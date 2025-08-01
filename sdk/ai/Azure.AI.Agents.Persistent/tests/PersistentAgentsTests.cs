﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.ClientModel;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.TestFramework;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.AI.Agents.Persistent.Tests
{
    public class PersistentAgentsTests : RecordedTestBase<AIAgentsTestEnvironment>
    {
        private const string AGENT_NAME = "cs_e2e_tests_client";
        private const string AGENT_NAME2 = "cs_e2e_tests_client2";
        private const string VCT_STORE_NAME = "cs_e2e_tests_vct_store";
        private const string FILE_NAME = "product_info_1.md";
        private const string FILE_NAME2 = "test_file.txt";
        private const string TEMP_DIR = "cs_e2e_temp_dir";

        private const string FILE_UPLOAD_CONSTRAINT = "The file is being uploaded as a multipart multipart/form-data, which cannot be recorded.";
        private const string STREAMING_CONSTRAINT = "The test framework does not support iteration of stream in Sync mode.";

        public PersistentAgentsTests(bool isAsync) : base(isAsync) {
            TestDiagnostics = false;
        }
        private class CompositeDisposable : IDisposable
        {
            private readonly List<IDisposable> _disposables = new List<IDisposable>();

            public CompositeDisposable(params IDisposable[] disposables)
            {
                for (int i = 0; i < disposables.Length; i++)
                {
                    _disposables.Add(disposables[i]);
                }
            }

            public void Dispose()
            {
                foreach (IDisposable d in _disposables)
                {
                    d?.Dispose();
                }
            }
        }

        public IDisposable SetTestSwitch()
        {
            return new CompositeDisposable(
            new TestAppContextSwitch(new() {
                { PersistentAgentsConstants.UseOldConnectionString, true.ToString() },
            }));
        }

        #region enumerations
        public enum ArgumentType
        {
            Metadata,
            Bytes,
            Stream
        }

        public enum VecrorStoreTestType
        {
            JustVectorStore,
            Batch,
            File
        }

        // We have to create this enum because AzureAISearchQueryType.Simple actually return a new object,
        // which cannot be used in TestCase
        public enum AzureAISearchQueryTypeEnum
        {
            Simple,
            Semantic,
            Vector,
            VectorSimpleHybrid,
            VectorSemanticHybrid
        }

        public Dictionary<AzureAISearchQueryTypeEnum, AzureAISearchQueryType> SearchQueryTypes = new()
        {
            { AzureAISearchQueryTypeEnum.Simple, AzureAISearchQueryType.Simple },
            { AzureAISearchQueryTypeEnum.Semantic, AzureAISearchQueryType.Semantic },
            { AzureAISearchQueryTypeEnum.Vector, AzureAISearchQueryType.Vector },
            { AzureAISearchQueryTypeEnum.VectorSimpleHybrid, AzureAISearchQueryType.VectorSimpleHybrid },
            { AzureAISearchQueryTypeEnum.VectorSemanticHybrid, AzureAISearchQueryType.VectorSemanticHybrid }
        };
        #endregion

        [RecordedTest]
        //Failing in CI due to no playback found
        //https://dev.azure.com/azure-sdk/public/_build/results?buildId=4622315&view=logs&j=91fc166b-5adf-5829-8c48-947d370143f5&t=b0549744-0856-5f62-f0ed-ab5057788140&l=1029
        //[TestCase(ArgumentType.Metadata)]
        //[TestCase(ArgumentType.Bytes)]
        [TestCase(ArgumentType.Stream)]
        public async Task TestCreatePersistentAgent(ArgumentType argType)
        {
            using var _ = SetTestSwitch();
            PersistentAgentsClient client = GetClient();
            string id;
            string name;
            if (argType == ArgumentType.Metadata)
            {
                Response<PersistentAgent> agentResponse = await client.Administration.CreateAgentAsync(
                model: "gpt-4",
                name: AGENT_NAME,
                instructions: "You are helpful agent."
                );
                id = agentResponse.Value.Id;
                name = agentResponse.Value.Name;
            }
            else
            {
                object objParams = new {
                    model = "gpt-4",
                    name = AGENT_NAME,
                    instructions = "You are helpful agent"
                };
                RequestContent content = argType == ArgumentType.Bytes?RequestContent.Create(GetBytes(objParams)): RequestContent.Create(GetStream(objParams));
                Response agentResponse = await client.Administration.CreateAgentAsync(content);
                id = GetFieldFromJson(agentResponse.Content, "id");
                name = GetFieldFromJson(agentResponse.Content, "name");
            }
            Assert.AreNotEqual(default, id);
            Assert.AreEqual(name, AGENT_NAME);
            Response<bool> delResponse = await client.Administration.DeleteAgentAsync(id);
            Assert.IsTrue(delResponse.Value);
        }

        [RecordedTest]
        [TestCase(ArgumentType.Metadata)]
        [TestCase(ArgumentType.Bytes)]
        [TestCase(ArgumentType.Stream)]
        public async Task TestUpdatePersistentAgent(ArgumentType argType)
        {
            using var _ = SetTestSwitch();
            PersistentAgentsClient client = GetClient();
            PersistentAgent agent = await GetAgent(client);
            string name = default;
            if (argType == ArgumentType.Metadata)
            {
                Response<PersistentAgent> agentResponse = await client.Administration.UpdateAgentAsync(
                assistantId: agent.Id,
                model: "gpt-4",
                name: AGENT_NAME2,
                instructions: "You are helpful agent."
                );
                name = agentResponse.Value.Name;
            }
            else
            {
                object objParams = new
                {
                    model = "gpt-4",
                    name = AGENT_NAME2,
                    instructions = "You are helpful agent"
                };
                RequestContent content = argType == ArgumentType.Bytes ? RequestContent.Create(GetBytes(objParams)) : RequestContent.Create(GetStream(objParams));
                Response agentResponse = await client.Administration.UpdateAgentAsync(agent.Id, content);
                name = GetFieldFromJson(agentResponse.Content, "name");
            }
            Assert.AreEqual(AGENT_NAME2, name);
        }

        [RecordedTest]
        public async Task TestListAgent()
        {
            using var _ = SetTestSwitch();
            PersistentAgentsClient client = GetClient();
            HashSet<string> ids = [];
            int initialAgentCount = await CountElementsAndRemoveIds(client, ids);
            PersistentAgent agent1 = await GetAgent(client, AGENT_NAME);
            ids = [agent1.Id];
            int count = await CountElementsAndRemoveIds(client, ids);
            Assert.AreEqual(0, ids.Count);
            Assert.AreEqual(initialAgentCount + 1, count);

            PersistentAgent agent2 = await GetAgent(client, AGENT_NAME2);
            ids.Add(agent1.Id);
            ids.Add(agent2.Id);
            count = await CountElementsAndRemoveIds(client, ids);
            Assert.AreEqual(0, ids.Count);
            Assert.AreEqual(initialAgentCount + 2, count);

            await DeleteAndAssert(client, agent1);
            ids.Add(agent1.Id);
            ids.Add(agent2.Id);
            count = await CountElementsAndRemoveIds(client, ids);
            Assert.AreEqual(1, ids.Count);
            Assert.False(ids.Contains(agent2.Id));
            Assert.AreEqual(initialAgentCount + 1, count);
            await DeleteAndAssert(client, agent2);
        }

        [RecordedTest]
        public async Task TestThreadPageable()
        {
            using var _ = SetTestSwitch();
            PersistentAgentsClient client = GetClient();
            PersistentAgent agent = await GetAgent(client, AGENT_NAME);
            AsyncPageable<PersistentAgentThread> pgThreads = client.Threads.GetThreadsAsync(limit: 2);
            // This test may take a long time if the number of threads is big.
            // The code below may e used to clean up the threads.
            //pgThreads = client.Threads.GetThreadsAsync(limit: 100);
            //List<PersistentAgentThread> del = await pgThreads.ToListAsync();
            //foreach (PersistentAgentThread thr in del)
            //{
            //    await client.Threads.DeleteThreadAsync(thr.Id);
            //    await Delay(5);
            //}
            //pgThreads = client.Threads.GetThreadsAsync(limit: 100);
            //Assert.AreEqual(0, (await pgThreads.ToListAsync()).Count);
            // End of cleanup code.
            int cntBefore = (await pgThreads.ToListAsync()).Count;
            PersistentAgentThread thr1 = await client.Threads.CreateThreadAsync();
            PersistentAgentThread thr2 = await client.Threads.CreateThreadAsync();
            PersistentAgentThread thr3 = await client.Threads.CreateThreadAsync();
            HashSet<string> threads = [thr1.Id, thr2.Id, thr3.Id];
            pgThreads = client.Threads.GetThreadsAsync(limit: 2);
            await foreach (Page<PersistentAgentThread> pg in pgThreads.AsPages())
            {
                Assert.LessOrEqual(pg.Values.Count, 2);
            }
            List<PersistentAgentThread> lstThreads = await client.Threads.GetThreadsAsync(limit: 2).ToListAsync();
            Assert.AreEqual(lstThreads.Count, cntBefore + 3);
            foreach (PersistentAgentThread thr in lstThreads)
                threads.Remove(thr.Id);
            Assert.AreEqual(threads.Count, 0, $"Some threads were not added: {threads.ToList()}");
            threads = [thr1.Id, thr2.Id, thr3.Id];
            Assert.True((await client.Threads.DeleteThreadAsync(thr1.Id)).Value);
            Assert.True((await client.Threads.DeleteThreadAsync(thr2.Id)).Value);
            Assert.True((await client.Threads.DeleteThreadAsync(thr3.Id)).Value);
            int cnt = 0;
            StringBuilder sbUndeleted = new();
            pgThreads = client.Threads.GetThreadsAsync(limit: 2);
            await foreach (PersistentAgentThread thr in pgThreads)
            {
                if (threads.Contains(thr.Id))
                    sbUndeleted.Append($" thr.Id");
                cnt++;
            }
            Assert.That(sbUndeleted.Length == 0, $"The threads{sbUndeleted.ToString()} were not deleted.");
            Assert.AreEqual(cntBefore, cnt);
        }

        [RecordedTest]
        [TestCase(ArgumentType.Metadata)]
        [TestCase(ArgumentType.Bytes)]
        [TestCase(ArgumentType.Stream)]
        public async Task TestCreateThread(ArgumentType argType)
        {
            using var _ = SetTestSwitch();
            PersistentAgentsClient client = GetClient();
            PersistentAgent agent = await GetAgent(client);

            string thread_id;
            IReadOnlyDictionary<string, string> metadata;
            if (argType == ArgumentType.Metadata)
            {
                Response<PersistentAgentThread> threadResponse = await client.Threads.CreateThreadAsync(
                    metadata: new Dictionary<string, string> {
                        {"key1", "value1"},
                        {"key2", "value2"}
                    });
                thread_id = threadResponse.Value.Id;
                metadata = threadResponse.Value.Metadata;
            }
            else
            {
                object data = new
                {
                    metadata = new
                    {
                        key1="value1",
                        key2="value2"
                    }
                };
                RequestContent content = argType == ArgumentType.Bytes ? RequestContent.Create(GetBytes(data)) : RequestContent.Create(GetStream(data));
                Response rawThreadResponse = await client.Threads.CreateThreadAsync(content);
                thread_id = GetFieldFromJson(rawThreadResponse.Content, "id");
                Response<PersistentAgentThread> threadResponse = await client.Threads.GetThreadAsync(thread_id);
                metadata = threadResponse.Value.Metadata;
            }
            Assert.AreNotEqual(default, thread_id);
            Assert.AreEqual(2, metadata.Count);

            // Test delete thread
            Response<bool> delResponse = await client.Threads.DeleteThreadAsync(thread_id);
            Assert.True(delResponse);
        }

        [RecordedTest]
        [TestCase(ArgumentType.Metadata)]
        [TestCase(ArgumentType.Bytes)]
        [TestCase(ArgumentType.Stream)]
        public async Task TestUpdateThread(ArgumentType argType)
        {
            using var _ = SetTestSwitch();
            PersistentAgentsClient client = GetClient();
            PersistentAgentThread thread = await GetThread(client);
            Assert.AreEqual(0, thread.Metadata.Count);

            if (argType == ArgumentType.Metadata)
            {
                //"metadata": {"key1": "value1", "key2": "value2"},
                await client.Threads.UpdateThreadAsync(
                    thread.Id,
                    metadata: new Dictionary<string, string> {
                        {"key1", "value1"},
                        {"key2", "value2"}
                    });
            }
            else
            {
                object data = new
                {
                    metadata = new
                    {
                        key1 = "value1",
                        key2 = "value2"
                    }
                };
                RequestContent content = argType == ArgumentType.Bytes ? RequestContent.Create(GetBytes(data)) : RequestContent.Create(GetStream(data));
                await client.Threads.UpdateThreadAsync(thread.Id, content);
            }

            // Test get thread
            Response<PersistentAgentThread> getThreadResponse = await client.Threads.GetThreadAsync(thread.Id);
            thread = getThreadResponse.Value;
            Assert.AreNotEqual(default, thread.Id);
            Assert.AreEqual(2, thread.Metadata.Count);

            // Test delete thread
            Response<bool> delResponse = await client.Threads.DeleteThreadAsync(thread.Id);
            Assert.True(delResponse);
        }

        [RecordedTest]
        [TestCase(ArgumentType.Metadata)]
        [TestCase(ArgumentType.Bytes)]
        [TestCase(ArgumentType.Stream)]
        public async Task TestCreateMessage(ArgumentType argType)
        {
            using var _ = SetTestSwitch();
            PersistentAgentsClient client = GetClient();
            PersistentAgentThread thread = await GetThread(client);
            PersistentThreadMessage tmTest;
            string message = "Hello, tell me a joke";
            if (argType == ArgumentType.Metadata)
            {
                Response<PersistentThreadMessage> msg = await client.Messages.CreateMessageAsync(thread.Id, MessageRole.User, message);
                tmTest = msg.Value;
            }
            else
            {
                object data = new
                {
                    role = "user",
                    content = message
                };
                RequestContent content = argType == ArgumentType.Bytes ? RequestContent.Create(GetBytes(data)) : RequestContent.Create(GetStream(data));
                Response rawMsg = await client.Messages.CreateMessageAsync(thread.Id, content);
                Response<PersistentThreadMessage> msg = await client.Messages.GetMessageAsync(thread.Id, GetFieldFromJson(rawMsg.Content, "id"));
                tmTest = msg.Value;
            }
            Assert.AreEqual(1, tmTest.ContentItems.Count);
            Assert.IsTrue(tmTest.ContentItems[0] is MessageTextContent text);
            Assert.AreEqual(message, ((MessageTextContent)tmTest.ContentItems[0]).Text);
        }

        [RecordedTest]
        [TestCase(ArgumentType.Metadata)]
        [TestCase(ArgumentType.Bytes)]
        [TestCase(ArgumentType.Stream)]
        public async Task TestUpdateMessage(ArgumentType argType)
        {
            using var _ = SetTestSwitch();
            PersistentAgentsClient client = GetClient();
            PersistentAgentThread thread = await GetThread(client);
            PersistentThreadMessage tmTest;
            Response<PersistentThreadMessage> oldMsgResp = await client.Messages.CreateMessageAsync(
                thread.Id,
                MessageRole.User,
                "Hello, tell me a joke");
            Assert.AreEqual(0, oldMsgResp.Value.Metadata.Count);
            if (argType == ArgumentType.Metadata)
            {
                Response<PersistentThreadMessage> msg = await client.Messages.UpdateMessageAsync(thread.Id, oldMsgResp.Value.Id, metadata: new Dictionary<string, string> {
                        {"key1", "value1"},
                        {"key2", "value2"}
                });
                tmTest = msg.Value;
            }
            else
            {
                object data = new
                {
                    metadata = new
                    {
                        key1 = "value1",
                        key2 = "value2"
                    }
                };
                RequestContent content = argType == ArgumentType.Bytes ? RequestContent.Create(GetBytes(data)) : RequestContent.Create(GetStream(data));
                Response rawMsg = await client.Messages.UpdateMessageAsync(thread.Id, oldMsgResp.Value.Id, content);
                Response<PersistentThreadMessage> msg = await client.Messages.GetMessageAsync(thread.Id, GetFieldFromJson(rawMsg.Content, "id"));
                tmTest = msg.Value;
            }
            Assert.AreEqual(2, tmTest.Metadata.Count);
        }

        [RecordedTest]
        public async Task TestListMessage()
        {
            using var _ = SetTestSwitch();
            PersistentAgentsClient client = GetClient();
            PersistentAgentThread thread = await GetThread(client);
            AsyncPageable<PersistentThreadMessage> msgResp = client.Messages.GetMessagesAsync(thread.Id);
            Assert.False(await msgResp.AnyAsync());

            HashSet<string> ids = new();
            PersistentThreadMessage msg1 = await client.Messages.CreateMessageAsync(thread.Id, MessageRole.User, "foo");
            ids.Add(msg1.Id);
            msgResp = client.Messages.GetMessagesAsync(thread.Id);
            await foreach (PersistentThreadMessage msg in msgResp)
            {
                ids.Remove(msg.Id);
            }
            Assert.AreEqual(0, ids.Count);
            Assert.AreEqual(1, (await msgResp.ToListAsync()).Count);

            PersistentThreadMessage msg2 = await client.Messages.CreateMessageAsync(thread.Id, MessageRole.User, "bar");
            ids.Add(msg1.Id);
            ids.Add(msg2.Id);
            msgResp = client.Messages.GetMessagesAsync(thread.Id);
            await foreach (PersistentThreadMessage msg in msgResp)
            {
                ids.Remove(msg.Id);
            }
            Assert.AreEqual(0, ids.Count);
            Assert.AreEqual(2, (await msgResp.ToListAsync()).Count);
        }

        [RecordedTest]
        public async Task TestListAgentsAfterAndBefore()
        {
            using var _ = SetTestSwitch();
            PersistentAgentsClient client = GetClient();
            // In this test we are assuming that workspace has more then 10 agents.
            // If it is not the case create these agents.
            int agentLimit = 10;
            AsyncPageable<PersistentAgent> agents = client.Administration.GetAgentsAsync(limit: 100, order: ListSortOrder.Ascending);
            List<string> ids = await agents.Select(x => x.Id).ToListAsync();
            if (ids.Count < agentLimit)
            {
                for (int i = ids.Count; i < agentLimit; i++)
                {
                    PersistentAgentThread thread = await client.Threads.CreateThreadAsync();
                    ids.Add((await GetAgent(client)).Id);
                }
            }
            // Test calling before.
            agents = client.Administration.GetAgentsAsync(before: ids[4], limit: 2, order: ListSortOrder.Ascending);
            int idNum = 0;
            await foreach (PersistentAgent agent in agents)
            {
                Assert.AreEqual(ids[idNum], agent.Id, $"The ID #{idNum} is incorrect.");
                idNum++;
            }
            Assert.AreEqual(idNum, 4);
            // Test calling after.
            agents = client.Administration.GetAgentsAsync(after: ids[idNum - 1], limit: 2, order: ListSortOrder.Ascending);
            await foreach (PersistentAgent agent in agents)
            {
                Assert.AreEqual(ids[idNum], agent.Id, $"The ID #{idNum} is incorrect.");
                idNum++;
                agentLimit--;
                if (agentLimit <= 0)
                    break;
            }
        }

        [RecordedTest]
        public async Task TestListThreadsAfterAndBefore()
        {
            using var _ = SetTestSwitch();
            PersistentAgentsClient client = GetClient();
            // In this test we are assuming that workspace has more then 10 threads.
            // If it is not the case create these threads.
            int threadLimit = 10;
            AsyncPageable<PersistentAgentThread> threads = client.Threads.GetThreadsAsync(limit: 100, order: ListSortOrder.Ascending);
            List<string> ids = await threads.Select(x => x.Id).ToListAsync();
            if (ids.Count < threadLimit)
            {
                for (int i = ids.Count; i < threadLimit; i++)
                {
                    PersistentAgentThread thread = await client.Threads.CreateThreadAsync();
                    ids.Add(thread.Id);
                }
            }
            // Test calling before.
            threads = client.Threads.GetThreadsAsync(before: ids[4], limit: 2, order: ListSortOrder.Ascending);
            int idNum = 0;
            await foreach (PersistentAgentThread thread in threads)
            {
                Assert.AreEqual(ids[idNum], thread.Id, $"The ID #{idNum} is incorrect.");
                idNum++;
            }
            Assert.AreEqual(idNum, 4);
            // Test calling after.
            threads = client.Threads.GetThreadsAsync(after: ids[idNum-1], limit: 2, order: ListSortOrder.Ascending);
            await foreach (PersistentAgentThread thread in threads)
            {
                Assert.AreEqual(ids[idNum], thread.Id, $"The ID #{idNum} is incorrect.");
                idNum++;
                threadLimit--;
                if (threadLimit <= 0)
                    break;
            }
        }

        [RecordedTest]
        public async Task TestListVectorStoresAfterAndBefore()
        {
            using var _ = SetTestSwitch();
            PersistentAgentsClient client = GetClient();
            // In this test we are assuming that workspace has more then 10 threads.
            // If it is not the case create these threads.
            int storeLimit = 10;
            AsyncPageable<PersistentAgentsVectorStore> vctStores = client.VectorStores.GetVectorStoresAsync(limit: 100, order: ListSortOrder.Ascending);
            List<string> ids = await vctStores.Select(x => x.Id).ToListAsync();
            if (ids.Count < storeLimit)
            {
                for (int i = ids.Count; i < storeLimit; i++)
                {
                    PersistentAgentsVectorStore vct = await client.VectorStores.CreateVectorStoreAsync(name: VCT_STORE_NAME);
                    ids.Add(vct.Id);
                }
            }
            // Test calling before.
            vctStores = client.VectorStores.GetVectorStoresAsync(before: ids[4], limit: 2, order: ListSortOrder.Ascending);
            int idNum = 0;
            await foreach (PersistentAgentsVectorStore vct in vctStores)
            {
                Assert.AreEqual(ids[idNum], vct.Id, $"The ID #{idNum} is incorrect.");
                idNum++;
            }
            Assert.AreEqual(idNum, 4);
            // Test calling after.
            vctStores = client.VectorStores.GetVectorStoresAsync(after: ids[idNum - 1], limit: 2, order: ListSortOrder.Ascending);
            await foreach (PersistentAgentsVectorStore vct in vctStores)
            {
                Assert.AreEqual(ids[idNum], vct.Id, $"The ID #{idNum} is incorrect.");
                idNum++;
                storeLimit--;
                if (storeLimit <= 0)
                    break;
            }
        }

        [RecordedTest]
        public async Task TestListRunsAfterAndBefore()
        {
            using var _ = SetTestSwitch();
            PersistentAgentsClient client = GetClient();
            PersistentAgentThread thread = await GetThread(client);
            PersistentAgent agent = await GetAgent(client);
            PersistentThreadMessage message = await client.Messages.CreateMessageAsync(
                threadId: thread.Id,
                role: MessageRole.User,
                content: "What is the mass of the Sun?"
            );
            int runLimit = 5;
            string[] ids = new string[runLimit];
            for (int i = 0; i < runLimit; i++)
            {
                ThreadRun run = await client.Runs.CreateRunAsync(thread, agent);
                await WaitForRun(client: client, run: run);
                ids[i] = run.Id;
            }
            // Test calling before.
            AsyncPageable<ThreadRun> runs = client.Runs.GetRunsAsync(threadId:thread.Id, before: ids[2], limit: 1, order: ListSortOrder.Ascending);
            int idNum = 0;
            await foreach (ThreadRun run in runs)
            {
                Assert.AreEqual(ids[idNum], run.Id, $"The ID #{idNum} is incorrect.");
                idNum++;
            }
            Assert.AreEqual(idNum, 2);
            // Test calling after.
            runs = client.Runs.GetRunsAsync(threadId: thread.Id, after: ids[idNum - 1], limit: 1, order: ListSortOrder.Ascending);
            await foreach (ThreadRun run in runs)
            {
                Assert.AreEqual(ids[idNum], run.Id, $"The ID #{idNum} is incorrect.");
                idNum++;
            }
            client.Threads.DeleteThread(threadId: thread.Id);
        }

        [RecordedTest]
        public async Task TestMultipleAgentTool()
        {
            PersistentAgentsClient client = GetClient();
            PersistentAgent weatherAgent = await GetAgent(
                client: client,
                agentName: "weather-bot",
                instruction: "Your job is to get the weather for a given location. " +
                              "Always return 50F Cloudy when asked about weather in Seattle"
            );

            // NOTE: To reuse existing agent, fetch it with agentClient.Administration.GetAgent(agentId)
            PersistentAgent stockPriceAgent = await GetAgent(
                client: client,
                agentName: "stock-price-bot",
                instruction: "Your job is to get the stock price of a company. If asked for the Microsoft stock price, always return $350.");
            ConnectedAgentToolDefinition stockPriceConnectedAgentTool = new(
                new ConnectedAgentDetails(
                    id: stockPriceAgent.Id,
                    name: "stock_price_bot",
                    description: "Gets the stock price of a company"
                )
            );

            ConnectedAgentToolDefinition weatherConnectedAgentTool = new(
                new ConnectedAgentDetails(
                    id: weatherAgent.Id,
                    name: "weather_bot",
                    description: "Gets the weather for a given location"
                )
            );
            PersistentAgent agent = await GetAgent(
               client: client,
               agentName: "my-assistant",
               instruction: "You are a helpful assistant, and use the connected agents to get stock prices and weather.",
               tools: [stockPriceConnectedAgentTool, weatherConnectedAgentTool]);

            // Create thread for communication
            PersistentAgentThread thread = await client.Threads.CreateThreadAsync();

            // Create message to thread
            PersistentThreadMessage message = await client.Messages.CreateMessageAsync(
                thread.Id,
                MessageRole.User,
                "What is the stock price of Microsoft and the weather in Seattle?");

            // Run the agent
            ThreadRun run = client.Runs.CreateRun(thread, agent);
            run = await WaitForRun(client, run);

            // Check run steps
            List<string> ids = await client.Runs.GetRunStepsAsync(run, order: ListSortOrder.Ascending).Select(x => x.Id).ToListAsync();
            Assert.AreEqual(ids.Count, 3);

            // Check steps before
            List<RunStep> steps = await client.Runs.GetRunStepsAsync(run, before: ids[1], order: ListSortOrder.Ascending).ToListAsync();
            Assert.AreEqual(1, steps.Count);
            Assert.AreEqual(steps[0].Id, ids[0]);

            // Check steps after
            steps = await client.Runs.GetRunStepsAsync(run, after: ids[0], order: ListSortOrder.Ascending).ToListAsync();
            Assert.AreEqual(2, steps.Count);
            Assert.AreEqual(steps[0].Id, ids[1]);
            Assert.AreEqual(steps[1].Id, ids[2]);

            List<PersistentThreadMessage> messages = await client.Messages.GetMessagesAsync(
                threadId: run.ThreadId,
                runId: run.Id,
                order: ListSortOrder.Ascending
            ).ToListAsync();
            Assert.Greater(messages.Count, 0);

            // NOTE: Comment out these four lines if you plan to reuse the agent later.
            client.Threads.DeleteThread(threadId: thread.Id);
        }

        [RecordedTest]
        public async Task TestListMessageAfterAndBefore()
        {
            using var _ = SetTestSwitch();
            PersistentAgentsClient client = GetClient();
            PersistentAgentThread thread = await GetThread(client);

            string[] ids = new string[9];
            for (int i = 0; i < 9; i++)
            {
                PersistentThreadMessage msg1 = await client.Messages.CreateMessageAsync(thread.Id, MessageRole.User, "foo");
                ids[i] = msg1.Id;
            }
            // Test calling before.
            AsyncPageable<PersistentThreadMessage> msgResp = client.Messages.GetMessagesAsync(thread.Id, before: ids[4], limit:2, order:ListSortOrder.Ascending);
            int idNum = 0;
            await foreach (PersistentThreadMessage msg in msgResp)
            {
                Assert.AreEqual(ids[idNum], msg.Id, $"The ID #{idNum} is incorrect.");
                idNum++;
            }
            Assert.AreEqual(idNum, 4);
            // Test calling after.
            msgResp = client.Messages.GetMessagesAsync(thread.Id, after: ids[idNum - 1], limit: 2, order: ListSortOrder.Ascending);
            await foreach (PersistentThreadMessage msg in msgResp)
            {
                Assert.AreEqual(ids[idNum], msg.Id, $"The ID #{idNum} is incorrect.");
                idNum++;
            }
        }

        [RecordedTest]
        public async Task TestListVectorStoreFilesAfterAndBefore()
        {
            using var _ = SetTestSwitch();
            PersistentAgentsClient client = GetClient();
            int storeLimit = 10;
            List<VectorStoreDataSource> sources = [];
            for (int i = 0; i < storeLimit; i++)
            {
                sources.Add(new(
                    assetIdentifier: TestEnvironment.AZURE_BLOB_URI,
                    assetType: VectorStoreDataSourceAssetType.UriAsset
                ));
            }
            VectorStoreConfiguration storeConf = new(
                sources
            );
            PersistentAgentsVectorStore vct = await client.VectorStores.CreateVectorStoreAsync(
                name: VCT_STORE_NAME,
                storeConfiguration: storeConf
            );
            List<string> ids = await client.VectorStores.GetVectorStoreFilesAsync(vectorStoreId: vct.Id, order: ListSortOrder.Ascending).Select(x => x.Id).ToListAsync();
            AsyncPageable<VectorStoreFile> files = client.VectorStores.GetVectorStoreFilesAsync(
                vectorStoreId: vct.Id,
                limit: 2,
                order: ListSortOrder.Ascending,
                before: ids[4]
            );
            int idNum = 0;
            await foreach (VectorStoreFile fle in files)
            {
                Assert.AreEqual(ids[idNum], fle.Id, $"The ID #{idNum} is incorrect.");
                idNum++;
            }
            Assert.AreEqual(idNum, 4);
            // Test calling after.
            files = client.VectorStores.GetVectorStoreFilesAsync(
                vectorStoreId: vct.Id,
                limit: 2,
                order: ListSortOrder.Ascending,
                after: ids[idNum-1]
            );
            await foreach (VectorStoreFile fle in files)
            {
                Assert.AreEqual(ids[idNum], fle.Id, $"The ID #{idNum} is incorrect.");
                idNum++;
            }
        }

        [RecordedTest]
        public async Task TestListVectorStoreFileBatchesAfterAndBefore()
        {
            using var _ = SetTestSwitch();
            PersistentAgentsClient client = GetClient();
            int storeLimit = 10;
            List<VectorStoreDataSource> sources = [];
            IReadOnlyList<PersistentAgentFileInfo> uploadedFiles = (await client.Files.GetFilesAsync()).Value;
            List<string> fileIds = [];
            // This test requires the number of uploaded files to be not less then ten.
            // The code below ill do it, however, th test will require re-recording as file upload
            // is not handled properly by the recording system.
            // Q: Why cannot we use the Enterprise file search as in TestListVectorStoreFilesAfterAndBefore?
            // A: Only one data source configuration may be uploaded at this time.
            if (uploadedFiles.Count < storeLimit)
            {
                for (int i = uploadedFiles.Count; i < storeLimit; i++)
                    await client.Files.UploadFileAsync(GetFile(), PersistentAgentFilePurpose.Agents);
                uploadedFiles = (await client.Files.GetFilesAsync()).Value;
            }
            for (int i = 0; i < storeLimit; i++)
            {
                fileIds.Add(uploadedFiles[i].Id);
            }
            PersistentAgentsVectorStore vct = await client.VectorStores.CreateVectorStoreAsync(
                name: VCT_STORE_NAME
            );
            VectorStoreFileBatch batch = await client.VectorStores.CreateVectorStoreFileBatchAsync(
                vectorStoreId: vct.Id,
                fileIds: fileIds
            );
            batch = await WaitForBatch(client, vct.Id, batch);

            List<string> ids = await client.VectorStores.GetVectorStoreFileBatchFilesAsync(vectorStoreId: vct.Id, batchId: batch.Id, order: ListSortOrder.Ascending).Select(x => x.Id).ToListAsync();
            AsyncPageable<VectorStoreFile> files = client.VectorStores.GetVectorStoreFileBatchFilesAsync(
                vectorStoreId: vct.Id,
                batchId: batch.Id,
                limit: 2,
                order: ListSortOrder.Ascending,
                before: ids[4]
            );
            int idNum = 0;
            await foreach (VectorStoreFile fle in files)
            {
                Assert.AreEqual(ids[idNum], fle.Id, $"The ID #{idNum} is incorrect.");
                idNum++;
            }
            Assert.AreEqual(4, idNum);
            // Test calling after.
            files = client.VectorStores.GetVectorStoreFileBatchFilesAsync(
                vectorStoreId: vct.Id,
                batchId: batch.Id,
                limit: 2,
                order: ListSortOrder.Ascending,
                after: ids[idNum - 1]
            );
            await foreach (VectorStoreFile fle in files)
            {
                Assert.AreEqual(ids[idNum], fle.Id, $"The ID #{idNum} is incorrect.");
                idNum++;
            }
        }

        [RecordedTest]
        [TestCase(ArgumentType.Metadata)]
        [TestCase(ArgumentType.Bytes)]
        [TestCase(ArgumentType.Stream)]
        public async Task TestCreateRun(ArgumentType argType)
        {
            using var _ = SetTestSwitch();
            PersistentAgentsClient client = GetClient();
            PersistentAgent agent = await GetAgent(client);
            PersistentAgentThread thread = await GetThread(client);
            await client.Messages.CreateMessageAsync(thread.Id, MessageRole.User, "Hello, tell me a joke");
            ThreadRun result;
            if (argType == ArgumentType.Metadata)
            {
                Response<ThreadRun> runResp = await client.Runs.CreateRunAsync(thread.Id, agent.Id);
                result = runResp.Value;
            }
            else
            {
                object data = new
                {
                    assistant_id = agent.Id
                };
                RequestContent content = argType == ArgumentType.Bytes ? RequestContent.Create(GetBytes(data)) : RequestContent.Create(GetStream(data));
                Response rawRun = await client.Runs.CreateRunAsync(thread.Id, content);
                Response<ThreadRun> resResp = await client.Runs.GetRunAsync(thread.Id, GetFieldFromJson(rawRun.Content, "id"));
                result = resResp.Value;
            }
            Assert.AreEqual(agent.Id, result.AssistantId);
            Assert.AreEqual(thread.Id, result.ThreadId);
            //  Check run status
            result = await WaitForRun(client, result);
            AsyncPageable<PersistentThreadMessage> msgResp = client.Messages.GetMessagesAsync(thread.Id);
            List<PersistentThreadMessage> messages = await msgResp.ToListAsync();
            Assert.AreEqual(2, messages.Count);

            Assert.AreEqual(MessageRole.Agent, messages[0].Role);
            Assert.AreEqual(MessageRole.User, messages[1].Role);
            // Get Run steps
            AsyncPageable<RunStep> steps = client.Runs.GetRunStepsAsync(result);
            List<RunStep> stepsList = await steps.ToListAsync();
            Assert.GreaterOrEqual(stepsList.Count, 1);
            RunStep step = await client.Runs.GetRunStepAsync(result.ThreadId, result.Id, stepsList[0].Id);
            Assert.AreEqual(stepsList[0].Id, step.Id);
        }

        [RecordedTest]
        public async Task TestCreateThreadAndRun()
        {
            using var _ = SetTestSwitch();
            PersistentAgentsClient client = GetClient();
            PersistentAgent agent = await GetAgent(client);
            ThreadRun result;
            var threadOp = new PersistentAgentThreadCreationOptions();
            threadOp.Messages.Add(new ThreadMessageOptions(
                role: MessageRole.User,
                content: "Hello, tell me a joke"
            ));
            var opts = new ThreadAndRunOptions()
            {
                ThreadOptions=threadOp,
                Metadata=new Dictionary<string, string> {
                    { "key1", "value1"},
                    { "key2", "value2"}
                }
            };
            result = await client.CreateThreadAndRunAsync(
                assistantId: agent.Id,
                opts
            );
            Assert.AreEqual(agent.Id, result.AssistantId);
            //  Check run status
            result = await WaitForRun(client, result);
            AsyncPageable<PersistentThreadMessage> msgResp = client.Messages.GetMessagesAsync(result.ThreadId);
            List<PersistentThreadMessage> data = await msgResp.ToListAsync();
            Assert.AreEqual(2, data.Count);
            Assert.AreEqual(MessageRole.Agent, data[0].Role);
            Assert.AreEqual(MessageRole.User, data[1].Role);
        }

        [RecordedTest]
        [TestCase(ArgumentType.Metadata)]
        [TestCase(ArgumentType.Bytes)]
        [TestCase(ArgumentType.Stream)]
        public async Task TestUpdateRun(ArgumentType argType)
        {
            PersistentAgentsClient client = GetClient();
            PersistentAgent agent = await GetAgent(client);
            PersistentAgentThread thread = await GetThread(client);
            await client.Messages.CreateMessageAsync(thread.Id, MessageRole.User, "Hello, tell me a joke");
            ThreadRun  runResp = await client.Runs.CreateRunAsync(thread.Id, agent.Id);
            runResp = await WaitForRun(client, runResp);
            Assert.AreEqual(0, runResp.Metadata.Count);
            if (argType == ArgumentType.Metadata)
            {
                runResp = await client.Runs.UpdateRunAsync(
                    threadId: thread.Id,
                    runId: runResp.Id,
                    metadata: new Dictionary<string, string> {
                            { "key1", "value1"},
                            { "key2", "value2"}
                        }
                    );
            }
            else
            {
                object data = new
                {
                    metadata = new
                    {
                        key1 = "value1",
                        key2 = "value2"
                    }
                };
                RequestContent content = argType == ArgumentType.Bytes ? RequestContent.Create(GetBytes(data)) : RequestContent.Create(GetStream(data));
                Response rawRun = await client.Runs.UpdateRunAsync(thread.Id, runResp.Id, content);
                runResp = await client.Runs.GetRunAsync(thread.Id, GetFieldFromJson(rawRun.Content, "id"));
            }
            Assert.AreEqual(2, runResp.Metadata.Count);
        }

        [RecordedTest]
        public async Task ListDeleteRuns()
        {
            using var _ = SetTestSwitch();
            PersistentAgentsClient client = GetClient();
            PersistentAgent agent = await GetAgent(client);
            PersistentAgentThread thread = await GetThread(client);
            await client.Messages.CreateMessageAsync(thread.Id, MessageRole.User, "Hello, tell me a joke");
            ThreadRun runResp1 = await client.Runs.CreateRunAsync(thread.Id, agent.Id);
            runResp1 = await WaitForRun(client, runResp1);
            ThreadRun runResp2 = await client.Runs.CreateRunAsync(thread.Id, agent.Id);
            runResp2 = await WaitForRun(client, runResp2);
            AsyncPageable<ThreadRun> runsResp = client.Runs.GetRunsAsync(thread.Id, limit: 1);
            Assert.True(await runsResp.AnyAsync());
            runsResp = client.Runs.GetRunsAsync(thread.Id);
            List<ThreadRun> data = await runsResp.ToListAsync();
            Assert.AreEqual(2, data.Count);
            HashSet<string> ids = [data[0].Id, data[1].Id];
            await foreach (ThreadRun rn in runsResp)
            {
                ids.Remove(rn.Id);
            }
            Assert.AreEqual(0, ids.Count);
        }

        [RecordedTest]
        [TestCase(ArgumentType.Metadata, true, false)]
        [TestCase(ArgumentType.Bytes, true, false)]
        [TestCase(ArgumentType.Stream, false, false)]
        [TestCase(ArgumentType.Metadata, true, true)]
        [TestCase(ArgumentType.Metadata, false, true)]
        public async Task TestSubmitToolOutputs(ArgumentType argType, bool parallelToolCalls, bool CreateThreadAndRun)
        {
            using var _ = SetTestSwitch();
            PersistentAgentsClient client = GetClient();
            FunctionToolDefinition getFavouriteNameTool = new(
                name: "getFavouriteWord",
                description: "Gets the favourite word of the person.",
                parameters: BinaryData.FromObjectAsJson(
                    new
                    {
                        Type = "object",
                        Properties = new
                        {
                            Name = new
                            {
                                Type = "string",
                                Description = "The name of the person.",
                            },
                        },
                        Required = new[] { "name" },
                    },
                    new JsonSerializerOptions() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase }));
            PersistentAgent agent = await client.Administration.CreateAgentAsync(
                model: "gpt-4",
                name: AGENT_NAME,
                instructions: "Use the provided functions to help answer questions.",
                tools: new List<ToolDefinition> { getFavouriteNameTool }
            );
            ThreadRun toolRun;
            if (CreateThreadAndRun)
            {
                var threadOp = new PersistentAgentThreadCreationOptions();
                threadOp.Messages.Add(new ThreadMessageOptions(
                    role: MessageRole.User,
                    content: "Tell me the favourite word of Mike?"
                ));
                var opts = new ThreadAndRunOptions()
                {
                    ThreadOptions = threadOp,
                    ParallelToolCalls = parallelToolCalls
                };
                toolRun = await client.CreateThreadAndRunAsync(
                    assistantId: agent.Id,
                    options: opts
                );
            }
            else
            {
                PersistentAgentThread thread = await GetThread(client);
                await client.Messages.CreateMessageAsync(thread.Id, MessageRole.User, "Tell me the favourite word of Mike?");
                toolRun = await client.Runs.CreateRunAsync(
                    threadId: thread.Id,
                    assistantId: agent.Id,
                    parallelToolCalls: parallelToolCalls
                    );
            }
            bool functionCalled = false;
            do
            {
                await Task.Delay(TimeSpan.FromMilliseconds(500));
                toolRun = await client.Runs.GetRunAsync(toolRun.ThreadId, toolRun.Id);
                if (toolRun.Status == RunStatus.RequiresAction && toolRun.RequiredAction is SubmitToolOutputsAction submitToolOutputsAction)
                {
                    List<ToolOutput> toolOutputs = new();
                    Assert.AreEqual(1, submitToolOutputsAction.ToolCalls.Count);
                    functionCalled = true;
                    if (submitToolOutputsAction.ToolCalls[0] is RequiredFunctionToolCall functionToolCall)
                    {
                        using JsonDocument argumentsJson = JsonDocument.Parse(functionToolCall.Arguments);
                        string nameArgument = argumentsJson.RootElement.GetProperty("name").GetString();
                        Assert.AreEqual(0, string.Compare(nameArgument, "mike", true));
                        toolOutputs.Add(new ToolOutput(submitToolOutputsAction.ToolCalls[0], "bar"));
                    }
                    else
                    {
                        Assert.Fail("The toolCall is of a wrong type.");
                    }
                    if (argType == ArgumentType.Metadata)
                    {
                        toolRun = await client.Runs.SubmitToolOutputsToRunAsync(toolRun, toolOutputs);
                    }
                    else
                    {
                        object objToolOutput = new
                        {
                            tool_outputs = new object[] {
                                new {
                                    tool_call_id = toolOutputs[0].ToolCallId,
                                    output = toolOutputs[0].Output
                                }
                            }
                        };
                        RequestContent content = argType == ArgumentType.Bytes ? RequestContent.Create(GetBytes(objToolOutput)) : RequestContent.Create(GetStream(objToolOutput));
                        await client.Runs.SubmitToolOutputsToRunAsync(toolRun.ThreadId, toolRun.Id, content);
                        toolRun = await client.Runs.GetRunAsync(toolRun.ThreadId, toolRun.Id);
                    }
                }
            }
            while (toolRun.Status == RunStatus.Queued
                || toolRun.Status == RunStatus.InProgress
                || toolRun.Status == RunStatus.RequiresAction);
            Assert.AreEqual(RunStatus.Completed, toolRun.Status, message: toolRun.LastError?.Message);
            Assert.True(functionCalled);
            AsyncPageable<PersistentThreadMessage> messages = client.Messages.GetMessagesAsync(toolRun.ThreadId, toolRun.Id);
            List<PersistentThreadMessage> messagesList = await messages.ToListAsync();
            Assert.GreaterOrEqual(messagesList.Count, 1);
            Assert.AreEqual(parallelToolCalls, toolRun.ParallelToolCalls);
        }

        [RecordedTest]
        [TestCase(VecrorStoreTestType.JustVectorStore, true, false)]
        [TestCase(VecrorStoreTestType.Batch, true, false)]
        [TestCase(VecrorStoreTestType.File, true, false)]
        [TestCase(VecrorStoreTestType.JustVectorStore, false, false)]
        [TestCase(VecrorStoreTestType.Batch, false, false)]
        [TestCase(VecrorStoreTestType.File, false, false)]
        [TestCase(VecrorStoreTestType.JustVectorStore, true, true)]
        [TestCase(VecrorStoreTestType.Batch, true, true)]
        [TestCase(VecrorStoreTestType.File, true, true)]
        [TestCase(VecrorStoreTestType.JustVectorStore, false, true)]
        [TestCase(VecrorStoreTestType.Batch, false, true)]
        [TestCase(VecrorStoreTestType.File, false, true)]
        public async Task TestCreateVectorStore(VecrorStoreTestType testType, bool useFileSource, bool useStreaming)
        {
            using var _ = SetTestSwitch();
            if (useFileSource && Mode != RecordedTestMode.Live)
                Assert.Inconclusive(FILE_UPLOAD_CONSTRAINT);
            if (useStreaming && !IsAsync)
                Assert.Inconclusive(STREAMING_CONSTRAINT);
            PersistentAgentsClient client = GetClient();
            PersistentAgentsVectorStore vectorStore;

            PersistentAgentFileInfo fileDataSource = null;
            VectorStoreDataSource vectorStoreDataSource = null;
            VectorStoreConfiguration vectorStoreConf = null;
            List<string> fileIds = null;
            if (useFileSource)
            {
                fileDataSource = await client.Files.UploadFileAsync(GetFile(), PersistentAgentFilePurpose.Agents);
                fileIds = [ fileDataSource.Id ];
            }
            else
            {
                vectorStoreDataSource = new VectorStoreDataSource(
                    assetIdentifier: TestEnvironment.AZURE_BLOB_URI,
                    assetType: VectorStoreDataSourceAssetType.UriAsset
                );
                vectorStoreConf = new VectorStoreConfiguration(
                    dataSources: [ vectorStoreDataSource ]
                );
            }
            if (testType == VecrorStoreTestType.JustVectorStore)
            {
                vectorStore = await client.VectorStores.CreateVectorStoreAsync(
                    name: VCT_STORE_NAME,
                    storeConfiguration: vectorStoreConf,
                    fileIds: fileIds
                );
            }
            else
            {
                vectorStore = await client.VectorStores.CreateVectorStoreAsync(
                    name: VCT_STORE_NAME
                );
                if (testType == VecrorStoreTestType.Batch)
                {
                    await client.VectorStores.CreateVectorStoreFileBatchAsync(
                        vectorStoreId: vectorStore.Id,
                        dataSources: vectorStoreConf?.DataSources,
                        fileIds: fileIds
                        );
                }
                else
                {
                    await client.VectorStores.CreateVectorStoreFileAsync(
                        vectorStoreId: vectorStore.Id,
                        dataSource: vectorStoreConf?.DataSources[0],
                        fileId: fileDataSource?.Id
                        );
                }
            }
            // Test file search
            FileSearchToolResource fileSearchToolResource = new FileSearchToolResource();
            fileSearchToolResource.VectorStoreIds.Add(vectorStore.Id);
            PersistentAgent agent = await client.Administration.CreateAgentAsync(
                model: "gpt-4",
                name: "SDK Test Agent - Retrieval",
                instructions: "You are a helpful agent that can help fetch data from files you know about.",
                tools: new List<ToolDefinition> { new FileSearchToolDefinition() },
                toolResources: new ToolResources() { FileSearch = fileSearchToolResource });
            var threadOp = new PersistentAgentThreadCreationOptions();
            threadOp.Messages.Add(new ThreadMessageOptions(
                role: MessageRole.User,
                content: "What does the attachment say?"
            ));
            ThreadRun fileSearchRun = default;
            if (useStreaming)
            {
                PersistentAgentThread thread = await client.Threads.CreateThreadAsync(messages: [new ThreadMessageOptions(
                    role: MessageRole.User,
                    content: "What does the attachment say?"
                )]);
                await foreach (StreamingUpdate streamingUpdate in client.Runs.CreateRunStreamingAsync(thread.Id, agent.Id))
                {
                    if (streamingUpdate is RunUpdate runUpdate)
                        fileSearchRun = runUpdate.Value;
                }
                Assert.AreEqual(RunStatus.Completed, fileSearchRun.Status, fileSearchRun.LastError?.ToString());
            }
            else
            {
                var opts = new ThreadAndRunOptions()
                {
                    ThreadOptions = threadOp
                };
                fileSearchRun = await client.CreateThreadAndRunAsync(
                    assistantId: agent.Id,
                    opts
                );
                fileSearchRun = await WaitForRun(client, fileSearchRun);
            }
            Assert.IsNotNull(fileSearchRun);
            AsyncPageable<PersistentThreadMessage> messagesPages = client.Messages.GetMessagesAsync(fileSearchRun.ThreadId, fileSearchRun.Id);
            List<PersistentThreadMessage> messages = await messagesPages.ToListAsync();
            Assert.GreaterOrEqual(messages.Count, 1);
            // Check list, get and delete operations.
            PersistentAgentsVectorStore getVct = await client.VectorStores.GetVectorStoreAsync(vectorStore.Id);
            Assert.AreEqual(vectorStore.Id, getVct.Id);
            AsyncPageable<PersistentAgentsVectorStore> stores = client.VectorStores.GetVectorStoresAsync(limit: 100);
            getVct = null;
            await foreach (PersistentAgentsVectorStore store in stores)
            {
                if (store.Id == vectorStore.Id)
                {
                    getVct = store;
                    break;
                }
            }
            Assert.NotNull(getVct);
            bool removed = await client.VectorStores.DeleteVectorStoreAsync(vectorStore.Id);
            Assert.True(removed);
            stores = client.VectorStores.GetVectorStoresAsync(limit: 100);
            getVct = null;
            await foreach (PersistentAgentsVectorStore store in stores)
            {
                if (store.Id == vectorStore.Id)
                {
                    getVct = store;
                    break;
                }
            }
            Assert.IsNull(getVct);
        }

        [RecordedTest]
        [TestCase(true, true)]
        [TestCase(true, false)]
        [TestCase(false, true)]
        [TestCase(false, false)]
        public async Task TestCreateWithMessageAttachment(bool useFileSource, bool attachmentOnThread)
        {
            using var _ = SetTestSwitch();
            if (useFileSource && Mode != RecordedTestMode.Live)
                Assert.Inconclusive(FILE_UPLOAD_CONSTRAINT);
            PersistentAgentsClient client = GetClient();

            MessageAttachment attachment;
            List<ToolDefinition> tools = [
                new FileSearchToolDefinition(),
                new CodeInterpreterToolDefinition()
            ];
            string fileId = default;
            if (useFileSource)
            {
                PersistentAgentFileInfo fileDataSource = await client.Files.UploadFileAsync(GetFile(), PersistentAgentFilePurpose.Agents);
                fileId = fileDataSource.Id;
                attachment = new MessageAttachment(fileDataSource.Id, tools);
            }
            else
            {
                VectorStoreDataSource vectorStoreDataSource = new(
                    assetIdentifier: TestEnvironment.AZURE_BLOB_URI,
                    assetType: VectorStoreDataSourceAssetType.UriAsset
                );
                attachment = new MessageAttachment(vectorStoreDataSource, tools);
            }
            // Test file search
            PersistentAgent agent = await client.Administration.CreateAgentAsync(
                model: "gpt-4",
                name: "SDK Test Agent - Retrieval",
                instructions: "You are a helpful agent that can help fetch data from files you know about."
                );
            PersistentAgentThread thread;
            List<ThreadMessageOptions> opts = null;
            if (attachmentOnThread)
            {
                ThreadMessageOptions messageOp = new(
                    role: MessageRole.User,
                    content: "What does the attachment say?"
                );
                opts = [messageOp];
                thread = await client.Threads.CreateThreadAsync(messages: opts);
            }
            else
            {
                thread = await client.Threads.CreateThreadAsync();
                await client.Messages.CreateMessageAsync(
                    threadId: thread.Id,
                    role: MessageRole.User,
                    content: "What does the attachment say?",
                    attachments: [attachment]
                );
            }
            ThreadRun fileSearchRun = await client.Runs.CreateRunAsync(thread, agent);
            fileSearchRun = await WaitForRun(client, fileSearchRun);
            List<PersistentThreadMessage> messages = await client.Messages.GetMessagesAsync(fileSearchRun.ThreadId, fileSearchRun.Id).ToListAsync();
            Assert.GreaterOrEqual(messages.Count, 1);
        }

        [RecordedTest]
        [TestCase(true, true)]
        [TestCase(true, false)]
        [TestCase(false, true)]
        [TestCase(false, false)]
        public async Task TestFileSearchWithCodeInterpreter(bool useFileSource, bool useThreads)
        {
            using var _ = SetTestSwitch();
            if (useFileSource && Mode != RecordedTestMode.Live)
                Assert.Inconclusive(FILE_UPLOAD_CONSTRAINT);
            PersistentAgentsClient client = GetClient();
            CodeInterpreterToolResource toolRes = new();
            if (useFileSource)
            {
                PersistentAgentFileInfo fileDataSource = await client.Files.UploadFileAsync(GetFile(), PersistentAgentFilePurpose.Agents);
                toolRes.FileIds.Add(fileDataSource.Id);
            }
            else
            {
                VectorStoreDataSource vectorStoreDataSource = new(
                    assetIdentifier: TestEnvironment.AZURE_BLOB_URI,
                    assetType: VectorStoreDataSourceAssetType.UriAsset
                );
                toolRes.DataSources.Add(vectorStoreDataSource);
            }
            ToolResources resources = new()
            {
                CodeInterpreter = toolRes
            };
            PersistentAgent agent = await client.Administration.CreateAgentAsync(
                model: "gpt-4",
                name: AGENT_NAME,
                instructions: "You are a helpful agent that can help fetch data from files you know about.",
                tools: [ new CodeInterpreterToolDefinition() ],
                toolResources: useThreads ? null : resources
            );
            PersistentAgentThread thread = await client.Threads.CreateThreadAsync(
                toolResources: useThreads ? resources : null
            );
            PersistentThreadMessage message = await client.Messages.CreateMessageAsync(
                threadId: thread.Id,
                role: MessageRole.User,
                content: "What Contoso Galaxy Innovations produces?"
            );
            ThreadRun fileSearchRun = await client.Runs.CreateRunAsync(thread, agent);

            long milliseconds = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            fileSearchRun = await WaitForRun(client, fileSearchRun);
            Console.WriteLine((milliseconds - DateTimeOffset.Now.ToUnixTimeMilliseconds()) / 1000);
            List<PersistentThreadMessage> messages = await client.Messages.GetMessagesAsync(fileSearchRun.ThreadId, fileSearchRun.Id).ToListAsync();
            Assert.GreaterOrEqual(messages.Count, 1);
        }

        [RecordedTest]
        public async Task TestCreateVectorStoreOnline()
        {
            using var _ = SetTestSwitch();
            PersistentAgentsClient client = GetClient();
            VectorStoreDataSource vectorStoreDataSource = new(
                assetIdentifier: TestEnvironment.AZURE_BLOB_URI,
                assetType: VectorStoreDataSourceAssetType.UriAsset
            );
            FileSearchToolResource fileSearch = new();
            fileSearch.VectorStores.Add(new VectorStoreConfigurations(
                    storeName: VCT_STORE_NAME,
                    new VectorStoreConfiguration([vectorStoreDataSource])
                )
            );
            ToolResources tools = new()
            {
                FileSearch=fileSearch
            };
            PersistentAgent agent = await client.Administration.CreateAgentAsync(
                model: "gpt-4",
                name: AGENT_NAME,
                instructions: "You are a helpful agent that can help fetch data from files you know about.",
                tools: [new FileSearchToolDefinition()],
                toolResources: tools
            );
            PersistentAgentThread thread = await client.Threads.CreateThreadAsync();
            PersistentThreadMessage message = await client.Messages.CreateMessageAsync(
                threadId: thread.Id,
                role: MessageRole.User,
                content: "What does the attachment say?"
            );
            ThreadRun fileSearchRun = await client.Runs.CreateRunAsync(thread, agent);

            fileSearchRun = await WaitForRun(client, fileSearchRun);
            List<PersistentThreadMessage> messages = await client.Messages.GetMessagesAsync(fileSearchRun.ThreadId, fileSearchRun.Id).ToListAsync();
            Assert.GreaterOrEqual(messages.Count, 1);
        }

        [RecordedTest]
        [TestCase(true, true)]
        [TestCase(true, false)]
        [TestCase(false, true)]
        [TestCase(false, false)]
        public async Task TestIncludeFileSearchContent(bool useStream, bool includeContent)
        {
            using var _ = SetTestSwitch();
            if (useStream && !IsAsync)
                Assert.Inconclusive(STREAMING_CONSTRAINT);
            PersistentAgentsClient client = GetClient();
            VectorStoreDataSource vectorStoreDataSource = new(
                    assetIdentifier: TestEnvironment.AZURE_BLOB_URI,
                    assetType: VectorStoreDataSourceAssetType.UriAsset
                );
            VectorStoreConfiguration vectorStoreConf = new(
                dataSources: [vectorStoreDataSource]
            );
            PersistentAgentsVectorStore vctStore = await client.VectorStores.CreateVectorStoreAsync(
                name: VCT_STORE_NAME,
                storeConfiguration: vectorStoreConf
            );
            FileSearchToolResource fileSearch = new();
            fileSearch.VectorStoreIds.Add(vctStore.Id);

            ToolResources tools = new()
            {
                FileSearch = fileSearch
            };
            PersistentAgent agent = await client.Administration.CreateAgentAsync(
                model: "gpt-4",
                name: AGENT_NAME,
                instructions: "Hello, you are helpful agent and can search information from uploaded files",
                tools: [new FileSearchToolDefinition()],
                toolResources: tools
            );
            PersistentAgentThread thread = await client.Threads.CreateThreadAsync();
            PersistentThreadMessage message = await client.Messages.CreateMessageAsync(
                threadId: thread.Id,
                role: MessageRole.User,
                content: "What Contoso Galaxy Innovations produces?"
            );
            List<RunAdditionalFieldList> include = includeContent ? [RunAdditionalFieldList.FileSearchContents] : null;
            ThreadRun fileSearchRun = null;
            if (useStream)
            {
                CreateRunStreamingOptions opts = new()
                {
                    Include = include,
                };
                await foreach (StreamingUpdate streamingUpdate in client.Runs.CreateRunStreamingAsync(thread.Id, agent.Id, options: opts))
                {
                    if (streamingUpdate is RunUpdate runUpdate)
                        fileSearchRun = runUpdate.Value;
                }
                Assert.IsNotNull(fileSearchRun);
            }
            else
            {
                fileSearchRun = await client.Runs.CreateRunAsync(thread.Id, agent.Id, include: include);

                fileSearchRun = await WaitForRun(client, fileSearchRun);
                Assert.AreEqual(RunStatus.Completed, fileSearchRun.Status);
                List<PersistentThreadMessage> messages = await client.Messages.GetMessagesAsync(fileSearchRun.ThreadId, fileSearchRun.Id).ToListAsync();
                Assert.GreaterOrEqual(messages.Count, 1);
            }
            List<RunStep> steps = await client.Runs.GetRunStepsAsync(
                threadId: fileSearchRun.ThreadId,
                runId: fileSearchRun.Id,
                include: include
            ).ToListAsync();
            Assert.GreaterOrEqual(steps.Count, 2);
            RunStep step = await client.Runs.GetRunStepAsync(fileSearchRun.ThreadId, fileSearchRun.Id, steps[1].Id, include: include);

            Assert.That(step.StepDetails is RunStepToolCallDetails);
            RunStepToolCallDetails toolCallDetails = step.StepDetails as RunStepToolCallDetails;
            Assert.That(toolCallDetails.ToolCalls[0] is RunStepFileSearchToolCall);
            RunStepFileSearchToolCall fileSearchCall = toolCallDetails.ToolCalls[0] as RunStepFileSearchToolCall;
            Assert.Greater(fileSearchCall.FileSearch.Results.Count, 0);
            if (includeContent)
            {
                Assert.Greater(fileSearchCall.FileSearch.Results[0].Content.Count, 0);
                Assert.AreEqual(FileSearchToolCallContentType.Text, fileSearchCall.FileSearch.Results[0].Content[0].Type);
                Assert.False(string.IsNullOrEmpty(fileSearchCall.FileSearch.Results[0].Content[0].Text));
            }
            else
            {
                Assert.AreEqual(0, fileSearchCall.FileSearch.Results[0].Content.Count);
            }
        }

        [RecordedTest]
        public async Task TestAzureFunctionCall()
        {
            using var _ = SetTestSwitch();
            // Note: This test was recorded in westus region as for now
            // 2025-02-05 it is not supported in test region (East US 2)
            AzureFunctionToolDefinition azureFnTool = new(
                name: "foo",
                description: "Get answers from the foo bot.",
                inputBinding: new AzureFunctionBinding(
                    new AzureFunctionStorageQueue(
                        queueName: "azure-function-foo-input",
                        storageServiceEndpoint: TestEnvironment.STORAGE_QUEUE_URI
                    )
                ),
                outputBinding: new AzureFunctionBinding(
                    new AzureFunctionStorageQueue(
                        queueName: "azure-function-tool-output",
                        storageServiceEndpoint: TestEnvironment.STORAGE_QUEUE_URI
                    )
                ),
                parameters: BinaryData.FromObjectAsJson(
                        new
                        {
                            Type = "object",
                            Properties = new
                            {
                                query = new
                                {
                                    Type = "string",
                                    Description = "The question to ask.",
                                },
                                outputqueueuri = new
                                {
                                    Type = "string",
                                    Description = "The full output queue uri."
                                }
                            },
                        },
                    new JsonSerializerOptions() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase }
                )
            );
            PersistentAgentsClient client = GetClient();
            PersistentAgent agent = await client.Administration.CreateAgentAsync(
                model: "gpt-4",
                name: AGENT_NAME,
                instructions: "You are a helpful support agent. Use the provided function any "
                + "time the prompt contains the string 'What would foo say?'. When you invoke "
                + "the function, ALWAYS specify the output queue uri parameter as "
                + $"'{TestEnvironment.STORAGE_QUEUE_URI}/azure-function-tool-output'. Always responds with "
                + "\"Foo says\" and then the response from the tool.",
                tools: new List<ToolDefinition> { azureFnTool }
            );
            PersistentAgentThread thread = await client.Threads.CreateThreadAsync();
            PersistentThreadMessage message = await client.Messages.CreateMessageAsync(
                thread.Id,
                MessageRole.User,
                "What is the most prevalent element in the universe? What would foo say?");
            ThreadRun run = await client.Runs.CreateRunAsync(thread, agent);
            await WaitForRun(client, run);
            List<PersistentThreadMessage> afterRunMessages = await client.Messages.GetMessagesAsync(thread.Id).ToListAsync();

            Assert.Greater(afterRunMessages.Count(), 1);
            bool foundResponse = false;
            foreach (PersistentThreadMessage msg in afterRunMessages)
            {
                foreach (MessageContent contentItem in msg.ContentItems)
                {
                    if (contentItem is MessageTextContent textItem)
                    {
                        if (textItem.Text.ToLower().Contains("bar"))
                        {
                            foundResponse = true;
                            break;
                        }
                    }
                }
            }
            Assert.True(foundResponse);
        }

        [RecordedTest]
        public async Task TestClientWithPersistentThreadMessages()
        {
            using var _ = SetTestSwitch();
            PersistentAgentsClient client = GetClient();
            PersistentAgent agent = await GetAgent(
                client,
                instruction: "You are a personal electronics tutor. Write and run code to answer questions.");

            List<ThreadMessageOptions> messages = [
                new(role: MessageRole.Agent, content: "E=mc^2"),
                new(role: MessageRole.Agent, content: "What is the impedance formula?")
            ];
            PersistentAgentThread thread = await client.Threads.CreateThreadAsync(messages: messages);
            ThreadRun run = await client.Runs.CreateRunAsync(thread, agent);
            run = await WaitForRun(client, run);
            Assert.AreEqual(RunStatus.Completed, run.Status);
            List<PersistentThreadMessage> afterRunMessages = await client.Messages.GetMessagesAsync(thread.Id).ToListAsync();
            Assert.Greater(afterRunMessages.Count(), 1);
        }

        [Ignore(FILE_UPLOAD_CONSTRAINT)]
        [RecordedTest]
        public async Task TestGenerateImageFile()
        {
            using var _ = SetTestSwitch();
            string tempDir = CreateTempDirMayBe();
            FileInfo file = new(Path.Combine(tempDir, FILE_NAME2));
            using (FileStream stream = file.OpenWrite())
            {
                string content = "This is a test file";
                stream.Write(Encoding.UTF8.GetBytes(content), 0, content.Length);
            };

            PersistentAgentsClient client = GetClient();
            PersistentAgentFileInfo fileDataSource = await client.Files.UploadFileAsync(file.FullName, PersistentAgentFilePurpose.Agents);

            CodeInterpreterToolResource cdResource = new();
            cdResource.FileIds.Add(fileDataSource.Id);
            ToolResources toolRes = new();
            toolRes.CodeInterpreter = cdResource;

            PersistentAgent agent = await client.Administration.CreateAgentAsync(
                model: "gpt-4",
                name: AGENT_NAME,
                instructions: "You are helpful agent",
                tools: [new CodeInterpreterToolDefinition()],
                toolResources: toolRes
            );

            PersistentAgentThread thread = await client.Threads.CreateThreadAsync();
            await client.Messages.CreateMessageAsync(
                threadId: thread.Id,
                role: MessageRole.User,
                content: "Create an image file same as the text file and give me file id?"
            );
            ThreadRun run = await client.Runs.CreateRunAsync(thread, agent);
            run = await WaitForRun(client, run);
            AsyncPageable<PersistentThreadMessage> messages = client.Messages.GetMessagesAsync(run.ThreadId, run.Id);
            bool foundId = false;
            await foreach (PersistentThreadMessage msg in messages)
            {
                foreach (MessageContent cont in msg.ContentItems)
                {
                    if (cont is MessageTextContent textCont)
                    {
                        foreach (MessageTextAnnotation annotation in textCont.Annotations)
                        {
                            if (annotation is MessageTextFilePathAnnotation pathAnnotation)
                            {
                                Assert.NotNull(pathAnnotation.FileId);
                                foundId = true;
                            }
                        }
                    }
                }
            }
            Assert.True(foundId);
        }

        [RecordedTest]
        [TestCase(AzureAISearchQueryTypeEnum.Simple)]
        [TestCase(AzureAISearchQueryTypeEnum.Semantic)]
        [TestCase(AzureAISearchQueryTypeEnum.Vector)]
        [TestCase(AzureAISearchQueryTypeEnum.VectorSimpleHybrid)]
        [TestCase(AzureAISearchQueryTypeEnum.VectorSemanticHybrid)]
        public async Task TestAzureAiSearch(AzureAISearchQueryTypeEnum queryType)
        {
            using var _ = SetTestSwitch();
            PersistentAgentsClient client = GetClient();

            ToolResources searchResource = GetAISearchToolResource(queryType);
            PersistentAgent agent = await client.Administration.CreateAgentAsync(
                model: "gpt-4",
                name: AGENT_NAME,
                instructions: "You are a helpful agent.",
                tools: [new AzureAISearchToolDefinition()],
                toolResources: searchResource);

            // Create thread for communication
            PersistentAgentThread thread = await client.Threads.CreateThreadAsync();

            // Create message to thread
            await client.Messages.CreateMessageAsync(
                thread.Id,
                MessageRole.User,
                "What is the temperature rating of the cozynights sleeping bag?");
            ThreadRun run = await client.Runs.CreateRunAsync(thread, agent);

            do
            {
                await Task.Delay(TimeSpan.FromMilliseconds(500));
                run = await client.Runs.GetRunAsync(thread.Id, run.Id);
            }
            while (run.Status == RunStatus.Queued
                || run.Status == RunStatus.InProgress);

            Assert.AreEqual(
                RunStatus.Completed,
                run.Status,
                run.LastError?.Message);
            AsyncPageable<PersistentThreadMessage> messages = client.Messages.GetMessagesAsync(
                threadId: thread.Id,
                order: ListSortOrder.Ascending
            );

            // Note: messages iterate from newest to oldest, with the messages[0] being the most recent
            await foreach (PersistentThreadMessage threadMessage in messages)
            {
                Console.Write($"{threadMessage.CreatedAt:yyyy-MM-dd HH:mm:ss} - {threadMessage.Role,10}: ");
                foreach (MessageContent contentItem in threadMessage.ContentItems)
                {
                    if (contentItem is MessageTextContent textItem)
                    {
                        // We need to annotate only Agent messages.
                        if (threadMessage.Role == MessageRole.Agent && textItem.Annotations.Count > 0)
                        {
                            string annotatedText = textItem.Text;
                            foreach (MessageTextAnnotation annotation in textItem.Annotations)
                            {
                                if (annotation is MessageTextUriCitationAnnotation urlAnnotation)
                                {
                                    annotatedText = annotatedText.Replace(
                                        urlAnnotation.Text,
                                        $" [see {urlAnnotation.UriCitation.Title}] ({urlAnnotation.UriCitation.Uri})");
                                }
                            }
                            Console.Write(annotatedText);
                        }
                        else
                        {
                            Console.Write(textItem.Text);
                        }
                    }
                    else if (contentItem is MessageImageFileContent imageFileItem)
                    {
                        Console.Write($"<image from ID: {imageFileItem.FileId}");
                    }
                    Console.WriteLine();
                }
            }
        }

        [RecordedTest]
        [TestCase(AzureAISearchQueryTypeEnum.Simple)]
        [TestCase(AzureAISearchQueryTypeEnum.Semantic)]
        [TestCase(AzureAISearchQueryTypeEnum.Vector)]
        [TestCase(AzureAISearchQueryTypeEnum.VectorSimpleHybrid)]
        [TestCase(AzureAISearchQueryTypeEnum.VectorSemanticHybrid)]
        public async Task TestAzureAiSearchStreaming(AzureAISearchQueryTypeEnum queryType)
        {
            using var _ = SetTestSwitch();
            if (!IsAsync && Mode != RecordedTestMode.Live)
                Assert.Inconclusive(STREAMING_CONSTRAINT);
            PersistentAgentsClient client = GetClient();
            ToolResources searchResource = GetAISearchToolResource(queryType);

            PersistentAgent agent = await client.Administration.CreateAgentAsync(
                model: "gpt-4",
                name: AGENT_NAME,
                instructions: "You are a helpful agent.",
                tools: [new AzureAISearchToolDefinition()],
                toolResources: searchResource);

            // Create thread for communication
            PersistentAgentThread thread = await client.Threads.CreateThreadAsync();

            // Create message to thread
            await client.Messages.CreateMessageAsync(
                thread.Id,
                MessageRole.User,
                "What is the temperature rating of the cozynights sleeping bag?");
            await foreach (StreamingUpdate streamingUpdate in client.Runs.CreateRunStreamingAsync(thread.Id, agent.Id))
            {
                if (streamingUpdate.UpdateKind == StreamingUpdateReason.RunCreated)
                {
                    Console.WriteLine("--- Run started! ---");
                }
                else if (streamingUpdate is MessageContentUpdate contentUpdate)
                {
                    if (contentUpdate.TextAnnotation != null)
                    {
                        Console.Write($" [see {contentUpdate.TextAnnotation.Title}] ({contentUpdate.TextAnnotation.Url})");
                    }
                    else
                    {
                        //Detect the reference placeholder and skip it. Instead we will print the actual reference.
                        if (contentUpdate.Text[0] != (char)12304 || contentUpdate.Text[contentUpdate.Text.Length - 1] != (char)12305)
                            Console.Write(contentUpdate.Text);
                    }
                }
                else if (streamingUpdate.UpdateKind == StreamingUpdateReason.RunCompleted)
                {
                    Console.WriteLine();
                    Console.WriteLine("--- Run completed! ---");
                }
            }
        }

        [RecordedTest]
        [TestCase(true)]
        [TestCase(false)]
        public async Task TestAutomaticSubmitToolOutputs(bool correctDefinition)
        {
            if (!IsAsync && Mode != RecordedTestMode.Live)
                Assert.Inconclusive(STREAMING_CONSTRAINT);

            string GetHumidityByAddress(string address)
            {
                return address.Contains("Seattle") ? "80" : "60";
            }

            FunctionToolDefinition correctGeHhumidityByAddressTool = new(
                 name: "GetHumidityByAddress",
                 description: "Get humidity by address",
                 parameters: BinaryData.FromObjectAsJson(
                 new
                 {
                     Type = "object",
                     Properties = new
                     {
                         Address = new
                         {
                             Type = "string",
                             Description = "Address"
                         }
                     },
                     Required = new[] { "address" }
                 },
                 new JsonSerializerOptions() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase }));

            FunctionToolDefinition incorrectGeHhumidityByAddressTool = new(
                 name: "GetHumidityByAddress",
                 description: "Get humidity by address",
                 parameters: BinaryData.FromObjectAsJson(
                 new
                 {
                     Type = "object",
                     Properties = new
                     {
                         Addresses = new
                         {
                             Type = "array",
                             Description = "A list of addresses",
                             Items = new
                             {
                                 Type = "object",
                                 Properties = new
                                 {
                                     Street = new
                                     {
                                         Type = "string",
                                         Description = "Street"
                                     },
                                     City = new
                                     {
                                         Type = "string",
                                         description = "city"
                                     },
                                 },
                                 Required = new[] { "street", "city" }
                             }
                         },
                     },
                     Required = new[] { "address" }
                 },
                 new JsonSerializerOptions() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase }));

            Dictionary<string, Delegate> toolDelegates = new();
            toolDelegates.Add(nameof(GetHumidityByAddress), GetHumidityByAddress);

            PersistentAgentsClient client = GetClient();
            string output = "";
            bool completed = false;
            bool cancelled = false;
            List<ToolDefinition> tools = new();
            AutoFunctionCallOptions autoFunctionCallOptions = new(toolDelegates, 0);
            if (correctDefinition)
                tools.Add(correctGeHhumidityByAddressTool);
            else
                tools.Add(incorrectGeHhumidityByAddressTool);

            PersistentAgent agent = await client.Administration.CreateAgentAsync(
                    model: "gpt-4o-mini",
                    name: AGENT_NAME,
                    instructions: "Use the provided functions to help answer questions.",
                    tools: tools
                );
            PersistentAgentThread thread = await client.Threads.CreateThreadAsync();

            PersistentThreadMessage message = await client.Messages.CreateMessageAsync(
                thread.Id,
                MessageRole.User,
                "Get humidity for address, 456 2nd Ave in city, Seattle");

            CreateRunStreamingOptions opts = new()
            {
                AutoFunctionCallOptions = autoFunctionCallOptions
            };
            await foreach (StreamingUpdate streamingUpdate in client.Runs.CreateRunStreamingAsync(thread.Id, agent.Id, options: opts))
            {
                if (streamingUpdate is MessageContentUpdate contentUpdate)
                {
                    output += contentUpdate.Text;
                }
                else if (streamingUpdate.UpdateKind == StreamingUpdateReason.RunCompleted)
                {
                    completed = true;
                }
                else if (streamingUpdate.UpdateKind == StreamingUpdateReason.RunCancelled)
                {
                    cancelled = true;
                }
                else if (streamingUpdate.UpdateKind == StreamingUpdateReason.RunFailed && streamingUpdate is RunUpdate errorStep)
                {
                    Assert.Fail(errorStep.Value.LastError.Message);
                }
            }

            if (correctDefinition)
            {
                Assert.True(output.Contains("80"));
                Assert.True(completed);
            }
            else
            {
                Assert.True(cancelled);
            }
        }

        [RecordedTest]
        public async Task TestDeepResearchTool()
        {
            PersistentAgentsClient client = GetClient();
            DeepResearchToolDefinition deepResearch = new(
                new DeepResearchDetails(
                    model: TestEnvironment.DEEP_RESEARCH_MODEL_DEPLOYMENT_NAME,
                    bingGroundingConnections: [
                        new DeepResearchBingGroundingConnection(TestEnvironment.BING_CONNECTION_ID)
                    ]
                )
            );
            string instruction = "You are a helpful Agent that assists in researching scientific topics.";
            PersistentAgent agent = await GetAgent(client: client, instruction:instruction, model: "gpt-4o", tools: [deepResearch]);
            PersistentAgentThreadCreationOptions threadOp = new();
            threadOp.Messages.Add(new ThreadMessageOptions(
                role: MessageRole.User,
                content: "Research the current state of studies on orca intelligence and orca language, " +
                "including what is currently known about orcas' cognitive capabilities, " +
                "communication systems and problem-solving reflected in recent publications in top thier scientific " +
                "journals like Science, Nature and PNAS."
            ));
            ThreadAndRunOptions opts = new()
            {
                ThreadOptions = threadOp,
            };
            ThreadRun run = await client.CreateThreadAndRunAsync(
                assistantId: agent.Id,
                options: opts
            );
            run = await WaitForRun(client, run);
            Assert.AreEqual(RunStatus.Completed, run.Status);
            List<PersistentThreadMessage> messages = await client.Messages.GetMessagesAsync(run.ThreadId, run.Id).ToListAsync();
            Assert.GreaterOrEqual(messages.Count, 1);
            bool annotationFound = false;
            foreach (PersistentThreadMessage msg in messages)
            {
                if (msg.Role != MessageRole.Agent)
                    continue;
                foreach (MessageContent contentItem in msg.ContentItems)
                {
                    if (contentItem is MessageTextContent textItem)
                    {
                        // Console.WriteLine(textItem.Text);
                        if (textItem.Annotations != null)
                        {
                            foreach (MessageTextAnnotation annotation in textItem.Annotations)
                            {
                                if (annotation is MessageTextUriCitationAnnotation uriAnnotation)
                                {
                                    annotationFound = true;
                                    break;
                                }
                            }
                        }
                    }
                    if (annotationFound)
                        break;
                }
                if (annotationFound)
                    break;
            }
            // Note sometimes this assumption fails because agent asks additional question.
            Assert.That(annotationFound, "Annotations were not found, the data are not grounded.");
        }

        [RecordedTest]
        public async Task TestMcpTool()
        {
            PersistentAgentsClient client = GetClient();
            MCPToolDefinition mcpTool = new("github", "https://gitmcp.io/Azure/azure-rest-api-specs");
            string searchApiCode = "search_azure_rest_api_code";
            mcpTool.AllowedTools.Add(searchApiCode);

            PersistentAgent agent = await GetAgent(
                client,
                instruction: "You are a helpful agent that can use MCP tools to assist users. Use the available MCP tools to answer questions and perform tasks.",
                tools: [mcpTool]);
            PersistentAgentThread thread = await client.Threads.CreateThreadAsync();
            PersistentThreadMessage message = await client.Messages.CreateMessageAsync(
                thread.Id,
                MessageRole.User,
                "Please summarize the Azure REST API specifications Readme");

            MCPToolResource mcpToolResource = new("github");
            mcpToolResource.UpdateHeader("SuperSecret", "123456");
            ToolResources toolResources = mcpToolResource.ToToolResources();

            // Run the agent with MCP tool resources
            ThreadRun run = await client.Runs.CreateRunAsync(thread, agent, toolResources);

            // Handle run execution and tool approvals
            bool isApprovalRequested = false;
            while (run.Status == RunStatus.Queued || run.Status == RunStatus.InProgress || run.Status == RunStatus.RequiresAction)
            {
                if (Mode != RecordedTestMode.Playback)
                    await Task.Delay(TimeSpan.FromMilliseconds(1000));
                run = await client.Runs.GetRunAsync(thread.Id, run.Id);

                if (run.Status == RunStatus.RequiresAction && run.RequiredAction is SubmitToolApprovalAction toolApprovalAction)
                {
                    var toolApprovals = new List<ToolApproval>();
                    foreach (RequiredToolCall toolCall in toolApprovalAction.SubmitToolApproval.ToolCalls)
                    {
                        if (toolCall is RequiredMcpToolCall mcpToolCall)
                        {
                            Console.WriteLine($"Approving MCP tool call: {mcpToolCall.Name}");
                            toolApprovals.Add(new ToolApproval(mcpToolCall.Id, approve: true)
                            {
                                Headers = { ["SuperSecret"] = "123456" }
                            });
                            isApprovalRequested = true;
                        }
                    }

                    if (toolApprovals.Count > 0)
                    {
                        run = await client.Runs.SubmitToolOutputsToRunAsync(thread.Id, run.Id, toolApprovals: toolApprovals);
                    }
                }
            }
            Assert.IsTrue(isApprovalRequested, "The approval was not requested.");
            Assert.Greater((await client.Messages.GetMessagesAsync(thread.Id).ToListAsync()).Count, 1);
            AsyncPageable<RunStep> steps = client.Runs.GetRunStepsAsync(thread.Id, run.Id);
            bool isRunStepMCPPresent = false;
            await foreach (RunStep step in steps)
            {
                if (step.StepDetails is RunStepToolCallDetails details)
                {
                    foreach (RunStepToolCall call in details.ToolCalls)
                        if (call is RunStepMcpToolCall)
                            isRunStepMCPPresent = true;
                }
            }
            Assert.IsTrue(isRunStepMCPPresent, "No MCP tool call step is present.");
        }

        [RecordedTest]
        public async Task TestMcpToolStreaming()
        {
            PersistentAgentsClient client = GetClient();
            MCPToolDefinition mcpTool = new("github", "https://gitmcp.io/Azure/azure-rest-api-specs");
            string searchApiCode = "search_azure_rest_api_code";
            mcpTool.AllowedTools.Add(searchApiCode);
            PersistentAgent agent = await GetAgent(
                client,
                instruction: "You are a helpful agent that can use MCP tools to assist users. Use the available MCP tools to answer questions and perform tasks.",
                tools: [mcpTool]);
            PersistentAgentThread thread = await client.Threads.CreateThreadAsync();
            PersistentThreadMessage message = await client.Messages.CreateMessageAsync(
                thread.Id,
                MessageRole.User,
                "Please summarize the Azure REST API specifications Readme");
            MCPToolResource mcpToolResource = new("github");
            mcpToolResource.UpdateHeader("SuperSecret", "123456");
            ToolResources toolResources = mcpToolResource.ToToolResources();
            CreateRunStreamingOptions options = new()
            {
                ToolResources = toolResources
            };
            List<ToolApproval> toolApprovals = [];
            ThreadRun streamRun = null;
            bool isApprovalRequested = false;
            bool isMCPStepCreated = false;
            AsyncCollectionResult<StreamingUpdate> stream = client.Runs.CreateRunStreamingAsync(thread.Id, agent.Id, options: options);
            do
            {
                toolApprovals.Clear();
                await foreach (StreamingUpdate streamingUpdate in stream)
                {
                    if (streamingUpdate is SubmitToolApprovalUpdate submitToolApprovalUpdate)
                    {
                        toolApprovals.Add(new ToolApproval(submitToolApprovalUpdate.ToolCallId, approve: true)
                        {
                            Headers = { ["SuperSecret"] = "123456" }
                        });
                        streamRun = submitToolApprovalUpdate.Value;
                        isApprovalRequested = true;
                    }
                    else if (streamingUpdate is MessageContentUpdate contentUpdate)
                    {
                        Console.Write(contentUpdate.Text);
                    }
                    else if (streamingUpdate.UpdateKind == StreamingUpdateReason.RunFailed && streamingUpdate is RunUpdate errorStep)
                    {
                        Assert.Fail(errorStep.Value.LastError.Message);
                    }
                    else if (streamingUpdate is RunStepDetailsUpdate runStepDelta)
                    {
                        if (!string.IsNullOrEmpty(runStepDelta.FunctionArguments))
                        {
                            isMCPStepCreated = true;
                        }
                    }
                }
                if (toolApprovals.Count > 0)
                {
                    stream = client.Runs.SubmitToolOutputsToStreamAsync(streamRun, toolOutputs: [], toolApprovals: toolApprovals);
                }
            }
            while (toolApprovals.Count > 0);
            Assert.IsTrue(isApprovalRequested, "The approval was not requested.");
            Assert.IsTrue(isMCPStepCreated, "The Delta MCP step was not encountered.");
            Assert.Greater((await client.Messages.GetMessagesAsync(thread.Id).ToListAsync()).Count, 1);
        }

        #region Helpers

        private static string CreateTempDirMayBe()
        {
            string tempDir = Path.Combine(Path.GetTempPath(), TEMP_DIR);
            if (!Directory.Exists(tempDir))
            {
                DirectoryInfo info = Directory.CreateDirectory(tempDir);
                Assert.True(info.Exists, "Unable to create temp directory.");
            }
            return tempDir;
        }

        private PersistentAgentsClient GetClient()
        {
            var connectionString = TestEnvironment.PROJECT_CONNECTION_STRING;
            // If we are in the Playback, do not ask for authentication.
            PersistentAgentsAdministrationClient admClient = null;
            PersistentAgentsAdministrationClientOptions opts = InstrumentClientOptions(new PersistentAgentsAdministrationClientOptions());
            if (Mode == RecordedTestMode.Playback)
            {
                admClient = InstrumentClient(new PersistentAgentsAdministrationClient(connectionString, new MockCredential(), opts));
                return new PersistentAgentsClient(admClient);
            }
            // For local testing if you are using non default account
            // add USE_CLI_CREDENTIAL into the .runsettings and set it to true,
            // also provide the PATH variable.
            // This path should allow launching az command.
            var cli = System.Environment.GetEnvironmentVariable("USE_CLI_CREDENTIAL");
            if (!string.IsNullOrEmpty(cli) && string.Compare(cli, "true", StringComparison.OrdinalIgnoreCase) == 0)
            {
                admClient = InstrumentClient(new PersistentAgentsAdministrationClient(connectionString, new AzureCliCredential(), opts));
            }
            else
            {
                admClient = InstrumentClient(new PersistentAgentsAdministrationClient(connectionString, new DefaultAzureCredential(), opts));
            }
            Assert.IsNotNull(admClient);
            return new PersistentAgentsClient(admClient);
        }

        private static async Task DeleteAndAssert(PersistentAgentsClient client, PersistentAgent agent)
        {
            Response<bool> resp = await client.Administration.DeleteAgentAsync(agent.Id);
            Assert.IsTrue(resp.Value);
        }

        private static async Task<PersistentAgent> GetAgent(PersistentAgentsClient client, string agentName = AGENT_NAME, string instruction = "You are helpful agent.", string model="gpt-4", IEnumerable<ToolDefinition> tools=null)
        {
            return await client.Administration.CreateAgentAsync(
                model: model,
                name: agentName,
                instructions: instruction,
                tools: tools
            );
        }

        private static async Task<PersistentAgentThread> GetThread(PersistentAgentsClient client, Dictionary<string, string> metadata=null)
        {
            return await client.Threads.CreateThreadAsync(metadata: metadata);
        }

        private static byte[] GetBytes(object value)
        {
            return Encoding.ASCII.GetBytes(JsonSerializer.Serialize(value));
        }

        private static MemoryStream GetStream(object value)
        {
            MemoryStream stream = new();
            stream.Write(GetBytes(value), 0, GetBytes(value).Length);
            stream.Position = 0;
            return stream;
        }

        private static string GetFieldFromJson(BinaryData json, string field)
        {
            JsonDocument document = JsonDocument.Parse(json);
            foreach (JsonProperty property in document.RootElement.EnumerateObject())
            {
                if (property.NameEquals(field))
                {
                    return property.Value.GetString();
                }
            }
            return default;
        }

        private async Task<ThreadRun> WaitForRun(PersistentAgentsClient client, ThreadRun run)
        {
            double delay = 500;
            do
            {
                if (Mode != RecordedTestMode.Playback)
                    await Task.Delay(TimeSpan.FromMilliseconds(delay));
                run = await client.Runs.GetRunAsync(run.ThreadId, run.Id);
            }
            while (run.Status == RunStatus.Queued
                || run.Status == RunStatus.InProgress
                || run.Status == RunStatus.RequiresAction);
            Assert.AreEqual(RunStatus.Completed, run.Status, message: run.LastError?.Message?.ToString());
            return run;
        }

        private async Task<VectorStoreFileBatch> WaitForBatch(PersistentAgentsClient client, string vectorStoreId, VectorStoreFileBatch batch)
        {
            double delay = 500;
            do
            {
                if (Mode != RecordedTestMode.Playback)
                    await Task.Delay(TimeSpan.FromMilliseconds(delay));
                batch = await client.VectorStores.GetVectorStoreFileBatchAsync(vectorStoreId: vectorStoreId, batchId: batch.Id);
            }
            while (batch.Status == VectorStoreFileBatchStatus.InProgress);
            Assert.AreEqual(VectorStoreFileBatchStatus.Completed, batch.Status, message: "Failed to create VectorStoreFileBatchStatus");
            return batch;
        }

        private static string GetFile([CallerFilePath] string pth = "")
        {
            var dirName = Path.GetDirectoryName(pth) ?? "";
            return Path.Combine(new string[] { dirName, "TestData", FILE_NAME });
        }

        private static async Task<int> CountElementsAndRemoveIds(PersistentAgentsClient client, HashSet<string> ids)
        {
            int count = 0;
            AsyncPageable<PersistentAgent> agentsResp = client.Administration.GetAgentsAsync();
            await foreach (PersistentAgent agent in agentsResp)
            {
                ids.Remove(agent.Id);
                count++;
            }
            return count;
        }

        private ToolResources GetAISearchToolResource(AzureAISearchQueryTypeEnum queryType)
        {
            return new ToolResources()
            {
                AzureAISearch = new AzureAISearchToolResource(
                    indexConnectionId: TestEnvironment.AI_SEARCH_CONNECTION_ID,
                    indexName: "sample_index",
                    queryType: SearchQueryTypes[queryType],
                    filter: null,
                    topK: 5
                )
            };
        }

        #endregion
        #region Cleanup
        [TearDown]
        public void Cleanup()
        {
            // Remve temporary directory
            DirectoryInfo tempDir = new(Path.Combine(Path.GetTempPath(), TEMP_DIR));
            if (tempDir.Exists)
            {
                tempDir.Delete(true);
            }
            if (Mode == RecordedTestMode.Playback)
                return;
            PersistentAgentsClient client;
            var cli = System.Environment.GetEnvironmentVariable("USE_CLI_CREDENTIAL");
            if (!string.IsNullOrEmpty(cli) && string.Compare(cli, "true", StringComparison.OrdinalIgnoreCase) == 0)
            {
                client = new PersistentAgentsClient(TestEnvironment.PROJECT_ENDPOINT, new AzureCliCredential());
            }
            else
            {
                client = new PersistentAgentsClient(TestEnvironment.PROJECT_ENDPOINT, new DefaultAzureCredential());
            }

            // Remove all files
            IReadOnlyList<PersistentAgentFileInfo> files = client.Files.GetFiles().Value;
            foreach (PersistentAgentFileInfo af in files)
            {
                if (af.Filename.Equals(FILE_NAME) || af.Filename.Equals(FILE_NAME2))
                    client.Files.DeleteFile(af.Id);
            }

            // Remove all vector stores
            Pageable<PersistentAgentsVectorStore> stores = client.VectorStores.GetVectorStores();
            foreach (PersistentAgentsVectorStore store in stores)
            {
                if (store.Name == null || store.Name.Equals(VCT_STORE_NAME))
                    client.VectorStores.DeleteVectorStore(store.Id);
            }

            // Remove all agents
            Pageable<PersistentAgent> agents = client.Administration.GetAgents();
            foreach (PersistentAgent agent in agents)
            {
                if (agent.Name.StartsWith(AGENT_NAME))
                    client.Administration.DeleteAgent(agent.Id);
            }
        }
        #endregion
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.EventGrid.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.EventGrid.Samples
{
    public partial class Sample_NamespaceTopicResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_NamespaceTopicsGet()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2025-04-01-preview/examples/NamespaceTopics_Get.json
            // this example is just showing the usage of "NamespaceTopics_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NamespaceTopicResource created on azure
            // for more information of creating NamespaceTopicResource, please refer to the document of NamespaceTopicResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e41";
            string resourceGroupName = "examplerg";
            string namespaceName = "examplenamespace2";
            string topicName = "examplenamespacetopic2";
            ResourceIdentifier namespaceTopicResourceId = NamespaceTopicResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName, topicName);
            NamespaceTopicResource namespaceTopic = client.GetNamespaceTopicResource(namespaceTopicResourceId);

            // invoke the operation
            NamespaceTopicResource result = await namespaceTopic.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NamespaceTopicData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_NamespaceTopicsDelete()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2025-04-01-preview/examples/NamespaceTopics_Delete.json
            // this example is just showing the usage of "NamespaceTopics_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NamespaceTopicResource created on azure
            // for more information of creating NamespaceTopicResource, please refer to the document of NamespaceTopicResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string namespaceName = "examplenamespace2";
            string topicName = "examplenamespacetopic2";
            ResourceIdentifier namespaceTopicResourceId = NamespaceTopicResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName, topicName);
            NamespaceTopicResource namespaceTopic = client.GetNamespaceTopicResource(namespaceTopicResourceId);

            // invoke the operation
            await namespaceTopic.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_NamespaceTopicsUpdate()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2025-04-01-preview/examples/NamespaceTopics_Update.json
            // this example is just showing the usage of "NamespaceTopics_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NamespaceTopicResource created on azure
            // for more information of creating NamespaceTopicResource, please refer to the document of NamespaceTopicResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string namespaceName = "exampleNamespaceName1";
            string topicName = "exampleNamespaceTopicName1";
            ResourceIdentifier namespaceTopicResourceId = NamespaceTopicResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName, topicName);
            NamespaceTopicResource namespaceTopic = client.GetNamespaceTopicResource(namespaceTopicResourceId);

            // invoke the operation
            NamespaceTopicPatch patch = new NamespaceTopicPatch
            {
                EventRetentionInDays = 1,
            };
            ArmOperation<NamespaceTopicResource> lro = await namespaceTopic.UpdateAsync(WaitUntil.Completed, patch);
            NamespaceTopicResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NamespaceTopicData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetSharedAccessKeys_NamespaceTopicsListSharedAccessKeys()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2025-04-01-preview/examples/NamespaceTopics_ListSharedAccessKeys.json
            // this example is just showing the usage of "NamespaceTopics_ListSharedAccessKeys" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NamespaceTopicResource created on azure
            // for more information of creating NamespaceTopicResource, please refer to the document of NamespaceTopicResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string namespaceName = "examplenamespace2";
            string topicName = "examplenamespacetopic2";
            ResourceIdentifier namespaceTopicResourceId = NamespaceTopicResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName, topicName);
            NamespaceTopicResource namespaceTopic = client.GetNamespaceTopicResource(namespaceTopicResourceId);

            // invoke the operation
            TopicSharedAccessKeys result = await namespaceTopic.GetSharedAccessKeysAsync();

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task RegenerateKey_NamespaceTopicsRegenerateKey()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2025-04-01-preview/examples/NamespaceTopics_RegenerateKey.json
            // this example is just showing the usage of "NamespaceTopics_RegenerateKey" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NamespaceTopicResource created on azure
            // for more information of creating NamespaceTopicResource, please refer to the document of NamespaceTopicResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string namespaceName = "examplenamespace2";
            string topicName = "examplenamespacetopic2";
            ResourceIdentifier namespaceTopicResourceId = NamespaceTopicResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName, topicName);
            NamespaceTopicResource namespaceTopic = client.GetNamespaceTopicResource(namespaceTopicResourceId);

            // invoke the operation
            TopicRegenerateKeyContent content = new TopicRegenerateKeyContent("key1");
            ArmOperation<TopicSharedAccessKeys> lro = await namespaceTopic.RegenerateKeyAsync(WaitUntil.Completed, content);
            TopicSharedAccessKeys result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}

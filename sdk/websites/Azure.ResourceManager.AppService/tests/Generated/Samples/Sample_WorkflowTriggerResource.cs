// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.AppService.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.AppService.Samples
{
    public partial class Sample_WorkflowTriggerResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetAWorkflowTrigger()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2024-11-01/examples/WorkflowTriggers_Get.json
            // this example is just showing the usage of "WorkflowTriggers_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkflowTriggerResource created on azure
            // for more information of creating WorkflowTriggerResource, please refer to the document of WorkflowTriggerResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "test-resource-group";
            string name = "test-name";
            string workflowName = "test-workflow";
            string triggerName = "manual";
            ResourceIdentifier workflowTriggerResourceId = WorkflowTriggerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name, workflowName, triggerName);
            WorkflowTriggerResource workflowTrigger = client.GetWorkflowTriggerResource(workflowTriggerResourceId);

            // invoke the operation
            WorkflowTriggerResource result = await workflowTrigger.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            WorkflowTriggerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetCallbackUrl_GetTheCallbackURLForATrigger()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2024-11-01/examples/WorkflowTriggers_ListCallbackUrl.json
            // this example is just showing the usage of "WorkflowTriggers_ListCallbackUrl" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkflowTriggerResource created on azure
            // for more information of creating WorkflowTriggerResource, please refer to the document of WorkflowTriggerResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "test-resource-group";
            string name = "test-name";
            string workflowName = "test-workflow";
            string triggerName = "manual";
            ResourceIdentifier workflowTriggerResourceId = WorkflowTriggerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name, workflowName, triggerName);
            WorkflowTriggerResource workflowTrigger = client.GetWorkflowTriggerResource(workflowTriggerResourceId);

            // invoke the operation
            WorkflowTriggerCallbackUri result = await workflowTrigger.GetCallbackUrlAsync();

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Run_RunAWorkflowTrigger()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2024-11-01/examples/WorkflowTriggers_Run.json
            // this example is just showing the usage of "WorkflowTriggers_Run" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkflowTriggerResource created on azure
            // for more information of creating WorkflowTriggerResource, please refer to the document of WorkflowTriggerResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "test-resource-group";
            string name = "test-name";
            string workflowName = "test-workflow";
            string triggerName = "recurrence";
            ResourceIdentifier workflowTriggerResourceId = WorkflowTriggerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name, workflowName, triggerName);
            WorkflowTriggerResource workflowTrigger = client.GetWorkflowTriggerResource(workflowTriggerResourceId);

            // invoke the operation
            await workflowTrigger.RunAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetSchemaJson_GetTriggerSchema()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2024-11-01/examples/WorkflowTriggers_GetSchemaJson.json
            // this example is just showing the usage of "WorkflowTriggers_GetSchemaJson" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkflowTriggerResource created on azure
            // for more information of creating WorkflowTriggerResource, please refer to the document of WorkflowTriggerResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "testResourceGroup";
            string name = "test-name";
            string workflowName = "testWorkflow";
            string triggerName = "testTrigger";
            ResourceIdentifier workflowTriggerResourceId = WorkflowTriggerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name, workflowName, triggerName);
            WorkflowTriggerResource workflowTrigger = client.GetWorkflowTriggerResource(workflowTriggerResourceId);

            // invoke the operation
            WebAppJsonSchema result = await workflowTrigger.GetSchemaJsonAsync();

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}

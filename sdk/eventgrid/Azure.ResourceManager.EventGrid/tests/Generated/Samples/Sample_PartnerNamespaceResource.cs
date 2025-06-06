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
    public partial class Sample_PartnerNamespaceResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_PartnerNamespacesGet()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2025-04-01-preview/examples/PartnerNamespaces_Get.json
            // this example is just showing the usage of "PartnerNamespaces_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PartnerNamespaceResource created on azure
            // for more information of creating PartnerNamespaceResource, please refer to the document of PartnerNamespaceResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string partnerNamespaceName = "examplePartnerNamespaceName1";
            ResourceIdentifier partnerNamespaceResourceId = PartnerNamespaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, partnerNamespaceName);
            PartnerNamespaceResource partnerNamespace = client.GetPartnerNamespaceResource(partnerNamespaceResourceId);

            // invoke the operation
            PartnerNamespaceResource result = await partnerNamespace.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PartnerNamespaceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_PartnerNamespacesDelete()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2025-04-01-preview/examples/PartnerNamespaces_Delete.json
            // this example is just showing the usage of "PartnerNamespaces_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PartnerNamespaceResource created on azure
            // for more information of creating PartnerNamespaceResource, please refer to the document of PartnerNamespaceResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string partnerNamespaceName = "examplePartnerNamespaceName1";
            ResourceIdentifier partnerNamespaceResourceId = PartnerNamespaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, partnerNamespaceName);
            PartnerNamespaceResource partnerNamespace = client.GetPartnerNamespaceResource(partnerNamespaceResourceId);

            // invoke the operation
            await partnerNamespace.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_PartnerNamespacesUpdate()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2025-04-01-preview/examples/PartnerNamespaces_Update.json
            // this example is just showing the usage of "PartnerNamespaces_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PartnerNamespaceResource created on azure
            // for more information of creating PartnerNamespaceResource, please refer to the document of PartnerNamespaceResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string partnerNamespaceName = "examplePartnerNamespaceName1";
            ResourceIdentifier partnerNamespaceResourceId = PartnerNamespaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, partnerNamespaceName);
            PartnerNamespaceResource partnerNamespace = client.GetPartnerNamespaceResource(partnerNamespaceResourceId);

            // invoke the operation
            PartnerNamespacePatch patch = new PartnerNamespacePatch
            {
                Tags =
{
["tag1"] = "value1"
},
            };
            await partnerNamespace.UpdateAsync(WaitUntil.Completed, patch);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetSharedAccessKeys_PartnerNamespacesListSharedAccessKeys()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2025-04-01-preview/examples/PartnerNamespaces_ListSharedAccessKeys.json
            // this example is just showing the usage of "PartnerNamespaces_ListSharedAccessKeys" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PartnerNamespaceResource created on azure
            // for more information of creating PartnerNamespaceResource, please refer to the document of PartnerNamespaceResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string partnerNamespaceName = "examplePartnerNamespaceName1";
            ResourceIdentifier partnerNamespaceResourceId = PartnerNamespaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, partnerNamespaceName);
            PartnerNamespaceResource partnerNamespace = client.GetPartnerNamespaceResource(partnerNamespaceResourceId);

            // invoke the operation
            PartnerNamespaceSharedAccessKeys result = await partnerNamespace.GetSharedAccessKeysAsync();

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task RegenerateKey_PartnerNamespacesRegenerateKey()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2025-04-01-preview/examples/PartnerNamespaces_RegenerateKey.json
            // this example is just showing the usage of "PartnerNamespaces_RegenerateKey" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PartnerNamespaceResource created on azure
            // for more information of creating PartnerNamespaceResource, please refer to the document of PartnerNamespaceResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string partnerNamespaceName = "examplePartnerNamespaceName1";
            ResourceIdentifier partnerNamespaceResourceId = PartnerNamespaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, partnerNamespaceName);
            PartnerNamespaceResource partnerNamespace = client.GetPartnerNamespaceResource(partnerNamespaceResourceId);

            // invoke the operation
            PartnerNamespaceRegenerateKeyContent content = new PartnerNamespaceRegenerateKeyContent("key1");
            PartnerNamespaceSharedAccessKeys result = await partnerNamespace.RegenerateKeyAsync(content);

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}

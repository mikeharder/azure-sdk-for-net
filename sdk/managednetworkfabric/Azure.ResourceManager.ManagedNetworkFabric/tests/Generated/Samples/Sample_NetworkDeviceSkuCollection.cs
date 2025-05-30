// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Resources;
using NUnit.Framework;

namespace Azure.ResourceManager.ManagedNetworkFabric.Samples
{
    public partial class Sample_NetworkDeviceSkuCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_NetworkDeviceSkusGetMaximumSetGen()
        {
            // Generated from example definition: specification/managednetworkfabric/resource-manager/Microsoft.ManagedNetworkFabric/stable/2023-06-15/examples/NetworkDeviceSkus_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "NetworkDeviceSkus_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "1234ABCD-0A1B-1234-5678-123456ABCDEF";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // get the collection of this NetworkDeviceSkuResource
            NetworkDeviceSkuCollection collection = subscriptionResource.GetNetworkDeviceSkus();

            // invoke the operation
            string networkDeviceSkuName = "example-deviceSku";
            NetworkDeviceSkuResource result = await collection.GetAsync(networkDeviceSkuName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkDeviceSkuData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_NetworkDeviceSkusListBySubscriptionMaximumSetGen()
        {
            // Generated from example definition: specification/managednetworkfabric/resource-manager/Microsoft.ManagedNetworkFabric/stable/2023-06-15/examples/NetworkDeviceSkus_ListBySubscription_MaximumSet_Gen.json
            // this example is just showing the usage of "NetworkDeviceSkus_ListBySubscription" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "1234ABCD-0A1B-1234-5678-123456ABCDEF";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // get the collection of this NetworkDeviceSkuResource
            NetworkDeviceSkuCollection collection = subscriptionResource.GetNetworkDeviceSkus();

            // invoke the operation and iterate over the result
            await foreach (NetworkDeviceSkuResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                NetworkDeviceSkuData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_NetworkDeviceSkusGetMaximumSetGen()
        {
            // Generated from example definition: specification/managednetworkfabric/resource-manager/Microsoft.ManagedNetworkFabric/stable/2023-06-15/examples/NetworkDeviceSkus_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "NetworkDeviceSkus_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "1234ABCD-0A1B-1234-5678-123456ABCDEF";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // get the collection of this NetworkDeviceSkuResource
            NetworkDeviceSkuCollection collection = subscriptionResource.GetNetworkDeviceSkus();

            // invoke the operation
            string networkDeviceSkuName = "example-deviceSku";
            bool result = await collection.ExistsAsync(networkDeviceSkuName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_NetworkDeviceSkusGetMaximumSetGen()
        {
            // Generated from example definition: specification/managednetworkfabric/resource-manager/Microsoft.ManagedNetworkFabric/stable/2023-06-15/examples/NetworkDeviceSkus_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "NetworkDeviceSkus_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "1234ABCD-0A1B-1234-5678-123456ABCDEF";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // get the collection of this NetworkDeviceSkuResource
            NetworkDeviceSkuCollection collection = subscriptionResource.GetNetworkDeviceSkus();

            // invoke the operation
            string networkDeviceSkuName = "example-deviceSku";
            NullableResponse<NetworkDeviceSkuResource> response = await collection.GetIfExistsAsync(networkDeviceSkuName);
            NetworkDeviceSkuResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                NetworkDeviceSkuData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}

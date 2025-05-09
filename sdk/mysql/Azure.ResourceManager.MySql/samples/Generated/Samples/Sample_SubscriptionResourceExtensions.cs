// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.MySql.FlexibleServers.Models;
using Azure.ResourceManager.Resources;
using NUnit.Framework;

namespace Azure.ResourceManager.MySql.FlexibleServers.Samples
{
    public partial class Sample_SubscriptionResourceExtensions
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetMySqlFlexibleServers_ListServersInASubscription()
        {
            // Generated from example definition: specification/mysql/resource-manager/Microsoft.DBforMySQL/FlexibleServers/stable/2023-12-30/examples/ServersList.json
            // this example is just showing the usage of "Servers_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (MySqlFlexibleServerResource item in subscriptionResource.GetMySqlFlexibleServersAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MySqlFlexibleServerData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetLocationBasedCapabilities_CapabilitiesList()
        {
            // Generated from example definition: specification/mysql/resource-manager/Microsoft.DBforMySQL/ServiceOperations/stable/2023-12-30/examples/CapabilitiesByLocationList.json
            // this example is just showing the usage of "LocationBasedCapabilities_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            AzureLocation locationName = new AzureLocation("WestUS");
            await foreach (MySqlFlexibleServerCapabilityProperties item in subscriptionResource.GetLocationBasedCapabilitiesAsync(locationName))
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task ExecuteCheckVirtualNetworkSubnetUsage_CheckVirtualNetworkSubnetUsage()
        {
            // Generated from example definition: specification/mysql/resource-manager/Microsoft.DBforMySQL/ServiceOperations/stable/2023-12-30/examples/CheckVirtualNetworkSubnetUsage.json
            // this example is just showing the usage of "CheckVirtualNetworkSubnetUsage_Execute" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation
            AzureLocation locationName = new AzureLocation("WestUS");
            MySqlFlexibleServerVirtualNetworkSubnetUsageParameter mySqlFlexibleServerVirtualNetworkSubnetUsageParameter = new MySqlFlexibleServerVirtualNetworkSubnetUsageParameter
            {
                VirtualNetworkResourceId = new ResourceIdentifier("/subscriptions/ffffffff-ffff-ffff-ffff-ffffffffffff/resourceGroups/testrg/providers/Microsoft.Network/virtualNetworks/testvnet"),
            };
            MySqlFlexibleServerVirtualNetworkSubnetUsageResult result = await subscriptionResource.ExecuteCheckVirtualNetworkSubnetUsageAsync(locationName, mySqlFlexibleServerVirtualNetworkSubnetUsageParameter);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CheckMySqlFlexibleServerNameAvailability_CheckNameAvailability()
        {
            // Generated from example definition: specification/mysql/resource-manager/Microsoft.DBforMySQL/ServiceOperations/stable/2023-12-30/examples/CheckNameAvailability.json
            // this example is just showing the usage of "CheckNameAvailability_Execute" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation
            AzureLocation locationName = new AzureLocation("SouthEastAsia");
            MySqlFlexibleServerNameAvailabilityContent content = new MySqlFlexibleServerNameAvailabilityContent("name1")
            {
                ResourceType = new ResourceType("Microsoft.DBforMySQL/flexibleServers"),
            };
            MySqlFlexibleServerNameAvailabilityResult result = await subscriptionResource.CheckMySqlFlexibleServerNameAvailabilityAsync(locationName, content);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CheckMySqlFlexibleServerNameAvailabilityWithoutLocation_CheckNameAvailability()
        {
            // Generated from example definition: specification/mysql/resource-manager/Microsoft.DBforMySQL/ServiceOperations/stable/2023-12-30/examples/CheckNameAvailability.json
            // this example is just showing the usage of "CheckNameAvailabilityWithoutLocation_Execute" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation
            MySqlFlexibleServerNameAvailabilityContent content = new MySqlFlexibleServerNameAvailabilityContent("name1")
            {
                ResourceType = new ResourceType("Microsoft.DBforMySQL/flexibleServers"),
            };
            MySqlFlexibleServerNameAvailabilityResult result = await subscriptionResource.CheckMySqlFlexibleServerNameAvailabilityWithoutLocationAsync(content);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetOperationResult_OperationResultsGet()
        {
            // Generated from example definition: specification/mysql/resource-manager/Microsoft.DBforMySQL/ServiceOperations/stable/2023-12-30/examples/OperationResults_Get.json
            // this example is just showing the usage of "OperationResults_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation
            AzureLocation locationName = new AzureLocation("westus");
            string operationId = "00000000-0000-0000-0000-000000000000";
            OperationStatusExtendedResult result = await subscriptionResource.GetOperationResultAsync(locationName, operationId);

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}

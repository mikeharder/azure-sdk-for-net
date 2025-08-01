// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Sql.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Sql.Samples
{
    public partial class Sample_DataWarehouseUserActivityResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetTheListOfTheUserActivitiesOfADataWarehouse()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2024-11-01-preview/examples/GetDataWarehouseUserActivities.json
            // this example is just showing the usage of "DataWarehouseUserActivities_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataWarehouseUserActivityResource created on azure
            // for more information of creating DataWarehouseUserActivityResource, please refer to the document of DataWarehouseUserActivityResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "Default-SQL-SouthEastAsia";
            string serverName = "testsvr";
            string databaseName = "testdb";
            DataWarehouseUserActivityName dataWarehouseUserActivityName = DataWarehouseUserActivityName.Current;
            ResourceIdentifier dataWarehouseUserActivityResourceId = DataWarehouseUserActivityResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, databaseName, dataWarehouseUserActivityName);
            DataWarehouseUserActivityResource dataWarehouseUserActivity = client.GetDataWarehouseUserActivityResource(dataWarehouseUserActivityResourceId);

            // invoke the operation
            DataWarehouseUserActivityResource result = await dataWarehouseUserActivity.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DataWarehouseUserActivityData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}

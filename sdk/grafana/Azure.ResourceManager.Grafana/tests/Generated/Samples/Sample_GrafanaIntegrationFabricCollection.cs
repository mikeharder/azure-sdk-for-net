// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Grafana.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Grafana.Samples
{
    public partial class Sample_GrafanaIntegrationFabricCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_IntegrationFabricsCreate()
        {
            // Generated from example definition: 2024-11-01-preview/IntegrationFabrics_Create.json
            // this example is just showing the usage of "IntegrationFabric_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagedGrafanaResource created on azure
            // for more information of creating ManagedGrafanaResource, please refer to the document of ManagedGrafanaResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string workspaceName = "myWorkspace";
            ResourceIdentifier managedGrafanaResourceId = ManagedGrafanaResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            ManagedGrafanaResource managedGrafana = client.GetManagedGrafanaResource(managedGrafanaResourceId);

            // get the collection of this GrafanaIntegrationFabricResource
            GrafanaIntegrationFabricCollection collection = managedGrafana.GetGrafanaIntegrationFabrics();

            // invoke the operation
            string integrationFabricName = "sampleIntegration";
            GrafanaIntegrationFabricData data = new GrafanaIntegrationFabricData(new AzureLocation("West US"))
            {
                Properties = new GrafanaIntegrationFabricProperties
                {
                    TargetResourceId = new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/myResourceGroup/providers/Microsoft.ContainerService/managedClusters/myAks"),
                    DataSourceResourceId = new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/myResourceGroup/providers/Microsoft.Monitor/accounts/myAmw"),
                    Scenarios = { "scenario1", "scenario2" },
                },
            };
            ArmOperation<GrafanaIntegrationFabricResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, integrationFabricName, data);
            GrafanaIntegrationFabricResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            GrafanaIntegrationFabricData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_IntegrationFabricsGet()
        {
            // Generated from example definition: 2024-11-01-preview/IntegrationFabrics_Get.json
            // this example is just showing the usage of "IntegrationFabric_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagedGrafanaResource created on azure
            // for more information of creating ManagedGrafanaResource, please refer to the document of ManagedGrafanaResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string workspaceName = "myWorkspace";
            ResourceIdentifier managedGrafanaResourceId = ManagedGrafanaResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            ManagedGrafanaResource managedGrafana = client.GetManagedGrafanaResource(managedGrafanaResourceId);

            // get the collection of this GrafanaIntegrationFabricResource
            GrafanaIntegrationFabricCollection collection = managedGrafana.GetGrafanaIntegrationFabrics();

            // invoke the operation
            string integrationFabricName = "sampleIntegration";
            GrafanaIntegrationFabricResource result = await collection.GetAsync(integrationFabricName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            GrafanaIntegrationFabricData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_IntegrationFabricsList()
        {
            // Generated from example definition: 2024-11-01-preview/IntegrationFabrics_List.json
            // this example is just showing the usage of "IntegrationFabric_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagedGrafanaResource created on azure
            // for more information of creating ManagedGrafanaResource, please refer to the document of ManagedGrafanaResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string workspaceName = "myWorkspace";
            ResourceIdentifier managedGrafanaResourceId = ManagedGrafanaResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            ManagedGrafanaResource managedGrafana = client.GetManagedGrafanaResource(managedGrafanaResourceId);

            // get the collection of this GrafanaIntegrationFabricResource
            GrafanaIntegrationFabricCollection collection = managedGrafana.GetGrafanaIntegrationFabrics();

            // invoke the operation and iterate over the result
            await foreach (GrafanaIntegrationFabricResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                GrafanaIntegrationFabricData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_IntegrationFabricsGet()
        {
            // Generated from example definition: 2024-11-01-preview/IntegrationFabrics_Get.json
            // this example is just showing the usage of "IntegrationFabric_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagedGrafanaResource created on azure
            // for more information of creating ManagedGrafanaResource, please refer to the document of ManagedGrafanaResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string workspaceName = "myWorkspace";
            ResourceIdentifier managedGrafanaResourceId = ManagedGrafanaResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            ManagedGrafanaResource managedGrafana = client.GetManagedGrafanaResource(managedGrafanaResourceId);

            // get the collection of this GrafanaIntegrationFabricResource
            GrafanaIntegrationFabricCollection collection = managedGrafana.GetGrafanaIntegrationFabrics();

            // invoke the operation
            string integrationFabricName = "sampleIntegration";
            bool result = await collection.ExistsAsync(integrationFabricName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_IntegrationFabricsGet()
        {
            // Generated from example definition: 2024-11-01-preview/IntegrationFabrics_Get.json
            // this example is just showing the usage of "IntegrationFabric_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagedGrafanaResource created on azure
            // for more information of creating ManagedGrafanaResource, please refer to the document of ManagedGrafanaResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string workspaceName = "myWorkspace";
            ResourceIdentifier managedGrafanaResourceId = ManagedGrafanaResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            ManagedGrafanaResource managedGrafana = client.GetManagedGrafanaResource(managedGrafanaResourceId);

            // get the collection of this GrafanaIntegrationFabricResource
            GrafanaIntegrationFabricCollection collection = managedGrafana.GetGrafanaIntegrationFabrics();

            // invoke the operation
            string integrationFabricName = "sampleIntegration";
            NullableResponse<GrafanaIntegrationFabricResource> response = await collection.GetIfExistsAsync(integrationFabricName);
            GrafanaIntegrationFabricResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                GrafanaIntegrationFabricData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}

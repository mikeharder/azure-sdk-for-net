// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.AppService.Samples
{
    public partial class Sample_StaticSiteUserProvidedFunctionAppCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_RegisterAUserProvidedFunctionAppWithAStaticSite()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2024-11-01/examples/RegisterUserProvidedFunctionAppWithStaticSite.json
            // this example is just showing the usage of "StaticSites_RegisterUserProvidedFunctionAppWithStaticSite" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StaticSiteResource created on azure
            // for more information of creating StaticSiteResource, please refer to the document of StaticSiteResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "rg";
            string name = "testStaticSite0";
            ResourceIdentifier staticSiteResourceId = StaticSiteResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name);
            StaticSiteResource staticSite = client.GetStaticSiteResource(staticSiteResourceId);

            // get the collection of this StaticSiteUserProvidedFunctionAppResource
            StaticSiteUserProvidedFunctionAppCollection collection = staticSite.GetStaticSiteUserProvidedFunctionApps();

            // invoke the operation
            string functionAppName = "testFunctionApp";
            StaticSiteUserProvidedFunctionAppData data = new StaticSiteUserProvidedFunctionAppData
            {
                FunctionAppResourceId = new ResourceIdentifier("/subscription/34adfa4f-cedf-4dc0-ba29-b6d1a69ab345/resourceGroups/functionRG/providers/Microsoft.Web/sites/testFunctionApp"),
                FunctionAppRegion = "West US 2",
            };
            bool? isForced = true;
            ArmOperation<StaticSiteUserProvidedFunctionAppResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, functionAppName, data, isForced: isForced);
            StaticSiteUserProvidedFunctionAppResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StaticSiteUserProvidedFunctionAppData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetDetailsOfTheUserProvidedFunctionAppRegisteredWithAStaticSite()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2024-11-01/examples/GetUserProvidedFunctionAppForStaticSite.json
            // this example is just showing the usage of "StaticSites_GetUserProvidedFunctionAppForStaticSite" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StaticSiteResource created on azure
            // for more information of creating StaticSiteResource, please refer to the document of StaticSiteResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "rg";
            string name = "testStaticSite0";
            ResourceIdentifier staticSiteResourceId = StaticSiteResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name);
            StaticSiteResource staticSite = client.GetStaticSiteResource(staticSiteResourceId);

            // get the collection of this StaticSiteUserProvidedFunctionAppResource
            StaticSiteUserProvidedFunctionAppCollection collection = staticSite.GetStaticSiteUserProvidedFunctionApps();

            // invoke the operation
            string functionAppName = "testFunctionApp";
            StaticSiteUserProvidedFunctionAppResource result = await collection.GetAsync(functionAppName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StaticSiteUserProvidedFunctionAppData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_GetDetailsOfTheUserProvidedFunctionAppsRegisteredWithAStaticSite()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2024-11-01/examples/GetUserProvidedFunctionAppsForStaticSite.json
            // this example is just showing the usage of "StaticSites_GetUserProvidedFunctionAppsForStaticSite" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StaticSiteResource created on azure
            // for more information of creating StaticSiteResource, please refer to the document of StaticSiteResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "rg";
            string name = "testStaticSite0";
            ResourceIdentifier staticSiteResourceId = StaticSiteResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name);
            StaticSiteResource staticSite = client.GetStaticSiteResource(staticSiteResourceId);

            // get the collection of this StaticSiteUserProvidedFunctionAppResource
            StaticSiteUserProvidedFunctionAppCollection collection = staticSite.GetStaticSiteUserProvidedFunctionApps();

            // invoke the operation and iterate over the result
            await foreach (StaticSiteUserProvidedFunctionAppResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                StaticSiteUserProvidedFunctionAppData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetDetailsOfTheUserProvidedFunctionAppRegisteredWithAStaticSite()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2024-11-01/examples/GetUserProvidedFunctionAppForStaticSite.json
            // this example is just showing the usage of "StaticSites_GetUserProvidedFunctionAppForStaticSite" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StaticSiteResource created on azure
            // for more information of creating StaticSiteResource, please refer to the document of StaticSiteResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "rg";
            string name = "testStaticSite0";
            ResourceIdentifier staticSiteResourceId = StaticSiteResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name);
            StaticSiteResource staticSite = client.GetStaticSiteResource(staticSiteResourceId);

            // get the collection of this StaticSiteUserProvidedFunctionAppResource
            StaticSiteUserProvidedFunctionAppCollection collection = staticSite.GetStaticSiteUserProvidedFunctionApps();

            // invoke the operation
            string functionAppName = "testFunctionApp";
            bool result = await collection.ExistsAsync(functionAppName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetDetailsOfTheUserProvidedFunctionAppRegisteredWithAStaticSite()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2024-11-01/examples/GetUserProvidedFunctionAppForStaticSite.json
            // this example is just showing the usage of "StaticSites_GetUserProvidedFunctionAppForStaticSite" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StaticSiteResource created on azure
            // for more information of creating StaticSiteResource, please refer to the document of StaticSiteResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "rg";
            string name = "testStaticSite0";
            ResourceIdentifier staticSiteResourceId = StaticSiteResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name);
            StaticSiteResource staticSite = client.GetStaticSiteResource(staticSiteResourceId);

            // get the collection of this StaticSiteUserProvidedFunctionAppResource
            StaticSiteUserProvidedFunctionAppCollection collection = staticSite.GetStaticSiteUserProvidedFunctionApps();

            // invoke the operation
            string functionAppName = "testFunctionApp";
            NullableResponse<StaticSiteUserProvidedFunctionAppResource> response = await collection.GetIfExistsAsync(functionAppName);
            StaticSiteUserProvidedFunctionAppResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                StaticSiteUserProvidedFunctionAppData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}

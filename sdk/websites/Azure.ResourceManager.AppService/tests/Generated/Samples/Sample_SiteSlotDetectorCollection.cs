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
    public partial class Sample_SiteSlotDetectorCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetAppDetectorResponse()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2024-11-01/examples/Diagnostics_GetSiteDetectorResponse.json
            // this example is just showing the usage of "Diagnostics_GetSiteDetectorResponseSlot" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WebSiteSlotResource created on azure
            // for more information of creating WebSiteSlotResource, please refer to the document of WebSiteSlotResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "Sample-WestUSResourceGroup";
            string siteName = "SampleApp";
            string slot = "staging";
            ResourceIdentifier webSiteSlotResourceId = WebSiteSlotResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, siteName, slot);
            WebSiteSlotResource webSiteSlot = client.GetWebSiteSlotResource(webSiteSlotResourceId);

            // get the collection of this SiteSlotDetectorResource
            SiteSlotDetectorCollection collection = webSiteSlot.GetSiteSlotDetectors();

            // invoke the operation
            string detectorName = "runtimeavailability";
            SiteSlotDetectorResource result = await collection.GetAsync(detectorName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AppServiceDetectorData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetAppSlotDetectorResponse()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2024-11-01/examples/Diagnostics_GetSiteDetectorResponseSlot.json
            // this example is just showing the usage of "Diagnostics_GetSiteDetectorResponseSlot" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WebSiteSlotResource created on azure
            // for more information of creating WebSiteSlotResource, please refer to the document of WebSiteSlotResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "Sample-WestUSResourceGroup";
            string siteName = "SampleApp";
            string slot = "staging";
            ResourceIdentifier webSiteSlotResourceId = WebSiteSlotResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, siteName, slot);
            WebSiteSlotResource webSiteSlot = client.GetWebSiteSlotResource(webSiteSlotResourceId);

            // get the collection of this SiteSlotDetectorResource
            SiteSlotDetectorCollection collection = webSiteSlot.GetSiteSlotDetectors();

            // invoke the operation
            string detectorName = "runtimeavailability";
            SiteSlotDetectorResource result = await collection.GetAsync(detectorName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AppServiceDetectorData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_GetAppDetectorResponses()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2024-11-01/examples/Diagnostics_ListSiteDetectorResponses.json
            // this example is just showing the usage of "Diagnostics_ListSiteDetectorResponsesSlot" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WebSiteSlotResource created on azure
            // for more information of creating WebSiteSlotResource, please refer to the document of WebSiteSlotResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "Sample-WestUSResourceGroup";
            string siteName = "SampleApp";
            string slot = "staging";
            ResourceIdentifier webSiteSlotResourceId = WebSiteSlotResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, siteName, slot);
            WebSiteSlotResource webSiteSlot = client.GetWebSiteSlotResource(webSiteSlotResourceId);

            // get the collection of this SiteSlotDetectorResource
            SiteSlotDetectorCollection collection = webSiteSlot.GetSiteSlotDetectors();

            // invoke the operation and iterate over the result
            await foreach (SiteSlotDetectorResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                AppServiceDetectorData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_GetAppSlotDetectorResponses()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2024-11-01/examples/Diagnostics_ListSiteDetectorResponsesSlot.json
            // this example is just showing the usage of "Diagnostics_ListSiteDetectorResponsesSlot" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WebSiteSlotResource created on azure
            // for more information of creating WebSiteSlotResource, please refer to the document of WebSiteSlotResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "Sample-WestUSResourceGroup";
            string siteName = "SampleApp";
            string slot = "staging";
            ResourceIdentifier webSiteSlotResourceId = WebSiteSlotResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, siteName, slot);
            WebSiteSlotResource webSiteSlot = client.GetWebSiteSlotResource(webSiteSlotResourceId);

            // get the collection of this SiteSlotDetectorResource
            SiteSlotDetectorCollection collection = webSiteSlot.GetSiteSlotDetectors();

            // invoke the operation and iterate over the result
            await foreach (SiteSlotDetectorResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                AppServiceDetectorData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetAppDetectorResponse()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2024-11-01/examples/Diagnostics_GetSiteDetectorResponse.json
            // this example is just showing the usage of "Diagnostics_GetSiteDetectorResponseSlot" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WebSiteSlotResource created on azure
            // for more information of creating WebSiteSlotResource, please refer to the document of WebSiteSlotResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "Sample-WestUSResourceGroup";
            string siteName = "SampleApp";
            string slot = "staging";
            ResourceIdentifier webSiteSlotResourceId = WebSiteSlotResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, siteName, slot);
            WebSiteSlotResource webSiteSlot = client.GetWebSiteSlotResource(webSiteSlotResourceId);

            // get the collection of this SiteSlotDetectorResource
            SiteSlotDetectorCollection collection = webSiteSlot.GetSiteSlotDetectors();

            // invoke the operation
            string detectorName = "runtimeavailability";
            bool result = await collection.ExistsAsync(detectorName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetAppSlotDetectorResponse()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2024-11-01/examples/Diagnostics_GetSiteDetectorResponseSlot.json
            // this example is just showing the usage of "Diagnostics_GetSiteDetectorResponseSlot" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WebSiteSlotResource created on azure
            // for more information of creating WebSiteSlotResource, please refer to the document of WebSiteSlotResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "Sample-WestUSResourceGroup";
            string siteName = "SampleApp";
            string slot = "staging";
            ResourceIdentifier webSiteSlotResourceId = WebSiteSlotResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, siteName, slot);
            WebSiteSlotResource webSiteSlot = client.GetWebSiteSlotResource(webSiteSlotResourceId);

            // get the collection of this SiteSlotDetectorResource
            SiteSlotDetectorCollection collection = webSiteSlot.GetSiteSlotDetectors();

            // invoke the operation
            string detectorName = "runtimeavailability";
            bool result = await collection.ExistsAsync(detectorName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetAppDetectorResponse()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2024-11-01/examples/Diagnostics_GetSiteDetectorResponse.json
            // this example is just showing the usage of "Diagnostics_GetSiteDetectorResponseSlot" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WebSiteSlotResource created on azure
            // for more information of creating WebSiteSlotResource, please refer to the document of WebSiteSlotResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "Sample-WestUSResourceGroup";
            string siteName = "SampleApp";
            string slot = "staging";
            ResourceIdentifier webSiteSlotResourceId = WebSiteSlotResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, siteName, slot);
            WebSiteSlotResource webSiteSlot = client.GetWebSiteSlotResource(webSiteSlotResourceId);

            // get the collection of this SiteSlotDetectorResource
            SiteSlotDetectorCollection collection = webSiteSlot.GetSiteSlotDetectors();

            // invoke the operation
            string detectorName = "runtimeavailability";
            NullableResponse<SiteSlotDetectorResource> response = await collection.GetIfExistsAsync(detectorName);
            SiteSlotDetectorResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                AppServiceDetectorData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetAppSlotDetectorResponse()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2024-11-01/examples/Diagnostics_GetSiteDetectorResponseSlot.json
            // this example is just showing the usage of "Diagnostics_GetSiteDetectorResponseSlot" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WebSiteSlotResource created on azure
            // for more information of creating WebSiteSlotResource, please refer to the document of WebSiteSlotResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "Sample-WestUSResourceGroup";
            string siteName = "SampleApp";
            string slot = "staging";
            ResourceIdentifier webSiteSlotResourceId = WebSiteSlotResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, siteName, slot);
            WebSiteSlotResource webSiteSlot = client.GetWebSiteSlotResource(webSiteSlotResourceId);

            // get the collection of this SiteSlotDetectorResource
            SiteSlotDetectorCollection collection = webSiteSlot.GetSiteSlotDetectors();

            // invoke the operation
            string detectorName = "runtimeavailability";
            NullableResponse<SiteSlotDetectorResource> response = await collection.GetIfExistsAsync(detectorName);
            SiteSlotDetectorResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                AppServiceDetectorData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}

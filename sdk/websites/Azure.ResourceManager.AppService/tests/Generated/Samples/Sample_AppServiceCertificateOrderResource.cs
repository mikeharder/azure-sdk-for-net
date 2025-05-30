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
    public partial class Sample_AppServiceCertificateOrderResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetAppServiceCertificateOrder()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.CertificateRegistration/stable/2024-11-01/examples/GetAppServiceCertificateOrder.json
            // this example is just showing the usage of "AppServiceCertificateOrders_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AppServiceCertificateOrderResource created on azure
            // for more information of creating AppServiceCertificateOrderResource, please refer to the document of AppServiceCertificateOrderResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "testrg123";
            string certificateOrderName = "SampleCertificateOrderName";
            ResourceIdentifier appServiceCertificateOrderResourceId = AppServiceCertificateOrderResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, certificateOrderName);
            AppServiceCertificateOrderResource appServiceCertificateOrder = client.GetAppServiceCertificateOrderResource(appServiceCertificateOrderResourceId);

            // invoke the operation
            AppServiceCertificateOrderResource result = await appServiceCertificateOrder.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AppServiceCertificateOrderData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeleteAppServiceCertificateOrder()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.CertificateRegistration/stable/2024-11-01/examples/DeleteAppServiceCertificateOrder.json
            // this example is just showing the usage of "AppServiceCertificateOrders_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AppServiceCertificateOrderResource created on azure
            // for more information of creating AppServiceCertificateOrderResource, please refer to the document of AppServiceCertificateOrderResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "testrg123";
            string certificateOrderName = "SampleCertificateOrderName";
            ResourceIdentifier appServiceCertificateOrderResourceId = AppServiceCertificateOrderResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, certificateOrderName);
            AppServiceCertificateOrderResource appServiceCertificateOrder = client.GetAppServiceCertificateOrderResource(appServiceCertificateOrderResourceId);

            // invoke the operation
            await appServiceCertificateOrder.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_UpdateCertificateOrder()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.CertificateRegistration/stable/2024-11-01/examples/UpdateAppServiceCertificateOrder.json
            // this example is just showing the usage of "AppServiceCertificateOrders_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AppServiceCertificateOrderResource created on azure
            // for more information of creating AppServiceCertificateOrderResource, please refer to the document of AppServiceCertificateOrderResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "testrg123";
            string certificateOrderName = "SampleCertificateOrderName";
            ResourceIdentifier appServiceCertificateOrderResourceId = AppServiceCertificateOrderResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, certificateOrderName);
            AppServiceCertificateOrderResource appServiceCertificateOrder = client.GetAppServiceCertificateOrderResource(appServiceCertificateOrderResourceId);

            // invoke the operation
            AppServiceCertificateOrderPatch patch = new AppServiceCertificateOrderPatch
            {
                Certificates =
{
["SampleCertName1"] = new AppServiceCertificateProperties
{
KeyVaultId = new ResourceIdentifier("/subscriptions/34adfa4f-cedf-4dc0-ba29-b6d1a69ab345/resourcegroups/testrg123/providers/microsoft.keyvault/vaults/SamplevaultName"),
KeyVaultSecretName = "SampleSecretName1",
},
["SampleCertName2"] = new AppServiceCertificateProperties
{
KeyVaultId = new ResourceIdentifier("/subscriptions/34adfa4f-cedf-4dc0-ba29-b6d1a69ab345/resourcegroups/testrg123/providers/microsoft.keyvault/vaults/SamplevaultName"),
KeyVaultSecretName = "SampleSecretName2",
}
},
                DistinguishedName = "CN=SampleCustomDomain.com",
                ValidityInYears = 2,
                KeySize = 2048,
                ProductType = CertificateProductType.StandardDomainValidatedSsl,
                IsAutoRenew = true,
            };
            AppServiceCertificateOrderResource result = await appServiceCertificateOrder.UpdateAsync(patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AppServiceCertificateOrderData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Reissue_ReissueAppServiceCertificateOrder()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.CertificateRegistration/stable/2024-11-01/examples/ReissueAppServiceCertificateOrder.json
            // this example is just showing the usage of "AppServiceCertificateOrders_Reissue" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AppServiceCertificateOrderResource created on azure
            // for more information of creating AppServiceCertificateOrderResource, please refer to the document of AppServiceCertificateOrderResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "testrg123";
            string certificateOrderName = "SampleCertificateOrderName";
            ResourceIdentifier appServiceCertificateOrderResourceId = AppServiceCertificateOrderResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, certificateOrderName);
            AppServiceCertificateOrderResource appServiceCertificateOrder = client.GetAppServiceCertificateOrderResource(appServiceCertificateOrderResourceId);

            // invoke the operation
            ReissueCertificateOrderContent content = new ReissueCertificateOrderContent
            {
                KeySize = 2048,
                DelayExistingRevokeInHours = 2,
                Csr = "CSR1223238Value",
                IsPrivateKeyExternal = false,
            };
            await appServiceCertificateOrder.ReissueAsync(content);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Renew_RenewAppServiceCertificateOrder()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.CertificateRegistration/stable/2024-11-01/examples/RenewAppServiceCertificateOrder.json
            // this example is just showing the usage of "AppServiceCertificateOrders_Renew" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AppServiceCertificateOrderResource created on azure
            // for more information of creating AppServiceCertificateOrderResource, please refer to the document of AppServiceCertificateOrderResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "testrg123";
            string certificateOrderName = "SampleCertificateOrderName";
            ResourceIdentifier appServiceCertificateOrderResourceId = AppServiceCertificateOrderResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, certificateOrderName);
            AppServiceCertificateOrderResource appServiceCertificateOrder = client.GetAppServiceCertificateOrderResource(appServiceCertificateOrderResourceId);

            // invoke the operation
            RenewCertificateOrderContent content = new RenewCertificateOrderContent
            {
                KeySize = 2048,
                Csr = "CSR1223238Value",
                IsPrivateKeyExternal = false,
            };
            await appServiceCertificateOrder.RenewAsync(content);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task ResendEmail_ResendAppServiceCertificateOrderEmail()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.CertificateRegistration/stable/2024-11-01/examples/ResendAppServiceCertificateOrderEmail.json
            // this example is just showing the usage of "AppServiceCertificateOrders_ResendEmail" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AppServiceCertificateOrderResource created on azure
            // for more information of creating AppServiceCertificateOrderResource, please refer to the document of AppServiceCertificateOrderResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "testrg123";
            string certificateOrderName = "SampleCertificateOrderName";
            ResourceIdentifier appServiceCertificateOrderResourceId = AppServiceCertificateOrderResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, certificateOrderName);
            AppServiceCertificateOrderResource appServiceCertificateOrder = client.GetAppServiceCertificateOrderResource(appServiceCertificateOrderResourceId);

            // invoke the operation
            await appServiceCertificateOrder.ResendEmailAsync();

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task ResendRequestEmails_ResendDomainOwnershipVerificationEmail()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.CertificateRegistration/stable/2024-11-01/examples/ResendDomainOwnershipVerificationEmail.json
            // this example is just showing the usage of "AppServiceCertificateOrders_ResendRequestEmails" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AppServiceCertificateOrderResource created on azure
            // for more information of creating AppServiceCertificateOrderResource, please refer to the document of AppServiceCertificateOrderResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "testrg123";
            string certificateOrderName = "SampleCertificateOrderName";
            ResourceIdentifier appServiceCertificateOrderResourceId = AppServiceCertificateOrderResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, certificateOrderName);
            AppServiceCertificateOrderResource appServiceCertificateOrder = client.GetAppServiceCertificateOrderResource(appServiceCertificateOrderResourceId);

            // invoke the operation
            AppServiceDomainNameIdentifier nameIdentifier = new AppServiceDomainNameIdentifier
            {
                Name = "Domain name",
            };
            await appServiceCertificateOrder.ResendRequestEmailsAsync(nameIdentifier);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task RetrieveSiteSeal_RetrieveSiteSeal()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.CertificateRegistration/stable/2024-11-01/examples/RetrieveSiteSeal.json
            // this example is just showing the usage of "AppServiceCertificateOrders_RetrieveSiteSeal" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AppServiceCertificateOrderResource created on azure
            // for more information of creating AppServiceCertificateOrderResource, please refer to the document of AppServiceCertificateOrderResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "testrg123";
            string certificateOrderName = "SampleCertOrder";
            ResourceIdentifier appServiceCertificateOrderResourceId = AppServiceCertificateOrderResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, certificateOrderName);
            AppServiceCertificateOrderResource appServiceCertificateOrder = client.GetAppServiceCertificateOrderResource(appServiceCertificateOrderResourceId);

            // invoke the operation
            SiteSealContent content = new SiteSealContent
            {
                IsLightTheme = true,
                Locale = "en-us",
            };
            SiteSeal result = await appServiceCertificateOrder.RetrieveSiteSealAsync(content);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task VerifyDomainOwnership_VerifyDomainOwnership()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.CertificateRegistration/stable/2024-11-01/examples/VerifyDomainOwnership.json
            // this example is just showing the usage of "AppServiceCertificateOrders_VerifyDomainOwnership" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AppServiceCertificateOrderResource created on azure
            // for more information of creating AppServiceCertificateOrderResource, please refer to the document of AppServiceCertificateOrderResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "testrg123";
            string certificateOrderName = "SampleCertificateOrderName";
            ResourceIdentifier appServiceCertificateOrderResourceId = AppServiceCertificateOrderResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, certificateOrderName);
            AppServiceCertificateOrderResource appServiceCertificateOrder = client.GetAppServiceCertificateOrderResource(appServiceCertificateOrderResourceId);

            // invoke the operation
            await appServiceCertificateOrder.VerifyDomainOwnershipAsync();

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task RetrieveCertificateActions_RetrieveCertificateOrderActions()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.CertificateRegistration/stable/2024-11-01/examples/RetrieveCertificateOrderActions.json
            // this example is just showing the usage of "AppServiceCertificateOrders_RetrieveCertificateActions" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AppServiceCertificateOrderResource created on azure
            // for more information of creating AppServiceCertificateOrderResource, please refer to the document of AppServiceCertificateOrderResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "testrg123";
            string name = "SampleCertOrder";
            ResourceIdentifier appServiceCertificateOrderResourceId = AppServiceCertificateOrderResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name);
            AppServiceCertificateOrderResource appServiceCertificateOrder = client.GetAppServiceCertificateOrderResource(appServiceCertificateOrderResourceId);

            // invoke the operation and iterate over the result
            await foreach (CertificateOrderAction item in appServiceCertificateOrder.RetrieveCertificateActionsAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task RetrieveCertificateEmailHistory_RetrieveCertificateEmailHistory()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.CertificateRegistration/stable/2024-11-01/examples/RetrieveCertificateEmailHistory.json
            // this example is just showing the usage of "AppServiceCertificateOrders_RetrieveCertificateEmailHistory" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AppServiceCertificateOrderResource created on azure
            // for more information of creating AppServiceCertificateOrderResource, please refer to the document of AppServiceCertificateOrderResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "testrg123";
            string name = "SampleCertOrder";
            ResourceIdentifier appServiceCertificateOrderResourceId = AppServiceCertificateOrderResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name);
            AppServiceCertificateOrderResource appServiceCertificateOrder = client.GetAppServiceCertificateOrderResource(appServiceCertificateOrderResourceId);

            // invoke the operation and iterate over the result
            await foreach (AppServiceCertificateEmail item in appServiceCertificateOrder.RetrieveCertificateEmailHistoryAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine("Succeeded");
        }
    }
}

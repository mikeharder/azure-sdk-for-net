// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.OracleDatabase.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.OracleDatabase.Samples
{
    public partial class Sample_AutonomousDatabaseResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_AutonomousDatabasesUpdate()
        {
            // Generated from example definition: 2025-03-01/autonomousDatabase_patch.json
            // this example is just showing the usage of "AutonomousDatabase_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AutonomousDatabaseResource created on azure
            // for more information of creating AutonomousDatabaseResource, please refer to the document of AutonomousDatabaseResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg000";
            string autonomousdatabasename = "databasedb1";
            ResourceIdentifier autonomousDatabaseResourceId = AutonomousDatabaseResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, autonomousdatabasename);
            AutonomousDatabaseResource autonomousDatabase = client.GetAutonomousDatabaseResource(autonomousDatabaseResourceId);

            // invoke the operation
            AutonomousDatabasePatch patch = new AutonomousDatabasePatch();
            ArmOperation<AutonomousDatabaseResource> lro = await autonomousDatabase.UpdateAsync(WaitUntil.Completed, patch);
            AutonomousDatabaseResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AutonomousDatabaseData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Switchover_AutonomousDatabasesSwitchover()
        {
            // Generated from example definition: 2025-03-01/autonomousDatabase_switchover.json
            // this example is just showing the usage of "AutonomousDatabases_Switchover" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AutonomousDatabaseResource created on azure
            // for more information of creating AutonomousDatabaseResource, please refer to the document of AutonomousDatabaseResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg000";
            string autonomousdatabasename = "databasedb1";
            ResourceIdentifier autonomousDatabaseResourceId = AutonomousDatabaseResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, autonomousdatabasename);
            AutonomousDatabaseResource autonomousDatabase = client.GetAutonomousDatabaseResource(autonomousDatabaseResourceId);

            // invoke the operation
            AutonomousDatabaseActionContent content = new AutonomousDatabaseActionContent
            {
                PeerDBId = "peerDbId",
            };
            ArmOperation<AutonomousDatabaseResource> lro = await autonomousDatabase.SwitchoverAsync(WaitUntil.Completed, content);
            AutonomousDatabaseResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AutonomousDatabaseData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Failover_AutonomousDatabasesFailover()
        {
            // Generated from example definition: 2025-03-01/autonomousDatabase_failover.json
            // this example is just showing the usage of "AutonomousDatabases_Failover" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AutonomousDatabaseResource created on azure
            // for more information of creating AutonomousDatabaseResource, please refer to the document of AutonomousDatabaseResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg000";
            string autonomousdatabasename = "databasedb1";
            ResourceIdentifier autonomousDatabaseResourceId = AutonomousDatabaseResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, autonomousdatabasename);
            AutonomousDatabaseResource autonomousDatabase = client.GetAutonomousDatabaseResource(autonomousDatabaseResourceId);

            // invoke the operation
            AutonomousDatabaseActionContent content = new AutonomousDatabaseActionContent
            {
                PeerDBId = "peerDbId",
            };
            ArmOperation<AutonomousDatabaseResource> lro = await autonomousDatabase.FailoverAsync(WaitUntil.Completed, content);
            AutonomousDatabaseResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AutonomousDatabaseData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GenerateWallet_AutonomousDatabasesGenerateWallet()
        {
            // Generated from example definition: 2025-03-01/autonomousDatabase_generateWallet.json
            // this example is just showing the usage of "AutonomousDatabases_GenerateWallet" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AutonomousDatabaseResource created on azure
            // for more information of creating AutonomousDatabaseResource, please refer to the document of AutonomousDatabaseResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg000";
            string autonomousdatabasename = "databasedb1";
            ResourceIdentifier autonomousDatabaseResourceId = AutonomousDatabaseResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, autonomousdatabasename);
            AutonomousDatabaseResource autonomousDatabase = client.GetAutonomousDatabaseResource(autonomousDatabaseResourceId);

            // invoke the operation
            GenerateAutonomousDatabaseWalletDetails details = new GenerateAutonomousDatabaseWalletDetails("********")
            {
                GenerateType = WalletGenerateType.Single,
                IsRegional = false,
            };
            AutonomousDatabaseWalletFile result = await autonomousDatabase.GenerateWalletAsync(details);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Restore_AutonomousDatabasesRestore()
        {
            // Generated from example definition: 2025-03-01/autonomousDatabase_restore.json
            // this example is just showing the usage of "AutonomousDatabases_Restore" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AutonomousDatabaseResource created on azure
            // for more information of creating AutonomousDatabaseResource, please refer to the document of AutonomousDatabaseResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg000";
            string autonomousdatabasename = "databasedb1";
            ResourceIdentifier autonomousDatabaseResourceId = AutonomousDatabaseResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, autonomousdatabasename);
            AutonomousDatabaseResource autonomousDatabase = client.GetAutonomousDatabaseResource(autonomousDatabaseResourceId);

            // invoke the operation
            RestoreAutonomousDatabaseDetails details = new RestoreAutonomousDatabaseDetails(DateTimeOffset.Parse("2024-04-23T00:00:00.000Z"));
            ArmOperation<AutonomousDatabaseResource> lro = await autonomousDatabase.RestoreAsync(WaitUntil.Completed, details);
            AutonomousDatabaseResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AutonomousDatabaseData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task ChangeDisasterRecoveryConfiguration_AutonomousDatabasesChangeDisasterRecoveryConfiguration()
        {
            // Generated from example definition: 2025-03-01/autonomousDatabase_changeDisasterRecoveryConfiguration.json
            // this example is just showing the usage of "AutonomousDatabases_ChangeDisasterRecoveryConfiguration" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AutonomousDatabaseResource created on azure
            // for more information of creating AutonomousDatabaseResource, please refer to the document of AutonomousDatabaseResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg000";
            string autonomousdatabasename = "databasedb1";
            ResourceIdentifier autonomousDatabaseResourceId = AutonomousDatabaseResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, autonomousdatabasename);
            AutonomousDatabaseResource autonomousDatabase = client.GetAutonomousDatabaseResource(autonomousDatabaseResourceId);

            // invoke the operation
            DisasterRecoveryConfigurationDetails details = new DisasterRecoveryConfigurationDetails
            {
                DisasterRecoveryType = DisasterRecoveryType.Adg,
                IsReplicateAutomaticBackups = false,
            };
            ArmOperation<AutonomousDatabaseResource> lro = await autonomousDatabase.ChangeDisasterRecoveryConfigurationAsync(WaitUntil.Completed, details);
            AutonomousDatabaseResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AutonomousDatabaseData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}

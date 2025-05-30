// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.IotOperations.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.IotOperations.Samples
{
    public partial class Sample_IotOperationsDataflowResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_DataflowGet()
        {
            // Generated from example definition: 2024-11-01/Dataflow_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "DataflowResource_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IotOperationsDataflowResource created on azure
            // for more information of creating IotOperationsDataflowResource, please refer to the document of IotOperationsDataflowResource
            string subscriptionId = "F8C729F9-DF9C-4743-848F-96EE433D8E53";
            string resourceGroupName = "rgiotoperations";
            string instanceName = "resource-name123";
            string dataflowProfileName = "resource-name123";
            string dataflowName = "resource-name123";
            ResourceIdentifier iotOperationsDataflowResourceId = IotOperationsDataflowResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, instanceName, dataflowProfileName, dataflowName);
            IotOperationsDataflowResource iotOperationsDataflow = client.GetIotOperationsDataflowResource(iotOperationsDataflowResourceId);

            // invoke the operation
            IotOperationsDataflowResource result = await iotOperationsDataflow.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            IotOperationsDataflowData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DataflowDelete()
        {
            // Generated from example definition: 2024-11-01/Dataflow_Delete_MaximumSet_Gen.json
            // this example is just showing the usage of "DataflowResource_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IotOperationsDataflowResource created on azure
            // for more information of creating IotOperationsDataflowResource, please refer to the document of IotOperationsDataflowResource
            string subscriptionId = "F8C729F9-DF9C-4743-848F-96EE433D8E53";
            string resourceGroupName = "rgiotoperations";
            string instanceName = "resource-name123";
            string dataflowProfileName = "resource-name123";
            string dataflowName = "resource-name123";
            ResourceIdentifier iotOperationsDataflowResourceId = IotOperationsDataflowResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, instanceName, dataflowProfileName, dataflowName);
            IotOperationsDataflowResource iotOperationsDataflow = client.GetIotOperationsDataflowResource(iotOperationsDataflowResourceId);

            // invoke the operation
            await iotOperationsDataflow.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_DataflowCreateOrUpdateComplexContextualization()
        {
            // Generated from example definition: 2024-11-01/Dataflow_CreateOrUpdate_ComplexContextualization.json
            // this example is just showing the usage of "DataflowResource_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IotOperationsDataflowResource created on azure
            // for more information of creating IotOperationsDataflowResource, please refer to the document of IotOperationsDataflowResource
            string subscriptionId = "F8C729F9-DF9C-4743-848F-96EE433D8E53";
            string resourceGroupName = "rgiotoperations";
            string instanceName = "resource-name123";
            string dataflowProfileName = "resource-name123";
            string dataflowName = "aio-to-adx-contexualized";
            ResourceIdentifier iotOperationsDataflowResourceId = IotOperationsDataflowResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, instanceName, dataflowProfileName, dataflowName);
            IotOperationsDataflowResource iotOperationsDataflow = client.GetIotOperationsDataflowResource(iotOperationsDataflowResourceId);

            // invoke the operation
            IotOperationsDataflowData data = new IotOperationsDataflowData(new IotOperationsExtendedLocation("qmbrfwcpwwhggszhrdjv", IotOperationsExtendedLocationType.CustomLocation))
            {
                Properties = new IotOperationsDataflowProperties(new DataflowOperationProperties[]
            {
new DataflowOperationProperties(DataflowOperationType.Source)
{
Name = "source1",
SourceSettings = new DataflowSourceOperationSettings("aio-builtin-broker-endpoint", new string[]{"azure-iot-operations/data/thermostat"}),
},
new DataflowOperationProperties(DataflowOperationType.BuiltInTransformation)
{
Name = "transformation1",
BuiltInTransformationSettings = new DataflowBuiltInTransformationSettings
{
Datasets = {new DataflowBuiltInTransformationDataset("quality", new string[]{"$source.country", "$context.country"})
{
Expression = "$1 == $2",
}},
Map = {new DataflowBuiltInTransformationMap(new string[]{"*"}, "*"), new DataflowBuiltInTransformationMap(new string[]{"$context(quality).*"}, "enriched.*")},
},
},
new DataflowOperationProperties(DataflowOperationType.Destination)
{
Name = "destination1",
DestinationSettings = new DataflowDestinationOperationSettings("adx-endpoint", "mytable"),
}
            })
                {
                    Mode = IotOperationsOperationalMode.Enabled,
                },
            };
            ArmOperation<IotOperationsDataflowResource> lro = await iotOperationsDataflow.UpdateAsync(WaitUntil.Completed, data);
            IotOperationsDataflowResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            IotOperationsDataflowData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_DataflowCreateOrUpdateComplexEventHub()
        {
            // Generated from example definition: 2024-11-01/Dataflow_CreateOrUpdate_ComplexEventHub.json
            // this example is just showing the usage of "DataflowResource_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IotOperationsDataflowResource created on azure
            // for more information of creating IotOperationsDataflowResource, please refer to the document of IotOperationsDataflowResource
            string subscriptionId = "F8C729F9-DF9C-4743-848F-96EE433D8E53";
            string resourceGroupName = "rgiotoperations";
            string instanceName = "resource-name123";
            string dataflowProfileName = "resource-name123";
            string dataflowName = "aio-to-event-hub-transformed";
            ResourceIdentifier iotOperationsDataflowResourceId = IotOperationsDataflowResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, instanceName, dataflowProfileName, dataflowName);
            IotOperationsDataflowResource iotOperationsDataflow = client.GetIotOperationsDataflowResource(iotOperationsDataflowResourceId);

            // invoke the operation
            IotOperationsDataflowData data = new IotOperationsDataflowData(new IotOperationsExtendedLocation("qmbrfwcpwwhggszhrdjv", IotOperationsExtendedLocationType.CustomLocation))
            {
                Properties = new IotOperationsDataflowProperties(new DataflowOperationProperties[]
            {
new DataflowOperationProperties(DataflowOperationType.Source)
{
Name = "source1",
SourceSettings = new DataflowSourceOperationSettings("aio-builtin-broker-endpoint", new string[]{"azure-iot-operations/data/thermostat"}),
},
new DataflowOperationProperties(DataflowOperationType.BuiltInTransformation)
{
BuiltInTransformationSettings = new DataflowBuiltInTransformationSettings
{
Filter = {new DataflowBuiltInTransformationFilter(new string[]{"temperature.Value", "\"Tag 10\".Value"}, "$1 > 9000 && $2 >= 8000")},
Map = {new DataflowBuiltInTransformationMap(new string[]{"*"}, "*"), new DataflowBuiltInTransformationMap(new string[]{"temperature.Value", "\"Tag 10\".Value"}, "AvgTemp.Value")
{
Expression = "($1+$2)/2",
}, new DataflowBuiltInTransformationMap(Array.Empty<string>(), "dataflow-processed")
{
Expression = "true",
}, new DataflowBuiltInTransformationMap(new string[]{"temperature.SourceTimestamp"}, "")
{
Expression = "",
}, new DataflowBuiltInTransformationMap(new string[]{"\"Tag 10\""}, "pressure")
{
Expression = "",
}, new DataflowBuiltInTransformationMap(new string[]{"temperature.Value"}, "temperatureF.Value")
{
Expression = "cToF($1)",
}, new DataflowBuiltInTransformationMap(new string[]{"\"Tag 10\".Value"}, "\"Scale Tag 10\".Value")
{
Expression = "scale ($1,0,10,0,100)",
}},
},
},
new DataflowOperationProperties(DataflowOperationType.Destination)
{
Name = "destination1",
DestinationSettings = new DataflowDestinationOperationSettings("event-hub-endpoint", "myuniqueeventhub"),
}
            })
                {
                    Mode = IotOperationsOperationalMode.Enabled,
                },
            };
            ArmOperation<IotOperationsDataflowResource> lro = await iotOperationsDataflow.UpdateAsync(WaitUntil.Completed, data);
            IotOperationsDataflowResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            IotOperationsDataflowData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_DataflowCreateOrUpdateFilterToTopic()
        {
            // Generated from example definition: 2024-11-01/Dataflow_CreateOrUpdate_FilterToTopic.json
            // this example is just showing the usage of "DataflowResource_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IotOperationsDataflowResource created on azure
            // for more information of creating IotOperationsDataflowResource, please refer to the document of IotOperationsDataflowResource
            string subscriptionId = "F8C729F9-DF9C-4743-848F-96EE433D8E53";
            string resourceGroupName = "rgiotoperations";
            string instanceName = "resource-name123";
            string dataflowProfileName = "resource-name123";
            string dataflowName = "mqtt-filter-to-topic";
            ResourceIdentifier iotOperationsDataflowResourceId = IotOperationsDataflowResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, instanceName, dataflowProfileName, dataflowName);
            IotOperationsDataflowResource iotOperationsDataflow = client.GetIotOperationsDataflowResource(iotOperationsDataflowResourceId);

            // invoke the operation
            IotOperationsDataflowData data = new IotOperationsDataflowData(new IotOperationsExtendedLocation("qmbrfwcpwwhggszhrdjv", IotOperationsExtendedLocationType.CustomLocation))
            {
                Properties = new IotOperationsDataflowProperties(new DataflowOperationProperties[]
            {
new DataflowOperationProperties(DataflowOperationType.Source)
{
Name = "source1",
SourceSettings = new DataflowSourceOperationSettings("aio-builtin-broker-endpoint", new string[]{"azure-iot-operations/data/thermostat"}),
},
new DataflowOperationProperties(DataflowOperationType.BuiltInTransformation)
{
Name = "transformation1",
BuiltInTransformationSettings = new DataflowBuiltInTransformationSettings
{
Filter = {new DataflowBuiltInTransformationFilter(new string[]{"temperature.Value", "\"Tag 10\".Value"}, "$1 > 9000 && $2 >= 8000")
{
Type = DataflowFilterType.Filter,
Description = "filter-datapoint",
}},
Map = {new DataflowBuiltInTransformationMap(new string[]{"*"}, "*")
{
Type = DataflowMappingType.PassThrough,
}},
},
},
new DataflowOperationProperties(DataflowOperationType.Destination)
{
Name = "destination1",
DestinationSettings = new DataflowDestinationOperationSettings("aio-builtin-broker-endpoint", "data/filtered/thermostat"),
}
            })
                {
                    Mode = IotOperationsOperationalMode.Enabled,
                },
            };
            ArmOperation<IotOperationsDataflowResource> lro = await iotOperationsDataflow.UpdateAsync(WaitUntil.Completed, data);
            IotOperationsDataflowResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            IotOperationsDataflowData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_DataflowCreateOrUpdate()
        {
            // Generated from example definition: 2024-11-01/Dataflow_CreateOrUpdate_MaximumSet_Gen.json
            // this example is just showing the usage of "DataflowResource_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IotOperationsDataflowResource created on azure
            // for more information of creating IotOperationsDataflowResource, please refer to the document of IotOperationsDataflowResource
            string subscriptionId = "F8C729F9-DF9C-4743-848F-96EE433D8E53";
            string resourceGroupName = "rgiotoperations";
            string instanceName = "resource-name123";
            string dataflowProfileName = "resource-name123";
            string dataflowName = "resource-name123";
            ResourceIdentifier iotOperationsDataflowResourceId = IotOperationsDataflowResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, instanceName, dataflowProfileName, dataflowName);
            IotOperationsDataflowResource iotOperationsDataflow = client.GetIotOperationsDataflowResource(iotOperationsDataflowResourceId);

            // invoke the operation
            IotOperationsDataflowData data = new IotOperationsDataflowData(new IotOperationsExtendedLocation("qmbrfwcpwwhggszhrdjv", IotOperationsExtendedLocationType.CustomLocation))
            {
                Properties = new IotOperationsDataflowProperties(new DataflowOperationProperties[]
            {
new DataflowOperationProperties(DataflowOperationType.Source)
{
Name = "knnafvkwoeakm",
SourceSettings = new DataflowSourceOperationSettings("iixotodhvhkkfcfyrkoveslqig", new string[]{"chkkpymxhp"})
{
AssetRef = "zayyykwmckaocywdkohmu",
SerializationFormat = DataflowSourceSerializationFormat.Json,
SchemaRef = "pknmdzqll",
},
BuiltInTransformationSettings = new DataflowBuiltInTransformationSettings
{
SerializationFormat = TransformationSerializationFormat.Delta,
SchemaRef = "mcdc",
Datasets = {new DataflowBuiltInTransformationDataset("qsfqcgxaxnhfumrsdsokwyv", new string[]{"mosffpsslifkq"})
{
Description = "Lorem ipsum odor amet, consectetuer adipiscing elit.",
SchemaRef = "n",
Expression = "aatbwomvflemsxialv",
}},
Filter = {new DataflowBuiltInTransformationFilter(new string[]{"sxmjkbntgb"}, "n")
{
Type = DataflowFilterType.Filter,
Description = "Lorem ipsum odor amet, consectetuer adipiscing elit.",
}},
Map = {new DataflowBuiltInTransformationMap(new string[]{"xsbxuk"}, "nvgtmkfl")
{
Type = DataflowMappingType.NewProperties,
Description = "Lorem ipsum odor amet, consectetuer adipiscing elit.",
Expression = "txoiltogsarwkzalsphvlmt",
}},
},
DestinationSettings = new DataflowDestinationOperationSettings("kybkchnzimerguekuvqlqiqdvvrt", "cbrh"),
}
            })
                {
                    Mode = IotOperationsOperationalMode.Enabled,
                },
            };
            ArmOperation<IotOperationsDataflowResource> lro = await iotOperationsDataflow.UpdateAsync(WaitUntil.Completed, data);
            IotOperationsDataflowResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            IotOperationsDataflowData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_DataflowCreateOrUpdateSimpleEventGrid()
        {
            // Generated from example definition: 2024-11-01/Dataflow_CreateOrUpdate_SimpleEventGrid.json
            // this example is just showing the usage of "DataflowResource_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IotOperationsDataflowResource created on azure
            // for more information of creating IotOperationsDataflowResource, please refer to the document of IotOperationsDataflowResource
            string subscriptionId = "F8C729F9-DF9C-4743-848F-96EE433D8E53";
            string resourceGroupName = "rgiotoperations";
            string instanceName = "resource-name123";
            string dataflowProfileName = "resource-name123";
            string dataflowName = "aio-to-event-grid";
            ResourceIdentifier iotOperationsDataflowResourceId = IotOperationsDataflowResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, instanceName, dataflowProfileName, dataflowName);
            IotOperationsDataflowResource iotOperationsDataflow = client.GetIotOperationsDataflowResource(iotOperationsDataflowResourceId);

            // invoke the operation
            IotOperationsDataflowData data = new IotOperationsDataflowData(new IotOperationsExtendedLocation("qmbrfwcpwwhggszhrdjv", IotOperationsExtendedLocationType.CustomLocation))
            {
                Properties = new IotOperationsDataflowProperties(new DataflowOperationProperties[]
            {
new DataflowOperationProperties(DataflowOperationType.Source)
{
Name = "source1",
SourceSettings = new DataflowSourceOperationSettings("aio-builtin-broker-endpoint", new string[]{"thermostats/+/telemetry/temperature/#"}),
},
new DataflowOperationProperties(DataflowOperationType.Destination)
{
Name = "destination1",
DestinationSettings = new DataflowDestinationOperationSettings("event-grid-endpoint", "factory/telemetry"),
}
            })
                {
                    Mode = IotOperationsOperationalMode.Enabled,
                },
            };
            ArmOperation<IotOperationsDataflowResource> lro = await iotOperationsDataflow.UpdateAsync(WaitUntil.Completed, data);
            IotOperationsDataflowResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            IotOperationsDataflowData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_DataflowCreateOrUpdateSimpleFabric()
        {
            // Generated from example definition: 2024-11-01/Dataflow_CreateOrUpdate_SimpleFabric.json
            // this example is just showing the usage of "DataflowResource_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IotOperationsDataflowResource created on azure
            // for more information of creating IotOperationsDataflowResource, please refer to the document of IotOperationsDataflowResource
            string subscriptionId = "F8C729F9-DF9C-4743-848F-96EE433D8E53";
            string resourceGroupName = "rgiotoperations";
            string instanceName = "resource-name123";
            string dataflowProfileName = "resource-name123";
            string dataflowName = "aio-to-fabric";
            ResourceIdentifier iotOperationsDataflowResourceId = IotOperationsDataflowResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, instanceName, dataflowProfileName, dataflowName);
            IotOperationsDataflowResource iotOperationsDataflow = client.GetIotOperationsDataflowResource(iotOperationsDataflowResourceId);

            // invoke the operation
            IotOperationsDataflowData data = new IotOperationsDataflowData(new IotOperationsExtendedLocation("qmbrfwcpwwhggszhrdjv", IotOperationsExtendedLocationType.CustomLocation))
            {
                Properties = new IotOperationsDataflowProperties(new DataflowOperationProperties[]
            {
new DataflowOperationProperties(DataflowOperationType.Source)
{
Name = "source1",
SourceSettings = new DataflowSourceOperationSettings("aio-builtin-broker-endpoint", new string[]{"azure-iot-operations/data/thermostat"}),
},
new DataflowOperationProperties(DataflowOperationType.BuiltInTransformation)
{
BuiltInTransformationSettings = new DataflowBuiltInTransformationSettings
{
SerializationFormat = TransformationSerializationFormat.Parquet,
SchemaRef = "aio-sr://exampleNamespace/exmapleParquetSchema:1.0.0",
},
},
new DataflowOperationProperties(DataflowOperationType.Destination)
{
Name = "destination1",
DestinationSettings = new DataflowDestinationOperationSettings("fabric-endpoint", "telemetryTable"),
}
            })
                {
                    Mode = IotOperationsOperationalMode.Enabled,
                },
            };
            ArmOperation<IotOperationsDataflowResource> lro = await iotOperationsDataflow.UpdateAsync(WaitUntil.Completed, data);
            IotOperationsDataflowResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            IotOperationsDataflowData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}

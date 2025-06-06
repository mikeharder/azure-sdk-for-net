// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Migration.Assessment
{
    public partial class MigrationAssessmentMachineResource : IJsonModel<MigrationAssessmentMachineData>
    {
        private static MigrationAssessmentMachineData s_dataDeserializationInstance;
        private static MigrationAssessmentMachineData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<MigrationAssessmentMachineData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<MigrationAssessmentMachineData>)Data).Write(writer, options);

        MigrationAssessmentMachineData IJsonModel<MigrationAssessmentMachineData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<MigrationAssessmentMachineData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<MigrationAssessmentMachineData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<MigrationAssessmentMachineData>(Data, options, AzureResourceManagerMigrationAssessmentContext.Default);

        MigrationAssessmentMachineData IPersistableModel<MigrationAssessmentMachineData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<MigrationAssessmentMachineData>(data, options, AzureResourceManagerMigrationAssessmentContext.Default);

        string IPersistableModel<MigrationAssessmentMachineData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<MigrationAssessmentMachineData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}

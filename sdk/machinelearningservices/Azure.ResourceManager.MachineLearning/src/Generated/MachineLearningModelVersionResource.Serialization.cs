// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.MachineLearning
{
    public partial class MachineLearningModelVersionResource : IJsonModel<MachineLearningModelVersionData>
    {
        private static MachineLearningModelVersionData s_dataDeserializationInstance;
        private static MachineLearningModelVersionData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<MachineLearningModelVersionData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<MachineLearningModelVersionData>)Data).Write(writer, options);

        MachineLearningModelVersionData IJsonModel<MachineLearningModelVersionData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<MachineLearningModelVersionData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<MachineLearningModelVersionData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<MachineLearningModelVersionData>(Data, options, AzureResourceManagerMachineLearningContext.Default);

        MachineLearningModelVersionData IPersistableModel<MachineLearningModelVersionData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<MachineLearningModelVersionData>(data, options, AzureResourceManagerMachineLearningContext.Default);

        string IPersistableModel<MachineLearningModelVersionData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<MachineLearningModelVersionData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}

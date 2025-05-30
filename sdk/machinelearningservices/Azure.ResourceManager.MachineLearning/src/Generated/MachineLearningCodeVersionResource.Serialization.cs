// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.MachineLearning
{
    public partial class MachineLearningCodeVersionResource : IJsonModel<MachineLearningCodeVersionData>
    {
        private static MachineLearningCodeVersionData s_dataDeserializationInstance;
        private static MachineLearningCodeVersionData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<MachineLearningCodeVersionData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<MachineLearningCodeVersionData>)Data).Write(writer, options);

        MachineLearningCodeVersionData IJsonModel<MachineLearningCodeVersionData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<MachineLearningCodeVersionData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<MachineLearningCodeVersionData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<MachineLearningCodeVersionData>(Data, options, AzureResourceManagerMachineLearningContext.Default);

        MachineLearningCodeVersionData IPersistableModel<MachineLearningCodeVersionData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<MachineLearningCodeVersionData>(data, options, AzureResourceManagerMachineLearningContext.Default);

        string IPersistableModel<MachineLearningCodeVersionData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<MachineLearningCodeVersionData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}

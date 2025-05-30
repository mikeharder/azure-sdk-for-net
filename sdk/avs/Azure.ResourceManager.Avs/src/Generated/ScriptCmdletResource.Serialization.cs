// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Avs
{
    public partial class ScriptCmdletResource : IJsonModel<ScriptCmdletData>
    {
        private static ScriptCmdletData s_dataDeserializationInstance;
        private static ScriptCmdletData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<ScriptCmdletData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<ScriptCmdletData>)Data).Write(writer, options);

        ScriptCmdletData IJsonModel<ScriptCmdletData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<ScriptCmdletData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<ScriptCmdletData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<ScriptCmdletData>(Data, options, AzureResourceManagerAvsContext.Default);

        ScriptCmdletData IPersistableModel<ScriptCmdletData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<ScriptCmdletData>(data, options, AzureResourceManagerAvsContext.Default);

        string IPersistableModel<ScriptCmdletData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<ScriptCmdletData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Sql
{
    public partial class SqlServerKeyResource : IJsonModel<SqlServerKeyData>
    {
        private static SqlServerKeyData s_dataDeserializationInstance;
        private static SqlServerKeyData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<SqlServerKeyData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<SqlServerKeyData>)Data).Write(writer, options);

        SqlServerKeyData IJsonModel<SqlServerKeyData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<SqlServerKeyData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<SqlServerKeyData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<SqlServerKeyData>(Data, options, AzureResourceManagerSqlContext.Default);

        SqlServerKeyData IPersistableModel<SqlServerKeyData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<SqlServerKeyData>(data, options, AzureResourceManagerSqlContext.Default);

        string IPersistableModel<SqlServerKeyData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<SqlServerKeyData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}

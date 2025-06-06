// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.ApiManagement
{
    public partial class ServiceWorkspaceBackendResource : IJsonModel<ApiManagementBackendData>
    {
        private static ApiManagementBackendData s_dataDeserializationInstance;
        private static ApiManagementBackendData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<ApiManagementBackendData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<ApiManagementBackendData>)Data).Write(writer, options);

        ApiManagementBackendData IJsonModel<ApiManagementBackendData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<ApiManagementBackendData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<ApiManagementBackendData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<ApiManagementBackendData>(Data, options, AzureResourceManagerApiManagementContext.Default);

        ApiManagementBackendData IPersistableModel<ApiManagementBackendData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<ApiManagementBackendData>(data, options, AzureResourceManagerApiManagementContext.Default);

        string IPersistableModel<ApiManagementBackendData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<ApiManagementBackendData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}

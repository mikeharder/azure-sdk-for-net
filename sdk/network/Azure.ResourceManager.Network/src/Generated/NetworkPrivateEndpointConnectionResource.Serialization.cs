// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Network
{
    public partial class NetworkPrivateEndpointConnectionResource : IJsonModel<NetworkPrivateEndpointConnectionData>
    {
        private static NetworkPrivateEndpointConnectionData s_dataDeserializationInstance;
        private static NetworkPrivateEndpointConnectionData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<NetworkPrivateEndpointConnectionData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<NetworkPrivateEndpointConnectionData>)Data).Write(writer, options);

        NetworkPrivateEndpointConnectionData IJsonModel<NetworkPrivateEndpointConnectionData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<NetworkPrivateEndpointConnectionData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<NetworkPrivateEndpointConnectionData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<NetworkPrivateEndpointConnectionData>(Data, options, AzureResourceManagerNetworkContext.Default);

        NetworkPrivateEndpointConnectionData IPersistableModel<NetworkPrivateEndpointConnectionData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<NetworkPrivateEndpointConnectionData>(data, options, AzureResourceManagerNetworkContext.Default);

        string IPersistableModel<NetworkPrivateEndpointConnectionData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<NetworkPrivateEndpointConnectionData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}

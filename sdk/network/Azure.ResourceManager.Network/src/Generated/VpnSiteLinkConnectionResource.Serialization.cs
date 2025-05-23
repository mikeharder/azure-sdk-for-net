// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Network
{
    public partial class VpnSiteLinkConnectionResource : IJsonModel<VpnSiteLinkConnectionData>
    {
        private static VpnSiteLinkConnectionData s_dataDeserializationInstance;
        private static VpnSiteLinkConnectionData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<VpnSiteLinkConnectionData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<VpnSiteLinkConnectionData>)Data).Write(writer, options);

        VpnSiteLinkConnectionData IJsonModel<VpnSiteLinkConnectionData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<VpnSiteLinkConnectionData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<VpnSiteLinkConnectionData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<VpnSiteLinkConnectionData>(Data, options, AzureResourceManagerNetworkContext.Default);

        VpnSiteLinkConnectionData IPersistableModel<VpnSiteLinkConnectionData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<VpnSiteLinkConnectionData>(data, options, AzureResourceManagerNetworkContext.Default);

        string IPersistableModel<VpnSiteLinkConnectionData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<VpnSiteLinkConnectionData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}

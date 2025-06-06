// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Cdn
{
    public partial class FrontDoorCustomDomainResource : IJsonModel<FrontDoorCustomDomainData>
    {
        private static FrontDoorCustomDomainData s_dataDeserializationInstance;
        private static FrontDoorCustomDomainData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<FrontDoorCustomDomainData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<FrontDoorCustomDomainData>)Data).Write(writer, options);

        FrontDoorCustomDomainData IJsonModel<FrontDoorCustomDomainData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<FrontDoorCustomDomainData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<FrontDoorCustomDomainData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<FrontDoorCustomDomainData>(Data, options, AzureResourceManagerCdnContext.Default);

        FrontDoorCustomDomainData IPersistableModel<FrontDoorCustomDomainData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<FrontDoorCustomDomainData>(data, options, AzureResourceManagerCdnContext.Default);

        string IPersistableModel<FrontDoorCustomDomainData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<FrontDoorCustomDomainData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}

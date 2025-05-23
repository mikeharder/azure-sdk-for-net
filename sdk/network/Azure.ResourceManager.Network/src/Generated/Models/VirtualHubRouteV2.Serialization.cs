// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class VirtualHubRouteV2 : IUtf8JsonSerializable, IJsonModel<VirtualHubRouteV2>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VirtualHubRouteV2>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<VirtualHubRouteV2>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualHubRouteV2>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualHubRouteV2)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(DestinationType))
            {
                writer.WritePropertyName("destinationType"u8);
                writer.WriteStringValue(DestinationType);
            }
            if (Optional.IsCollectionDefined(Destinations))
            {
                writer.WritePropertyName("destinations"u8);
                writer.WriteStartArray();
                foreach (var item in Destinations)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(NextHopType))
            {
                writer.WritePropertyName("nextHopType"u8);
                writer.WriteStringValue(NextHopType);
            }
            if (Optional.IsCollectionDefined(NextHops))
            {
                writer.WritePropertyName("nextHops"u8);
                writer.WriteStartArray();
                foreach (var item in NextHops)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value, ModelSerializationExtensions.JsonDocumentOptions))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        VirtualHubRouteV2 IJsonModel<VirtualHubRouteV2>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualHubRouteV2>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualHubRouteV2)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVirtualHubRouteV2(document.RootElement, options);
        }

        internal static VirtualHubRouteV2 DeserializeVirtualHubRouteV2(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string destinationType = default;
            IList<string> destinations = default;
            string nextHopType = default;
            IList<string> nextHops = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("destinationType"u8))
                {
                    destinationType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("destinations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    destinations = array;
                    continue;
                }
                if (property.NameEquals("nextHopType"u8))
                {
                    nextHopType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("nextHops"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    nextHops = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new VirtualHubRouteV2(destinationType, destinations ?? new ChangeTrackingList<string>(), nextHopType, nextHops ?? new ChangeTrackingList<string>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<VirtualHubRouteV2>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualHubRouteV2>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerNetworkContext.Default);
                default:
                    throw new FormatException($"The model {nameof(VirtualHubRouteV2)} does not support writing '{options.Format}' format.");
            }
        }

        VirtualHubRouteV2 IPersistableModel<VirtualHubRouteV2>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualHubRouteV2>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeVirtualHubRouteV2(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VirtualHubRouteV2)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<VirtualHubRouteV2>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

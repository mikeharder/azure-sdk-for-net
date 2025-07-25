// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerInstance.Models
{
    internal partial class NGroupCGPropertyContainerProperties : IUtf8JsonSerializable, IJsonModel<NGroupCGPropertyContainerProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NGroupCGPropertyContainerProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<NGroupCGPropertyContainerProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NGroupCGPropertyContainerProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NGroupCGPropertyContainerProperties)} does not support writing '{format}' format.");
            }

            if (Optional.IsCollectionDefined(VolumeMounts))
            {
                writer.WritePropertyName("volumeMounts"u8);
                writer.WriteStartArray();
                foreach (var item in VolumeMounts)
                {
                    writer.WriteObjectValue(item, options);
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

        NGroupCGPropertyContainerProperties IJsonModel<NGroupCGPropertyContainerProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NGroupCGPropertyContainerProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NGroupCGPropertyContainerProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNGroupCGPropertyContainerProperties(document.RootElement, options);
        }

        internal static NGroupCGPropertyContainerProperties DeserializeNGroupCGPropertyContainerProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<ContainerVolumeMount> volumeMounts = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("volumeMounts"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ContainerVolumeMount> array = new List<ContainerVolumeMount>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerVolumeMount.DeserializeContainerVolumeMount(item, options));
                    }
                    volumeMounts = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new NGroupCGPropertyContainerProperties(volumeMounts ?? new ChangeTrackingList<ContainerVolumeMount>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NGroupCGPropertyContainerProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NGroupCGPropertyContainerProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerContainerInstanceContext.Default);
                default:
                    throw new FormatException($"The model {nameof(NGroupCGPropertyContainerProperties)} does not support writing '{options.Format}' format.");
            }
        }

        NGroupCGPropertyContainerProperties IPersistableModel<NGroupCGPropertyContainerProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NGroupCGPropertyContainerProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeNGroupCGPropertyContainerProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NGroupCGPropertyContainerProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<NGroupCGPropertyContainerProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

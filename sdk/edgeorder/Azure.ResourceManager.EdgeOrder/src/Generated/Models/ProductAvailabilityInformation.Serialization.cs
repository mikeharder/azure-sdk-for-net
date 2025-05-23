// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    public partial class ProductAvailabilityInformation : IUtf8JsonSerializable, IJsonModel<ProductAvailabilityInformation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ProductAvailabilityInformation>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ProductAvailabilityInformation>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProductAvailabilityInformation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ProductAvailabilityInformation)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(AvailabilityStage))
            {
                writer.WritePropertyName("availabilityStage"u8);
                writer.WriteStringValue(AvailabilityStage.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(DisabledReason))
            {
                writer.WritePropertyName("disabledReason"u8);
                writer.WriteStringValue(DisabledReason.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(DisabledReasonMessage))
            {
                writer.WritePropertyName("disabledReasonMessage"u8);
                writer.WriteStringValue(DisabledReasonMessage);
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

        ProductAvailabilityInformation IJsonModel<ProductAvailabilityInformation>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProductAvailabilityInformation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ProductAvailabilityInformation)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeProductAvailabilityInformation(document.RootElement, options);
        }

        internal static ProductAvailabilityInformation DeserializeProductAvailabilityInformation(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ProductAvailabilityStage? availabilityStage = default;
            ProductDisabledReason? disabledReason = default;
            string disabledReasonMessage = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("availabilityStage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    availabilityStage = new ProductAvailabilityStage(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("disabledReason"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    disabledReason = new ProductDisabledReason(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("disabledReasonMessage"u8))
                {
                    disabledReasonMessage = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ProductAvailabilityInformation(availabilityStage, disabledReason, disabledReasonMessage, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ProductAvailabilityInformation>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProductAvailabilityInformation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerEdgeOrderContext.Default);
                default:
                    throw new FormatException($"The model {nameof(ProductAvailabilityInformation)} does not support writing '{options.Format}' format.");
            }
        }

        ProductAvailabilityInformation IPersistableModel<ProductAvailabilityInformation>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProductAvailabilityInformation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeProductAvailabilityInformation(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ProductAvailabilityInformation)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ProductAvailabilityInformation>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.PureStorageBlock.Models
{
    public partial class PureStorageSoftDeletionState : IUtf8JsonSerializable, IJsonModel<PureStorageSoftDeletionState>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PureStorageSoftDeletionState>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<PureStorageSoftDeletionState>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PureStorageSoftDeletionState>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PureStorageSoftDeletionState)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("destroyed"u8);
            writer.WriteBooleanValue(IsDestroyed);
            if (options.Format != "W" && Optional.IsDefined(EradicatedOn))
            {
                writer.WritePropertyName("eradicationTimestamp"u8);
                writer.WriteStringValue(EradicatedOn.Value, "O");
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

        PureStorageSoftDeletionState IJsonModel<PureStorageSoftDeletionState>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PureStorageSoftDeletionState>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PureStorageSoftDeletionState)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePureStorageSoftDeletionState(document.RootElement, options);
        }

        internal static PureStorageSoftDeletionState DeserializePureStorageSoftDeletionState(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool destroyed = default;
            DateTimeOffset? eradicationTimestamp = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("destroyed"u8))
                {
                    destroyed = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("eradicationTimestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    eradicationTimestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new PureStorageSoftDeletionState(destroyed, eradicationTimestamp, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PureStorageSoftDeletionState>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PureStorageSoftDeletionState>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerPureStorageBlockContext.Default);
                default:
                    throw new FormatException($"The model {nameof(PureStorageSoftDeletionState)} does not support writing '{options.Format}' format.");
            }
        }

        PureStorageSoftDeletionState IPersistableModel<PureStorageSoftDeletionState>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PureStorageSoftDeletionState>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializePureStorageSoftDeletionState(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PureStorageSoftDeletionState)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<PureStorageSoftDeletionState>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

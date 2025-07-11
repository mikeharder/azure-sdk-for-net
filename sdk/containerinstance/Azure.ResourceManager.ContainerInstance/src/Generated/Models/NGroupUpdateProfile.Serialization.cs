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
    public partial class NGroupUpdateProfile : IUtf8JsonSerializable, IJsonModel<NGroupUpdateProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NGroupUpdateProfile>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<NGroupUpdateProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NGroupUpdateProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NGroupUpdateProfile)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(UpdateMode))
            {
                writer.WritePropertyName("updateMode"u8);
                writer.WriteStringValue(UpdateMode.Value.ToString());
            }
            if (Optional.IsDefined(RollingUpdateProfile))
            {
                writer.WritePropertyName("rollingUpdateProfile"u8);
                writer.WriteObjectValue(RollingUpdateProfile, options);
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

        NGroupUpdateProfile IJsonModel<NGroupUpdateProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NGroupUpdateProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NGroupUpdateProfile)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNGroupUpdateProfile(document.RootElement, options);
        }

        internal static NGroupUpdateProfile DeserializeNGroupUpdateProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            NGroupUpdateMode? updateMode = default;
            NGroupRollingUpdateProfile rollingUpdateProfile = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("updateMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    updateMode = new NGroupUpdateMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("rollingUpdateProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rollingUpdateProfile = NGroupRollingUpdateProfile.DeserializeNGroupRollingUpdateProfile(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new NGroupUpdateProfile(updateMode, rollingUpdateProfile, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NGroupUpdateProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NGroupUpdateProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerContainerInstanceContext.Default);
                default:
                    throw new FormatException($"The model {nameof(NGroupUpdateProfile)} does not support writing '{options.Format}' format.");
            }
        }

        NGroupUpdateProfile IPersistableModel<NGroupUpdateProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NGroupUpdateProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeNGroupUpdateProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NGroupUpdateProfile)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<NGroupUpdateProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

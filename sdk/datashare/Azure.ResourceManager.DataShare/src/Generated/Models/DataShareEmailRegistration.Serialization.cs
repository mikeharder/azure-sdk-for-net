// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataShare.Models
{
    public partial class DataShareEmailRegistration : IUtf8JsonSerializable, IJsonModel<DataShareEmailRegistration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataShareEmailRegistration>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DataShareEmailRegistration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataShareEmailRegistration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataShareEmailRegistration)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(ActivationCode))
            {
                writer.WritePropertyName("activationCode"u8);
                writer.WriteStringValue(ActivationCode);
            }
            if (options.Format != "W" && Optional.IsDefined(ActivationExpireOn))
            {
                writer.WritePropertyName("activationExpirationDate"u8);
                writer.WriteStringValue(ActivationExpireOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(Email))
            {
                writer.WritePropertyName("email"u8);
                writer.WriteStringValue(Email);
            }
            if (options.Format != "W" && Optional.IsDefined(RegistrationStatus))
            {
                writer.WritePropertyName("registrationStatus"u8);
                writer.WriteStringValue(RegistrationStatus.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(TenantId))
            {
                writer.WritePropertyName("tenantId"u8);
                writer.WriteStringValue(TenantId.Value);
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

        DataShareEmailRegistration IJsonModel<DataShareEmailRegistration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataShareEmailRegistration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataShareEmailRegistration)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataShareEmailRegistration(document.RootElement, options);
        }

        internal static DataShareEmailRegistration DeserializeDataShareEmailRegistration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string activationCode = default;
            DateTimeOffset? activationExpirationDate = default;
            string email = default;
            DataShareEmailRegistrationStatus? registrationStatus = default;
            Guid? tenantId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("activationCode"u8))
                {
                    activationCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("activationExpirationDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    activationExpirationDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("email"u8))
                {
                    email = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("registrationStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    registrationStatus = new DataShareEmailRegistrationStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tenantId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tenantId = property.Value.GetGuid();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DataShareEmailRegistration(
                activationCode,
                activationExpirationDate,
                email,
                registrationStatus,
                tenantId,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataShareEmailRegistration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataShareEmailRegistration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerDataShareContext.Default);
                default:
                    throw new FormatException($"The model {nameof(DataShareEmailRegistration)} does not support writing '{options.Format}' format.");
            }
        }

        DataShareEmailRegistration IPersistableModel<DataShareEmailRegistration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataShareEmailRegistration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeDataShareEmailRegistration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataShareEmailRegistration)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataShareEmailRegistration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

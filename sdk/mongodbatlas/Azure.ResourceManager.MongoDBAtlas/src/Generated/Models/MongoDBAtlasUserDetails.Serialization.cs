// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MongoDBAtlas.Models
{
    public partial class MongoDBAtlasUserDetails : IUtf8JsonSerializable, IJsonModel<MongoDBAtlasUserDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MongoDBAtlasUserDetails>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MongoDBAtlasUserDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MongoDBAtlasUserDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MongoDBAtlasUserDetails)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("firstName"u8);
            writer.WriteStringValue(FirstName);
            writer.WritePropertyName("lastName"u8);
            writer.WriteStringValue(LastName);
            writer.WritePropertyName("emailAddress"u8);
            writer.WriteStringValue(EmailAddress);
            if (Optional.IsDefined(Upn))
            {
                writer.WritePropertyName("upn"u8);
                writer.WriteStringValue(Upn);
            }
            if (Optional.IsDefined(PhoneNumber))
            {
                writer.WritePropertyName("phoneNumber"u8);
                writer.WriteStringValue(PhoneNumber);
            }
            if (Optional.IsDefined(CompanyName))
            {
                writer.WritePropertyName("companyName"u8);
                writer.WriteStringValue(CompanyName);
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

        MongoDBAtlasUserDetails IJsonModel<MongoDBAtlasUserDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MongoDBAtlasUserDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MongoDBAtlasUserDetails)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMongoDBAtlasUserDetails(document.RootElement, options);
        }

        internal static MongoDBAtlasUserDetails DeserializeMongoDBAtlasUserDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string firstName = default;
            string lastName = default;
            string emailAddress = default;
            string upn = default;
            string phoneNumber = default;
            string companyName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("firstName"u8))
                {
                    firstName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastName"u8))
                {
                    lastName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("emailAddress"u8))
                {
                    emailAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("upn"u8))
                {
                    upn = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("phoneNumber"u8))
                {
                    phoneNumber = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("companyName"u8))
                {
                    companyName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MongoDBAtlasUserDetails(
                firstName,
                lastName,
                emailAddress,
                upn,
                phoneNumber,
                companyName,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MongoDBAtlasUserDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MongoDBAtlasUserDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerMongoDBAtlasContext.Default);
                default:
                    throw new FormatException($"The model {nameof(MongoDBAtlasUserDetails)} does not support writing '{options.Format}' format.");
            }
        }

        MongoDBAtlasUserDetails IPersistableModel<MongoDBAtlasUserDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MongoDBAtlasUserDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeMongoDBAtlasUserDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MongoDBAtlasUserDetails)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MongoDBAtlasUserDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

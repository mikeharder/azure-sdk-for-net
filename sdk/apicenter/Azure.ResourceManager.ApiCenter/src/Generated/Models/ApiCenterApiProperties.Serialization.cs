// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApiCenter.Models
{
    public partial class ApiCenterApiProperties : IUtf8JsonSerializable, IJsonModel<ApiCenterApiProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ApiCenterApiProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ApiCenterApiProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiCenterApiProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApiCenterApiProperties)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("title"u8);
            writer.WriteStringValue(Title);
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(Summary))
            {
                writer.WritePropertyName("summary"u8);
                writer.WriteStringValue(Summary);
            }
            if (options.Format != "W" && Optional.IsDefined(LifecycleStage))
            {
                writer.WritePropertyName("lifecycleStage"u8);
                writer.WriteStringValue(LifecycleStage.Value.ToString());
            }
            if (Optional.IsDefined(TermsOfService))
            {
                writer.WritePropertyName("termsOfService"u8);
                writer.WriteObjectValue(TermsOfService, options);
            }
            if (Optional.IsCollectionDefined(ExternalDocumentation))
            {
                writer.WritePropertyName("externalDocumentation"u8);
                writer.WriteStartArray();
                foreach (var item in ExternalDocumentation)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Contacts))
            {
                writer.WritePropertyName("contacts"u8);
                writer.WriteStartArray();
                foreach (var item in Contacts)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(License))
            {
                writer.WritePropertyName("license"u8);
                writer.WriteObjectValue(License, options);
            }
            if (Optional.IsDefined(CustomProperties))
            {
                writer.WritePropertyName("customProperties"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(CustomProperties);
#else
                using (JsonDocument document = JsonDocument.Parse(CustomProperties, ModelSerializationExtensions.JsonDocumentOptions))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
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

        ApiCenterApiProperties IJsonModel<ApiCenterApiProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiCenterApiProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApiCenterApiProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeApiCenterApiProperties(document.RootElement, options);
        }

        internal static ApiCenterApiProperties DeserializeApiCenterApiProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string title = default;
            ApiKind kind = default;
            string description = default;
            string summary = default;
            ApiLifecycleStage? lifecycleStage = default;
            TermsOfService termsOfService = default;
            IList<ApiExternalDocumentation> externalDocumentation = default;
            IList<ApiContactInformation> contacts = default;
            ApiLicenseInformation license = default;
            BinaryData customProperties = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("title"u8))
                {
                    title = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = new ApiKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("summary"u8))
                {
                    summary = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lifecycleStage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lifecycleStage = new ApiLifecycleStage(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("termsOfService"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    termsOfService = TermsOfService.DeserializeTermsOfService(property.Value, options);
                    continue;
                }
                if (property.NameEquals("externalDocumentation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ApiExternalDocumentation> array = new List<ApiExternalDocumentation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ApiExternalDocumentation.DeserializeApiExternalDocumentation(item, options));
                    }
                    externalDocumentation = array;
                    continue;
                }
                if (property.NameEquals("contacts"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ApiContactInformation> array = new List<ApiContactInformation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ApiContactInformation.DeserializeApiContactInformation(item, options));
                    }
                    contacts = array;
                    continue;
                }
                if (property.NameEquals("license"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    license = ApiLicenseInformation.DeserializeApiLicenseInformation(property.Value, options);
                    continue;
                }
                if (property.NameEquals("customProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    customProperties = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ApiCenterApiProperties(
                title,
                kind,
                description,
                summary,
                lifecycleStage,
                termsOfService,
                externalDocumentation ?? new ChangeTrackingList<ApiExternalDocumentation>(),
                contacts ?? new ChangeTrackingList<ApiContactInformation>(),
                license,
                customProperties,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ApiCenterApiProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiCenterApiProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerApiCenterContext.Default);
                default:
                    throw new FormatException($"The model {nameof(ApiCenterApiProperties)} does not support writing '{options.Format}' format.");
            }
        }

        ApiCenterApiProperties IPersistableModel<ApiCenterApiProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiCenterApiProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeApiCenterApiProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ApiCenterApiProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ApiCenterApiProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

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
    public partial class ApplicationGatewayClientAuthConfiguration : IUtf8JsonSerializable, IJsonModel<ApplicationGatewayClientAuthConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ApplicationGatewayClientAuthConfiguration>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ApplicationGatewayClientAuthConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationGatewayClientAuthConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApplicationGatewayClientAuthConfiguration)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(VerifyClientCertIssuerDN))
            {
                writer.WritePropertyName("verifyClientCertIssuerDN"u8);
                writer.WriteBooleanValue(VerifyClientCertIssuerDN.Value);
            }
            if (Optional.IsDefined(VerifyClientRevocation))
            {
                writer.WritePropertyName("verifyClientRevocation"u8);
                writer.WriteStringValue(VerifyClientRevocation.Value.ToString());
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

        ApplicationGatewayClientAuthConfiguration IJsonModel<ApplicationGatewayClientAuthConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationGatewayClientAuthConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApplicationGatewayClientAuthConfiguration)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeApplicationGatewayClientAuthConfiguration(document.RootElement, options);
        }

        internal static ApplicationGatewayClientAuthConfiguration DeserializeApplicationGatewayClientAuthConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? verifyClientCertIssuerDN = default;
            ApplicationGatewayClientRevocationOption? verifyClientRevocation = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("verifyClientCertIssuerDN"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    verifyClientCertIssuerDN = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("verifyClientRevocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    verifyClientRevocation = new ApplicationGatewayClientRevocationOption(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ApplicationGatewayClientAuthConfiguration(verifyClientCertIssuerDN, verifyClientRevocation, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ApplicationGatewayClientAuthConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationGatewayClientAuthConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerNetworkContext.Default);
                default:
                    throw new FormatException($"The model {nameof(ApplicationGatewayClientAuthConfiguration)} does not support writing '{options.Format}' format.");
            }
        }

        ApplicationGatewayClientAuthConfiguration IPersistableModel<ApplicationGatewayClientAuthConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationGatewayClientAuthConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeApplicationGatewayClientAuthConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ApplicationGatewayClientAuthConfiguration)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ApplicationGatewayClientAuthConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

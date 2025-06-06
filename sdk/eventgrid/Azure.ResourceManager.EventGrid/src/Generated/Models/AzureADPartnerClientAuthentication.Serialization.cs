// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EventGrid.Models
{
    public partial class AzureADPartnerClientAuthentication : IUtf8JsonSerializable, IJsonModel<AzureADPartnerClientAuthentication>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AzureADPartnerClientAuthentication>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AzureADPartnerClientAuthentication>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureADPartnerClientAuthentication>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureADPartnerClientAuthentication)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(AzureActiveDirectoryTenantId))
            {
                writer.WritePropertyName("azureActiveDirectoryTenantId"u8);
                writer.WriteStringValue(AzureActiveDirectoryTenantId);
            }
            if (Optional.IsDefined(AzureActiveDirectoryApplicationIdOrUri))
            {
                writer.WritePropertyName("azureActiveDirectoryApplicationIdOrUri"u8);
                writer.WriteStringValue(AzureActiveDirectoryApplicationIdOrUri.AbsoluteUri);
            }
            writer.WriteEndObject();
        }

        AzureADPartnerClientAuthentication IJsonModel<AzureADPartnerClientAuthentication>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureADPartnerClientAuthentication>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureADPartnerClientAuthentication)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureADPartnerClientAuthentication(document.RootElement, options);
        }

        internal static AzureADPartnerClientAuthentication DeserializeAzureADPartnerClientAuthentication(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            PartnerClientAuthenticationType clientAuthenticationType = default;
            string azureActiveDirectoryTenantId = default;
            Uri azureActiveDirectoryApplicationIdOrUri = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("clientAuthenticationType"u8))
                {
                    clientAuthenticationType = new PartnerClientAuthenticationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("azureActiveDirectoryTenantId"u8))
                        {
                            azureActiveDirectoryTenantId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("azureActiveDirectoryApplicationIdOrUri"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            azureActiveDirectoryApplicationIdOrUri = new Uri(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AzureADPartnerClientAuthentication(clientAuthenticationType, serializedAdditionalRawData, azureActiveDirectoryTenantId, azureActiveDirectoryApplicationIdOrUri);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ClientAuthenticationType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  clientAuthenticationType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  clientAuthenticationType: ");
                builder.AppendLine($"'{ClientAuthenticationType.ToString()}'");
            }

            builder.Append("  properties:");
            builder.AppendLine(" {");
            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AzureActiveDirectoryTenantId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    azureActiveDirectoryTenantId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AzureActiveDirectoryTenantId))
                {
                    builder.Append("    azureActiveDirectoryTenantId: ");
                    if (AzureActiveDirectoryTenantId.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{AzureActiveDirectoryTenantId}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{AzureActiveDirectoryTenantId}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AzureActiveDirectoryApplicationIdOrUri), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    azureActiveDirectoryApplicationIdOrUri: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AzureActiveDirectoryApplicationIdOrUri))
                {
                    builder.Append("    azureActiveDirectoryApplicationIdOrUri: ");
                    builder.AppendLine($"'{AzureActiveDirectoryApplicationIdOrUri.AbsoluteUri}'");
                }
            }

            builder.AppendLine("  }");
            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<AzureADPartnerClientAuthentication>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureADPartnerClientAuthentication>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerEventGridContext.Default);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(AzureADPartnerClientAuthentication)} does not support writing '{options.Format}' format.");
            }
        }

        AzureADPartnerClientAuthentication IPersistableModel<AzureADPartnerClientAuthentication>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureADPartnerClientAuthentication>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeAzureADPartnerClientAuthentication(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AzureADPartnerClientAuthentication)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AzureADPartnerClientAuthentication>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

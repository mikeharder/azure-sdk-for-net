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

namespace Azure.AI.Language.Text.Authoring
{
    public partial class TextAuthoringDeploymentState : IUtf8JsonSerializable, IJsonModel<TextAuthoringDeploymentState>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TextAuthoringDeploymentState>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<TextAuthoringDeploymentState>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TextAuthoringDeploymentState>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TextAuthoringDeploymentState)} does not support writing '{format}' format.");
            }

            if (options.Format != "W")
            {
                writer.WritePropertyName("jobId"u8);
                writer.WriteStringValue(JobId);
            }
            writer.WritePropertyName("createdDateTime"u8);
            writer.WriteStringValue(CreatedOn, "O");
            writer.WritePropertyName("lastUpdatedDateTime"u8);
            writer.WriteStringValue(LastUpdatedOn, "O");
            if (Optional.IsDefined(ExpiresOn))
            {
                writer.WritePropertyName("expirationDateTime"u8);
                writer.WriteStringValue(ExpiresOn.Value, "O");
            }
            writer.WritePropertyName("status"u8);
            writer.WriteStringValue(Status.ToString());
            if (Optional.IsCollectionDefined(Warnings))
            {
                writer.WritePropertyName("warnings"u8);
                writer.WriteStartArray();
                foreach (var item in Warnings)
                {
                    ((IJsonModel<ResponseError>)item).Write(writer, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Errors))
            {
                writer.WritePropertyName("errors"u8);
                writer.WriteStartArray();
                foreach (var item in Errors)
                {
                    ((IJsonModel<ResponseError>)item).Write(writer, options);
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

        TextAuthoringDeploymentState IJsonModel<TextAuthoringDeploymentState>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TextAuthoringDeploymentState>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TextAuthoringDeploymentState)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTextAuthoringDeploymentState(document.RootElement, options);
        }

        internal static TextAuthoringDeploymentState DeserializeTextAuthoringDeploymentState(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string jobId = default;
            DateTimeOffset createdDateTime = default;
            DateTimeOffset lastUpdatedDateTime = default;
            DateTimeOffset? expirationDateTime = default;
            TextAuthoringOperationStatus status = default;
            IReadOnlyList<ResponseError> warnings = default;
            IReadOnlyList<ResponseError> errors = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("jobId"u8))
                {
                    jobId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("createdDateTime"u8))
                {
                    createdDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastUpdatedDateTime"u8))
                {
                    lastUpdatedDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("expirationDateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expirationDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = new TextAuthoringOperationStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("warnings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ResponseError> array = new List<ResponseError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ModelReaderWriter.Read<ResponseError>(new BinaryData(Encoding.UTF8.GetBytes(item.GetRawText())), options, AzureAILanguageTextAuthoringContext.Default));
                    }
                    warnings = array;
                    continue;
                }
                if (property.NameEquals("errors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ResponseError> array = new List<ResponseError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ModelReaderWriter.Read<ResponseError>(new BinaryData(Encoding.UTF8.GetBytes(item.GetRawText())), options, AzureAILanguageTextAuthoringContext.Default));
                    }
                    errors = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new TextAuthoringDeploymentState(
                jobId,
                createdDateTime,
                lastUpdatedDateTime,
                expirationDateTime,
                status,
                warnings ?? new ChangeTrackingList<ResponseError>(),
                errors ?? new ChangeTrackingList<ResponseError>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<TextAuthoringDeploymentState>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TextAuthoringDeploymentState>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureAILanguageTextAuthoringContext.Default);
                default:
                    throw new FormatException($"The model {nameof(TextAuthoringDeploymentState)} does not support writing '{options.Format}' format.");
            }
        }

        TextAuthoringDeploymentState IPersistableModel<TextAuthoringDeploymentState>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TextAuthoringDeploymentState>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeTextAuthoringDeploymentState(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TextAuthoringDeploymentState)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<TextAuthoringDeploymentState>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static TextAuthoringDeploymentState FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeTextAuthoringDeploymentState(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}

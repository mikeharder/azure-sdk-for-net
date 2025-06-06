// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Communication.Messages.Models.Channels;
using Azure.Core;

namespace Azure.Communication.Messages
{
    [PersistableModelProxy(typeof(UnknownActionBindings))]
    public partial class ActionBindings : IUtf8JsonSerializable, IJsonModel<ActionBindings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ActionBindings>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ActionBindings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ActionBindings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ActionBindings)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
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

        ActionBindings IJsonModel<ActionBindings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ActionBindings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ActionBindings)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeActionBindings(document.RootElement, options);
        }

        internal static ActionBindings DeserializeActionBindings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("kind", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "whatsAppButtonAction": return WhatsAppButtonActionBindings.DeserializeWhatsAppButtonActionBindings(element, options);
                    case "whatsAppListAction": return WhatsAppListActionBindings.DeserializeWhatsAppListActionBindings(element, options);
                    case "whatsAppUrlAction": return WhatsAppUrlActionBindings.DeserializeWhatsAppUrlActionBindings(element, options);
                }
            }
            return UnknownActionBindings.DeserializeUnknownActionBindings(element, options);
        }

        BinaryData IPersistableModel<ActionBindings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ActionBindings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureCommunicationMessagesContext.Default);
                default:
                    throw new FormatException($"The model {nameof(ActionBindings)} does not support writing '{options.Format}' format.");
            }
        }

        ActionBindings IPersistableModel<ActionBindings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ActionBindings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeActionBindings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ActionBindings)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ActionBindings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static ActionBindings FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeActionBindings(document.RootElement);
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

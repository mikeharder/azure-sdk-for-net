// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace BasicTypeSpec
{
    /// <summary> A model with a few properties of literal types. </summary>
    public partial class ThingModel : IJsonModel<ThingModel>
    {
        /// <summary> Initializes a new instance of <see cref="ThingModel"/> for deserialization. </summary>
        internal ThingModel()
        {
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        void IJsonModel<ThingModel>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ThingModel>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ThingModel)} does not support writing '{format}' format.");
            }
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("requiredUnion"u8);
#if NET6_0_OR_GREATER
            writer.WriteRawValue(RequiredUnion);
#else
            using (JsonDocument document = JsonDocument.Parse(RequiredUnion))
            {
                JsonSerializer.Serialize(writer, document.RootElement);
            }
#endif
            writer.WritePropertyName("requiredLiteralString"u8);
            writer.WriteStringValue(RequiredLiteralString);
            writer.WritePropertyName("requiredLiteralInt"u8);
            writer.WriteNumberValue(RequiredLiteralInt);
            writer.WritePropertyName("requiredLiteralFloat"u8);
            writer.WriteNumberValue(RequiredLiteralFloat);
            writer.WritePropertyName("requiredLiteralBool"u8);
            writer.WriteBooleanValue(RequiredLiteralBool);
            if (Optional.IsDefined(OptionalLiteralString))
            {
                writer.WritePropertyName("optionalLiteralString"u8);
                writer.WriteStringValue(OptionalLiteralString);
            }
            if (Optional.IsDefined(OptionalLiteralInt))
            {
                writer.WritePropertyName("optionalLiteralInt"u8);
                writer.WriteNumberValue(OptionalLiteralInt.Value);
            }
            if (Optional.IsDefined(OptionalLiteralFloat))
            {
                writer.WritePropertyName("optionalLiteralFloat"u8);
                writer.WriteNumberValue(OptionalLiteralFloat.Value);
            }
            if (Optional.IsDefined(OptionalLiteralBool))
            {
                writer.WritePropertyName("optionalLiteralBool"u8);
                writer.WriteBooleanValue(OptionalLiteralBool.Value);
            }
            writer.WritePropertyName("requiredBadDescription"u8);
            writer.WriteStringValue(RequiredBadDescription);
            if (Optional.IsCollectionDefined(OptionalNullableList))
            {
                writer.WritePropertyName("optionalNullableList"u8);
                writer.WriteStartArray();
                foreach (int item in OptionalNullableList)
                {
                    writer.WriteNumberValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(RequiredNullableList))
            {
                writer.WritePropertyName("requiredNullableList"u8);
                writer.WriteStartArray();
                foreach (int item in RequiredNullableList)
                {
                    writer.WriteNumberValue(item);
                }
                writer.WriteEndArray();
            }
            else
            {
                writer.WriteNull("requiredNullableList"u8);
            }
            if (options.Format != "W" && _additionalBinaryDataProperties != null)
            {
                foreach (var item in _additionalBinaryDataProperties)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
                    writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        /// <param name="reader"> The JSON reader. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        ThingModel IJsonModel<ThingModel>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => JsonModelCreateCore(ref reader, options);

        /// <param name="reader"> The JSON reader. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual ThingModel JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ThingModel>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ThingModel)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeThingModel(document.RootElement, options);
        }

        /// <param name="element"> The JSON element to deserialize. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        internal static ThingModel DeserializeThingModel(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            BinaryData requiredUnion = default;
            string requiredLiteralString = default;
            int requiredLiteralInt = default;
            float requiredLiteralFloat = default;
            bool requiredLiteralBool = default;
            string optionalLiteralString = default;
            int? optionalLiteralInt = default;
            float? optionalLiteralFloat = default;
            bool? optionalLiteralBool = default;
            string requiredBadDescription = default;
            IList<int> optionalNullableList = default;
            IList<int> requiredNullableList = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("name"u8))
                {
                    name = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("requiredUnion"u8))
                {
                    requiredUnion = BinaryData.FromString(prop.Value.GetRawText());
                    continue;
                }
                if (prop.NameEquals("requiredLiteralString"u8))
                {
                    requiredLiteralString = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("requiredLiteralInt"u8))
                {
                    requiredLiteralInt = prop.Value.GetInt32();
                    continue;
                }
                if (prop.NameEquals("requiredLiteralFloat"u8))
                {
                    requiredLiteralFloat = prop.Value.GetSingle();
                    continue;
                }
                if (prop.NameEquals("requiredLiteralBool"u8))
                {
                    requiredLiteralBool = prop.Value.GetBoolean();
                    continue;
                }
                if (prop.NameEquals("optionalLiteralString"u8))
                {
                    optionalLiteralString = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("optionalLiteralInt"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    optionalLiteralInt = prop.Value.GetInt32();
                    continue;
                }
                if (prop.NameEquals("optionalLiteralFloat"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    optionalLiteralFloat = prop.Value.GetSingle();
                    continue;
                }
                if (prop.NameEquals("optionalLiteralBool"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    optionalLiteralBool = prop.Value.GetBoolean();
                    continue;
                }
                if (prop.NameEquals("requiredBadDescription"u8))
                {
                    requiredBadDescription = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("optionalNullableList"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<int> array = new List<int>();
                    foreach (var item in prop.Value.EnumerateArray())
                    {
                        array.Add(item.GetInt32());
                    }
                    optionalNullableList = array;
                    continue;
                }
                if (prop.NameEquals("requiredNullableList"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        requiredNullableList = new ChangeTrackingList<int>();
                        continue;
                    }
                    List<int> array = new List<int>();
                    foreach (var item in prop.Value.EnumerateArray())
                    {
                        array.Add(item.GetInt32());
                    }
                    requiredNullableList = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
                }
            }
            return new ThingModel(
                name,
                requiredUnion,
                requiredLiteralString,
                requiredLiteralInt,
                requiredLiteralFloat,
                requiredLiteralBool,
                optionalLiteralString,
                optionalLiteralInt,
                optionalLiteralFloat,
                optionalLiteralBool,
                requiredBadDescription,
                optionalNullableList ?? new ChangeTrackingList<int>(),
                requiredNullableList,
                additionalBinaryDataProperties);
        }

        /// <param name="options"> The client options for reading and writing models. </param>
        BinaryData IPersistableModel<ThingModel>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ThingModel>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, BasicTypeSpecContext.Default);
                default:
                    throw new FormatException($"The model {nameof(ThingModel)} does not support writing '{options.Format}' format.");
            }
        }

        /// <param name="data"> The data to parse. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        ThingModel IPersistableModel<ThingModel>.Create(BinaryData data, ModelReaderWriterOptions options) => PersistableModelCreateCore(data, options);

        /// <param name="data"> The data to parse. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual ThingModel PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ThingModel>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeThingModel(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ThingModel)} does not support reading '{options.Format}' format.");
            }
        }

        /// <param name="options"> The client options for reading and writing models. </param>
        string IPersistableModel<ThingModel>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <param name="thingModel"> The <see cref="ThingModel"/> to serialize into <see cref="RequestContent"/>. </param>
        public static implicit operator RequestContent(ThingModel thingModel)
        {
            if (thingModel == null)
            {
                return null;
            }
            Utf8JsonRequestContent content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(thingModel, ModelSerializationExtensions.WireOptions);
            return content;
        }

        /// <param name="result"> The <see cref="Response"/> to deserialize the <see cref="ThingModel"/> from. </param>
        public static explicit operator ThingModel(Response result)
        {
            using Response response = result;
            using JsonDocument document = JsonDocument.Parse(response.Content);
            return DeserializeThingModel(document.RootElement, ModelSerializationExtensions.WireOptions);
        }
    }
}

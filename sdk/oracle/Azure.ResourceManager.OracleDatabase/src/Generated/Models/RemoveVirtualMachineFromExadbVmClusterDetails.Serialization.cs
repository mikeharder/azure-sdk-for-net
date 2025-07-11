// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.OracleDatabase.Models
{
    public partial class RemoveVirtualMachineFromExadbVmClusterDetails : IUtf8JsonSerializable, IJsonModel<RemoveVirtualMachineFromExadbVmClusterDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RemoveVirtualMachineFromExadbVmClusterDetails>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<RemoveVirtualMachineFromExadbVmClusterDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RemoveVirtualMachineFromExadbVmClusterDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RemoveVirtualMachineFromExadbVmClusterDetails)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("dbNodes"u8);
            writer.WriteStartArray();
            foreach (var item in DBNodes)
            {
                writer.WriteObjectValue(item, options);
            }
            writer.WriteEndArray();
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

        RemoveVirtualMachineFromExadbVmClusterDetails IJsonModel<RemoveVirtualMachineFromExadbVmClusterDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RemoveVirtualMachineFromExadbVmClusterDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RemoveVirtualMachineFromExadbVmClusterDetails)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRemoveVirtualMachineFromExadbVmClusterDetails(document.RootElement, options);
        }

        internal static RemoveVirtualMachineFromExadbVmClusterDetails DeserializeRemoveVirtualMachineFromExadbVmClusterDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<DBNodeDetails> dbNodes = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dbNodes"u8))
                {
                    List<DBNodeDetails> array = new List<DBNodeDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DBNodeDetails.DeserializeDBNodeDetails(item, options));
                    }
                    dbNodes = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new RemoveVirtualMachineFromExadbVmClusterDetails(dbNodes, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RemoveVirtualMachineFromExadbVmClusterDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RemoveVirtualMachineFromExadbVmClusterDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerOracleDatabaseContext.Default);
                default:
                    throw new FormatException($"The model {nameof(RemoveVirtualMachineFromExadbVmClusterDetails)} does not support writing '{options.Format}' format.");
            }
        }

        RemoveVirtualMachineFromExadbVmClusterDetails IPersistableModel<RemoveVirtualMachineFromExadbVmClusterDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RemoveVirtualMachineFromExadbVmClusterDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeRemoveVirtualMachineFromExadbVmClusterDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RemoveVirtualMachineFromExadbVmClusterDetails)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RemoveVirtualMachineFromExadbVmClusterDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

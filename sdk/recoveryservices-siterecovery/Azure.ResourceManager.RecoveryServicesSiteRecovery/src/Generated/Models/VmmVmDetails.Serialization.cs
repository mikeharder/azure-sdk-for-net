// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class VmmVmDetails : IUtf8JsonSerializable, IJsonModel<VmmVmDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VmmVmDetails>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<VmmVmDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VmmVmDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VmmVmDetails)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
        }

        VmmVmDetails IJsonModel<VmmVmDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VmmVmDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VmmVmDetails)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVmmVmDetails(document.RootElement, options);
        }

        internal static VmmVmDetails DeserializeVmmVmDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string sourceItemId = default;
            string generation = default;
            SiteRecoveryOSDetails osDetails = default;
            IReadOnlyList<SiteRecoveryDiskDetails> diskDetails = default;
            HyperVVmDiskPresenceStatus? hasPhysicalDisk = default;
            HyperVVmDiskPresenceStatus? hasFibreChannelAdapter = default;
            HyperVVmDiskPresenceStatus? hasSharedVhd = default;
            string hyperVHostId = default;
            string instanceType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourceItemId"u8))
                {
                    sourceItemId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("generation"u8))
                {
                    generation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("osDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    osDetails = SiteRecoveryOSDetails.DeserializeSiteRecoveryOSDetails(property.Value, options);
                    continue;
                }
                if (property.NameEquals("diskDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SiteRecoveryDiskDetails> array = new List<SiteRecoveryDiskDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SiteRecoveryDiskDetails.DeserializeSiteRecoveryDiskDetails(item, options));
                    }
                    diskDetails = array;
                    continue;
                }
                if (property.NameEquals("hasPhysicalDisk"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hasPhysicalDisk = new HyperVVmDiskPresenceStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("hasFibreChannelAdapter"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hasFibreChannelAdapter = new HyperVVmDiskPresenceStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("hasSharedVhd"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hasSharedVhd = new HyperVVmDiskPresenceStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("hyperVHostId"u8))
                {
                    hyperVHostId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new VmmVmDetails(
                instanceType,
                serializedAdditionalRawData,
                sourceItemId,
                generation,
                osDetails,
                diskDetails ?? new ChangeTrackingList<SiteRecoveryDiskDetails>(),
                hasPhysicalDisk,
                hasFibreChannelAdapter,
                hasSharedVhd,
                hyperVHostId);
        }

        BinaryData IPersistableModel<VmmVmDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VmmVmDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerRecoveryServicesSiteRecoveryContext.Default);
                default:
                    throw new FormatException($"The model {nameof(VmmVmDetails)} does not support writing '{options.Format}' format.");
            }
        }

        VmmVmDetails IPersistableModel<VmmVmDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VmmVmDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeVmmVmDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VmmVmDetails)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<VmmVmDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

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

namespace Azure.ResourceManager.AppContainers.Models
{
    public partial class JobConfigurationScheduleTriggerConfig : IUtf8JsonSerializable, IJsonModel<JobConfigurationScheduleTriggerConfig>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<JobConfigurationScheduleTriggerConfig>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<JobConfigurationScheduleTriggerConfig>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<JobConfigurationScheduleTriggerConfig>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(JobConfigurationScheduleTriggerConfig)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(ReplicaCompletionCount))
            {
                writer.WritePropertyName("replicaCompletionCount"u8);
                writer.WriteNumberValue(ReplicaCompletionCount.Value);
            }
            writer.WritePropertyName("cronExpression"u8);
            writer.WriteStringValue(CronExpression);
            if (Optional.IsDefined(Parallelism))
            {
                writer.WritePropertyName("parallelism"u8);
                writer.WriteNumberValue(Parallelism.Value);
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

        JobConfigurationScheduleTriggerConfig IJsonModel<JobConfigurationScheduleTriggerConfig>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<JobConfigurationScheduleTriggerConfig>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(JobConfigurationScheduleTriggerConfig)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeJobConfigurationScheduleTriggerConfig(document.RootElement, options);
        }

        internal static JobConfigurationScheduleTriggerConfig DeserializeJobConfigurationScheduleTriggerConfig(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? replicaCompletionCount = default;
            string cronExpression = default;
            int? parallelism = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("replicaCompletionCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    replicaCompletionCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("cronExpression"u8))
                {
                    cronExpression = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("parallelism"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    parallelism = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new JobConfigurationScheduleTriggerConfig(replicaCompletionCount, cronExpression, parallelism, serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ReplicaCompletionCount), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  replicaCompletionCount: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ReplicaCompletionCount))
                {
                    builder.Append("  replicaCompletionCount: ");
                    builder.AppendLine($"{ReplicaCompletionCount.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(CronExpression), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  cronExpression: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(CronExpression))
                {
                    builder.Append("  cronExpression: ");
                    if (CronExpression.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{CronExpression}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{CronExpression}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Parallelism), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  parallelism: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Parallelism))
                {
                    builder.Append("  parallelism: ");
                    builder.AppendLine($"{Parallelism.Value}");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<JobConfigurationScheduleTriggerConfig>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<JobConfigurationScheduleTriggerConfig>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerAppContainersContext.Default);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(JobConfigurationScheduleTriggerConfig)} does not support writing '{options.Format}' format.");
            }
        }

        JobConfigurationScheduleTriggerConfig IPersistableModel<JobConfigurationScheduleTriggerConfig>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<JobConfigurationScheduleTriggerConfig>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeJobConfigurationScheduleTriggerConfig(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(JobConfigurationScheduleTriggerConfig)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<JobConfigurationScheduleTriggerConfig>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

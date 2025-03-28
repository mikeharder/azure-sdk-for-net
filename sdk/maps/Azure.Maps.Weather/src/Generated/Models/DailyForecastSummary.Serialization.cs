// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Maps.Common;

namespace Azure.Maps.Weather.Models
{
    public partial class DailyForecastSummary
    {
        internal static DailyForecastSummary DeserializeDailyForecastSummary(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DateTimeOffset? startDate = default;
            DateTimeOffset? endDate = default;
            int? severity = default;
            string phrase = default;
            string category = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("startDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("severity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    severity = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("phrase"u8))
                {
                    phrase = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("category"u8))
                {
                    category = property.Value.GetString();
                    continue;
                }
            }
            return new DailyForecastSummary(startDate, endDate, severity, phrase, category);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static DailyForecastSummary FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeDailyForecastSummary(document.RootElement);
        }
    }
}

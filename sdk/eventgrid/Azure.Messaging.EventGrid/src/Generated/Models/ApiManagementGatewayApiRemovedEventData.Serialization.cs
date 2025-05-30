// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(ApiManagementGatewayApiRemovedEventDataConverter))]
    public partial class ApiManagementGatewayApiRemovedEventData
    {
        internal static ApiManagementGatewayApiRemovedEventData DeserializeApiManagementGatewayApiRemovedEventData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string resourceUri = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceUri"u8))
                {
                    resourceUri = property.Value.GetString();
                    continue;
                }
            }
            return new ApiManagementGatewayApiRemovedEventData(resourceUri);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static ApiManagementGatewayApiRemovedEventData FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeApiManagementGatewayApiRemovedEventData(document.RootElement);
        }

        internal partial class ApiManagementGatewayApiRemovedEventDataConverter : JsonConverter<ApiManagementGatewayApiRemovedEventData>
        {
            public override void Write(Utf8JsonWriter writer, ApiManagementGatewayApiRemovedEventData model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }

            public override ApiManagementGatewayApiRemovedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeApiManagementGatewayApiRemovedEventData(document.RootElement);
            }
        }
    }
}

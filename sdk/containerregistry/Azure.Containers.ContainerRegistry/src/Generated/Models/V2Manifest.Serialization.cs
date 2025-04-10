// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;

namespace Azure.Containers.ContainerRegistry
{
    internal partial class V2Manifest
    {
        internal static V2Manifest DeserializeV2Manifest(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string mediaType = default;
            OciDescriptor config = default;
            IReadOnlyList<OciDescriptor> layers = default;
            int? schemaVersion = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("mediaType"u8))
                {
                    mediaType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("config"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    config = OciDescriptor.DeserializeOciDescriptor(property.Value);
                    continue;
                }
                if (property.NameEquals("layers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<OciDescriptor> array = new List<OciDescriptor>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(OciDescriptor.DeserializeOciDescriptor(item));
                    }
                    layers = array;
                    continue;
                }
                if (property.NameEquals("schemaVersion"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    schemaVersion = property.Value.GetInt32();
                    continue;
                }
            }
            return new V2Manifest(schemaVersion, mediaType, config, layers ?? new ChangeTrackingList<OciDescriptor>());
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new V2Manifest FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeV2Manifest(document.RootElement);
        }
    }
}

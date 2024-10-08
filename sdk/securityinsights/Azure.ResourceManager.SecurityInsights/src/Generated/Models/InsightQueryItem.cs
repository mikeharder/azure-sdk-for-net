// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Represents Insight Query. </summary>
    public partial class InsightQueryItem : EntityQueryItem
    {
        /// <summary> Initializes a new instance of <see cref="InsightQueryItem"/>. </summary>
        internal InsightQueryItem()
        {
            Kind = new EntityQueryKind("Insight");
        }

        /// <summary> Initializes a new instance of <see cref="InsightQueryItem"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> The kind of the entity query. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="properties"> Properties bag for InsightQueryItem. </param>
        internal InsightQueryItem(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, EntityQueryKind kind, IDictionary<string, BinaryData> serializedAdditionalRawData, InsightQueryItemProperties properties) : base(id, name, resourceType, systemData, kind, serializedAdditionalRawData)
        {
            Properties = properties;
            Kind = kind;
        }

        /// <summary> Properties bag for InsightQueryItem. </summary>
        [WirePath("properties")]
        public InsightQueryItemProperties Properties { get; }
    }
}

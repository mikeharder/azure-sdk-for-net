// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    /// <summary> The type of placement policy for a service fabric service. Following are the possible values. </summary>
    public partial class ServicePlacementNonPartiallyPlaceServicePolicy : ManagedServicePlacementPolicy
    {
        /// <summary> Initializes a new instance of <see cref="ServicePlacementNonPartiallyPlaceServicePolicy"/>. </summary>
        public ServicePlacementNonPartiallyPlaceServicePolicy()
        {
            Type = ServicePlacementPolicyType.NonPartiallyPlaceService;
        }

        /// <summary> Initializes a new instance of <see cref="ServicePlacementNonPartiallyPlaceServicePolicy"/>. </summary>
        /// <param name="type"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ServicePlacementNonPartiallyPlaceServicePolicy(ServicePlacementPolicyType type, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(type, serializedAdditionalRawData)
        {
            Type = type;
        }
    }
}

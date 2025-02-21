// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Avs.Models
{
    /// <summary> VM type. </summary>
    public readonly partial struct WorkloadNetworkVmType : IEquatable<WorkloadNetworkVmType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="WorkloadNetworkVmType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public WorkloadNetworkVmType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string RegularValue = "REGULAR";
        private const string EdgeValue = "EDGE";
        private const string ServiceValue = "SERVICE";

        /// <summary> is regular. </summary>
        public static WorkloadNetworkVmType Regular { get; } = new WorkloadNetworkVmType(RegularValue);
        /// <summary> is edge. </summary>
        public static WorkloadNetworkVmType Edge { get; } = new WorkloadNetworkVmType(EdgeValue);
        /// <summary> is service. </summary>
        public static WorkloadNetworkVmType Service { get; } = new WorkloadNetworkVmType(ServiceValue);
        /// <summary> Determines if two <see cref="WorkloadNetworkVmType"/> values are the same. </summary>
        public static bool operator ==(WorkloadNetworkVmType left, WorkloadNetworkVmType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="WorkloadNetworkVmType"/> values are not the same. </summary>
        public static bool operator !=(WorkloadNetworkVmType left, WorkloadNetworkVmType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="WorkloadNetworkVmType"/>. </summary>
        public static implicit operator WorkloadNetworkVmType(string value) => new WorkloadNetworkVmType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is WorkloadNetworkVmType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(WorkloadNetworkVmType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}

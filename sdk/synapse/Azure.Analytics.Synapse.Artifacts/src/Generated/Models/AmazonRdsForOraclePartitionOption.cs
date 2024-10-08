// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The AmazonRdsForOraclePartitionOption. </summary>
    internal readonly partial struct AmazonRdsForOraclePartitionOption : IEquatable<AmazonRdsForOraclePartitionOption>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AmazonRdsForOraclePartitionOption"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AmazonRdsForOraclePartitionOption(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "None";
        private const string PhysicalPartitionsOfTableValue = "PhysicalPartitionsOfTable";
        private const string DynamicRangeValue = "DynamicRange";

        /// <summary> None. </summary>
        public static AmazonRdsForOraclePartitionOption None { get; } = new AmazonRdsForOraclePartitionOption(NoneValue);
        /// <summary> PhysicalPartitionsOfTable. </summary>
        public static AmazonRdsForOraclePartitionOption PhysicalPartitionsOfTable { get; } = new AmazonRdsForOraclePartitionOption(PhysicalPartitionsOfTableValue);
        /// <summary> DynamicRange. </summary>
        public static AmazonRdsForOraclePartitionOption DynamicRange { get; } = new AmazonRdsForOraclePartitionOption(DynamicRangeValue);
        /// <summary> Determines if two <see cref="AmazonRdsForOraclePartitionOption"/> values are the same. </summary>
        public static bool operator ==(AmazonRdsForOraclePartitionOption left, AmazonRdsForOraclePartitionOption right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AmazonRdsForOraclePartitionOption"/> values are not the same. </summary>
        public static bool operator !=(AmazonRdsForOraclePartitionOption left, AmazonRdsForOraclePartitionOption right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="AmazonRdsForOraclePartitionOption"/>. </summary>
        public static implicit operator AmazonRdsForOraclePartitionOption(string value) => new AmazonRdsForOraclePartitionOption(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AmazonRdsForOraclePartitionOption other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AmazonRdsForOraclePartitionOption other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}

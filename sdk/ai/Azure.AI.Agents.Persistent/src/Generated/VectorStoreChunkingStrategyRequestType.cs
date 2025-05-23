// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.Agents.Persistent
{
    /// <summary> Type of chunking strategy. </summary>
    internal readonly partial struct VectorStoreChunkingStrategyRequestType : IEquatable<VectorStoreChunkingStrategyRequestType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="VectorStoreChunkingStrategyRequestType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public VectorStoreChunkingStrategyRequestType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AutoValue = "auto";
        private const string StaticValue = "static";

        /// <summary> auto. </summary>
        public static VectorStoreChunkingStrategyRequestType Auto { get; } = new VectorStoreChunkingStrategyRequestType(AutoValue);
        /// <summary> static. </summary>
        public static VectorStoreChunkingStrategyRequestType Static { get; } = new VectorStoreChunkingStrategyRequestType(StaticValue);
        /// <summary> Determines if two <see cref="VectorStoreChunkingStrategyRequestType"/> values are the same. </summary>
        public static bool operator ==(VectorStoreChunkingStrategyRequestType left, VectorStoreChunkingStrategyRequestType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="VectorStoreChunkingStrategyRequestType"/> values are not the same. </summary>
        public static bool operator !=(VectorStoreChunkingStrategyRequestType left, VectorStoreChunkingStrategyRequestType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="VectorStoreChunkingStrategyRequestType"/>. </summary>
        public static implicit operator VectorStoreChunkingStrategyRequestType(string value) => new VectorStoreChunkingStrategyRequestType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is VectorStoreChunkingStrategyRequestType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(VectorStoreChunkingStrategyRequestType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}

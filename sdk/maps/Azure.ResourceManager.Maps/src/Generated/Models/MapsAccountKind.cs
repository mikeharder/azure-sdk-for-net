// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Maps.Models
{
    /// <summary> The Kind of the Maps Account. </summary>
    public readonly partial struct MapsAccountKind : IEquatable<MapsAccountKind>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MapsAccountKind"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MapsAccountKind(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string Gen1Value = "Gen1";
        private const string Gen2Value = "Gen2";

        /// <summary> Gen1. </summary>
        public static MapsAccountKind Gen1 { get; } = new MapsAccountKind(Gen1Value);
        /// <summary> Gen2. </summary>
        public static MapsAccountKind Gen2 { get; } = new MapsAccountKind(Gen2Value);
        /// <summary> Determines if two <see cref="MapsAccountKind"/> values are the same. </summary>
        public static bool operator ==(MapsAccountKind left, MapsAccountKind right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MapsAccountKind"/> values are not the same. </summary>
        public static bool operator !=(MapsAccountKind left, MapsAccountKind right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="MapsAccountKind"/>. </summary>
        public static implicit operator MapsAccountKind(string value) => new MapsAccountKind(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MapsAccountKind other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MapsAccountKind other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}

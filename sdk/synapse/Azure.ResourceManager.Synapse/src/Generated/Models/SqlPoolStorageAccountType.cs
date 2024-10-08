// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> The storage account type used to store backups for this sql pool. </summary>
    public readonly partial struct SqlPoolStorageAccountType : IEquatable<SqlPoolStorageAccountType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SqlPoolStorageAccountType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SqlPoolStorageAccountType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string GrsValue = "GRS";
        private const string LrsValue = "LRS";

        /// <summary> GRS. </summary>
        public static SqlPoolStorageAccountType Grs { get; } = new SqlPoolStorageAccountType(GrsValue);
        /// <summary> LRS. </summary>
        public static SqlPoolStorageAccountType Lrs { get; } = new SqlPoolStorageAccountType(LrsValue);
        /// <summary> Determines if two <see cref="SqlPoolStorageAccountType"/> values are the same. </summary>
        public static bool operator ==(SqlPoolStorageAccountType left, SqlPoolStorageAccountType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SqlPoolStorageAccountType"/> values are not the same. </summary>
        public static bool operator !=(SqlPoolStorageAccountType left, SqlPoolStorageAccountType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="SqlPoolStorageAccountType"/>. </summary>
        public static implicit operator SqlPoolStorageAccountType(string value) => new SqlPoolStorageAccountType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SqlPoolStorageAccountType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SqlPoolStorageAccountType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}

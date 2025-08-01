// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> The project's provisioning state. </summary>
    public readonly partial struct DataMigrationProjectProvisioningState : IEquatable<DataMigrationProjectProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DataMigrationProjectProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DataMigrationProjectProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DeletingValue = "Deleting";
        private const string SucceededValue = "Succeeded";

        /// <summary> Deleting. </summary>
        public static DataMigrationProjectProvisioningState Deleting { get; } = new DataMigrationProjectProvisioningState(DeletingValue);
        /// <summary> Succeeded. </summary>
        public static DataMigrationProjectProvisioningState Succeeded { get; } = new DataMigrationProjectProvisioningState(SucceededValue);
        /// <summary> Determines if two <see cref="DataMigrationProjectProvisioningState"/> values are the same. </summary>
        public static bool operator ==(DataMigrationProjectProvisioningState left, DataMigrationProjectProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DataMigrationProjectProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(DataMigrationProjectProvisioningState left, DataMigrationProjectProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="DataMigrationProjectProvisioningState"/>. </summary>
        public static implicit operator DataMigrationProjectProvisioningState(string value) => new DataMigrationProjectProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DataMigrationProjectProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DataMigrationProjectProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Type of Ssl Policy. </summary>
    public readonly partial struct ApplicationGatewaySslPolicyType : IEquatable<ApplicationGatewaySslPolicyType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ApplicationGatewaySslPolicyType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ApplicationGatewaySslPolicyType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PredefinedValue = "Predefined";
        private const string CustomValue = "Custom";
        private const string CustomV2Value = "CustomV2";

        /// <summary> Predefined. </summary>
        public static ApplicationGatewaySslPolicyType Predefined { get; } = new ApplicationGatewaySslPolicyType(PredefinedValue);
        /// <summary> Custom. </summary>
        public static ApplicationGatewaySslPolicyType Custom { get; } = new ApplicationGatewaySslPolicyType(CustomValue);
        /// <summary> CustomV2. </summary>
        public static ApplicationGatewaySslPolicyType CustomV2 { get; } = new ApplicationGatewaySslPolicyType(CustomV2Value);
        /// <summary> Determines if two <see cref="ApplicationGatewaySslPolicyType"/> values are the same. </summary>
        public static bool operator ==(ApplicationGatewaySslPolicyType left, ApplicationGatewaySslPolicyType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ApplicationGatewaySslPolicyType"/> values are not the same. </summary>
        public static bool operator !=(ApplicationGatewaySslPolicyType left, ApplicationGatewaySslPolicyType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ApplicationGatewaySslPolicyType"/>. </summary>
        public static implicit operator ApplicationGatewaySslPolicyType(string value) => new ApplicationGatewaySslPolicyType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ApplicationGatewaySslPolicyType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ApplicationGatewaySslPolicyType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}

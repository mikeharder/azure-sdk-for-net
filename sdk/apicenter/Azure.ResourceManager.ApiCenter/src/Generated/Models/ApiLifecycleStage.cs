// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ApiCenter.Models
{
    /// <summary> The stage of the Api development lifecycle. </summary>
    public readonly partial struct ApiLifecycleStage : IEquatable<ApiLifecycleStage>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ApiLifecycleStage"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ApiLifecycleStage(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DesignValue = "design";
        private const string DevelopmentValue = "development";
        private const string TestingValue = "testing";
        private const string PreviewValue = "preview";
        private const string ProductionValue = "production";
        private const string DeprecatedValue = "deprecated";
        private const string RetiredValue = "retired";

        /// <summary> design stage. </summary>
        public static ApiLifecycleStage Design { get; } = new ApiLifecycleStage(DesignValue);
        /// <summary> development stage. </summary>
        public static ApiLifecycleStage Development { get; } = new ApiLifecycleStage(DevelopmentValue);
        /// <summary> testing stage. </summary>
        public static ApiLifecycleStage Testing { get; } = new ApiLifecycleStage(TestingValue);
        /// <summary> In preview. </summary>
        public static ApiLifecycleStage Preview { get; } = new ApiLifecycleStage(PreviewValue);
        /// <summary> In production. </summary>
        public static ApiLifecycleStage Production { get; } = new ApiLifecycleStage(ProductionValue);
        /// <summary> deprecated stage. </summary>
        public static ApiLifecycleStage Deprecated { get; } = new ApiLifecycleStage(DeprecatedValue);
        /// <summary> Retired stage. </summary>
        public static ApiLifecycleStage Retired { get; } = new ApiLifecycleStage(RetiredValue);
        /// <summary> Determines if two <see cref="ApiLifecycleStage"/> values are the same. </summary>
        public static bool operator ==(ApiLifecycleStage left, ApiLifecycleStage right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ApiLifecycleStage"/> values are not the same. </summary>
        public static bool operator !=(ApiLifecycleStage left, ApiLifecycleStage right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ApiLifecycleStage"/>. </summary>
        public static implicit operator ApiLifecycleStage(string value) => new ApiLifecycleStage(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ApiLifecycleStage other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ApiLifecycleStage other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}

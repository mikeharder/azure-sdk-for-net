// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.DocumentIntelligence
{
    /// <summary> Presence of signature. </summary>
    public readonly partial struct DocumentSignatureType : IEquatable<DocumentSignatureType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DocumentSignatureType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DocumentSignatureType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SignedValue = "signed";
        private const string UnsignedValue = "unsigned";

        /// <summary> A signature is detected. </summary>
        public static DocumentSignatureType Signed { get; } = new DocumentSignatureType(SignedValue);
        /// <summary> No signatures are detected. </summary>
        public static DocumentSignatureType Unsigned { get; } = new DocumentSignatureType(UnsignedValue);
        /// <summary> Determines if two <see cref="DocumentSignatureType"/> values are the same. </summary>
        public static bool operator ==(DocumentSignatureType left, DocumentSignatureType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DocumentSignatureType"/> values are not the same. </summary>
        public static bool operator !=(DocumentSignatureType left, DocumentSignatureType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="DocumentSignatureType"/>. </summary>
        public static implicit operator DocumentSignatureType(string value) => new DocumentSignatureType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DocumentSignatureType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DocumentSignatureType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}

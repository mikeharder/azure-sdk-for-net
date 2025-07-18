// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;
using Azure.AI.OpenAI;

namespace Azure.AI.OpenAI.Chat
{
    internal readonly partial struct InternalAzureChatDataSourceAuthenticationOptionsType : IEquatable<InternalAzureChatDataSourceAuthenticationOptionsType>
    {
        private readonly string _value;
        private const string ApiKeyValue = "api_key";
        private const string UsernameAndPasswordValue = "username_and_password";
        private const string ConnectionStringValue = "connection_string";
        private const string KeyAndKeyIdValue = "key_and_key_id";
        private const string EncodedApiKeyValue = "encoded_api_key";
        private const string AccessTokenValue = "access_token";
        private const string SystemAssignedManagedIdentityValue = "system_assigned_managed_identity";
        private const string UserAssignedManagedIdentityValue = "user_assigned_managed_identity";

        /// <summary> Initializes a new instance of <see cref="InternalAzureChatDataSourceAuthenticationOptionsType"/>. </summary>
        /// <param name="value"> The value. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public InternalAzureChatDataSourceAuthenticationOptionsType(string value)
        {
            Argument.AssertNotNull(value, nameof(value));

            _value = value;
        }

        /// <summary> Gets or sets the ApiKey. </summary>
        internal static InternalAzureChatDataSourceAuthenticationOptionsType ApiKey { get; set; } = new InternalAzureChatDataSourceAuthenticationOptionsType(ApiKeyValue);

        /// <summary> Gets or sets the UsernameAndPassword. </summary>
        internal static InternalAzureChatDataSourceAuthenticationOptionsType UsernameAndPassword { get; set; } = new InternalAzureChatDataSourceAuthenticationOptionsType(UsernameAndPasswordValue);

        /// <summary> Gets or sets the ConnectionString. </summary>
        internal static InternalAzureChatDataSourceAuthenticationOptionsType ConnectionString { get; set; } = new InternalAzureChatDataSourceAuthenticationOptionsType(ConnectionStringValue);

        /// <summary> Gets or sets the KeyAndKeyId. </summary>
        internal static InternalAzureChatDataSourceAuthenticationOptionsType KeyAndKeyId { get; set; } = new InternalAzureChatDataSourceAuthenticationOptionsType(KeyAndKeyIdValue);

        /// <summary> Gets or sets the EncodedApiKey. </summary>
        internal static InternalAzureChatDataSourceAuthenticationOptionsType EncodedApiKey { get; set; } = new InternalAzureChatDataSourceAuthenticationOptionsType(EncodedApiKeyValue);

        /// <summary> Gets or sets the AccessToken. </summary>
        internal static InternalAzureChatDataSourceAuthenticationOptionsType AccessToken { get; set; } = new InternalAzureChatDataSourceAuthenticationOptionsType(AccessTokenValue);

        /// <summary> Gets or sets the SystemAssignedManagedIdentity. </summary>
        internal static InternalAzureChatDataSourceAuthenticationOptionsType SystemAssignedManagedIdentity { get; set; } = new InternalAzureChatDataSourceAuthenticationOptionsType(SystemAssignedManagedIdentityValue);

        /// <summary> Gets or sets the UserAssignedManagedIdentity. </summary>
        internal static InternalAzureChatDataSourceAuthenticationOptionsType UserAssignedManagedIdentity { get; set; } = new InternalAzureChatDataSourceAuthenticationOptionsType(UserAssignedManagedIdentityValue);

        /// <summary> Determines if two <see cref="InternalAzureChatDataSourceAuthenticationOptionsType"/> values are the same. </summary>
        /// <param name="left"> The left value to compare. </param>
        /// <param name="right"> The right value to compare. </param>
        public static bool operator ==(InternalAzureChatDataSourceAuthenticationOptionsType left, InternalAzureChatDataSourceAuthenticationOptionsType right) => left.Equals(right);

        /// <summary> Determines if two <see cref="InternalAzureChatDataSourceAuthenticationOptionsType"/> values are not the same. </summary>
        /// <param name="left"> The left value to compare. </param>
        /// <param name="right"> The right value to compare. </param>
        public static bool operator !=(InternalAzureChatDataSourceAuthenticationOptionsType left, InternalAzureChatDataSourceAuthenticationOptionsType right) => !left.Equals(right);

        /// <summary> Converts a string to a <see cref="InternalAzureChatDataSourceAuthenticationOptionsType"/>. </summary>
        /// <param name="value"> The value. </param>
        public static implicit operator InternalAzureChatDataSourceAuthenticationOptionsType(string value) => new InternalAzureChatDataSourceAuthenticationOptionsType(value);

        /// <inheritdoc/>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InternalAzureChatDataSourceAuthenticationOptionsType other && Equals(other);

        /// <inheritdoc/>
        public bool Equals(InternalAzureChatDataSourceAuthenticationOptionsType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc/>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;

        /// <inheritdoc/>
        public override string ToString() => _value;
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Subscription create details. </summary>
    public partial class ApiManagementSubscriptionCreateOrUpdateContent
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ApiManagementSubscriptionCreateOrUpdateContent"/>. </summary>
        public ApiManagementSubscriptionCreateOrUpdateContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ApiManagementSubscriptionCreateOrUpdateContent"/>. </summary>
        /// <param name="ownerId"> User (user id path) for whom subscription is being created in form /users/{userId}. </param>
        /// <param name="scope"> Scope like /products/{productId} or /apis or /apis/{apiId}. </param>
        /// <param name="displayName"> Subscription name. </param>
        /// <param name="primaryKey"> Primary subscription key. If not specified during request key will be generated automatically. </param>
        /// <param name="secondaryKey"> Secondary subscription key. If not specified during request key will be generated automatically. </param>
        /// <param name="state"> Initial subscription state. If no value is specified, subscription is created with Submitted state. Possible states are * active – the subscription is active, * suspended – the subscription is blocked, and the subscriber cannot call any APIs of the product, * submitted – the subscription request has been made by the developer, but has not yet been approved or rejected, * rejected – the subscription request has been denied by an administrator, * cancelled – the subscription has been cancelled by the developer or administrator, * expired – the subscription reached its expiration date and was deactivated. </param>
        /// <param name="allowTracing"> Determines whether tracing can be enabled. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ApiManagementSubscriptionCreateOrUpdateContent(string ownerId, string scope, string displayName, string primaryKey, string secondaryKey, SubscriptionState? state, bool? allowTracing, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            OwnerId = ownerId;
            Scope = scope;
            DisplayName = displayName;
            PrimaryKey = primaryKey;
            SecondaryKey = secondaryKey;
            State = state;
            AllowTracing = allowTracing;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> User (user id path) for whom subscription is being created in form /users/{userId}. </summary>
        [WirePath("properties.ownerId")]
        public string OwnerId { get; set; }
        /// <summary> Scope like /products/{productId} or /apis or /apis/{apiId}. </summary>
        [WirePath("properties.scope")]
        public string Scope { get; set; }
        /// <summary> Subscription name. </summary>
        [WirePath("properties.displayName")]
        public string DisplayName { get; set; }
        /// <summary> Primary subscription key. If not specified during request key will be generated automatically. </summary>
        [WirePath("properties.primaryKey")]
        public string PrimaryKey { get; set; }
        /// <summary> Secondary subscription key. If not specified during request key will be generated automatically. </summary>
        [WirePath("properties.secondaryKey")]
        public string SecondaryKey { get; set; }
        /// <summary> Initial subscription state. If no value is specified, subscription is created with Submitted state. Possible states are * active – the subscription is active, * suspended – the subscription is blocked, and the subscriber cannot call any APIs of the product, * submitted – the subscription request has been made by the developer, but has not yet been approved or rejected, * rejected – the subscription request has been denied by an administrator, * cancelled – the subscription has been cancelled by the developer or administrator, * expired – the subscription reached its expiration date and was deactivated. </summary>
        [WirePath("properties.state")]
        public SubscriptionState? State { get; set; }
        /// <summary> Determines whether tracing can be enabled. </summary>
        [WirePath("properties.allowTracing")]
        public bool? AllowTracing { get; set; }
    }
}

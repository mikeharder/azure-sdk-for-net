// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.OnlineExperimentation
{
    /// <summary> Diagnostic details for validation errors. </summary>
    public partial class DiagnosticDetail
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

        /// <summary> Initializes a new instance of <see cref="DiagnosticDetail"/>. </summary>
        internal DiagnosticDetail()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DiagnosticDetail"/>. </summary>
        /// <param name="message"> A human-readable error message. </param>
        /// <param name="code"> The diagnostic error code. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DiagnosticDetail(string message, DiagnosticCode code, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Message = message;
            Code = code;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> A human-readable error message. </summary>
        public string Message { get; }
        /// <summary> The diagnostic error code. </summary>
        public DiagnosticCode Code { get; }
    }
}

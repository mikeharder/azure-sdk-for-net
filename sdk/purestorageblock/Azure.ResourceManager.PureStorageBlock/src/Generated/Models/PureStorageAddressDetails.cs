// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.PureStorageBlock.Models
{
    /// <summary> Address details. </summary>
    public partial class PureStorageAddressDetails
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

        /// <summary> Initializes a new instance of <see cref="PureStorageAddressDetails"/>. </summary>
        /// <param name="addressLine1"> Address line 1. </param>
        /// <param name="city"> Name of the city. </param>
        /// <param name="state"> State (if any). </param>
        /// <param name="country"> Name of the country. </param>
        /// <param name="postalCode"> Postal code. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="addressLine1"/>, <paramref name="city"/>, <paramref name="state"/>, <paramref name="country"/> or <paramref name="postalCode"/> is null. </exception>
        public PureStorageAddressDetails(string addressLine1, string city, string state, string country, string postalCode)
        {
            Argument.AssertNotNull(addressLine1, nameof(addressLine1));
            Argument.AssertNotNull(city, nameof(city));
            Argument.AssertNotNull(state, nameof(state));
            Argument.AssertNotNull(country, nameof(country));
            Argument.AssertNotNull(postalCode, nameof(postalCode));

            AddressLine1 = addressLine1;
            City = city;
            State = state;
            Country = country;
            PostalCode = postalCode;
        }

        /// <summary> Initializes a new instance of <see cref="PureStorageAddressDetails"/>. </summary>
        /// <param name="addressLine1"> Address line 1. </param>
        /// <param name="addressLine2"> Address line 2. </param>
        /// <param name="city"> Name of the city. </param>
        /// <param name="state"> State (if any). </param>
        /// <param name="country"> Name of the country. </param>
        /// <param name="postalCode"> Postal code. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PureStorageAddressDetails(string addressLine1, string addressLine2, string city, string state, string country, string postalCode, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AddressLine1 = addressLine1;
            AddressLine2 = addressLine2;
            City = city;
            State = state;
            Country = country;
            PostalCode = postalCode;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="PureStorageAddressDetails"/> for deserialization. </summary>
        internal PureStorageAddressDetails()
        {
        }

        /// <summary> Address line 1. </summary>
        public string AddressLine1 { get; set; }
        /// <summary> Address line 2. </summary>
        public string AddressLine2 { get; set; }
        /// <summary> Name of the city. </summary>
        public string City { get; set; }
        /// <summary> State (if any). </summary>
        public string State { get; set; }
        /// <summary> Name of the country. </summary>
        public string Country { get; set; }
        /// <summary> Postal code. </summary>
        public string PostalCode { get; set; }
    }
}

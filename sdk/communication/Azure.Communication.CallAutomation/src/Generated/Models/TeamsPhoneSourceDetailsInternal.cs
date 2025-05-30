// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Communication.CallAutomation
{
    /// <summary> Container for details relating to the entity responsible for the creation of these call details. </summary>
    internal partial class TeamsPhoneSourceDetailsInternal
    {
        /// <summary> Initializes a new instance of <see cref="TeamsPhoneSourceDetailsInternal"/>. </summary>
        /// <param name="source"> ID of the source entity passing along the call details (ex. Application Instance ID of - CQ/AA). </param>
        /// <param name="language"> Language of the source entity passing along the call details, passed in the ISO-639 standard. </param>
        /// <param name="status"> Status of the source entity passing along the call details. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="source"/>, <paramref name="language"/> or <paramref name="status"/> is null. </exception>
        public TeamsPhoneSourceDetailsInternal(CommunicationIdentifierModel source, string language, string status)
        {
            Argument.AssertNotNull(source, nameof(source));
            Argument.AssertNotNull(language, nameof(language));
            Argument.AssertNotNull(status, nameof(status));

            Source = source;
            Language = language;
            Status = status;
            IntendedTargets = new ChangeTrackingDictionary<string, CommunicationIdentifierModel>();
        }

        /// <summary> Initializes a new instance of <see cref="TeamsPhoneSourceDetailsInternal"/>. </summary>
        /// <param name="source"> ID of the source entity passing along the call details (ex. Application Instance ID of - CQ/AA). </param>
        /// <param name="language"> Language of the source entity passing along the call details, passed in the ISO-639 standard. </param>
        /// <param name="status"> Status of the source entity passing along the call details. </param>
        /// <param name="intendedTargets"> Intended targets of the source entity passing along the call details. </param>
        internal TeamsPhoneSourceDetailsInternal(CommunicationIdentifierModel source, string language, string status, IDictionary<string, CommunicationIdentifierModel> intendedTargets)
        {
            Source = source;
            Language = language;
            Status = status;
            IntendedTargets = intendedTargets;
        }

        /// <summary> ID of the source entity passing along the call details (ex. Application Instance ID of - CQ/AA). </summary>
        public CommunicationIdentifierModel Source { get; set; }
        /// <summary> Language of the source entity passing along the call details, passed in the ISO-639 standard. </summary>
        public string Language { get; set; }
        /// <summary> Status of the source entity passing along the call details. </summary>
        public string Status { get; set; }
        /// <summary> Intended targets of the source entity passing along the call details. </summary>
        public IDictionary<string, CommunicationIdentifierModel> IntendedTargets { get; }
    }
}

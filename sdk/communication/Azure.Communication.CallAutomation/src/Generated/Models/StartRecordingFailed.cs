// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Communication.CallAutomation
{
    /// <summary> The StartRecordingFailed. </summary>
    public partial class StartRecordingFailed
    {
        /// <summary> Initializes a new instance of <see cref="StartRecordingFailed"/>. </summary>
        internal StartRecordingFailed()
        {
        }

        /// <summary> Initializes a new instance of <see cref="StartRecordingFailed"/>. </summary>
        /// <param name="recordingId"> The call recording Id. </param>
        /// <param name="callConnectionId"> Call connection ID. </param>
        /// <param name="serverCallId"> Server call ID. </param>
        /// <param name="correlationId"> Correlation ID for event to call correlation. Also called ChainId for skype chain ID. </param>
        /// <param name="operationContext"> Used by customers when calling mid-call actions to correlate the request to the response event. </param>
        /// <param name="resultInformation"> Contains the resulting SIP code, sub-code and message. </param>
        internal StartRecordingFailed(string recordingId, string callConnectionId, string serverCallId, string correlationId, string operationContext, ResultInformation resultInformation)
        {
            RecordingId = recordingId;
            CallConnectionId = callConnectionId;
            ServerCallId = serverCallId;
            CorrelationId = correlationId;
            OperationContext = operationContext;
            ResultInformation = resultInformation;
        }

        /// <summary> The call recording Id. </summary>
        public string RecordingId { get; }
    }
}

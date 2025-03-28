// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AgriculturePlatform.Models
{
    /// <summary> The updatable properties of the AgriServiceResource. </summary>
    public partial class AgricultureServicePatchProperties
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

        /// <summary> Initializes a new instance of <see cref="AgricultureServicePatchProperties"/>. </summary>
        public AgricultureServicePatchProperties()
        {
            DataConnectorCredentials = new ChangeTrackingList<DataConnectorCredentialMap>();
            InstalledSolutions = new ChangeTrackingList<InstalledSolutionMap>();
        }

        /// <summary> Initializes a new instance of <see cref="AgricultureServicePatchProperties"/>. </summary>
        /// <param name="config"> Config of the AgriService instance. </param>
        /// <param name="dataConnectorCredentials"> Data connector credentials of AgriService instance. </param>
        /// <param name="installedSolutions"> AgriService installed solutions. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AgricultureServicePatchProperties(AgricultureServiceConfig config, IList<DataConnectorCredentialMap> dataConnectorCredentials, IList<InstalledSolutionMap> installedSolutions, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Config = config;
            DataConnectorCredentials = dataConnectorCredentials;
            InstalledSolutions = installedSolutions;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Config of the AgriService instance. </summary>
        public AgricultureServiceConfig Config { get; set; }
        /// <summary> Data connector credentials of AgriService instance. </summary>
        public IList<DataConnectorCredentialMap> DataConnectorCredentials { get; }
        /// <summary> AgriService installed solutions. </summary>
        public IList<InstalledSolutionMap> InstalledSolutions { get; }
    }
}

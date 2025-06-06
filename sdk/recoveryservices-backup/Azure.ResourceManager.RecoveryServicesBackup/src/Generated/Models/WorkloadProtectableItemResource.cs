// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Base class for backup item. Workload-specific backup items are derived from this class. </summary>
    public partial class WorkloadProtectableItemResource : TrackedResourceData
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

        /// <summary> Initializes a new instance of <see cref="WorkloadProtectableItemResource"/>. </summary>
        /// <param name="location"> The location. </param>
        public WorkloadProtectableItemResource(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of <see cref="WorkloadProtectableItemResource"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="properties">
        /// WorkloadProtectableItemResource properties
        /// Please note <see cref="WorkloadProtectableItem"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="FileShareProtectableItem"/>, <see cref="VmWorkloadProtectableItem"/>, <see cref="VmWorkloadSapHanaHsrProtectableItem"/>, <see cref="IaasVmProtectableItem"/>, <see cref="IaasClassicComputeVmProtectableItem"/>, <see cref="IaasComputeVmProtectableItem"/>, <see cref="VmWorkloadSapAseDatabaseProtectableItem"/>, <see cref="VmWorkloadSapAseSystemProtectableItem"/>, <see cref="VmWorkloadSapHanaDatabaseProtectableItem"/>, <see cref="VmWorkloadSapHanaDBInstance"/>, <see cref="VmWorkloadSapHanaSystemProtectableItem"/>, <see cref="VmWorkloadSqlAvailabilityGroupProtectableItem"/>, <see cref="VmWorkloadSqlDatabaseProtectableItem"/> and <see cref="VmWorkloadSqlInstanceProtectableItem"/>.
        /// </param>
        /// <param name="eTag"> Optional ETag. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal WorkloadProtectableItemResource(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, WorkloadProtectableItem properties, ETag? eTag, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            Properties = properties;
            ETag = eTag;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="WorkloadProtectableItemResource"/> for deserialization. </summary>
        internal WorkloadProtectableItemResource()
        {
        }

        /// <summary>
        /// WorkloadProtectableItemResource properties
        /// Please note <see cref="WorkloadProtectableItem"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="FileShareProtectableItem"/>, <see cref="VmWorkloadProtectableItem"/>, <see cref="VmWorkloadSapHanaHsrProtectableItem"/>, <see cref="IaasVmProtectableItem"/>, <see cref="IaasClassicComputeVmProtectableItem"/>, <see cref="IaasComputeVmProtectableItem"/>, <see cref="VmWorkloadSapAseDatabaseProtectableItem"/>, <see cref="VmWorkloadSapAseSystemProtectableItem"/>, <see cref="VmWorkloadSapHanaDatabaseProtectableItem"/>, <see cref="VmWorkloadSapHanaDBInstance"/>, <see cref="VmWorkloadSapHanaSystemProtectableItem"/>, <see cref="VmWorkloadSqlAvailabilityGroupProtectableItem"/>, <see cref="VmWorkloadSqlDatabaseProtectableItem"/> and <see cref="VmWorkloadSqlInstanceProtectableItem"/>.
        /// </summary>
        public WorkloadProtectableItem Properties { get; set; }
        /// <summary> Optional ETag. </summary>
        public ETag? ETag { get; set; }
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.OracleDatabase.Models
{
    /// <summary> AutonomousDatabaseBackup resource model. </summary>
    public partial class AutonomousDatabaseBackupProperties
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

        /// <summary> Initializes a new instance of <see cref="AutonomousDatabaseBackupProperties"/>. </summary>
        public AutonomousDatabaseBackupProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AutonomousDatabaseBackupProperties"/>. </summary>
        /// <param name="databaseOcid"> The OCID of the Autonomous Database. </param>
        /// <param name="databaseSizeInTbs"> The size of the database in terabytes at the time the backup was taken. </param>
        /// <param name="dbVersion"> A valid Oracle Database version for Autonomous Database. </param>
        /// <param name="displayName"> The user-friendly name for the backup. The name does not have to be unique. </param>
        /// <param name="databaseBackupOcid"> The OCID of the Autonomous Database backup. </param>
        /// <param name="isAutomatic"> Indicates whether the backup is user-initiated or automatic. </param>
        /// <param name="isRestorable"> Indicates whether the backup can be used to restore the associated Autonomous Database. </param>
        /// <param name="lifecycleDetails"> Additional information about the current lifecycle state. </param>
        /// <param name="lifecycleState"> The current state of the backup. </param>
        /// <param name="retentionPeriodInDays"> Retention period, in days. </param>
        /// <param name="sizeInTbs"> The backup size in terabytes (TB). </param>
        /// <param name="timeAvailableTil"> Timestamp until when the backup will be available. </param>
        /// <param name="timeStarted"> The date and time the backup started. </param>
        /// <param name="timeEnded"> The date and time the backup completed. </param>
        /// <param name="backupType"> The type of backup. </param>
        /// <param name="provisioningState"> Azure resource provisioning state. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AutonomousDatabaseBackupProperties(string databaseOcid, double? databaseSizeInTbs, string dbVersion, string displayName, string databaseBackupOcid, bool? isAutomatic, bool? isRestorable, string lifecycleDetails, AutonomousDatabaseBackupLifecycleState? lifecycleState, int? retentionPeriodInDays, double? sizeInTbs, DateTimeOffset? timeAvailableTil, string timeStarted, string timeEnded, AutonomousDatabaseBackupType? backupType, OracleDatabaseProvisioningState? provisioningState, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DatabaseOcid = databaseOcid;
            DatabaseSizeInTbs = databaseSizeInTbs;
            DBVersion = dbVersion;
            DisplayName = displayName;
            DatabaseBackupOcid = databaseBackupOcid;
            IsAutomatic = isAutomatic;
            IsRestorable = isRestorable;
            LifecycleDetails = lifecycleDetails;
            LifecycleState = lifecycleState;
            RetentionPeriodInDays = retentionPeriodInDays;
            SizeInTbs = sizeInTbs;
            TimeAvailableTil = timeAvailableTil;
            TimeStarted = timeStarted;
            TimeEnded = timeEnded;
            BackupType = backupType;
            ProvisioningState = provisioningState;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The OCID of the Autonomous Database. </summary>
        public string DatabaseOcid { get; }
        /// <summary> The size of the database in terabytes at the time the backup was taken. </summary>
        public double? DatabaseSizeInTbs { get; }
        /// <summary> A valid Oracle Database version for Autonomous Database. </summary>
        public string DBVersion { get; }
        /// <summary> The user-friendly name for the backup. The name does not have to be unique. </summary>
        public string DisplayName { get; set; }
        /// <summary> The OCID of the Autonomous Database backup. </summary>
        public string DatabaseBackupOcid { get; }
        /// <summary> Indicates whether the backup is user-initiated or automatic. </summary>
        public bool? IsAutomatic { get; }
        /// <summary> Indicates whether the backup can be used to restore the associated Autonomous Database. </summary>
        public bool? IsRestorable { get; }
        /// <summary> Additional information about the current lifecycle state. </summary>
        public string LifecycleDetails { get; }
        /// <summary> The current state of the backup. </summary>
        public AutonomousDatabaseBackupLifecycleState? LifecycleState { get; }
        /// <summary> Retention period, in days. </summary>
        public int? RetentionPeriodInDays { get; set; }
        /// <summary> The backup size in terabytes (TB). </summary>
        public double? SizeInTbs { get; }
        /// <summary> Timestamp until when the backup will be available. </summary>
        public DateTimeOffset? TimeAvailableTil { get; }
        /// <summary> The date and time the backup started. </summary>
        public string TimeStarted { get; }
        /// <summary> The date and time the backup completed. </summary>
        public string TimeEnded { get; }
        /// <summary> The type of backup. </summary>
        public AutonomousDatabaseBackupType? BackupType { get; }
        /// <summary> Azure resource provisioning state. </summary>
        public OracleDatabaseProvisioningState? ProvisioningState { get; }
    }
}

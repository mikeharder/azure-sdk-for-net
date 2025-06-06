// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class HyperVReplicaAzureReplicationDetails : IUtf8JsonSerializable, IJsonModel<HyperVReplicaAzureReplicationDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HyperVReplicaAzureReplicationDetails>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<HyperVReplicaAzureReplicationDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HyperVReplicaAzureReplicationDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HyperVReplicaAzureReplicationDetails)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsCollectionDefined(AzureVmDiskDetails))
            {
                writer.WritePropertyName("azureVmDiskDetails"u8);
                writer.WriteStartArray();
                foreach (var item in AzureVmDiskDetails)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(RecoveryAzureVmName))
            {
                writer.WritePropertyName("recoveryAzureVmName"u8);
                writer.WriteStringValue(RecoveryAzureVmName);
            }
            if (Optional.IsDefined(RecoveryAzureVmSize))
            {
                writer.WritePropertyName("recoveryAzureVMSize"u8);
                writer.WriteStringValue(RecoveryAzureVmSize);
            }
            if (Optional.IsDefined(RecoveryAzureStorageAccount))
            {
                writer.WritePropertyName("recoveryAzureStorageAccount"u8);
                writer.WriteStringValue(RecoveryAzureStorageAccount);
            }
            if (Optional.IsDefined(RecoveryAzureLogStorageAccountId))
            {
                writer.WritePropertyName("recoveryAzureLogStorageAccountId"u8);
                writer.WriteStringValue(RecoveryAzureLogStorageAccountId);
            }
            if (Optional.IsDefined(LastReplicatedOn))
            {
                writer.WritePropertyName("lastReplicatedTime"u8);
                writer.WriteStringValue(LastReplicatedOn.Value, "O");
            }
            if (Optional.IsDefined(RpoInSeconds))
            {
                writer.WritePropertyName("rpoInSeconds"u8);
                writer.WriteNumberValue(RpoInSeconds.Value);
            }
            if (Optional.IsDefined(LastRpoCalculatedOn))
            {
                writer.WritePropertyName("lastRpoCalculatedTime"u8);
                writer.WriteStringValue(LastRpoCalculatedOn.Value, "O");
            }
            if (Optional.IsDefined(VmId))
            {
                writer.WritePropertyName("vmId"u8);
                writer.WriteStringValue(VmId);
            }
            if (Optional.IsDefined(VmProtectionState))
            {
                writer.WritePropertyName("vmProtectionState"u8);
                writer.WriteStringValue(VmProtectionState);
            }
            if (Optional.IsDefined(VmProtectionStateDescription))
            {
                writer.WritePropertyName("vmProtectionStateDescription"u8);
                writer.WriteStringValue(VmProtectionStateDescription);
            }
            if (Optional.IsDefined(InitialReplicationDetails))
            {
                writer.WritePropertyName("initialReplicationDetails"u8);
                writer.WriteObjectValue(InitialReplicationDetails, options);
            }
            if (Optional.IsCollectionDefined(VmNics))
            {
                writer.WritePropertyName("vmNics"u8);
                writer.WriteStartArray();
                foreach (var item in VmNics)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(SelectedRecoveryAzureNetworkId))
            {
                writer.WritePropertyName("selectedRecoveryAzureNetworkId"u8);
                writer.WriteStringValue(SelectedRecoveryAzureNetworkId);
            }
            if (Optional.IsDefined(SelectedSourceNicId))
            {
                writer.WritePropertyName("selectedSourceNicId"u8);
                writer.WriteStringValue(SelectedSourceNicId);
            }
            if (Optional.IsDefined(Encryption))
            {
                writer.WritePropertyName("encryption"u8);
                writer.WriteStringValue(Encryption);
            }
            if (Optional.IsDefined(OSDetails))
            {
                writer.WritePropertyName("oSDetails"u8);
                writer.WriteObjectValue(OSDetails, options);
            }
            if (Optional.IsDefined(SourceVmRamSizeInMB))
            {
                writer.WritePropertyName("sourceVmRamSizeInMB"u8);
                writer.WriteNumberValue(SourceVmRamSizeInMB.Value);
            }
            if (Optional.IsDefined(SourceVmCpuCount))
            {
                writer.WritePropertyName("sourceVmCpuCount"u8);
                writer.WriteNumberValue(SourceVmCpuCount.Value);
            }
            if (Optional.IsDefined(EnableRdpOnTargetOption))
            {
                writer.WritePropertyName("enableRdpOnTargetOption"u8);
                writer.WriteStringValue(EnableRdpOnTargetOption);
            }
            if (Optional.IsDefined(RecoveryAzureResourceGroupId))
            {
                writer.WritePropertyName("recoveryAzureResourceGroupId"u8);
                writer.WriteStringValue(RecoveryAzureResourceGroupId);
            }
            if (Optional.IsDefined(RecoveryAvailabilitySetId))
            {
                writer.WritePropertyName("recoveryAvailabilitySetId"u8);
                writer.WriteStringValue(RecoveryAvailabilitySetId);
            }
            if (Optional.IsDefined(TargetAvailabilityZone))
            {
                writer.WritePropertyName("targetAvailabilityZone"u8);
                writer.WriteStringValue(TargetAvailabilityZone);
            }
            if (Optional.IsDefined(TargetProximityPlacementGroupId))
            {
                writer.WritePropertyName("targetProximityPlacementGroupId"u8);
                writer.WriteStringValue(TargetProximityPlacementGroupId);
            }
            if (Optional.IsDefined(UseManagedDisks))
            {
                writer.WritePropertyName("useManagedDisks"u8);
                writer.WriteStringValue(UseManagedDisks);
            }
            if (Optional.IsDefined(LicenseType))
            {
                writer.WritePropertyName("licenseType"u8);
                writer.WriteStringValue(LicenseType);
            }
            if (Optional.IsDefined(SqlServerLicenseType))
            {
                writer.WritePropertyName("sqlServerLicenseType"u8);
                writer.WriteStringValue(SqlServerLicenseType);
            }
            if (Optional.IsDefined(LinuxLicenseType))
            {
                writer.WritePropertyName("linuxLicenseType"u8);
                writer.WriteStringValue(LinuxLicenseType.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(LastRecoveryPointReceived))
            {
                writer.WritePropertyName("lastRecoveryPointReceived"u8);
                writer.WriteStringValue(LastRecoveryPointReceived.Value, "O");
            }
            if (Optional.IsCollectionDefined(TargetVmTags))
            {
                writer.WritePropertyName("targetVmTags"u8);
                writer.WriteStartObject();
                foreach (var item in TargetVmTags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(SeedManagedDiskTags))
            {
                writer.WritePropertyName("seedManagedDiskTags"u8);
                writer.WriteStartObject();
                foreach (var item in SeedManagedDiskTags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(TargetManagedDiskTags))
            {
                writer.WritePropertyName("targetManagedDiskTags"u8);
                writer.WriteStartObject();
                foreach (var item in TargetManagedDiskTags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(TargetNicTags))
            {
                writer.WritePropertyName("targetNicTags"u8);
                writer.WriteStartObject();
                foreach (var item in TargetNicTags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(ProtectedManagedDisks))
            {
                writer.WritePropertyName("protectedManagedDisks"u8);
                writer.WriteStartArray();
                foreach (var item in ProtectedManagedDisks)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(AllAvailableOSUpgradeConfigurations))
            {
                writer.WritePropertyName("allAvailableOSUpgradeConfigurations"u8);
                writer.WriteStartArray();
                foreach (var item in AllAvailableOSUpgradeConfigurations)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(TargetVmSecurityProfile))
            {
                writer.WritePropertyName("targetVmSecurityProfile"u8);
                writer.WriteObjectValue(TargetVmSecurityProfile, options);
            }
        }

        HyperVReplicaAzureReplicationDetails IJsonModel<HyperVReplicaAzureReplicationDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HyperVReplicaAzureReplicationDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HyperVReplicaAzureReplicationDetails)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHyperVReplicaAzureReplicationDetails(document.RootElement, options);
        }

        internal static HyperVReplicaAzureReplicationDetails DeserializeHyperVReplicaAzureReplicationDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<SiteRecoveryVmDiskDetails> azureVmDiskDetails = default;
            string recoveryAzureVmName = default;
            string recoveryAzureVmSize = default;
            string recoveryAzureStorageAccount = default;
            ResourceIdentifier recoveryAzureLogStorageAccountId = default;
            DateTimeOffset? lastReplicatedTime = default;
            long? rpoInSeconds = default;
            DateTimeOffset? lastRpoCalculatedTime = default;
            string vmId = default;
            string vmProtectionState = default;
            string vmProtectionStateDescription = default;
            InitialReplicationDetails initialReplicationDetails = default;
            IReadOnlyList<VmNicDetails> vmNics = default;
            ResourceIdentifier selectedRecoveryAzureNetworkId = default;
            string selectedSourceNicId = default;
            string encryption = default;
            SiteRecoveryOSDetails osDetails = default;
            int? sourceVmRamSizeInMB = default;
            int? sourceVmCpuCount = default;
            string enableRdpOnTargetOption = default;
            ResourceIdentifier recoveryAzureResourceGroupId = default;
            ResourceIdentifier recoveryAvailabilitySetId = default;
            string targetAvailabilityZone = default;
            ResourceIdentifier targetProximityPlacementGroupId = default;
            string useManagedDisks = default;
            string licenseType = default;
            string sqlServerLicenseType = default;
            RecoveryServicesSiteRecoveryLinuxLicenseType? linuxLicenseType = default;
            DateTimeOffset? lastRecoveryPointReceived = default;
            IReadOnlyDictionary<string, string> targetVmTags = default;
            IReadOnlyDictionary<string, string> seedManagedDiskTags = default;
            IReadOnlyDictionary<string, string> targetManagedDiskTags = default;
            IReadOnlyDictionary<string, string> targetNicTags = default;
            IReadOnlyList<HyperVReplicaAzureManagedDiskDetails> protectedManagedDisks = default;
            IReadOnlyList<OSUpgradeSupportedVersions> allAvailableOSUpgradeConfigurations = default;
            RecoveryServicesSiteRecoverySecurityProfileProperties targetVmSecurityProfile = default;
            string instanceType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("azureVmDiskDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SiteRecoveryVmDiskDetails> array = new List<SiteRecoveryVmDiskDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SiteRecoveryVmDiskDetails.DeserializeSiteRecoveryVmDiskDetails(item, options));
                    }
                    azureVmDiskDetails = array;
                    continue;
                }
                if (property.NameEquals("recoveryAzureVmName"u8))
                {
                    recoveryAzureVmName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recoveryAzureVMSize"u8))
                {
                    recoveryAzureVmSize = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recoveryAzureStorageAccount"u8))
                {
                    recoveryAzureStorageAccount = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recoveryAzureLogStorageAccountId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryAzureLogStorageAccountId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("lastReplicatedTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastReplicatedTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("rpoInSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rpoInSeconds = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("lastRpoCalculatedTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastRpoCalculatedTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("vmId"u8))
                {
                    vmId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vmProtectionState"u8))
                {
                    vmProtectionState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vmProtectionStateDescription"u8))
                {
                    vmProtectionStateDescription = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("initialReplicationDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    initialReplicationDetails = InitialReplicationDetails.DeserializeInitialReplicationDetails(property.Value, options);
                    continue;
                }
                if (property.NameEquals("vmNics"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<VmNicDetails> array = new List<VmNicDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VmNicDetails.DeserializeVmNicDetails(item, options));
                    }
                    vmNics = array;
                    continue;
                }
                if (property.NameEquals("selectedRecoveryAzureNetworkId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    selectedRecoveryAzureNetworkId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("selectedSourceNicId"u8))
                {
                    selectedSourceNicId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("encryption"u8))
                {
                    encryption = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("oSDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    osDetails = SiteRecoveryOSDetails.DeserializeSiteRecoveryOSDetails(property.Value, options);
                    continue;
                }
                if (property.NameEquals("sourceVmRamSizeInMB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceVmRamSizeInMB = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("sourceVmCpuCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceVmCpuCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("enableRdpOnTargetOption"u8))
                {
                    enableRdpOnTargetOption = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recoveryAzureResourceGroupId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryAzureResourceGroupId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("recoveryAvailabilitySetId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryAvailabilitySetId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetAvailabilityZone"u8))
                {
                    targetAvailabilityZone = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetProximityPlacementGroupId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetProximityPlacementGroupId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("useManagedDisks"u8))
                {
                    useManagedDisks = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("licenseType"u8))
                {
                    licenseType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sqlServerLicenseType"u8))
                {
                    sqlServerLicenseType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("linuxLicenseType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    linuxLicenseType = new RecoveryServicesSiteRecoveryLinuxLicenseType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("lastRecoveryPointReceived"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastRecoveryPointReceived = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("targetVmTags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    targetVmTags = dictionary;
                    continue;
                }
                if (property.NameEquals("seedManagedDiskTags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    seedManagedDiskTags = dictionary;
                    continue;
                }
                if (property.NameEquals("targetManagedDiskTags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    targetManagedDiskTags = dictionary;
                    continue;
                }
                if (property.NameEquals("targetNicTags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    targetNicTags = dictionary;
                    continue;
                }
                if (property.NameEquals("protectedManagedDisks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<HyperVReplicaAzureManagedDiskDetails> array = new List<HyperVReplicaAzureManagedDiskDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HyperVReplicaAzureManagedDiskDetails.DeserializeHyperVReplicaAzureManagedDiskDetails(item, options));
                    }
                    protectedManagedDisks = array;
                    continue;
                }
                if (property.NameEquals("allAvailableOSUpgradeConfigurations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<OSUpgradeSupportedVersions> array = new List<OSUpgradeSupportedVersions>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(OSUpgradeSupportedVersions.DeserializeOSUpgradeSupportedVersions(item, options));
                    }
                    allAvailableOSUpgradeConfigurations = array;
                    continue;
                }
                if (property.NameEquals("targetVmSecurityProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetVmSecurityProfile = RecoveryServicesSiteRecoverySecurityProfileProperties.DeserializeRecoveryServicesSiteRecoverySecurityProfileProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new HyperVReplicaAzureReplicationDetails(
                instanceType,
                serializedAdditionalRawData,
                azureVmDiskDetails ?? new ChangeTrackingList<SiteRecoveryVmDiskDetails>(),
                recoveryAzureVmName,
                recoveryAzureVmSize,
                recoveryAzureStorageAccount,
                recoveryAzureLogStorageAccountId,
                lastReplicatedTime,
                rpoInSeconds,
                lastRpoCalculatedTime,
                vmId,
                vmProtectionState,
                vmProtectionStateDescription,
                initialReplicationDetails,
                vmNics ?? new ChangeTrackingList<VmNicDetails>(),
                selectedRecoveryAzureNetworkId,
                selectedSourceNicId,
                encryption,
                osDetails,
                sourceVmRamSizeInMB,
                sourceVmCpuCount,
                enableRdpOnTargetOption,
                recoveryAzureResourceGroupId,
                recoveryAvailabilitySetId,
                targetAvailabilityZone,
                targetProximityPlacementGroupId,
                useManagedDisks,
                licenseType,
                sqlServerLicenseType,
                linuxLicenseType,
                lastRecoveryPointReceived,
                targetVmTags ?? new ChangeTrackingDictionary<string, string>(),
                seedManagedDiskTags ?? new ChangeTrackingDictionary<string, string>(),
                targetManagedDiskTags ?? new ChangeTrackingDictionary<string, string>(),
                targetNicTags ?? new ChangeTrackingDictionary<string, string>(),
                protectedManagedDisks ?? new ChangeTrackingList<HyperVReplicaAzureManagedDiskDetails>(),
                allAvailableOSUpgradeConfigurations ?? new ChangeTrackingList<OSUpgradeSupportedVersions>(),
                targetVmSecurityProfile);
        }

        BinaryData IPersistableModel<HyperVReplicaAzureReplicationDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HyperVReplicaAzureReplicationDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerRecoveryServicesSiteRecoveryContext.Default);
                default:
                    throw new FormatException($"The model {nameof(HyperVReplicaAzureReplicationDetails)} does not support writing '{options.Format}' format.");
            }
        }

        HyperVReplicaAzureReplicationDetails IPersistableModel<HyperVReplicaAzureReplicationDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HyperVReplicaAzureReplicationDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeHyperVReplicaAzureReplicationDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HyperVReplicaAzureReplicationDetails)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<HyperVReplicaAzureReplicationDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

// <auto-generated/>

using Azure.ResourceManager.DataBox;
using Azure.ResourceManager.DataBox.Models;
using System.ClientModel.Primitives;

namespace Azure.ResourceManager.DataBox;

[ModelReaderWriterBuildable(typeof(DataBoxJobData))]
[ModelReaderWriterBuildable(typeof(DataBoxJobResource))]
#pragma warning disable CS0618 // Type or member is obsolete
[ModelReaderWriterBuildable(typeof(DataboxJobSecrets))]
#pragma warning restore CS0618 // Type or member is obsolete
[ModelReaderWriterBuildable(typeof(DataBoxJobStage))]
[ModelReaderWriterBuildable(typeof(DataBoxManagedIdentity))]
[ModelReaderWriterBuildable(typeof(DataBoxOrderPreferences))]
[ModelReaderWriterBuildable(typeof(DataBoxShippingAddress))]
[ModelReaderWriterBuildable(typeof(DataBoxValidateAddressContent))]
[ModelReaderWriterBuildable(typeof(MitigateJobContent))]
[ModelReaderWriterBuildable(typeof(RegionConfigurationContent))]
[ModelReaderWriterBuildable(typeof(AddressValidationOutput))]
[ModelReaderWriterBuildable(typeof(AddressValidationResult))]
[ModelReaderWriterBuildable(typeof(ApplianceNetworkConfiguration))]
[ModelReaderWriterBuildable(typeof(AvailableSkusContent))]
[ModelReaderWriterBuildable(typeof(AvailableSkusResult))]
[ModelReaderWriterBuildable(typeof(AzureFileFilterDetails))]
[ModelReaderWriterBuildable(typeof(BlobFilterDetails))]
[ModelReaderWriterBuildable(typeof(ContactInfo))]
[ModelReaderWriterBuildable(typeof(CopyLogDetails))]
[ModelReaderWriterBuildable(typeof(CreateJobValidationContent))]
[ModelReaderWriterBuildable(typeof(CreateOrderLimitForSubscriptionValidationContent))]
[ModelReaderWriterBuildable(typeof(CreateOrderLimitForSubscriptionValidationResult))]
[ModelReaderWriterBuildable(typeof(CustomerDiskJobSecrets))]
[ModelReaderWriterBuildable(typeof(DataAccountDetails))]
[ModelReaderWriterBuildable(typeof(DataBoxAccountCopyLogDetails))]
[ModelReaderWriterBuildable(typeof(DataBoxAccountCredentialDetails))]
[ModelReaderWriterBuildable(typeof(DataBoxBasicJobDetails))]
[ModelReaderWriterBuildable(typeof(DataBoxContactDetails))]
[ModelReaderWriterBuildable(typeof(DataBoxCopyProgress))]
[ModelReaderWriterBuildable(typeof(DataBoxCustomerDiskCopyLogDetails))]
[ModelReaderWriterBuildable(typeof(DataBoxCustomerDiskCopyProgress))]
[ModelReaderWriterBuildable(typeof(DataBoxCustomerDiskJobDetails))]
[ModelReaderWriterBuildable(typeof(DataBoxDiskCopyLogDetails))]
[ModelReaderWriterBuildable(typeof(DataBoxDiskCopyProgress))]
[ModelReaderWriterBuildable(typeof(DataBoxDiskGranularCopyLogDetails))]
[ModelReaderWriterBuildable(typeof(DataBoxDiskGranularCopyProgress))]
[ModelReaderWriterBuildable(typeof(DataBoxDiskJobDetails))]
[ModelReaderWriterBuildable(typeof(DataBoxDiskJobSecrets))]
[ModelReaderWriterBuildable(typeof(DataBoxDiskSecret))]
[ModelReaderWriterBuildable(typeof(DataBoxEncryptionPreferences))]
[ModelReaderWriterBuildable(typeof(DataBoxHeavyAccountCopyLogDetails))]
[ModelReaderWriterBuildable(typeof(DataBoxHeavyJobDetails))]
[ModelReaderWriterBuildable(typeof(DataBoxHeavyJobSecrets))]
[ModelReaderWriterBuildable(typeof(DataBoxHeavySecret))]
[ModelReaderWriterBuildable(typeof(DataBoxJobCancellationReason))]
[ModelReaderWriterBuildable(typeof(DataBoxJobDetails))]
[ModelReaderWriterBuildable(typeof(DataBoxJobListResult))]
[ModelReaderWriterBuildable(typeof(DataBoxJobPatch))]
[ModelReaderWriterBuildable(typeof(DataBoxJobSecrets))]
[ModelReaderWriterBuildable(typeof(DataBoxKeyEncryptionKey))]
[ModelReaderWriterBuildable(typeof(DataBoxScheduleAvailabilityContent))]
[ModelReaderWriterBuildable(typeof(DataBoxSecret))]
[ModelReaderWriterBuildable(typeof(DataBoxShipmentPickUpResult))]
[ModelReaderWriterBuildable(typeof(DataBoxSku))]
[ModelReaderWriterBuildable(typeof(DataBoxSkuCapacity))]
[ModelReaderWriterBuildable(typeof(DataBoxSkuCost))]
[ModelReaderWriterBuildable(typeof(DataBoxSkuInformation))]
[ModelReaderWriterBuildable(typeof(DataBoxStorageAccountDetails))]
[ModelReaderWriterBuildable(typeof(DataBoxUserAssignedIdentity))]
[ModelReaderWriterBuildable(typeof(DataBoxValidationContent))]
[ModelReaderWriterBuildable(typeof(DataBoxValidationInputContent))]
[ModelReaderWriterBuildable(typeof(DataBoxValidationInputResult))]
[ModelReaderWriterBuildable(typeof(DataBoxValidationResult))]
[ModelReaderWriterBuildable(typeof(DataCenterAccessSecurityCode))]
[ModelReaderWriterBuildable(typeof(DataCenterAddressContent))]
[ModelReaderWriterBuildable(typeof(DataCenterAddressInstructionResult))]
[ModelReaderWriterBuildable(typeof(DataCenterAddressLocationResult))]
[ModelReaderWriterBuildable(typeof(DataCenterAddressResult))]
[ModelReaderWriterBuildable(typeof(DataExportDetails))]
[ModelReaderWriterBuildable(typeof(DataImportDetails))]
[ModelReaderWriterBuildable(typeof(DataLocationToServiceLocationMap))]
[ModelReaderWriterBuildable(typeof(DataTransferDetailsValidationContent))]
[ModelReaderWriterBuildable(typeof(DataTransferDetailsValidationResult))]
[ModelReaderWriterBuildable(typeof(DeviceCapabilityContent))]
[ModelReaderWriterBuildable(typeof(DeviceCapabilityDetails))]
[ModelReaderWriterBuildable(typeof(DeviceCapabilityResponse))]
[ModelReaderWriterBuildable(typeof(DeviceErasureDetails))]
[ModelReaderWriterBuildable(typeof(DiskScheduleAvailabilityContent))]
[ModelReaderWriterBuildable(typeof(ExportDiskDetails))]
[ModelReaderWriterBuildable(typeof(FilterFileDetails))]
[ModelReaderWriterBuildable(typeof(GranularCopyLogDetails))]
[ModelReaderWriterBuildable(typeof(GranularCopyProgress))]
[ModelReaderWriterBuildable(typeof(HeavyScheduleAvailabilityContent))]
[ModelReaderWriterBuildable(typeof(ImportDiskDetails))]
[ModelReaderWriterBuildable(typeof(JobDelayDetails))]
[ModelReaderWriterBuildable(typeof(JobDeliveryInfo))]
[ModelReaderWriterBuildable(typeof(JobSecrets))]
[ModelReaderWriterBuildable(typeof(LastMitigationActionOnJob))]
[ModelReaderWriterBuildable(typeof(ManagedDiskDetails))]
[ModelReaderWriterBuildable(typeof(MarkDevicesShippedContent))]
[ModelReaderWriterBuildable(typeof(NotificationPreference))]
[ModelReaderWriterBuildable(typeof(PackageCarrierDetails))]
[ModelReaderWriterBuildable(typeof(PackageCarrierInfo))]
[ModelReaderWriterBuildable(typeof(PackageShippingDetails))]
[ModelReaderWriterBuildable(typeof(PreferencesValidationContent))]
[ModelReaderWriterBuildable(typeof(PreferencesValidationResult))]
[ModelReaderWriterBuildable(typeof(RegionConfigurationResult))]
[ModelReaderWriterBuildable(typeof(ReverseShippingDetails))]
[ModelReaderWriterBuildable(typeof(ScheduleAvailabilityContent))]
[ModelReaderWriterBuildable(typeof(ScheduleAvailabilityResponse))]
[ModelReaderWriterBuildable(typeof(ShareCredentialDetails))]
[ModelReaderWriterBuildable(typeof(ShipmentPickUpContent))]
[ModelReaderWriterBuildable(typeof(SkuAvailabilityValidationContent))]
[ModelReaderWriterBuildable(typeof(SkuAvailabilityValidationResult))]
[ModelReaderWriterBuildable(typeof(SubscriptionIsAllowedToCreateJobValidationContent))]
[ModelReaderWriterBuildable(typeof(SubscriptionIsAllowedToCreateJobValidationResult))]
[ModelReaderWriterBuildable(typeof(TransferAllDetails))]
[ModelReaderWriterBuildable(typeof(TransferConfiguration))]
[ModelReaderWriterBuildable(typeof(TransferConfigurationTransferAllDetails))]
[ModelReaderWriterBuildable(typeof(TransferConfigurationTransferFilterDetails))]
[ModelReaderWriterBuildable(typeof(TransferFilterDetails))]
[ModelReaderWriterBuildable(typeof(TransportAvailabilityContent))]
[ModelReaderWriterBuildable(typeof(TransportAvailabilityDetails))]
[ModelReaderWriterBuildable(typeof(TransportAvailabilityResponse))]
[ModelReaderWriterBuildable(typeof(TransportPreferences))]
[ModelReaderWriterBuildable(typeof(UnencryptedCredentials))]
[ModelReaderWriterBuildable(typeof(UnencryptedCredentialsList))]
[ModelReaderWriterBuildable(typeof(UnknownCopyLogDetails))]
[ModelReaderWriterBuildable(typeof(UnknownDataAccountDetails))]
[ModelReaderWriterBuildable(typeof(UnknownDataCenterAddressResponse))]
[ModelReaderWriterBuildable(typeof(UnknownGranularCopyLogDetails))]
[ModelReaderWriterBuildable(typeof(UnknownJobDetails))]
[ModelReaderWriterBuildable(typeof(UnknownJobSecrets))]
[ModelReaderWriterBuildable(typeof(UnknownScheduleAvailabilityRequest))]
[ModelReaderWriterBuildable(typeof(UnknownValidationInputRequest))]
[ModelReaderWriterBuildable(typeof(UnknownValidationInputResponse))]
[ModelReaderWriterBuildable(typeof(UnknownValidationRequest))]
[ModelReaderWriterBuildable(typeof(UpdateJobDetails))]
public partial class AzureResourceManagerDataBoxContext
{
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SiteRecoveryVmwareReplicatedVm
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.siteRecoveryVmwareReplicatedVm.SiteRecoveryVmwareReplicatedVmManagedDisk")]
    public class SiteRecoveryVmwareReplicatedVmManagedDisk : azurerm.SiteRecoveryVmwareReplicatedVm.ISiteRecoveryVmwareReplicatedVmManagedDisk
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_vmware_replicated_vm#disk_id SiteRecoveryVmwareReplicatedVm#disk_id}.</summary>
        [JsiiProperty(name: "diskId", typeJson: "{\"primitive\":\"string\"}")]
        public string DiskId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_vmware_replicated_vm#target_disk_type SiteRecoveryVmwareReplicatedVm#target_disk_type}.</summary>
        [JsiiProperty(name: "targetDiskType", typeJson: "{\"primitive\":\"string\"}")]
        public string TargetDiskType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_vmware_replicated_vm#log_storage_account_id SiteRecoveryVmwareReplicatedVm#log_storage_account_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "logStorageAccountId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LogStorageAccountId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_vmware_replicated_vm#target_disk_encryption_set_id SiteRecoveryVmwareReplicatedVm#target_disk_encryption_set_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetDiskEncryptionSetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TargetDiskEncryptionSetId
        {
            get;
            set;
        }
    }
}

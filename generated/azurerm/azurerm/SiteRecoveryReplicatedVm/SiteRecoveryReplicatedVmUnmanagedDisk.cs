using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SiteRecoveryReplicatedVm
{
    [JsiiByValue(fqn: "azurerm.siteRecoveryReplicatedVm.SiteRecoveryReplicatedVmUnmanagedDisk")]
    public class SiteRecoveryReplicatedVmUnmanagedDisk : azurerm.SiteRecoveryReplicatedVm.ISiteRecoveryReplicatedVmUnmanagedDisk
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_replicated_vm#disk_uri SiteRecoveryReplicatedVm#disk_uri}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "diskUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DiskUri
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_replicated_vm#staging_storage_account_id SiteRecoveryReplicatedVm#staging_storage_account_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "stagingStorageAccountId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StagingStorageAccountId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_replicated_vm#target_storage_account_id SiteRecoveryReplicatedVm#target_storage_account_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetStorageAccountId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TargetStorageAccountId
        {
            get;
            set;
        }
    }
}

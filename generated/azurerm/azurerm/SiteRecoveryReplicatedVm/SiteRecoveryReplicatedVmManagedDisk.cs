using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SiteRecoveryReplicatedVm
{
    [JsiiByValue(fqn: "azurerm.siteRecoveryReplicatedVm.SiteRecoveryReplicatedVmManagedDisk")]
    public class SiteRecoveryReplicatedVmManagedDisk : azurerm.SiteRecoveryReplicatedVm.ISiteRecoveryReplicatedVmManagedDisk
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_replicated_vm#disk_id SiteRecoveryReplicatedVm#disk_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "diskId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DiskId
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

        private object? _targetDiskEncryption;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_replicated_vm#target_disk_encryption SiteRecoveryReplicatedVm#target_disk_encryption}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetDiskEncryption", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.siteRecoveryReplicatedVm.SiteRecoveryReplicatedVmManagedDiskTargetDiskEncryption\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? TargetDiskEncryption
        {
            get => _targetDiskEncryption;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.SiteRecoveryReplicatedVm.ISiteRecoveryReplicatedVmManagedDiskTargetDiskEncryption[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.SiteRecoveryReplicatedVm.ISiteRecoveryReplicatedVmManagedDiskTargetDiskEncryption).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _targetDiskEncryption = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_replicated_vm#target_disk_encryption_set_id SiteRecoveryReplicatedVm#target_disk_encryption_set_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetDiskEncryptionSetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TargetDiskEncryptionSetId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_replicated_vm#target_disk_type SiteRecoveryReplicatedVm#target_disk_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetDiskType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TargetDiskType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_replicated_vm#target_replica_disk_type SiteRecoveryReplicatedVm#target_replica_disk_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetReplicaDiskType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TargetReplicaDiskType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_replicated_vm#target_resource_group_id SiteRecoveryReplicatedVm#target_resource_group_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetResourceGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TargetResourceGroupId
        {
            get;
            set;
        }
    }
}

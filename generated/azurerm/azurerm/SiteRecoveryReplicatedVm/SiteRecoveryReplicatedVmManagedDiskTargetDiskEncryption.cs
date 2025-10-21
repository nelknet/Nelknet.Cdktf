using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SiteRecoveryReplicatedVm
{
    [JsiiByValue(fqn: "azurerm.siteRecoveryReplicatedVm.SiteRecoveryReplicatedVmManagedDiskTargetDiskEncryption")]
    public class SiteRecoveryReplicatedVmManagedDiskTargetDiskEncryption : azurerm.SiteRecoveryReplicatedVm.ISiteRecoveryReplicatedVmManagedDiskTargetDiskEncryption
    {
        private object? _diskEncryptionKey;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_replicated_vm#disk_encryption_key SiteRecoveryReplicatedVm#disk_encryption_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "diskEncryptionKey", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.siteRecoveryReplicatedVm.SiteRecoveryReplicatedVmManagedDiskTargetDiskEncryptionDiskEncryptionKey\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? DiskEncryptionKey
        {
            get => _diskEncryptionKey;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.SiteRecoveryReplicatedVm.ISiteRecoveryReplicatedVmManagedDiskTargetDiskEncryptionDiskEncryptionKey[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.SiteRecoveryReplicatedVm.ISiteRecoveryReplicatedVmManagedDiskTargetDiskEncryptionDiskEncryptionKey).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _diskEncryptionKey = value;
            }
        }

        private object? _keyEncryptionKey;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_replicated_vm#key_encryption_key SiteRecoveryReplicatedVm#key_encryption_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "keyEncryptionKey", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.siteRecoveryReplicatedVm.SiteRecoveryReplicatedVmManagedDiskTargetDiskEncryptionKeyEncryptionKey\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? KeyEncryptionKey
        {
            get => _keyEncryptionKey;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.SiteRecoveryReplicatedVm.ISiteRecoveryReplicatedVmManagedDiskTargetDiskEncryptionKeyEncryptionKey[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.SiteRecoveryReplicatedVm.ISiteRecoveryReplicatedVmManagedDiskTargetDiskEncryptionKeyEncryptionKey).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _keyEncryptionKey = value;
            }
        }
    }
}

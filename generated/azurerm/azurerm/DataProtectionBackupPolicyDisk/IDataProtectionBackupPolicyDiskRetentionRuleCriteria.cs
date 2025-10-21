using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataProtectionBackupPolicyDisk
{
    [JsiiInterface(nativeType: typeof(IDataProtectionBackupPolicyDiskRetentionRuleCriteria), fullyQualifiedName: "azurerm.dataProtectionBackupPolicyDisk.DataProtectionBackupPolicyDiskRetentionRuleCriteria")]
    public interface IDataProtectionBackupPolicyDiskRetentionRuleCriteria
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_policy_disk#absolute_criteria DataProtectionBackupPolicyDisk#absolute_criteria}.</summary>
        [JsiiProperty(name: "absoluteCriteria", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AbsoluteCriteria
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataProtectionBackupPolicyDiskRetentionRuleCriteria), fullyQualifiedName: "azurerm.dataProtectionBackupPolicyDisk.DataProtectionBackupPolicyDiskRetentionRuleCriteria")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataProtectionBackupPolicyDisk.IDataProtectionBackupPolicyDiskRetentionRuleCriteria
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_policy_disk#absolute_criteria DataProtectionBackupPolicyDisk#absolute_criteria}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "absoluteCriteria", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AbsoluteCriteria
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

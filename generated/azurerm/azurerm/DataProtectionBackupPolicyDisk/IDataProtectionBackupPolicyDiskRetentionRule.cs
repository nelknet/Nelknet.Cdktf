using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataProtectionBackupPolicyDisk
{
    [JsiiInterface(nativeType: typeof(IDataProtectionBackupPolicyDiskRetentionRule), fullyQualifiedName: "azurerm.dataProtectionBackupPolicyDisk.DataProtectionBackupPolicyDiskRetentionRule")]
    public interface IDataProtectionBackupPolicyDiskRetentionRule
    {
        /// <summary>criteria block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_policy_disk#criteria DataProtectionBackupPolicyDisk#criteria}
        /// </remarks>
        [JsiiProperty(name: "criteria", typeJson: "{\"fqn\":\"azurerm.dataProtectionBackupPolicyDisk.DataProtectionBackupPolicyDiskRetentionRuleCriteria\"}")]
        azurerm.DataProtectionBackupPolicyDisk.IDataProtectionBackupPolicyDiskRetentionRuleCriteria Criteria
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_policy_disk#duration DataProtectionBackupPolicyDisk#duration}.</summary>
        [JsiiProperty(name: "duration", typeJson: "{\"primitive\":\"string\"}")]
        string Duration
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_policy_disk#name DataProtectionBackupPolicyDisk#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_policy_disk#priority DataProtectionBackupPolicyDisk#priority}.</summary>
        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}")]
        double Priority
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDataProtectionBackupPolicyDiskRetentionRule), fullyQualifiedName: "azurerm.dataProtectionBackupPolicyDisk.DataProtectionBackupPolicyDiskRetentionRule")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataProtectionBackupPolicyDisk.IDataProtectionBackupPolicyDiskRetentionRule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>criteria block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_policy_disk#criteria DataProtectionBackupPolicyDisk#criteria}
            /// </remarks>
            [JsiiProperty(name: "criteria", typeJson: "{\"fqn\":\"azurerm.dataProtectionBackupPolicyDisk.DataProtectionBackupPolicyDiskRetentionRuleCriteria\"}")]
            public azurerm.DataProtectionBackupPolicyDisk.IDataProtectionBackupPolicyDiskRetentionRuleCriteria Criteria
            {
                get => GetInstanceProperty<azurerm.DataProtectionBackupPolicyDisk.IDataProtectionBackupPolicyDiskRetentionRuleCriteria>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_policy_disk#duration DataProtectionBackupPolicyDisk#duration}.</summary>
            [JsiiProperty(name: "duration", typeJson: "{\"primitive\":\"string\"}")]
            public string Duration
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_policy_disk#name DataProtectionBackupPolicyDisk#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_policy_disk#priority DataProtectionBackupPolicyDisk#priority}.</summary>
            [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}")]
            public double Priority
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}

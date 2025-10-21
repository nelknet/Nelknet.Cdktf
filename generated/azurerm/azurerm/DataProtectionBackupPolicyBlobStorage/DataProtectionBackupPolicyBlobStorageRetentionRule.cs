using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataProtectionBackupPolicyBlobStorage
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.dataProtectionBackupPolicyBlobStorage.DataProtectionBackupPolicyBlobStorageRetentionRule")]
    public class DataProtectionBackupPolicyBlobStorageRetentionRule : azurerm.DataProtectionBackupPolicyBlobStorage.IDataProtectionBackupPolicyBlobStorageRetentionRule
    {
        /// <summary>criteria block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_policy_blob_storage#criteria DataProtectionBackupPolicyBlobStorage#criteria}
        /// </remarks>
        [JsiiProperty(name: "criteria", typeJson: "{\"fqn\":\"azurerm.dataProtectionBackupPolicyBlobStorage.DataProtectionBackupPolicyBlobStorageRetentionRuleCriteria\"}")]
        public azurerm.DataProtectionBackupPolicyBlobStorage.IDataProtectionBackupPolicyBlobStorageRetentionRuleCriteria Criteria
        {
            get;
            set;
        }

        /// <summary>life_cycle block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_policy_blob_storage#life_cycle DataProtectionBackupPolicyBlobStorage#life_cycle}
        /// </remarks>
        [JsiiProperty(name: "lifeCycle", typeJson: "{\"fqn\":\"azurerm.dataProtectionBackupPolicyBlobStorage.DataProtectionBackupPolicyBlobStorageRetentionRuleLifeCycle\"}")]
        public azurerm.DataProtectionBackupPolicyBlobStorage.IDataProtectionBackupPolicyBlobStorageRetentionRuleLifeCycle LifeCycle
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_policy_blob_storage#name DataProtectionBackupPolicyBlobStorage#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_policy_blob_storage#priority DataProtectionBackupPolicyBlobStorage#priority}.</summary>
        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}")]
        public double Priority
        {
            get;
            set;
        }
    }
}

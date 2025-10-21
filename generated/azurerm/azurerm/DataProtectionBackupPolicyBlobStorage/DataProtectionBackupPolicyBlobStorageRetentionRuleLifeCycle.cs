using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataProtectionBackupPolicyBlobStorage
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.dataProtectionBackupPolicyBlobStorage.DataProtectionBackupPolicyBlobStorageRetentionRuleLifeCycle")]
    public class DataProtectionBackupPolicyBlobStorageRetentionRuleLifeCycle : azurerm.DataProtectionBackupPolicyBlobStorage.IDataProtectionBackupPolicyBlobStorageRetentionRuleLifeCycle
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_policy_blob_storage#data_store_type DataProtectionBackupPolicyBlobStorage#data_store_type}.</summary>
        [JsiiProperty(name: "dataStoreType", typeJson: "{\"primitive\":\"string\"}")]
        public string DataStoreType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_policy_blob_storage#duration DataProtectionBackupPolicyBlobStorage#duration}.</summary>
        [JsiiProperty(name: "duration", typeJson: "{\"primitive\":\"string\"}")]
        public string Duration
        {
            get;
            set;
        }
    }
}

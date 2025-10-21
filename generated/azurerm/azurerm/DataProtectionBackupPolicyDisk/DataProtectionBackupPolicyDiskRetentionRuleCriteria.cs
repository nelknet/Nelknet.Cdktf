using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataProtectionBackupPolicyDisk
{
    [JsiiByValue(fqn: "azurerm.dataProtectionBackupPolicyDisk.DataProtectionBackupPolicyDiskRetentionRuleCriteria")]
    public class DataProtectionBackupPolicyDiskRetentionRuleCriteria : azurerm.DataProtectionBackupPolicyDisk.IDataProtectionBackupPolicyDiskRetentionRuleCriteria
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_policy_disk#absolute_criteria DataProtectionBackupPolicyDisk#absolute_criteria}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "absoluteCriteria", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AbsoluteCriteria
        {
            get;
            set;
        }
    }
}

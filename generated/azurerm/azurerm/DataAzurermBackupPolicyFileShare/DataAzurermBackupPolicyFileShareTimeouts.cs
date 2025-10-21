using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermBackupPolicyFileShare
{
    [JsiiByValue(fqn: "azurerm.dataAzurermBackupPolicyFileShare.DataAzurermBackupPolicyFileShareTimeouts")]
    public class DataAzurermBackupPolicyFileShareTimeouts : azurerm.DataAzurermBackupPolicyFileShare.IDataAzurermBackupPolicyFileShareTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/backup_policy_file_share#read DataAzurermBackupPolicyFileShare#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}

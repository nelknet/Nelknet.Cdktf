using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermDataProtectionBackupVault
{
    [JsiiByValue(fqn: "azurerm.dataAzurermDataProtectionBackupVault.DataAzurermDataProtectionBackupVaultTimeouts")]
    public class DataAzurermDataProtectionBackupVaultTimeouts : azurerm.DataAzurermDataProtectionBackupVault.IDataAzurermDataProtectionBackupVaultTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/data_protection_backup_vault#read DataAzurermDataProtectionBackupVault#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}

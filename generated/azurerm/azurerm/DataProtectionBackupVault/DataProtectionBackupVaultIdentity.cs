using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataProtectionBackupVault
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.dataProtectionBackupVault.DataProtectionBackupVaultIdentity")]
    public class DataProtectionBackupVaultIdentity : azurerm.DataProtectionBackupVault.IDataProtectionBackupVaultIdentity
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_vault#type DataProtectionBackupVault#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }
    }
}

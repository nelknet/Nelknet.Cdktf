using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataProtectionBackupVault
{
    [JsiiInterface(nativeType: typeof(IDataProtectionBackupVaultIdentity), fullyQualifiedName: "azurerm.dataProtectionBackupVault.DataProtectionBackupVaultIdentity")]
    public interface IDataProtectionBackupVaultIdentity
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_vault#type DataProtectionBackupVault#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDataProtectionBackupVaultIdentity), fullyQualifiedName: "azurerm.dataProtectionBackupVault.DataProtectionBackupVaultIdentity")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataProtectionBackupVault.IDataProtectionBackupVaultIdentity
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_vault#type DataProtectionBackupVault#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}

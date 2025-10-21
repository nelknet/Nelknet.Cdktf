using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermDataProtectionBackupVault
{
    [JsiiInterface(nativeType: typeof(IDataAzurermDataProtectionBackupVaultTimeouts), fullyQualifiedName: "azurerm.dataAzurermDataProtectionBackupVault.DataAzurermDataProtectionBackupVaultTimeouts")]
    public interface IDataAzurermDataProtectionBackupVaultTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/data_protection_backup_vault#read DataAzurermDataProtectionBackupVault#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermDataProtectionBackupVaultTimeouts), fullyQualifiedName: "azurerm.dataAzurermDataProtectionBackupVault.DataAzurermDataProtectionBackupVaultTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermDataProtectionBackupVault.IDataAzurermDataProtectionBackupVaultTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/data_protection_backup_vault#read DataAzurermDataProtectionBackupVault#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

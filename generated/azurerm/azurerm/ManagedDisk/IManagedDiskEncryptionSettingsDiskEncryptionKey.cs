using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ManagedDisk
{
    [JsiiInterface(nativeType: typeof(IManagedDiskEncryptionSettingsDiskEncryptionKey), fullyQualifiedName: "azurerm.managedDisk.ManagedDiskEncryptionSettingsDiskEncryptionKey")]
    public interface IManagedDiskEncryptionSettingsDiskEncryptionKey
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_disk#secret_url ManagedDisk#secret_url}.</summary>
        [JsiiProperty(name: "secretUrl", typeJson: "{\"primitive\":\"string\"}")]
        string SecretUrl
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_disk#source_vault_id ManagedDisk#source_vault_id}.</summary>
        [JsiiProperty(name: "sourceVaultId", typeJson: "{\"primitive\":\"string\"}")]
        string SourceVaultId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IManagedDiskEncryptionSettingsDiskEncryptionKey), fullyQualifiedName: "azurerm.managedDisk.ManagedDiskEncryptionSettingsDiskEncryptionKey")]
        internal sealed class _Proxy : DeputyBase, azurerm.ManagedDisk.IManagedDiskEncryptionSettingsDiskEncryptionKey
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_disk#secret_url ManagedDisk#secret_url}.</summary>
            [JsiiProperty(name: "secretUrl", typeJson: "{\"primitive\":\"string\"}")]
            public string SecretUrl
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_disk#source_vault_id ManagedDisk#source_vault_id}.</summary>
            [JsiiProperty(name: "sourceVaultId", typeJson: "{\"primitive\":\"string\"}")]
            public string SourceVaultId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}

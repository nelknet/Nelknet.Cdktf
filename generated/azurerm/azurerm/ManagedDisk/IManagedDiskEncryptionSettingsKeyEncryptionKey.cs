using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ManagedDisk
{
    [JsiiInterface(nativeType: typeof(IManagedDiskEncryptionSettingsKeyEncryptionKey), fullyQualifiedName: "azurerm.managedDisk.ManagedDiskEncryptionSettingsKeyEncryptionKey")]
    public interface IManagedDiskEncryptionSettingsKeyEncryptionKey
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_disk#key_url ManagedDisk#key_url}.</summary>
        [JsiiProperty(name: "keyUrl", typeJson: "{\"primitive\":\"string\"}")]
        string KeyUrl
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_disk#source_vault_id ManagedDisk#source_vault_id}.</summary>
        [JsiiProperty(name: "sourceVaultId", typeJson: "{\"primitive\":\"string\"}")]
        string SourceVaultId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IManagedDiskEncryptionSettingsKeyEncryptionKey), fullyQualifiedName: "azurerm.managedDisk.ManagedDiskEncryptionSettingsKeyEncryptionKey")]
        internal sealed class _Proxy : DeputyBase, azurerm.ManagedDisk.IManagedDiskEncryptionSettingsKeyEncryptionKey
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_disk#key_url ManagedDisk#key_url}.</summary>
            [JsiiProperty(name: "keyUrl", typeJson: "{\"primitive\":\"string\"}")]
            public string KeyUrl
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

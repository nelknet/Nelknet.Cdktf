using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ManagedDisk
{
    [JsiiInterface(nativeType: typeof(IManagedDiskEncryptionSettings), fullyQualifiedName: "azurerm.managedDisk.ManagedDiskEncryptionSettings")]
    public interface IManagedDiskEncryptionSettings
    {
        /// <summary>disk_encryption_key block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_disk#disk_encryption_key ManagedDisk#disk_encryption_key}
        /// </remarks>
        [JsiiProperty(name: "diskEncryptionKey", typeJson: "{\"fqn\":\"azurerm.managedDisk.ManagedDiskEncryptionSettingsDiskEncryptionKey\"}")]
        azurerm.ManagedDisk.IManagedDiskEncryptionSettingsDiskEncryptionKey DiskEncryptionKey
        {
            get;
        }

        /// <summary>key_encryption_key block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_disk#key_encryption_key ManagedDisk#key_encryption_key}
        /// </remarks>
        [JsiiProperty(name: "keyEncryptionKey", typeJson: "{\"fqn\":\"azurerm.managedDisk.ManagedDiskEncryptionSettingsKeyEncryptionKey\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.ManagedDisk.IManagedDiskEncryptionSettingsKeyEncryptionKey? KeyEncryptionKey
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IManagedDiskEncryptionSettings), fullyQualifiedName: "azurerm.managedDisk.ManagedDiskEncryptionSettings")]
        internal sealed class _Proxy : DeputyBase, azurerm.ManagedDisk.IManagedDiskEncryptionSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>disk_encryption_key block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_disk#disk_encryption_key ManagedDisk#disk_encryption_key}
            /// </remarks>
            [JsiiProperty(name: "diskEncryptionKey", typeJson: "{\"fqn\":\"azurerm.managedDisk.ManagedDiskEncryptionSettingsDiskEncryptionKey\"}")]
            public azurerm.ManagedDisk.IManagedDiskEncryptionSettingsDiskEncryptionKey DiskEncryptionKey
            {
                get => GetInstanceProperty<azurerm.ManagedDisk.IManagedDiskEncryptionSettingsDiskEncryptionKey>()!;
            }

            /// <summary>key_encryption_key block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_disk#key_encryption_key ManagedDisk#key_encryption_key}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "keyEncryptionKey", typeJson: "{\"fqn\":\"azurerm.managedDisk.ManagedDiskEncryptionSettingsKeyEncryptionKey\"}", isOptional: true)]
            public azurerm.ManagedDisk.IManagedDiskEncryptionSettingsKeyEncryptionKey? KeyEncryptionKey
            {
                get => GetInstanceProperty<azurerm.ManagedDisk.IManagedDiskEncryptionSettingsKeyEncryptionKey?>();
            }
        }
    }
}

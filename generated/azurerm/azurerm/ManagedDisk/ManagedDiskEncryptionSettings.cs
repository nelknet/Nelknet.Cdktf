using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ManagedDisk
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.managedDisk.ManagedDiskEncryptionSettings")]
    public class ManagedDiskEncryptionSettings : azurerm.ManagedDisk.IManagedDiskEncryptionSettings
    {
        /// <summary>disk_encryption_key block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_disk#disk_encryption_key ManagedDisk#disk_encryption_key}
        /// </remarks>
        [JsiiProperty(name: "diskEncryptionKey", typeJson: "{\"fqn\":\"azurerm.managedDisk.ManagedDiskEncryptionSettingsDiskEncryptionKey\"}")]
        public azurerm.ManagedDisk.IManagedDiskEncryptionSettingsDiskEncryptionKey DiskEncryptionKey
        {
            get;
            set;
        }

        /// <summary>key_encryption_key block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_disk#key_encryption_key ManagedDisk#key_encryption_key}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "keyEncryptionKey", typeJson: "{\"fqn\":\"azurerm.managedDisk.ManagedDiskEncryptionSettingsKeyEncryptionKey\"}", isOptional: true)]
        public azurerm.ManagedDisk.IManagedDiskEncryptionSettingsKeyEncryptionKey? KeyEncryptionKey
        {
            get;
            set;
        }
    }
}

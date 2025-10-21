using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.Snapshot
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.snapshot.SnapshotEncryptionSettings")]
    public class SnapshotEncryptionSettings : azurerm.Snapshot.ISnapshotEncryptionSettings
    {
        /// <summary>disk_encryption_key block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/snapshot#disk_encryption_key Snapshot#disk_encryption_key}
        /// </remarks>
        [JsiiProperty(name: "diskEncryptionKey", typeJson: "{\"fqn\":\"azurerm.snapshot.SnapshotEncryptionSettingsDiskEncryptionKey\"}")]
        public azurerm.Snapshot.ISnapshotEncryptionSettingsDiskEncryptionKey DiskEncryptionKey
        {
            get;
            set;
        }

        /// <summary>key_encryption_key block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/snapshot#key_encryption_key Snapshot#key_encryption_key}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "keyEncryptionKey", typeJson: "{\"fqn\":\"azurerm.snapshot.SnapshotEncryptionSettingsKeyEncryptionKey\"}", isOptional: true)]
        public azurerm.Snapshot.ISnapshotEncryptionSettingsKeyEncryptionKey? KeyEncryptionKey
        {
            get;
            set;
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.Snapshot
{
    [JsiiInterface(nativeType: typeof(ISnapshotEncryptionSettings), fullyQualifiedName: "azurerm.snapshot.SnapshotEncryptionSettings")]
    public interface ISnapshotEncryptionSettings
    {
        /// <summary>disk_encryption_key block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/snapshot#disk_encryption_key Snapshot#disk_encryption_key}
        /// </remarks>
        [JsiiProperty(name: "diskEncryptionKey", typeJson: "{\"fqn\":\"azurerm.snapshot.SnapshotEncryptionSettingsDiskEncryptionKey\"}")]
        azurerm.Snapshot.ISnapshotEncryptionSettingsDiskEncryptionKey DiskEncryptionKey
        {
            get;
        }

        /// <summary>key_encryption_key block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/snapshot#key_encryption_key Snapshot#key_encryption_key}
        /// </remarks>
        [JsiiProperty(name: "keyEncryptionKey", typeJson: "{\"fqn\":\"azurerm.snapshot.SnapshotEncryptionSettingsKeyEncryptionKey\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.Snapshot.ISnapshotEncryptionSettingsKeyEncryptionKey? KeyEncryptionKey
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISnapshotEncryptionSettings), fullyQualifiedName: "azurerm.snapshot.SnapshotEncryptionSettings")]
        internal sealed class _Proxy : DeputyBase, azurerm.Snapshot.ISnapshotEncryptionSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>disk_encryption_key block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/snapshot#disk_encryption_key Snapshot#disk_encryption_key}
            /// </remarks>
            [JsiiProperty(name: "diskEncryptionKey", typeJson: "{\"fqn\":\"azurerm.snapshot.SnapshotEncryptionSettingsDiskEncryptionKey\"}")]
            public azurerm.Snapshot.ISnapshotEncryptionSettingsDiskEncryptionKey DiskEncryptionKey
            {
                get => GetInstanceProperty<azurerm.Snapshot.ISnapshotEncryptionSettingsDiskEncryptionKey>()!;
            }

            /// <summary>key_encryption_key block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/snapshot#key_encryption_key Snapshot#key_encryption_key}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "keyEncryptionKey", typeJson: "{\"fqn\":\"azurerm.snapshot.SnapshotEncryptionSettingsKeyEncryptionKey\"}", isOptional: true)]
            public azurerm.Snapshot.ISnapshotEncryptionSettingsKeyEncryptionKey? KeyEncryptionKey
            {
                get => GetInstanceProperty<azurerm.Snapshot.ISnapshotEncryptionSettingsKeyEncryptionKey?>();
            }
        }
    }
}

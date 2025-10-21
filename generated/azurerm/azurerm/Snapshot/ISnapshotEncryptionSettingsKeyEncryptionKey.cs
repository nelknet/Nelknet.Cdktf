using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.Snapshot
{
    [JsiiInterface(nativeType: typeof(ISnapshotEncryptionSettingsKeyEncryptionKey), fullyQualifiedName: "azurerm.snapshot.SnapshotEncryptionSettingsKeyEncryptionKey")]
    public interface ISnapshotEncryptionSettingsKeyEncryptionKey
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/snapshot#key_url Snapshot#key_url}.</summary>
        [JsiiProperty(name: "keyUrl", typeJson: "{\"primitive\":\"string\"}")]
        string KeyUrl
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/snapshot#source_vault_id Snapshot#source_vault_id}.</summary>
        [JsiiProperty(name: "sourceVaultId", typeJson: "{\"primitive\":\"string\"}")]
        string SourceVaultId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISnapshotEncryptionSettingsKeyEncryptionKey), fullyQualifiedName: "azurerm.snapshot.SnapshotEncryptionSettingsKeyEncryptionKey")]
        internal sealed class _Proxy : DeputyBase, azurerm.Snapshot.ISnapshotEncryptionSettingsKeyEncryptionKey
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/snapshot#key_url Snapshot#key_url}.</summary>
            [JsiiProperty(name: "keyUrl", typeJson: "{\"primitive\":\"string\"}")]
            public string KeyUrl
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/snapshot#source_vault_id Snapshot#source_vault_id}.</summary>
            [JsiiProperty(name: "sourceVaultId", typeJson: "{\"primitive\":\"string\"}")]
            public string SourceVaultId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}

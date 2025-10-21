using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.Snapshot
{
    [JsiiInterface(nativeType: typeof(ISnapshotEncryptionSettingsDiskEncryptionKey), fullyQualifiedName: "azurerm.snapshot.SnapshotEncryptionSettingsDiskEncryptionKey")]
    public interface ISnapshotEncryptionSettingsDiskEncryptionKey
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/snapshot#secret_url Snapshot#secret_url}.</summary>
        [JsiiProperty(name: "secretUrl", typeJson: "{\"primitive\":\"string\"}")]
        string SecretUrl
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/snapshot#source_vault_id Snapshot#source_vault_id}.</summary>
        [JsiiProperty(name: "sourceVaultId", typeJson: "{\"primitive\":\"string\"}")]
        string SourceVaultId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISnapshotEncryptionSettingsDiskEncryptionKey), fullyQualifiedName: "azurerm.snapshot.SnapshotEncryptionSettingsDiskEncryptionKey")]
        internal sealed class _Proxy : DeputyBase, azurerm.Snapshot.ISnapshotEncryptionSettingsDiskEncryptionKey
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/snapshot#secret_url Snapshot#secret_url}.</summary>
            [JsiiProperty(name: "secretUrl", typeJson: "{\"primitive\":\"string\"}")]
            public string SecretUrl
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

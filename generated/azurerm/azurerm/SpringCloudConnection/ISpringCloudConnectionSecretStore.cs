using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SpringCloudConnection
{
    [JsiiInterface(nativeType: typeof(ISpringCloudConnectionSecretStore), fullyQualifiedName: "azurerm.springCloudConnection.SpringCloudConnectionSecretStore")]
    public interface ISpringCloudConnectionSecretStore
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_connection#key_vault_id SpringCloudConnection#key_vault_id}.</summary>
        [JsiiProperty(name: "keyVaultId", typeJson: "{\"primitive\":\"string\"}")]
        string KeyVaultId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISpringCloudConnectionSecretStore), fullyQualifiedName: "azurerm.springCloudConnection.SpringCloudConnectionSecretStore")]
        internal sealed class _Proxy : DeputyBase, azurerm.SpringCloudConnection.ISpringCloudConnectionSecretStore
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_connection#key_vault_id SpringCloudConnection#key_vault_id}.</summary>
            [JsiiProperty(name: "keyVaultId", typeJson: "{\"primitive\":\"string\"}")]
            public string KeyVaultId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}

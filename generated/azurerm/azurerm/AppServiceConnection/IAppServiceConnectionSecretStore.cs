using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AppServiceConnection
{
    [JsiiInterface(nativeType: typeof(IAppServiceConnectionSecretStore), fullyQualifiedName: "azurerm.appServiceConnection.AppServiceConnectionSecretStore")]
    public interface IAppServiceConnectionSecretStore
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_connection#key_vault_id AppServiceConnection#key_vault_id}.</summary>
        [JsiiProperty(name: "keyVaultId", typeJson: "{\"primitive\":\"string\"}")]
        string KeyVaultId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppServiceConnectionSecretStore), fullyQualifiedName: "azurerm.appServiceConnection.AppServiceConnectionSecretStore")]
        internal sealed class _Proxy : DeputyBase, azurerm.AppServiceConnection.IAppServiceConnectionSecretStore
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_connection#key_vault_id AppServiceConnection#key_vault_id}.</summary>
            [JsiiProperty(name: "keyVaultId", typeJson: "{\"primitive\":\"string\"}")]
            public string KeyVaultId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}

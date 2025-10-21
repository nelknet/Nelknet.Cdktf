using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.FunctionAppConnection
{
    [JsiiInterface(nativeType: typeof(IFunctionAppConnectionSecretStore), fullyQualifiedName: "azurerm.functionAppConnection.FunctionAppConnectionSecretStore")]
    public interface IFunctionAppConnectionSecretStore
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_connection#key_vault_id FunctionAppConnection#key_vault_id}.</summary>
        [JsiiProperty(name: "keyVaultId", typeJson: "{\"primitive\":\"string\"}")]
        string KeyVaultId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IFunctionAppConnectionSecretStore), fullyQualifiedName: "azurerm.functionAppConnection.FunctionAppConnectionSecretStore")]
        internal sealed class _Proxy : DeputyBase, azurerm.FunctionAppConnection.IFunctionAppConnectionSecretStore
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_connection#key_vault_id FunctionAppConnection#key_vault_id}.</summary>
            [JsiiProperty(name: "keyVaultId", typeJson: "{\"primitive\":\"string\"}")]
            public string KeyVaultId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}

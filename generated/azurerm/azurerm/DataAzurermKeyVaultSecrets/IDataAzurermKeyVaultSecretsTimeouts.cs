using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermKeyVaultSecrets
{
    [JsiiInterface(nativeType: typeof(IDataAzurermKeyVaultSecretsTimeouts), fullyQualifiedName: "azurerm.dataAzurermKeyVaultSecrets.DataAzurermKeyVaultSecretsTimeouts")]
    public interface IDataAzurermKeyVaultSecretsTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/key_vault_secrets#read DataAzurermKeyVaultSecrets#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermKeyVaultSecretsTimeouts), fullyQualifiedName: "azurerm.dataAzurermKeyVaultSecrets.DataAzurermKeyVaultSecretsTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermKeyVaultSecrets.IDataAzurermKeyVaultSecretsTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/key_vault_secrets#read DataAzurermKeyVaultSecrets#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

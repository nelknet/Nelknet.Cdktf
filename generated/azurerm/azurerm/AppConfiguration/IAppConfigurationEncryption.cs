using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AppConfiguration
{
    [JsiiInterface(nativeType: typeof(IAppConfigurationEncryption), fullyQualifiedName: "azurerm.appConfiguration.AppConfigurationEncryption")]
    public interface IAppConfigurationEncryption
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_configuration#identity_client_id AppConfiguration#identity_client_id}.</summary>
        [JsiiProperty(name: "identityClientId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IdentityClientId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_configuration#key_vault_key_identifier AppConfiguration#key_vault_key_identifier}.</summary>
        [JsiiProperty(name: "keyVaultKeyIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KeyVaultKeyIdentifier
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppConfigurationEncryption), fullyQualifiedName: "azurerm.appConfiguration.AppConfigurationEncryption")]
        internal sealed class _Proxy : DeputyBase, azurerm.AppConfiguration.IAppConfigurationEncryption
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_configuration#identity_client_id AppConfiguration#identity_client_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "identityClientId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IdentityClientId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_configuration#key_vault_key_identifier AppConfiguration#key_vault_key_identifier}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "keyVaultKeyIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KeyVaultKeyIdentifier
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

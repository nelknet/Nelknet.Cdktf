using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AppConfiguration
{
    [JsiiByValue(fqn: "azurerm.appConfiguration.AppConfigurationEncryption")]
    public class AppConfigurationEncryption : azurerm.AppConfiguration.IAppConfigurationEncryption
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_configuration#identity_client_id AppConfiguration#identity_client_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "identityClientId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IdentityClientId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_configuration#key_vault_key_identifier AppConfiguration#key_vault_key_identifier}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "keyVaultKeyIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KeyVaultKeyIdentifier
        {
            get;
            set;
        }
    }
}

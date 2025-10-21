using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.FrontdoorCustomHttpsConfiguration
{
    [JsiiByValue(fqn: "azurerm.frontdoorCustomHttpsConfiguration.FrontdoorCustomHttpsConfigurationCustomHttpsConfiguration")]
    public class FrontdoorCustomHttpsConfigurationCustomHttpsConfiguration : azurerm.FrontdoorCustomHttpsConfiguration.IFrontdoorCustomHttpsConfigurationCustomHttpsConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor_custom_https_configuration#azure_key_vault_certificate_secret_name FrontdoorCustomHttpsConfiguration#azure_key_vault_certificate_secret_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "azureKeyVaultCertificateSecretName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AzureKeyVaultCertificateSecretName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor_custom_https_configuration#azure_key_vault_certificate_secret_version FrontdoorCustomHttpsConfiguration#azure_key_vault_certificate_secret_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "azureKeyVaultCertificateSecretVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AzureKeyVaultCertificateSecretVersion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor_custom_https_configuration#azure_key_vault_certificate_vault_id FrontdoorCustomHttpsConfiguration#azure_key_vault_certificate_vault_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "azureKeyVaultCertificateVaultId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AzureKeyVaultCertificateVaultId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor_custom_https_configuration#certificate_source FrontdoorCustomHttpsConfiguration#certificate_source}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "certificateSource", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CertificateSource
        {
            get;
            set;
        }
    }
}

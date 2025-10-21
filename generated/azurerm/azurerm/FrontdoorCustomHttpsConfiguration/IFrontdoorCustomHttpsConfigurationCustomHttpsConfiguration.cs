using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.FrontdoorCustomHttpsConfiguration
{
    [JsiiInterface(nativeType: typeof(IFrontdoorCustomHttpsConfigurationCustomHttpsConfiguration), fullyQualifiedName: "azurerm.frontdoorCustomHttpsConfiguration.FrontdoorCustomHttpsConfigurationCustomHttpsConfiguration")]
    public interface IFrontdoorCustomHttpsConfigurationCustomHttpsConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor_custom_https_configuration#azure_key_vault_certificate_secret_name FrontdoorCustomHttpsConfiguration#azure_key_vault_certificate_secret_name}.</summary>
        [JsiiProperty(name: "azureKeyVaultCertificateSecretName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AzureKeyVaultCertificateSecretName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor_custom_https_configuration#azure_key_vault_certificate_secret_version FrontdoorCustomHttpsConfiguration#azure_key_vault_certificate_secret_version}.</summary>
        [JsiiProperty(name: "azureKeyVaultCertificateSecretVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AzureKeyVaultCertificateSecretVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor_custom_https_configuration#azure_key_vault_certificate_vault_id FrontdoorCustomHttpsConfiguration#azure_key_vault_certificate_vault_id}.</summary>
        [JsiiProperty(name: "azureKeyVaultCertificateVaultId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AzureKeyVaultCertificateVaultId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor_custom_https_configuration#certificate_source FrontdoorCustomHttpsConfiguration#certificate_source}.</summary>
        [JsiiProperty(name: "certificateSource", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CertificateSource
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFrontdoorCustomHttpsConfigurationCustomHttpsConfiguration), fullyQualifiedName: "azurerm.frontdoorCustomHttpsConfiguration.FrontdoorCustomHttpsConfigurationCustomHttpsConfiguration")]
        internal sealed class _Proxy : DeputyBase, azurerm.FrontdoorCustomHttpsConfiguration.IFrontdoorCustomHttpsConfigurationCustomHttpsConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor_custom_https_configuration#azure_key_vault_certificate_secret_name FrontdoorCustomHttpsConfiguration#azure_key_vault_certificate_secret_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "azureKeyVaultCertificateSecretName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AzureKeyVaultCertificateSecretName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor_custom_https_configuration#azure_key_vault_certificate_secret_version FrontdoorCustomHttpsConfiguration#azure_key_vault_certificate_secret_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "azureKeyVaultCertificateSecretVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AzureKeyVaultCertificateSecretVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor_custom_https_configuration#azure_key_vault_certificate_vault_id FrontdoorCustomHttpsConfiguration#azure_key_vault_certificate_vault_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "azureKeyVaultCertificateVaultId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AzureKeyVaultCertificateVaultId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor_custom_https_configuration#certificate_source FrontdoorCustomHttpsConfiguration#certificate_source}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "certificateSource", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CertificateSource
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

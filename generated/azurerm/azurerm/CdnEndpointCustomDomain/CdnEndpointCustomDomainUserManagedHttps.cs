using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CdnEndpointCustomDomain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.cdnEndpointCustomDomain.CdnEndpointCustomDomainUserManagedHttps")]
    public class CdnEndpointCustomDomainUserManagedHttps : azurerm.CdnEndpointCustomDomain.ICdnEndpointCustomDomainUserManagedHttps
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint_custom_domain#key_vault_secret_id CdnEndpointCustomDomain#key_vault_secret_id}.</summary>
        [JsiiProperty(name: "keyVaultSecretId", typeJson: "{\"primitive\":\"string\"}")]
        public string KeyVaultSecretId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint_custom_domain#tls_version CdnEndpointCustomDomain#tls_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tlsVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TlsVersion
        {
            get;
            set;
        }
    }
}

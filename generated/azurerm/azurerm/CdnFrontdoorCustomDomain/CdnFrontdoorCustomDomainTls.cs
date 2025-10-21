using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CdnFrontdoorCustomDomain
{
    [JsiiByValue(fqn: "azurerm.cdnFrontdoorCustomDomain.CdnFrontdoorCustomDomainTls")]
    public class CdnFrontdoorCustomDomainTls : azurerm.CdnFrontdoorCustomDomain.ICdnFrontdoorCustomDomainTls
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_custom_domain#cdn_frontdoor_secret_id CdnFrontdoorCustomDomain#cdn_frontdoor_secret_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cdnFrontdoorSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CdnFrontdoorSecretId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_custom_domain#certificate_type CdnFrontdoorCustomDomain#certificate_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "certificateType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CertificateType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_custom_domain#minimum_tls_version CdnFrontdoorCustomDomain#minimum_tls_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "minimumTlsVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MinimumTlsVersion
        {
            get;
            set;
        }
    }
}

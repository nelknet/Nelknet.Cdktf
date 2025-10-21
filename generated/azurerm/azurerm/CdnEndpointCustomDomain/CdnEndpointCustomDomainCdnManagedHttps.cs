using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CdnEndpointCustomDomain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.cdnEndpointCustomDomain.CdnEndpointCustomDomainCdnManagedHttps")]
    public class CdnEndpointCustomDomainCdnManagedHttps : azurerm.CdnEndpointCustomDomain.ICdnEndpointCustomDomainCdnManagedHttps
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint_custom_domain#certificate_type CdnEndpointCustomDomain#certificate_type}.</summary>
        [JsiiProperty(name: "certificateType", typeJson: "{\"primitive\":\"string\"}")]
        public string CertificateType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint_custom_domain#protocol_type CdnEndpointCustomDomain#protocol_type}.</summary>
        [JsiiProperty(name: "protocolType", typeJson: "{\"primitive\":\"string\"}")]
        public string ProtocolType
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

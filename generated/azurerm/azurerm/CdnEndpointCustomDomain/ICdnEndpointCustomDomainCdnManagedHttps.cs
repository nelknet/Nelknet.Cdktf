using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CdnEndpointCustomDomain
{
    [JsiiInterface(nativeType: typeof(ICdnEndpointCustomDomainCdnManagedHttps), fullyQualifiedName: "azurerm.cdnEndpointCustomDomain.CdnEndpointCustomDomainCdnManagedHttps")]
    public interface ICdnEndpointCustomDomainCdnManagedHttps
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint_custom_domain#certificate_type CdnEndpointCustomDomain#certificate_type}.</summary>
        [JsiiProperty(name: "certificateType", typeJson: "{\"primitive\":\"string\"}")]
        string CertificateType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint_custom_domain#protocol_type CdnEndpointCustomDomain#protocol_type}.</summary>
        [JsiiProperty(name: "protocolType", typeJson: "{\"primitive\":\"string\"}")]
        string ProtocolType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint_custom_domain#tls_version CdnEndpointCustomDomain#tls_version}.</summary>
        [JsiiProperty(name: "tlsVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TlsVersion
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICdnEndpointCustomDomainCdnManagedHttps), fullyQualifiedName: "azurerm.cdnEndpointCustomDomain.CdnEndpointCustomDomainCdnManagedHttps")]
        internal sealed class _Proxy : DeputyBase, azurerm.CdnEndpointCustomDomain.ICdnEndpointCustomDomainCdnManagedHttps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint_custom_domain#certificate_type CdnEndpointCustomDomain#certificate_type}.</summary>
            [JsiiProperty(name: "certificateType", typeJson: "{\"primitive\":\"string\"}")]
            public string CertificateType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint_custom_domain#protocol_type CdnEndpointCustomDomain#protocol_type}.</summary>
            [JsiiProperty(name: "protocolType", typeJson: "{\"primitive\":\"string\"}")]
            public string ProtocolType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint_custom_domain#tls_version CdnEndpointCustomDomain#tls_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tlsVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TlsVersion
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

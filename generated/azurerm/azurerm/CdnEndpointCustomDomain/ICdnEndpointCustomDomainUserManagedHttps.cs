using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CdnEndpointCustomDomain
{
    [JsiiInterface(nativeType: typeof(ICdnEndpointCustomDomainUserManagedHttps), fullyQualifiedName: "azurerm.cdnEndpointCustomDomain.CdnEndpointCustomDomainUserManagedHttps")]
    public interface ICdnEndpointCustomDomainUserManagedHttps
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint_custom_domain#key_vault_secret_id CdnEndpointCustomDomain#key_vault_secret_id}.</summary>
        [JsiiProperty(name: "keyVaultSecretId", typeJson: "{\"primitive\":\"string\"}")]
        string KeyVaultSecretId
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

        [JsiiTypeProxy(nativeType: typeof(ICdnEndpointCustomDomainUserManagedHttps), fullyQualifiedName: "azurerm.cdnEndpointCustomDomain.CdnEndpointCustomDomainUserManagedHttps")]
        internal sealed class _Proxy : DeputyBase, azurerm.CdnEndpointCustomDomain.ICdnEndpointCustomDomainUserManagedHttps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint_custom_domain#key_vault_secret_id CdnEndpointCustomDomain#key_vault_secret_id}.</summary>
            [JsiiProperty(name: "keyVaultSecretId", typeJson: "{\"primitive\":\"string\"}")]
            public string KeyVaultSecretId
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

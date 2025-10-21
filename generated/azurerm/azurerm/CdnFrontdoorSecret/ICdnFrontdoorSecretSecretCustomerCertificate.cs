using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CdnFrontdoorSecret
{
    [JsiiInterface(nativeType: typeof(ICdnFrontdoorSecretSecretCustomerCertificate), fullyQualifiedName: "azurerm.cdnFrontdoorSecret.CdnFrontdoorSecretSecretCustomerCertificate")]
    public interface ICdnFrontdoorSecretSecretCustomerCertificate
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_secret#key_vault_certificate_id CdnFrontdoorSecret#key_vault_certificate_id}.</summary>
        [JsiiProperty(name: "keyVaultCertificateId", typeJson: "{\"primitive\":\"string\"}")]
        string KeyVaultCertificateId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICdnFrontdoorSecretSecretCustomerCertificate), fullyQualifiedName: "azurerm.cdnFrontdoorSecret.CdnFrontdoorSecretSecretCustomerCertificate")]
        internal sealed class _Proxy : DeputyBase, azurerm.CdnFrontdoorSecret.ICdnFrontdoorSecretSecretCustomerCertificate
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_secret#key_vault_certificate_id CdnFrontdoorSecret#key_vault_certificate_id}.</summary>
            [JsiiProperty(name: "keyVaultCertificateId", typeJson: "{\"primitive\":\"string\"}")]
            public string KeyVaultCertificateId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}

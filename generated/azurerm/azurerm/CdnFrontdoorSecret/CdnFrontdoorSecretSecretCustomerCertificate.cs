using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CdnFrontdoorSecret
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.cdnFrontdoorSecret.CdnFrontdoorSecretSecretCustomerCertificate")]
    public class CdnFrontdoorSecretSecretCustomerCertificate : azurerm.CdnFrontdoorSecret.ICdnFrontdoorSecretSecretCustomerCertificate
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_secret#key_vault_certificate_id CdnFrontdoorSecret#key_vault_certificate_id}.</summary>
        [JsiiProperty(name: "keyVaultCertificateId", typeJson: "{\"primitive\":\"string\"}")]
        public string KeyVaultCertificateId
        {
            get;
            set;
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KeyVaultCertificate
{
    [JsiiByValue(fqn: "azurerm.keyVaultCertificate.KeyVaultCertificateCertificatePolicyX509CertificatePropertiesSubjectAlternativeNames")]
    public class KeyVaultCertificateCertificatePolicyX509CertificatePropertiesSubjectAlternativeNames : azurerm.KeyVaultCertificate.IKeyVaultCertificateCertificatePolicyX509CertificatePropertiesSubjectAlternativeNames
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_certificate#dns_names KeyVaultCertificate#dns_names}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dnsNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? DnsNames
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_certificate#emails KeyVaultCertificate#emails}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "emails", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Emails
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_certificate#upns KeyVaultCertificate#upns}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "upns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Upns
        {
            get;
            set;
        }
    }
}

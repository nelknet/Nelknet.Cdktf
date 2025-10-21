using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KeyVaultCertificate
{
    [JsiiInterface(nativeType: typeof(IKeyVaultCertificateCertificatePolicyX509CertificatePropertiesSubjectAlternativeNames), fullyQualifiedName: "azurerm.keyVaultCertificate.KeyVaultCertificateCertificatePolicyX509CertificatePropertiesSubjectAlternativeNames")]
    public interface IKeyVaultCertificateCertificatePolicyX509CertificatePropertiesSubjectAlternativeNames
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_certificate#dns_names KeyVaultCertificate#dns_names}.</summary>
        [JsiiProperty(name: "dnsNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? DnsNames
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_certificate#emails KeyVaultCertificate#emails}.</summary>
        [JsiiProperty(name: "emails", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Emails
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_certificate#upns KeyVaultCertificate#upns}.</summary>
        [JsiiProperty(name: "upns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Upns
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKeyVaultCertificateCertificatePolicyX509CertificatePropertiesSubjectAlternativeNames), fullyQualifiedName: "azurerm.keyVaultCertificate.KeyVaultCertificateCertificatePolicyX509CertificatePropertiesSubjectAlternativeNames")]
        internal sealed class _Proxy : DeputyBase, azurerm.KeyVaultCertificate.IKeyVaultCertificateCertificatePolicyX509CertificatePropertiesSubjectAlternativeNames
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_certificate#dns_names KeyVaultCertificate#dns_names}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dnsNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? DnsNames
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_certificate#emails KeyVaultCertificate#emails}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "emails", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Emails
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_certificate#upns KeyVaultCertificate#upns}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "upns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Upns
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}

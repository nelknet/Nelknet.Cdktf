using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KeyVaultCertificate
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.keyVaultCertificate.KeyVaultCertificateCertificate")]
    public class KeyVaultCertificateCertificate : azurerm.KeyVaultCertificate.IKeyVaultCertificateCertificate
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_certificate#contents KeyVaultCertificate#contents}.</summary>
        [JsiiProperty(name: "contents", typeJson: "{\"primitive\":\"string\"}")]
        public string Contents
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_certificate#password KeyVaultCertificate#password}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Password
        {
            get;
            set;
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KeyVaultCertificate
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.keyVaultCertificate.KeyVaultCertificateCertificatePolicyLifetimeAction")]
    public class KeyVaultCertificateCertificatePolicyLifetimeAction : azurerm.KeyVaultCertificate.IKeyVaultCertificateCertificatePolicyLifetimeAction
    {
        /// <summary>action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_certificate#action KeyVaultCertificate#action}
        /// </remarks>
        [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"azurerm.keyVaultCertificate.KeyVaultCertificateCertificatePolicyLifetimeActionAction\"}")]
        public azurerm.KeyVaultCertificate.IKeyVaultCertificateCertificatePolicyLifetimeActionAction Action
        {
            get;
            set;
        }

        /// <summary>trigger block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_certificate#trigger KeyVaultCertificate#trigger}
        /// </remarks>
        [JsiiProperty(name: "trigger", typeJson: "{\"fqn\":\"azurerm.keyVaultCertificate.KeyVaultCertificateCertificatePolicyLifetimeActionTrigger\"}")]
        public azurerm.KeyVaultCertificate.IKeyVaultCertificateCertificatePolicyLifetimeActionTrigger Trigger
        {
            get;
            set;
        }
    }
}

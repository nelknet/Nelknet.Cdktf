using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KeyVaultCertificate
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.keyVaultCertificate.KeyVaultCertificateCertificatePolicyLifetimeActionAction")]
    public class KeyVaultCertificateCertificatePolicyLifetimeActionAction : azurerm.KeyVaultCertificate.IKeyVaultCertificateCertificatePolicyLifetimeActionAction
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_certificate#action_type KeyVaultCertificate#action_type}.</summary>
        [JsiiProperty(name: "actionType", typeJson: "{\"primitive\":\"string\"}")]
        public string ActionType
        {
            get;
            set;
        }
    }
}

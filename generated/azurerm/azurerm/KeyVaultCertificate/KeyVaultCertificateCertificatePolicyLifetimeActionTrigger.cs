using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KeyVaultCertificate
{
    [JsiiByValue(fqn: "azurerm.keyVaultCertificate.KeyVaultCertificateCertificatePolicyLifetimeActionTrigger")]
    public class KeyVaultCertificateCertificatePolicyLifetimeActionTrigger : azurerm.KeyVaultCertificate.IKeyVaultCertificateCertificatePolicyLifetimeActionTrigger
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_certificate#days_before_expiry KeyVaultCertificate#days_before_expiry}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "daysBeforeExpiry", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DaysBeforeExpiry
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_certificate#lifetime_percentage KeyVaultCertificate#lifetime_percentage}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "lifetimePercentage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? LifetimePercentage
        {
            get;
            set;
        }
    }
}

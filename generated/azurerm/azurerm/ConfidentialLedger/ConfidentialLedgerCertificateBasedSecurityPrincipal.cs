using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ConfidentialLedger
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.confidentialLedger.ConfidentialLedgerCertificateBasedSecurityPrincipal")]
    public class ConfidentialLedgerCertificateBasedSecurityPrincipal : azurerm.ConfidentialLedger.IConfidentialLedgerCertificateBasedSecurityPrincipal
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/confidential_ledger#ledger_role_name ConfidentialLedger#ledger_role_name}.</summary>
        [JsiiProperty(name: "ledgerRoleName", typeJson: "{\"primitive\":\"string\"}")]
        public string LedgerRoleName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/confidential_ledger#pem_public_key ConfidentialLedger#pem_public_key}.</summary>
        [JsiiProperty(name: "pemPublicKey", typeJson: "{\"primitive\":\"string\"}")]
        public string PemPublicKey
        {
            get;
            set;
        }
    }
}

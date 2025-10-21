using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ConfidentialLedger
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.confidentialLedger.ConfidentialLedgerAzureadBasedServicePrincipal")]
    public class ConfidentialLedgerAzureadBasedServicePrincipal : azurerm.ConfidentialLedger.IConfidentialLedgerAzureadBasedServicePrincipal
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/confidential_ledger#ledger_role_name ConfidentialLedger#ledger_role_name}.</summary>
        [JsiiProperty(name: "ledgerRoleName", typeJson: "{\"primitive\":\"string\"}")]
        public string LedgerRoleName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/confidential_ledger#principal_id ConfidentialLedger#principal_id}.</summary>
        [JsiiProperty(name: "principalId", typeJson: "{\"primitive\":\"string\"}")]
        public string PrincipalId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/confidential_ledger#tenant_id ConfidentialLedger#tenant_id}.</summary>
        [JsiiProperty(name: "tenantId", typeJson: "{\"primitive\":\"string\"}")]
        public string TenantId
        {
            get;
            set;
        }
    }
}

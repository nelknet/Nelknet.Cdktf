using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ConfidentialLedger
{
    [JsiiInterface(nativeType: typeof(IConfidentialLedgerAzureadBasedServicePrincipal), fullyQualifiedName: "azurerm.confidentialLedger.ConfidentialLedgerAzureadBasedServicePrincipal")]
    public interface IConfidentialLedgerAzureadBasedServicePrincipal
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/confidential_ledger#ledger_role_name ConfidentialLedger#ledger_role_name}.</summary>
        [JsiiProperty(name: "ledgerRoleName", typeJson: "{\"primitive\":\"string\"}")]
        string LedgerRoleName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/confidential_ledger#principal_id ConfidentialLedger#principal_id}.</summary>
        [JsiiProperty(name: "principalId", typeJson: "{\"primitive\":\"string\"}")]
        string PrincipalId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/confidential_ledger#tenant_id ConfidentialLedger#tenant_id}.</summary>
        [JsiiProperty(name: "tenantId", typeJson: "{\"primitive\":\"string\"}")]
        string TenantId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IConfidentialLedgerAzureadBasedServicePrincipal), fullyQualifiedName: "azurerm.confidentialLedger.ConfidentialLedgerAzureadBasedServicePrincipal")]
        internal sealed class _Proxy : DeputyBase, azurerm.ConfidentialLedger.IConfidentialLedgerAzureadBasedServicePrincipal
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/confidential_ledger#ledger_role_name ConfidentialLedger#ledger_role_name}.</summary>
            [JsiiProperty(name: "ledgerRoleName", typeJson: "{\"primitive\":\"string\"}")]
            public string LedgerRoleName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/confidential_ledger#principal_id ConfidentialLedger#principal_id}.</summary>
            [JsiiProperty(name: "principalId", typeJson: "{\"primitive\":\"string\"}")]
            public string PrincipalId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/confidential_ledger#tenant_id ConfidentialLedger#tenant_id}.</summary>
            [JsiiProperty(name: "tenantId", typeJson: "{\"primitive\":\"string\"}")]
            public string TenantId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}

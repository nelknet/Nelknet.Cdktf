using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ConfidentialLedger
{
    [JsiiInterface(nativeType: typeof(IConfidentialLedgerCertificateBasedSecurityPrincipal), fullyQualifiedName: "azurerm.confidentialLedger.ConfidentialLedgerCertificateBasedSecurityPrincipal")]
    public interface IConfidentialLedgerCertificateBasedSecurityPrincipal
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/confidential_ledger#ledger_role_name ConfidentialLedger#ledger_role_name}.</summary>
        [JsiiProperty(name: "ledgerRoleName", typeJson: "{\"primitive\":\"string\"}")]
        string LedgerRoleName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/confidential_ledger#pem_public_key ConfidentialLedger#pem_public_key}.</summary>
        [JsiiProperty(name: "pemPublicKey", typeJson: "{\"primitive\":\"string\"}")]
        string PemPublicKey
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IConfidentialLedgerCertificateBasedSecurityPrincipal), fullyQualifiedName: "azurerm.confidentialLedger.ConfidentialLedgerCertificateBasedSecurityPrincipal")]
        internal sealed class _Proxy : DeputyBase, azurerm.ConfidentialLedger.IConfidentialLedgerCertificateBasedSecurityPrincipal
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/confidential_ledger#pem_public_key ConfidentialLedger#pem_public_key}.</summary>
            [JsiiProperty(name: "pemPublicKey", typeJson: "{\"primitive\":\"string\"}")]
            public string PemPublicKey
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}

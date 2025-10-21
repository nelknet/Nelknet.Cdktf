using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermConfidentialLedger
{
    [JsiiInterface(nativeType: typeof(IDataAzurermConfidentialLedgerTimeouts), fullyQualifiedName: "azurerm.dataAzurermConfidentialLedger.DataAzurermConfidentialLedgerTimeouts")]
    public interface IDataAzurermConfidentialLedgerTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/confidential_ledger#read DataAzurermConfidentialLedger#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermConfidentialLedgerTimeouts), fullyQualifiedName: "azurerm.dataAzurermConfidentialLedger.DataAzurermConfidentialLedgerTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermConfidentialLedger.IDataAzurermConfidentialLedgerTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/confidential_ledger#read DataAzurermConfidentialLedger#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

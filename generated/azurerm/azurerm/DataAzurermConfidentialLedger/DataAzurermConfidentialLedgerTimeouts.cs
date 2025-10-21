using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermConfidentialLedger
{
    [JsiiByValue(fqn: "azurerm.dataAzurermConfidentialLedger.DataAzurermConfidentialLedgerTimeouts")]
    public class DataAzurermConfidentialLedgerTimeouts : azurerm.DataAzurermConfidentialLedger.IDataAzurermConfidentialLedgerTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/confidential_ledger#read DataAzurermConfidentialLedger#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}

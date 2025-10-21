using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermBillingMpaAccountScope
{
    [JsiiByValue(fqn: "azurerm.dataAzurermBillingMpaAccountScope.DataAzurermBillingMpaAccountScopeTimeouts")]
    public class DataAzurermBillingMpaAccountScopeTimeouts : azurerm.DataAzurermBillingMpaAccountScope.IDataAzurermBillingMpaAccountScopeTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/billing_mpa_account_scope#read DataAzurermBillingMpaAccountScope#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}

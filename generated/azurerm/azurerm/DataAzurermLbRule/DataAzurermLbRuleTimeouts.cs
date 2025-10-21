using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermLbRule
{
    [JsiiByValue(fqn: "azurerm.dataAzurermLbRule.DataAzurermLbRuleTimeouts")]
    public class DataAzurermLbRuleTimeouts : azurerm.DataAzurermLbRule.IDataAzurermLbRuleTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/lb_rule#read DataAzurermLbRule#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}

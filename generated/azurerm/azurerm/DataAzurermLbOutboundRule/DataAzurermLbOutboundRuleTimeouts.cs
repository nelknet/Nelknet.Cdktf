using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermLbOutboundRule
{
    [JsiiByValue(fqn: "azurerm.dataAzurermLbOutboundRule.DataAzurermLbOutboundRuleTimeouts")]
    public class DataAzurermLbOutboundRuleTimeouts : azurerm.DataAzurermLbOutboundRule.IDataAzurermLbOutboundRuleTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/lb_outbound_rule#read DataAzurermLbOutboundRule#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}

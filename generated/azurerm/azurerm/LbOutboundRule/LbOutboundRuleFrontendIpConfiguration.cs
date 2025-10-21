using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LbOutboundRule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.lbOutboundRule.LbOutboundRuleFrontendIpConfiguration")]
    public class LbOutboundRuleFrontendIpConfiguration : azurerm.LbOutboundRule.ILbOutboundRuleFrontendIpConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_outbound_rule#name LbOutboundRule#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }
    }
}

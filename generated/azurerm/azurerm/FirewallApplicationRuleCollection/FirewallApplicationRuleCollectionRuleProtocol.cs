using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.FirewallApplicationRuleCollection
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.firewallApplicationRuleCollection.FirewallApplicationRuleCollectionRuleProtocol")]
    public class FirewallApplicationRuleCollectionRuleProtocol : azurerm.FirewallApplicationRuleCollection.IFirewallApplicationRuleCollectionRuleProtocol
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall_application_rule_collection#port FirewallApplicationRuleCollection#port}.</summary>
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
        public double Port
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall_application_rule_collection#type FirewallApplicationRuleCollection#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }
    }
}

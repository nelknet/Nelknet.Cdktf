using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WebApplicationFirewallPolicy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.webApplicationFirewallPolicy.WebApplicationFirewallPolicyCustomRulesMatchConditionsMatchVariables")]
    public class WebApplicationFirewallPolicyCustomRulesMatchConditionsMatchVariables : azurerm.WebApplicationFirewallPolicy.IWebApplicationFirewallPolicyCustomRulesMatchConditionsMatchVariables
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_application_firewall_policy#variable_name WebApplicationFirewallPolicy#variable_name}.</summary>
        [JsiiProperty(name: "variableName", typeJson: "{\"primitive\":\"string\"}")]
        public string VariableName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_application_firewall_policy#selector WebApplicationFirewallPolicy#selector}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "selector", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Selector
        {
            get;
            set;
        }
    }
}

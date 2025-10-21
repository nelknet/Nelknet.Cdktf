using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WebApplicationFirewallPolicy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.webApplicationFirewallPolicy.WebApplicationFirewallPolicyManagedRulesExclusion")]
    public class WebApplicationFirewallPolicyManagedRulesExclusion : azurerm.WebApplicationFirewallPolicy.IWebApplicationFirewallPolicyManagedRulesExclusion
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_application_firewall_policy#match_variable WebApplicationFirewallPolicy#match_variable}.</summary>
        [JsiiProperty(name: "matchVariable", typeJson: "{\"primitive\":\"string\"}")]
        public string MatchVariable
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_application_firewall_policy#selector WebApplicationFirewallPolicy#selector}.</summary>
        [JsiiProperty(name: "selector", typeJson: "{\"primitive\":\"string\"}")]
        public string Selector
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_application_firewall_policy#selector_match_operator WebApplicationFirewallPolicy#selector_match_operator}.</summary>
        [JsiiProperty(name: "selectorMatchOperator", typeJson: "{\"primitive\":\"string\"}")]
        public string SelectorMatchOperator
        {
            get;
            set;
        }

        /// <summary>excluded_rule_set block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_application_firewall_policy#excluded_rule_set WebApplicationFirewallPolicy#excluded_rule_set}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "excludedRuleSet", typeJson: "{\"fqn\":\"azurerm.webApplicationFirewallPolicy.WebApplicationFirewallPolicyManagedRulesExclusionExcludedRuleSet\"}", isOptional: true)]
        public azurerm.WebApplicationFirewallPolicy.IWebApplicationFirewallPolicyManagedRulesExclusionExcludedRuleSet? ExcludedRuleSet
        {
            get;
            set;
        }
    }
}

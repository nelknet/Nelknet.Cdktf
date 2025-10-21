using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WebApplicationFirewallPolicy
{
    [JsiiInterface(nativeType: typeof(IWebApplicationFirewallPolicyManagedRulesExclusion), fullyQualifiedName: "azurerm.webApplicationFirewallPolicy.WebApplicationFirewallPolicyManagedRulesExclusion")]
    public interface IWebApplicationFirewallPolicyManagedRulesExclusion
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_application_firewall_policy#match_variable WebApplicationFirewallPolicy#match_variable}.</summary>
        [JsiiProperty(name: "matchVariable", typeJson: "{\"primitive\":\"string\"}")]
        string MatchVariable
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_application_firewall_policy#selector WebApplicationFirewallPolicy#selector}.</summary>
        [JsiiProperty(name: "selector", typeJson: "{\"primitive\":\"string\"}")]
        string Selector
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_application_firewall_policy#selector_match_operator WebApplicationFirewallPolicy#selector_match_operator}.</summary>
        [JsiiProperty(name: "selectorMatchOperator", typeJson: "{\"primitive\":\"string\"}")]
        string SelectorMatchOperator
        {
            get;
        }

        /// <summary>excluded_rule_set block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_application_firewall_policy#excluded_rule_set WebApplicationFirewallPolicy#excluded_rule_set}
        /// </remarks>
        [JsiiProperty(name: "excludedRuleSet", typeJson: "{\"fqn\":\"azurerm.webApplicationFirewallPolicy.WebApplicationFirewallPolicyManagedRulesExclusionExcludedRuleSet\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.WebApplicationFirewallPolicy.IWebApplicationFirewallPolicyManagedRulesExclusionExcludedRuleSet? ExcludedRuleSet
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWebApplicationFirewallPolicyManagedRulesExclusion), fullyQualifiedName: "azurerm.webApplicationFirewallPolicy.WebApplicationFirewallPolicyManagedRulesExclusion")]
        internal sealed class _Proxy : DeputyBase, azurerm.WebApplicationFirewallPolicy.IWebApplicationFirewallPolicyManagedRulesExclusion
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_application_firewall_policy#match_variable WebApplicationFirewallPolicy#match_variable}.</summary>
            [JsiiProperty(name: "matchVariable", typeJson: "{\"primitive\":\"string\"}")]
            public string MatchVariable
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_application_firewall_policy#selector WebApplicationFirewallPolicy#selector}.</summary>
            [JsiiProperty(name: "selector", typeJson: "{\"primitive\":\"string\"}")]
            public string Selector
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_application_firewall_policy#selector_match_operator WebApplicationFirewallPolicy#selector_match_operator}.</summary>
            [JsiiProperty(name: "selectorMatchOperator", typeJson: "{\"primitive\":\"string\"}")]
            public string SelectorMatchOperator
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>excluded_rule_set block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_application_firewall_policy#excluded_rule_set WebApplicationFirewallPolicy#excluded_rule_set}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "excludedRuleSet", typeJson: "{\"fqn\":\"azurerm.webApplicationFirewallPolicy.WebApplicationFirewallPolicyManagedRulesExclusionExcludedRuleSet\"}", isOptional: true)]
            public azurerm.WebApplicationFirewallPolicy.IWebApplicationFirewallPolicyManagedRulesExclusionExcludedRuleSet? ExcludedRuleSet
            {
                get => GetInstanceProperty<azurerm.WebApplicationFirewallPolicy.IWebApplicationFirewallPolicyManagedRulesExclusionExcludedRuleSet?>();
            }
        }
    }
}

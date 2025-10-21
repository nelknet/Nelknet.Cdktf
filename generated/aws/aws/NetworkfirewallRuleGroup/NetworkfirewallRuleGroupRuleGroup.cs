using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.NetworkfirewallRuleGroup
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.networkfirewallRuleGroup.NetworkfirewallRuleGroupRuleGroup")]
    public class NetworkfirewallRuleGroupRuleGroup : aws.NetworkfirewallRuleGroup.INetworkfirewallRuleGroupRuleGroup
    {
        /// <summary>rules_source block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkfirewall_rule_group#rules_source NetworkfirewallRuleGroup#rules_source}
        /// </remarks>
        [JsiiProperty(name: "rulesSource", typeJson: "{\"fqn\":\"aws.networkfirewallRuleGroup.NetworkfirewallRuleGroupRuleGroupRulesSource\"}")]
        public aws.NetworkfirewallRuleGroup.INetworkfirewallRuleGroupRuleGroupRulesSource RulesSource
        {
            get;
            set;
        }

        /// <summary>reference_sets block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkfirewall_rule_group#reference_sets NetworkfirewallRuleGroup#reference_sets}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "referenceSets", typeJson: "{\"fqn\":\"aws.networkfirewallRuleGroup.NetworkfirewallRuleGroupRuleGroupReferenceSets\"}", isOptional: true)]
        public aws.NetworkfirewallRuleGroup.INetworkfirewallRuleGroupRuleGroupReferenceSets? ReferenceSets
        {
            get;
            set;
        }

        /// <summary>rule_variables block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkfirewall_rule_group#rule_variables NetworkfirewallRuleGroup#rule_variables}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ruleVariables", typeJson: "{\"fqn\":\"aws.networkfirewallRuleGroup.NetworkfirewallRuleGroupRuleGroupRuleVariables\"}", isOptional: true)]
        public aws.NetworkfirewallRuleGroup.INetworkfirewallRuleGroupRuleGroupRuleVariables? RuleVariables
        {
            get;
            set;
        }

        /// <summary>stateful_rule_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkfirewall_rule_group#stateful_rule_options NetworkfirewallRuleGroup#stateful_rule_options}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "statefulRuleOptions", typeJson: "{\"fqn\":\"aws.networkfirewallRuleGroup.NetworkfirewallRuleGroupRuleGroupStatefulRuleOptions\"}", isOptional: true)]
        public aws.NetworkfirewallRuleGroup.INetworkfirewallRuleGroupRuleGroupStatefulRuleOptions? StatefulRuleOptions
        {
            get;
            set;
        }
    }
}

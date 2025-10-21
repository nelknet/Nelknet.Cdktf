using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.NetworkfirewallRuleGroup
{
    [JsiiInterface(nativeType: typeof(INetworkfirewallRuleGroupRuleGroup), fullyQualifiedName: "aws.networkfirewallRuleGroup.NetworkfirewallRuleGroupRuleGroup")]
    public interface INetworkfirewallRuleGroupRuleGroup
    {
        /// <summary>rules_source block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkfirewall_rule_group#rules_source NetworkfirewallRuleGroup#rules_source}
        /// </remarks>
        [JsiiProperty(name: "rulesSource", typeJson: "{\"fqn\":\"aws.networkfirewallRuleGroup.NetworkfirewallRuleGroupRuleGroupRulesSource\"}")]
        aws.NetworkfirewallRuleGroup.INetworkfirewallRuleGroupRuleGroupRulesSource RulesSource
        {
            get;
        }

        /// <summary>reference_sets block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkfirewall_rule_group#reference_sets NetworkfirewallRuleGroup#reference_sets}
        /// </remarks>
        [JsiiProperty(name: "referenceSets", typeJson: "{\"fqn\":\"aws.networkfirewallRuleGroup.NetworkfirewallRuleGroupRuleGroupReferenceSets\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.NetworkfirewallRuleGroup.INetworkfirewallRuleGroupRuleGroupReferenceSets? ReferenceSets
        {
            get
            {
                return null;
            }
        }

        /// <summary>rule_variables block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkfirewall_rule_group#rule_variables NetworkfirewallRuleGroup#rule_variables}
        /// </remarks>
        [JsiiProperty(name: "ruleVariables", typeJson: "{\"fqn\":\"aws.networkfirewallRuleGroup.NetworkfirewallRuleGroupRuleGroupRuleVariables\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.NetworkfirewallRuleGroup.INetworkfirewallRuleGroupRuleGroupRuleVariables? RuleVariables
        {
            get
            {
                return null;
            }
        }

        /// <summary>stateful_rule_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkfirewall_rule_group#stateful_rule_options NetworkfirewallRuleGroup#stateful_rule_options}
        /// </remarks>
        [JsiiProperty(name: "statefulRuleOptions", typeJson: "{\"fqn\":\"aws.networkfirewallRuleGroup.NetworkfirewallRuleGroupRuleGroupStatefulRuleOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.NetworkfirewallRuleGroup.INetworkfirewallRuleGroupRuleGroupStatefulRuleOptions? StatefulRuleOptions
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(INetworkfirewallRuleGroupRuleGroup), fullyQualifiedName: "aws.networkfirewallRuleGroup.NetworkfirewallRuleGroupRuleGroup")]
        internal sealed class _Proxy : DeputyBase, aws.NetworkfirewallRuleGroup.INetworkfirewallRuleGroupRuleGroup
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>rules_source block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkfirewall_rule_group#rules_source NetworkfirewallRuleGroup#rules_source}
            /// </remarks>
            [JsiiProperty(name: "rulesSource", typeJson: "{\"fqn\":\"aws.networkfirewallRuleGroup.NetworkfirewallRuleGroupRuleGroupRulesSource\"}")]
            public aws.NetworkfirewallRuleGroup.INetworkfirewallRuleGroupRuleGroupRulesSource RulesSource
            {
                get => GetInstanceProperty<aws.NetworkfirewallRuleGroup.INetworkfirewallRuleGroupRuleGroupRulesSource>()!;
            }

            /// <summary>reference_sets block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkfirewall_rule_group#reference_sets NetworkfirewallRuleGroup#reference_sets}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "referenceSets", typeJson: "{\"fqn\":\"aws.networkfirewallRuleGroup.NetworkfirewallRuleGroupRuleGroupReferenceSets\"}", isOptional: true)]
            public aws.NetworkfirewallRuleGroup.INetworkfirewallRuleGroupRuleGroupReferenceSets? ReferenceSets
            {
                get => GetInstanceProperty<aws.NetworkfirewallRuleGroup.INetworkfirewallRuleGroupRuleGroupReferenceSets?>();
            }

            /// <summary>rule_variables block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkfirewall_rule_group#rule_variables NetworkfirewallRuleGroup#rule_variables}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ruleVariables", typeJson: "{\"fqn\":\"aws.networkfirewallRuleGroup.NetworkfirewallRuleGroupRuleGroupRuleVariables\"}", isOptional: true)]
            public aws.NetworkfirewallRuleGroup.INetworkfirewallRuleGroupRuleGroupRuleVariables? RuleVariables
            {
                get => GetInstanceProperty<aws.NetworkfirewallRuleGroup.INetworkfirewallRuleGroupRuleGroupRuleVariables?>();
            }

            /// <summary>stateful_rule_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkfirewall_rule_group#stateful_rule_options NetworkfirewallRuleGroup#stateful_rule_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "statefulRuleOptions", typeJson: "{\"fqn\":\"aws.networkfirewallRuleGroup.NetworkfirewallRuleGroupRuleGroupStatefulRuleOptions\"}", isOptional: true)]
            public aws.NetworkfirewallRuleGroup.INetworkfirewallRuleGroupRuleGroupStatefulRuleOptions? StatefulRuleOptions
            {
                get => GetInstanceProperty<aws.NetworkfirewallRuleGroup.INetworkfirewallRuleGroupRuleGroupStatefulRuleOptions?>();
            }
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.NetworkfirewallRuleGroup
{
    [JsiiInterface(nativeType: typeof(INetworkfirewallRuleGroupRuleGroupRuleVariables), fullyQualifiedName: "aws.networkfirewallRuleGroup.NetworkfirewallRuleGroupRuleGroupRuleVariables")]
    public interface INetworkfirewallRuleGroupRuleGroupRuleVariables
    {
        /// <summary>ip_sets block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkfirewall_rule_group#ip_sets NetworkfirewallRuleGroup#ip_sets}
        /// </remarks>
        [JsiiProperty(name: "ipSets", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.networkfirewallRuleGroup.NetworkfirewallRuleGroupRuleGroupRuleVariablesIpSets\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IpSets
        {
            get
            {
                return null;
            }
        }

        /// <summary>port_sets block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkfirewall_rule_group#port_sets NetworkfirewallRuleGroup#port_sets}
        /// </remarks>
        [JsiiProperty(name: "portSets", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.networkfirewallRuleGroup.NetworkfirewallRuleGroupRuleGroupRuleVariablesPortSets\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PortSets
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(INetworkfirewallRuleGroupRuleGroupRuleVariables), fullyQualifiedName: "aws.networkfirewallRuleGroup.NetworkfirewallRuleGroupRuleGroupRuleVariables")]
        internal sealed class _Proxy : DeputyBase, aws.NetworkfirewallRuleGroup.INetworkfirewallRuleGroupRuleGroupRuleVariables
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>ip_sets block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkfirewall_rule_group#ip_sets NetworkfirewallRuleGroup#ip_sets}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ipSets", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.networkfirewallRuleGroup.NetworkfirewallRuleGroupRuleGroupRuleVariablesIpSets\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? IpSets
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>port_sets block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkfirewall_rule_group#port_sets NetworkfirewallRuleGroup#port_sets}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "portSets", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.networkfirewallRuleGroup.NetworkfirewallRuleGroupRuleGroupRuleVariablesPortSets\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? PortSets
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.NetworkfirewallRuleGroup
{
    [JsiiInterface(nativeType: typeof(INetworkfirewallRuleGroupRuleGroupRuleVariablesPortSets), fullyQualifiedName: "aws.networkfirewallRuleGroup.NetworkfirewallRuleGroupRuleGroupRuleVariablesPortSets")]
    public interface INetworkfirewallRuleGroupRuleGroupRuleVariablesPortSets
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkfirewall_rule_group#key NetworkfirewallRuleGroup#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        string Key
        {
            get;
        }

        /// <summary>port_set block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkfirewall_rule_group#port_set NetworkfirewallRuleGroup#port_set}
        /// </remarks>
        [JsiiProperty(name: "portSet", typeJson: "{\"fqn\":\"aws.networkfirewallRuleGroup.NetworkfirewallRuleGroupRuleGroupRuleVariablesPortSetsPortSet\"}")]
        aws.NetworkfirewallRuleGroup.INetworkfirewallRuleGroupRuleGroupRuleVariablesPortSetsPortSet PortSet
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(INetworkfirewallRuleGroupRuleGroupRuleVariablesPortSets), fullyQualifiedName: "aws.networkfirewallRuleGroup.NetworkfirewallRuleGroupRuleGroupRuleVariablesPortSets")]
        internal sealed class _Proxy : DeputyBase, aws.NetworkfirewallRuleGroup.INetworkfirewallRuleGroupRuleGroupRuleVariablesPortSets
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkfirewall_rule_group#key NetworkfirewallRuleGroup#key}.</summary>
            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
            public string Key
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>port_set block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkfirewall_rule_group#port_set NetworkfirewallRuleGroup#port_set}
            /// </remarks>
            [JsiiProperty(name: "portSet", typeJson: "{\"fqn\":\"aws.networkfirewallRuleGroup.NetworkfirewallRuleGroupRuleGroupRuleVariablesPortSetsPortSet\"}")]
            public aws.NetworkfirewallRuleGroup.INetworkfirewallRuleGroupRuleGroupRuleVariablesPortSetsPortSet PortSet
            {
                get => GetInstanceProperty<aws.NetworkfirewallRuleGroup.INetworkfirewallRuleGroupRuleGroupRuleVariablesPortSetsPortSet>()!;
            }
        }
    }
}

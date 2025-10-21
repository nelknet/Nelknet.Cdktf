using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.NetworkfirewallFirewallPolicy
{
    [JsiiInterface(nativeType: typeof(INetworkfirewallFirewallPolicyFirewallPolicyPolicyVariablesRuleVariables), fullyQualifiedName: "aws.networkfirewallFirewallPolicy.NetworkfirewallFirewallPolicyFirewallPolicyPolicyVariablesRuleVariables")]
    public interface INetworkfirewallFirewallPolicyFirewallPolicyPolicyVariablesRuleVariables
    {
        /// <summary>ip_set block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkfirewall_firewall_policy#ip_set NetworkfirewallFirewallPolicy#ip_set}
        /// </remarks>
        [JsiiProperty(name: "ipSet", typeJson: "{\"fqn\":\"aws.networkfirewallFirewallPolicy.NetworkfirewallFirewallPolicyFirewallPolicyPolicyVariablesRuleVariablesIpSet\"}")]
        aws.NetworkfirewallFirewallPolicy.INetworkfirewallFirewallPolicyFirewallPolicyPolicyVariablesRuleVariablesIpSet IpSet
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkfirewall_firewall_policy#key NetworkfirewallFirewallPolicy#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        string Key
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(INetworkfirewallFirewallPolicyFirewallPolicyPolicyVariablesRuleVariables), fullyQualifiedName: "aws.networkfirewallFirewallPolicy.NetworkfirewallFirewallPolicyFirewallPolicyPolicyVariablesRuleVariables")]
        internal sealed class _Proxy : DeputyBase, aws.NetworkfirewallFirewallPolicy.INetworkfirewallFirewallPolicyFirewallPolicyPolicyVariablesRuleVariables
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>ip_set block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkfirewall_firewall_policy#ip_set NetworkfirewallFirewallPolicy#ip_set}
            /// </remarks>
            [JsiiProperty(name: "ipSet", typeJson: "{\"fqn\":\"aws.networkfirewallFirewallPolicy.NetworkfirewallFirewallPolicyFirewallPolicyPolicyVariablesRuleVariablesIpSet\"}")]
            public aws.NetworkfirewallFirewallPolicy.INetworkfirewallFirewallPolicyFirewallPolicyPolicyVariablesRuleVariablesIpSet IpSet
            {
                get => GetInstanceProperty<aws.NetworkfirewallFirewallPolicy.INetworkfirewallFirewallPolicyFirewallPolicyPolicyVariablesRuleVariablesIpSet>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkfirewall_firewall_policy#key NetworkfirewallFirewallPolicy#key}.</summary>
            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
            public string Key
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}

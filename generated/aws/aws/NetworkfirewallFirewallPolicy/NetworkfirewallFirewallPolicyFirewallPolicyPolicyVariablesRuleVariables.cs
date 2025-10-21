using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.NetworkfirewallFirewallPolicy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.networkfirewallFirewallPolicy.NetworkfirewallFirewallPolicyFirewallPolicyPolicyVariablesRuleVariables")]
    public class NetworkfirewallFirewallPolicyFirewallPolicyPolicyVariablesRuleVariables : aws.NetworkfirewallFirewallPolicy.INetworkfirewallFirewallPolicyFirewallPolicyPolicyVariablesRuleVariables
    {
        /// <summary>ip_set block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkfirewall_firewall_policy#ip_set NetworkfirewallFirewallPolicy#ip_set}
        /// </remarks>
        [JsiiProperty(name: "ipSet", typeJson: "{\"fqn\":\"aws.networkfirewallFirewallPolicy.NetworkfirewallFirewallPolicyFirewallPolicyPolicyVariablesRuleVariablesIpSet\"}")]
        public aws.NetworkfirewallFirewallPolicy.INetworkfirewallFirewallPolicyFirewallPolicyPolicyVariablesRuleVariablesIpSet IpSet
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkfirewall_firewall_policy#key NetworkfirewallFirewallPolicy#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public string Key
        {
            get;
            set;
        }
    }
}

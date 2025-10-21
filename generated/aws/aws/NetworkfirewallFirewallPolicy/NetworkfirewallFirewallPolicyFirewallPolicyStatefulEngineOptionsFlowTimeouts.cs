using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.NetworkfirewallFirewallPolicy
{
    [JsiiByValue(fqn: "aws.networkfirewallFirewallPolicy.NetworkfirewallFirewallPolicyFirewallPolicyStatefulEngineOptionsFlowTimeouts")]
    public class NetworkfirewallFirewallPolicyFirewallPolicyStatefulEngineOptionsFlowTimeouts : aws.NetworkfirewallFirewallPolicy.INetworkfirewallFirewallPolicyFirewallPolicyStatefulEngineOptionsFlowTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkfirewall_firewall_policy#tcp_idle_timeout_seconds NetworkfirewallFirewallPolicy#tcp_idle_timeout_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tcpIdleTimeoutSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TcpIdleTimeoutSeconds
        {
            get;
            set;
        }
    }
}

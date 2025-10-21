using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.NetworkfirewallFirewallPolicy
{
    [JsiiByValue(fqn: "aws.networkfirewallFirewallPolicy.NetworkfirewallFirewallPolicyFirewallPolicyStatefulEngineOptions")]
    public class NetworkfirewallFirewallPolicyFirewallPolicyStatefulEngineOptions : aws.NetworkfirewallFirewallPolicy.INetworkfirewallFirewallPolicyFirewallPolicyStatefulEngineOptions
    {
        /// <summary>flow_timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkfirewall_firewall_policy#flow_timeouts NetworkfirewallFirewallPolicy#flow_timeouts}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "flowTimeouts", typeJson: "{\"fqn\":\"aws.networkfirewallFirewallPolicy.NetworkfirewallFirewallPolicyFirewallPolicyStatefulEngineOptionsFlowTimeouts\"}", isOptional: true)]
        public aws.NetworkfirewallFirewallPolicy.INetworkfirewallFirewallPolicyFirewallPolicyStatefulEngineOptionsFlowTimeouts? FlowTimeouts
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkfirewall_firewall_policy#rule_order NetworkfirewallFirewallPolicy#rule_order}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ruleOrder", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RuleOrder
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkfirewall_firewall_policy#stream_exception_policy NetworkfirewallFirewallPolicy#stream_exception_policy}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "streamExceptionPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StreamExceptionPolicy
        {
            get;
            set;
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.NetworkfirewallFirewallPolicy
{
    [JsiiByValue(fqn: "aws.networkfirewallFirewallPolicy.NetworkfirewallFirewallPolicyFirewallPolicyPolicyVariables")]
    public class NetworkfirewallFirewallPolicyFirewallPolicyPolicyVariables : aws.NetworkfirewallFirewallPolicy.INetworkfirewallFirewallPolicyFirewallPolicyPolicyVariables
    {
        private object? _ruleVariables;

        /// <summary>rule_variables block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkfirewall_firewall_policy#rule_variables NetworkfirewallFirewallPolicy#rule_variables}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ruleVariables", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.networkfirewallFirewallPolicy.NetworkfirewallFirewallPolicyFirewallPolicyPolicyVariablesRuleVariables\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? RuleVariables
        {
            get => _ruleVariables;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.NetworkfirewallFirewallPolicy.INetworkfirewallFirewallPolicyFirewallPolicyPolicyVariablesRuleVariables[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.NetworkfirewallFirewallPolicy.INetworkfirewallFirewallPolicyFirewallPolicyPolicyVariablesRuleVariables).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _ruleVariables = value;
            }
        }
    }
}

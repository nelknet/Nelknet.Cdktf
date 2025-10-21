using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.NetworkfirewallRuleGroup
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.networkfirewallRuleGroup.NetworkfirewallRuleGroupRuleGroupReferenceSetsIpSetReferencesIpSetReference")]
    public class NetworkfirewallRuleGroupRuleGroupReferenceSetsIpSetReferencesIpSetReference : aws.NetworkfirewallRuleGroup.INetworkfirewallRuleGroupRuleGroupReferenceSetsIpSetReferencesIpSetReference
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkfirewall_rule_group#reference_arn NetworkfirewallRuleGroup#reference_arn}.</summary>
        [JsiiProperty(name: "referenceArn", typeJson: "{\"primitive\":\"string\"}")]
        public string ReferenceArn
        {
            get;
            set;
        }
    }
}

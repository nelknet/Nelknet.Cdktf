using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.NetworkfirewallRuleGroup
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.networkfirewallRuleGroup.NetworkfirewallRuleGroupRuleGroupRuleVariablesPortSets")]
    public class NetworkfirewallRuleGroupRuleGroupRuleVariablesPortSets : aws.NetworkfirewallRuleGroup.INetworkfirewallRuleGroupRuleGroupRuleVariablesPortSets
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkfirewall_rule_group#key NetworkfirewallRuleGroup#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public string Key
        {
            get;
            set;
        }

        /// <summary>port_set block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkfirewall_rule_group#port_set NetworkfirewallRuleGroup#port_set}
        /// </remarks>
        [JsiiProperty(name: "portSet", typeJson: "{\"fqn\":\"aws.networkfirewallRuleGroup.NetworkfirewallRuleGroupRuleGroupRuleVariablesPortSetsPortSet\"}")]
        public aws.NetworkfirewallRuleGroup.INetworkfirewallRuleGroupRuleGroupRuleVariablesPortSetsPortSet PortSet
        {
            get;
            set;
        }
    }
}

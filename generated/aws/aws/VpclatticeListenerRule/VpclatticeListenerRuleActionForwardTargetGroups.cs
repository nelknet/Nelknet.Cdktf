using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.VpclatticeListenerRule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.vpclatticeListenerRule.VpclatticeListenerRuleActionForwardTargetGroups")]
    public class VpclatticeListenerRuleActionForwardTargetGroups : aws.VpclatticeListenerRule.IVpclatticeListenerRuleActionForwardTargetGroups
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_listener_rule#target_group_identifier VpclatticeListenerRule#target_group_identifier}.</summary>
        [JsiiProperty(name: "targetGroupIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        public string TargetGroupIdentifier
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_listener_rule#weight VpclatticeListenerRule#weight}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "weight", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Weight
        {
            get;
            set;
        }
    }
}

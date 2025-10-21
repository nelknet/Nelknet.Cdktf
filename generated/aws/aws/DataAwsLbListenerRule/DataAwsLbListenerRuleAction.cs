using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsLbListenerRule
{
    [JsiiByValue(fqn: "aws.dataAwsLbListenerRule.DataAwsLbListenerRuleAction")]
    public class DataAwsLbListenerRuleAction : aws.DataAwsLbListenerRule.IDataAwsLbListenerRuleAction
    {
        /// <summary>forward block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lb_listener_rule#forward DataAwsLbListenerRule#forward}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "forward", typeJson: "{\"fqn\":\"aws.dataAwsLbListenerRule.DataAwsLbListenerRuleActionForward\"}", isOptional: true)]
        public aws.DataAwsLbListenerRule.IDataAwsLbListenerRuleActionForward? Forward
        {
            get;
            set;
        }
    }
}

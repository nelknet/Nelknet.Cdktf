using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsLbListenerRule
{
    [JsiiByValue(fqn: "aws.dataAwsLbListenerRule.DataAwsLbListenerRuleCondition")]
    public class DataAwsLbListenerRuleCondition : aws.DataAwsLbListenerRule.IDataAwsLbListenerRuleCondition
    {
        /// <summary>query_string block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lb_listener_rule#query_string DataAwsLbListenerRule#query_string}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "queryString", typeJson: "{\"fqn\":\"aws.dataAwsLbListenerRule.DataAwsLbListenerRuleConditionQueryString\"}", isOptional: true)]
        public aws.DataAwsLbListenerRule.IDataAwsLbListenerRuleConditionQueryString? QueryString
        {
            get;
            set;
        }
    }
}

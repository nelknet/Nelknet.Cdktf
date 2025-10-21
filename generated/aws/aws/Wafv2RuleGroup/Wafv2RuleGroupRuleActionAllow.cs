using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2RuleGroup
{
    [JsiiByValue(fqn: "aws.wafv2RuleGroup.Wafv2RuleGroupRuleActionAllow")]
    public class Wafv2RuleGroupRuleActionAllow : aws.Wafv2RuleGroup.IWafv2RuleGroupRuleActionAllow
    {
        /// <summary>custom_request_handling block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_rule_group#custom_request_handling Wafv2RuleGroup#custom_request_handling}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "customRequestHandling", typeJson: "{\"fqn\":\"aws.wafv2RuleGroup.Wafv2RuleGroupRuleActionAllowCustomRequestHandling\"}", isOptional: true)]
        public aws.Wafv2RuleGroup.IWafv2RuleGroupRuleActionAllowCustomRequestHandling? CustomRequestHandling
        {
            get;
            set;
        }
    }
}

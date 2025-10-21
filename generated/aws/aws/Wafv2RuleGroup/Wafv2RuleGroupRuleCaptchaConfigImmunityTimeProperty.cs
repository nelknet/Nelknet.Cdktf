using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2RuleGroup
{
    [JsiiByValue(fqn: "aws.wafv2RuleGroup.Wafv2RuleGroupRuleCaptchaConfigImmunityTimeProperty")]
    public class Wafv2RuleGroupRuleCaptchaConfigImmunityTimeProperty : aws.Wafv2RuleGroup.IWafv2RuleGroupRuleCaptchaConfigImmunityTimeProperty
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_rule_group#immunity_time Wafv2RuleGroup#immunity_time}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "immunityTime", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ImmunityTime
        {
            get;
            set;
        }
    }
}

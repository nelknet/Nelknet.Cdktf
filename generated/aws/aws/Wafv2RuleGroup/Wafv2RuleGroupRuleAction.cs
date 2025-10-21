using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2RuleGroup
{
    [JsiiByValue(fqn: "aws.wafv2RuleGroup.Wafv2RuleGroupRuleAction")]
    public class Wafv2RuleGroupRuleAction : aws.Wafv2RuleGroup.IWafv2RuleGroupRuleAction
    {
        /// <summary>allow block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_rule_group#allow Wafv2RuleGroup#allow}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "allow", typeJson: "{\"fqn\":\"aws.wafv2RuleGroup.Wafv2RuleGroupRuleActionAllow\"}", isOptional: true)]
        public aws.Wafv2RuleGroup.IWafv2RuleGroupRuleActionAllow? Allow
        {
            get;
            set;
        }

        /// <summary>block block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_rule_group#block Wafv2RuleGroup#block}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "block", typeJson: "{\"fqn\":\"aws.wafv2RuleGroup.Wafv2RuleGroupRuleActionBlock\"}", isOptional: true)]
        public aws.Wafv2RuleGroup.IWafv2RuleGroupRuleActionBlock? Block
        {
            get;
            set;
        }

        /// <summary>captcha block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_rule_group#captcha Wafv2RuleGroup#captcha}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "captcha", typeJson: "{\"fqn\":\"aws.wafv2RuleGroup.Wafv2RuleGroupRuleActionCaptcha\"}", isOptional: true)]
        public aws.Wafv2RuleGroup.IWafv2RuleGroupRuleActionCaptcha? Captcha
        {
            get;
            set;
        }

        /// <summary>challenge block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_rule_group#challenge Wafv2RuleGroup#challenge}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "challenge", typeJson: "{\"fqn\":\"aws.wafv2RuleGroup.Wafv2RuleGroupRuleActionChallenge\"}", isOptional: true)]
        public aws.Wafv2RuleGroup.IWafv2RuleGroupRuleActionChallenge? Challenge
        {
            get;
            set;
        }

        /// <summary>count block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_rule_group#count Wafv2RuleGroup#count}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"fqn\":\"aws.wafv2RuleGroup.Wafv2RuleGroupRuleActionCount\"}", isOptional: true)]
        public aws.Wafv2RuleGroup.IWafv2RuleGroupRuleActionCount? Count
        {
            get;
            set;
        }
    }
}

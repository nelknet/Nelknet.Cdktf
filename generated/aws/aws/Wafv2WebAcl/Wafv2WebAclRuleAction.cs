using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAcl
{
    [JsiiByValue(fqn: "aws.wafv2WebAcl.Wafv2WebAclRuleAction")]
    public class Wafv2WebAclRuleAction : aws.Wafv2WebAcl.IWafv2WebAclRuleAction
    {
        /// <summary>allow block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#allow Wafv2WebAcl#allow}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "allow", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclRuleActionAllow\"}", isOptional: true)]
        public aws.Wafv2WebAcl.IWafv2WebAclRuleActionAllow? Allow
        {
            get;
            set;
        }

        /// <summary>block block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#block Wafv2WebAcl#block}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "block", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclRuleActionBlock\"}", isOptional: true)]
        public aws.Wafv2WebAcl.IWafv2WebAclRuleActionBlock? Block
        {
            get;
            set;
        }

        /// <summary>captcha block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#captcha Wafv2WebAcl#captcha}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "captcha", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclRuleActionCaptcha\"}", isOptional: true)]
        public aws.Wafv2WebAcl.IWafv2WebAclRuleActionCaptcha? Captcha
        {
            get;
            set;
        }

        /// <summary>challenge block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#challenge Wafv2WebAcl#challenge}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "challenge", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclRuleActionChallenge\"}", isOptional: true)]
        public aws.Wafv2WebAcl.IWafv2WebAclRuleActionChallenge? Challenge
        {
            get;
            set;
        }

        /// <summary>count block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#count Wafv2WebAcl#count}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclRuleActionCount\"}", isOptional: true)]
        public aws.Wafv2WebAcl.IWafv2WebAclRuleActionCount? Count
        {
            get;
            set;
        }
    }
}

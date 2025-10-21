using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAcl
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.wafv2WebAcl.Wafv2WebAclRule")]
    public class Wafv2WebAclRule : aws.Wafv2WebAcl.IWafv2WebAclRule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#name Wafv2WebAcl#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#priority Wafv2WebAcl#priority}.</summary>
        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}")]
        public double Priority
        {
            get;
            set;
        }

        /// <summary>visibility_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#visibility_config Wafv2WebAcl#visibility_config}
        /// </remarks>
        [JsiiProperty(name: "visibilityConfig", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclRuleVisibilityConfig\"}")]
        public aws.Wafv2WebAcl.IWafv2WebAclRuleVisibilityConfig VisibilityConfig
        {
            get;
            set;
        }

        /// <summary>action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#action Wafv2WebAcl#action}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclRuleAction\"}", isOptional: true)]
        public aws.Wafv2WebAcl.IWafv2WebAclRuleAction? Action
        {
            get;
            set;
        }

        /// <summary>captcha_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#captcha_config Wafv2WebAcl#captcha_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "captchaConfig", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclRuleCaptchaConfig\"}", isOptional: true)]
        public aws.Wafv2WebAcl.IWafv2WebAclRuleCaptchaConfig? CaptchaConfig
        {
            get;
            set;
        }

        /// <summary>challenge_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#challenge_config Wafv2WebAcl#challenge_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "challengeConfig", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclRuleChallengeConfig\"}", isOptional: true)]
        public aws.Wafv2WebAcl.IWafv2WebAclRuleChallengeConfig? ChallengeConfig
        {
            get;
            set;
        }

        /// <summary>override_action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#override_action Wafv2WebAcl#override_action}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "overrideAction", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclRuleOverrideAction\"}", isOptional: true)]
        public aws.Wafv2WebAcl.IWafv2WebAclRuleOverrideAction? OverrideAction
        {
            get;
            set;
        }

        private object? _ruleLabel;

        /// <summary>rule_label block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#rule_label Wafv2WebAcl#rule_label}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ruleLabel", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclRuleRuleLabel\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? RuleLabel
        {
            get => _ruleLabel;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.Wafv2WebAcl.IWafv2WebAclRuleRuleLabel[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Wafv2WebAcl.IWafv2WebAclRuleRuleLabel).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _ruleLabel = value;
            }
        }

        /// <summary>statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#statement Wafv2WebAcl#statement}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "statement", typeJson: "{\"primitive\":\"any\"}", isOptional: true)]
        public object? Statement
        {
            get;
            set;
        }
    }
}

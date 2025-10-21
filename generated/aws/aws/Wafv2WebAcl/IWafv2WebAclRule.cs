using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAcl
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRule), fullyQualifiedName: "aws.wafv2WebAcl.Wafv2WebAclRule")]
    public interface IWafv2WebAclRule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#name Wafv2WebAcl#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#priority Wafv2WebAcl#priority}.</summary>
        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}")]
        double Priority
        {
            get;
        }

        /// <summary>visibility_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#visibility_config Wafv2WebAcl#visibility_config}
        /// </remarks>
        [JsiiProperty(name: "visibilityConfig", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclRuleVisibilityConfig\"}")]
        aws.Wafv2WebAcl.IWafv2WebAclRuleVisibilityConfig VisibilityConfig
        {
            get;
        }

        /// <summary>action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#action Wafv2WebAcl#action}
        /// </remarks>
        [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclRuleAction\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2WebAcl.IWafv2WebAclRuleAction? Action
        {
            get
            {
                return null;
            }
        }

        /// <summary>captcha_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#captcha_config Wafv2WebAcl#captcha_config}
        /// </remarks>
        [JsiiProperty(name: "captchaConfig", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclRuleCaptchaConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2WebAcl.IWafv2WebAclRuleCaptchaConfig? CaptchaConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>challenge_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#challenge_config Wafv2WebAcl#challenge_config}
        /// </remarks>
        [JsiiProperty(name: "challengeConfig", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclRuleChallengeConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2WebAcl.IWafv2WebAclRuleChallengeConfig? ChallengeConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>override_action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#override_action Wafv2WebAcl#override_action}
        /// </remarks>
        [JsiiProperty(name: "overrideAction", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclRuleOverrideAction\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2WebAcl.IWafv2WebAclRuleOverrideAction? OverrideAction
        {
            get
            {
                return null;
            }
        }

        /// <summary>rule_label block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#rule_label Wafv2WebAcl#rule_label}
        /// </remarks>
        [JsiiProperty(name: "ruleLabel", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclRuleRuleLabel\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RuleLabel
        {
            get
            {
                return null;
            }
        }

        /// <summary>statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#statement Wafv2WebAcl#statement}
        /// </remarks>
        [JsiiProperty(name: "statement", typeJson: "{\"primitive\":\"any\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Statement
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclRule), fullyQualifiedName: "aws.wafv2WebAcl.Wafv2WebAclRule")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2WebAcl.IWafv2WebAclRule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#name Wafv2WebAcl#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#priority Wafv2WebAcl#priority}.</summary>
            [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}")]
            public double Priority
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>visibility_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#visibility_config Wafv2WebAcl#visibility_config}
            /// </remarks>
            [JsiiProperty(name: "visibilityConfig", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclRuleVisibilityConfig\"}")]
            public aws.Wafv2WebAcl.IWafv2WebAclRuleVisibilityConfig VisibilityConfig
            {
                get => GetInstanceProperty<aws.Wafv2WebAcl.IWafv2WebAclRuleVisibilityConfig>()!;
            }

            /// <summary>action block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#action Wafv2WebAcl#action}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclRuleAction\"}", isOptional: true)]
            public aws.Wafv2WebAcl.IWafv2WebAclRuleAction? Action
            {
                get => GetInstanceProperty<aws.Wafv2WebAcl.IWafv2WebAclRuleAction?>();
            }

            /// <summary>captcha_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#captcha_config Wafv2WebAcl#captcha_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "captchaConfig", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclRuleCaptchaConfig\"}", isOptional: true)]
            public aws.Wafv2WebAcl.IWafv2WebAclRuleCaptchaConfig? CaptchaConfig
            {
                get => GetInstanceProperty<aws.Wafv2WebAcl.IWafv2WebAclRuleCaptchaConfig?>();
            }

            /// <summary>challenge_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#challenge_config Wafv2WebAcl#challenge_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "challengeConfig", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclRuleChallengeConfig\"}", isOptional: true)]
            public aws.Wafv2WebAcl.IWafv2WebAclRuleChallengeConfig? ChallengeConfig
            {
                get => GetInstanceProperty<aws.Wafv2WebAcl.IWafv2WebAclRuleChallengeConfig?>();
            }

            /// <summary>override_action block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#override_action Wafv2WebAcl#override_action}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "overrideAction", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclRuleOverrideAction\"}", isOptional: true)]
            public aws.Wafv2WebAcl.IWafv2WebAclRuleOverrideAction? OverrideAction
            {
                get => GetInstanceProperty<aws.Wafv2WebAcl.IWafv2WebAclRuleOverrideAction?>();
            }

            /// <summary>rule_label block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#rule_label Wafv2WebAcl#rule_label}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ruleLabel", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclRuleRuleLabel\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RuleLabel
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>statement block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#statement Wafv2WebAcl#statement}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "statement", typeJson: "{\"primitive\":\"any\"}", isOptional: true)]
            public object? Statement
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}

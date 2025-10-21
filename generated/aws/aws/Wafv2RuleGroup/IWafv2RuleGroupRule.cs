using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2RuleGroup
{
    [JsiiInterface(nativeType: typeof(IWafv2RuleGroupRule), fullyQualifiedName: "aws.wafv2RuleGroup.Wafv2RuleGroupRule")]
    public interface IWafv2RuleGroupRule
    {
        /// <summary>action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_rule_group#action Wafv2RuleGroup#action}
        /// </remarks>
        [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"aws.wafv2RuleGroup.Wafv2RuleGroupRuleAction\"}")]
        aws.Wafv2RuleGroup.IWafv2RuleGroupRuleAction Action
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_rule_group#name Wafv2RuleGroup#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_rule_group#priority Wafv2RuleGroup#priority}.</summary>
        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}")]
        double Priority
        {
            get;
        }

        /// <summary>visibility_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_rule_group#visibility_config Wafv2RuleGroup#visibility_config}
        /// </remarks>
        [JsiiProperty(name: "visibilityConfig", typeJson: "{\"fqn\":\"aws.wafv2RuleGroup.Wafv2RuleGroupRuleVisibilityConfig\"}")]
        aws.Wafv2RuleGroup.IWafv2RuleGroupRuleVisibilityConfig VisibilityConfig
        {
            get;
        }

        /// <summary>captcha_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_rule_group#captcha_config Wafv2RuleGroup#captcha_config}
        /// </remarks>
        [JsiiProperty(name: "captchaConfig", typeJson: "{\"fqn\":\"aws.wafv2RuleGroup.Wafv2RuleGroupRuleCaptchaConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2RuleGroup.IWafv2RuleGroupRuleCaptchaConfig? CaptchaConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>rule_label block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_rule_group#rule_label Wafv2RuleGroup#rule_label}
        /// </remarks>
        [JsiiProperty(name: "ruleLabel", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2RuleGroup.Wafv2RuleGroupRuleRuleLabel\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_rule_group#statement Wafv2RuleGroup#statement}
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

        [JsiiTypeProxy(nativeType: typeof(IWafv2RuleGroupRule), fullyQualifiedName: "aws.wafv2RuleGroup.Wafv2RuleGroupRule")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2RuleGroup.IWafv2RuleGroupRule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>action block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_rule_group#action Wafv2RuleGroup#action}
            /// </remarks>
            [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"aws.wafv2RuleGroup.Wafv2RuleGroupRuleAction\"}")]
            public aws.Wafv2RuleGroup.IWafv2RuleGroupRuleAction Action
            {
                get => GetInstanceProperty<aws.Wafv2RuleGroup.IWafv2RuleGroupRuleAction>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_rule_group#name Wafv2RuleGroup#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_rule_group#priority Wafv2RuleGroup#priority}.</summary>
            [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}")]
            public double Priority
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>visibility_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_rule_group#visibility_config Wafv2RuleGroup#visibility_config}
            /// </remarks>
            [JsiiProperty(name: "visibilityConfig", typeJson: "{\"fqn\":\"aws.wafv2RuleGroup.Wafv2RuleGroupRuleVisibilityConfig\"}")]
            public aws.Wafv2RuleGroup.IWafv2RuleGroupRuleVisibilityConfig VisibilityConfig
            {
                get => GetInstanceProperty<aws.Wafv2RuleGroup.IWafv2RuleGroupRuleVisibilityConfig>()!;
            }

            /// <summary>captcha_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_rule_group#captcha_config Wafv2RuleGroup#captcha_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "captchaConfig", typeJson: "{\"fqn\":\"aws.wafv2RuleGroup.Wafv2RuleGroupRuleCaptchaConfig\"}", isOptional: true)]
            public aws.Wafv2RuleGroup.IWafv2RuleGroupRuleCaptchaConfig? CaptchaConfig
            {
                get => GetInstanceProperty<aws.Wafv2RuleGroup.IWafv2RuleGroupRuleCaptchaConfig?>();
            }

            /// <summary>rule_label block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_rule_group#rule_label Wafv2RuleGroup#rule_label}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ruleLabel", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2RuleGroup.Wafv2RuleGroupRuleRuleLabel\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RuleLabel
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>statement block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_rule_group#statement Wafv2RuleGroup#statement}
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

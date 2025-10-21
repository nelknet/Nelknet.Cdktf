using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2RuleGroup
{
    [JsiiInterface(nativeType: typeof(IWafv2RuleGroupRuleCaptchaConfig), fullyQualifiedName: "aws.wafv2RuleGroup.Wafv2RuleGroupRuleCaptchaConfig")]
    public interface IWafv2RuleGroupRuleCaptchaConfig
    {
        /// <summary>immunity_time_property block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_rule_group#immunity_time_property Wafv2RuleGroup#immunity_time_property}
        /// </remarks>
        [JsiiProperty(name: "immunityTimeProperty", typeJson: "{\"fqn\":\"aws.wafv2RuleGroup.Wafv2RuleGroupRuleCaptchaConfigImmunityTimeProperty\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2RuleGroup.IWafv2RuleGroupRuleCaptchaConfigImmunityTimeProperty? ImmunityTimeProperty
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2RuleGroupRuleCaptchaConfig), fullyQualifiedName: "aws.wafv2RuleGroup.Wafv2RuleGroupRuleCaptchaConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2RuleGroup.IWafv2RuleGroupRuleCaptchaConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>immunity_time_property block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_rule_group#immunity_time_property Wafv2RuleGroup#immunity_time_property}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "immunityTimeProperty", typeJson: "{\"fqn\":\"aws.wafv2RuleGroup.Wafv2RuleGroupRuleCaptchaConfigImmunityTimeProperty\"}", isOptional: true)]
            public aws.Wafv2RuleGroup.IWafv2RuleGroupRuleCaptchaConfigImmunityTimeProperty? ImmunityTimeProperty
            {
                get => GetInstanceProperty<aws.Wafv2RuleGroup.IWafv2RuleGroupRuleCaptchaConfigImmunityTimeProperty?>();
            }
        }
    }
}

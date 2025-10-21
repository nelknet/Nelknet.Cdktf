using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2RuleGroup
{
    [JsiiInterface(nativeType: typeof(IWafv2RuleGroupRuleCaptchaConfigImmunityTimeProperty), fullyQualifiedName: "aws.wafv2RuleGroup.Wafv2RuleGroupRuleCaptchaConfigImmunityTimeProperty")]
    public interface IWafv2RuleGroupRuleCaptchaConfigImmunityTimeProperty
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_rule_group#immunity_time Wafv2RuleGroup#immunity_time}.</summary>
        [JsiiProperty(name: "immunityTime", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ImmunityTime
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2RuleGroupRuleCaptchaConfigImmunityTimeProperty), fullyQualifiedName: "aws.wafv2RuleGroup.Wafv2RuleGroupRuleCaptchaConfigImmunityTimeProperty")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2RuleGroup.IWafv2RuleGroupRuleCaptchaConfigImmunityTimeProperty
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_rule_group#immunity_time Wafv2RuleGroup#immunity_time}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "immunityTime", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ImmunityTime
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}

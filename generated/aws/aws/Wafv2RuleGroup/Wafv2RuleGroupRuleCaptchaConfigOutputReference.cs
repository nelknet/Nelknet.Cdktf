using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2RuleGroup
{
    [JsiiClass(nativeType: typeof(aws.Wafv2RuleGroup.Wafv2RuleGroupRuleCaptchaConfigOutputReference), fullyQualifiedName: "aws.wafv2RuleGroup.Wafv2RuleGroupRuleCaptchaConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class Wafv2RuleGroupRuleCaptchaConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public Wafv2RuleGroupRuleCaptchaConfigOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Wafv2RuleGroupRuleCaptchaConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Wafv2RuleGroupRuleCaptchaConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putImmunityTimeProperty", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2RuleGroup.Wafv2RuleGroupRuleCaptchaConfigImmunityTimeProperty\"}}]")]
        public virtual void PutImmunityTimeProperty(aws.Wafv2RuleGroup.IWafv2RuleGroupRuleCaptchaConfigImmunityTimeProperty @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2RuleGroup.IWafv2RuleGroupRuleCaptchaConfigImmunityTimeProperty)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetImmunityTimeProperty")]
        public virtual void ResetImmunityTimeProperty()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "immunityTimeProperty", typeJson: "{\"fqn\":\"aws.wafv2RuleGroup.Wafv2RuleGroupRuleCaptchaConfigImmunityTimePropertyOutputReference\"}")]
        public virtual aws.Wafv2RuleGroup.Wafv2RuleGroupRuleCaptchaConfigImmunityTimePropertyOutputReference ImmunityTimeProperty
        {
            get => GetInstanceProperty<aws.Wafv2RuleGroup.Wafv2RuleGroupRuleCaptchaConfigImmunityTimePropertyOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "immunityTimePropertyInput", typeJson: "{\"fqn\":\"aws.wafv2RuleGroup.Wafv2RuleGroupRuleCaptchaConfigImmunityTimeProperty\"}", isOptional: true)]
        public virtual aws.Wafv2RuleGroup.IWafv2RuleGroupRuleCaptchaConfigImmunityTimeProperty? ImmunityTimePropertyInput
        {
            get => GetInstanceProperty<aws.Wafv2RuleGroup.IWafv2RuleGroupRuleCaptchaConfigImmunityTimeProperty?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.wafv2RuleGroup.Wafv2RuleGroupRuleCaptchaConfig\"}", isOptional: true)]
        public virtual aws.Wafv2RuleGroup.IWafv2RuleGroupRuleCaptchaConfig? InternalValue
        {
            get => GetInstanceProperty<aws.Wafv2RuleGroup.IWafv2RuleGroupRuleCaptchaConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}

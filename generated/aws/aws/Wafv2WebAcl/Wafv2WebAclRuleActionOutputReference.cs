using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAcl
{
    [JsiiClass(nativeType: typeof(aws.Wafv2WebAcl.Wafv2WebAclRuleActionOutputReference), fullyQualifiedName: "aws.wafv2WebAcl.Wafv2WebAclRuleActionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class Wafv2WebAclRuleActionOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public Wafv2WebAclRuleActionOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected Wafv2WebAclRuleActionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Wafv2WebAclRuleActionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAllow", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclRuleActionAllow\"}}]")]
        public virtual void PutAllow(aws.Wafv2WebAcl.IWafv2WebAclRuleActionAllow @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2WebAcl.IWafv2WebAclRuleActionAllow)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBlock", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclRuleActionBlock\"}}]")]
        public virtual void PutBlock(aws.Wafv2WebAcl.IWafv2WebAclRuleActionBlock @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2WebAcl.IWafv2WebAclRuleActionBlock)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCaptcha", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclRuleActionCaptcha\"}}]")]
        public virtual void PutCaptcha(aws.Wafv2WebAcl.IWafv2WebAclRuleActionCaptcha @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2WebAcl.IWafv2WebAclRuleActionCaptcha)}, new object[]{@value});
        }

        [JsiiMethod(name: "putChallenge", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclRuleActionChallenge\"}}]")]
        public virtual void PutChallenge(aws.Wafv2WebAcl.IWafv2WebAclRuleActionChallenge @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2WebAcl.IWafv2WebAclRuleActionChallenge)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCount", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclRuleActionCount\"}}]")]
        public virtual void PutCount(aws.Wafv2WebAcl.IWafv2WebAclRuleActionCount @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2WebAcl.IWafv2WebAclRuleActionCount)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAllow")]
        public virtual void ResetAllow()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBlock")]
        public virtual void ResetBlock()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCaptcha")]
        public virtual void ResetCaptcha()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetChallenge")]
        public virtual void ResetChallenge()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCount")]
        public virtual void ResetCount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "allow", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclRuleActionAllowOutputReference\"}")]
        public virtual aws.Wafv2WebAcl.Wafv2WebAclRuleActionAllowOutputReference Allow
        {
            get => GetInstanceProperty<aws.Wafv2WebAcl.Wafv2WebAclRuleActionAllowOutputReference>()!;
        }

        [JsiiProperty(name: "block", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclRuleActionBlockOutputReference\"}")]
        public virtual aws.Wafv2WebAcl.Wafv2WebAclRuleActionBlockOutputReference Block
        {
            get => GetInstanceProperty<aws.Wafv2WebAcl.Wafv2WebAclRuleActionBlockOutputReference>()!;
        }

        [JsiiProperty(name: "captcha", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclRuleActionCaptchaOutputReference\"}")]
        public virtual aws.Wafv2WebAcl.Wafv2WebAclRuleActionCaptchaOutputReference Captcha
        {
            get => GetInstanceProperty<aws.Wafv2WebAcl.Wafv2WebAclRuleActionCaptchaOutputReference>()!;
        }

        [JsiiProperty(name: "challenge", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclRuleActionChallengeOutputReference\"}")]
        public virtual aws.Wafv2WebAcl.Wafv2WebAclRuleActionChallengeOutputReference Challenge
        {
            get => GetInstanceProperty<aws.Wafv2WebAcl.Wafv2WebAclRuleActionChallengeOutputReference>()!;
        }

        [JsiiProperty(name: "count", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclRuleActionCountOutputReference\"}")]
        public virtual aws.Wafv2WebAcl.Wafv2WebAclRuleActionCountOutputReference Count
        {
            get => GetInstanceProperty<aws.Wafv2WebAcl.Wafv2WebAclRuleActionCountOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "allowInput", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclRuleActionAllow\"}", isOptional: true)]
        public virtual aws.Wafv2WebAcl.IWafv2WebAclRuleActionAllow? AllowInput
        {
            get => GetInstanceProperty<aws.Wafv2WebAcl.IWafv2WebAclRuleActionAllow?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "blockInput", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclRuleActionBlock\"}", isOptional: true)]
        public virtual aws.Wafv2WebAcl.IWafv2WebAclRuleActionBlock? BlockInput
        {
            get => GetInstanceProperty<aws.Wafv2WebAcl.IWafv2WebAclRuleActionBlock?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "captchaInput", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclRuleActionCaptcha\"}", isOptional: true)]
        public virtual aws.Wafv2WebAcl.IWafv2WebAclRuleActionCaptcha? CaptchaInput
        {
            get => GetInstanceProperty<aws.Wafv2WebAcl.IWafv2WebAclRuleActionCaptcha?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "challengeInput", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclRuleActionChallenge\"}", isOptional: true)]
        public virtual aws.Wafv2WebAcl.IWafv2WebAclRuleActionChallenge? ChallengeInput
        {
            get => GetInstanceProperty<aws.Wafv2WebAcl.IWafv2WebAclRuleActionChallenge?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "countInput", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclRuleActionCount\"}", isOptional: true)]
        public virtual aws.Wafv2WebAcl.IWafv2WebAclRuleActionCount? CountInput
        {
            get => GetInstanceProperty<aws.Wafv2WebAcl.IWafv2WebAclRuleActionCount?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclRuleAction\"}", isOptional: true)]
        public virtual aws.Wafv2WebAcl.IWafv2WebAclRuleAction? InternalValue
        {
            get => GetInstanceProperty<aws.Wafv2WebAcl.IWafv2WebAclRuleAction?>();
            set => SetInstanceProperty(value);
        }
    }
}

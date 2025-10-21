using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAcl
{
    [JsiiClass(nativeType: typeof(aws.Wafv2WebAcl.Wafv2WebAclRuleActionChallengeOutputReference), fullyQualifiedName: "aws.wafv2WebAcl.Wafv2WebAclRuleActionChallengeOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class Wafv2WebAclRuleActionChallengeOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public Wafv2WebAclRuleActionChallengeOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected Wafv2WebAclRuleActionChallengeOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Wafv2WebAclRuleActionChallengeOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCustomRequestHandling", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclRuleActionChallengeCustomRequestHandling\"}}]")]
        public virtual void PutCustomRequestHandling(aws.Wafv2WebAcl.IWafv2WebAclRuleActionChallengeCustomRequestHandling @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2WebAcl.IWafv2WebAclRuleActionChallengeCustomRequestHandling)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCustomRequestHandling")]
        public virtual void ResetCustomRequestHandling()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "customRequestHandling", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclRuleActionChallengeCustomRequestHandlingOutputReference\"}")]
        public virtual aws.Wafv2WebAcl.Wafv2WebAclRuleActionChallengeCustomRequestHandlingOutputReference CustomRequestHandling
        {
            get => GetInstanceProperty<aws.Wafv2WebAcl.Wafv2WebAclRuleActionChallengeCustomRequestHandlingOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "customRequestHandlingInput", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclRuleActionChallengeCustomRequestHandling\"}", isOptional: true)]
        public virtual aws.Wafv2WebAcl.IWafv2WebAclRuleActionChallengeCustomRequestHandling? CustomRequestHandlingInput
        {
            get => GetInstanceProperty<aws.Wafv2WebAcl.IWafv2WebAclRuleActionChallengeCustomRequestHandling?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclRuleActionChallenge\"}", isOptional: true)]
        public virtual aws.Wafv2WebAcl.IWafv2WebAclRuleActionChallenge? InternalValue
        {
            get => GetInstanceProperty<aws.Wafv2WebAcl.IWafv2WebAclRuleActionChallenge?>();
            set => SetInstanceProperty(value);
        }
    }
}

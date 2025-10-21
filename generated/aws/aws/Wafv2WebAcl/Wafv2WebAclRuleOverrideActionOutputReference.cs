using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAcl
{
    [JsiiClass(nativeType: typeof(aws.Wafv2WebAcl.Wafv2WebAclRuleOverrideActionOutputReference), fullyQualifiedName: "aws.wafv2WebAcl.Wafv2WebAclRuleOverrideActionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class Wafv2WebAclRuleOverrideActionOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public Wafv2WebAclRuleOverrideActionOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected Wafv2WebAclRuleOverrideActionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Wafv2WebAclRuleOverrideActionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCount", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclRuleOverrideActionCount\"}}]")]
        public virtual void PutCount(aws.Wafv2WebAcl.IWafv2WebAclRuleOverrideActionCount @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2WebAcl.IWafv2WebAclRuleOverrideActionCount)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNone", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclRuleOverrideActionNone\"}}]")]
        public virtual void PutNone(aws.Wafv2WebAcl.IWafv2WebAclRuleOverrideActionNone @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2WebAcl.IWafv2WebAclRuleOverrideActionNone)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCount")]
        public virtual void ResetCount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNone")]
        public virtual void ResetNone()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "count", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclRuleOverrideActionCountOutputReference\"}")]
        public virtual aws.Wafv2WebAcl.Wafv2WebAclRuleOverrideActionCountOutputReference Count
        {
            get => GetInstanceProperty<aws.Wafv2WebAcl.Wafv2WebAclRuleOverrideActionCountOutputReference>()!;
        }

        [JsiiProperty(name: "none", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclRuleOverrideActionNoneOutputReference\"}")]
        public virtual aws.Wafv2WebAcl.Wafv2WebAclRuleOverrideActionNoneOutputReference None
        {
            get => GetInstanceProperty<aws.Wafv2WebAcl.Wafv2WebAclRuleOverrideActionNoneOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "countInput", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclRuleOverrideActionCount\"}", isOptional: true)]
        public virtual aws.Wafv2WebAcl.IWafv2WebAclRuleOverrideActionCount? CountInput
        {
            get => GetInstanceProperty<aws.Wafv2WebAcl.IWafv2WebAclRuleOverrideActionCount?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "noneInput", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclRuleOverrideActionNone\"}", isOptional: true)]
        public virtual aws.Wafv2WebAcl.IWafv2WebAclRuleOverrideActionNone? NoneInput
        {
            get => GetInstanceProperty<aws.Wafv2WebAcl.IWafv2WebAclRuleOverrideActionNone?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclRuleOverrideAction\"}", isOptional: true)]
        public virtual aws.Wafv2WebAcl.IWafv2WebAclRuleOverrideAction? InternalValue
        {
            get => GetInstanceProperty<aws.Wafv2WebAcl.IWafv2WebAclRuleOverrideAction?>();
            set => SetInstanceProperty(value);
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAcl
{
    [JsiiClass(nativeType: typeof(aws.Wafv2WebAcl.Wafv2WebAclChallengeConfigOutputReference), fullyQualifiedName: "aws.wafv2WebAcl.Wafv2WebAclChallengeConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class Wafv2WebAclChallengeConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public Wafv2WebAclChallengeConfigOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected Wafv2WebAclChallengeConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Wafv2WebAclChallengeConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putImmunityTimeProperty", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclChallengeConfigImmunityTimeProperty\"}}]")]
        public virtual void PutImmunityTimeProperty(aws.Wafv2WebAcl.IWafv2WebAclChallengeConfigImmunityTimeProperty @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2WebAcl.IWafv2WebAclChallengeConfigImmunityTimeProperty)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetImmunityTimeProperty")]
        public virtual void ResetImmunityTimeProperty()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "immunityTimeProperty", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclChallengeConfigImmunityTimePropertyOutputReference\"}")]
        public virtual aws.Wafv2WebAcl.Wafv2WebAclChallengeConfigImmunityTimePropertyOutputReference ImmunityTimeProperty
        {
            get => GetInstanceProperty<aws.Wafv2WebAcl.Wafv2WebAclChallengeConfigImmunityTimePropertyOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "immunityTimePropertyInput", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclChallengeConfigImmunityTimeProperty\"}", isOptional: true)]
        public virtual aws.Wafv2WebAcl.IWafv2WebAclChallengeConfigImmunityTimeProperty? ImmunityTimePropertyInput
        {
            get => GetInstanceProperty<aws.Wafv2WebAcl.IWafv2WebAclChallengeConfigImmunityTimeProperty?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclChallengeConfig\"}", isOptional: true)]
        public virtual aws.Wafv2WebAcl.IWafv2WebAclChallengeConfig? InternalValue
        {
            get => GetInstanceProperty<aws.Wafv2WebAcl.IWafv2WebAclChallengeConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}

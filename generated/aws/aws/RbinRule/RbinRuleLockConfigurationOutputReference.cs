using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.RbinRule
{
    [JsiiClass(nativeType: typeof(aws.RbinRule.RbinRuleLockConfigurationOutputReference), fullyQualifiedName: "aws.rbinRule.RbinRuleLockConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class RbinRuleLockConfigurationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public RbinRuleLockConfigurationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected RbinRuleLockConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected RbinRuleLockConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putUnlockDelay", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.rbinRule.RbinRuleLockConfigurationUnlockDelay\"}}]")]
        public virtual void PutUnlockDelay(aws.RbinRule.IRbinRuleLockConfigurationUnlockDelay @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.RbinRule.IRbinRuleLockConfigurationUnlockDelay)}, new object[]{@value});
        }

        [JsiiProperty(name: "unlockDelay", typeJson: "{\"fqn\":\"aws.rbinRule.RbinRuleLockConfigurationUnlockDelayOutputReference\"}")]
        public virtual aws.RbinRule.RbinRuleLockConfigurationUnlockDelayOutputReference UnlockDelay
        {
            get => GetInstanceProperty<aws.RbinRule.RbinRuleLockConfigurationUnlockDelayOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "unlockDelayInput", typeJson: "{\"fqn\":\"aws.rbinRule.RbinRuleLockConfigurationUnlockDelay\"}", isOptional: true)]
        public virtual aws.RbinRule.IRbinRuleLockConfigurationUnlockDelay? UnlockDelayInput
        {
            get => GetInstanceProperty<aws.RbinRule.IRbinRuleLockConfigurationUnlockDelay?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.rbinRule.RbinRuleLockConfiguration\"}", isOptional: true)]
        public virtual aws.RbinRule.IRbinRuleLockConfiguration? InternalValue
        {
            get => GetInstanceProperty<aws.RbinRule.IRbinRuleLockConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}

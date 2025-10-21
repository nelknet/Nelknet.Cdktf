using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.RbinRule
{
    [JsiiClass(nativeType: typeof(aws.RbinRule.RbinRuleLockConfigurationUnlockDelayOutputReference), fullyQualifiedName: "aws.rbinRule.RbinRuleLockConfigurationUnlockDelayOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class RbinRuleLockConfigurationUnlockDelayOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public RbinRuleLockConfigurationUnlockDelayOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected RbinRuleLockConfigurationUnlockDelayOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected RbinRuleLockConfigurationUnlockDelayOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "unlockDelayUnitInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UnlockDelayUnitInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "unlockDelayValueInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? UnlockDelayValueInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "unlockDelayUnit", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UnlockDelayUnit
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "unlockDelayValue", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double UnlockDelayValue
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.rbinRule.RbinRuleLockConfigurationUnlockDelay\"}", isOptional: true)]
        public virtual aws.RbinRule.IRbinRuleLockConfigurationUnlockDelay? InternalValue
        {
            get => GetInstanceProperty<aws.RbinRule.IRbinRuleLockConfigurationUnlockDelay?>();
            set => SetInstanceProperty(value);
        }
    }
}

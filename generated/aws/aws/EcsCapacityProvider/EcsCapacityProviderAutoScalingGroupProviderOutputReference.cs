using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsCapacityProvider
{
    [JsiiClass(nativeType: typeof(aws.EcsCapacityProvider.EcsCapacityProviderAutoScalingGroupProviderOutputReference), fullyQualifiedName: "aws.ecsCapacityProvider.EcsCapacityProviderAutoScalingGroupProviderOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class EcsCapacityProviderAutoScalingGroupProviderOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public EcsCapacityProviderAutoScalingGroupProviderOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected EcsCapacityProviderAutoScalingGroupProviderOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EcsCapacityProviderAutoScalingGroupProviderOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putManagedScaling", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ecsCapacityProvider.EcsCapacityProviderAutoScalingGroupProviderManagedScaling\"}}]")]
        public virtual void PutManagedScaling(aws.EcsCapacityProvider.IEcsCapacityProviderAutoScalingGroupProviderManagedScaling @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.EcsCapacityProvider.IEcsCapacityProviderAutoScalingGroupProviderManagedScaling)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetManagedDraining")]
        public virtual void ResetManagedDraining()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetManagedScaling")]
        public virtual void ResetManagedScaling()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetManagedTerminationProtection")]
        public virtual void ResetManagedTerminationProtection()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "managedScaling", typeJson: "{\"fqn\":\"aws.ecsCapacityProvider.EcsCapacityProviderAutoScalingGroupProviderManagedScalingOutputReference\"}")]
        public virtual aws.EcsCapacityProvider.EcsCapacityProviderAutoScalingGroupProviderManagedScalingOutputReference ManagedScaling
        {
            get => GetInstanceProperty<aws.EcsCapacityProvider.EcsCapacityProviderAutoScalingGroupProviderManagedScalingOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "autoScalingGroupArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AutoScalingGroupArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "managedDrainingInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ManagedDrainingInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "managedScalingInput", typeJson: "{\"fqn\":\"aws.ecsCapacityProvider.EcsCapacityProviderAutoScalingGroupProviderManagedScaling\"}", isOptional: true)]
        public virtual aws.EcsCapacityProvider.IEcsCapacityProviderAutoScalingGroupProviderManagedScaling? ManagedScalingInput
        {
            get => GetInstanceProperty<aws.EcsCapacityProvider.IEcsCapacityProviderAutoScalingGroupProviderManagedScaling?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "managedTerminationProtectionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ManagedTerminationProtectionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "autoScalingGroupArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AutoScalingGroupArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "managedDraining", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ManagedDraining
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "managedTerminationProtection", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ManagedTerminationProtection
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.ecsCapacityProvider.EcsCapacityProviderAutoScalingGroupProvider\"}", isOptional: true)]
        public virtual aws.EcsCapacityProvider.IEcsCapacityProviderAutoScalingGroupProvider? InternalValue
        {
            get => GetInstanceProperty<aws.EcsCapacityProvider.IEcsCapacityProviderAutoScalingGroupProvider?>();
            set => SetInstanceProperty(value);
        }
    }
}

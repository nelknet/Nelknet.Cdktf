using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AutoscalingGroup
{
    [JsiiClass(nativeType: typeof(aws.AutoscalingGroup.AutoscalingGroupAvailabilityZoneDistributionOutputReference), fullyQualifiedName: "aws.autoscalingGroup.AutoscalingGroupAvailabilityZoneDistributionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AutoscalingGroupAvailabilityZoneDistributionOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AutoscalingGroupAvailabilityZoneDistributionOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AutoscalingGroupAvailabilityZoneDistributionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AutoscalingGroupAvailabilityZoneDistributionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetCapacityDistributionStrategy")]
        public virtual void ResetCapacityDistributionStrategy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "capacityDistributionStrategyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CapacityDistributionStrategyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "capacityDistributionStrategy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CapacityDistributionStrategy
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.autoscalingGroup.AutoscalingGroupAvailabilityZoneDistribution\"}", isOptional: true)]
        public virtual aws.AutoscalingGroup.IAutoscalingGroupAvailabilityZoneDistribution? InternalValue
        {
            get => GetInstanceProperty<aws.AutoscalingGroup.IAutoscalingGroupAvailabilityZoneDistribution?>();
            set => SetInstanceProperty(value);
        }
    }
}

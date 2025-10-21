using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AutoscalingGroup
{
    [JsiiInterface(nativeType: typeof(IAutoscalingGroupAvailabilityZoneDistribution), fullyQualifiedName: "aws.autoscalingGroup.AutoscalingGroupAvailabilityZoneDistribution")]
    public interface IAutoscalingGroupAvailabilityZoneDistribution
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#capacity_distribution_strategy AutoscalingGroup#capacity_distribution_strategy}.</summary>
        [JsiiProperty(name: "capacityDistributionStrategy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CapacityDistributionStrategy
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAutoscalingGroupAvailabilityZoneDistribution), fullyQualifiedName: "aws.autoscalingGroup.AutoscalingGroupAvailabilityZoneDistribution")]
        internal sealed class _Proxy : DeputyBase, aws.AutoscalingGroup.IAutoscalingGroupAvailabilityZoneDistribution
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#capacity_distribution_strategy AutoscalingGroup#capacity_distribution_strategy}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "capacityDistributionStrategy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CapacityDistributionStrategy
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

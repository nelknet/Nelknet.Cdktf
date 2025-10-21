using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AutoscalingGroup
{
    [JsiiByValue(fqn: "aws.autoscalingGroup.AutoscalingGroupAvailabilityZoneDistribution")]
    public class AutoscalingGroupAvailabilityZoneDistribution : aws.AutoscalingGroup.IAutoscalingGroupAvailabilityZoneDistribution
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#capacity_distribution_strategy AutoscalingGroup#capacity_distribution_strategy}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "capacityDistributionStrategy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CapacityDistributionStrategy
        {
            get;
            set;
        }
    }
}

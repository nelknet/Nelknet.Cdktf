using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AutoscalingGroup
{
    [JsiiByValue(fqn: "aws.autoscalingGroup.AutoscalingGroupMixedInstancesPolicyInstancesDistribution")]
    public class AutoscalingGroupMixedInstancesPolicyInstancesDistribution : aws.AutoscalingGroup.IAutoscalingGroupMixedInstancesPolicyInstancesDistribution
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#on_demand_allocation_strategy AutoscalingGroup#on_demand_allocation_strategy}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "onDemandAllocationStrategy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OnDemandAllocationStrategy
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#on_demand_base_capacity AutoscalingGroup#on_demand_base_capacity}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "onDemandBaseCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? OnDemandBaseCapacity
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#on_demand_percentage_above_base_capacity AutoscalingGroup#on_demand_percentage_above_base_capacity}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "onDemandPercentageAboveBaseCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? OnDemandPercentageAboveBaseCapacity
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#spot_allocation_strategy AutoscalingGroup#spot_allocation_strategy}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "spotAllocationStrategy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SpotAllocationStrategy
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#spot_instance_pools AutoscalingGroup#spot_instance_pools}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "spotInstancePools", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? SpotInstancePools
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#spot_max_price AutoscalingGroup#spot_max_price}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "spotMaxPrice", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SpotMaxPrice
        {
            get;
            set;
        }
    }
}

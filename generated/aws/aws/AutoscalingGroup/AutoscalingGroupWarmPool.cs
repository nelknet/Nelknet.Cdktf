using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AutoscalingGroup
{
    [JsiiByValue(fqn: "aws.autoscalingGroup.AutoscalingGroupWarmPool")]
    public class AutoscalingGroupWarmPool : aws.AutoscalingGroup.IAutoscalingGroupWarmPool
    {
        /// <summary>instance_reuse_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#instance_reuse_policy AutoscalingGroup#instance_reuse_policy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "instanceReusePolicy", typeJson: "{\"fqn\":\"aws.autoscalingGroup.AutoscalingGroupWarmPoolInstanceReusePolicy\"}", isOptional: true)]
        public aws.AutoscalingGroup.IAutoscalingGroupWarmPoolInstanceReusePolicy? InstanceReusePolicy
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#max_group_prepared_capacity AutoscalingGroup#max_group_prepared_capacity}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxGroupPreparedCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxGroupPreparedCapacity
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#min_size AutoscalingGroup#min_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "minSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MinSize
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#pool_state AutoscalingGroup#pool_state}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "poolState", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PoolState
        {
            get;
            set;
        }
    }
}

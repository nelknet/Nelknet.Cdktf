using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AutoscalingGroup
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.autoscalingGroup.AutoscalingGroupMixedInstancesPolicy")]
    public class AutoscalingGroupMixedInstancesPolicy : aws.AutoscalingGroup.IAutoscalingGroupMixedInstancesPolicy
    {
        /// <summary>launch_template block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#launch_template AutoscalingGroup#launch_template}
        /// </remarks>
        [JsiiProperty(name: "launchTemplate", typeJson: "{\"fqn\":\"aws.autoscalingGroup.AutoscalingGroupMixedInstancesPolicyLaunchTemplate\"}")]
        public aws.AutoscalingGroup.IAutoscalingGroupMixedInstancesPolicyLaunchTemplate LaunchTemplate
        {
            get;
            set;
        }

        /// <summary>instances_distribution block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#instances_distribution AutoscalingGroup#instances_distribution}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "instancesDistribution", typeJson: "{\"fqn\":\"aws.autoscalingGroup.AutoscalingGroupMixedInstancesPolicyInstancesDistribution\"}", isOptional: true)]
        public aws.AutoscalingGroup.IAutoscalingGroupMixedInstancesPolicyInstancesDistribution? InstancesDistribution
        {
            get;
            set;
        }
    }
}

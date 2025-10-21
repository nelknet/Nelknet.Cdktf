using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AutoscalingGroup
{
    [JsiiInterface(nativeType: typeof(IAutoscalingGroupMixedInstancesPolicy), fullyQualifiedName: "aws.autoscalingGroup.AutoscalingGroupMixedInstancesPolicy")]
    public interface IAutoscalingGroupMixedInstancesPolicy
    {
        /// <summary>launch_template block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#launch_template AutoscalingGroup#launch_template}
        /// </remarks>
        [JsiiProperty(name: "launchTemplate", typeJson: "{\"fqn\":\"aws.autoscalingGroup.AutoscalingGroupMixedInstancesPolicyLaunchTemplate\"}")]
        aws.AutoscalingGroup.IAutoscalingGroupMixedInstancesPolicyLaunchTemplate LaunchTemplate
        {
            get;
        }

        /// <summary>instances_distribution block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#instances_distribution AutoscalingGroup#instances_distribution}
        /// </remarks>
        [JsiiProperty(name: "instancesDistribution", typeJson: "{\"fqn\":\"aws.autoscalingGroup.AutoscalingGroupMixedInstancesPolicyInstancesDistribution\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AutoscalingGroup.IAutoscalingGroupMixedInstancesPolicyInstancesDistribution? InstancesDistribution
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAutoscalingGroupMixedInstancesPolicy), fullyQualifiedName: "aws.autoscalingGroup.AutoscalingGroupMixedInstancesPolicy")]
        internal sealed class _Proxy : DeputyBase, aws.AutoscalingGroup.IAutoscalingGroupMixedInstancesPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>launch_template block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#launch_template AutoscalingGroup#launch_template}
            /// </remarks>
            [JsiiProperty(name: "launchTemplate", typeJson: "{\"fqn\":\"aws.autoscalingGroup.AutoscalingGroupMixedInstancesPolicyLaunchTemplate\"}")]
            public aws.AutoscalingGroup.IAutoscalingGroupMixedInstancesPolicyLaunchTemplate LaunchTemplate
            {
                get => GetInstanceProperty<aws.AutoscalingGroup.IAutoscalingGroupMixedInstancesPolicyLaunchTemplate>()!;
            }

            /// <summary>instances_distribution block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#instances_distribution AutoscalingGroup#instances_distribution}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "instancesDistribution", typeJson: "{\"fqn\":\"aws.autoscalingGroup.AutoscalingGroupMixedInstancesPolicyInstancesDistribution\"}", isOptional: true)]
            public aws.AutoscalingGroup.IAutoscalingGroupMixedInstancesPolicyInstancesDistribution? InstancesDistribution
            {
                get => GetInstanceProperty<aws.AutoscalingGroup.IAutoscalingGroupMixedInstancesPolicyInstancesDistribution?>();
            }
        }
    }
}

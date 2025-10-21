using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AutoscalingGroup
{
    [JsiiInterface(nativeType: typeof(IAutoscalingGroupMixedInstancesPolicyLaunchTemplateOverride), fullyQualifiedName: "aws.autoscalingGroup.AutoscalingGroupMixedInstancesPolicyLaunchTemplateOverride")]
    public interface IAutoscalingGroupMixedInstancesPolicyLaunchTemplateOverride
    {
        /// <summary>instance_requirements block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#instance_requirements AutoscalingGroup#instance_requirements}
        /// </remarks>
        [JsiiProperty(name: "instanceRequirements", typeJson: "{\"fqn\":\"aws.autoscalingGroup.AutoscalingGroupMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirements\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AutoscalingGroup.IAutoscalingGroupMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirements? InstanceRequirements
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#instance_type AutoscalingGroup#instance_type}.</summary>
        [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InstanceType
        {
            get
            {
                return null;
            }
        }

        /// <summary>launch_template_specification block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#launch_template_specification AutoscalingGroup#launch_template_specification}
        /// </remarks>
        [JsiiProperty(name: "launchTemplateSpecification", typeJson: "{\"fqn\":\"aws.autoscalingGroup.AutoscalingGroupMixedInstancesPolicyLaunchTemplateOverrideLaunchTemplateSpecification\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AutoscalingGroup.IAutoscalingGroupMixedInstancesPolicyLaunchTemplateOverrideLaunchTemplateSpecification? LaunchTemplateSpecification
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#weighted_capacity AutoscalingGroup#weighted_capacity}.</summary>
        [JsiiProperty(name: "weightedCapacity", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? WeightedCapacity
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAutoscalingGroupMixedInstancesPolicyLaunchTemplateOverride), fullyQualifiedName: "aws.autoscalingGroup.AutoscalingGroupMixedInstancesPolicyLaunchTemplateOverride")]
        internal sealed class _Proxy : DeputyBase, aws.AutoscalingGroup.IAutoscalingGroupMixedInstancesPolicyLaunchTemplateOverride
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>instance_requirements block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#instance_requirements AutoscalingGroup#instance_requirements}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "instanceRequirements", typeJson: "{\"fqn\":\"aws.autoscalingGroup.AutoscalingGroupMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirements\"}", isOptional: true)]
            public aws.AutoscalingGroup.IAutoscalingGroupMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirements? InstanceRequirements
            {
                get => GetInstanceProperty<aws.AutoscalingGroup.IAutoscalingGroupMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirements?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#instance_type AutoscalingGroup#instance_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InstanceType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>launch_template_specification block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#launch_template_specification AutoscalingGroup#launch_template_specification}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "launchTemplateSpecification", typeJson: "{\"fqn\":\"aws.autoscalingGroup.AutoscalingGroupMixedInstancesPolicyLaunchTemplateOverrideLaunchTemplateSpecification\"}", isOptional: true)]
            public aws.AutoscalingGroup.IAutoscalingGroupMixedInstancesPolicyLaunchTemplateOverrideLaunchTemplateSpecification? LaunchTemplateSpecification
            {
                get => GetInstanceProperty<aws.AutoscalingGroup.IAutoscalingGroupMixedInstancesPolicyLaunchTemplateOverrideLaunchTemplateSpecification?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#weighted_capacity AutoscalingGroup#weighted_capacity}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "weightedCapacity", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? WeightedCapacity
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

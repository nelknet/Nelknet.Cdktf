using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsCapacityProvider
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ecsCapacityProvider.EcsCapacityProviderAutoScalingGroupProvider")]
    public class EcsCapacityProviderAutoScalingGroupProvider : aws.EcsCapacityProvider.IEcsCapacityProviderAutoScalingGroupProvider
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_capacity_provider#auto_scaling_group_arn EcsCapacityProvider#auto_scaling_group_arn}.</summary>
        [JsiiProperty(name: "autoScalingGroupArn", typeJson: "{\"primitive\":\"string\"}")]
        public string AutoScalingGroupArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_capacity_provider#managed_draining EcsCapacityProvider#managed_draining}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "managedDraining", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ManagedDraining
        {
            get;
            set;
        }

        /// <summary>managed_scaling block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_capacity_provider#managed_scaling EcsCapacityProvider#managed_scaling}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "managedScaling", typeJson: "{\"fqn\":\"aws.ecsCapacityProvider.EcsCapacityProviderAutoScalingGroupProviderManagedScaling\"}", isOptional: true)]
        public aws.EcsCapacityProvider.IEcsCapacityProviderAutoScalingGroupProviderManagedScaling? ManagedScaling
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_capacity_provider#managed_termination_protection EcsCapacityProvider#managed_termination_protection}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "managedTerminationProtection", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ManagedTerminationProtection
        {
            get;
            set;
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsCapacityProvider
{
    [JsiiInterface(nativeType: typeof(IEcsCapacityProviderAutoScalingGroupProvider), fullyQualifiedName: "aws.ecsCapacityProvider.EcsCapacityProviderAutoScalingGroupProvider")]
    public interface IEcsCapacityProviderAutoScalingGroupProvider
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_capacity_provider#auto_scaling_group_arn EcsCapacityProvider#auto_scaling_group_arn}.</summary>
        [JsiiProperty(name: "autoScalingGroupArn", typeJson: "{\"primitive\":\"string\"}")]
        string AutoScalingGroupArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_capacity_provider#managed_draining EcsCapacityProvider#managed_draining}.</summary>
        [JsiiProperty(name: "managedDraining", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ManagedDraining
        {
            get
            {
                return null;
            }
        }

        /// <summary>managed_scaling block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_capacity_provider#managed_scaling EcsCapacityProvider#managed_scaling}
        /// </remarks>
        [JsiiProperty(name: "managedScaling", typeJson: "{\"fqn\":\"aws.ecsCapacityProvider.EcsCapacityProviderAutoScalingGroupProviderManagedScaling\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.EcsCapacityProvider.IEcsCapacityProviderAutoScalingGroupProviderManagedScaling? ManagedScaling
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_capacity_provider#managed_termination_protection EcsCapacityProvider#managed_termination_protection}.</summary>
        [JsiiProperty(name: "managedTerminationProtection", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ManagedTerminationProtection
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEcsCapacityProviderAutoScalingGroupProvider), fullyQualifiedName: "aws.ecsCapacityProvider.EcsCapacityProviderAutoScalingGroupProvider")]
        internal sealed class _Proxy : DeputyBase, aws.EcsCapacityProvider.IEcsCapacityProviderAutoScalingGroupProvider
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_capacity_provider#auto_scaling_group_arn EcsCapacityProvider#auto_scaling_group_arn}.</summary>
            [JsiiProperty(name: "autoScalingGroupArn", typeJson: "{\"primitive\":\"string\"}")]
            public string AutoScalingGroupArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_capacity_provider#managed_draining EcsCapacityProvider#managed_draining}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "managedDraining", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ManagedDraining
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>managed_scaling block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_capacity_provider#managed_scaling EcsCapacityProvider#managed_scaling}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "managedScaling", typeJson: "{\"fqn\":\"aws.ecsCapacityProvider.EcsCapacityProviderAutoScalingGroupProviderManagedScaling\"}", isOptional: true)]
            public aws.EcsCapacityProvider.IEcsCapacityProviderAutoScalingGroupProviderManagedScaling? ManagedScaling
            {
                get => GetInstanceProperty<aws.EcsCapacityProvider.IEcsCapacityProviderAutoScalingGroupProviderManagedScaling?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_capacity_provider#managed_termination_protection EcsCapacityProvider#managed_termination_protection}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "managedTerminationProtection", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ManagedTerminationProtection
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

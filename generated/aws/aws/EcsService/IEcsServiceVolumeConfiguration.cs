using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsService
{
    [JsiiInterface(nativeType: typeof(IEcsServiceVolumeConfiguration), fullyQualifiedName: "aws.ecsService.EcsServiceVolumeConfiguration")]
    public interface IEcsServiceVolumeConfiguration
    {
        /// <summary>managed_ebs_volume block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service#managed_ebs_volume EcsService#managed_ebs_volume}
        /// </remarks>
        [JsiiProperty(name: "managedEbsVolume", typeJson: "{\"fqn\":\"aws.ecsService.EcsServiceVolumeConfigurationManagedEbsVolume\"}")]
        aws.EcsService.IEcsServiceVolumeConfigurationManagedEbsVolume ManagedEbsVolume
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service#name EcsService#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IEcsServiceVolumeConfiguration), fullyQualifiedName: "aws.ecsService.EcsServiceVolumeConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.EcsService.IEcsServiceVolumeConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>managed_ebs_volume block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service#managed_ebs_volume EcsService#managed_ebs_volume}
            /// </remarks>
            [JsiiProperty(name: "managedEbsVolume", typeJson: "{\"fqn\":\"aws.ecsService.EcsServiceVolumeConfigurationManagedEbsVolume\"}")]
            public aws.EcsService.IEcsServiceVolumeConfigurationManagedEbsVolume ManagedEbsVolume
            {
                get => GetInstanceProperty<aws.EcsService.IEcsServiceVolumeConfigurationManagedEbsVolume>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service#name EcsService#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}

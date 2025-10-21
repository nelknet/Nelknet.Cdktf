using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsTaskDefinition
{
    [JsiiInterface(nativeType: typeof(IEcsTaskDefinitionVolumeFsxWindowsFileServerVolumeConfiguration), fullyQualifiedName: "aws.ecsTaskDefinition.EcsTaskDefinitionVolumeFsxWindowsFileServerVolumeConfiguration")]
    public interface IEcsTaskDefinitionVolumeFsxWindowsFileServerVolumeConfiguration
    {
        /// <summary>authorization_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_task_definition#authorization_config EcsTaskDefinition#authorization_config}
        /// </remarks>
        [JsiiProperty(name: "authorizationConfig", typeJson: "{\"fqn\":\"aws.ecsTaskDefinition.EcsTaskDefinitionVolumeFsxWindowsFileServerVolumeConfigurationAuthorizationConfig\"}")]
        aws.EcsTaskDefinition.IEcsTaskDefinitionVolumeFsxWindowsFileServerVolumeConfigurationAuthorizationConfig AuthorizationConfig
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_task_definition#file_system_id EcsTaskDefinition#file_system_id}.</summary>
        [JsiiProperty(name: "fileSystemId", typeJson: "{\"primitive\":\"string\"}")]
        string FileSystemId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_task_definition#root_directory EcsTaskDefinition#root_directory}.</summary>
        [JsiiProperty(name: "rootDirectory", typeJson: "{\"primitive\":\"string\"}")]
        string RootDirectory
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IEcsTaskDefinitionVolumeFsxWindowsFileServerVolumeConfiguration), fullyQualifiedName: "aws.ecsTaskDefinition.EcsTaskDefinitionVolumeFsxWindowsFileServerVolumeConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.EcsTaskDefinition.IEcsTaskDefinitionVolumeFsxWindowsFileServerVolumeConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>authorization_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_task_definition#authorization_config EcsTaskDefinition#authorization_config}
            /// </remarks>
            [JsiiProperty(name: "authorizationConfig", typeJson: "{\"fqn\":\"aws.ecsTaskDefinition.EcsTaskDefinitionVolumeFsxWindowsFileServerVolumeConfigurationAuthorizationConfig\"}")]
            public aws.EcsTaskDefinition.IEcsTaskDefinitionVolumeFsxWindowsFileServerVolumeConfigurationAuthorizationConfig AuthorizationConfig
            {
                get => GetInstanceProperty<aws.EcsTaskDefinition.IEcsTaskDefinitionVolumeFsxWindowsFileServerVolumeConfigurationAuthorizationConfig>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_task_definition#file_system_id EcsTaskDefinition#file_system_id}.</summary>
            [JsiiProperty(name: "fileSystemId", typeJson: "{\"primitive\":\"string\"}")]
            public string FileSystemId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_task_definition#root_directory EcsTaskDefinition#root_directory}.</summary>
            [JsiiProperty(name: "rootDirectory", typeJson: "{\"primitive\":\"string\"}")]
            public string RootDirectory
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}

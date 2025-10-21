using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsTaskDefinition
{
    [JsiiInterface(nativeType: typeof(IEcsTaskDefinitionVolume), fullyQualifiedName: "aws.ecsTaskDefinition.EcsTaskDefinitionVolume")]
    public interface IEcsTaskDefinitionVolume
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_task_definition#name EcsTaskDefinition#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_task_definition#configure_at_launch EcsTaskDefinition#configure_at_launch}.</summary>
        [JsiiProperty(name: "configureAtLaunch", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ConfigureAtLaunch
        {
            get
            {
                return null;
            }
        }

        /// <summary>docker_volume_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_task_definition#docker_volume_configuration EcsTaskDefinition#docker_volume_configuration}
        /// </remarks>
        [JsiiProperty(name: "dockerVolumeConfiguration", typeJson: "{\"fqn\":\"aws.ecsTaskDefinition.EcsTaskDefinitionVolumeDockerVolumeConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.EcsTaskDefinition.IEcsTaskDefinitionVolumeDockerVolumeConfiguration? DockerVolumeConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>efs_volume_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_task_definition#efs_volume_configuration EcsTaskDefinition#efs_volume_configuration}
        /// </remarks>
        [JsiiProperty(name: "efsVolumeConfiguration", typeJson: "{\"fqn\":\"aws.ecsTaskDefinition.EcsTaskDefinitionVolumeEfsVolumeConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.EcsTaskDefinition.IEcsTaskDefinitionVolumeEfsVolumeConfiguration? EfsVolumeConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>fsx_windows_file_server_volume_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_task_definition#fsx_windows_file_server_volume_configuration EcsTaskDefinition#fsx_windows_file_server_volume_configuration}
        /// </remarks>
        [JsiiProperty(name: "fsxWindowsFileServerVolumeConfiguration", typeJson: "{\"fqn\":\"aws.ecsTaskDefinition.EcsTaskDefinitionVolumeFsxWindowsFileServerVolumeConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.EcsTaskDefinition.IEcsTaskDefinitionVolumeFsxWindowsFileServerVolumeConfiguration? FsxWindowsFileServerVolumeConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_task_definition#host_path EcsTaskDefinition#host_path}.</summary>
        [JsiiProperty(name: "hostPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HostPath
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEcsTaskDefinitionVolume), fullyQualifiedName: "aws.ecsTaskDefinition.EcsTaskDefinitionVolume")]
        internal sealed class _Proxy : DeputyBase, aws.EcsTaskDefinition.IEcsTaskDefinitionVolume
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_task_definition#name EcsTaskDefinition#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_task_definition#configure_at_launch EcsTaskDefinition#configure_at_launch}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "configureAtLaunch", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? ConfigureAtLaunch
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>docker_volume_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_task_definition#docker_volume_configuration EcsTaskDefinition#docker_volume_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dockerVolumeConfiguration", typeJson: "{\"fqn\":\"aws.ecsTaskDefinition.EcsTaskDefinitionVolumeDockerVolumeConfiguration\"}", isOptional: true)]
            public aws.EcsTaskDefinition.IEcsTaskDefinitionVolumeDockerVolumeConfiguration? DockerVolumeConfiguration
            {
                get => GetInstanceProperty<aws.EcsTaskDefinition.IEcsTaskDefinitionVolumeDockerVolumeConfiguration?>();
            }

            /// <summary>efs_volume_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_task_definition#efs_volume_configuration EcsTaskDefinition#efs_volume_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "efsVolumeConfiguration", typeJson: "{\"fqn\":\"aws.ecsTaskDefinition.EcsTaskDefinitionVolumeEfsVolumeConfiguration\"}", isOptional: true)]
            public aws.EcsTaskDefinition.IEcsTaskDefinitionVolumeEfsVolumeConfiguration? EfsVolumeConfiguration
            {
                get => GetInstanceProperty<aws.EcsTaskDefinition.IEcsTaskDefinitionVolumeEfsVolumeConfiguration?>();
            }

            /// <summary>fsx_windows_file_server_volume_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_task_definition#fsx_windows_file_server_volume_configuration EcsTaskDefinition#fsx_windows_file_server_volume_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fsxWindowsFileServerVolumeConfiguration", typeJson: "{\"fqn\":\"aws.ecsTaskDefinition.EcsTaskDefinitionVolumeFsxWindowsFileServerVolumeConfiguration\"}", isOptional: true)]
            public aws.EcsTaskDefinition.IEcsTaskDefinitionVolumeFsxWindowsFileServerVolumeConfiguration? FsxWindowsFileServerVolumeConfiguration
            {
                get => GetInstanceProperty<aws.EcsTaskDefinition.IEcsTaskDefinitionVolumeFsxWindowsFileServerVolumeConfiguration?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_task_definition#host_path EcsTaskDefinition#host_path}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "hostPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HostPath
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

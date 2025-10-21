using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsTaskDefinition
{
    [JsiiInterface(nativeType: typeof(IEcsTaskDefinitionVolumeFsxWindowsFileServerVolumeConfigurationAuthorizationConfig), fullyQualifiedName: "aws.ecsTaskDefinition.EcsTaskDefinitionVolumeFsxWindowsFileServerVolumeConfigurationAuthorizationConfig")]
    public interface IEcsTaskDefinitionVolumeFsxWindowsFileServerVolumeConfigurationAuthorizationConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_task_definition#credentials_parameter EcsTaskDefinition#credentials_parameter}.</summary>
        [JsiiProperty(name: "credentialsParameter", typeJson: "{\"primitive\":\"string\"}")]
        string CredentialsParameter
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_task_definition#domain EcsTaskDefinition#domain}.</summary>
        [JsiiProperty(name: "domain", typeJson: "{\"primitive\":\"string\"}")]
        string Domain
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IEcsTaskDefinitionVolumeFsxWindowsFileServerVolumeConfigurationAuthorizationConfig), fullyQualifiedName: "aws.ecsTaskDefinition.EcsTaskDefinitionVolumeFsxWindowsFileServerVolumeConfigurationAuthorizationConfig")]
        internal sealed class _Proxy : DeputyBase, aws.EcsTaskDefinition.IEcsTaskDefinitionVolumeFsxWindowsFileServerVolumeConfigurationAuthorizationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_task_definition#credentials_parameter EcsTaskDefinition#credentials_parameter}.</summary>
            [JsiiProperty(name: "credentialsParameter", typeJson: "{\"primitive\":\"string\"}")]
            public string CredentialsParameter
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_task_definition#domain EcsTaskDefinition#domain}.</summary>
            [JsiiProperty(name: "domain", typeJson: "{\"primitive\":\"string\"}")]
            public string Domain
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}

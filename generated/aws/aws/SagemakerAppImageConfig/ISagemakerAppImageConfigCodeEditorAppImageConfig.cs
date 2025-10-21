using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerAppImageConfig
{
    [JsiiInterface(nativeType: typeof(ISagemakerAppImageConfigCodeEditorAppImageConfig), fullyQualifiedName: "aws.sagemakerAppImageConfig.SagemakerAppImageConfigCodeEditorAppImageConfig")]
    public interface ISagemakerAppImageConfigCodeEditorAppImageConfig
    {
        /// <summary>container_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_app_image_config#container_config SagemakerAppImageConfig#container_config}
        /// </remarks>
        [JsiiProperty(name: "containerConfig", typeJson: "{\"fqn\":\"aws.sagemakerAppImageConfig.SagemakerAppImageConfigCodeEditorAppImageConfigContainerConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SagemakerAppImageConfig.ISagemakerAppImageConfigCodeEditorAppImageConfigContainerConfig? ContainerConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>file_system_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_app_image_config#file_system_config SagemakerAppImageConfig#file_system_config}
        /// </remarks>
        [JsiiProperty(name: "fileSystemConfig", typeJson: "{\"fqn\":\"aws.sagemakerAppImageConfig.SagemakerAppImageConfigCodeEditorAppImageConfigFileSystemConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SagemakerAppImageConfig.ISagemakerAppImageConfigCodeEditorAppImageConfigFileSystemConfig? FileSystemConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerAppImageConfigCodeEditorAppImageConfig), fullyQualifiedName: "aws.sagemakerAppImageConfig.SagemakerAppImageConfigCodeEditorAppImageConfig")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerAppImageConfig.ISagemakerAppImageConfigCodeEditorAppImageConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>container_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_app_image_config#container_config SagemakerAppImageConfig#container_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "containerConfig", typeJson: "{\"fqn\":\"aws.sagemakerAppImageConfig.SagemakerAppImageConfigCodeEditorAppImageConfigContainerConfig\"}", isOptional: true)]
            public aws.SagemakerAppImageConfig.ISagemakerAppImageConfigCodeEditorAppImageConfigContainerConfig? ContainerConfig
            {
                get => GetInstanceProperty<aws.SagemakerAppImageConfig.ISagemakerAppImageConfigCodeEditorAppImageConfigContainerConfig?>();
            }

            /// <summary>file_system_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_app_image_config#file_system_config SagemakerAppImageConfig#file_system_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fileSystemConfig", typeJson: "{\"fqn\":\"aws.sagemakerAppImageConfig.SagemakerAppImageConfigCodeEditorAppImageConfigFileSystemConfig\"}", isOptional: true)]
            public aws.SagemakerAppImageConfig.ISagemakerAppImageConfigCodeEditorAppImageConfigFileSystemConfig? FileSystemConfig
            {
                get => GetInstanceProperty<aws.SagemakerAppImageConfig.ISagemakerAppImageConfigCodeEditorAppImageConfigFileSystemConfig?>();
            }
        }
    }
}

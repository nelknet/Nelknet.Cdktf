using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerAppImageConfig
{
    [JsiiInterface(nativeType: typeof(ISagemakerAppImageConfigKernelGatewayImageConfig), fullyQualifiedName: "aws.sagemakerAppImageConfig.SagemakerAppImageConfigKernelGatewayImageConfig")]
    public interface ISagemakerAppImageConfigKernelGatewayImageConfig
    {
        /// <summary>kernel_spec block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_app_image_config#kernel_spec SagemakerAppImageConfig#kernel_spec}
        /// </remarks>
        [JsiiProperty(name: "kernelSpec", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerAppImageConfig.SagemakerAppImageConfigKernelGatewayImageConfigKernelSpec\"},\"kind\":\"array\"}}]}}")]
        object KernelSpec
        {
            get;
        }

        /// <summary>file_system_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_app_image_config#file_system_config SagemakerAppImageConfig#file_system_config}
        /// </remarks>
        [JsiiProperty(name: "fileSystemConfig", typeJson: "{\"fqn\":\"aws.sagemakerAppImageConfig.SagemakerAppImageConfigKernelGatewayImageConfigFileSystemConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SagemakerAppImageConfig.ISagemakerAppImageConfigKernelGatewayImageConfigFileSystemConfig? FileSystemConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerAppImageConfigKernelGatewayImageConfig), fullyQualifiedName: "aws.sagemakerAppImageConfig.SagemakerAppImageConfigKernelGatewayImageConfig")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerAppImageConfig.ISagemakerAppImageConfigKernelGatewayImageConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>kernel_spec block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_app_image_config#kernel_spec SagemakerAppImageConfig#kernel_spec}
            /// </remarks>
            [JsiiProperty(name: "kernelSpec", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerAppImageConfig.SagemakerAppImageConfigKernelGatewayImageConfigKernelSpec\"},\"kind\":\"array\"}}]}}")]
            public object KernelSpec
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>file_system_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_app_image_config#file_system_config SagemakerAppImageConfig#file_system_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fileSystemConfig", typeJson: "{\"fqn\":\"aws.sagemakerAppImageConfig.SagemakerAppImageConfigKernelGatewayImageConfigFileSystemConfig\"}", isOptional: true)]
            public aws.SagemakerAppImageConfig.ISagemakerAppImageConfigKernelGatewayImageConfigFileSystemConfig? FileSystemConfig
            {
                get => GetInstanceProperty<aws.SagemakerAppImageConfig.ISagemakerAppImageConfigKernelGatewayImageConfigFileSystemConfig?>();
            }
        }
    }
}

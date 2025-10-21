using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerAppImageConfig
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemakerAppImageConfig.SagemakerAppImageConfigKernelGatewayImageConfig")]
    public class SagemakerAppImageConfigKernelGatewayImageConfig : aws.SagemakerAppImageConfig.ISagemakerAppImageConfigKernelGatewayImageConfig
    {
        private object _kernelSpec;

        /// <summary>kernel_spec block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_app_image_config#kernel_spec SagemakerAppImageConfig#kernel_spec}
        /// </remarks>
        [JsiiProperty(name: "kernelSpec", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerAppImageConfig.SagemakerAppImageConfigKernelGatewayImageConfigKernelSpec\"},\"kind\":\"array\"}}]}}")]
        public object KernelSpec
        {
            get => _kernelSpec;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SagemakerAppImageConfig.ISagemakerAppImageConfigKernelGatewayImageConfigKernelSpec[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SagemakerAppImageConfig.ISagemakerAppImageConfigKernelGatewayImageConfigKernelSpec).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SagemakerAppImageConfig.ISagemakerAppImageConfigKernelGatewayImageConfigKernelSpec).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _kernelSpec = value;
            }
        }

        /// <summary>file_system_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_app_image_config#file_system_config SagemakerAppImageConfig#file_system_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fileSystemConfig", typeJson: "{\"fqn\":\"aws.sagemakerAppImageConfig.SagemakerAppImageConfigKernelGatewayImageConfigFileSystemConfig\"}", isOptional: true)]
        public aws.SagemakerAppImageConfig.ISagemakerAppImageConfigKernelGatewayImageConfigFileSystemConfig? FileSystemConfig
        {
            get;
            set;
        }
    }
}

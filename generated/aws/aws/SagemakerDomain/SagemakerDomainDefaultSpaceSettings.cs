using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerDomain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemakerDomain.SagemakerDomainDefaultSpaceSettings")]
    public class SagemakerDomainDefaultSpaceSettings : aws.SagemakerDomain.ISagemakerDomainDefaultSpaceSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#execution_role SagemakerDomain#execution_role}.</summary>
        [JsiiProperty(name: "executionRole", typeJson: "{\"primitive\":\"string\"}")]
        public string ExecutionRole
        {
            get;
            set;
        }

        private object? _customFileSystemConfig;

        /// <summary>custom_file_system_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#custom_file_system_config SagemakerDomain#custom_file_system_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "customFileSystemConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultSpaceSettingsCustomFileSystemConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CustomFileSystemConfig
        {
            get => _customFileSystemConfig;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SagemakerDomain.ISagemakerDomainDefaultSpaceSettingsCustomFileSystemConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SagemakerDomain.ISagemakerDomainDefaultSpaceSettingsCustomFileSystemConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _customFileSystemConfig = value;
            }
        }

        /// <summary>custom_posix_user_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#custom_posix_user_config SagemakerDomain#custom_posix_user_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "customPosixUserConfig", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultSpaceSettingsCustomPosixUserConfig\"}", isOptional: true)]
        public aws.SagemakerDomain.ISagemakerDomainDefaultSpaceSettingsCustomPosixUserConfig? CustomPosixUserConfig
        {
            get;
            set;
        }

        /// <summary>jupyter_lab_app_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#jupyter_lab_app_settings SagemakerDomain#jupyter_lab_app_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "jupyterLabAppSettings", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultSpaceSettingsJupyterLabAppSettings\"}", isOptional: true)]
        public aws.SagemakerDomain.ISagemakerDomainDefaultSpaceSettingsJupyterLabAppSettings? JupyterLabAppSettings
        {
            get;
            set;
        }

        /// <summary>jupyter_server_app_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#jupyter_server_app_settings SagemakerDomain#jupyter_server_app_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "jupyterServerAppSettings", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultSpaceSettingsJupyterServerAppSettings\"}", isOptional: true)]
        public aws.SagemakerDomain.ISagemakerDomainDefaultSpaceSettingsJupyterServerAppSettings? JupyterServerAppSettings
        {
            get;
            set;
        }

        /// <summary>kernel_gateway_app_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#kernel_gateway_app_settings SagemakerDomain#kernel_gateway_app_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "kernelGatewayAppSettings", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultSpaceSettingsKernelGatewayAppSettings\"}", isOptional: true)]
        public aws.SagemakerDomain.ISagemakerDomainDefaultSpaceSettingsKernelGatewayAppSettings? KernelGatewayAppSettings
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#security_groups SagemakerDomain#security_groups}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "securityGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? SecurityGroups
        {
            get;
            set;
        }

        /// <summary>space_storage_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#space_storage_settings SagemakerDomain#space_storage_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "spaceStorageSettings", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultSpaceSettingsSpaceStorageSettings\"}", isOptional: true)]
        public aws.SagemakerDomain.ISagemakerDomainDefaultSpaceSettingsSpaceStorageSettings? SpaceStorageSettings
        {
            get;
            set;
        }
    }
}

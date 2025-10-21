using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerSpace
{
    [JsiiByValue(fqn: "aws.sagemakerSpace.SagemakerSpaceSpaceSettings")]
    public class SagemakerSpaceSpaceSettings : aws.SagemakerSpace.ISagemakerSpaceSpaceSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_space#app_type SagemakerSpace#app_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "appType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AppType
        {
            get;
            set;
        }

        /// <summary>code_editor_app_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_space#code_editor_app_settings SagemakerSpace#code_editor_app_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "codeEditorAppSettings", typeJson: "{\"fqn\":\"aws.sagemakerSpace.SagemakerSpaceSpaceSettingsCodeEditorAppSettings\"}", isOptional: true)]
        public aws.SagemakerSpace.ISagemakerSpaceSpaceSettingsCodeEditorAppSettings? CodeEditorAppSettings
        {
            get;
            set;
        }

        private object? _customFileSystem;

        /// <summary>custom_file_system block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_space#custom_file_system SagemakerSpace#custom_file_system}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "customFileSystem", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerSpace.SagemakerSpaceSpaceSettingsCustomFileSystem\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CustomFileSystem
        {
            get => _customFileSystem;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SagemakerSpace.ISagemakerSpaceSpaceSettingsCustomFileSystem[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SagemakerSpace.ISagemakerSpaceSpaceSettingsCustomFileSystem).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _customFileSystem = value;
            }
        }

        /// <summary>jupyter_lab_app_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_space#jupyter_lab_app_settings SagemakerSpace#jupyter_lab_app_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "jupyterLabAppSettings", typeJson: "{\"fqn\":\"aws.sagemakerSpace.SagemakerSpaceSpaceSettingsJupyterLabAppSettings\"}", isOptional: true)]
        public aws.SagemakerSpace.ISagemakerSpaceSpaceSettingsJupyterLabAppSettings? JupyterLabAppSettings
        {
            get;
            set;
        }

        /// <summary>jupyter_server_app_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_space#jupyter_server_app_settings SagemakerSpace#jupyter_server_app_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "jupyterServerAppSettings", typeJson: "{\"fqn\":\"aws.sagemakerSpace.SagemakerSpaceSpaceSettingsJupyterServerAppSettings\"}", isOptional: true)]
        public aws.SagemakerSpace.ISagemakerSpaceSpaceSettingsJupyterServerAppSettings? JupyterServerAppSettings
        {
            get;
            set;
        }

        /// <summary>kernel_gateway_app_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_space#kernel_gateway_app_settings SagemakerSpace#kernel_gateway_app_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "kernelGatewayAppSettings", typeJson: "{\"fqn\":\"aws.sagemakerSpace.SagemakerSpaceSpaceSettingsKernelGatewayAppSettings\"}", isOptional: true)]
        public aws.SagemakerSpace.ISagemakerSpaceSpaceSettingsKernelGatewayAppSettings? KernelGatewayAppSettings
        {
            get;
            set;
        }

        /// <summary>space_storage_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_space#space_storage_settings SagemakerSpace#space_storage_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "spaceStorageSettings", typeJson: "{\"fqn\":\"aws.sagemakerSpace.SagemakerSpaceSpaceSettingsSpaceStorageSettings\"}", isOptional: true)]
        public aws.SagemakerSpace.ISagemakerSpaceSpaceSettingsSpaceStorageSettings? SpaceStorageSettings
        {
            get;
            set;
        }
    }
}

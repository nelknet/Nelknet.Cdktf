using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerSpace
{
    [JsiiInterface(nativeType: typeof(ISagemakerSpaceSpaceSettings), fullyQualifiedName: "aws.sagemakerSpace.SagemakerSpaceSpaceSettings")]
    public interface ISagemakerSpaceSpaceSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_space#app_type SagemakerSpace#app_type}.</summary>
        [JsiiProperty(name: "appType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AppType
        {
            get
            {
                return null;
            }
        }

        /// <summary>code_editor_app_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_space#code_editor_app_settings SagemakerSpace#code_editor_app_settings}
        /// </remarks>
        [JsiiProperty(name: "codeEditorAppSettings", typeJson: "{\"fqn\":\"aws.sagemakerSpace.SagemakerSpaceSpaceSettingsCodeEditorAppSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SagemakerSpace.ISagemakerSpaceSpaceSettingsCodeEditorAppSettings? CodeEditorAppSettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>custom_file_system block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_space#custom_file_system SagemakerSpace#custom_file_system}
        /// </remarks>
        [JsiiProperty(name: "customFileSystem", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerSpace.SagemakerSpaceSpaceSettingsCustomFileSystem\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CustomFileSystem
        {
            get
            {
                return null;
            }
        }

        /// <summary>jupyter_lab_app_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_space#jupyter_lab_app_settings SagemakerSpace#jupyter_lab_app_settings}
        /// </remarks>
        [JsiiProperty(name: "jupyterLabAppSettings", typeJson: "{\"fqn\":\"aws.sagemakerSpace.SagemakerSpaceSpaceSettingsJupyterLabAppSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SagemakerSpace.ISagemakerSpaceSpaceSettingsJupyterLabAppSettings? JupyterLabAppSettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>jupyter_server_app_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_space#jupyter_server_app_settings SagemakerSpace#jupyter_server_app_settings}
        /// </remarks>
        [JsiiProperty(name: "jupyterServerAppSettings", typeJson: "{\"fqn\":\"aws.sagemakerSpace.SagemakerSpaceSpaceSettingsJupyterServerAppSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SagemakerSpace.ISagemakerSpaceSpaceSettingsJupyterServerAppSettings? JupyterServerAppSettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>kernel_gateway_app_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_space#kernel_gateway_app_settings SagemakerSpace#kernel_gateway_app_settings}
        /// </remarks>
        [JsiiProperty(name: "kernelGatewayAppSettings", typeJson: "{\"fqn\":\"aws.sagemakerSpace.SagemakerSpaceSpaceSettingsKernelGatewayAppSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SagemakerSpace.ISagemakerSpaceSpaceSettingsKernelGatewayAppSettings? KernelGatewayAppSettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>space_storage_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_space#space_storage_settings SagemakerSpace#space_storage_settings}
        /// </remarks>
        [JsiiProperty(name: "spaceStorageSettings", typeJson: "{\"fqn\":\"aws.sagemakerSpace.SagemakerSpaceSpaceSettingsSpaceStorageSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SagemakerSpace.ISagemakerSpaceSpaceSettingsSpaceStorageSettings? SpaceStorageSettings
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerSpaceSpaceSettings), fullyQualifiedName: "aws.sagemakerSpace.SagemakerSpaceSpaceSettings")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerSpace.ISagemakerSpaceSpaceSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_space#app_type SagemakerSpace#app_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "appType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AppType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>code_editor_app_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_space#code_editor_app_settings SagemakerSpace#code_editor_app_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "codeEditorAppSettings", typeJson: "{\"fqn\":\"aws.sagemakerSpace.SagemakerSpaceSpaceSettingsCodeEditorAppSettings\"}", isOptional: true)]
            public aws.SagemakerSpace.ISagemakerSpaceSpaceSettingsCodeEditorAppSettings? CodeEditorAppSettings
            {
                get => GetInstanceProperty<aws.SagemakerSpace.ISagemakerSpaceSpaceSettingsCodeEditorAppSettings?>();
            }

            /// <summary>custom_file_system block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_space#custom_file_system SagemakerSpace#custom_file_system}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customFileSystem", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerSpace.SagemakerSpaceSpaceSettingsCustomFileSystem\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CustomFileSystem
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>jupyter_lab_app_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_space#jupyter_lab_app_settings SagemakerSpace#jupyter_lab_app_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "jupyterLabAppSettings", typeJson: "{\"fqn\":\"aws.sagemakerSpace.SagemakerSpaceSpaceSettingsJupyterLabAppSettings\"}", isOptional: true)]
            public aws.SagemakerSpace.ISagemakerSpaceSpaceSettingsJupyterLabAppSettings? JupyterLabAppSettings
            {
                get => GetInstanceProperty<aws.SagemakerSpace.ISagemakerSpaceSpaceSettingsJupyterLabAppSettings?>();
            }

            /// <summary>jupyter_server_app_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_space#jupyter_server_app_settings SagemakerSpace#jupyter_server_app_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "jupyterServerAppSettings", typeJson: "{\"fqn\":\"aws.sagemakerSpace.SagemakerSpaceSpaceSettingsJupyterServerAppSettings\"}", isOptional: true)]
            public aws.SagemakerSpace.ISagemakerSpaceSpaceSettingsJupyterServerAppSettings? JupyterServerAppSettings
            {
                get => GetInstanceProperty<aws.SagemakerSpace.ISagemakerSpaceSpaceSettingsJupyterServerAppSettings?>();
            }

            /// <summary>kernel_gateway_app_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_space#kernel_gateway_app_settings SagemakerSpace#kernel_gateway_app_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "kernelGatewayAppSettings", typeJson: "{\"fqn\":\"aws.sagemakerSpace.SagemakerSpaceSpaceSettingsKernelGatewayAppSettings\"}", isOptional: true)]
            public aws.SagemakerSpace.ISagemakerSpaceSpaceSettingsKernelGatewayAppSettings? KernelGatewayAppSettings
            {
                get => GetInstanceProperty<aws.SagemakerSpace.ISagemakerSpaceSpaceSettingsKernelGatewayAppSettings?>();
            }

            /// <summary>space_storage_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_space#space_storage_settings SagemakerSpace#space_storage_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "spaceStorageSettings", typeJson: "{\"fqn\":\"aws.sagemakerSpace.SagemakerSpaceSpaceSettingsSpaceStorageSettings\"}", isOptional: true)]
            public aws.SagemakerSpace.ISagemakerSpaceSpaceSettingsSpaceStorageSettings? SpaceStorageSettings
            {
                get => GetInstanceProperty<aws.SagemakerSpace.ISagemakerSpaceSpaceSettingsSpaceStorageSettings?>();
            }
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerUserProfile
{
    [JsiiInterface(nativeType: typeof(ISagemakerUserProfileUserSettings), fullyQualifiedName: "aws.sagemakerUserProfile.SagemakerUserProfileUserSettings")]
    public interface ISagemakerUserProfileUserSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_user_profile#execution_role SagemakerUserProfile#execution_role}.</summary>
        [JsiiProperty(name: "executionRole", typeJson: "{\"primitive\":\"string\"}")]
        string ExecutionRole
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_user_profile#auto_mount_home_efs SagemakerUserProfile#auto_mount_home_efs}.</summary>
        [JsiiProperty(name: "autoMountHomeEfs", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AutoMountHomeEfs
        {
            get
            {
                return null;
            }
        }

        /// <summary>canvas_app_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_user_profile#canvas_app_settings SagemakerUserProfile#canvas_app_settings}
        /// </remarks>
        [JsiiProperty(name: "canvasAppSettings", typeJson: "{\"fqn\":\"aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsCanvasAppSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsCanvasAppSettings? CanvasAppSettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>code_editor_app_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_user_profile#code_editor_app_settings SagemakerUserProfile#code_editor_app_settings}
        /// </remarks>
        [JsiiProperty(name: "codeEditorAppSettings", typeJson: "{\"fqn\":\"aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsCodeEditorAppSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsCodeEditorAppSettings? CodeEditorAppSettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>custom_file_system_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_user_profile#custom_file_system_config SagemakerUserProfile#custom_file_system_config}
        /// </remarks>
        [JsiiProperty(name: "customFileSystemConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsCustomFileSystemConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CustomFileSystemConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>custom_posix_user_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_user_profile#custom_posix_user_config SagemakerUserProfile#custom_posix_user_config}
        /// </remarks>
        [JsiiProperty(name: "customPosixUserConfig", typeJson: "{\"fqn\":\"aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsCustomPosixUserConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsCustomPosixUserConfig? CustomPosixUserConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_user_profile#default_landing_uri SagemakerUserProfile#default_landing_uri}.</summary>
        [JsiiProperty(name: "defaultLandingUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DefaultLandingUri
        {
            get
            {
                return null;
            }
        }

        /// <summary>jupyter_lab_app_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_user_profile#jupyter_lab_app_settings SagemakerUserProfile#jupyter_lab_app_settings}
        /// </remarks>
        [JsiiProperty(name: "jupyterLabAppSettings", typeJson: "{\"fqn\":\"aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsJupyterLabAppSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsJupyterLabAppSettings? JupyterLabAppSettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>jupyter_server_app_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_user_profile#jupyter_server_app_settings SagemakerUserProfile#jupyter_server_app_settings}
        /// </remarks>
        [JsiiProperty(name: "jupyterServerAppSettings", typeJson: "{\"fqn\":\"aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsJupyterServerAppSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsJupyterServerAppSettings? JupyterServerAppSettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>kernel_gateway_app_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_user_profile#kernel_gateway_app_settings SagemakerUserProfile#kernel_gateway_app_settings}
        /// </remarks>
        [JsiiProperty(name: "kernelGatewayAppSettings", typeJson: "{\"fqn\":\"aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsKernelGatewayAppSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsKernelGatewayAppSettings? KernelGatewayAppSettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>r_session_app_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_user_profile#r_session_app_settings SagemakerUserProfile#r_session_app_settings}
        /// </remarks>
        [JsiiProperty(name: "rSessionAppSettings", typeJson: "{\"fqn\":\"aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsRSessionAppSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsRSessionAppSettings? RSessionAppSettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>r_studio_server_pro_app_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_user_profile#r_studio_server_pro_app_settings SagemakerUserProfile#r_studio_server_pro_app_settings}
        /// </remarks>
        [JsiiProperty(name: "rStudioServerProAppSettings", typeJson: "{\"fqn\":\"aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsRStudioServerProAppSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsRStudioServerProAppSettings? RStudioServerProAppSettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_user_profile#security_groups SagemakerUserProfile#security_groups}.</summary>
        [JsiiProperty(name: "securityGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? SecurityGroups
        {
            get
            {
                return null;
            }
        }

        /// <summary>sharing_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_user_profile#sharing_settings SagemakerUserProfile#sharing_settings}
        /// </remarks>
        [JsiiProperty(name: "sharingSettings", typeJson: "{\"fqn\":\"aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsSharingSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsSharingSettings? SharingSettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>space_storage_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_user_profile#space_storage_settings SagemakerUserProfile#space_storage_settings}
        /// </remarks>
        [JsiiProperty(name: "spaceStorageSettings", typeJson: "{\"fqn\":\"aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsSpaceStorageSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsSpaceStorageSettings? SpaceStorageSettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_user_profile#studio_web_portal SagemakerUserProfile#studio_web_portal}.</summary>
        [JsiiProperty(name: "studioWebPortal", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StudioWebPortal
        {
            get
            {
                return null;
            }
        }

        /// <summary>studio_web_portal_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_user_profile#studio_web_portal_settings SagemakerUserProfile#studio_web_portal_settings}
        /// </remarks>
        [JsiiProperty(name: "studioWebPortalSettings", typeJson: "{\"fqn\":\"aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsStudioWebPortalSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsStudioWebPortalSettings? StudioWebPortalSettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>tensor_board_app_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_user_profile#tensor_board_app_settings SagemakerUserProfile#tensor_board_app_settings}
        /// </remarks>
        [JsiiProperty(name: "tensorBoardAppSettings", typeJson: "{\"fqn\":\"aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsTensorBoardAppSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsTensorBoardAppSettings? TensorBoardAppSettings
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerUserProfileUserSettings), fullyQualifiedName: "aws.sagemakerUserProfile.SagemakerUserProfileUserSettings")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerUserProfile.ISagemakerUserProfileUserSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_user_profile#execution_role SagemakerUserProfile#execution_role}.</summary>
            [JsiiProperty(name: "executionRole", typeJson: "{\"primitive\":\"string\"}")]
            public string ExecutionRole
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_user_profile#auto_mount_home_efs SagemakerUserProfile#auto_mount_home_efs}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "autoMountHomeEfs", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AutoMountHomeEfs
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>canvas_app_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_user_profile#canvas_app_settings SagemakerUserProfile#canvas_app_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "canvasAppSettings", typeJson: "{\"fqn\":\"aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsCanvasAppSettings\"}", isOptional: true)]
            public aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsCanvasAppSettings? CanvasAppSettings
            {
                get => GetInstanceProperty<aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsCanvasAppSettings?>();
            }

            /// <summary>code_editor_app_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_user_profile#code_editor_app_settings SagemakerUserProfile#code_editor_app_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "codeEditorAppSettings", typeJson: "{\"fqn\":\"aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsCodeEditorAppSettings\"}", isOptional: true)]
            public aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsCodeEditorAppSettings? CodeEditorAppSettings
            {
                get => GetInstanceProperty<aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsCodeEditorAppSettings?>();
            }

            /// <summary>custom_file_system_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_user_profile#custom_file_system_config SagemakerUserProfile#custom_file_system_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customFileSystemConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsCustomFileSystemConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CustomFileSystemConfig
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>custom_posix_user_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_user_profile#custom_posix_user_config SagemakerUserProfile#custom_posix_user_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customPosixUserConfig", typeJson: "{\"fqn\":\"aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsCustomPosixUserConfig\"}", isOptional: true)]
            public aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsCustomPosixUserConfig? CustomPosixUserConfig
            {
                get => GetInstanceProperty<aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsCustomPosixUserConfig?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_user_profile#default_landing_uri SagemakerUserProfile#default_landing_uri}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "defaultLandingUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DefaultLandingUri
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>jupyter_lab_app_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_user_profile#jupyter_lab_app_settings SagemakerUserProfile#jupyter_lab_app_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "jupyterLabAppSettings", typeJson: "{\"fqn\":\"aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsJupyterLabAppSettings\"}", isOptional: true)]
            public aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsJupyterLabAppSettings? JupyterLabAppSettings
            {
                get => GetInstanceProperty<aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsJupyterLabAppSettings?>();
            }

            /// <summary>jupyter_server_app_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_user_profile#jupyter_server_app_settings SagemakerUserProfile#jupyter_server_app_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "jupyterServerAppSettings", typeJson: "{\"fqn\":\"aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsJupyterServerAppSettings\"}", isOptional: true)]
            public aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsJupyterServerAppSettings? JupyterServerAppSettings
            {
                get => GetInstanceProperty<aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsJupyterServerAppSettings?>();
            }

            /// <summary>kernel_gateway_app_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_user_profile#kernel_gateway_app_settings SagemakerUserProfile#kernel_gateway_app_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "kernelGatewayAppSettings", typeJson: "{\"fqn\":\"aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsKernelGatewayAppSettings\"}", isOptional: true)]
            public aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsKernelGatewayAppSettings? KernelGatewayAppSettings
            {
                get => GetInstanceProperty<aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsKernelGatewayAppSettings?>();
            }

            /// <summary>r_session_app_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_user_profile#r_session_app_settings SagemakerUserProfile#r_session_app_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "rSessionAppSettings", typeJson: "{\"fqn\":\"aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsRSessionAppSettings\"}", isOptional: true)]
            public aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsRSessionAppSettings? RSessionAppSettings
            {
                get => GetInstanceProperty<aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsRSessionAppSettings?>();
            }

            /// <summary>r_studio_server_pro_app_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_user_profile#r_studio_server_pro_app_settings SagemakerUserProfile#r_studio_server_pro_app_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "rStudioServerProAppSettings", typeJson: "{\"fqn\":\"aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsRStudioServerProAppSettings\"}", isOptional: true)]
            public aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsRStudioServerProAppSettings? RStudioServerProAppSettings
            {
                get => GetInstanceProperty<aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsRStudioServerProAppSettings?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_user_profile#security_groups SagemakerUserProfile#security_groups}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "securityGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? SecurityGroups
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>sharing_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_user_profile#sharing_settings SagemakerUserProfile#sharing_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sharingSettings", typeJson: "{\"fqn\":\"aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsSharingSettings\"}", isOptional: true)]
            public aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsSharingSettings? SharingSettings
            {
                get => GetInstanceProperty<aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsSharingSettings?>();
            }

            /// <summary>space_storage_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_user_profile#space_storage_settings SagemakerUserProfile#space_storage_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "spaceStorageSettings", typeJson: "{\"fqn\":\"aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsSpaceStorageSettings\"}", isOptional: true)]
            public aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsSpaceStorageSettings? SpaceStorageSettings
            {
                get => GetInstanceProperty<aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsSpaceStorageSettings?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_user_profile#studio_web_portal SagemakerUserProfile#studio_web_portal}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "studioWebPortal", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StudioWebPortal
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>studio_web_portal_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_user_profile#studio_web_portal_settings SagemakerUserProfile#studio_web_portal_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "studioWebPortalSettings", typeJson: "{\"fqn\":\"aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsStudioWebPortalSettings\"}", isOptional: true)]
            public aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsStudioWebPortalSettings? StudioWebPortalSettings
            {
                get => GetInstanceProperty<aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsStudioWebPortalSettings?>();
            }

            /// <summary>tensor_board_app_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_user_profile#tensor_board_app_settings SagemakerUserProfile#tensor_board_app_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tensorBoardAppSettings", typeJson: "{\"fqn\":\"aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsTensorBoardAppSettings\"}", isOptional: true)]
            public aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsTensorBoardAppSettings? TensorBoardAppSettings
            {
                get => GetInstanceProperty<aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsTensorBoardAppSettings?>();
            }
        }
    }
}

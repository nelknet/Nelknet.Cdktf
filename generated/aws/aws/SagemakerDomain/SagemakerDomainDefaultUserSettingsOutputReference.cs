using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerDomain
{
    [JsiiClass(nativeType: typeof(aws.SagemakerDomain.SagemakerDomainDefaultUserSettingsOutputReference), fullyQualifiedName: "aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SagemakerDomainDefaultUserSettingsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SagemakerDomainDefaultUserSettingsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerDomainDefaultUserSettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerDomainDefaultUserSettingsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCanvasAppSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsCanvasAppSettings\"}}]")]
        public virtual void PutCanvasAppSettings(aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCanvasAppSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCanvasAppSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCodeEditorAppSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsCodeEditorAppSettings\"}}]")]
        public virtual void PutCodeEditorAppSettings(aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCodeEditorAppSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCodeEditorAppSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCustomFileSystemConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsCustomFileSystemConfig\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutCustomFileSystemConfig(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCustomFileSystemConfig[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCustomFileSystemConfig).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCustomFileSystemConfig).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCustomPosixUserConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsCustomPosixUserConfig\"}}]")]
        public virtual void PutCustomPosixUserConfig(aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCustomPosixUserConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCustomPosixUserConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putJupyterLabAppSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsJupyterLabAppSettings\"}}]")]
        public virtual void PutJupyterLabAppSettings(aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsJupyterLabAppSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsJupyterLabAppSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "putJupyterServerAppSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsJupyterServerAppSettings\"}}]")]
        public virtual void PutJupyterServerAppSettings(aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsJupyterServerAppSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsJupyterServerAppSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "putKernelGatewayAppSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsKernelGatewayAppSettings\"}}]")]
        public virtual void PutKernelGatewayAppSettings(aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsKernelGatewayAppSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsKernelGatewayAppSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRSessionAppSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsRSessionAppSettings\"}}]")]
        public virtual void PutRSessionAppSettings(aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsRSessionAppSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsRSessionAppSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRStudioServerProAppSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsRStudioServerProAppSettings\"}}]")]
        public virtual void PutRStudioServerProAppSettings(aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsRStudioServerProAppSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsRStudioServerProAppSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSharingSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsSharingSettings\"}}]")]
        public virtual void PutSharingSettings(aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsSharingSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsSharingSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSpaceStorageSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsSpaceStorageSettings\"}}]")]
        public virtual void PutSpaceStorageSettings(aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsSpaceStorageSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsSpaceStorageSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStudioWebPortalSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsStudioWebPortalSettings\"}}]")]
        public virtual void PutStudioWebPortalSettings(aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsStudioWebPortalSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsStudioWebPortalSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTensorBoardAppSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsTensorBoardAppSettings\"}}]")]
        public virtual void PutTensorBoardAppSettings(aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsTensorBoardAppSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsTensorBoardAppSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAutoMountHomeEfs")]
        public virtual void ResetAutoMountHomeEfs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCanvasAppSettings")]
        public virtual void ResetCanvasAppSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCodeEditorAppSettings")]
        public virtual void ResetCodeEditorAppSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCustomFileSystemConfig")]
        public virtual void ResetCustomFileSystemConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCustomPosixUserConfig")]
        public virtual void ResetCustomPosixUserConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDefaultLandingUri")]
        public virtual void ResetDefaultLandingUri()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetJupyterLabAppSettings")]
        public virtual void ResetJupyterLabAppSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetJupyterServerAppSettings")]
        public virtual void ResetJupyterServerAppSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKernelGatewayAppSettings")]
        public virtual void ResetKernelGatewayAppSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRSessionAppSettings")]
        public virtual void ResetRSessionAppSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRStudioServerProAppSettings")]
        public virtual void ResetRStudioServerProAppSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecurityGroups")]
        public virtual void ResetSecurityGroups()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSharingSettings")]
        public virtual void ResetSharingSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSpaceStorageSettings")]
        public virtual void ResetSpaceStorageSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStudioWebPortal")]
        public virtual void ResetStudioWebPortal()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStudioWebPortalSettings")]
        public virtual void ResetStudioWebPortalSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTensorBoardAppSettings")]
        public virtual void ResetTensorBoardAppSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "canvasAppSettings", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsCanvasAppSettingsOutputReference\"}")]
        public virtual aws.SagemakerDomain.SagemakerDomainDefaultUserSettingsCanvasAppSettingsOutputReference CanvasAppSettings
        {
            get => GetInstanceProperty<aws.SagemakerDomain.SagemakerDomainDefaultUserSettingsCanvasAppSettingsOutputReference>()!;
        }

        [JsiiProperty(name: "codeEditorAppSettings", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsCodeEditorAppSettingsOutputReference\"}")]
        public virtual aws.SagemakerDomain.SagemakerDomainDefaultUserSettingsCodeEditorAppSettingsOutputReference CodeEditorAppSettings
        {
            get => GetInstanceProperty<aws.SagemakerDomain.SagemakerDomainDefaultUserSettingsCodeEditorAppSettingsOutputReference>()!;
        }

        [JsiiProperty(name: "customFileSystemConfig", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsCustomFileSystemConfigList\"}")]
        public virtual aws.SagemakerDomain.SagemakerDomainDefaultUserSettingsCustomFileSystemConfigList CustomFileSystemConfig
        {
            get => GetInstanceProperty<aws.SagemakerDomain.SagemakerDomainDefaultUserSettingsCustomFileSystemConfigList>()!;
        }

        [JsiiProperty(name: "customPosixUserConfig", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsCustomPosixUserConfigOutputReference\"}")]
        public virtual aws.SagemakerDomain.SagemakerDomainDefaultUserSettingsCustomPosixUserConfigOutputReference CustomPosixUserConfig
        {
            get => GetInstanceProperty<aws.SagemakerDomain.SagemakerDomainDefaultUserSettingsCustomPosixUserConfigOutputReference>()!;
        }

        [JsiiProperty(name: "jupyterLabAppSettings", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsJupyterLabAppSettingsOutputReference\"}")]
        public virtual aws.SagemakerDomain.SagemakerDomainDefaultUserSettingsJupyterLabAppSettingsOutputReference JupyterLabAppSettings
        {
            get => GetInstanceProperty<aws.SagemakerDomain.SagemakerDomainDefaultUserSettingsJupyterLabAppSettingsOutputReference>()!;
        }

        [JsiiProperty(name: "jupyterServerAppSettings", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsJupyterServerAppSettingsOutputReference\"}")]
        public virtual aws.SagemakerDomain.SagemakerDomainDefaultUserSettingsJupyterServerAppSettingsOutputReference JupyterServerAppSettings
        {
            get => GetInstanceProperty<aws.SagemakerDomain.SagemakerDomainDefaultUserSettingsJupyterServerAppSettingsOutputReference>()!;
        }

        [JsiiProperty(name: "kernelGatewayAppSettings", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsKernelGatewayAppSettingsOutputReference\"}")]
        public virtual aws.SagemakerDomain.SagemakerDomainDefaultUserSettingsKernelGatewayAppSettingsOutputReference KernelGatewayAppSettings
        {
            get => GetInstanceProperty<aws.SagemakerDomain.SagemakerDomainDefaultUserSettingsKernelGatewayAppSettingsOutputReference>()!;
        }

        [JsiiProperty(name: "rSessionAppSettings", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsRSessionAppSettingsOutputReference\"}")]
        public virtual aws.SagemakerDomain.SagemakerDomainDefaultUserSettingsRSessionAppSettingsOutputReference RSessionAppSettings
        {
            get => GetInstanceProperty<aws.SagemakerDomain.SagemakerDomainDefaultUserSettingsRSessionAppSettingsOutputReference>()!;
        }

        [JsiiProperty(name: "rStudioServerProAppSettings", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsRStudioServerProAppSettingsOutputReference\"}")]
        public virtual aws.SagemakerDomain.SagemakerDomainDefaultUserSettingsRStudioServerProAppSettingsOutputReference RStudioServerProAppSettings
        {
            get => GetInstanceProperty<aws.SagemakerDomain.SagemakerDomainDefaultUserSettingsRStudioServerProAppSettingsOutputReference>()!;
        }

        [JsiiProperty(name: "sharingSettings", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsSharingSettingsOutputReference\"}")]
        public virtual aws.SagemakerDomain.SagemakerDomainDefaultUserSettingsSharingSettingsOutputReference SharingSettings
        {
            get => GetInstanceProperty<aws.SagemakerDomain.SagemakerDomainDefaultUserSettingsSharingSettingsOutputReference>()!;
        }

        [JsiiProperty(name: "spaceStorageSettings", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsSpaceStorageSettingsOutputReference\"}")]
        public virtual aws.SagemakerDomain.SagemakerDomainDefaultUserSettingsSpaceStorageSettingsOutputReference SpaceStorageSettings
        {
            get => GetInstanceProperty<aws.SagemakerDomain.SagemakerDomainDefaultUserSettingsSpaceStorageSettingsOutputReference>()!;
        }

        [JsiiProperty(name: "studioWebPortalSettings", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsStudioWebPortalSettingsOutputReference\"}")]
        public virtual aws.SagemakerDomain.SagemakerDomainDefaultUserSettingsStudioWebPortalSettingsOutputReference StudioWebPortalSettings
        {
            get => GetInstanceProperty<aws.SagemakerDomain.SagemakerDomainDefaultUserSettingsStudioWebPortalSettingsOutputReference>()!;
        }

        [JsiiProperty(name: "tensorBoardAppSettings", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsTensorBoardAppSettingsOutputReference\"}")]
        public virtual aws.SagemakerDomain.SagemakerDomainDefaultUserSettingsTensorBoardAppSettingsOutputReference TensorBoardAppSettings
        {
            get => GetInstanceProperty<aws.SagemakerDomain.SagemakerDomainDefaultUserSettingsTensorBoardAppSettingsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "autoMountHomeEfsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AutoMountHomeEfsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "canvasAppSettingsInput", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsCanvasAppSettings\"}", isOptional: true)]
        public virtual aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCanvasAppSettings? CanvasAppSettingsInput
        {
            get => GetInstanceProperty<aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCanvasAppSettings?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "codeEditorAppSettingsInput", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsCodeEditorAppSettings\"}", isOptional: true)]
        public virtual aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCodeEditorAppSettings? CodeEditorAppSettingsInput
        {
            get => GetInstanceProperty<aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCodeEditorAppSettings?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "customFileSystemConfigInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsCustomFileSystemConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? CustomFileSystemConfigInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "customPosixUserConfigInput", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsCustomPosixUserConfig\"}", isOptional: true)]
        public virtual aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCustomPosixUserConfig? CustomPosixUserConfigInput
        {
            get => GetInstanceProperty<aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCustomPosixUserConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultLandingUriInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DefaultLandingUriInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "executionRoleInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ExecutionRoleInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "jupyterLabAppSettingsInput", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsJupyterLabAppSettings\"}", isOptional: true)]
        public virtual aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsJupyterLabAppSettings? JupyterLabAppSettingsInput
        {
            get => GetInstanceProperty<aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsJupyterLabAppSettings?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "jupyterServerAppSettingsInput", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsJupyterServerAppSettings\"}", isOptional: true)]
        public virtual aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsJupyterServerAppSettings? JupyterServerAppSettingsInput
        {
            get => GetInstanceProperty<aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsJupyterServerAppSettings?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kernelGatewayAppSettingsInput", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsKernelGatewayAppSettings\"}", isOptional: true)]
        public virtual aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsKernelGatewayAppSettings? KernelGatewayAppSettingsInput
        {
            get => GetInstanceProperty<aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsKernelGatewayAppSettings?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rSessionAppSettingsInput", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsRSessionAppSettings\"}", isOptional: true)]
        public virtual aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsRSessionAppSettings? RSessionAppSettingsInput
        {
            get => GetInstanceProperty<aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsRSessionAppSettings?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rStudioServerProAppSettingsInput", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsRStudioServerProAppSettings\"}", isOptional: true)]
        public virtual aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsRStudioServerProAppSettings? RStudioServerProAppSettingsInput
        {
            get => GetInstanceProperty<aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsRStudioServerProAppSettings?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "securityGroupsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? SecurityGroupsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sharingSettingsInput", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsSharingSettings\"}", isOptional: true)]
        public virtual aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsSharingSettings? SharingSettingsInput
        {
            get => GetInstanceProperty<aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsSharingSettings?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "spaceStorageSettingsInput", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsSpaceStorageSettings\"}", isOptional: true)]
        public virtual aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsSpaceStorageSettings? SpaceStorageSettingsInput
        {
            get => GetInstanceProperty<aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsSpaceStorageSettings?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "studioWebPortalInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StudioWebPortalInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "studioWebPortalSettingsInput", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsStudioWebPortalSettings\"}", isOptional: true)]
        public virtual aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsStudioWebPortalSettings? StudioWebPortalSettingsInput
        {
            get => GetInstanceProperty<aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsStudioWebPortalSettings?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tensorBoardAppSettingsInput", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsTensorBoardAppSettings\"}", isOptional: true)]
        public virtual aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsTensorBoardAppSettings? TensorBoardAppSettingsInput
        {
            get => GetInstanceProperty<aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsTensorBoardAppSettings?>();
        }

        [JsiiProperty(name: "autoMountHomeEfs", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AutoMountHomeEfs
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "defaultLandingUri", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DefaultLandingUri
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "executionRole", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExecutionRole
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "securityGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SecurityGroups
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "studioWebPortal", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StudioWebPortal
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettings\"}", isOptional: true)]
        public virtual aws.SagemakerDomain.ISagemakerDomainDefaultUserSettings? InternalValue
        {
            get => GetInstanceProperty<aws.SagemakerDomain.ISagemakerDomainDefaultUserSettings?>();
            set => SetInstanceProperty(value);
        }
    }
}

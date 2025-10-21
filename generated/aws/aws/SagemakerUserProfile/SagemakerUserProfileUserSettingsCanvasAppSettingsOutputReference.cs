using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerUserProfile
{
    [JsiiClass(nativeType: typeof(aws.SagemakerUserProfile.SagemakerUserProfileUserSettingsCanvasAppSettingsOutputReference), fullyQualifiedName: "aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsCanvasAppSettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SagemakerUserProfileUserSettingsCanvasAppSettingsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SagemakerUserProfileUserSettingsCanvasAppSettingsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected SagemakerUserProfileUserSettingsCanvasAppSettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerUserProfileUserSettingsCanvasAppSettingsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDirectDeploySettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsCanvasAppSettingsDirectDeploySettings\"}}]")]
        public virtual void PutDirectDeploySettings(aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsCanvasAppSettingsDirectDeploySettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsCanvasAppSettingsDirectDeploySettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEmrServerlessSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsCanvasAppSettingsEmrServerlessSettings\"}}]")]
        public virtual void PutEmrServerlessSettings(aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsCanvasAppSettingsEmrServerlessSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsCanvasAppSettingsEmrServerlessSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGenerativeAiSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsCanvasAppSettingsGenerativeAiSettings\"}}]")]
        public virtual void PutGenerativeAiSettings(aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsCanvasAppSettingsGenerativeAiSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsCanvasAppSettingsGenerativeAiSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIdentityProviderOauthSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsCanvasAppSettingsIdentityProviderOauthSettings\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutIdentityProviderOauthSettings(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsCanvasAppSettingsIdentityProviderOauthSettings[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsCanvasAppSettingsIdentityProviderOauthSettings).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsCanvasAppSettingsIdentityProviderOauthSettings).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putKendraSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsCanvasAppSettingsKendraSettings\"}}]")]
        public virtual void PutKendraSettings(aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsCanvasAppSettingsKendraSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsCanvasAppSettingsKendraSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "putModelRegisterSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsCanvasAppSettingsModelRegisterSettings\"}}]")]
        public virtual void PutModelRegisterSettings(aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsCanvasAppSettingsModelRegisterSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsCanvasAppSettingsModelRegisterSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeSeriesForecastingSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsCanvasAppSettingsTimeSeriesForecastingSettings\"}}]")]
        public virtual void PutTimeSeriesForecastingSettings(aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsCanvasAppSettingsTimeSeriesForecastingSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsCanvasAppSettingsTimeSeriesForecastingSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "putWorkspaceSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsCanvasAppSettingsWorkspaceSettings\"}}]")]
        public virtual void PutWorkspaceSettings(aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsCanvasAppSettingsWorkspaceSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsCanvasAppSettingsWorkspaceSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDirectDeploySettings")]
        public virtual void ResetDirectDeploySettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEmrServerlessSettings")]
        public virtual void ResetEmrServerlessSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGenerativeAiSettings")]
        public virtual void ResetGenerativeAiSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIdentityProviderOauthSettings")]
        public virtual void ResetIdentityProviderOauthSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKendraSettings")]
        public virtual void ResetKendraSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetModelRegisterSettings")]
        public virtual void ResetModelRegisterSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeSeriesForecastingSettings")]
        public virtual void ResetTimeSeriesForecastingSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWorkspaceSettings")]
        public virtual void ResetWorkspaceSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "directDeploySettings", typeJson: "{\"fqn\":\"aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsCanvasAppSettingsDirectDeploySettingsOutputReference\"}")]
        public virtual aws.SagemakerUserProfile.SagemakerUserProfileUserSettingsCanvasAppSettingsDirectDeploySettingsOutputReference DirectDeploySettings
        {
            get => GetInstanceProperty<aws.SagemakerUserProfile.SagemakerUserProfileUserSettingsCanvasAppSettingsDirectDeploySettingsOutputReference>()!;
        }

        [JsiiProperty(name: "emrServerlessSettings", typeJson: "{\"fqn\":\"aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsCanvasAppSettingsEmrServerlessSettingsOutputReference\"}")]
        public virtual aws.SagemakerUserProfile.SagemakerUserProfileUserSettingsCanvasAppSettingsEmrServerlessSettingsOutputReference EmrServerlessSettings
        {
            get => GetInstanceProperty<aws.SagemakerUserProfile.SagemakerUserProfileUserSettingsCanvasAppSettingsEmrServerlessSettingsOutputReference>()!;
        }

        [JsiiProperty(name: "generativeAiSettings", typeJson: "{\"fqn\":\"aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsCanvasAppSettingsGenerativeAiSettingsOutputReference\"}")]
        public virtual aws.SagemakerUserProfile.SagemakerUserProfileUserSettingsCanvasAppSettingsGenerativeAiSettingsOutputReference GenerativeAiSettings
        {
            get => GetInstanceProperty<aws.SagemakerUserProfile.SagemakerUserProfileUserSettingsCanvasAppSettingsGenerativeAiSettingsOutputReference>()!;
        }

        [JsiiProperty(name: "identityProviderOauthSettings", typeJson: "{\"fqn\":\"aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsCanvasAppSettingsIdentityProviderOauthSettingsList\"}")]
        public virtual aws.SagemakerUserProfile.SagemakerUserProfileUserSettingsCanvasAppSettingsIdentityProviderOauthSettingsList IdentityProviderOauthSettings
        {
            get => GetInstanceProperty<aws.SagemakerUserProfile.SagemakerUserProfileUserSettingsCanvasAppSettingsIdentityProviderOauthSettingsList>()!;
        }

        [JsiiProperty(name: "kendraSettings", typeJson: "{\"fqn\":\"aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsCanvasAppSettingsKendraSettingsOutputReference\"}")]
        public virtual aws.SagemakerUserProfile.SagemakerUserProfileUserSettingsCanvasAppSettingsKendraSettingsOutputReference KendraSettings
        {
            get => GetInstanceProperty<aws.SagemakerUserProfile.SagemakerUserProfileUserSettingsCanvasAppSettingsKendraSettingsOutputReference>()!;
        }

        [JsiiProperty(name: "modelRegisterSettings", typeJson: "{\"fqn\":\"aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsCanvasAppSettingsModelRegisterSettingsOutputReference\"}")]
        public virtual aws.SagemakerUserProfile.SagemakerUserProfileUserSettingsCanvasAppSettingsModelRegisterSettingsOutputReference ModelRegisterSettings
        {
            get => GetInstanceProperty<aws.SagemakerUserProfile.SagemakerUserProfileUserSettingsCanvasAppSettingsModelRegisterSettingsOutputReference>()!;
        }

        [JsiiProperty(name: "timeSeriesForecastingSettings", typeJson: "{\"fqn\":\"aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsCanvasAppSettingsTimeSeriesForecastingSettingsOutputReference\"}")]
        public virtual aws.SagemakerUserProfile.SagemakerUserProfileUserSettingsCanvasAppSettingsTimeSeriesForecastingSettingsOutputReference TimeSeriesForecastingSettings
        {
            get => GetInstanceProperty<aws.SagemakerUserProfile.SagemakerUserProfileUserSettingsCanvasAppSettingsTimeSeriesForecastingSettingsOutputReference>()!;
        }

        [JsiiProperty(name: "workspaceSettings", typeJson: "{\"fqn\":\"aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsCanvasAppSettingsWorkspaceSettingsOutputReference\"}")]
        public virtual aws.SagemakerUserProfile.SagemakerUserProfileUserSettingsCanvasAppSettingsWorkspaceSettingsOutputReference WorkspaceSettings
        {
            get => GetInstanceProperty<aws.SagemakerUserProfile.SagemakerUserProfileUserSettingsCanvasAppSettingsWorkspaceSettingsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "directDeploySettingsInput", typeJson: "{\"fqn\":\"aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsCanvasAppSettingsDirectDeploySettings\"}", isOptional: true)]
        public virtual aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsCanvasAppSettingsDirectDeploySettings? DirectDeploySettingsInput
        {
            get => GetInstanceProperty<aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsCanvasAppSettingsDirectDeploySettings?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "emrServerlessSettingsInput", typeJson: "{\"fqn\":\"aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsCanvasAppSettingsEmrServerlessSettings\"}", isOptional: true)]
        public virtual aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsCanvasAppSettingsEmrServerlessSettings? EmrServerlessSettingsInput
        {
            get => GetInstanceProperty<aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsCanvasAppSettingsEmrServerlessSettings?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "generativeAiSettingsInput", typeJson: "{\"fqn\":\"aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsCanvasAppSettingsGenerativeAiSettings\"}", isOptional: true)]
        public virtual aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsCanvasAppSettingsGenerativeAiSettings? GenerativeAiSettingsInput
        {
            get => GetInstanceProperty<aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsCanvasAppSettingsGenerativeAiSettings?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "identityProviderOauthSettingsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsCanvasAppSettingsIdentityProviderOauthSettings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? IdentityProviderOauthSettingsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kendraSettingsInput", typeJson: "{\"fqn\":\"aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsCanvasAppSettingsKendraSettings\"}", isOptional: true)]
        public virtual aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsCanvasAppSettingsKendraSettings? KendraSettingsInput
        {
            get => GetInstanceProperty<aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsCanvasAppSettingsKendraSettings?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "modelRegisterSettingsInput", typeJson: "{\"fqn\":\"aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsCanvasAppSettingsModelRegisterSettings\"}", isOptional: true)]
        public virtual aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsCanvasAppSettingsModelRegisterSettings? ModelRegisterSettingsInput
        {
            get => GetInstanceProperty<aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsCanvasAppSettingsModelRegisterSettings?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeSeriesForecastingSettingsInput", typeJson: "{\"fqn\":\"aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsCanvasAppSettingsTimeSeriesForecastingSettings\"}", isOptional: true)]
        public virtual aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsCanvasAppSettingsTimeSeriesForecastingSettings? TimeSeriesForecastingSettingsInput
        {
            get => GetInstanceProperty<aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsCanvasAppSettingsTimeSeriesForecastingSettings?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "workspaceSettingsInput", typeJson: "{\"fqn\":\"aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsCanvasAppSettingsWorkspaceSettings\"}", isOptional: true)]
        public virtual aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsCanvasAppSettingsWorkspaceSettings? WorkspaceSettingsInput
        {
            get => GetInstanceProperty<aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsCanvasAppSettingsWorkspaceSettings?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsCanvasAppSettings\"}", isOptional: true)]
        public virtual aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsCanvasAppSettings? InternalValue
        {
            get => GetInstanceProperty<aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsCanvasAppSettings?>();
            set => SetInstanceProperty(value);
        }
    }
}

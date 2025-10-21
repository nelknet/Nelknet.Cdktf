using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerDomain
{
    [JsiiClass(nativeType: typeof(aws.SagemakerDomain.SagemakerDomainDefaultUserSettingsCanvasAppSettingsOutputReference), fullyQualifiedName: "aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsCanvasAppSettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SagemakerDomainDefaultUserSettingsCanvasAppSettingsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SagemakerDomainDefaultUserSettingsCanvasAppSettingsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected SagemakerDomainDefaultUserSettingsCanvasAppSettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerDomainDefaultUserSettingsCanvasAppSettingsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDirectDeploySettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsCanvasAppSettingsDirectDeploySettings\"}}]")]
        public virtual void PutDirectDeploySettings(aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCanvasAppSettingsDirectDeploySettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCanvasAppSettingsDirectDeploySettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEmrServerlessSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsCanvasAppSettingsEmrServerlessSettings\"}}]")]
        public virtual void PutEmrServerlessSettings(aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCanvasAppSettingsEmrServerlessSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCanvasAppSettingsEmrServerlessSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGenerativeAiSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsCanvasAppSettingsGenerativeAiSettings\"}}]")]
        public virtual void PutGenerativeAiSettings(aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCanvasAppSettingsGenerativeAiSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCanvasAppSettingsGenerativeAiSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIdentityProviderOauthSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsCanvasAppSettingsIdentityProviderOauthSettings\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutIdentityProviderOauthSettings(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCanvasAppSettingsIdentityProviderOauthSettings[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCanvasAppSettingsIdentityProviderOauthSettings).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCanvasAppSettingsIdentityProviderOauthSettings).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putKendraSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsCanvasAppSettingsKendraSettings\"}}]")]
        public virtual void PutKendraSettings(aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCanvasAppSettingsKendraSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCanvasAppSettingsKendraSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "putModelRegisterSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsCanvasAppSettingsModelRegisterSettings\"}}]")]
        public virtual void PutModelRegisterSettings(aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCanvasAppSettingsModelRegisterSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCanvasAppSettingsModelRegisterSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeSeriesForecastingSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsCanvasAppSettingsTimeSeriesForecastingSettings\"}}]")]
        public virtual void PutTimeSeriesForecastingSettings(aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCanvasAppSettingsTimeSeriesForecastingSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCanvasAppSettingsTimeSeriesForecastingSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "putWorkspaceSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsCanvasAppSettingsWorkspaceSettings\"}}]")]
        public virtual void PutWorkspaceSettings(aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCanvasAppSettingsWorkspaceSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCanvasAppSettingsWorkspaceSettings)}, new object[]{@value});
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

        [JsiiProperty(name: "directDeploySettings", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsCanvasAppSettingsDirectDeploySettingsOutputReference\"}")]
        public virtual aws.SagemakerDomain.SagemakerDomainDefaultUserSettingsCanvasAppSettingsDirectDeploySettingsOutputReference DirectDeploySettings
        {
            get => GetInstanceProperty<aws.SagemakerDomain.SagemakerDomainDefaultUserSettingsCanvasAppSettingsDirectDeploySettingsOutputReference>()!;
        }

        [JsiiProperty(name: "emrServerlessSettings", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsCanvasAppSettingsEmrServerlessSettingsOutputReference\"}")]
        public virtual aws.SagemakerDomain.SagemakerDomainDefaultUserSettingsCanvasAppSettingsEmrServerlessSettingsOutputReference EmrServerlessSettings
        {
            get => GetInstanceProperty<aws.SagemakerDomain.SagemakerDomainDefaultUserSettingsCanvasAppSettingsEmrServerlessSettingsOutputReference>()!;
        }

        [JsiiProperty(name: "generativeAiSettings", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsCanvasAppSettingsGenerativeAiSettingsOutputReference\"}")]
        public virtual aws.SagemakerDomain.SagemakerDomainDefaultUserSettingsCanvasAppSettingsGenerativeAiSettingsOutputReference GenerativeAiSettings
        {
            get => GetInstanceProperty<aws.SagemakerDomain.SagemakerDomainDefaultUserSettingsCanvasAppSettingsGenerativeAiSettingsOutputReference>()!;
        }

        [JsiiProperty(name: "identityProviderOauthSettings", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsCanvasAppSettingsIdentityProviderOauthSettingsList\"}")]
        public virtual aws.SagemakerDomain.SagemakerDomainDefaultUserSettingsCanvasAppSettingsIdentityProviderOauthSettingsList IdentityProviderOauthSettings
        {
            get => GetInstanceProperty<aws.SagemakerDomain.SagemakerDomainDefaultUserSettingsCanvasAppSettingsIdentityProviderOauthSettingsList>()!;
        }

        [JsiiProperty(name: "kendraSettings", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsCanvasAppSettingsKendraSettingsOutputReference\"}")]
        public virtual aws.SagemakerDomain.SagemakerDomainDefaultUserSettingsCanvasAppSettingsKendraSettingsOutputReference KendraSettings
        {
            get => GetInstanceProperty<aws.SagemakerDomain.SagemakerDomainDefaultUserSettingsCanvasAppSettingsKendraSettingsOutputReference>()!;
        }

        [JsiiProperty(name: "modelRegisterSettings", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsCanvasAppSettingsModelRegisterSettingsOutputReference\"}")]
        public virtual aws.SagemakerDomain.SagemakerDomainDefaultUserSettingsCanvasAppSettingsModelRegisterSettingsOutputReference ModelRegisterSettings
        {
            get => GetInstanceProperty<aws.SagemakerDomain.SagemakerDomainDefaultUserSettingsCanvasAppSettingsModelRegisterSettingsOutputReference>()!;
        }

        [JsiiProperty(name: "timeSeriesForecastingSettings", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsCanvasAppSettingsTimeSeriesForecastingSettingsOutputReference\"}")]
        public virtual aws.SagemakerDomain.SagemakerDomainDefaultUserSettingsCanvasAppSettingsTimeSeriesForecastingSettingsOutputReference TimeSeriesForecastingSettings
        {
            get => GetInstanceProperty<aws.SagemakerDomain.SagemakerDomainDefaultUserSettingsCanvasAppSettingsTimeSeriesForecastingSettingsOutputReference>()!;
        }

        [JsiiProperty(name: "workspaceSettings", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsCanvasAppSettingsWorkspaceSettingsOutputReference\"}")]
        public virtual aws.SagemakerDomain.SagemakerDomainDefaultUserSettingsCanvasAppSettingsWorkspaceSettingsOutputReference WorkspaceSettings
        {
            get => GetInstanceProperty<aws.SagemakerDomain.SagemakerDomainDefaultUserSettingsCanvasAppSettingsWorkspaceSettingsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "directDeploySettingsInput", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsCanvasAppSettingsDirectDeploySettings\"}", isOptional: true)]
        public virtual aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCanvasAppSettingsDirectDeploySettings? DirectDeploySettingsInput
        {
            get => GetInstanceProperty<aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCanvasAppSettingsDirectDeploySettings?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "emrServerlessSettingsInput", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsCanvasAppSettingsEmrServerlessSettings\"}", isOptional: true)]
        public virtual aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCanvasAppSettingsEmrServerlessSettings? EmrServerlessSettingsInput
        {
            get => GetInstanceProperty<aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCanvasAppSettingsEmrServerlessSettings?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "generativeAiSettingsInput", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsCanvasAppSettingsGenerativeAiSettings\"}", isOptional: true)]
        public virtual aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCanvasAppSettingsGenerativeAiSettings? GenerativeAiSettingsInput
        {
            get => GetInstanceProperty<aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCanvasAppSettingsGenerativeAiSettings?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "identityProviderOauthSettingsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsCanvasAppSettingsIdentityProviderOauthSettings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? IdentityProviderOauthSettingsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kendraSettingsInput", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsCanvasAppSettingsKendraSettings\"}", isOptional: true)]
        public virtual aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCanvasAppSettingsKendraSettings? KendraSettingsInput
        {
            get => GetInstanceProperty<aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCanvasAppSettingsKendraSettings?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "modelRegisterSettingsInput", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsCanvasAppSettingsModelRegisterSettings\"}", isOptional: true)]
        public virtual aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCanvasAppSettingsModelRegisterSettings? ModelRegisterSettingsInput
        {
            get => GetInstanceProperty<aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCanvasAppSettingsModelRegisterSettings?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeSeriesForecastingSettingsInput", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsCanvasAppSettingsTimeSeriesForecastingSettings\"}", isOptional: true)]
        public virtual aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCanvasAppSettingsTimeSeriesForecastingSettings? TimeSeriesForecastingSettingsInput
        {
            get => GetInstanceProperty<aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCanvasAppSettingsTimeSeriesForecastingSettings?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "workspaceSettingsInput", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsCanvasAppSettingsWorkspaceSettings\"}", isOptional: true)]
        public virtual aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCanvasAppSettingsWorkspaceSettings? WorkspaceSettingsInput
        {
            get => GetInstanceProperty<aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCanvasAppSettingsWorkspaceSettings?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsCanvasAppSettings\"}", isOptional: true)]
        public virtual aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCanvasAppSettings? InternalValue
        {
            get => GetInstanceProperty<aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCanvasAppSettings?>();
            set => SetInstanceProperty(value);
        }
    }
}

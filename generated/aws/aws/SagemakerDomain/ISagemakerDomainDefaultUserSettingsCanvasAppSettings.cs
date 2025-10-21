using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerDomain
{
    [JsiiInterface(nativeType: typeof(ISagemakerDomainDefaultUserSettingsCanvasAppSettings), fullyQualifiedName: "aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsCanvasAppSettings")]
    public interface ISagemakerDomainDefaultUserSettingsCanvasAppSettings
    {
        /// <summary>direct_deploy_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#direct_deploy_settings SagemakerDomain#direct_deploy_settings}
        /// </remarks>
        [JsiiProperty(name: "directDeploySettings", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsCanvasAppSettingsDirectDeploySettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCanvasAppSettingsDirectDeploySettings? DirectDeploySettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>emr_serverless_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#emr_serverless_settings SagemakerDomain#emr_serverless_settings}
        /// </remarks>
        [JsiiProperty(name: "emrServerlessSettings", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsCanvasAppSettingsEmrServerlessSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCanvasAppSettingsEmrServerlessSettings? EmrServerlessSettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>generative_ai_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#generative_ai_settings SagemakerDomain#generative_ai_settings}
        /// </remarks>
        [JsiiProperty(name: "generativeAiSettings", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsCanvasAppSettingsGenerativeAiSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCanvasAppSettingsGenerativeAiSettings? GenerativeAiSettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>identity_provider_oauth_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#identity_provider_oauth_settings SagemakerDomain#identity_provider_oauth_settings}
        /// </remarks>
        [JsiiProperty(name: "identityProviderOauthSettings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsCanvasAppSettingsIdentityProviderOauthSettings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IdentityProviderOauthSettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>kendra_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#kendra_settings SagemakerDomain#kendra_settings}
        /// </remarks>
        [JsiiProperty(name: "kendraSettings", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsCanvasAppSettingsKendraSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCanvasAppSettingsKendraSettings? KendraSettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>model_register_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#model_register_settings SagemakerDomain#model_register_settings}
        /// </remarks>
        [JsiiProperty(name: "modelRegisterSettings", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsCanvasAppSettingsModelRegisterSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCanvasAppSettingsModelRegisterSettings? ModelRegisterSettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>time_series_forecasting_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#time_series_forecasting_settings SagemakerDomain#time_series_forecasting_settings}
        /// </remarks>
        [JsiiProperty(name: "timeSeriesForecastingSettings", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsCanvasAppSettingsTimeSeriesForecastingSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCanvasAppSettingsTimeSeriesForecastingSettings? TimeSeriesForecastingSettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>workspace_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#workspace_settings SagemakerDomain#workspace_settings}
        /// </remarks>
        [JsiiProperty(name: "workspaceSettings", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsCanvasAppSettingsWorkspaceSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCanvasAppSettingsWorkspaceSettings? WorkspaceSettings
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerDomainDefaultUserSettingsCanvasAppSettings), fullyQualifiedName: "aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsCanvasAppSettings")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCanvasAppSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>direct_deploy_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#direct_deploy_settings SagemakerDomain#direct_deploy_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "directDeploySettings", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsCanvasAppSettingsDirectDeploySettings\"}", isOptional: true)]
            public aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCanvasAppSettingsDirectDeploySettings? DirectDeploySettings
            {
                get => GetInstanceProperty<aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCanvasAppSettingsDirectDeploySettings?>();
            }

            /// <summary>emr_serverless_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#emr_serverless_settings SagemakerDomain#emr_serverless_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "emrServerlessSettings", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsCanvasAppSettingsEmrServerlessSettings\"}", isOptional: true)]
            public aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCanvasAppSettingsEmrServerlessSettings? EmrServerlessSettings
            {
                get => GetInstanceProperty<aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCanvasAppSettingsEmrServerlessSettings?>();
            }

            /// <summary>generative_ai_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#generative_ai_settings SagemakerDomain#generative_ai_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "generativeAiSettings", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsCanvasAppSettingsGenerativeAiSettings\"}", isOptional: true)]
            public aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCanvasAppSettingsGenerativeAiSettings? GenerativeAiSettings
            {
                get => GetInstanceProperty<aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCanvasAppSettingsGenerativeAiSettings?>();
            }

            /// <summary>identity_provider_oauth_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#identity_provider_oauth_settings SagemakerDomain#identity_provider_oauth_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "identityProviderOauthSettings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsCanvasAppSettingsIdentityProviderOauthSettings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? IdentityProviderOauthSettings
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>kendra_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#kendra_settings SagemakerDomain#kendra_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "kendraSettings", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsCanvasAppSettingsKendraSettings\"}", isOptional: true)]
            public aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCanvasAppSettingsKendraSettings? KendraSettings
            {
                get => GetInstanceProperty<aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCanvasAppSettingsKendraSettings?>();
            }

            /// <summary>model_register_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#model_register_settings SagemakerDomain#model_register_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "modelRegisterSettings", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsCanvasAppSettingsModelRegisterSettings\"}", isOptional: true)]
            public aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCanvasAppSettingsModelRegisterSettings? ModelRegisterSettings
            {
                get => GetInstanceProperty<aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCanvasAppSettingsModelRegisterSettings?>();
            }

            /// <summary>time_series_forecasting_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#time_series_forecasting_settings SagemakerDomain#time_series_forecasting_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeSeriesForecastingSettings", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsCanvasAppSettingsTimeSeriesForecastingSettings\"}", isOptional: true)]
            public aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCanvasAppSettingsTimeSeriesForecastingSettings? TimeSeriesForecastingSettings
            {
                get => GetInstanceProperty<aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCanvasAppSettingsTimeSeriesForecastingSettings?>();
            }

            /// <summary>workspace_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#workspace_settings SagemakerDomain#workspace_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "workspaceSettings", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsCanvasAppSettingsWorkspaceSettings\"}", isOptional: true)]
            public aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCanvasAppSettingsWorkspaceSettings? WorkspaceSettings
            {
                get => GetInstanceProperty<aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCanvasAppSettingsWorkspaceSettings?>();
            }
        }
    }
}

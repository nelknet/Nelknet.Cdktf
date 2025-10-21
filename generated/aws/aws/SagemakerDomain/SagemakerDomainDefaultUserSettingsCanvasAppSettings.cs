using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerDomain
{
    [JsiiByValue(fqn: "aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsCanvasAppSettings")]
    public class SagemakerDomainDefaultUserSettingsCanvasAppSettings : aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCanvasAppSettings
    {
        /// <summary>direct_deploy_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#direct_deploy_settings SagemakerDomain#direct_deploy_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "directDeploySettings", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsCanvasAppSettingsDirectDeploySettings\"}", isOptional: true)]
        public aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCanvasAppSettingsDirectDeploySettings? DirectDeploySettings
        {
            get;
            set;
        }

        /// <summary>emr_serverless_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#emr_serverless_settings SagemakerDomain#emr_serverless_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "emrServerlessSettings", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsCanvasAppSettingsEmrServerlessSettings\"}", isOptional: true)]
        public aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCanvasAppSettingsEmrServerlessSettings? EmrServerlessSettings
        {
            get;
            set;
        }

        /// <summary>generative_ai_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#generative_ai_settings SagemakerDomain#generative_ai_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "generativeAiSettings", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsCanvasAppSettingsGenerativeAiSettings\"}", isOptional: true)]
        public aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCanvasAppSettingsGenerativeAiSettings? GenerativeAiSettings
        {
            get;
            set;
        }

        private object? _identityProviderOauthSettings;

        /// <summary>identity_provider_oauth_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#identity_provider_oauth_settings SagemakerDomain#identity_provider_oauth_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "identityProviderOauthSettings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsCanvasAppSettingsIdentityProviderOauthSettings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? IdentityProviderOauthSettings
        {
            get => _identityProviderOauthSettings;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCanvasAppSettingsIdentityProviderOauthSettings[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCanvasAppSettingsIdentityProviderOauthSettings).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _identityProviderOauthSettings = value;
            }
        }

        /// <summary>kendra_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#kendra_settings SagemakerDomain#kendra_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "kendraSettings", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsCanvasAppSettingsKendraSettings\"}", isOptional: true)]
        public aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCanvasAppSettingsKendraSettings? KendraSettings
        {
            get;
            set;
        }

        /// <summary>model_register_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#model_register_settings SagemakerDomain#model_register_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "modelRegisterSettings", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsCanvasAppSettingsModelRegisterSettings\"}", isOptional: true)]
        public aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCanvasAppSettingsModelRegisterSettings? ModelRegisterSettings
        {
            get;
            set;
        }

        /// <summary>time_series_forecasting_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#time_series_forecasting_settings SagemakerDomain#time_series_forecasting_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeSeriesForecastingSettings", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsCanvasAppSettingsTimeSeriesForecastingSettings\"}", isOptional: true)]
        public aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCanvasAppSettingsTimeSeriesForecastingSettings? TimeSeriesForecastingSettings
        {
            get;
            set;
        }

        /// <summary>workspace_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#workspace_settings SagemakerDomain#workspace_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "workspaceSettings", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsCanvasAppSettingsWorkspaceSettings\"}", isOptional: true)]
        public aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCanvasAppSettingsWorkspaceSettings? WorkspaceSettings
        {
            get;
            set;
        }
    }
}

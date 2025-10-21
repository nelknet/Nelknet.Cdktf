using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerUserProfile
{
    [JsiiByValue(fqn: "aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsCanvasAppSettings")]
    public class SagemakerUserProfileUserSettingsCanvasAppSettings : aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsCanvasAppSettings
    {
        /// <summary>direct_deploy_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_user_profile#direct_deploy_settings SagemakerUserProfile#direct_deploy_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "directDeploySettings", typeJson: "{\"fqn\":\"aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsCanvasAppSettingsDirectDeploySettings\"}", isOptional: true)]
        public aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsCanvasAppSettingsDirectDeploySettings? DirectDeploySettings
        {
            get;
            set;
        }

        /// <summary>emr_serverless_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_user_profile#emr_serverless_settings SagemakerUserProfile#emr_serverless_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "emrServerlessSettings", typeJson: "{\"fqn\":\"aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsCanvasAppSettingsEmrServerlessSettings\"}", isOptional: true)]
        public aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsCanvasAppSettingsEmrServerlessSettings? EmrServerlessSettings
        {
            get;
            set;
        }

        /// <summary>generative_ai_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_user_profile#generative_ai_settings SagemakerUserProfile#generative_ai_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "generativeAiSettings", typeJson: "{\"fqn\":\"aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsCanvasAppSettingsGenerativeAiSettings\"}", isOptional: true)]
        public aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsCanvasAppSettingsGenerativeAiSettings? GenerativeAiSettings
        {
            get;
            set;
        }

        private object? _identityProviderOauthSettings;

        /// <summary>identity_provider_oauth_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_user_profile#identity_provider_oauth_settings SagemakerUserProfile#identity_provider_oauth_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "identityProviderOauthSettings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsCanvasAppSettingsIdentityProviderOauthSettings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsCanvasAppSettingsIdentityProviderOauthSettings[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsCanvasAppSettingsIdentityProviderOauthSettings).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _identityProviderOauthSettings = value;
            }
        }

        /// <summary>kendra_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_user_profile#kendra_settings SagemakerUserProfile#kendra_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "kendraSettings", typeJson: "{\"fqn\":\"aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsCanvasAppSettingsKendraSettings\"}", isOptional: true)]
        public aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsCanvasAppSettingsKendraSettings? KendraSettings
        {
            get;
            set;
        }

        /// <summary>model_register_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_user_profile#model_register_settings SagemakerUserProfile#model_register_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "modelRegisterSettings", typeJson: "{\"fqn\":\"aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsCanvasAppSettingsModelRegisterSettings\"}", isOptional: true)]
        public aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsCanvasAppSettingsModelRegisterSettings? ModelRegisterSettings
        {
            get;
            set;
        }

        /// <summary>time_series_forecasting_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_user_profile#time_series_forecasting_settings SagemakerUserProfile#time_series_forecasting_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeSeriesForecastingSettings", typeJson: "{\"fqn\":\"aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsCanvasAppSettingsTimeSeriesForecastingSettings\"}", isOptional: true)]
        public aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsCanvasAppSettingsTimeSeriesForecastingSettings? TimeSeriesForecastingSettings
        {
            get;
            set;
        }

        /// <summary>workspace_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_user_profile#workspace_settings SagemakerUserProfile#workspace_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "workspaceSettings", typeJson: "{\"fqn\":\"aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsCanvasAppSettingsWorkspaceSettings\"}", isOptional: true)]
        public aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsCanvasAppSettingsWorkspaceSettings? WorkspaceSettings
        {
            get;
            set;
        }
    }
}

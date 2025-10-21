using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerUserProfile
{
    [JsiiByValue(fqn: "aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsJupyterServerAppSettings")]
    public class SagemakerUserProfileUserSettingsJupyterServerAppSettings : aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsJupyterServerAppSettings
    {
        private object? _codeRepository;

        /// <summary>code_repository block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_user_profile#code_repository SagemakerUserProfile#code_repository}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "codeRepository", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsJupyterServerAppSettingsCodeRepository\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CodeRepository
        {
            get => _codeRepository;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsJupyterServerAppSettingsCodeRepository[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsJupyterServerAppSettingsCodeRepository).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _codeRepository = value;
            }
        }

        /// <summary>default_resource_spec block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_user_profile#default_resource_spec SagemakerUserProfile#default_resource_spec}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "defaultResourceSpec", typeJson: "{\"fqn\":\"aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsJupyterServerAppSettingsDefaultResourceSpec\"}", isOptional: true)]
        public aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsJupyterServerAppSettingsDefaultResourceSpec? DefaultResourceSpec
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_user_profile#lifecycle_config_arns SagemakerUserProfile#lifecycle_config_arns}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycleConfigArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? LifecycleConfigArns
        {
            get;
            set;
        }
    }
}

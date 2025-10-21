using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ApprunnerService
{
    [JsiiByValue(fqn: "aws.apprunnerService.ApprunnerServiceSourceConfiguration")]
    public class ApprunnerServiceSourceConfiguration : aws.ApprunnerService.IApprunnerServiceSourceConfiguration
    {
        /// <summary>authentication_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_service#authentication_configuration ApprunnerService#authentication_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "authenticationConfiguration", typeJson: "{\"fqn\":\"aws.apprunnerService.ApprunnerServiceSourceConfigurationAuthenticationConfiguration\"}", isOptional: true)]
        public aws.ApprunnerService.IApprunnerServiceSourceConfigurationAuthenticationConfiguration? AuthenticationConfiguration
        {
            get;
            set;
        }

        private object? _autoDeploymentsEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_service#auto_deployments_enabled ApprunnerService#auto_deployments_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "autoDeploymentsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? AutoDeploymentsEnabled
        {
            get => _autoDeploymentsEnabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _autoDeploymentsEnabled = value;
            }
        }

        /// <summary>code_repository block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_service#code_repository ApprunnerService#code_repository}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "codeRepository", typeJson: "{\"fqn\":\"aws.apprunnerService.ApprunnerServiceSourceConfigurationCodeRepository\"}", isOptional: true)]
        public aws.ApprunnerService.IApprunnerServiceSourceConfigurationCodeRepository? CodeRepository
        {
            get;
            set;
        }

        /// <summary>image_repository block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_service#image_repository ApprunnerService#image_repository}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "imageRepository", typeJson: "{\"fqn\":\"aws.apprunnerService.ApprunnerServiceSourceConfigurationImageRepository\"}", isOptional: true)]
        public aws.ApprunnerService.IApprunnerServiceSourceConfigurationImageRepository? ImageRepository
        {
            get;
            set;
        }
    }
}

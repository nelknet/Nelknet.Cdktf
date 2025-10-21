using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ApprunnerService
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.apprunnerService.ApprunnerServiceSourceConfigurationCodeRepositoryCodeConfiguration")]
    public class ApprunnerServiceSourceConfigurationCodeRepositoryCodeConfiguration : aws.ApprunnerService.IApprunnerServiceSourceConfigurationCodeRepositoryCodeConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_service#configuration_source ApprunnerService#configuration_source}.</summary>
        [JsiiProperty(name: "configurationSource", typeJson: "{\"primitive\":\"string\"}")]
        public string ConfigurationSource
        {
            get;
            set;
        }

        /// <summary>code_configuration_values block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_service#code_configuration_values ApprunnerService#code_configuration_values}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "codeConfigurationValues", typeJson: "{\"fqn\":\"aws.apprunnerService.ApprunnerServiceSourceConfigurationCodeRepositoryCodeConfigurationCodeConfigurationValues\"}", isOptional: true)]
        public aws.ApprunnerService.IApprunnerServiceSourceConfigurationCodeRepositoryCodeConfigurationCodeConfigurationValues? CodeConfigurationValues
        {
            get;
            set;
        }
    }
}

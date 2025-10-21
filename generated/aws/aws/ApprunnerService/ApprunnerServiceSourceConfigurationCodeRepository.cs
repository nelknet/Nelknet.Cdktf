using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ApprunnerService
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.apprunnerService.ApprunnerServiceSourceConfigurationCodeRepository")]
    public class ApprunnerServiceSourceConfigurationCodeRepository : aws.ApprunnerService.IApprunnerServiceSourceConfigurationCodeRepository
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_service#repository_url ApprunnerService#repository_url}.</summary>
        [JsiiProperty(name: "repositoryUrl", typeJson: "{\"primitive\":\"string\"}")]
        public string RepositoryUrl
        {
            get;
            set;
        }

        /// <summary>source_code_version block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_service#source_code_version ApprunnerService#source_code_version}
        /// </remarks>
        [JsiiProperty(name: "sourceCodeVersion", typeJson: "{\"fqn\":\"aws.apprunnerService.ApprunnerServiceSourceConfigurationCodeRepositorySourceCodeVersion\"}")]
        public aws.ApprunnerService.IApprunnerServiceSourceConfigurationCodeRepositorySourceCodeVersion SourceCodeVersion
        {
            get;
            set;
        }

        /// <summary>code_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_service#code_configuration ApprunnerService#code_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "codeConfiguration", typeJson: "{\"fqn\":\"aws.apprunnerService.ApprunnerServiceSourceConfigurationCodeRepositoryCodeConfiguration\"}", isOptional: true)]
        public aws.ApprunnerService.IApprunnerServiceSourceConfigurationCodeRepositoryCodeConfiguration? CodeConfiguration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_service#source_directory ApprunnerService#source_directory}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sourceDirectory", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SourceDirectory
        {
            get;
            set;
        }
    }
}

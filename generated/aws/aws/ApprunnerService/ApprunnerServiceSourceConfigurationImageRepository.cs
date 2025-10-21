using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ApprunnerService
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.apprunnerService.ApprunnerServiceSourceConfigurationImageRepository")]
    public class ApprunnerServiceSourceConfigurationImageRepository : aws.ApprunnerService.IApprunnerServiceSourceConfigurationImageRepository
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_service#image_identifier ApprunnerService#image_identifier}.</summary>
        [JsiiProperty(name: "imageIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        public string ImageIdentifier
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_service#image_repository_type ApprunnerService#image_repository_type}.</summary>
        [JsiiProperty(name: "imageRepositoryType", typeJson: "{\"primitive\":\"string\"}")]
        public string ImageRepositoryType
        {
            get;
            set;
        }

        /// <summary>image_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_service#image_configuration ApprunnerService#image_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "imageConfiguration", typeJson: "{\"fqn\":\"aws.apprunnerService.ApprunnerServiceSourceConfigurationImageRepositoryImageConfiguration\"}", isOptional: true)]
        public aws.ApprunnerService.IApprunnerServiceSourceConfigurationImageRepositoryImageConfiguration? ImageConfiguration
        {
            get;
            set;
        }
    }
}

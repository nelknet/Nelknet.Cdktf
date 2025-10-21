using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ApprunnerService
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.apprunnerService.ApprunnerServiceSourceConfigurationCodeRepositorySourceCodeVersion")]
    public class ApprunnerServiceSourceConfigurationCodeRepositorySourceCodeVersion : aws.ApprunnerService.IApprunnerServiceSourceConfigurationCodeRepositorySourceCodeVersion
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_service#type ApprunnerService#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_service#value ApprunnerService#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }
    }
}

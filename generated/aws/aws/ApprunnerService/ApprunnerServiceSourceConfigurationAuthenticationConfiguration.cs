using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ApprunnerService
{
    [JsiiByValue(fqn: "aws.apprunnerService.ApprunnerServiceSourceConfigurationAuthenticationConfiguration")]
    public class ApprunnerServiceSourceConfigurationAuthenticationConfiguration : aws.ApprunnerService.IApprunnerServiceSourceConfigurationAuthenticationConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_service#access_role_arn ApprunnerService#access_role_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "accessRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AccessRoleArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_service#connection_arn ApprunnerService#connection_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "connectionArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ConnectionArn
        {
            get;
            set;
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ApprunnerService
{
    [JsiiByValue(fqn: "aws.apprunnerService.ApprunnerServiceSourceConfigurationImageRepositoryImageConfiguration")]
    public class ApprunnerServiceSourceConfigurationImageRepositoryImageConfiguration : aws.ApprunnerService.IApprunnerServiceSourceConfigurationImageRepositoryImageConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_service#port ApprunnerService#port}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Port
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_service#runtime_environment_secrets ApprunnerService#runtime_environment_secrets}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "runtimeEnvironmentSecrets", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? RuntimeEnvironmentSecrets
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_service#runtime_environment_variables ApprunnerService#runtime_environment_variables}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "runtimeEnvironmentVariables", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? RuntimeEnvironmentVariables
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_service#start_command ApprunnerService#start_command}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "startCommand", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StartCommand
        {
            get;
            set;
        }
    }
}

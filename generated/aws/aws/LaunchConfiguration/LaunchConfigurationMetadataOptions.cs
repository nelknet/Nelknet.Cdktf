using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LaunchConfiguration
{
    [JsiiByValue(fqn: "aws.launchConfiguration.LaunchConfigurationMetadataOptions")]
    public class LaunchConfigurationMetadataOptions : aws.LaunchConfiguration.ILaunchConfigurationMetadataOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_configuration#http_endpoint LaunchConfiguration#http_endpoint}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "httpEndpoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HttpEndpoint
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_configuration#http_put_response_hop_limit LaunchConfiguration#http_put_response_hop_limit}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "httpPutResponseHopLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? HttpPutResponseHopLimit
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_configuration#http_tokens LaunchConfiguration#http_tokens}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "httpTokens", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HttpTokens
        {
            get;
            set;
        }
    }
}

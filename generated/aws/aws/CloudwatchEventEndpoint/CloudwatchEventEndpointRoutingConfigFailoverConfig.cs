using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchEventEndpoint
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudwatchEventEndpoint.CloudwatchEventEndpointRoutingConfigFailoverConfig")]
    public class CloudwatchEventEndpointRoutingConfigFailoverConfig : aws.CloudwatchEventEndpoint.ICloudwatchEventEndpointRoutingConfigFailoverConfig
    {
        /// <summary>primary block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_endpoint#primary CloudwatchEventEndpoint#primary}
        /// </remarks>
        [JsiiProperty(name: "primary", typeJson: "{\"fqn\":\"aws.cloudwatchEventEndpoint.CloudwatchEventEndpointRoutingConfigFailoverConfigPrimary\"}")]
        public aws.CloudwatchEventEndpoint.ICloudwatchEventEndpointRoutingConfigFailoverConfigPrimary Primary
        {
            get;
            set;
        }

        /// <summary>secondary block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_endpoint#secondary CloudwatchEventEndpoint#secondary}
        /// </remarks>
        [JsiiProperty(name: "secondary", typeJson: "{\"fqn\":\"aws.cloudwatchEventEndpoint.CloudwatchEventEndpointRoutingConfigFailoverConfigSecondary\"}")]
        public aws.CloudwatchEventEndpoint.ICloudwatchEventEndpointRoutingConfigFailoverConfigSecondary Secondary
        {
            get;
            set;
        }
    }
}

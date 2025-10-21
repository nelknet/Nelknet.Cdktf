using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchEventEndpoint
{
    [JsiiByValue(fqn: "aws.cloudwatchEventEndpoint.CloudwatchEventEndpointRoutingConfigFailoverConfigSecondary")]
    public class CloudwatchEventEndpointRoutingConfigFailoverConfigSecondary : aws.CloudwatchEventEndpoint.ICloudwatchEventEndpointRoutingConfigFailoverConfigSecondary
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_endpoint#route CloudwatchEventEndpoint#route}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "route", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Route
        {
            get;
            set;
        }
    }
}

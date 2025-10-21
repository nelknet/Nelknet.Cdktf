using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchEventEndpoint
{
    [JsiiByValue(fqn: "aws.cloudwatchEventEndpoint.CloudwatchEventEndpointRoutingConfigFailoverConfigPrimary")]
    public class CloudwatchEventEndpointRoutingConfigFailoverConfigPrimary : aws.CloudwatchEventEndpoint.ICloudwatchEventEndpointRoutingConfigFailoverConfigPrimary
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_endpoint#health_check CloudwatchEventEndpoint#health_check}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "healthCheck", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HealthCheck
        {
            get;
            set;
        }
    }
}

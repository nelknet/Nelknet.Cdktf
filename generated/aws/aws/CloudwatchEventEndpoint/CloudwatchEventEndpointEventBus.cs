using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchEventEndpoint
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudwatchEventEndpoint.CloudwatchEventEndpointEventBus")]
    public class CloudwatchEventEndpointEventBus : aws.CloudwatchEventEndpoint.ICloudwatchEventEndpointEventBus
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_endpoint#event_bus_arn CloudwatchEventEndpoint#event_bus_arn}.</summary>
        [JsiiProperty(name: "eventBusArn", typeJson: "{\"primitive\":\"string\"}")]
        public string EventBusArn
        {
            get;
            set;
        }
    }
}

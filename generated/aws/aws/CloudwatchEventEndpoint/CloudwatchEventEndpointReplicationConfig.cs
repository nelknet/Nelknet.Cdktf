using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchEventEndpoint
{
    [JsiiByValue(fqn: "aws.cloudwatchEventEndpoint.CloudwatchEventEndpointReplicationConfig")]
    public class CloudwatchEventEndpointReplicationConfig : aws.CloudwatchEventEndpoint.ICloudwatchEventEndpointReplicationConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_endpoint#state CloudwatchEventEndpoint#state}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? State
        {
            get;
            set;
        }
    }
}

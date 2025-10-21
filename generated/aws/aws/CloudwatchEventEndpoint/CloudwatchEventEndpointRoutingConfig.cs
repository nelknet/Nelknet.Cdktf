using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchEventEndpoint
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudwatchEventEndpoint.CloudwatchEventEndpointRoutingConfig")]
    public class CloudwatchEventEndpointRoutingConfig : aws.CloudwatchEventEndpoint.ICloudwatchEventEndpointRoutingConfig
    {
        /// <summary>failover_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_endpoint#failover_config CloudwatchEventEndpoint#failover_config}
        /// </remarks>
        [JsiiProperty(name: "failoverConfig", typeJson: "{\"fqn\":\"aws.cloudwatchEventEndpoint.CloudwatchEventEndpointRoutingConfigFailoverConfig\"}")]
        public aws.CloudwatchEventEndpoint.ICloudwatchEventEndpointRoutingConfigFailoverConfig FailoverConfig
        {
            get;
            set;
        }
    }
}

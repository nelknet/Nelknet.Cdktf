using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sesv2ConfigurationSetEventDestination
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sesv2ConfigurationSetEventDestination.Sesv2ConfigurationSetEventDestinationEventDestinationEventBridgeDestination")]
    public class Sesv2ConfigurationSetEventDestinationEventDestinationEventBridgeDestination : aws.Sesv2ConfigurationSetEventDestination.ISesv2ConfigurationSetEventDestinationEventDestinationEventBridgeDestination
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_configuration_set_event_destination#event_bus_arn Sesv2ConfigurationSetEventDestination#event_bus_arn}.</summary>
        [JsiiProperty(name: "eventBusArn", typeJson: "{\"primitive\":\"string\"}")]
        public string EventBusArn
        {
            get;
            set;
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sesv2ConfigurationSetEventDestination
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sesv2ConfigurationSetEventDestination.Sesv2ConfigurationSetEventDestinationEventDestination")]
    public class Sesv2ConfigurationSetEventDestinationEventDestination : aws.Sesv2ConfigurationSetEventDestination.ISesv2ConfigurationSetEventDestinationEventDestination
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_configuration_set_event_destination#matching_event_types Sesv2ConfigurationSetEventDestination#matching_event_types}.</summary>
        [JsiiProperty(name: "matchingEventTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] MatchingEventTypes
        {
            get;
            set;
        }

        /// <summary>cloud_watch_destination block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_configuration_set_event_destination#cloud_watch_destination Sesv2ConfigurationSetEventDestination#cloud_watch_destination}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cloudWatchDestination", typeJson: "{\"fqn\":\"aws.sesv2ConfigurationSetEventDestination.Sesv2ConfigurationSetEventDestinationEventDestinationCloudWatchDestination\"}", isOptional: true)]
        public aws.Sesv2ConfigurationSetEventDestination.ISesv2ConfigurationSetEventDestinationEventDestinationCloudWatchDestination? CloudWatchDestination
        {
            get;
            set;
        }

        private object? _enabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_configuration_set_event_destination#enabled Sesv2ConfigurationSetEventDestination#enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? Enabled
        {
            get => _enabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _enabled = value;
            }
        }

        /// <summary>event_bridge_destination block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_configuration_set_event_destination#event_bridge_destination Sesv2ConfigurationSetEventDestination#event_bridge_destination}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "eventBridgeDestination", typeJson: "{\"fqn\":\"aws.sesv2ConfigurationSetEventDestination.Sesv2ConfigurationSetEventDestinationEventDestinationEventBridgeDestination\"}", isOptional: true)]
        public aws.Sesv2ConfigurationSetEventDestination.ISesv2ConfigurationSetEventDestinationEventDestinationEventBridgeDestination? EventBridgeDestination
        {
            get;
            set;
        }

        /// <summary>kinesis_firehose_destination block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_configuration_set_event_destination#kinesis_firehose_destination Sesv2ConfigurationSetEventDestination#kinesis_firehose_destination}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "kinesisFirehoseDestination", typeJson: "{\"fqn\":\"aws.sesv2ConfigurationSetEventDestination.Sesv2ConfigurationSetEventDestinationEventDestinationKinesisFirehoseDestination\"}", isOptional: true)]
        public aws.Sesv2ConfigurationSetEventDestination.ISesv2ConfigurationSetEventDestinationEventDestinationKinesisFirehoseDestination? KinesisFirehoseDestination
        {
            get;
            set;
        }

        /// <summary>pinpoint_destination block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_configuration_set_event_destination#pinpoint_destination Sesv2ConfigurationSetEventDestination#pinpoint_destination}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "pinpointDestination", typeJson: "{\"fqn\":\"aws.sesv2ConfigurationSetEventDestination.Sesv2ConfigurationSetEventDestinationEventDestinationPinpointDestination\"}", isOptional: true)]
        public aws.Sesv2ConfigurationSetEventDestination.ISesv2ConfigurationSetEventDestinationEventDestinationPinpointDestination? PinpointDestination
        {
            get;
            set;
        }

        /// <summary>sns_destination block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_configuration_set_event_destination#sns_destination Sesv2ConfigurationSetEventDestination#sns_destination}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "snsDestination", typeJson: "{\"fqn\":\"aws.sesv2ConfigurationSetEventDestination.Sesv2ConfigurationSetEventDestinationEventDestinationSnsDestination\"}", isOptional: true)]
        public aws.Sesv2ConfigurationSetEventDestination.ISesv2ConfigurationSetEventDestinationEventDestinationSnsDestination? SnsDestination
        {
            get;
            set;
        }
    }
}

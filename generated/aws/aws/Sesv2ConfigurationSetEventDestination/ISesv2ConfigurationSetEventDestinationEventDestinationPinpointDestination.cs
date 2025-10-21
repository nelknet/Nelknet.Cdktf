using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sesv2ConfigurationSetEventDestination
{
    [JsiiInterface(nativeType: typeof(ISesv2ConfigurationSetEventDestinationEventDestinationPinpointDestination), fullyQualifiedName: "aws.sesv2ConfigurationSetEventDestination.Sesv2ConfigurationSetEventDestinationEventDestinationPinpointDestination")]
    public interface ISesv2ConfigurationSetEventDestinationEventDestinationPinpointDestination
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_configuration_set_event_destination#application_arn Sesv2ConfigurationSetEventDestination#application_arn}.</summary>
        [JsiiProperty(name: "applicationArn", typeJson: "{\"primitive\":\"string\"}")]
        string ApplicationArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISesv2ConfigurationSetEventDestinationEventDestinationPinpointDestination), fullyQualifiedName: "aws.sesv2ConfigurationSetEventDestination.Sesv2ConfigurationSetEventDestinationEventDestinationPinpointDestination")]
        internal sealed class _Proxy : DeputyBase, aws.Sesv2ConfigurationSetEventDestination.ISesv2ConfigurationSetEventDestinationEventDestinationPinpointDestination
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_configuration_set_event_destination#application_arn Sesv2ConfigurationSetEventDestination#application_arn}.</summary>
            [JsiiProperty(name: "applicationArn", typeJson: "{\"primitive\":\"string\"}")]
            public string ApplicationArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}

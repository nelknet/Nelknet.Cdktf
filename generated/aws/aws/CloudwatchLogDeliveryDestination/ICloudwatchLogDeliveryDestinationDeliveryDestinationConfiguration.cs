using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchLogDeliveryDestination
{
    [JsiiInterface(nativeType: typeof(ICloudwatchLogDeliveryDestinationDeliveryDestinationConfiguration), fullyQualifiedName: "aws.cloudwatchLogDeliveryDestination.CloudwatchLogDeliveryDestinationDeliveryDestinationConfiguration")]
    public interface ICloudwatchLogDeliveryDestinationDeliveryDestinationConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_log_delivery_destination#destination_resource_arn CloudwatchLogDeliveryDestination#destination_resource_arn}.</summary>
        [JsiiProperty(name: "destinationResourceArn", typeJson: "{\"primitive\":\"string\"}")]
        string DestinationResourceArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudwatchLogDeliveryDestinationDeliveryDestinationConfiguration), fullyQualifiedName: "aws.cloudwatchLogDeliveryDestination.CloudwatchLogDeliveryDestinationDeliveryDestinationConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.CloudwatchLogDeliveryDestination.ICloudwatchLogDeliveryDestinationDeliveryDestinationConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_log_delivery_destination#destination_resource_arn CloudwatchLogDeliveryDestination#destination_resource_arn}.</summary>
            [JsiiProperty(name: "destinationResourceArn", typeJson: "{\"primitive\":\"string\"}")]
            public string DestinationResourceArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}

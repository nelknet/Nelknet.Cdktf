using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ConfigDeliveryChannel
{
    [JsiiByValue(fqn: "aws.configDeliveryChannel.ConfigDeliveryChannelSnapshotDeliveryProperties")]
    public class ConfigDeliveryChannelSnapshotDeliveryProperties : aws.ConfigDeliveryChannel.IConfigDeliveryChannelSnapshotDeliveryProperties
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_delivery_channel#delivery_frequency ConfigDeliveryChannel#delivery_frequency}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "deliveryFrequency", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DeliveryFrequency
        {
            get;
            set;
        }
    }
}

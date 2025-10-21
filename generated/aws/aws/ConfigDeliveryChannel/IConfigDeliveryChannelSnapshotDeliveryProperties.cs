using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ConfigDeliveryChannel
{
    [JsiiInterface(nativeType: typeof(IConfigDeliveryChannelSnapshotDeliveryProperties), fullyQualifiedName: "aws.configDeliveryChannel.ConfigDeliveryChannelSnapshotDeliveryProperties")]
    public interface IConfigDeliveryChannelSnapshotDeliveryProperties
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_delivery_channel#delivery_frequency ConfigDeliveryChannel#delivery_frequency}.</summary>
        [JsiiProperty(name: "deliveryFrequency", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DeliveryFrequency
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IConfigDeliveryChannelSnapshotDeliveryProperties), fullyQualifiedName: "aws.configDeliveryChannel.ConfigDeliveryChannelSnapshotDeliveryProperties")]
        internal sealed class _Proxy : DeputyBase, aws.ConfigDeliveryChannel.IConfigDeliveryChannelSnapshotDeliveryProperties
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_delivery_channel#delivery_frequency ConfigDeliveryChannel#delivery_frequency}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "deliveryFrequency", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DeliveryFrequency
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

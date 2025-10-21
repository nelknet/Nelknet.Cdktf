using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.KinesisFirehoseDeliveryStream
{
    [JsiiInterface(nativeType: typeof(IKinesisFirehoseDeliveryStreamSnowflakeConfigurationSnowflakeVpcConfiguration), fullyQualifiedName: "aws.kinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamSnowflakeConfigurationSnowflakeVpcConfiguration")]
    public interface IKinesisFirehoseDeliveryStreamSnowflakeConfigurationSnowflakeVpcConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_firehose_delivery_stream#private_link_vpce_id KinesisFirehoseDeliveryStream#private_link_vpce_id}.</summary>
        [JsiiProperty(name: "privateLinkVpceId", typeJson: "{\"primitive\":\"string\"}")]
        string PrivateLinkVpceId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IKinesisFirehoseDeliveryStreamSnowflakeConfigurationSnowflakeVpcConfiguration), fullyQualifiedName: "aws.kinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamSnowflakeConfigurationSnowflakeVpcConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.KinesisFirehoseDeliveryStream.IKinesisFirehoseDeliveryStreamSnowflakeConfigurationSnowflakeVpcConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_firehose_delivery_stream#private_link_vpce_id KinesisFirehoseDeliveryStream#private_link_vpce_id}.</summary>
            [JsiiProperty(name: "privateLinkVpceId", typeJson: "{\"primitive\":\"string\"}")]
            public string PrivateLinkVpceId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.KinesisFirehoseDeliveryStream
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.kinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamSnowflakeConfigurationSnowflakeVpcConfiguration")]
    public class KinesisFirehoseDeliveryStreamSnowflakeConfigurationSnowflakeVpcConfiguration : aws.KinesisFirehoseDeliveryStream.IKinesisFirehoseDeliveryStreamSnowflakeConfigurationSnowflakeVpcConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_firehose_delivery_stream#private_link_vpce_id KinesisFirehoseDeliveryStream#private_link_vpce_id}.</summary>
        [JsiiProperty(name: "privateLinkVpceId", typeJson: "{\"primitive\":\"string\"}")]
        public string PrivateLinkVpceId
        {
            get;
            set;
        }
    }
}

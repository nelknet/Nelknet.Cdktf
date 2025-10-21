using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.KinesisFirehoseDeliveryStream
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.kinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamMskSourceConfiguration")]
    public class KinesisFirehoseDeliveryStreamMskSourceConfiguration : aws.KinesisFirehoseDeliveryStream.IKinesisFirehoseDeliveryStreamMskSourceConfiguration
    {
        /// <summary>authentication_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_firehose_delivery_stream#authentication_configuration KinesisFirehoseDeliveryStream#authentication_configuration}
        /// </remarks>
        [JsiiProperty(name: "authenticationConfiguration", typeJson: "{\"fqn\":\"aws.kinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamMskSourceConfigurationAuthenticationConfiguration\"}")]
        public aws.KinesisFirehoseDeliveryStream.IKinesisFirehoseDeliveryStreamMskSourceConfigurationAuthenticationConfiguration AuthenticationConfiguration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_firehose_delivery_stream#msk_cluster_arn KinesisFirehoseDeliveryStream#msk_cluster_arn}.</summary>
        [JsiiProperty(name: "mskClusterArn", typeJson: "{\"primitive\":\"string\"}")]
        public string MskClusterArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_firehose_delivery_stream#topic_name KinesisFirehoseDeliveryStream#topic_name}.</summary>
        [JsiiProperty(name: "topicName", typeJson: "{\"primitive\":\"string\"}")]
        public string TopicName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_firehose_delivery_stream#read_from_timestamp KinesisFirehoseDeliveryStream#read_from_timestamp}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "readFromTimestamp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ReadFromTimestamp
        {
            get;
            set;
        }
    }
}

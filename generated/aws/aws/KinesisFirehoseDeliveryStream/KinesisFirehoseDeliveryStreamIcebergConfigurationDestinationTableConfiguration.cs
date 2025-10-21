using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.KinesisFirehoseDeliveryStream
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.kinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamIcebergConfigurationDestinationTableConfiguration")]
    public class KinesisFirehoseDeliveryStreamIcebergConfigurationDestinationTableConfiguration : aws.KinesisFirehoseDeliveryStream.IKinesisFirehoseDeliveryStreamIcebergConfigurationDestinationTableConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_firehose_delivery_stream#database_name KinesisFirehoseDeliveryStream#database_name}.</summary>
        [JsiiProperty(name: "databaseName", typeJson: "{\"primitive\":\"string\"}")]
        public string DatabaseName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_firehose_delivery_stream#table_name KinesisFirehoseDeliveryStream#table_name}.</summary>
        [JsiiProperty(name: "tableName", typeJson: "{\"primitive\":\"string\"}")]
        public string TableName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_firehose_delivery_stream#s3_error_output_prefix KinesisFirehoseDeliveryStream#s3_error_output_prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "s3ErrorOutputPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? S3ErrorOutputPrefix
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_firehose_delivery_stream#unique_keys KinesisFirehoseDeliveryStream#unique_keys}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "uniqueKeys", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? UniqueKeys
        {
            get;
            set;
        }
    }
}

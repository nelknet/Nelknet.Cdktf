using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.KinesisFirehoseDeliveryStream
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.kinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamOpensearchConfigurationDocumentIdOptions")]
    public class KinesisFirehoseDeliveryStreamOpensearchConfigurationDocumentIdOptions : aws.KinesisFirehoseDeliveryStream.IKinesisFirehoseDeliveryStreamOpensearchConfigurationDocumentIdOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_firehose_delivery_stream#default_document_id_format KinesisFirehoseDeliveryStream#default_document_id_format}.</summary>
        [JsiiProperty(name: "defaultDocumentIdFormat", typeJson: "{\"primitive\":\"string\"}")]
        public string DefaultDocumentIdFormat
        {
            get;
            set;
        }
    }
}

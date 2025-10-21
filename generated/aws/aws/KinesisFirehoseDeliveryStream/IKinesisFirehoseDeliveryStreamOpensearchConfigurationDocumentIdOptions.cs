using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.KinesisFirehoseDeliveryStream
{
    [JsiiInterface(nativeType: typeof(IKinesisFirehoseDeliveryStreamOpensearchConfigurationDocumentIdOptions), fullyQualifiedName: "aws.kinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamOpensearchConfigurationDocumentIdOptions")]
    public interface IKinesisFirehoseDeliveryStreamOpensearchConfigurationDocumentIdOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_firehose_delivery_stream#default_document_id_format KinesisFirehoseDeliveryStream#default_document_id_format}.</summary>
        [JsiiProperty(name: "defaultDocumentIdFormat", typeJson: "{\"primitive\":\"string\"}")]
        string DefaultDocumentIdFormat
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IKinesisFirehoseDeliveryStreamOpensearchConfigurationDocumentIdOptions), fullyQualifiedName: "aws.kinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamOpensearchConfigurationDocumentIdOptions")]
        internal sealed class _Proxy : DeputyBase, aws.KinesisFirehoseDeliveryStream.IKinesisFirehoseDeliveryStreamOpensearchConfigurationDocumentIdOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_firehose_delivery_stream#default_document_id_format KinesisFirehoseDeliveryStream#default_document_id_format}.</summary>
            [JsiiProperty(name: "defaultDocumentIdFormat", typeJson: "{\"primitive\":\"string\"}")]
            public string DefaultDocumentIdFormat
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.RekognitionStreamProcessor
{
    [JsiiInterface(nativeType: typeof(IRekognitionStreamProcessorOutput), fullyQualifiedName: "aws.rekognitionStreamProcessor.RekognitionStreamProcessorOutput")]
    public interface IRekognitionStreamProcessorOutput
    {
        /// <summary>kinesis_data_stream block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rekognition_stream_processor#kinesis_data_stream RekognitionStreamProcessor#kinesis_data_stream}
        /// </remarks>
        [JsiiProperty(name: "kinesisDataStream", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.rekognitionStreamProcessor.RekognitionStreamProcessorOutputKinesisDataStream\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? KinesisDataStream
        {
            get
            {
                return null;
            }
        }

        /// <summary>s3_destination block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rekognition_stream_processor#s3_destination RekognitionStreamProcessor#s3_destination}
        /// </remarks>
        [JsiiProperty(name: "s3Destination", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.rekognitionStreamProcessor.RekognitionStreamProcessorOutputS3Destination\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? S3Destination
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRekognitionStreamProcessorOutput), fullyQualifiedName: "aws.rekognitionStreamProcessor.RekognitionStreamProcessorOutput")]
        internal sealed class _Proxy : DeputyBase, aws.RekognitionStreamProcessor.IRekognitionStreamProcessorOutput
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>kinesis_data_stream block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rekognition_stream_processor#kinesis_data_stream RekognitionStreamProcessor#kinesis_data_stream}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "kinesisDataStream", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.rekognitionStreamProcessor.RekognitionStreamProcessorOutputKinesisDataStream\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? KinesisDataStream
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>s3_destination block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rekognition_stream_processor#s3_destination RekognitionStreamProcessor#s3_destination}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "s3Destination", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.rekognitionStreamProcessor.RekognitionStreamProcessorOutputS3Destination\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? S3Destination
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}

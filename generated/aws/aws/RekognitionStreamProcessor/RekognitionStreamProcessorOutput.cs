using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.RekognitionStreamProcessor
{
    [JsiiByValue(fqn: "aws.rekognitionStreamProcessor.RekognitionStreamProcessorOutput")]
    public class RekognitionStreamProcessorOutput : aws.RekognitionStreamProcessor.IRekognitionStreamProcessorOutput
    {
        private object? _kinesisDataStream;

        /// <summary>kinesis_data_stream block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rekognition_stream_processor#kinesis_data_stream RekognitionStreamProcessor#kinesis_data_stream}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "kinesisDataStream", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.rekognitionStreamProcessor.RekognitionStreamProcessorOutputKinesisDataStream\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? KinesisDataStream
        {
            get => _kinesisDataStream;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.RekognitionStreamProcessor.IRekognitionStreamProcessorOutputKinesisDataStream[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.RekognitionStreamProcessor.IRekognitionStreamProcessorOutputKinesisDataStream).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _kinesisDataStream = value;
            }
        }

        private object? _s3Destination;

        /// <summary>s3_destination block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rekognition_stream_processor#s3_destination RekognitionStreamProcessor#s3_destination}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "s3Destination", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.rekognitionStreamProcessor.RekognitionStreamProcessorOutputS3Destination\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? S3Destination
        {
            get => _s3Destination;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.RekognitionStreamProcessor.IRekognitionStreamProcessorOutputS3Destination[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.RekognitionStreamProcessor.IRekognitionStreamProcessorOutputS3Destination).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _s3Destination = value;
            }
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.RekognitionStreamProcessor
{
    [JsiiByValue(fqn: "aws.rekognitionStreamProcessor.RekognitionStreamProcessorInput")]
    public class RekognitionStreamProcessorInput : aws.RekognitionStreamProcessor.IRekognitionStreamProcessorInput
    {
        private object? _kinesisVideoStream;

        /// <summary>kinesis_video_stream block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rekognition_stream_processor#kinesis_video_stream RekognitionStreamProcessor#kinesis_video_stream}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "kinesisVideoStream", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.rekognitionStreamProcessor.RekognitionStreamProcessorInputKinesisVideoStream\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? KinesisVideoStream
        {
            get => _kinesisVideoStream;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.RekognitionStreamProcessor.IRekognitionStreamProcessorInputKinesisVideoStream[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.RekognitionStreamProcessor.IRekognitionStreamProcessorInputKinesisVideoStream).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _kinesisVideoStream = value;
            }
        }
    }
}

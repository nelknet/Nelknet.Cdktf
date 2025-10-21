using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.RekognitionStreamProcessor
{
    [JsiiInterface(nativeType: typeof(IRekognitionStreamProcessorInput), fullyQualifiedName: "aws.rekognitionStreamProcessor.RekognitionStreamProcessorInput")]
    public interface IRekognitionStreamProcessorInput
    {
        /// <summary>kinesis_video_stream block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rekognition_stream_processor#kinesis_video_stream RekognitionStreamProcessor#kinesis_video_stream}
        /// </remarks>
        [JsiiProperty(name: "kinesisVideoStream", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.rekognitionStreamProcessor.RekognitionStreamProcessorInputKinesisVideoStream\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? KinesisVideoStream
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRekognitionStreamProcessorInput), fullyQualifiedName: "aws.rekognitionStreamProcessor.RekognitionStreamProcessorInput")]
        internal sealed class _Proxy : DeputyBase, aws.RekognitionStreamProcessor.IRekognitionStreamProcessorInput
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>kinesis_video_stream block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rekognition_stream_processor#kinesis_video_stream RekognitionStreamProcessor#kinesis_video_stream}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "kinesisVideoStream", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.rekognitionStreamProcessor.RekognitionStreamProcessorInputKinesisVideoStream\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? KinesisVideoStream
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}

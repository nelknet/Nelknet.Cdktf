using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.RekognitionStreamProcessor
{
    [JsiiInterface(nativeType: typeof(IRekognitionStreamProcessorInputKinesisVideoStream), fullyQualifiedName: "aws.rekognitionStreamProcessor.RekognitionStreamProcessorInputKinesisVideoStream")]
    public interface IRekognitionStreamProcessorInputKinesisVideoStream
    {
        /// <summary>ARN of the Kinesis video stream stream that streams the source video.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rekognition_stream_processor#arn RekognitionStreamProcessor#arn}
        /// </remarks>
        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        string Arn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IRekognitionStreamProcessorInputKinesisVideoStream), fullyQualifiedName: "aws.rekognitionStreamProcessor.RekognitionStreamProcessorInputKinesisVideoStream")]
        internal sealed class _Proxy : DeputyBase, aws.RekognitionStreamProcessor.IRekognitionStreamProcessorInputKinesisVideoStream
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>ARN of the Kinesis video stream stream that streams the source video.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rekognition_stream_processor#arn RekognitionStreamProcessor#arn}
            /// </remarks>
            [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
            public string Arn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.RekognitionStreamProcessor
{
    [JsiiByValue(fqn: "aws.rekognitionStreamProcessor.RekognitionStreamProcessorOutputKinesisDataStream")]
    public class RekognitionStreamProcessorOutputKinesisDataStream : aws.RekognitionStreamProcessor.IRekognitionStreamProcessorOutputKinesisDataStream
    {
        /// <summary>ARN of the output Amazon Kinesis Data Streams stream.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rekognition_stream_processor#arn RekognitionStreamProcessor#arn}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Arn
        {
            get;
            set;
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.RekognitionStreamProcessor
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.rekognitionStreamProcessor.RekognitionStreamProcessorInputKinesisVideoStream")]
    public class RekognitionStreamProcessorInputKinesisVideoStream : aws.RekognitionStreamProcessor.IRekognitionStreamProcessorInputKinesisVideoStream
    {
        /// <summary>ARN of the Kinesis video stream stream that streams the source video.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rekognition_stream_processor#arn RekognitionStreamProcessor#arn}
        /// </remarks>
        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public string Arn
        {
            get;
            set;
        }
    }
}

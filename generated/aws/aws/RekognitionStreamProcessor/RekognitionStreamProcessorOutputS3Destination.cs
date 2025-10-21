using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.RekognitionStreamProcessor
{
    [JsiiByValue(fqn: "aws.rekognitionStreamProcessor.RekognitionStreamProcessorOutputS3Destination")]
    public class RekognitionStreamProcessorOutputS3Destination : aws.RekognitionStreamProcessor.IRekognitionStreamProcessorOutputS3Destination
    {
        /// <summary>The name of the Amazon S3 bucket you want to associate with the streaming video project.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rekognition_stream_processor#bucket RekognitionStreamProcessor#bucket}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Bucket
        {
            get;
            set;
        }

        /// <summary>The prefix value of the location within the bucket that you want the information to be published to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rekognition_stream_processor#key_prefix RekognitionStreamProcessor#key_prefix}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "keyPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KeyPrefix
        {
            get;
            set;
        }
    }
}

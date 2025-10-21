using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.RekognitionStreamProcessor
{
    [JsiiByValue(fqn: "aws.rekognitionStreamProcessor.RekognitionStreamProcessorNotificationChannel")]
    public class RekognitionStreamProcessorNotificationChannel : aws.RekognitionStreamProcessor.IRekognitionStreamProcessorNotificationChannel
    {
        /// <summary>The Amazon Resource Number (ARN) of the Amazon Amazon Simple Notification Service topic to which Amazon Rekognition posts the completion status.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rekognition_stream_processor#sns_topic_arn RekognitionStreamProcessor#sns_topic_arn}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "snsTopicArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SnsTopicArn
        {
            get;
            set;
        }
    }
}

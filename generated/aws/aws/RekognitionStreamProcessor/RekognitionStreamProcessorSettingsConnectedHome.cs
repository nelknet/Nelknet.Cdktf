using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.RekognitionStreamProcessor
{
    [JsiiByValue(fqn: "aws.rekognitionStreamProcessor.RekognitionStreamProcessorSettingsConnectedHome")]
    public class RekognitionStreamProcessorSettingsConnectedHome : aws.RekognitionStreamProcessor.IRekognitionStreamProcessorSettingsConnectedHome
    {
        /// <summary>Specifies what you want to detect in the video, such as people, packages, or pets.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rekognition_stream_processor#labels RekognitionStreamProcessor#labels}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "labels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Labels
        {
            get;
            set;
        }

        /// <summary>The minimum confidence required to label an object in the video.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rekognition_stream_processor#min_confidence RekognitionStreamProcessor#min_confidence}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "minConfidence", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MinConfidence
        {
            get;
            set;
        }
    }
}

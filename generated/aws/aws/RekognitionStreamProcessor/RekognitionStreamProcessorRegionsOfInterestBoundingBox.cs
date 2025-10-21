using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.RekognitionStreamProcessor
{
    [JsiiByValue(fqn: "aws.rekognitionStreamProcessor.RekognitionStreamProcessorRegionsOfInterestBoundingBox")]
    public class RekognitionStreamProcessorRegionsOfInterestBoundingBox : aws.RekognitionStreamProcessor.IRekognitionStreamProcessorRegionsOfInterestBoundingBox
    {
        /// <summary>Height of the bounding box as a ratio of the overall image height.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rekognition_stream_processor#height RekognitionStreamProcessor#height}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "height", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Height
        {
            get;
            set;
        }

        /// <summary>Left coordinate of the bounding box as a ratio of overall image width.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rekognition_stream_processor#left RekognitionStreamProcessor#left}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "left", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Left
        {
            get;
            set;
        }

        /// <summary>Top coordinate of the bounding box as a ratio of overall image height.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rekognition_stream_processor#top RekognitionStreamProcessor#top}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "top", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Top
        {
            get;
            set;
        }

        /// <summary>Width of the bounding box as a ratio of the overall image width.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rekognition_stream_processor#width RekognitionStreamProcessor#width}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "width", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Width
        {
            get;
            set;
        }
    }
}

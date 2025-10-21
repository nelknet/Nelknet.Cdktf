using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.RekognitionStreamProcessor
{
    [JsiiByValue(fqn: "aws.rekognitionStreamProcessor.RekognitionStreamProcessorRegionsOfInterestPolygon")]
    public class RekognitionStreamProcessorRegionsOfInterestPolygon : aws.RekognitionStreamProcessor.IRekognitionStreamProcessorRegionsOfInterestPolygon
    {
        /// <summary>The value of the X coordinate for a point on a Polygon.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rekognition_stream_processor#x RekognitionStreamProcessor#x}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "x", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? X
        {
            get;
            set;
        }

        /// <summary>The value of the Y coordinate for a point on a Polygon.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rekognition_stream_processor#y RekognitionStreamProcessor#y}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "y", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Y
        {
            get;
            set;
        }
    }
}

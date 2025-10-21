using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.RekognitionStreamProcessor
{
    [JsiiByValue(fqn: "aws.rekognitionStreamProcessor.RekognitionStreamProcessorRegionsOfInterest")]
    public class RekognitionStreamProcessorRegionsOfInterest : aws.RekognitionStreamProcessor.IRekognitionStreamProcessorRegionsOfInterest
    {
        /// <summary>bounding_box block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rekognition_stream_processor#bounding_box RekognitionStreamProcessor#bounding_box}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "boundingBox", typeJson: "{\"fqn\":\"aws.rekognitionStreamProcessor.RekognitionStreamProcessorRegionsOfInterestBoundingBox\"}", isOptional: true)]
        public aws.RekognitionStreamProcessor.IRekognitionStreamProcessorRegionsOfInterestBoundingBox? BoundingBox
        {
            get;
            set;
        }

        private object? _polygon;

        /// <summary>polygon block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rekognition_stream_processor#polygon RekognitionStreamProcessor#polygon}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "polygon", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.rekognitionStreamProcessor.RekognitionStreamProcessorRegionsOfInterestPolygon\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Polygon
        {
            get => _polygon;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.RekognitionStreamProcessor.IRekognitionStreamProcessorRegionsOfInterestPolygon[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.RekognitionStreamProcessor.IRekognitionStreamProcessorRegionsOfInterestPolygon).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _polygon = value;
            }
        }
    }
}

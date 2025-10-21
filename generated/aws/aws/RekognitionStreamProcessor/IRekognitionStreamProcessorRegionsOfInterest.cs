using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.RekognitionStreamProcessor
{
    [JsiiInterface(nativeType: typeof(IRekognitionStreamProcessorRegionsOfInterest), fullyQualifiedName: "aws.rekognitionStreamProcessor.RekognitionStreamProcessorRegionsOfInterest")]
    public interface IRekognitionStreamProcessorRegionsOfInterest
    {
        /// <summary>bounding_box block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rekognition_stream_processor#bounding_box RekognitionStreamProcessor#bounding_box}
        /// </remarks>
        [JsiiProperty(name: "boundingBox", typeJson: "{\"fqn\":\"aws.rekognitionStreamProcessor.RekognitionStreamProcessorRegionsOfInterestBoundingBox\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.RekognitionStreamProcessor.IRekognitionStreamProcessorRegionsOfInterestBoundingBox? BoundingBox
        {
            get
            {
                return null;
            }
        }

        /// <summary>polygon block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rekognition_stream_processor#polygon RekognitionStreamProcessor#polygon}
        /// </remarks>
        [JsiiProperty(name: "polygon", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.rekognitionStreamProcessor.RekognitionStreamProcessorRegionsOfInterestPolygon\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Polygon
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRekognitionStreamProcessorRegionsOfInterest), fullyQualifiedName: "aws.rekognitionStreamProcessor.RekognitionStreamProcessorRegionsOfInterest")]
        internal sealed class _Proxy : DeputyBase, aws.RekognitionStreamProcessor.IRekognitionStreamProcessorRegionsOfInterest
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>bounding_box block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rekognition_stream_processor#bounding_box RekognitionStreamProcessor#bounding_box}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "boundingBox", typeJson: "{\"fqn\":\"aws.rekognitionStreamProcessor.RekognitionStreamProcessorRegionsOfInterestBoundingBox\"}", isOptional: true)]
            public aws.RekognitionStreamProcessor.IRekognitionStreamProcessorRegionsOfInterestBoundingBox? BoundingBox
            {
                get => GetInstanceProperty<aws.RekognitionStreamProcessor.IRekognitionStreamProcessorRegionsOfInterestBoundingBox?>();
            }

            /// <summary>polygon block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rekognition_stream_processor#polygon RekognitionStreamProcessor#polygon}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "polygon", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.rekognitionStreamProcessor.RekognitionStreamProcessorRegionsOfInterestPolygon\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Polygon
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}

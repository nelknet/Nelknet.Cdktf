using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.RekognitionStreamProcessor
{
    [JsiiInterface(nativeType: typeof(IRekognitionStreamProcessorRegionsOfInterestPolygon), fullyQualifiedName: "aws.rekognitionStreamProcessor.RekognitionStreamProcessorRegionsOfInterestPolygon")]
    public interface IRekognitionStreamProcessorRegionsOfInterestPolygon
    {
        /// <summary>The value of the X coordinate for a point on a Polygon.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rekognition_stream_processor#x RekognitionStreamProcessor#x}
        /// </remarks>
        [JsiiProperty(name: "x", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? X
        {
            get
            {
                return null;
            }
        }

        /// <summary>The value of the Y coordinate for a point on a Polygon.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rekognition_stream_processor#y RekognitionStreamProcessor#y}
        /// </remarks>
        [JsiiProperty(name: "y", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Y
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRekognitionStreamProcessorRegionsOfInterestPolygon), fullyQualifiedName: "aws.rekognitionStreamProcessor.RekognitionStreamProcessorRegionsOfInterestPolygon")]
        internal sealed class _Proxy : DeputyBase, aws.RekognitionStreamProcessor.IRekognitionStreamProcessorRegionsOfInterestPolygon
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The value of the X coordinate for a point on a Polygon.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rekognition_stream_processor#x RekognitionStreamProcessor#x}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "x", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? X
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The value of the Y coordinate for a point on a Polygon.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rekognition_stream_processor#y RekognitionStreamProcessor#y}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "y", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Y
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}

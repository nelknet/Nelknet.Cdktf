using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.RekognitionStreamProcessor
{
    [JsiiInterface(nativeType: typeof(IRekognitionStreamProcessorRegionsOfInterestBoundingBox), fullyQualifiedName: "aws.rekognitionStreamProcessor.RekognitionStreamProcessorRegionsOfInterestBoundingBox")]
    public interface IRekognitionStreamProcessorRegionsOfInterestBoundingBox
    {
        /// <summary>Height of the bounding box as a ratio of the overall image height.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rekognition_stream_processor#height RekognitionStreamProcessor#height}
        /// </remarks>
        [JsiiProperty(name: "height", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Height
        {
            get
            {
                return null;
            }
        }

        /// <summary>Left coordinate of the bounding box as a ratio of overall image width.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rekognition_stream_processor#left RekognitionStreamProcessor#left}
        /// </remarks>
        [JsiiProperty(name: "left", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Left
        {
            get
            {
                return null;
            }
        }

        /// <summary>Top coordinate of the bounding box as a ratio of overall image height.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rekognition_stream_processor#top RekognitionStreamProcessor#top}
        /// </remarks>
        [JsiiProperty(name: "top", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Top
        {
            get
            {
                return null;
            }
        }

        /// <summary>Width of the bounding box as a ratio of the overall image width.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rekognition_stream_processor#width RekognitionStreamProcessor#width}
        /// </remarks>
        [JsiiProperty(name: "width", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Width
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRekognitionStreamProcessorRegionsOfInterestBoundingBox), fullyQualifiedName: "aws.rekognitionStreamProcessor.RekognitionStreamProcessorRegionsOfInterestBoundingBox")]
        internal sealed class _Proxy : DeputyBase, aws.RekognitionStreamProcessor.IRekognitionStreamProcessorRegionsOfInterestBoundingBox
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Height of the bounding box as a ratio of the overall image height.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rekognition_stream_processor#height RekognitionStreamProcessor#height}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "height", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Height
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Left coordinate of the bounding box as a ratio of overall image width.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rekognition_stream_processor#left RekognitionStreamProcessor#left}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "left", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Left
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Top coordinate of the bounding box as a ratio of overall image height.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rekognition_stream_processor#top RekognitionStreamProcessor#top}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "top", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Top
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Width of the bounding box as a ratio of the overall image width.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rekognition_stream_processor#width RekognitionStreamProcessor#width}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "width", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Width
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}

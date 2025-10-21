using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.RekognitionStreamProcessor
{
    [JsiiInterface(nativeType: typeof(IRekognitionStreamProcessorSettingsConnectedHome), fullyQualifiedName: "aws.rekognitionStreamProcessor.RekognitionStreamProcessorSettingsConnectedHome")]
    public interface IRekognitionStreamProcessorSettingsConnectedHome
    {
        /// <summary>Specifies what you want to detect in the video, such as people, packages, or pets.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rekognition_stream_processor#labels RekognitionStreamProcessor#labels}
        /// </remarks>
        [JsiiProperty(name: "labels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Labels
        {
            get
            {
                return null;
            }
        }

        /// <summary>The minimum confidence required to label an object in the video.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rekognition_stream_processor#min_confidence RekognitionStreamProcessor#min_confidence}
        /// </remarks>
        [JsiiProperty(name: "minConfidence", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MinConfidence
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRekognitionStreamProcessorSettingsConnectedHome), fullyQualifiedName: "aws.rekognitionStreamProcessor.RekognitionStreamProcessorSettingsConnectedHome")]
        internal sealed class _Proxy : DeputyBase, aws.RekognitionStreamProcessor.IRekognitionStreamProcessorSettingsConnectedHome
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Specifies what you want to detect in the video, such as people, packages, or pets.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rekognition_stream_processor#labels RekognitionStreamProcessor#labels}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "labels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Labels
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>The minimum confidence required to label an object in the video.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rekognition_stream_processor#min_confidence RekognitionStreamProcessor#min_confidence}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "minConfidence", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MinConfidence
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.RekognitionStreamProcessor
{
    [JsiiInterface(nativeType: typeof(IRekognitionStreamProcessorSettingsFaceSearch), fullyQualifiedName: "aws.rekognitionStreamProcessor.RekognitionStreamProcessorSettingsFaceSearch")]
    public interface IRekognitionStreamProcessorSettingsFaceSearch
    {
        /// <summary>The ID of a collection that contains faces that you want to search for.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rekognition_stream_processor#collection_id RekognitionStreamProcessor#collection_id}
        /// </remarks>
        [JsiiProperty(name: "collectionId", typeJson: "{\"primitive\":\"string\"}")]
        string CollectionId
        {
            get;
        }

        /// <summary>Minimum face match confidence score that must be met to return a result for a recognized face.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rekognition_stream_processor#face_match_threshold RekognitionStreamProcessor#face_match_threshold}
        /// </remarks>
        [JsiiProperty(name: "faceMatchThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? FaceMatchThreshold
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRekognitionStreamProcessorSettingsFaceSearch), fullyQualifiedName: "aws.rekognitionStreamProcessor.RekognitionStreamProcessorSettingsFaceSearch")]
        internal sealed class _Proxy : DeputyBase, aws.RekognitionStreamProcessor.IRekognitionStreamProcessorSettingsFaceSearch
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The ID of a collection that contains faces that you want to search for.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rekognition_stream_processor#collection_id RekognitionStreamProcessor#collection_id}
            /// </remarks>
            [JsiiProperty(name: "collectionId", typeJson: "{\"primitive\":\"string\"}")]
            public string CollectionId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Minimum face match confidence score that must be met to return a result for a recognized face.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rekognition_stream_processor#face_match_threshold RekognitionStreamProcessor#face_match_threshold}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "faceMatchThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? FaceMatchThreshold
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}

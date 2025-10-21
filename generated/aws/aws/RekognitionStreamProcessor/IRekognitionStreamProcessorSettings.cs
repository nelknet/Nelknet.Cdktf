using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.RekognitionStreamProcessor
{
    [JsiiInterface(nativeType: typeof(IRekognitionStreamProcessorSettings), fullyQualifiedName: "aws.rekognitionStreamProcessor.RekognitionStreamProcessorSettings")]
    public interface IRekognitionStreamProcessorSettings
    {
        /// <summary>connected_home block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rekognition_stream_processor#connected_home RekognitionStreamProcessor#connected_home}
        /// </remarks>
        [JsiiProperty(name: "connectedHome", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.rekognitionStreamProcessor.RekognitionStreamProcessorSettingsConnectedHome\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ConnectedHome
        {
            get
            {
                return null;
            }
        }

        /// <summary>face_search block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rekognition_stream_processor#face_search RekognitionStreamProcessor#face_search}
        /// </remarks>
        [JsiiProperty(name: "faceSearch", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.rekognitionStreamProcessor.RekognitionStreamProcessorSettingsFaceSearch\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? FaceSearch
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRekognitionStreamProcessorSettings), fullyQualifiedName: "aws.rekognitionStreamProcessor.RekognitionStreamProcessorSettings")]
        internal sealed class _Proxy : DeputyBase, aws.RekognitionStreamProcessor.IRekognitionStreamProcessorSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>connected_home block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rekognition_stream_processor#connected_home RekognitionStreamProcessor#connected_home}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connectedHome", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.rekognitionStreamProcessor.RekognitionStreamProcessorSettingsConnectedHome\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ConnectedHome
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>face_search block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rekognition_stream_processor#face_search RekognitionStreamProcessor#face_search}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "faceSearch", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.rekognitionStreamProcessor.RekognitionStreamProcessorSettingsFaceSearch\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? FaceSearch
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}

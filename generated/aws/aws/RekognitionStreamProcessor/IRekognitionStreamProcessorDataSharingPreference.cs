using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.RekognitionStreamProcessor
{
    [JsiiInterface(nativeType: typeof(IRekognitionStreamProcessorDataSharingPreference), fullyQualifiedName: "aws.rekognitionStreamProcessor.RekognitionStreamProcessorDataSharingPreference")]
    public interface IRekognitionStreamProcessorDataSharingPreference
    {
        /// <summary>Do you want to share data with Rekognition to improve model performance.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rekognition_stream_processor#opt_in RekognitionStreamProcessor#opt_in}
        /// </remarks>
        [JsiiProperty(name: "optIn", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        object OptIn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IRekognitionStreamProcessorDataSharingPreference), fullyQualifiedName: "aws.rekognitionStreamProcessor.RekognitionStreamProcessorDataSharingPreference")]
        internal sealed class _Proxy : DeputyBase, aws.RekognitionStreamProcessor.IRekognitionStreamProcessorDataSharingPreference
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Do you want to share data with Rekognition to improve model performance.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rekognition_stream_processor#opt_in RekognitionStreamProcessor#opt_in}
            /// </remarks>
            [JsiiProperty(name: "optIn", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
            public object OptIn
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockInferenceProfile
{
    [JsiiInterface(nativeType: typeof(IBedrockInferenceProfileModelSource), fullyQualifiedName: "aws.bedrockInferenceProfile.BedrockInferenceProfileModelSource")]
    public interface IBedrockInferenceProfileModelSource
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrock_inference_profile#copy_from BedrockInferenceProfile#copy_from}.</summary>
        [JsiiProperty(name: "copyFrom", typeJson: "{\"primitive\":\"string\"}")]
        string CopyFrom
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockInferenceProfileModelSource), fullyQualifiedName: "aws.bedrockInferenceProfile.BedrockInferenceProfileModelSource")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockInferenceProfile.IBedrockInferenceProfileModelSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrock_inference_profile#copy_from BedrockInferenceProfile#copy_from}.</summary>
            [JsiiProperty(name: "copyFrom", typeJson: "{\"primitive\":\"string\"}")]
            public string CopyFrom
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}

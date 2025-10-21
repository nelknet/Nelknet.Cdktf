using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockCustomModel
{
    [JsiiInterface(nativeType: typeof(IBedrockCustomModelValidationDataConfigValidator), fullyQualifiedName: "aws.bedrockCustomModel.BedrockCustomModelValidationDataConfigValidator")]
    public interface IBedrockCustomModelValidationDataConfigValidator
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrock_custom_model#s3_uri BedrockCustomModel#s3_uri}.</summary>
        [JsiiProperty(name: "s3Uri", typeJson: "{\"primitive\":\"string\"}")]
        string S3Uri
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockCustomModelValidationDataConfigValidator), fullyQualifiedName: "aws.bedrockCustomModel.BedrockCustomModelValidationDataConfigValidator")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockCustomModel.IBedrockCustomModelValidationDataConfigValidator
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrock_custom_model#s3_uri BedrockCustomModel#s3_uri}.</summary>
            [JsiiProperty(name: "s3Uri", typeJson: "{\"primitive\":\"string\"}")]
            public string S3Uri
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockCustomModel
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.bedrockCustomModel.BedrockCustomModelValidationDataConfigValidator")]
    public class BedrockCustomModelValidationDataConfigValidator : aws.BedrockCustomModel.IBedrockCustomModelValidationDataConfigValidator
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrock_custom_model#s3_uri BedrockCustomModel#s3_uri}.</summary>
        [JsiiProperty(name: "s3Uri", typeJson: "{\"primitive\":\"string\"}")]
        public string S3Uri
        {
            get;
            set;
        }
    }
}

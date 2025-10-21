using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerUserProfile
{
    [JsiiByValue(fqn: "aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsCanvasAppSettingsGenerativeAiSettings")]
    public class SagemakerUserProfileUserSettingsCanvasAppSettingsGenerativeAiSettings : aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsCanvasAppSettingsGenerativeAiSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_user_profile#amazon_bedrock_role_arn SagemakerUserProfile#amazon_bedrock_role_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "amazonBedrockRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AmazonBedrockRoleArn
        {
            get;
            set;
        }
    }
}

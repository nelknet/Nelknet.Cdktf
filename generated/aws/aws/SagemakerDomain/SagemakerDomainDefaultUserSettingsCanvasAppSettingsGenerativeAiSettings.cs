using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerDomain
{
    [JsiiByValue(fqn: "aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsCanvasAppSettingsGenerativeAiSettings")]
    public class SagemakerDomainDefaultUserSettingsCanvasAppSettingsGenerativeAiSettings : aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCanvasAppSettingsGenerativeAiSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#amazon_bedrock_role_arn SagemakerDomain#amazon_bedrock_role_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "amazonBedrockRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AmazonBedrockRoleArn
        {
            get;
            set;
        }
    }
}

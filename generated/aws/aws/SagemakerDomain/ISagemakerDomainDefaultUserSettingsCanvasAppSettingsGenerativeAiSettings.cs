using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerDomain
{
    [JsiiInterface(nativeType: typeof(ISagemakerDomainDefaultUserSettingsCanvasAppSettingsGenerativeAiSettings), fullyQualifiedName: "aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsCanvasAppSettingsGenerativeAiSettings")]
    public interface ISagemakerDomainDefaultUserSettingsCanvasAppSettingsGenerativeAiSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#amazon_bedrock_role_arn SagemakerDomain#amazon_bedrock_role_arn}.</summary>
        [JsiiProperty(name: "amazonBedrockRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AmazonBedrockRoleArn
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerDomainDefaultUserSettingsCanvasAppSettingsGenerativeAiSettings), fullyQualifiedName: "aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsCanvasAppSettingsGenerativeAiSettings")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCanvasAppSettingsGenerativeAiSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#amazon_bedrock_role_arn SagemakerDomain#amazon_bedrock_role_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "amazonBedrockRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AmazonBedrockRoleArn
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

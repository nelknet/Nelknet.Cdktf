using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentPrompt
{
    [JsiiByValue(fqn: "aws.bedrockagentPrompt.BedrockagentPromptVariantTemplateConfigurationChatToolConfigurationToolToolSpecInputSchema")]
    public class BedrockagentPromptVariantTemplateConfigurationChatToolConfigurationToolToolSpecInputSchema : aws.BedrockagentPrompt.IBedrockagentPromptVariantTemplateConfigurationChatToolConfigurationToolToolSpecInputSchema
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_prompt#json BedrockagentPrompt#json}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "json", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Json
        {
            get;
            set;
        }
    }
}

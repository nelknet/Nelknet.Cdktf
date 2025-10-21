using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentPrompt
{
    [JsiiInterface(nativeType: typeof(IBedrockagentPromptVariantTemplateConfigurationChatToolConfigurationToolToolSpecInputSchema), fullyQualifiedName: "aws.bedrockagentPrompt.BedrockagentPromptVariantTemplateConfigurationChatToolConfigurationToolToolSpecInputSchema")]
    public interface IBedrockagentPromptVariantTemplateConfigurationChatToolConfigurationToolToolSpecInputSchema
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_prompt#json BedrockagentPrompt#json}.</summary>
        [JsiiProperty(name: "json", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Json
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentPromptVariantTemplateConfigurationChatToolConfigurationToolToolSpecInputSchema), fullyQualifiedName: "aws.bedrockagentPrompt.BedrockagentPromptVariantTemplateConfigurationChatToolConfigurationToolToolSpecInputSchema")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentPrompt.IBedrockagentPromptVariantTemplateConfigurationChatToolConfigurationToolToolSpecInputSchema
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_prompt#json BedrockagentPrompt#json}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "json", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Json
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

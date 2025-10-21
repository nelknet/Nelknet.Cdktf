using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentPrompt
{
    [JsiiInterface(nativeType: typeof(IBedrockagentPromptVariantGenAiResource), fullyQualifiedName: "aws.bedrockagentPrompt.BedrockagentPromptVariantGenAiResource")]
    public interface IBedrockagentPromptVariantGenAiResource
    {
        /// <summary>agent block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_prompt#agent BedrockagentPrompt#agent}
        /// </remarks>
        [JsiiProperty(name: "agent", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentPrompt.BedrockagentPromptVariantGenAiResourceAgent\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Agent
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentPromptVariantGenAiResource), fullyQualifiedName: "aws.bedrockagentPrompt.BedrockagentPromptVariantGenAiResource")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentPrompt.IBedrockagentPromptVariantGenAiResource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>agent block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_prompt#agent BedrockagentPrompt#agent}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "agent", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentPrompt.BedrockagentPromptVariantGenAiResourceAgent\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Agent
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}

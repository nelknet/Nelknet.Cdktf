using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentPrompt
{
    [JsiiInterface(nativeType: typeof(IBedrockagentPromptVariantGenAiResourceAgent), fullyQualifiedName: "aws.bedrockagentPrompt.BedrockagentPromptVariantGenAiResourceAgent")]
    public interface IBedrockagentPromptVariantGenAiResourceAgent
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_prompt#agent_identifier BedrockagentPrompt#agent_identifier}.</summary>
        [JsiiProperty(name: "agentIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        string AgentIdentifier
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentPromptVariantGenAiResourceAgent), fullyQualifiedName: "aws.bedrockagentPrompt.BedrockagentPromptVariantGenAiResourceAgent")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentPrompt.IBedrockagentPromptVariantGenAiResourceAgent
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_prompt#agent_identifier BedrockagentPrompt#agent_identifier}.</summary>
            [JsiiProperty(name: "agentIdentifier", typeJson: "{\"primitive\":\"string\"}")]
            public string AgentIdentifier
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}

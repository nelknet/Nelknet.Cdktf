using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentPrompt
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.bedrockagentPrompt.BedrockagentPromptVariantGenAiResourceAgent")]
    public class BedrockagentPromptVariantGenAiResourceAgent : aws.BedrockagentPrompt.IBedrockagentPromptVariantGenAiResourceAgent
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_prompt#agent_identifier BedrockagentPrompt#agent_identifier}.</summary>
        [JsiiProperty(name: "agentIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        public string AgentIdentifier
        {
            get;
            set;
        }
    }
}

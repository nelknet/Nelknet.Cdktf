using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentPrompt
{
    [JsiiByValue(fqn: "aws.bedrockagentPrompt.BedrockagentPromptVariantGenAiResource")]
    public class BedrockagentPromptVariantGenAiResource : aws.BedrockagentPrompt.IBedrockagentPromptVariantGenAiResource
    {
        private object? _agent;

        /// <summary>agent block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_prompt#agent BedrockagentPrompt#agent}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "agent", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentPrompt.BedrockagentPromptVariantGenAiResourceAgent\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Agent
        {
            get => _agent;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentPrompt.IBedrockagentPromptVariantGenAiResourceAgent[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.BedrockagentPrompt.IBedrockagentPromptVariantGenAiResourceAgent).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _agent = value;
            }
        }
    }
}

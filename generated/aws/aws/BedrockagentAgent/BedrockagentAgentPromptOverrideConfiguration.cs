using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentAgent
{
    [JsiiByValue(fqn: "aws.bedrockagentAgent.BedrockagentAgentPromptOverrideConfiguration")]
    public class BedrockagentAgentPromptOverrideConfiguration : aws.BedrockagentAgent.IBedrockagentAgentPromptOverrideConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent#override_lambda BedrockagentAgent#override_lambda}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "overrideLambda", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OverrideLambda
        {
            get;
            set;
        }

        private object? _promptConfigurations;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent#prompt_configurations BedrockagentAgent#prompt_configurations}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "promptConfigurations", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentAgent.BedrockagentAgentPromptOverrideConfigurationPromptConfigurations\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? PromptConfigurations
        {
            get => _promptConfigurations;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentAgent.IBedrockagentAgentPromptOverrideConfigurationPromptConfigurations[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.BedrockagentAgent.IBedrockagentAgentPromptOverrideConfigurationPromptConfigurations).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _promptConfigurations = value;
            }
        }
    }
}

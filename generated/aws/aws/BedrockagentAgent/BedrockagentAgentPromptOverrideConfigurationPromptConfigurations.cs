using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentAgent
{
    [JsiiByValue(fqn: "aws.bedrockagentAgent.BedrockagentAgentPromptOverrideConfigurationPromptConfigurations")]
    public class BedrockagentAgentPromptOverrideConfigurationPromptConfigurations : aws.BedrockagentAgent.IBedrockagentAgentPromptOverrideConfigurationPromptConfigurations
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent#base_prompt_template BedrockagentAgent#base_prompt_template}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "basePromptTemplate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BasePromptTemplate
        {
            get;
            set;
        }

        private object? _inferenceConfiguration;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent#inference_configuration BedrockagentAgent#inference_configuration}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "inferenceConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentAgent.BedrockagentAgentPromptOverrideConfigurationPromptConfigurationsInferenceConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? InferenceConfiguration
        {
            get => _inferenceConfiguration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentAgent.IBedrockagentAgentPromptOverrideConfigurationPromptConfigurationsInferenceConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.BedrockagentAgent.IBedrockagentAgentPromptOverrideConfigurationPromptConfigurationsInferenceConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _inferenceConfiguration = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent#parser_mode BedrockagentAgent#parser_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "parserMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ParserMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent#prompt_creation_mode BedrockagentAgent#prompt_creation_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "promptCreationMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PromptCreationMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent#prompt_state BedrockagentAgent#prompt_state}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "promptState", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PromptState
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent#prompt_type BedrockagentAgent#prompt_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "promptType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PromptType
        {
            get;
            set;
        }
    }
}

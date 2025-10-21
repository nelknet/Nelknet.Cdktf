using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentPrompt
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.bedrockagentPrompt.BedrockagentPromptVariantTemplateConfigurationText")]
    public class BedrockagentPromptVariantTemplateConfigurationText : aws.BedrockagentPrompt.IBedrockagentPromptVariantTemplateConfigurationText
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_prompt#text BedrockagentPrompt#text}.</summary>
        [JsiiProperty(name: "text", typeJson: "{\"primitive\":\"string\"}")]
        public string Text
        {
            get;
            set;
        }

        private object? _cachePoint;

        /// <summary>cache_point block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_prompt#cache_point BedrockagentPrompt#cache_point}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cachePoint", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentPrompt.BedrockagentPromptVariantTemplateConfigurationTextCachePoint\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CachePoint
        {
            get => _cachePoint;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentPrompt.IBedrockagentPromptVariantTemplateConfigurationTextCachePoint[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.BedrockagentPrompt.IBedrockagentPromptVariantTemplateConfigurationTextCachePoint).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _cachePoint = value;
            }
        }

        private object? _inputVariable;

        /// <summary>input_variable block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_prompt#input_variable BedrockagentPrompt#input_variable}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "inputVariable", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentPrompt.BedrockagentPromptVariantTemplateConfigurationTextInputVariable\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? InputVariable
        {
            get => _inputVariable;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentPrompt.IBedrockagentPromptVariantTemplateConfigurationTextInputVariable[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.BedrockagentPrompt.IBedrockagentPromptVariantTemplateConfigurationTextInputVariable).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _inputVariable = value;
            }
        }
    }
}

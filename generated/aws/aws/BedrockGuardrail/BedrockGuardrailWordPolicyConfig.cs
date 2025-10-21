using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockGuardrail
{
    [JsiiByValue(fqn: "aws.bedrockGuardrail.BedrockGuardrailWordPolicyConfig")]
    public class BedrockGuardrailWordPolicyConfig : aws.BedrockGuardrail.IBedrockGuardrailWordPolicyConfig
    {
        private object? _managedWordListsConfig;

        /// <summary>managed_word_lists_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrock_guardrail#managed_word_lists_config BedrockGuardrail#managed_word_lists_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "managedWordListsConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockGuardrail.BedrockGuardrailWordPolicyConfigManagedWordListsConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ManagedWordListsConfig
        {
            get => _managedWordListsConfig;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockGuardrail.IBedrockGuardrailWordPolicyConfigManagedWordListsConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.BedrockGuardrail.IBedrockGuardrailWordPolicyConfigManagedWordListsConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _managedWordListsConfig = value;
            }
        }

        private object? _wordsConfig;

        /// <summary>words_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrock_guardrail#words_config BedrockGuardrail#words_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "wordsConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockGuardrail.BedrockGuardrailWordPolicyConfigWordsConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? WordsConfig
        {
            get => _wordsConfig;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockGuardrail.IBedrockGuardrailWordPolicyConfigWordsConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.BedrockGuardrail.IBedrockGuardrailWordPolicyConfigWordsConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _wordsConfig = value;
            }
        }
    }
}

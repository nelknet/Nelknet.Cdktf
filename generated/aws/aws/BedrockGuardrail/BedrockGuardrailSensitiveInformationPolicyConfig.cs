using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockGuardrail
{
    [JsiiByValue(fqn: "aws.bedrockGuardrail.BedrockGuardrailSensitiveInformationPolicyConfig")]
    public class BedrockGuardrailSensitiveInformationPolicyConfig : aws.BedrockGuardrail.IBedrockGuardrailSensitiveInformationPolicyConfig
    {
        private object? _piiEntitiesConfig;

        /// <summary>pii_entities_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrock_guardrail#pii_entities_config BedrockGuardrail#pii_entities_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "piiEntitiesConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockGuardrail.BedrockGuardrailSensitiveInformationPolicyConfigPiiEntitiesConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? PiiEntitiesConfig
        {
            get => _piiEntitiesConfig;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockGuardrail.IBedrockGuardrailSensitiveInformationPolicyConfigPiiEntitiesConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.BedrockGuardrail.IBedrockGuardrailSensitiveInformationPolicyConfigPiiEntitiesConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _piiEntitiesConfig = value;
            }
        }

        private object? _regexesConfig;

        /// <summary>regexes_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrock_guardrail#regexes_config BedrockGuardrail#regexes_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "regexesConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockGuardrail.BedrockGuardrailSensitiveInformationPolicyConfigRegexesConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? RegexesConfig
        {
            get => _regexesConfig;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockGuardrail.IBedrockGuardrailSensitiveInformationPolicyConfigRegexesConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.BedrockGuardrail.IBedrockGuardrailSensitiveInformationPolicyConfigRegexesConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _regexesConfig = value;
            }
        }
    }
}

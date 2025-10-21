using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockGuardrail
{
    [JsiiInterface(nativeType: typeof(IBedrockGuardrailSensitiveInformationPolicyConfig), fullyQualifiedName: "aws.bedrockGuardrail.BedrockGuardrailSensitiveInformationPolicyConfig")]
    public interface IBedrockGuardrailSensitiveInformationPolicyConfig
    {
        /// <summary>pii_entities_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrock_guardrail#pii_entities_config BedrockGuardrail#pii_entities_config}
        /// </remarks>
        [JsiiProperty(name: "piiEntitiesConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockGuardrail.BedrockGuardrailSensitiveInformationPolicyConfigPiiEntitiesConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PiiEntitiesConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>regexes_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrock_guardrail#regexes_config BedrockGuardrail#regexes_config}
        /// </remarks>
        [JsiiProperty(name: "regexesConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockGuardrail.BedrockGuardrailSensitiveInformationPolicyConfigRegexesConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RegexesConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockGuardrailSensitiveInformationPolicyConfig), fullyQualifiedName: "aws.bedrockGuardrail.BedrockGuardrailSensitiveInformationPolicyConfig")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockGuardrail.IBedrockGuardrailSensitiveInformationPolicyConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>pii_entities_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrock_guardrail#pii_entities_config BedrockGuardrail#pii_entities_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "piiEntitiesConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockGuardrail.BedrockGuardrailSensitiveInformationPolicyConfigPiiEntitiesConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? PiiEntitiesConfig
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>regexes_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrock_guardrail#regexes_config BedrockGuardrail#regexes_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "regexesConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockGuardrail.BedrockGuardrailSensitiveInformationPolicyConfigRegexesConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RegexesConfig
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}

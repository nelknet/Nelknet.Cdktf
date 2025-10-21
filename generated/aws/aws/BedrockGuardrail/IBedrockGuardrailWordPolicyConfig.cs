using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockGuardrail
{
    [JsiiInterface(nativeType: typeof(IBedrockGuardrailWordPolicyConfig), fullyQualifiedName: "aws.bedrockGuardrail.BedrockGuardrailWordPolicyConfig")]
    public interface IBedrockGuardrailWordPolicyConfig
    {
        /// <summary>managed_word_lists_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrock_guardrail#managed_word_lists_config BedrockGuardrail#managed_word_lists_config}
        /// </remarks>
        [JsiiProperty(name: "managedWordListsConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockGuardrail.BedrockGuardrailWordPolicyConfigManagedWordListsConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ManagedWordListsConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>words_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrock_guardrail#words_config BedrockGuardrail#words_config}
        /// </remarks>
        [JsiiProperty(name: "wordsConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockGuardrail.BedrockGuardrailWordPolicyConfigWordsConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? WordsConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockGuardrailWordPolicyConfig), fullyQualifiedName: "aws.bedrockGuardrail.BedrockGuardrailWordPolicyConfig")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockGuardrail.IBedrockGuardrailWordPolicyConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>managed_word_lists_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrock_guardrail#managed_word_lists_config BedrockGuardrail#managed_word_lists_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "managedWordListsConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockGuardrail.BedrockGuardrailWordPolicyConfigManagedWordListsConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ManagedWordListsConfig
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>words_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrock_guardrail#words_config BedrockGuardrail#words_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "wordsConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockGuardrail.BedrockGuardrailWordPolicyConfigWordsConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? WordsConfig
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}

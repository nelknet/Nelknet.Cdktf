using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockGuardrail
{
    [JsiiInterface(nativeType: typeof(IBedrockGuardrailTopicPolicyConfig), fullyQualifiedName: "aws.bedrockGuardrail.BedrockGuardrailTopicPolicyConfig")]
    public interface IBedrockGuardrailTopicPolicyConfig
    {
        /// <summary>topics_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrock_guardrail#topics_config BedrockGuardrail#topics_config}
        /// </remarks>
        [JsiiProperty(name: "topicsConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockGuardrail.BedrockGuardrailTopicPolicyConfigTopicsConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? TopicsConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockGuardrailTopicPolicyConfig), fullyQualifiedName: "aws.bedrockGuardrail.BedrockGuardrailTopicPolicyConfig")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockGuardrail.IBedrockGuardrailTopicPolicyConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>topics_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrock_guardrail#topics_config BedrockGuardrail#topics_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "topicsConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockGuardrail.BedrockGuardrailTopicPolicyConfigTopicsConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? TopicsConfig
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}

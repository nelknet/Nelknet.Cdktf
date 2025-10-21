using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockGuardrail
{
    [JsiiInterface(nativeType: typeof(IBedrockGuardrailContextualGroundingPolicyConfig), fullyQualifiedName: "aws.bedrockGuardrail.BedrockGuardrailContextualGroundingPolicyConfig")]
    public interface IBedrockGuardrailContextualGroundingPolicyConfig
    {
        /// <summary>filters_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrock_guardrail#filters_config BedrockGuardrail#filters_config}
        /// </remarks>
        [JsiiProperty(name: "filtersConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockGuardrail.BedrockGuardrailContextualGroundingPolicyConfigFiltersConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? FiltersConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockGuardrailContextualGroundingPolicyConfig), fullyQualifiedName: "aws.bedrockGuardrail.BedrockGuardrailContextualGroundingPolicyConfig")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockGuardrail.IBedrockGuardrailContextualGroundingPolicyConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>filters_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrock_guardrail#filters_config BedrockGuardrail#filters_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "filtersConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockGuardrail.BedrockGuardrailContextualGroundingPolicyConfigFiltersConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? FiltersConfig
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}

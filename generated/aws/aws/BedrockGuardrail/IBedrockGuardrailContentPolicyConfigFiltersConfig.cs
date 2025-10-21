using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockGuardrail
{
    [JsiiInterface(nativeType: typeof(IBedrockGuardrailContentPolicyConfigFiltersConfig), fullyQualifiedName: "aws.bedrockGuardrail.BedrockGuardrailContentPolicyConfigFiltersConfig")]
    public interface IBedrockGuardrailContentPolicyConfigFiltersConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrock_guardrail#input_strength BedrockGuardrail#input_strength}.</summary>
        [JsiiProperty(name: "inputStrength", typeJson: "{\"primitive\":\"string\"}")]
        string InputStrength
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrock_guardrail#output_strength BedrockGuardrail#output_strength}.</summary>
        [JsiiProperty(name: "outputStrength", typeJson: "{\"primitive\":\"string\"}")]
        string OutputStrength
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrock_guardrail#type BedrockGuardrail#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockGuardrailContentPolicyConfigFiltersConfig), fullyQualifiedName: "aws.bedrockGuardrail.BedrockGuardrailContentPolicyConfigFiltersConfig")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockGuardrail.IBedrockGuardrailContentPolicyConfigFiltersConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrock_guardrail#input_strength BedrockGuardrail#input_strength}.</summary>
            [JsiiProperty(name: "inputStrength", typeJson: "{\"primitive\":\"string\"}")]
            public string InputStrength
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrock_guardrail#output_strength BedrockGuardrail#output_strength}.</summary>
            [JsiiProperty(name: "outputStrength", typeJson: "{\"primitive\":\"string\"}")]
            public string OutputStrength
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrock_guardrail#type BedrockGuardrail#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}

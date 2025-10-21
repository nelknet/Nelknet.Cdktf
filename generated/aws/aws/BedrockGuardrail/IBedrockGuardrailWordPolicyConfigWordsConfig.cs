using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockGuardrail
{
    [JsiiInterface(nativeType: typeof(IBedrockGuardrailWordPolicyConfigWordsConfig), fullyQualifiedName: "aws.bedrockGuardrail.BedrockGuardrailWordPolicyConfigWordsConfig")]
    public interface IBedrockGuardrailWordPolicyConfigWordsConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrock_guardrail#text BedrockGuardrail#text}.</summary>
        [JsiiProperty(name: "text", typeJson: "{\"primitive\":\"string\"}")]
        string Text
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockGuardrailWordPolicyConfigWordsConfig), fullyQualifiedName: "aws.bedrockGuardrail.BedrockGuardrailWordPolicyConfigWordsConfig")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockGuardrail.IBedrockGuardrailWordPolicyConfigWordsConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrock_guardrail#text BedrockGuardrail#text}.</summary>
            [JsiiProperty(name: "text", typeJson: "{\"primitive\":\"string\"}")]
            public string Text
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}

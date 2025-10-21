using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockGuardrail
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.bedrockGuardrail.BedrockGuardrailWordPolicyConfigWordsConfig")]
    public class BedrockGuardrailWordPolicyConfigWordsConfig : aws.BedrockGuardrail.IBedrockGuardrailWordPolicyConfigWordsConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrock_guardrail#text BedrockGuardrail#text}.</summary>
        [JsiiProperty(name: "text", typeJson: "{\"primitive\":\"string\"}")]
        public string Text
        {
            get;
            set;
        }
    }
}

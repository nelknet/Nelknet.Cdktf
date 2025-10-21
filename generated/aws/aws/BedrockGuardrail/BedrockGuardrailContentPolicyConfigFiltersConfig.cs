using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockGuardrail
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.bedrockGuardrail.BedrockGuardrailContentPolicyConfigFiltersConfig")]
    public class BedrockGuardrailContentPolicyConfigFiltersConfig : aws.BedrockGuardrail.IBedrockGuardrailContentPolicyConfigFiltersConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrock_guardrail#input_strength BedrockGuardrail#input_strength}.</summary>
        [JsiiProperty(name: "inputStrength", typeJson: "{\"primitive\":\"string\"}")]
        public string InputStrength
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrock_guardrail#output_strength BedrockGuardrail#output_strength}.</summary>
        [JsiiProperty(name: "outputStrength", typeJson: "{\"primitive\":\"string\"}")]
        public string OutputStrength
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrock_guardrail#type BedrockGuardrail#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }
    }
}

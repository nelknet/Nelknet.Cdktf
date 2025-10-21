using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentAgent
{
    [JsiiByValue(fqn: "aws.bedrockagentAgent.BedrockagentAgentGuardrailConfiguration")]
    public class BedrockagentAgentGuardrailConfiguration : aws.BedrockagentAgent.IBedrockagentAgentGuardrailConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent#guardrail_identifier BedrockagentAgent#guardrail_identifier}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "guardrailIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? GuardrailIdentifier
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent#guardrail_version BedrockagentAgent#guardrail_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "guardrailVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? GuardrailVersion
        {
            get;
            set;
        }
    }
}

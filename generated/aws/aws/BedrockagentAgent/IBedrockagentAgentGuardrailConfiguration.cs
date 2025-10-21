using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentAgent
{
    [JsiiInterface(nativeType: typeof(IBedrockagentAgentGuardrailConfiguration), fullyQualifiedName: "aws.bedrockagentAgent.BedrockagentAgentGuardrailConfiguration")]
    public interface IBedrockagentAgentGuardrailConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent#guardrail_identifier BedrockagentAgent#guardrail_identifier}.</summary>
        [JsiiProperty(name: "guardrailIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? GuardrailIdentifier
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent#guardrail_version BedrockagentAgent#guardrail_version}.</summary>
        [JsiiProperty(name: "guardrailVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? GuardrailVersion
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentAgentGuardrailConfiguration), fullyQualifiedName: "aws.bedrockagentAgent.BedrockagentAgentGuardrailConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentAgent.IBedrockagentAgentGuardrailConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent#guardrail_identifier BedrockagentAgent#guardrail_identifier}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "guardrailIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? GuardrailIdentifier
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent#guardrail_version BedrockagentAgent#guardrail_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "guardrailVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? GuardrailVersion
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsBedrockagentAgentVersions
{
    [JsiiInterface(nativeType: typeof(IDataAwsBedrockagentAgentVersionsAgentVersionSummaries), fullyQualifiedName: "aws.dataAwsBedrockagentAgentVersions.DataAwsBedrockagentAgentVersionsAgentVersionSummaries")]
    public interface IDataAwsBedrockagentAgentVersionsAgentVersionSummaries
    {
        /// <summary>guardrail_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/bedrockagent_agent_versions#guardrail_configuration DataAwsBedrockagentAgentVersions#guardrail_configuration}
        /// </remarks>
        [JsiiProperty(name: "guardrailConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsBedrockagentAgentVersions.DataAwsBedrockagentAgentVersionsAgentVersionSummariesGuardrailConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? GuardrailConfiguration
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsBedrockagentAgentVersionsAgentVersionSummaries), fullyQualifiedName: "aws.dataAwsBedrockagentAgentVersions.DataAwsBedrockagentAgentVersionsAgentVersionSummaries")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsBedrockagentAgentVersions.IDataAwsBedrockagentAgentVersionsAgentVersionSummaries
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>guardrail_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/bedrockagent_agent_versions#guardrail_configuration DataAwsBedrockagentAgentVersions#guardrail_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "guardrailConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsBedrockagentAgentVersions.DataAwsBedrockagentAgentVersionsAgentVersionSummariesGuardrailConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? GuardrailConfiguration
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsBedrockagentAgentVersions
{
    [JsiiByValue(fqn: "aws.dataAwsBedrockagentAgentVersions.DataAwsBedrockagentAgentVersionsAgentVersionSummaries")]
    public class DataAwsBedrockagentAgentVersionsAgentVersionSummaries : aws.DataAwsBedrockagentAgentVersions.IDataAwsBedrockagentAgentVersionsAgentVersionSummaries
    {
        private object? _guardrailConfiguration;

        /// <summary>guardrail_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/bedrockagent_agent_versions#guardrail_configuration DataAwsBedrockagentAgentVersions#guardrail_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "guardrailConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsBedrockagentAgentVersions.DataAwsBedrockagentAgentVersionsAgentVersionSummariesGuardrailConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? GuardrailConfiguration
        {
            get => _guardrailConfiguration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.DataAwsBedrockagentAgentVersions.IDataAwsBedrockagentAgentVersionsAgentVersionSummariesGuardrailConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.DataAwsBedrockagentAgentVersions.IDataAwsBedrockagentAgentVersionsAgentVersionSummariesGuardrailConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _guardrailConfiguration = value;
            }
        }
    }
}

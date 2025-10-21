using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentAgentAlias
{
    [JsiiByValue(fqn: "aws.bedrockagentAgentAlias.BedrockagentAgentAliasRoutingConfiguration")]
    public class BedrockagentAgentAliasRoutingConfiguration : aws.BedrockagentAgentAlias.IBedrockagentAgentAliasRoutingConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent_alias#agent_version BedrockagentAgentAlias#agent_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "agentVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AgentVersion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent_alias#provisioned_throughput BedrockagentAgentAlias#provisioned_throughput}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "provisionedThroughput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ProvisionedThroughput
        {
            get;
            set;
        }
    }
}

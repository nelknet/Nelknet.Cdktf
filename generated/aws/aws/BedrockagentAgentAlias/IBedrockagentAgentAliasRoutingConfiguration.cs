using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentAgentAlias
{
    [JsiiInterface(nativeType: typeof(IBedrockagentAgentAliasRoutingConfiguration), fullyQualifiedName: "aws.bedrockagentAgentAlias.BedrockagentAgentAliasRoutingConfiguration")]
    public interface IBedrockagentAgentAliasRoutingConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent_alias#agent_version BedrockagentAgentAlias#agent_version}.</summary>
        [JsiiProperty(name: "agentVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AgentVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent_alias#provisioned_throughput BedrockagentAgentAlias#provisioned_throughput}.</summary>
        [JsiiProperty(name: "provisionedThroughput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ProvisionedThroughput
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentAgentAliasRoutingConfiguration), fullyQualifiedName: "aws.bedrockagentAgentAlias.BedrockagentAgentAliasRoutingConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentAgentAlias.IBedrockagentAgentAliasRoutingConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent_alias#agent_version BedrockagentAgentAlias#agent_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "agentVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AgentVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent_alias#provisioned_throughput BedrockagentAgentAlias#provisioned_throughput}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "provisionedThroughput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ProvisionedThroughput
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentAgent
{
    [JsiiByValue(fqn: "aws.bedrockagentAgent.BedrockagentAgentMemoryConfiguration")]
    public class BedrockagentAgentMemoryConfiguration : aws.BedrockagentAgent.IBedrockagentAgentMemoryConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent#enabled_memory_types BedrockagentAgent#enabled_memory_types}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enabledMemoryTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? EnabledMemoryTypes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent#storage_days BedrockagentAgent#storage_days}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "storageDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? StorageDays
        {
            get;
            set;
        }
    }
}

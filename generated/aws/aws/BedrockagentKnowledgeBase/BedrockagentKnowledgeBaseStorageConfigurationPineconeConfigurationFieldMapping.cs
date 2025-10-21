using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentKnowledgeBase
{
    [JsiiByValue(fqn: "aws.bedrockagentKnowledgeBase.BedrockagentKnowledgeBaseStorageConfigurationPineconeConfigurationFieldMapping")]
    public class BedrockagentKnowledgeBaseStorageConfigurationPineconeConfigurationFieldMapping : aws.BedrockagentKnowledgeBase.IBedrockagentKnowledgeBaseStorageConfigurationPineconeConfigurationFieldMapping
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_knowledge_base#metadata_field BedrockagentKnowledgeBase#metadata_field}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "metadataField", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MetadataField
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_knowledge_base#text_field BedrockagentKnowledgeBase#text_field}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "textField", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TextField
        {
            get;
            set;
        }
    }
}

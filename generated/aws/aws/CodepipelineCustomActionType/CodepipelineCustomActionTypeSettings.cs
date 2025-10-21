using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CodepipelineCustomActionType
{
    [JsiiByValue(fqn: "aws.codepipelineCustomActionType.CodepipelineCustomActionTypeSettings")]
    public class CodepipelineCustomActionTypeSettings : aws.CodepipelineCustomActionType.ICodepipelineCustomActionTypeSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline_custom_action_type#entity_url_template CodepipelineCustomActionType#entity_url_template}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "entityUrlTemplate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EntityUrlTemplate
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline_custom_action_type#execution_url_template CodepipelineCustomActionType#execution_url_template}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "executionUrlTemplate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ExecutionUrlTemplate
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline_custom_action_type#revision_url_template CodepipelineCustomActionType#revision_url_template}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "revisionUrlTemplate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RevisionUrlTemplate
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline_custom_action_type#third_party_configuration_url CodepipelineCustomActionType#third_party_configuration_url}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "thirdPartyConfigurationUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ThirdPartyConfigurationUrl
        {
            get;
            set;
        }
    }
}

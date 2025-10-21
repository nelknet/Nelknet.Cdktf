using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CodepipelineCustomActionType
{
    [JsiiInterface(nativeType: typeof(ICodepipelineCustomActionTypeSettings), fullyQualifiedName: "aws.codepipelineCustomActionType.CodepipelineCustomActionTypeSettings")]
    public interface ICodepipelineCustomActionTypeSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline_custom_action_type#entity_url_template CodepipelineCustomActionType#entity_url_template}.</summary>
        [JsiiProperty(name: "entityUrlTemplate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EntityUrlTemplate
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline_custom_action_type#execution_url_template CodepipelineCustomActionType#execution_url_template}.</summary>
        [JsiiProperty(name: "executionUrlTemplate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ExecutionUrlTemplate
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline_custom_action_type#revision_url_template CodepipelineCustomActionType#revision_url_template}.</summary>
        [JsiiProperty(name: "revisionUrlTemplate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RevisionUrlTemplate
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline_custom_action_type#third_party_configuration_url CodepipelineCustomActionType#third_party_configuration_url}.</summary>
        [JsiiProperty(name: "thirdPartyConfigurationUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ThirdPartyConfigurationUrl
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICodepipelineCustomActionTypeSettings), fullyQualifiedName: "aws.codepipelineCustomActionType.CodepipelineCustomActionTypeSettings")]
        internal sealed class _Proxy : DeputyBase, aws.CodepipelineCustomActionType.ICodepipelineCustomActionTypeSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline_custom_action_type#entity_url_template CodepipelineCustomActionType#entity_url_template}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "entityUrlTemplate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EntityUrlTemplate
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline_custom_action_type#execution_url_template CodepipelineCustomActionType#execution_url_template}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "executionUrlTemplate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ExecutionUrlTemplate
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline_custom_action_type#revision_url_template CodepipelineCustomActionType#revision_url_template}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "revisionUrlTemplate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RevisionUrlTemplate
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline_custom_action_type#third_party_configuration_url CodepipelineCustomActionType#third_party_configuration_url}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "thirdPartyConfigurationUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ThirdPartyConfigurationUrl
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

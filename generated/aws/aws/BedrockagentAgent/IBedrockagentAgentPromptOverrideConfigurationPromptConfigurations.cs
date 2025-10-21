using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentAgent
{
    [JsiiInterface(nativeType: typeof(IBedrockagentAgentPromptOverrideConfigurationPromptConfigurations), fullyQualifiedName: "aws.bedrockagentAgent.BedrockagentAgentPromptOverrideConfigurationPromptConfigurations")]
    public interface IBedrockagentAgentPromptOverrideConfigurationPromptConfigurations
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent#base_prompt_template BedrockagentAgent#base_prompt_template}.</summary>
        [JsiiProperty(name: "basePromptTemplate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BasePromptTemplate
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent#inference_configuration BedrockagentAgent#inference_configuration}.</summary>
        [JsiiProperty(name: "inferenceConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentAgent.BedrockagentAgentPromptOverrideConfigurationPromptConfigurationsInferenceConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? InferenceConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent#parser_mode BedrockagentAgent#parser_mode}.</summary>
        [JsiiProperty(name: "parserMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ParserMode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent#prompt_creation_mode BedrockagentAgent#prompt_creation_mode}.</summary>
        [JsiiProperty(name: "promptCreationMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PromptCreationMode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent#prompt_state BedrockagentAgent#prompt_state}.</summary>
        [JsiiProperty(name: "promptState", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PromptState
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent#prompt_type BedrockagentAgent#prompt_type}.</summary>
        [JsiiProperty(name: "promptType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PromptType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentAgentPromptOverrideConfigurationPromptConfigurations), fullyQualifiedName: "aws.bedrockagentAgent.BedrockagentAgentPromptOverrideConfigurationPromptConfigurations")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentAgent.IBedrockagentAgentPromptOverrideConfigurationPromptConfigurations
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent#base_prompt_template BedrockagentAgent#base_prompt_template}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "basePromptTemplate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BasePromptTemplate
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent#inference_configuration BedrockagentAgent#inference_configuration}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "inferenceConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentAgent.BedrockagentAgentPromptOverrideConfigurationPromptConfigurationsInferenceConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? InferenceConfiguration
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent#parser_mode BedrockagentAgent#parser_mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "parserMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ParserMode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent#prompt_creation_mode BedrockagentAgent#prompt_creation_mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "promptCreationMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PromptCreationMode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent#prompt_state BedrockagentAgent#prompt_state}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "promptState", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PromptState
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent#prompt_type BedrockagentAgent#prompt_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "promptType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PromptType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

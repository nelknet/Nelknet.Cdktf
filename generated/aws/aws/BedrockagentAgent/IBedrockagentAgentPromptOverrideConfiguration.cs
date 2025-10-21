using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentAgent
{
    [JsiiInterface(nativeType: typeof(IBedrockagentAgentPromptOverrideConfiguration), fullyQualifiedName: "aws.bedrockagentAgent.BedrockagentAgentPromptOverrideConfiguration")]
    public interface IBedrockagentAgentPromptOverrideConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent#override_lambda BedrockagentAgent#override_lambda}.</summary>
        [JsiiProperty(name: "overrideLambda", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OverrideLambda
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent#prompt_configurations BedrockagentAgent#prompt_configurations}.</summary>
        [JsiiProperty(name: "promptConfigurations", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentAgent.BedrockagentAgentPromptOverrideConfigurationPromptConfigurations\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PromptConfigurations
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentAgentPromptOverrideConfiguration), fullyQualifiedName: "aws.bedrockagentAgent.BedrockagentAgentPromptOverrideConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentAgent.IBedrockagentAgentPromptOverrideConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent#override_lambda BedrockagentAgent#override_lambda}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "overrideLambda", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OverrideLambda
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent#prompt_configurations BedrockagentAgent#prompt_configurations}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "promptConfigurations", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentAgent.BedrockagentAgentPromptOverrideConfigurationPromptConfigurations\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? PromptConfigurations
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}

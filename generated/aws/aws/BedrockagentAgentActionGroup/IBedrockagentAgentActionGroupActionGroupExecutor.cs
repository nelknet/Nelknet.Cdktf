using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentAgentActionGroup
{
    [JsiiInterface(nativeType: typeof(IBedrockagentAgentActionGroupActionGroupExecutor), fullyQualifiedName: "aws.bedrockagentAgentActionGroup.BedrockagentAgentActionGroupActionGroupExecutor")]
    public interface IBedrockagentAgentActionGroupActionGroupExecutor
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent_action_group#custom_control BedrockagentAgentActionGroup#custom_control}.</summary>
        [JsiiProperty(name: "customControl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CustomControl
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent_action_group#lambda BedrockagentAgentActionGroup#lambda}.</summary>
        [JsiiProperty(name: "lambda", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Lambda
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentAgentActionGroupActionGroupExecutor), fullyQualifiedName: "aws.bedrockagentAgentActionGroup.BedrockagentAgentActionGroupActionGroupExecutor")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentAgentActionGroup.IBedrockagentAgentActionGroupActionGroupExecutor
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent_action_group#custom_control BedrockagentAgentActionGroup#custom_control}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "customControl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CustomControl
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent_action_group#lambda BedrockagentAgentActionGroup#lambda}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "lambda", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Lambda
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

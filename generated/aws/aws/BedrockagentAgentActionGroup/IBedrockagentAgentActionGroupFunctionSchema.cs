using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentAgentActionGroup
{
    [JsiiInterface(nativeType: typeof(IBedrockagentAgentActionGroupFunctionSchema), fullyQualifiedName: "aws.bedrockagentAgentActionGroup.BedrockagentAgentActionGroupFunctionSchema")]
    public interface IBedrockagentAgentActionGroupFunctionSchema
    {
        /// <summary>member_functions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent_action_group#member_functions BedrockagentAgentActionGroup#member_functions}
        /// </remarks>
        [JsiiProperty(name: "memberFunctions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentAgentActionGroup.BedrockagentAgentActionGroupFunctionSchemaMemberFunctions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? MemberFunctions
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentAgentActionGroupFunctionSchema), fullyQualifiedName: "aws.bedrockagentAgentActionGroup.BedrockagentAgentActionGroupFunctionSchema")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentAgentActionGroup.IBedrockagentAgentActionGroupFunctionSchema
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>member_functions block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent_action_group#member_functions BedrockagentAgentActionGroup#member_functions}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "memberFunctions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentAgentActionGroup.BedrockagentAgentActionGroupFunctionSchemaMemberFunctions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? MemberFunctions
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}

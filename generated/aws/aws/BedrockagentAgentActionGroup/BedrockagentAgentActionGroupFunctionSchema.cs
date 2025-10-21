using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentAgentActionGroup
{
    [JsiiByValue(fqn: "aws.bedrockagentAgentActionGroup.BedrockagentAgentActionGroupFunctionSchema")]
    public class BedrockagentAgentActionGroupFunctionSchema : aws.BedrockagentAgentActionGroup.IBedrockagentAgentActionGroupFunctionSchema
    {
        private object? _memberFunctions;

        /// <summary>member_functions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent_action_group#member_functions BedrockagentAgentActionGroup#member_functions}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "memberFunctions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentAgentActionGroup.BedrockagentAgentActionGroupFunctionSchemaMemberFunctions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? MemberFunctions
        {
            get => _memberFunctions;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentAgentActionGroup.IBedrockagentAgentActionGroupFunctionSchemaMemberFunctions[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.BedrockagentAgentActionGroup.IBedrockagentAgentActionGroupFunctionSchemaMemberFunctions).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _memberFunctions = value;
            }
        }
    }
}

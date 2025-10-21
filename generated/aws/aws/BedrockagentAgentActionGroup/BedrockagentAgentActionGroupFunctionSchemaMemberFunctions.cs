using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentAgentActionGroup
{
    [JsiiByValue(fqn: "aws.bedrockagentAgentActionGroup.BedrockagentAgentActionGroupFunctionSchemaMemberFunctions")]
    public class BedrockagentAgentActionGroupFunctionSchemaMemberFunctions : aws.BedrockagentAgentActionGroup.IBedrockagentAgentActionGroupFunctionSchemaMemberFunctions
    {
        private object? _functions;

        /// <summary>functions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent_action_group#functions BedrockagentAgentActionGroup#functions}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "functions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentAgentActionGroup.BedrockagentAgentActionGroupFunctionSchemaMemberFunctionsFunctions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Functions
        {
            get => _functions;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentAgentActionGroup.IBedrockagentAgentActionGroupFunctionSchemaMemberFunctionsFunctions[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.BedrockagentAgentActionGroup.IBedrockagentAgentActionGroupFunctionSchemaMemberFunctionsFunctions).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _functions = value;
            }
        }
    }
}

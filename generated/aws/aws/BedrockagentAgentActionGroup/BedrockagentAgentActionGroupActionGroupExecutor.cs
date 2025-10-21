using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentAgentActionGroup
{
    [JsiiByValue(fqn: "aws.bedrockagentAgentActionGroup.BedrockagentAgentActionGroupActionGroupExecutor")]
    public class BedrockagentAgentActionGroupActionGroupExecutor : aws.BedrockagentAgentActionGroup.IBedrockagentAgentActionGroupActionGroupExecutor
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent_action_group#custom_control BedrockagentAgentActionGroup#custom_control}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "customControl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CustomControl
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent_action_group#lambda BedrockagentAgentActionGroup#lambda}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "lambda", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Lambda
        {
            get;
            set;
        }
    }
}

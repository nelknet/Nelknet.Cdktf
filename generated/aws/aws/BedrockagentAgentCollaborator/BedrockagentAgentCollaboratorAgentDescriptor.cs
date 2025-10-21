using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentAgentCollaborator
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.bedrockagentAgentCollaborator.BedrockagentAgentCollaboratorAgentDescriptor")]
    public class BedrockagentAgentCollaboratorAgentDescriptor : aws.BedrockagentAgentCollaborator.IBedrockagentAgentCollaboratorAgentDescriptor
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent_collaborator#alias_arn BedrockagentAgentCollaborator#alias_arn}.</summary>
        [JsiiProperty(name: "aliasArn", typeJson: "{\"primitive\":\"string\"}")]
        public string AliasArn
        {
            get;
            set;
        }
    }
}

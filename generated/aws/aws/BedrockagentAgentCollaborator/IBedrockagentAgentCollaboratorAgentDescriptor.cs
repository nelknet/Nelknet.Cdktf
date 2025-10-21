using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentAgentCollaborator
{
    [JsiiInterface(nativeType: typeof(IBedrockagentAgentCollaboratorAgentDescriptor), fullyQualifiedName: "aws.bedrockagentAgentCollaborator.BedrockagentAgentCollaboratorAgentDescriptor")]
    public interface IBedrockagentAgentCollaboratorAgentDescriptor
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent_collaborator#alias_arn BedrockagentAgentCollaborator#alias_arn}.</summary>
        [JsiiProperty(name: "aliasArn", typeJson: "{\"primitive\":\"string\"}")]
        string AliasArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentAgentCollaboratorAgentDescriptor), fullyQualifiedName: "aws.bedrockagentAgentCollaborator.BedrockagentAgentCollaboratorAgentDescriptor")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentAgentCollaborator.IBedrockagentAgentCollaboratorAgentDescriptor
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent_collaborator#alias_arn BedrockagentAgentCollaborator#alias_arn}.</summary>
            [JsiiProperty(name: "aliasArn", typeJson: "{\"primitive\":\"string\"}")]
            public string AliasArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}

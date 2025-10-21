namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type BedrockagentAgentCollaboratorState<'AgentId, 'CollaborationInstruction, 'CollaboratorName> = { assignments: ResizeArray<aws.BedrockagentAgentCollaborator.BedrockagentAgentCollaboratorConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent_collaborator">aws_bedrockagent_agent_collaborator</a>.
    /// </summary>
    type BedrockagentAgentCollaboratorBuilder(logicalId: string) =
        member _.Yield(_: unit) : BedrockagentAgentCollaboratorState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : BedrockagentAgentCollaboratorState<Missing, Missing, Missing>)

        member _.Zero(()) : BedrockagentAgentCollaboratorState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : BedrockagentAgentCollaboratorState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent_collaborator#agent_id-1">BedrockagentAgentCollaborator#agent_id</a>.
        /// </summary>
        [<CustomOperation "agent_id">]
        member _.AgentId(state: BedrockagentAgentCollaboratorState<Missing, 'CollaborationInstruction, 'CollaboratorName>, value: string) : BedrockagentAgentCollaboratorState<Present, 'CollaborationInstruction, 'CollaboratorName> =
            state.assignments.Add(fun config -> config.AgentId <- value)
            ({ assignments = state.assignments } : BedrockagentAgentCollaboratorState<Present, 'CollaborationInstruction, 'CollaboratorName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent_collaborator#collaboration_instruction-1">BedrockagentAgentCollaborator#collaboration_instruction</a>.
        /// </summary>
        [<CustomOperation "collaboration_instruction">]
        member _.CollaborationInstruction(state: BedrockagentAgentCollaboratorState<'AgentId, Missing, 'CollaboratorName>, value: string) : BedrockagentAgentCollaboratorState<'AgentId, Present, 'CollaboratorName> =
            state.assignments.Add(fun config -> config.CollaborationInstruction <- value)
            ({ assignments = state.assignments } : BedrockagentAgentCollaboratorState<'AgentId, Present, 'CollaboratorName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent_collaborator#collaborator_name-1">BedrockagentAgentCollaborator#collaborator_name</a>.
        /// </summary>
        [<CustomOperation "collaborator_name">]
        member _.CollaboratorName(state: BedrockagentAgentCollaboratorState<'AgentId, 'CollaborationInstruction, Missing>, value: string) : BedrockagentAgentCollaboratorState<'AgentId, 'CollaborationInstruction, Present> =
            state.assignments.Add(fun config -> config.CollaboratorName <- value)
            ({ assignments = state.assignments } : BedrockagentAgentCollaboratorState<'AgentId, 'CollaborationInstruction, Present>)

        /// <summary>
        /// agent_descriptor block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent_collaborator#agent_descriptor-1">BedrockagentAgentCollaborator#agent_descriptor</a> Accepts: aws.IResolvable | aws.BedrockagentAgentCollaborator.BedrockagentAgentCollaboratorAgentDescriptor[]
        /// </summary>
        [<CustomOperation "agent_descriptor">]
        member _.AgentDescriptor(state: BedrockagentAgentCollaboratorState<'AgentId, 'CollaborationInstruction, 'CollaboratorName>, value: HashiCorp.Cdktf.IResolvable) : BedrockagentAgentCollaboratorState<'AgentId, 'CollaborationInstruction, 'CollaboratorName> =
            state.assignments.Add(fun config -> config.AgentDescriptor <- value)
            state : BedrockagentAgentCollaboratorState<'AgentId, 'CollaborationInstruction, 'CollaboratorName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent_collaborator#agent_version-1">BedrockagentAgentCollaborator#agent_version</a>.
        /// </summary>
        [<CustomOperation "agent_version">]
        member _.AgentVersion(state: BedrockagentAgentCollaboratorState<'AgentId, 'CollaborationInstruction, 'CollaboratorName>, value: string) : BedrockagentAgentCollaboratorState<'AgentId, 'CollaborationInstruction, 'CollaboratorName> =
            state.assignments.Add(fun config -> config.AgentVersion <- value)
            state : BedrockagentAgentCollaboratorState<'AgentId, 'CollaborationInstruction, 'CollaboratorName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent_collaborator#prepare_agent-1">BedrockagentAgentCollaborator#prepare_agent</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "prepare_agent">]
        member _.PrepareAgent(state: BedrockagentAgentCollaboratorState<'AgentId, 'CollaborationInstruction, 'CollaboratorName>, value: bool) : BedrockagentAgentCollaboratorState<'AgentId, 'CollaborationInstruction, 'CollaboratorName> =
            state.assignments.Add(fun config -> config.PrepareAgent <- value)
            state : BedrockagentAgentCollaboratorState<'AgentId, 'CollaborationInstruction, 'CollaboratorName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent_collaborator#prepare_agent-1">BedrockagentAgentCollaborator#prepare_agent</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "prepare_agent">]
        member _.PrepareAgent(state: BedrockagentAgentCollaboratorState<'AgentId, 'CollaborationInstruction, 'CollaboratorName>, value: HashiCorp.Cdktf.IResolvable) : BedrockagentAgentCollaboratorState<'AgentId, 'CollaborationInstruction, 'CollaboratorName> =
            state.assignments.Add(fun config -> config.PrepareAgent <- value)
            state : BedrockagentAgentCollaboratorState<'AgentId, 'CollaborationInstruction, 'CollaboratorName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent_collaborator#relay_conversation_history-1">BedrockagentAgentCollaborator#relay_conversation_history</a>.
        /// </summary>
        [<CustomOperation "relay_conversation_history">]
        member _.RelayConversationHistory(state: BedrockagentAgentCollaboratorState<'AgentId, 'CollaborationInstruction, 'CollaboratorName>, value: string) : BedrockagentAgentCollaboratorState<'AgentId, 'CollaborationInstruction, 'CollaboratorName> =
            state.assignments.Add(fun config -> config.RelayConversationHistory <- value)
            state : BedrockagentAgentCollaboratorState<'AgentId, 'CollaborationInstruction, 'CollaboratorName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent_collaborator#timeouts-1">BedrockagentAgentCollaborator#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: BedrockagentAgentCollaboratorState<'AgentId, 'CollaborationInstruction, 'CollaboratorName>, value: aws.BedrockagentAgentCollaborator.BedrockagentAgentCollaboratorTimeouts) : BedrockagentAgentCollaboratorState<'AgentId, 'CollaborationInstruction, 'CollaboratorName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : BedrockagentAgentCollaboratorState<'AgentId, 'CollaborationInstruction, 'CollaboratorName>

        member _.Run(state: BedrockagentAgentCollaboratorState<Present, Present, Present>) : aws.BedrockagentAgentCollaborator.BedrockagentAgentCollaborator =
            let config = aws.BedrockagentAgentCollaborator.BedrockagentAgentCollaboratorConfig()
            for setter in state.assignments do
                setter config
            aws.BedrockagentAgentCollaborator.BedrockagentAgentCollaborator(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.bedrockagentAgentCollaborator: missing required arguments. Must call: agent_id, collaboration_instruction, collaborator_name.", 9999, IsError = true)>]
        member _.Run(_: BedrockagentAgentCollaboratorState<_, _, _>) : aws.BedrockagentAgentCollaborator.BedrockagentAgentCollaborator =
            Unchecked.defaultof<aws.BedrockagentAgentCollaborator.BedrockagentAgentCollaborator>

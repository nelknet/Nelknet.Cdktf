namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type BedrockagentAgentKnowledgeBaseAssociationState<'AgentId, 'Description, 'KnowledgeBaseId, 'KnowledgeBaseState> = { assignments: ResizeArray<aws.BedrockagentAgentKnowledgeBaseAssociation.BedrockagentAgentKnowledgeBaseAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent_knowledge_base_association">aws_bedrockagent_agent_knowledge_base_association</a>.
    /// </summary>
    type BedrockagentAgentKnowledgeBaseAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : BedrockagentAgentKnowledgeBaseAssociationState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : BedrockagentAgentKnowledgeBaseAssociationState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : BedrockagentAgentKnowledgeBaseAssociationState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : BedrockagentAgentKnowledgeBaseAssociationState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent_knowledge_base_association#agent_id-1">BedrockagentAgentKnowledgeBaseAssociation#agent_id</a>.
        /// </summary>
        [<CustomOperation "agent_id">]
        member _.AgentId(state: BedrockagentAgentKnowledgeBaseAssociationState<Missing, 'Description, 'KnowledgeBaseId, 'KnowledgeBaseState>, value: string) : BedrockagentAgentKnowledgeBaseAssociationState<Present, 'Description, 'KnowledgeBaseId, 'KnowledgeBaseState> =
            state.assignments.Add(fun config -> config.AgentId <- value)
            ({ assignments = state.assignments } : BedrockagentAgentKnowledgeBaseAssociationState<Present, 'Description, 'KnowledgeBaseId, 'KnowledgeBaseState>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent_knowledge_base_association#description-1">BedrockagentAgentKnowledgeBaseAssociation#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: BedrockagentAgentKnowledgeBaseAssociationState<'AgentId, Missing, 'KnowledgeBaseId, 'KnowledgeBaseState>, value: string) : BedrockagentAgentKnowledgeBaseAssociationState<'AgentId, Present, 'KnowledgeBaseId, 'KnowledgeBaseState> =
            state.assignments.Add(fun config -> config.Description <- value)
            ({ assignments = state.assignments } : BedrockagentAgentKnowledgeBaseAssociationState<'AgentId, Present, 'KnowledgeBaseId, 'KnowledgeBaseState>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent_knowledge_base_association#knowledge_base_id-1">BedrockagentAgentKnowledgeBaseAssociation#knowledge_base_id</a>.
        /// </summary>
        [<CustomOperation "knowledge_base_id">]
        member _.KnowledgeBaseId(state: BedrockagentAgentKnowledgeBaseAssociationState<'AgentId, 'Description, Missing, 'KnowledgeBaseState>, value: string) : BedrockagentAgentKnowledgeBaseAssociationState<'AgentId, 'Description, Present, 'KnowledgeBaseState> =
            state.assignments.Add(fun config -> config.KnowledgeBaseId <- value)
            ({ assignments = state.assignments } : BedrockagentAgentKnowledgeBaseAssociationState<'AgentId, 'Description, Present, 'KnowledgeBaseState>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent_knowledge_base_association#knowledge_base_state-1">BedrockagentAgentKnowledgeBaseAssociation#knowledge_base_state</a>.
        /// </summary>
        [<CustomOperation "knowledge_base_state">]
        member _.KnowledgeBaseState(state: BedrockagentAgentKnowledgeBaseAssociationState<'AgentId, 'Description, 'KnowledgeBaseId, Missing>, value: string) : BedrockagentAgentKnowledgeBaseAssociationState<'AgentId, 'Description, 'KnowledgeBaseId, Present> =
            state.assignments.Add(fun config -> config.KnowledgeBaseState <- value)
            ({ assignments = state.assignments } : BedrockagentAgentKnowledgeBaseAssociationState<'AgentId, 'Description, 'KnowledgeBaseId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent_knowledge_base_association#agent_version-1">BedrockagentAgentKnowledgeBaseAssociation#agent_version</a>.
        /// </summary>
        [<CustomOperation "agent_version">]
        member _.AgentVersion(state: BedrockagentAgentKnowledgeBaseAssociationState<'AgentId, 'Description, 'KnowledgeBaseId, 'KnowledgeBaseState>, value: string) : BedrockagentAgentKnowledgeBaseAssociationState<'AgentId, 'Description, 'KnowledgeBaseId, 'KnowledgeBaseState> =
            state.assignments.Add(fun config -> config.AgentVersion <- value)
            state : BedrockagentAgentKnowledgeBaseAssociationState<'AgentId, 'Description, 'KnowledgeBaseId, 'KnowledgeBaseState>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent_knowledge_base_association#timeouts-1">BedrockagentAgentKnowledgeBaseAssociation#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: BedrockagentAgentKnowledgeBaseAssociationState<'AgentId, 'Description, 'KnowledgeBaseId, 'KnowledgeBaseState>, value: aws.BedrockagentAgentKnowledgeBaseAssociation.BedrockagentAgentKnowledgeBaseAssociationTimeouts) : BedrockagentAgentKnowledgeBaseAssociationState<'AgentId, 'Description, 'KnowledgeBaseId, 'KnowledgeBaseState> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : BedrockagentAgentKnowledgeBaseAssociationState<'AgentId, 'Description, 'KnowledgeBaseId, 'KnowledgeBaseState>

        member _.Run(state: BedrockagentAgentKnowledgeBaseAssociationState<Present, Present, Present, Present>) : aws.BedrockagentAgentKnowledgeBaseAssociation.BedrockagentAgentKnowledgeBaseAssociation =
            let config = aws.BedrockagentAgentKnowledgeBaseAssociation.BedrockagentAgentKnowledgeBaseAssociationConfig()
            for setter in state.assignments do
                setter config
            aws.BedrockagentAgentKnowledgeBaseAssociation.BedrockagentAgentKnowledgeBaseAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.bedrockagentAgentKnowledgeBaseAssociation: missing required arguments. Must call: agent_id, description, knowledge_base_id, knowledge_base_state.", 9999, IsError = true)>]
        member _.Run(_: BedrockagentAgentKnowledgeBaseAssociationState<_, _, _, _>) : aws.BedrockagentAgentKnowledgeBaseAssociation.BedrockagentAgentKnowledgeBaseAssociation =
            Unchecked.defaultof<aws.BedrockagentAgentKnowledgeBaseAssociation.BedrockagentAgentKnowledgeBaseAssociation>

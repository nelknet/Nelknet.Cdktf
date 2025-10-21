namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type BedrockagentAgentAliasState<'AgentAliasName, 'AgentId> = { assignments: ResizeArray<aws.BedrockagentAgentAlias.BedrockagentAgentAliasConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent_alias">aws_bedrockagent_agent_alias</a>.
    /// </summary>
    type BedrockagentAgentAliasBuilder(logicalId: string) =
        member _.Yield(_: unit) : BedrockagentAgentAliasState<Missing, Missing> =
            ({ assignments = ResizeArray() } : BedrockagentAgentAliasState<Missing, Missing>)

        member _.Zero(()) : BedrockagentAgentAliasState<Missing, Missing> =
            ({ assignments = ResizeArray() } : BedrockagentAgentAliasState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent_alias#agent_alias_name-1">BedrockagentAgentAlias#agent_alias_name</a>.
        /// </summary>
        [<CustomOperation "agent_alias_name">]
        member _.AgentAliasName(state: BedrockagentAgentAliasState<Missing, 'AgentId>, value: string) : BedrockagentAgentAliasState<Present, 'AgentId> =
            state.assignments.Add(fun config -> config.AgentAliasName <- value)
            ({ assignments = state.assignments } : BedrockagentAgentAliasState<Present, 'AgentId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent_alias#agent_id-1">BedrockagentAgentAlias#agent_id</a>.
        /// </summary>
        [<CustomOperation "agent_id">]
        member _.AgentId(state: BedrockagentAgentAliasState<'AgentAliasName, Missing>, value: string) : BedrockagentAgentAliasState<'AgentAliasName, Present> =
            state.assignments.Add(fun config -> config.AgentId <- value)
            ({ assignments = state.assignments } : BedrockagentAgentAliasState<'AgentAliasName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent_alias#description-1">BedrockagentAgentAlias#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: BedrockagentAgentAliasState<'AgentAliasName, 'AgentId>, value: string) : BedrockagentAgentAliasState<'AgentAliasName, 'AgentId> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : BedrockagentAgentAliasState<'AgentAliasName, 'AgentId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent_alias#routing_configuration-1">BedrockagentAgentAlias#routing_configuration</a>. Accepts: aws.IResolvable | aws.BedrockagentAgentAlias.BedrockagentAgentAliasRoutingConfiguration[]
        /// </summary>
        [<CustomOperation "routing_configuration">]
        member _.RoutingConfiguration(state: BedrockagentAgentAliasState<'AgentAliasName, 'AgentId>, value: HashiCorp.Cdktf.IResolvable) : BedrockagentAgentAliasState<'AgentAliasName, 'AgentId> =
            state.assignments.Add(fun config -> config.RoutingConfiguration <- value)
            state : BedrockagentAgentAliasState<'AgentAliasName, 'AgentId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent_alias#tags-1">BedrockagentAgentAlias#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: BedrockagentAgentAliasState<'AgentAliasName, 'AgentId>, value: seq<string * string>) : BedrockagentAgentAliasState<'AgentAliasName, 'AgentId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : BedrockagentAgentAliasState<'AgentAliasName, 'AgentId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent_alias#timeouts-1">BedrockagentAgentAlias#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: BedrockagentAgentAliasState<'AgentAliasName, 'AgentId>, value: aws.BedrockagentAgentAlias.BedrockagentAgentAliasTimeouts) : BedrockagentAgentAliasState<'AgentAliasName, 'AgentId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : BedrockagentAgentAliasState<'AgentAliasName, 'AgentId>

        member _.Run(state: BedrockagentAgentAliasState<Present, Present>) : aws.BedrockagentAgentAlias.BedrockagentAgentAlias =
            let config = aws.BedrockagentAgentAlias.BedrockagentAgentAliasConfig()
            for setter in state.assignments do
                setter config
            aws.BedrockagentAgentAlias.BedrockagentAgentAlias(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.bedrockagentAgentAlias: missing required arguments. Must call: agent_alias_name, agent_id.", 9999, IsError = true)>]
        member _.Run(_: BedrockagentAgentAliasState<_, _>) : aws.BedrockagentAgentAlias.BedrockagentAgentAlias =
            Unchecked.defaultof<aws.BedrockagentAgentAlias.BedrockagentAgentAlias>

namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type BedrockagentAgentActionGroupState<'ActionGroupName, 'AgentId, 'AgentVersion> = { assignments: ResizeArray<aws.BedrockagentAgentActionGroup.BedrockagentAgentActionGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent_action_group">aws_bedrockagent_agent_action_group</a>.
    /// </summary>
    type BedrockagentAgentActionGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : BedrockagentAgentActionGroupState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : BedrockagentAgentActionGroupState<Missing, Missing, Missing>)

        member _.Zero(()) : BedrockagentAgentActionGroupState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : BedrockagentAgentActionGroupState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent_action_group#action_group_name-1">BedrockagentAgentActionGroup#action_group_name</a>.
        /// </summary>
        [<CustomOperation "action_group_name">]
        member _.ActionGroupName(state: BedrockagentAgentActionGroupState<Missing, 'AgentId, 'AgentVersion>, value: string) : BedrockagentAgentActionGroupState<Present, 'AgentId, 'AgentVersion> =
            state.assignments.Add(fun config -> config.ActionGroupName <- value)
            ({ assignments = state.assignments } : BedrockagentAgentActionGroupState<Present, 'AgentId, 'AgentVersion>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent_action_group#agent_id-1">BedrockagentAgentActionGroup#agent_id</a>.
        /// </summary>
        [<CustomOperation "agent_id">]
        member _.AgentId(state: BedrockagentAgentActionGroupState<'ActionGroupName, Missing, 'AgentVersion>, value: string) : BedrockagentAgentActionGroupState<'ActionGroupName, Present, 'AgentVersion> =
            state.assignments.Add(fun config -> config.AgentId <- value)
            ({ assignments = state.assignments } : BedrockagentAgentActionGroupState<'ActionGroupName, Present, 'AgentVersion>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent_action_group#agent_version-1">BedrockagentAgentActionGroup#agent_version</a>.
        /// </summary>
        [<CustomOperation "agent_version">]
        member _.AgentVersion(state: BedrockagentAgentActionGroupState<'ActionGroupName, 'AgentId, Missing>, value: string) : BedrockagentAgentActionGroupState<'ActionGroupName, 'AgentId, Present> =
            state.assignments.Add(fun config -> config.AgentVersion <- value)
            ({ assignments = state.assignments } : BedrockagentAgentActionGroupState<'ActionGroupName, 'AgentId, Present>)

        /// <summary>
        /// action_group_executor block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent_action_group#action_group_executor-1">BedrockagentAgentActionGroup#action_group_executor</a> Accepts: aws.IResolvable | aws.BedrockagentAgentActionGroup.BedrockagentAgentActionGroupActionGroupExecutor[]
        /// </summary>
        [<CustomOperation "action_group_executor">]
        member _.ActionGroupExecutor(state: BedrockagentAgentActionGroupState<'ActionGroupName, 'AgentId, 'AgentVersion>, value: HashiCorp.Cdktf.IResolvable) : BedrockagentAgentActionGroupState<'ActionGroupName, 'AgentId, 'AgentVersion> =
            state.assignments.Add(fun config -> config.ActionGroupExecutor <- value)
            state : BedrockagentAgentActionGroupState<'ActionGroupName, 'AgentId, 'AgentVersion>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent_action_group#action_group_state-1">BedrockagentAgentActionGroup#action_group_state</a>.
        /// </summary>
        [<CustomOperation "action_group_state">]
        member _.ActionGroupState(state: BedrockagentAgentActionGroupState<'ActionGroupName, 'AgentId, 'AgentVersion>, value: string) : BedrockagentAgentActionGroupState<'ActionGroupName, 'AgentId, 'AgentVersion> =
            state.assignments.Add(fun config -> config.ActionGroupState <- value)
            state : BedrockagentAgentActionGroupState<'ActionGroupName, 'AgentId, 'AgentVersion>

        /// <summary>
        /// api_schema block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent_action_group#api_schema-1">BedrockagentAgentActionGroup#api_schema</a> Accepts: aws.IResolvable | aws.BedrockagentAgentActionGroup.BedrockagentAgentActionGroupApiSchema[]
        /// </summary>
        [<CustomOperation "api_schema">]
        member _.ApiSchema(state: BedrockagentAgentActionGroupState<'ActionGroupName, 'AgentId, 'AgentVersion>, value: HashiCorp.Cdktf.IResolvable) : BedrockagentAgentActionGroupState<'ActionGroupName, 'AgentId, 'AgentVersion> =
            state.assignments.Add(fun config -> config.ApiSchema <- value)
            state : BedrockagentAgentActionGroupState<'ActionGroupName, 'AgentId, 'AgentVersion>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent_action_group#description-1">BedrockagentAgentActionGroup#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: BedrockagentAgentActionGroupState<'ActionGroupName, 'AgentId, 'AgentVersion>, value: string) : BedrockagentAgentActionGroupState<'ActionGroupName, 'AgentId, 'AgentVersion> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : BedrockagentAgentActionGroupState<'ActionGroupName, 'AgentId, 'AgentVersion>

        /// <summary>
        /// function_schema block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent_action_group#function_schema-1">BedrockagentAgentActionGroup#function_schema</a> Accepts: aws.IResolvable | aws.BedrockagentAgentActionGroup.BedrockagentAgentActionGroupFunctionSchema[]
        /// </summary>
        [<CustomOperation "function_schema">]
        member _.FunctionSchema(state: BedrockagentAgentActionGroupState<'ActionGroupName, 'AgentId, 'AgentVersion>, value: HashiCorp.Cdktf.IResolvable) : BedrockagentAgentActionGroupState<'ActionGroupName, 'AgentId, 'AgentVersion> =
            state.assignments.Add(fun config -> config.FunctionSchema <- value)
            state : BedrockagentAgentActionGroupState<'ActionGroupName, 'AgentId, 'AgentVersion>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent_action_group#parent_action_group_signature-1">BedrockagentAgentActionGroup#parent_action_group_signature</a>.
        /// </summary>
        [<CustomOperation "parent_action_group_signature">]
        member _.ParentActionGroupSignature(state: BedrockagentAgentActionGroupState<'ActionGroupName, 'AgentId, 'AgentVersion>, value: string) : BedrockagentAgentActionGroupState<'ActionGroupName, 'AgentId, 'AgentVersion> =
            state.assignments.Add(fun config -> config.ParentActionGroupSignature <- value)
            state : BedrockagentAgentActionGroupState<'ActionGroupName, 'AgentId, 'AgentVersion>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent_action_group#prepare_agent-1">BedrockagentAgentActionGroup#prepare_agent</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "prepare_agent">]
        member _.PrepareAgent(state: BedrockagentAgentActionGroupState<'ActionGroupName, 'AgentId, 'AgentVersion>, value: bool) : BedrockagentAgentActionGroupState<'ActionGroupName, 'AgentId, 'AgentVersion> =
            state.assignments.Add(fun config -> config.PrepareAgent <- value)
            state : BedrockagentAgentActionGroupState<'ActionGroupName, 'AgentId, 'AgentVersion>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent_action_group#prepare_agent-1">BedrockagentAgentActionGroup#prepare_agent</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "prepare_agent">]
        member _.PrepareAgent(state: BedrockagentAgentActionGroupState<'ActionGroupName, 'AgentId, 'AgentVersion>, value: HashiCorp.Cdktf.IResolvable) : BedrockagentAgentActionGroupState<'ActionGroupName, 'AgentId, 'AgentVersion> =
            state.assignments.Add(fun config -> config.PrepareAgent <- value)
            state : BedrockagentAgentActionGroupState<'ActionGroupName, 'AgentId, 'AgentVersion>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent_action_group#skip_resource_in_use_check-1">BedrockagentAgentActionGroup#skip_resource_in_use_check</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "skip_resource_in_use_check">]
        member _.SkipResourceInUseCheck(state: BedrockagentAgentActionGroupState<'ActionGroupName, 'AgentId, 'AgentVersion>, value: bool) : BedrockagentAgentActionGroupState<'ActionGroupName, 'AgentId, 'AgentVersion> =
            state.assignments.Add(fun config -> config.SkipResourceInUseCheck <- value)
            state : BedrockagentAgentActionGroupState<'ActionGroupName, 'AgentId, 'AgentVersion>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent_action_group#skip_resource_in_use_check-1">BedrockagentAgentActionGroup#skip_resource_in_use_check</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "skip_resource_in_use_check">]
        member _.SkipResourceInUseCheck(state: BedrockagentAgentActionGroupState<'ActionGroupName, 'AgentId, 'AgentVersion>, value: HashiCorp.Cdktf.IResolvable) : BedrockagentAgentActionGroupState<'ActionGroupName, 'AgentId, 'AgentVersion> =
            state.assignments.Add(fun config -> config.SkipResourceInUseCheck <- value)
            state : BedrockagentAgentActionGroupState<'ActionGroupName, 'AgentId, 'AgentVersion>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent_action_group#timeouts-1">BedrockagentAgentActionGroup#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: BedrockagentAgentActionGroupState<'ActionGroupName, 'AgentId, 'AgentVersion>, value: aws.BedrockagentAgentActionGroup.BedrockagentAgentActionGroupTimeouts) : BedrockagentAgentActionGroupState<'ActionGroupName, 'AgentId, 'AgentVersion> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : BedrockagentAgentActionGroupState<'ActionGroupName, 'AgentId, 'AgentVersion>

        member _.Run(state: BedrockagentAgentActionGroupState<Present, Present, Present>) : aws.BedrockagentAgentActionGroup.BedrockagentAgentActionGroup =
            let config = aws.BedrockagentAgentActionGroup.BedrockagentAgentActionGroupConfig()
            for setter in state.assignments do
                setter config
            aws.BedrockagentAgentActionGroup.BedrockagentAgentActionGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.bedrockagentAgentActionGroup: missing required arguments. Must call: action_group_name, agent_id, agent_version.", 9999, IsError = true)>]
        member _.Run(_: BedrockagentAgentActionGroupState<_, _, _>) : aws.BedrockagentAgentActionGroup.BedrockagentAgentActionGroup =
            Unchecked.defaultof<aws.BedrockagentAgentActionGroup.BedrockagentAgentActionGroup>

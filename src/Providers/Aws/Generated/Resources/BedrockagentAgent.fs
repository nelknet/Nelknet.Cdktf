namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type BedrockagentAgentState<'AgentName, 'AgentResourceRoleArn, 'FoundationModel> = { assignments: ResizeArray<aws.BedrockagentAgent.BedrockagentAgentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent">aws_bedrockagent_agent</a>.
    /// </summary>
    type BedrockagentAgentBuilder(logicalId: string) =
        member _.Yield(_: unit) : BedrockagentAgentState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : BedrockagentAgentState<Missing, Missing, Missing>)

        member _.Zero(()) : BedrockagentAgentState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : BedrockagentAgentState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent#agent_name-1">BedrockagentAgent#agent_name</a>.
        /// </summary>
        [<CustomOperation "agent_name">]
        member _.AgentName(state: BedrockagentAgentState<Missing, 'AgentResourceRoleArn, 'FoundationModel>, value: string) : BedrockagentAgentState<Present, 'AgentResourceRoleArn, 'FoundationModel> =
            state.assignments.Add(fun config -> config.AgentName <- value)
            ({ assignments = state.assignments } : BedrockagentAgentState<Present, 'AgentResourceRoleArn, 'FoundationModel>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent#agent_resource_role_arn-1">BedrockagentAgent#agent_resource_role_arn</a>.
        /// </summary>
        [<CustomOperation "agent_resource_role_arn">]
        member _.AgentResourceRoleArn(state: BedrockagentAgentState<'AgentName, Missing, 'FoundationModel>, value: string) : BedrockagentAgentState<'AgentName, Present, 'FoundationModel> =
            state.assignments.Add(fun config -> config.AgentResourceRoleArn <- value)
            ({ assignments = state.assignments } : BedrockagentAgentState<'AgentName, Present, 'FoundationModel>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent#foundation_model-1">BedrockagentAgent#foundation_model</a>.
        /// </summary>
        [<CustomOperation "foundation_model">]
        member _.FoundationModel(state: BedrockagentAgentState<'AgentName, 'AgentResourceRoleArn, Missing>, value: string) : BedrockagentAgentState<'AgentName, 'AgentResourceRoleArn, Present> =
            state.assignments.Add(fun config -> config.FoundationModel <- value)
            ({ assignments = state.assignments } : BedrockagentAgentState<'AgentName, 'AgentResourceRoleArn, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent#agent_collaboration-1">BedrockagentAgent#agent_collaboration</a>.
        /// </summary>
        [<CustomOperation "agent_collaboration">]
        member _.AgentCollaboration(state: BedrockagentAgentState<'AgentName, 'AgentResourceRoleArn, 'FoundationModel>, value: string) : BedrockagentAgentState<'AgentName, 'AgentResourceRoleArn, 'FoundationModel> =
            state.assignments.Add(fun config -> config.AgentCollaboration <- value)
            state : BedrockagentAgentState<'AgentName, 'AgentResourceRoleArn, 'FoundationModel>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent#customer_encryption_key_arn-1">BedrockagentAgent#customer_encryption_key_arn</a>.
        /// </summary>
        [<CustomOperation "customer_encryption_key_arn">]
        member _.CustomerEncryptionKeyArn(state: BedrockagentAgentState<'AgentName, 'AgentResourceRoleArn, 'FoundationModel>, value: string) : BedrockagentAgentState<'AgentName, 'AgentResourceRoleArn, 'FoundationModel> =
            state.assignments.Add(fun config -> config.CustomerEncryptionKeyArn <- value)
            state : BedrockagentAgentState<'AgentName, 'AgentResourceRoleArn, 'FoundationModel>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent#description-1">BedrockagentAgent#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: BedrockagentAgentState<'AgentName, 'AgentResourceRoleArn, 'FoundationModel>, value: string) : BedrockagentAgentState<'AgentName, 'AgentResourceRoleArn, 'FoundationModel> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : BedrockagentAgentState<'AgentName, 'AgentResourceRoleArn, 'FoundationModel>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent#guardrail_configuration-1">BedrockagentAgent#guardrail_configuration</a>. Accepts: aws.IResolvable | aws.BedrockagentAgent.BedrockagentAgentGuardrailConfiguration[]
        /// </summary>
        [<CustomOperation "guardrail_configuration">]
        member _.GuardrailConfiguration(state: BedrockagentAgentState<'AgentName, 'AgentResourceRoleArn, 'FoundationModel>, value: HashiCorp.Cdktf.IResolvable) : BedrockagentAgentState<'AgentName, 'AgentResourceRoleArn, 'FoundationModel> =
            state.assignments.Add(fun config -> config.GuardrailConfiguration <- value)
            state : BedrockagentAgentState<'AgentName, 'AgentResourceRoleArn, 'FoundationModel>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent#idle_session_ttl_in_seconds-1">BedrockagentAgent#idle_session_ttl_in_seconds</a>.
        /// </summary>
        [<CustomOperation "idle_session_ttl_in_seconds">]
        member _.IdleSessionTtlInSeconds(state: BedrockagentAgentState<'AgentName, 'AgentResourceRoleArn, 'FoundationModel>, value: double) : BedrockagentAgentState<'AgentName, 'AgentResourceRoleArn, 'FoundationModel> =
            state.assignments.Add(fun config -> config.IdleSessionTtlInSeconds <- value)
            state : BedrockagentAgentState<'AgentName, 'AgentResourceRoleArn, 'FoundationModel>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent#instruction-1">BedrockagentAgent#instruction</a>.
        /// </summary>
        [<CustomOperation "instruction">]
        member _.Instruction(state: BedrockagentAgentState<'AgentName, 'AgentResourceRoleArn, 'FoundationModel>, value: string) : BedrockagentAgentState<'AgentName, 'AgentResourceRoleArn, 'FoundationModel> =
            state.assignments.Add(fun config -> config.Instruction <- value)
            state : BedrockagentAgentState<'AgentName, 'AgentResourceRoleArn, 'FoundationModel>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent#memory_configuration-1">BedrockagentAgent#memory_configuration</a>. Accepts: aws.IResolvable | aws.BedrockagentAgent.BedrockagentAgentMemoryConfiguration[]
        /// </summary>
        [<CustomOperation "memory_configuration">]
        member _.MemoryConfiguration(state: BedrockagentAgentState<'AgentName, 'AgentResourceRoleArn, 'FoundationModel>, value: HashiCorp.Cdktf.IResolvable) : BedrockagentAgentState<'AgentName, 'AgentResourceRoleArn, 'FoundationModel> =
            state.assignments.Add(fun config -> config.MemoryConfiguration <- value)
            state : BedrockagentAgentState<'AgentName, 'AgentResourceRoleArn, 'FoundationModel>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent#prepare_agent-1">BedrockagentAgent#prepare_agent</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "prepare_agent">]
        member _.PrepareAgent(state: BedrockagentAgentState<'AgentName, 'AgentResourceRoleArn, 'FoundationModel>, value: bool) : BedrockagentAgentState<'AgentName, 'AgentResourceRoleArn, 'FoundationModel> =
            state.assignments.Add(fun config -> config.PrepareAgent <- value)
            state : BedrockagentAgentState<'AgentName, 'AgentResourceRoleArn, 'FoundationModel>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent#prepare_agent-1">BedrockagentAgent#prepare_agent</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "prepare_agent">]
        member _.PrepareAgent(state: BedrockagentAgentState<'AgentName, 'AgentResourceRoleArn, 'FoundationModel>, value: HashiCorp.Cdktf.IResolvable) : BedrockagentAgentState<'AgentName, 'AgentResourceRoleArn, 'FoundationModel> =
            state.assignments.Add(fun config -> config.PrepareAgent <- value)
            state : BedrockagentAgentState<'AgentName, 'AgentResourceRoleArn, 'FoundationModel>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent#prompt_override_configuration-1">BedrockagentAgent#prompt_override_configuration</a>. Accepts: aws.IResolvable | aws.BedrockagentAgent.BedrockagentAgentPromptOverrideConfiguration[]
        /// </summary>
        [<CustomOperation "prompt_override_configuration">]
        member _.PromptOverrideConfiguration(state: BedrockagentAgentState<'AgentName, 'AgentResourceRoleArn, 'FoundationModel>, value: HashiCorp.Cdktf.IResolvable) : BedrockagentAgentState<'AgentName, 'AgentResourceRoleArn, 'FoundationModel> =
            state.assignments.Add(fun config -> config.PromptOverrideConfiguration <- value)
            state : BedrockagentAgentState<'AgentName, 'AgentResourceRoleArn, 'FoundationModel>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent#skip_resource_in_use_check-1">BedrockagentAgent#skip_resource_in_use_check</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "skip_resource_in_use_check">]
        member _.SkipResourceInUseCheck(state: BedrockagentAgentState<'AgentName, 'AgentResourceRoleArn, 'FoundationModel>, value: bool) : BedrockagentAgentState<'AgentName, 'AgentResourceRoleArn, 'FoundationModel> =
            state.assignments.Add(fun config -> config.SkipResourceInUseCheck <- value)
            state : BedrockagentAgentState<'AgentName, 'AgentResourceRoleArn, 'FoundationModel>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent#skip_resource_in_use_check-1">BedrockagentAgent#skip_resource_in_use_check</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "skip_resource_in_use_check">]
        member _.SkipResourceInUseCheck(state: BedrockagentAgentState<'AgentName, 'AgentResourceRoleArn, 'FoundationModel>, value: HashiCorp.Cdktf.IResolvable) : BedrockagentAgentState<'AgentName, 'AgentResourceRoleArn, 'FoundationModel> =
            state.assignments.Add(fun config -> config.SkipResourceInUseCheck <- value)
            state : BedrockagentAgentState<'AgentName, 'AgentResourceRoleArn, 'FoundationModel>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent#tags-1">BedrockagentAgent#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: BedrockagentAgentState<'AgentName, 'AgentResourceRoleArn, 'FoundationModel>, value: seq<string * string>) : BedrockagentAgentState<'AgentName, 'AgentResourceRoleArn, 'FoundationModel> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : BedrockagentAgentState<'AgentName, 'AgentResourceRoleArn, 'FoundationModel>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent#timeouts-1">BedrockagentAgent#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: BedrockagentAgentState<'AgentName, 'AgentResourceRoleArn, 'FoundationModel>, value: aws.BedrockagentAgent.BedrockagentAgentTimeouts) : BedrockagentAgentState<'AgentName, 'AgentResourceRoleArn, 'FoundationModel> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : BedrockagentAgentState<'AgentName, 'AgentResourceRoleArn, 'FoundationModel>

        member _.Run(state: BedrockagentAgentState<Present, Present, Present>) : aws.BedrockagentAgent.BedrockagentAgent =
            let config = aws.BedrockagentAgent.BedrockagentAgentConfig()
            for setter in state.assignments do
                setter config
            aws.BedrockagentAgent.BedrockagentAgent(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.bedrockagentAgent: missing required arguments. Must call: agent_name, agent_resource_role_arn, foundation_model.", 9999, IsError = true)>]
        member _.Run(_: BedrockagentAgentState<_, _, _>) : aws.BedrockagentAgent.BedrockagentAgent =
            Unchecked.defaultof<aws.BedrockagentAgent.BedrockagentAgent>

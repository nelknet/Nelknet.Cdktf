namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CodeguruprofilerProfilingGroupState<'Name> = { assignments: ResizeArray<aws.CodeguruprofilerProfilingGroup.CodeguruprofilerProfilingGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codeguruprofiler_profiling_group">aws_codeguruprofiler_profiling_group</a>.
    /// </summary>
    type CodeguruprofilerProfilingGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : CodeguruprofilerProfilingGroupState<Missing> =
            ({ assignments = ResizeArray() } : CodeguruprofilerProfilingGroupState<Missing>)

        member _.Zero(()) : CodeguruprofilerProfilingGroupState<Missing> =
            ({ assignments = ResizeArray() } : CodeguruprofilerProfilingGroupState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codeguruprofiler_profiling_group#name-1">CodeguruprofilerProfilingGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: CodeguruprofilerProfilingGroupState<Missing>, value: string) : CodeguruprofilerProfilingGroupState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : CodeguruprofilerProfilingGroupState<Present>)

        /// <summary>
        /// agent_orchestration_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codeguruprofiler_profiling_group#agent_orchestration_config-1">CodeguruprofilerProfilingGroup#agent_orchestration_config</a> Accepts: aws.IResolvable | aws.CodeguruprofilerProfilingGroup.CodeguruprofilerProfilingGroupAgentOrchestrationConfig[]
        /// </summary>
        [<CustomOperation "agent_orchestration_config">]
        member _.AgentOrchestrationConfig(state: CodeguruprofilerProfilingGroupState<'Name>, value: HashiCorp.Cdktf.IResolvable) : CodeguruprofilerProfilingGroupState<'Name> =
            state.assignments.Add(fun config -> config.AgentOrchestrationConfig <- value)
            state : CodeguruprofilerProfilingGroupState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codeguruprofiler_profiling_group#compute_platform-1">CodeguruprofilerProfilingGroup#compute_platform</a>.
        /// </summary>
        [<CustomOperation "compute_platform">]
        member _.ComputePlatform(state: CodeguruprofilerProfilingGroupState<'Name>, value: string) : CodeguruprofilerProfilingGroupState<'Name> =
            state.assignments.Add(fun config -> config.ComputePlatform <- value)
            state : CodeguruprofilerProfilingGroupState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codeguruprofiler_profiling_group#tags-1">CodeguruprofilerProfilingGroup#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: CodeguruprofilerProfilingGroupState<'Name>, value: seq<string * string>) : CodeguruprofilerProfilingGroupState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : CodeguruprofilerProfilingGroupState<'Name>

        member _.Run(state: CodeguruprofilerProfilingGroupState<Present>) : aws.CodeguruprofilerProfilingGroup.CodeguruprofilerProfilingGroup =
            let config = aws.CodeguruprofilerProfilingGroup.CodeguruprofilerProfilingGroupConfig()
            for setter in state.assignments do
                setter config
            aws.CodeguruprofilerProfilingGroup.CodeguruprofilerProfilingGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.codeguruprofilerProfilingGroup: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: CodeguruprofilerProfilingGroupState<_>) : aws.CodeguruprofilerProfilingGroup.CodeguruprofilerProfilingGroup =
            Unchecked.defaultof<aws.CodeguruprofilerProfilingGroup.CodeguruprofilerProfilingGroup>

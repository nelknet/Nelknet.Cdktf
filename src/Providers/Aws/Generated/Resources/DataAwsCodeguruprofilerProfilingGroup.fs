namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsCodeguruprofilerProfilingGroupState<'Name> = { assignments: ResizeArray<aws.DataAwsCodeguruprofilerProfilingGroup.DataAwsCodeguruprofilerProfilingGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/codeguruprofiler_profiling_group">aws_codeguruprofiler_profiling_group</a>.
    /// </summary>
    type DataAwsCodeguruprofilerProfilingGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsCodeguruprofilerProfilingGroupState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsCodeguruprofilerProfilingGroupState<Missing>)

        member _.Zero(()) : DataAwsCodeguruprofilerProfilingGroupState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsCodeguruprofilerProfilingGroupState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/codeguruprofiler_profiling_group#name-1">DataAwsCodeguruprofilerProfilingGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsCodeguruprofilerProfilingGroupState<Missing>, value: string) : DataAwsCodeguruprofilerProfilingGroupState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAwsCodeguruprofilerProfilingGroupState<Present>)

        member _.Run(state: DataAwsCodeguruprofilerProfilingGroupState<Present>) : aws.DataAwsCodeguruprofilerProfilingGroup.DataAwsCodeguruprofilerProfilingGroup =
            let config = aws.DataAwsCodeguruprofilerProfilingGroup.DataAwsCodeguruprofilerProfilingGroupConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsCodeguruprofilerProfilingGroup.DataAwsCodeguruprofilerProfilingGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsCodeguruprofilerProfilingGroup: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsCodeguruprofilerProfilingGroupState<_>) : aws.DataAwsCodeguruprofilerProfilingGroup.DataAwsCodeguruprofilerProfilingGroup =
            Unchecked.defaultof<aws.DataAwsCodeguruprofilerProfilingGroup.DataAwsCodeguruprofilerProfilingGroup>

namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsSyntheticsRuntimeVersionsState = { assignments: ResizeArray<aws.DataAwsSyntheticsRuntimeVersions.DataAwsSyntheticsRuntimeVersionsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/synthetics_runtime_versions">aws_synthetics_runtime_versions</a>.
    /// </summary>
    type DataAwsSyntheticsRuntimeVersionsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsSyntheticsRuntimeVersionsState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsSyntheticsRuntimeVersionsState =
            { assignments = ResizeArray() }

        /// <summary>
        /// runtime_versions block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/synthetics_runtime_versions#runtime_versions-1">DataAwsSyntheticsRuntimeVersions#runtime_versions</a> Accepts: aws.IResolvable | aws.DataAwsSyntheticsRuntimeVersions.DataAwsSyntheticsRuntimeVersionsRuntimeVersions[]
        /// </summary>
        [<CustomOperation "runtime_versions">]
        member _.RuntimeVersions(state: DataAwsSyntheticsRuntimeVersionsState, value: HashiCorp.Cdktf.IResolvable) : DataAwsSyntheticsRuntimeVersionsState =
            state.assignments.Add(fun config -> config.RuntimeVersions <- value)
            state : DataAwsSyntheticsRuntimeVersionsState

        member _.Run(state: DataAwsSyntheticsRuntimeVersionsState) : aws.DataAwsSyntheticsRuntimeVersions.DataAwsSyntheticsRuntimeVersions =
            let config = aws.DataAwsSyntheticsRuntimeVersions.DataAwsSyntheticsRuntimeVersionsConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsSyntheticsRuntimeVersions.DataAwsSyntheticsRuntimeVersions(StackContext.get (), logicalId, config)

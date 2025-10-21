namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsPrometheusWorkspaceState<'WorkspaceId> = { assignments: ResizeArray<aws.DataAwsPrometheusWorkspace.DataAwsPrometheusWorkspaceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/prometheus_workspace">aws_prometheus_workspace</a>.
    /// </summary>
    type DataAwsPrometheusWorkspaceBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsPrometheusWorkspaceState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsPrometheusWorkspaceState<Missing>)

        member _.Zero(()) : DataAwsPrometheusWorkspaceState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsPrometheusWorkspaceState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/prometheus_workspace#workspace_id-1">DataAwsPrometheusWorkspace#workspace_id</a>.
        /// </summary>
        [<CustomOperation "workspace_id">]
        member _.WorkspaceId(state: DataAwsPrometheusWorkspaceState<Missing>, value: string) : DataAwsPrometheusWorkspaceState<Present> =
            state.assignments.Add(fun config -> config.WorkspaceId <- value)
            ({ assignments = state.assignments } : DataAwsPrometheusWorkspaceState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/prometheus_workspace#id-1">DataAwsPrometheusWorkspace#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsPrometheusWorkspaceState<'WorkspaceId>, value: string) : DataAwsPrometheusWorkspaceState<'WorkspaceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsPrometheusWorkspaceState<'WorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/prometheus_workspace#tags-1">DataAwsPrometheusWorkspace#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsPrometheusWorkspaceState<'WorkspaceId>, value: seq<string * string>) : DataAwsPrometheusWorkspaceState<'WorkspaceId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsPrometheusWorkspaceState<'WorkspaceId>

        member _.Run(state: DataAwsPrometheusWorkspaceState<Present>) : aws.DataAwsPrometheusWorkspace.DataAwsPrometheusWorkspace =
            let config = aws.DataAwsPrometheusWorkspace.DataAwsPrometheusWorkspaceConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsPrometheusWorkspace.DataAwsPrometheusWorkspace(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsPrometheusWorkspace: missing required arguments. Must call: workspace_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsPrometheusWorkspaceState<_>) : aws.DataAwsPrometheusWorkspace.DataAwsPrometheusWorkspace =
            Unchecked.defaultof<aws.DataAwsPrometheusWorkspace.DataAwsPrometheusWorkspace>

namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsGrafanaWorkspaceState<'WorkspaceId> = { assignments: ResizeArray<aws.DataAwsGrafanaWorkspace.DataAwsGrafanaWorkspaceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/grafana_workspace">aws_grafana_workspace</a>.
    /// </summary>
    type DataAwsGrafanaWorkspaceBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsGrafanaWorkspaceState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsGrafanaWorkspaceState<Missing>)

        member _.Zero(()) : DataAwsGrafanaWorkspaceState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsGrafanaWorkspaceState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/grafana_workspace#workspace_id-1">DataAwsGrafanaWorkspace#workspace_id</a>.
        /// </summary>
        [<CustomOperation "workspace_id">]
        member _.WorkspaceId(state: DataAwsGrafanaWorkspaceState<Missing>, value: string) : DataAwsGrafanaWorkspaceState<Present> =
            state.assignments.Add(fun config -> config.WorkspaceId <- value)
            ({ assignments = state.assignments } : DataAwsGrafanaWorkspaceState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/grafana_workspace#id-1">DataAwsGrafanaWorkspace#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsGrafanaWorkspaceState<'WorkspaceId>, value: string) : DataAwsGrafanaWorkspaceState<'WorkspaceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsGrafanaWorkspaceState<'WorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/grafana_workspace#tags-1">DataAwsGrafanaWorkspace#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsGrafanaWorkspaceState<'WorkspaceId>, value: seq<string * string>) : DataAwsGrafanaWorkspaceState<'WorkspaceId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsGrafanaWorkspaceState<'WorkspaceId>

        member _.Run(state: DataAwsGrafanaWorkspaceState<Present>) : aws.DataAwsGrafanaWorkspace.DataAwsGrafanaWorkspace =
            let config = aws.DataAwsGrafanaWorkspace.DataAwsGrafanaWorkspaceConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsGrafanaWorkspace.DataAwsGrafanaWorkspace(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsGrafanaWorkspace: missing required arguments. Must call: workspace_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsGrafanaWorkspaceState<_>) : aws.DataAwsGrafanaWorkspace.DataAwsGrafanaWorkspace =
            Unchecked.defaultof<aws.DataAwsGrafanaWorkspace.DataAwsGrafanaWorkspace>

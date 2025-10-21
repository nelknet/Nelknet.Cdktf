namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsPrometheusWorkspacesState = { assignments: ResizeArray<aws.DataAwsPrometheusWorkspaces.DataAwsPrometheusWorkspacesConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/prometheus_workspaces">aws_prometheus_workspaces</a>.
    /// </summary>
    type DataAwsPrometheusWorkspacesBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsPrometheusWorkspacesState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsPrometheusWorkspacesState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/prometheus_workspaces#alias_prefix-1">DataAwsPrometheusWorkspaces#alias_prefix</a>.
        /// </summary>
        [<CustomOperation "alias_prefix">]
        member _.AliasPrefix(state: DataAwsPrometheusWorkspacesState, value: string) : DataAwsPrometheusWorkspacesState =
            state.assignments.Add(fun config -> config.AliasPrefix <- value)
            state : DataAwsPrometheusWorkspacesState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/prometheus_workspaces#id-1">DataAwsPrometheusWorkspaces#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsPrometheusWorkspacesState, value: string) : DataAwsPrometheusWorkspacesState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsPrometheusWorkspacesState

        member _.Run(state: DataAwsPrometheusWorkspacesState) : aws.DataAwsPrometheusWorkspaces.DataAwsPrometheusWorkspaces =
            let config = aws.DataAwsPrometheusWorkspaces.DataAwsPrometheusWorkspacesConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsPrometheusWorkspaces.DataAwsPrometheusWorkspaces(StackContext.get (), logicalId, config)

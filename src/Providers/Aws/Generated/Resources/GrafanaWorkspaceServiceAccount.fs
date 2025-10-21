namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type GrafanaWorkspaceServiceAccountState<'GrafanaRole, 'Name, 'WorkspaceId> = { assignments: ResizeArray<aws.GrafanaWorkspaceServiceAccount.GrafanaWorkspaceServiceAccountConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/grafana_workspace_service_account">aws_grafana_workspace_service_account</a>.
    /// </summary>
    type GrafanaWorkspaceServiceAccountBuilder(logicalId: string) =
        member _.Yield(_: unit) : GrafanaWorkspaceServiceAccountState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : GrafanaWorkspaceServiceAccountState<Missing, Missing, Missing>)

        member _.Zero(()) : GrafanaWorkspaceServiceAccountState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : GrafanaWorkspaceServiceAccountState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/grafana_workspace_service_account#grafana_role-1">GrafanaWorkspaceServiceAccount#grafana_role</a>.
        /// </summary>
        [<CustomOperation "grafana_role">]
        member _.GrafanaRole(state: GrafanaWorkspaceServiceAccountState<Missing, 'Name, 'WorkspaceId>, value: string) : GrafanaWorkspaceServiceAccountState<Present, 'Name, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.GrafanaRole <- value)
            ({ assignments = state.assignments } : GrafanaWorkspaceServiceAccountState<Present, 'Name, 'WorkspaceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/grafana_workspace_service_account#name-1">GrafanaWorkspaceServiceAccount#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: GrafanaWorkspaceServiceAccountState<'GrafanaRole, Missing, 'WorkspaceId>, value: string) : GrafanaWorkspaceServiceAccountState<'GrafanaRole, Present, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : GrafanaWorkspaceServiceAccountState<'GrafanaRole, Present, 'WorkspaceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/grafana_workspace_service_account#workspace_id-1">GrafanaWorkspaceServiceAccount#workspace_id</a>.
        /// </summary>
        [<CustomOperation "workspace_id">]
        member _.WorkspaceId(state: GrafanaWorkspaceServiceAccountState<'GrafanaRole, 'Name, Missing>, value: string) : GrafanaWorkspaceServiceAccountState<'GrafanaRole, 'Name, Present> =
            state.assignments.Add(fun config -> config.WorkspaceId <- value)
            ({ assignments = state.assignments } : GrafanaWorkspaceServiceAccountState<'GrafanaRole, 'Name, Present>)

        member _.Run(state: GrafanaWorkspaceServiceAccountState<Present, Present, Present>) : aws.GrafanaWorkspaceServiceAccount.GrafanaWorkspaceServiceAccount =
            let config = aws.GrafanaWorkspaceServiceAccount.GrafanaWorkspaceServiceAccountConfig()
            for setter in state.assignments do
                setter config
            aws.GrafanaWorkspaceServiceAccount.GrafanaWorkspaceServiceAccount(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.grafanaWorkspaceServiceAccount: missing required arguments. Must call: grafana_role, name, workspace_id.", 9999, IsError = true)>]
        member _.Run(_: GrafanaWorkspaceServiceAccountState<_, _, _>) : aws.GrafanaWorkspaceServiceAccount.GrafanaWorkspaceServiceAccount =
            Unchecked.defaultof<aws.GrafanaWorkspaceServiceAccount.GrafanaWorkspaceServiceAccount>

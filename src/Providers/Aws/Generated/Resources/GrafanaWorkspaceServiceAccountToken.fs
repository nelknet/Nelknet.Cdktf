namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type GrafanaWorkspaceServiceAccountTokenState<'Name, 'SecondsToLive, 'ServiceAccountId, 'WorkspaceId> = { assignments: ResizeArray<aws.GrafanaWorkspaceServiceAccountToken.GrafanaWorkspaceServiceAccountTokenConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/grafana_workspace_service_account_token">aws_grafana_workspace_service_account_token</a>.
    /// </summary>
    type GrafanaWorkspaceServiceAccountTokenBuilder(logicalId: string) =
        member _.Yield(_: unit) : GrafanaWorkspaceServiceAccountTokenState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : GrafanaWorkspaceServiceAccountTokenState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : GrafanaWorkspaceServiceAccountTokenState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : GrafanaWorkspaceServiceAccountTokenState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/grafana_workspace_service_account_token#name-1">GrafanaWorkspaceServiceAccountToken#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: GrafanaWorkspaceServiceAccountTokenState<Missing, 'SecondsToLive, 'ServiceAccountId, 'WorkspaceId>, value: string) : GrafanaWorkspaceServiceAccountTokenState<Present, 'SecondsToLive, 'ServiceAccountId, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : GrafanaWorkspaceServiceAccountTokenState<Present, 'SecondsToLive, 'ServiceAccountId, 'WorkspaceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/grafana_workspace_service_account_token#seconds_to_live-1">GrafanaWorkspaceServiceAccountToken#seconds_to_live</a>.
        /// </summary>
        [<CustomOperation "seconds_to_live">]
        member _.SecondsToLive(state: GrafanaWorkspaceServiceAccountTokenState<'Name, Missing, 'ServiceAccountId, 'WorkspaceId>, value: double) : GrafanaWorkspaceServiceAccountTokenState<'Name, Present, 'ServiceAccountId, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.SecondsToLive <- value)
            ({ assignments = state.assignments } : GrafanaWorkspaceServiceAccountTokenState<'Name, Present, 'ServiceAccountId, 'WorkspaceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/grafana_workspace_service_account_token#service_account_id-1">GrafanaWorkspaceServiceAccountToken#service_account_id</a>.
        /// </summary>
        [<CustomOperation "service_account_id">]
        member _.ServiceAccountId(state: GrafanaWorkspaceServiceAccountTokenState<'Name, 'SecondsToLive, Missing, 'WorkspaceId>, value: string) : GrafanaWorkspaceServiceAccountTokenState<'Name, 'SecondsToLive, Present, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.ServiceAccountId <- value)
            ({ assignments = state.assignments } : GrafanaWorkspaceServiceAccountTokenState<'Name, 'SecondsToLive, Present, 'WorkspaceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/grafana_workspace_service_account_token#workspace_id-1">GrafanaWorkspaceServiceAccountToken#workspace_id</a>.
        /// </summary>
        [<CustomOperation "workspace_id">]
        member _.WorkspaceId(state: GrafanaWorkspaceServiceAccountTokenState<'Name, 'SecondsToLive, 'ServiceAccountId, Missing>, value: string) : GrafanaWorkspaceServiceAccountTokenState<'Name, 'SecondsToLive, 'ServiceAccountId, Present> =
            state.assignments.Add(fun config -> config.WorkspaceId <- value)
            ({ assignments = state.assignments } : GrafanaWorkspaceServiceAccountTokenState<'Name, 'SecondsToLive, 'ServiceAccountId, Present>)

        member _.Run(state: GrafanaWorkspaceServiceAccountTokenState<Present, Present, Present, Present>) : aws.GrafanaWorkspaceServiceAccountToken.GrafanaWorkspaceServiceAccountToken =
            let config = aws.GrafanaWorkspaceServiceAccountToken.GrafanaWorkspaceServiceAccountTokenConfig()
            for setter in state.assignments do
                setter config
            aws.GrafanaWorkspaceServiceAccountToken.GrafanaWorkspaceServiceAccountToken(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.grafanaWorkspaceServiceAccountToken: missing required arguments. Must call: name, seconds_to_live, service_account_id, workspace_id.", 9999, IsError = true)>]
        member _.Run(_: GrafanaWorkspaceServiceAccountTokenState<_, _, _, _>) : aws.GrafanaWorkspaceServiceAccountToken.GrafanaWorkspaceServiceAccountToken =
            Unchecked.defaultof<aws.GrafanaWorkspaceServiceAccountToken.GrafanaWorkspaceServiceAccountToken>

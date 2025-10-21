namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type GrafanaWorkspaceApiKeyState<'KeyName, 'KeyRole, 'SecondsToLive, 'WorkspaceId> = { assignments: ResizeArray<aws.GrafanaWorkspaceApiKey.GrafanaWorkspaceApiKeyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/grafana_workspace_api_key">aws_grafana_workspace_api_key</a>.
    /// </summary>
    type GrafanaWorkspaceApiKeyBuilder(logicalId: string) =
        member _.Yield(_: unit) : GrafanaWorkspaceApiKeyState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : GrafanaWorkspaceApiKeyState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : GrafanaWorkspaceApiKeyState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : GrafanaWorkspaceApiKeyState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/grafana_workspace_api_key#key_name-1">GrafanaWorkspaceApiKey#key_name</a>.
        /// </summary>
        [<CustomOperation "key_name">]
        member _.KeyName(state: GrafanaWorkspaceApiKeyState<Missing, 'KeyRole, 'SecondsToLive, 'WorkspaceId>, value: string) : GrafanaWorkspaceApiKeyState<Present, 'KeyRole, 'SecondsToLive, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.KeyName <- value)
            ({ assignments = state.assignments } : GrafanaWorkspaceApiKeyState<Present, 'KeyRole, 'SecondsToLive, 'WorkspaceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/grafana_workspace_api_key#key_role-1">GrafanaWorkspaceApiKey#key_role</a>.
        /// </summary>
        [<CustomOperation "key_role">]
        member _.KeyRole(state: GrafanaWorkspaceApiKeyState<'KeyName, Missing, 'SecondsToLive, 'WorkspaceId>, value: string) : GrafanaWorkspaceApiKeyState<'KeyName, Present, 'SecondsToLive, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.KeyRole <- value)
            ({ assignments = state.assignments } : GrafanaWorkspaceApiKeyState<'KeyName, Present, 'SecondsToLive, 'WorkspaceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/grafana_workspace_api_key#seconds_to_live-1">GrafanaWorkspaceApiKey#seconds_to_live</a>.
        /// </summary>
        [<CustomOperation "seconds_to_live">]
        member _.SecondsToLive(state: GrafanaWorkspaceApiKeyState<'KeyName, 'KeyRole, Missing, 'WorkspaceId>, value: double) : GrafanaWorkspaceApiKeyState<'KeyName, 'KeyRole, Present, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.SecondsToLive <- value)
            ({ assignments = state.assignments } : GrafanaWorkspaceApiKeyState<'KeyName, 'KeyRole, Present, 'WorkspaceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/grafana_workspace_api_key#workspace_id-1">GrafanaWorkspaceApiKey#workspace_id</a>.
        /// </summary>
        [<CustomOperation "workspace_id">]
        member _.WorkspaceId(state: GrafanaWorkspaceApiKeyState<'KeyName, 'KeyRole, 'SecondsToLive, Missing>, value: string) : GrafanaWorkspaceApiKeyState<'KeyName, 'KeyRole, 'SecondsToLive, Present> =
            state.assignments.Add(fun config -> config.WorkspaceId <- value)
            ({ assignments = state.assignments } : GrafanaWorkspaceApiKeyState<'KeyName, 'KeyRole, 'SecondsToLive, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/grafana_workspace_api_key#id-1">GrafanaWorkspaceApiKey#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: GrafanaWorkspaceApiKeyState<'KeyName, 'KeyRole, 'SecondsToLive, 'WorkspaceId>, value: string) : GrafanaWorkspaceApiKeyState<'KeyName, 'KeyRole, 'SecondsToLive, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : GrafanaWorkspaceApiKeyState<'KeyName, 'KeyRole, 'SecondsToLive, 'WorkspaceId>

        member _.Run(state: GrafanaWorkspaceApiKeyState<Present, Present, Present, Present>) : aws.GrafanaWorkspaceApiKey.GrafanaWorkspaceApiKey =
            let config = aws.GrafanaWorkspaceApiKey.GrafanaWorkspaceApiKeyConfig()
            for setter in state.assignments do
                setter config
            aws.GrafanaWorkspaceApiKey.GrafanaWorkspaceApiKey(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.grafanaWorkspaceApiKey: missing required arguments. Must call: key_name, key_role, seconds_to_live, workspace_id.", 9999, IsError = true)>]
        member _.Run(_: GrafanaWorkspaceApiKeyState<_, _, _, _>) : aws.GrafanaWorkspaceApiKey.GrafanaWorkspaceApiKey =
            Unchecked.defaultof<aws.GrafanaWorkspaceApiKey.GrafanaWorkspaceApiKey>

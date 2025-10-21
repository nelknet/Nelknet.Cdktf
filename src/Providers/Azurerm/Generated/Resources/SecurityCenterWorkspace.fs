namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SecurityCenterWorkspaceState<'Scope, 'WorkspaceId> = { assignments: ResizeArray<azurerm.SecurityCenterWorkspace.SecurityCenterWorkspaceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_workspace">azurerm_security_center_workspace</a>.
    /// </summary>
    type SecurityCenterWorkspaceBuilder(logicalId: string) =
        member _.Yield(_: unit) : SecurityCenterWorkspaceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SecurityCenterWorkspaceState<Missing, Missing>)

        member _.Zero(()) : SecurityCenterWorkspaceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SecurityCenterWorkspaceState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_workspace#scope-1">SecurityCenterWorkspace#scope</a>.
        /// </summary>
        [<CustomOperation "scope">]
        member _.Scope(state: SecurityCenterWorkspaceState<Missing, 'WorkspaceId>, value: string) : SecurityCenterWorkspaceState<Present, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Scope <- value)
            ({ assignments = state.assignments } : SecurityCenterWorkspaceState<Present, 'WorkspaceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_workspace#workspace_id-1">SecurityCenterWorkspace#workspace_id</a>.
        /// </summary>
        [<CustomOperation "workspace_id">]
        member _.WorkspaceId(state: SecurityCenterWorkspaceState<'Scope, Missing>, value: string) : SecurityCenterWorkspaceState<'Scope, Present> =
            state.assignments.Add(fun config -> config.WorkspaceId <- value)
            ({ assignments = state.assignments } : SecurityCenterWorkspaceState<'Scope, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_workspace#id-1">SecurityCenterWorkspace#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SecurityCenterWorkspaceState<'Scope, 'WorkspaceId>, value: string) : SecurityCenterWorkspaceState<'Scope, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SecurityCenterWorkspaceState<'Scope, 'WorkspaceId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_workspace#timeouts-1">SecurityCenterWorkspace#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SecurityCenterWorkspaceState<'Scope, 'WorkspaceId>, value: azurerm.SecurityCenterWorkspace.SecurityCenterWorkspaceTimeouts) : SecurityCenterWorkspaceState<'Scope, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SecurityCenterWorkspaceState<'Scope, 'WorkspaceId>

        member _.Run(state: SecurityCenterWorkspaceState<Present, Present>) : azurerm.SecurityCenterWorkspace.SecurityCenterWorkspace =
            let config = azurerm.SecurityCenterWorkspace.SecurityCenterWorkspaceConfig()
            for setter in state.assignments do
                setter config
            azurerm.SecurityCenterWorkspace.SecurityCenterWorkspace(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.securityCenterWorkspace: missing required arguments. Must call: scope, workspace_id.", 9999, IsError = true)>]
        member _.Run(_: SecurityCenterWorkspaceState<_, _>) : azurerm.SecurityCenterWorkspace.SecurityCenterWorkspace =
            Unchecked.defaultof<azurerm.SecurityCenterWorkspace.SecurityCenterWorkspace>

namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VirtualDesktopWorkspaceApplicationGroupAssociationState<'ApplicationGroupId, 'WorkspaceId> = { assignments: ResizeArray<azurerm.VirtualDesktopWorkspaceApplicationGroupAssociation.VirtualDesktopWorkspaceApplicationGroupAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_workspace_application_group_association">azurerm_virtual_desktop_workspace_application_group_association</a>.
    /// </summary>
    type VirtualDesktopWorkspaceApplicationGroupAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : VirtualDesktopWorkspaceApplicationGroupAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : VirtualDesktopWorkspaceApplicationGroupAssociationState<Missing, Missing>)

        member _.Zero(()) : VirtualDesktopWorkspaceApplicationGroupAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : VirtualDesktopWorkspaceApplicationGroupAssociationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_workspace_application_group_association#application_group_id-1">VirtualDesktopWorkspaceApplicationGroupAssociation#application_group_id</a>.
        /// </summary>
        [<CustomOperation "application_group_id">]
        member _.ApplicationGroupId(state: VirtualDesktopWorkspaceApplicationGroupAssociationState<Missing, 'WorkspaceId>, value: string) : VirtualDesktopWorkspaceApplicationGroupAssociationState<Present, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.ApplicationGroupId <- value)
            ({ assignments = state.assignments } : VirtualDesktopWorkspaceApplicationGroupAssociationState<Present, 'WorkspaceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_workspace_application_group_association#workspace_id-1">VirtualDesktopWorkspaceApplicationGroupAssociation#workspace_id</a>.
        /// </summary>
        [<CustomOperation "workspace_id">]
        member _.WorkspaceId(state: VirtualDesktopWorkspaceApplicationGroupAssociationState<'ApplicationGroupId, Missing>, value: string) : VirtualDesktopWorkspaceApplicationGroupAssociationState<'ApplicationGroupId, Present> =
            state.assignments.Add(fun config -> config.WorkspaceId <- value)
            ({ assignments = state.assignments } : VirtualDesktopWorkspaceApplicationGroupAssociationState<'ApplicationGroupId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_workspace_application_group_association#id-1">VirtualDesktopWorkspaceApplicationGroupAssociation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VirtualDesktopWorkspaceApplicationGroupAssociationState<'ApplicationGroupId, 'WorkspaceId>, value: string) : VirtualDesktopWorkspaceApplicationGroupAssociationState<'ApplicationGroupId, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VirtualDesktopWorkspaceApplicationGroupAssociationState<'ApplicationGroupId, 'WorkspaceId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_workspace_application_group_association#timeouts-1">VirtualDesktopWorkspaceApplicationGroupAssociation#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: VirtualDesktopWorkspaceApplicationGroupAssociationState<'ApplicationGroupId, 'WorkspaceId>, value: azurerm.VirtualDesktopWorkspaceApplicationGroupAssociation.VirtualDesktopWorkspaceApplicationGroupAssociationTimeouts) : VirtualDesktopWorkspaceApplicationGroupAssociationState<'ApplicationGroupId, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : VirtualDesktopWorkspaceApplicationGroupAssociationState<'ApplicationGroupId, 'WorkspaceId>

        member _.Run(state: VirtualDesktopWorkspaceApplicationGroupAssociationState<Present, Present>) : azurerm.VirtualDesktopWorkspaceApplicationGroupAssociation.VirtualDesktopWorkspaceApplicationGroupAssociation =
            let config = azurerm.VirtualDesktopWorkspaceApplicationGroupAssociation.VirtualDesktopWorkspaceApplicationGroupAssociationConfig()
            for setter in state.assignments do
                setter config
            azurerm.VirtualDesktopWorkspaceApplicationGroupAssociation.VirtualDesktopWorkspaceApplicationGroupAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.virtualDesktopWorkspaceApplicationGroupAssociation: missing required arguments. Must call: application_group_id, workspace_id.", 9999, IsError = true)>]
        member _.Run(_: VirtualDesktopWorkspaceApplicationGroupAssociationState<_, _>) : azurerm.VirtualDesktopWorkspaceApplicationGroupAssociation.VirtualDesktopWorkspaceApplicationGroupAssociation =
            Unchecked.defaultof<azurerm.VirtualDesktopWorkspaceApplicationGroupAssociation.VirtualDesktopWorkspaceApplicationGroupAssociation>

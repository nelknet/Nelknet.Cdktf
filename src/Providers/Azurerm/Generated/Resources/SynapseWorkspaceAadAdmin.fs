namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SynapseWorkspaceAadAdminState<'Login, 'ObjectId, 'SynapseWorkspaceId, 'TenantId> = { assignments: ResizeArray<azurerm.SynapseWorkspaceAadAdmin.SynapseWorkspaceAadAdminConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_workspace_aad_admin">azurerm_synapse_workspace_aad_admin</a>.
    /// </summary>
    type SynapseWorkspaceAadAdminBuilder(logicalId: string) =
        member _.Yield(_: unit) : SynapseWorkspaceAadAdminState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SynapseWorkspaceAadAdminState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : SynapseWorkspaceAadAdminState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SynapseWorkspaceAadAdminState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_workspace_aad_admin#login-1">SynapseWorkspaceAadAdmin#login</a>.
        /// </summary>
        [<CustomOperation "login">]
        member _.Login(state: SynapseWorkspaceAadAdminState<Missing, 'ObjectId, 'SynapseWorkspaceId, 'TenantId>, value: string) : SynapseWorkspaceAadAdminState<Present, 'ObjectId, 'SynapseWorkspaceId, 'TenantId> =
            state.assignments.Add(fun config -> config.Login <- value)
            ({ assignments = state.assignments } : SynapseWorkspaceAadAdminState<Present, 'ObjectId, 'SynapseWorkspaceId, 'TenantId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_workspace_aad_admin#object_id-1">SynapseWorkspaceAadAdmin#object_id</a>.
        /// </summary>
        [<CustomOperation "object_id">]
        member _.ObjectId(state: SynapseWorkspaceAadAdminState<'Login, Missing, 'SynapseWorkspaceId, 'TenantId>, value: string) : SynapseWorkspaceAadAdminState<'Login, Present, 'SynapseWorkspaceId, 'TenantId> =
            state.assignments.Add(fun config -> config.ObjectId <- value)
            ({ assignments = state.assignments } : SynapseWorkspaceAadAdminState<'Login, Present, 'SynapseWorkspaceId, 'TenantId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_workspace_aad_admin#synapse_workspace_id-1">SynapseWorkspaceAadAdmin#synapse_workspace_id</a>.
        /// </summary>
        [<CustomOperation "synapse_workspace_id">]
        member _.SynapseWorkspaceId(state: SynapseWorkspaceAadAdminState<'Login, 'ObjectId, Missing, 'TenantId>, value: string) : SynapseWorkspaceAadAdminState<'Login, 'ObjectId, Present, 'TenantId> =
            state.assignments.Add(fun config -> config.SynapseWorkspaceId <- value)
            ({ assignments = state.assignments } : SynapseWorkspaceAadAdminState<'Login, 'ObjectId, Present, 'TenantId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_workspace_aad_admin#tenant_id-1">SynapseWorkspaceAadAdmin#tenant_id</a>.
        /// </summary>
        [<CustomOperation "tenant_id">]
        member _.TenantId(state: SynapseWorkspaceAadAdminState<'Login, 'ObjectId, 'SynapseWorkspaceId, Missing>, value: string) : SynapseWorkspaceAadAdminState<'Login, 'ObjectId, 'SynapseWorkspaceId, Present> =
            state.assignments.Add(fun config -> config.TenantId <- value)
            ({ assignments = state.assignments } : SynapseWorkspaceAadAdminState<'Login, 'ObjectId, 'SynapseWorkspaceId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_workspace_aad_admin#id-1">SynapseWorkspaceAadAdmin#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SynapseWorkspaceAadAdminState<'Login, 'ObjectId, 'SynapseWorkspaceId, 'TenantId>, value: string) : SynapseWorkspaceAadAdminState<'Login, 'ObjectId, 'SynapseWorkspaceId, 'TenantId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SynapseWorkspaceAadAdminState<'Login, 'ObjectId, 'SynapseWorkspaceId, 'TenantId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_workspace_aad_admin#timeouts-1">SynapseWorkspaceAadAdmin#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SynapseWorkspaceAadAdminState<'Login, 'ObjectId, 'SynapseWorkspaceId, 'TenantId>, value: azurerm.SynapseWorkspaceAadAdmin.SynapseWorkspaceAadAdminTimeouts) : SynapseWorkspaceAadAdminState<'Login, 'ObjectId, 'SynapseWorkspaceId, 'TenantId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SynapseWorkspaceAadAdminState<'Login, 'ObjectId, 'SynapseWorkspaceId, 'TenantId>

        member _.Run(state: SynapseWorkspaceAadAdminState<Present, Present, Present, Present>) : azurerm.SynapseWorkspaceAadAdmin.SynapseWorkspaceAadAdmin =
            let config = azurerm.SynapseWorkspaceAadAdmin.SynapseWorkspaceAadAdminConfig()
            for setter in state.assignments do
                setter config
            azurerm.SynapseWorkspaceAadAdmin.SynapseWorkspaceAadAdmin(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.synapseWorkspaceAadAdmin: missing required arguments. Must call: login, object_id, synapse_workspace_id, tenant_id.", 9999, IsError = true)>]
        member _.Run(_: SynapseWorkspaceAadAdminState<_, _, _, _>) : azurerm.SynapseWorkspaceAadAdmin.SynapseWorkspaceAadAdmin =
            Unchecked.defaultof<azurerm.SynapseWorkspaceAadAdmin.SynapseWorkspaceAadAdmin>

namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SynapseWorkspaceSqlAadAdminState<'Login, 'ObjectId, 'SynapseWorkspaceId, 'TenantId> = { assignments: ResizeArray<azurerm.SynapseWorkspaceSqlAadAdmin.SynapseWorkspaceSqlAadAdminConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_workspace_sql_aad_admin">azurerm_synapse_workspace_sql_aad_admin</a>.
    /// </summary>
    type SynapseWorkspaceSqlAadAdminBuilder(logicalId: string) =
        member _.Yield(_: unit) : SynapseWorkspaceSqlAadAdminState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SynapseWorkspaceSqlAadAdminState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : SynapseWorkspaceSqlAadAdminState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SynapseWorkspaceSqlAadAdminState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_workspace_sql_aad_admin#login-1">SynapseWorkspaceSqlAadAdmin#login</a>.
        /// </summary>
        [<CustomOperation "login">]
        member _.Login(state: SynapseWorkspaceSqlAadAdminState<Missing, 'ObjectId, 'SynapseWorkspaceId, 'TenantId>, value: string) : SynapseWorkspaceSqlAadAdminState<Present, 'ObjectId, 'SynapseWorkspaceId, 'TenantId> =
            state.assignments.Add(fun config -> config.Login <- value)
            ({ assignments = state.assignments } : SynapseWorkspaceSqlAadAdminState<Present, 'ObjectId, 'SynapseWorkspaceId, 'TenantId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_workspace_sql_aad_admin#object_id-1">SynapseWorkspaceSqlAadAdmin#object_id</a>.
        /// </summary>
        [<CustomOperation "object_id">]
        member _.ObjectId(state: SynapseWorkspaceSqlAadAdminState<'Login, Missing, 'SynapseWorkspaceId, 'TenantId>, value: string) : SynapseWorkspaceSqlAadAdminState<'Login, Present, 'SynapseWorkspaceId, 'TenantId> =
            state.assignments.Add(fun config -> config.ObjectId <- value)
            ({ assignments = state.assignments } : SynapseWorkspaceSqlAadAdminState<'Login, Present, 'SynapseWorkspaceId, 'TenantId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_workspace_sql_aad_admin#synapse_workspace_id-1">SynapseWorkspaceSqlAadAdmin#synapse_workspace_id</a>.
        /// </summary>
        [<CustomOperation "synapse_workspace_id">]
        member _.SynapseWorkspaceId(state: SynapseWorkspaceSqlAadAdminState<'Login, 'ObjectId, Missing, 'TenantId>, value: string) : SynapseWorkspaceSqlAadAdminState<'Login, 'ObjectId, Present, 'TenantId> =
            state.assignments.Add(fun config -> config.SynapseWorkspaceId <- value)
            ({ assignments = state.assignments } : SynapseWorkspaceSqlAadAdminState<'Login, 'ObjectId, Present, 'TenantId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_workspace_sql_aad_admin#tenant_id-1">SynapseWorkspaceSqlAadAdmin#tenant_id</a>.
        /// </summary>
        [<CustomOperation "tenant_id">]
        member _.TenantId(state: SynapseWorkspaceSqlAadAdminState<'Login, 'ObjectId, 'SynapseWorkspaceId, Missing>, value: string) : SynapseWorkspaceSqlAadAdminState<'Login, 'ObjectId, 'SynapseWorkspaceId, Present> =
            state.assignments.Add(fun config -> config.TenantId <- value)
            ({ assignments = state.assignments } : SynapseWorkspaceSqlAadAdminState<'Login, 'ObjectId, 'SynapseWorkspaceId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_workspace_sql_aad_admin#id-1">SynapseWorkspaceSqlAadAdmin#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SynapseWorkspaceSqlAadAdminState<'Login, 'ObjectId, 'SynapseWorkspaceId, 'TenantId>, value: string) : SynapseWorkspaceSqlAadAdminState<'Login, 'ObjectId, 'SynapseWorkspaceId, 'TenantId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SynapseWorkspaceSqlAadAdminState<'Login, 'ObjectId, 'SynapseWorkspaceId, 'TenantId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_workspace_sql_aad_admin#timeouts-1">SynapseWorkspaceSqlAadAdmin#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SynapseWorkspaceSqlAadAdminState<'Login, 'ObjectId, 'SynapseWorkspaceId, 'TenantId>, value: azurerm.SynapseWorkspaceSqlAadAdmin.SynapseWorkspaceSqlAadAdminTimeouts) : SynapseWorkspaceSqlAadAdminState<'Login, 'ObjectId, 'SynapseWorkspaceId, 'TenantId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SynapseWorkspaceSqlAadAdminState<'Login, 'ObjectId, 'SynapseWorkspaceId, 'TenantId>

        member _.Run(state: SynapseWorkspaceSqlAadAdminState<Present, Present, Present, Present>) : azurerm.SynapseWorkspaceSqlAadAdmin.SynapseWorkspaceSqlAadAdmin =
            let config = azurerm.SynapseWorkspaceSqlAadAdmin.SynapseWorkspaceSqlAadAdminConfig()
            for setter in state.assignments do
                setter config
            azurerm.SynapseWorkspaceSqlAadAdmin.SynapseWorkspaceSqlAadAdmin(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.synapseWorkspaceSqlAadAdmin: missing required arguments. Must call: login, object_id, synapse_workspace_id, tenant_id.", 9999, IsError = true)>]
        member _.Run(_: SynapseWorkspaceSqlAadAdminState<_, _, _, _>) : azurerm.SynapseWorkspaceSqlAadAdmin.SynapseWorkspaceSqlAadAdmin =
            Unchecked.defaultof<azurerm.SynapseWorkspaceSqlAadAdmin.SynapseWorkspaceSqlAadAdmin>

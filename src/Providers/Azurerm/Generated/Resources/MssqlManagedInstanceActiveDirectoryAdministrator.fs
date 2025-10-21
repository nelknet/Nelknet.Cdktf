namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MssqlManagedInstanceActiveDirectoryAdministratorState<'LoginUsername, 'ManagedInstanceId, 'ObjectId, 'TenantId> = { assignments: ResizeArray<azurerm.MssqlManagedInstanceActiveDirectoryAdministrator.MssqlManagedInstanceActiveDirectoryAdministratorConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_managed_instance_active_directory_administrator">azurerm_mssql_managed_instance_active_directory_administrator</a>.
    /// </summary>
    type MssqlManagedInstanceActiveDirectoryAdministratorBuilder(logicalId: string) =
        member _.Yield(_: unit) : MssqlManagedInstanceActiveDirectoryAdministratorState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MssqlManagedInstanceActiveDirectoryAdministratorState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : MssqlManagedInstanceActiveDirectoryAdministratorState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MssqlManagedInstanceActiveDirectoryAdministratorState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_managed_instance_active_directory_administrator#login_username-1">MssqlManagedInstanceActiveDirectoryAdministrator#login_username</a>.
        /// </summary>
        [<CustomOperation "login_username">]
        member _.LoginUsername(state: MssqlManagedInstanceActiveDirectoryAdministratorState<Missing, 'ManagedInstanceId, 'ObjectId, 'TenantId>, value: string) : MssqlManagedInstanceActiveDirectoryAdministratorState<Present, 'ManagedInstanceId, 'ObjectId, 'TenantId> =
            state.assignments.Add(fun config -> config.LoginUsername <- value)
            ({ assignments = state.assignments } : MssqlManagedInstanceActiveDirectoryAdministratorState<Present, 'ManagedInstanceId, 'ObjectId, 'TenantId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_managed_instance_active_directory_administrator#managed_instance_id-1">MssqlManagedInstanceActiveDirectoryAdministrator#managed_instance_id</a>.
        /// </summary>
        [<CustomOperation "managed_instance_id">]
        member _.ManagedInstanceId(state: MssqlManagedInstanceActiveDirectoryAdministratorState<'LoginUsername, Missing, 'ObjectId, 'TenantId>, value: string) : MssqlManagedInstanceActiveDirectoryAdministratorState<'LoginUsername, Present, 'ObjectId, 'TenantId> =
            state.assignments.Add(fun config -> config.ManagedInstanceId <- value)
            ({ assignments = state.assignments } : MssqlManagedInstanceActiveDirectoryAdministratorState<'LoginUsername, Present, 'ObjectId, 'TenantId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_managed_instance_active_directory_administrator#object_id-1">MssqlManagedInstanceActiveDirectoryAdministrator#object_id</a>.
        /// </summary>
        [<CustomOperation "object_id">]
        member _.ObjectId(state: MssqlManagedInstanceActiveDirectoryAdministratorState<'LoginUsername, 'ManagedInstanceId, Missing, 'TenantId>, value: string) : MssqlManagedInstanceActiveDirectoryAdministratorState<'LoginUsername, 'ManagedInstanceId, Present, 'TenantId> =
            state.assignments.Add(fun config -> config.ObjectId <- value)
            ({ assignments = state.assignments } : MssqlManagedInstanceActiveDirectoryAdministratorState<'LoginUsername, 'ManagedInstanceId, Present, 'TenantId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_managed_instance_active_directory_administrator#tenant_id-1">MssqlManagedInstanceActiveDirectoryAdministrator#tenant_id</a>.
        /// </summary>
        [<CustomOperation "tenant_id">]
        member _.TenantId(state: MssqlManagedInstanceActiveDirectoryAdministratorState<'LoginUsername, 'ManagedInstanceId, 'ObjectId, Missing>, value: string) : MssqlManagedInstanceActiveDirectoryAdministratorState<'LoginUsername, 'ManagedInstanceId, 'ObjectId, Present> =
            state.assignments.Add(fun config -> config.TenantId <- value)
            ({ assignments = state.assignments } : MssqlManagedInstanceActiveDirectoryAdministratorState<'LoginUsername, 'ManagedInstanceId, 'ObjectId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_managed_instance_active_directory_administrator#azuread_authentication_only-1">MssqlManagedInstanceActiveDirectoryAdministrator#azuread_authentication_only</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "azuread_authentication_only">]
        member _.AzureadAuthenticationOnly(state: MssqlManagedInstanceActiveDirectoryAdministratorState<'LoginUsername, 'ManagedInstanceId, 'ObjectId, 'TenantId>, value: bool) : MssqlManagedInstanceActiveDirectoryAdministratorState<'LoginUsername, 'ManagedInstanceId, 'ObjectId, 'TenantId> =
            state.assignments.Add(fun config -> config.AzureadAuthenticationOnly <- value)
            state : MssqlManagedInstanceActiveDirectoryAdministratorState<'LoginUsername, 'ManagedInstanceId, 'ObjectId, 'TenantId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_managed_instance_active_directory_administrator#azuread_authentication_only-1">MssqlManagedInstanceActiveDirectoryAdministrator#azuread_authentication_only</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "azuread_authentication_only">]
        member _.AzureadAuthenticationOnly(state: MssqlManagedInstanceActiveDirectoryAdministratorState<'LoginUsername, 'ManagedInstanceId, 'ObjectId, 'TenantId>, value: HashiCorp.Cdktf.IResolvable) : MssqlManagedInstanceActiveDirectoryAdministratorState<'LoginUsername, 'ManagedInstanceId, 'ObjectId, 'TenantId> =
            state.assignments.Add(fun config -> config.AzureadAuthenticationOnly <- value)
            state : MssqlManagedInstanceActiveDirectoryAdministratorState<'LoginUsername, 'ManagedInstanceId, 'ObjectId, 'TenantId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_managed_instance_active_directory_administrator#id-1">MssqlManagedInstanceActiveDirectoryAdministrator#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MssqlManagedInstanceActiveDirectoryAdministratorState<'LoginUsername, 'ManagedInstanceId, 'ObjectId, 'TenantId>, value: string) : MssqlManagedInstanceActiveDirectoryAdministratorState<'LoginUsername, 'ManagedInstanceId, 'ObjectId, 'TenantId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MssqlManagedInstanceActiveDirectoryAdministratorState<'LoginUsername, 'ManagedInstanceId, 'ObjectId, 'TenantId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_managed_instance_active_directory_administrator#timeouts-1">MssqlManagedInstanceActiveDirectoryAdministrator#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: MssqlManagedInstanceActiveDirectoryAdministratorState<'LoginUsername, 'ManagedInstanceId, 'ObjectId, 'TenantId>, value: azurerm.MssqlManagedInstanceActiveDirectoryAdministrator.MssqlManagedInstanceActiveDirectoryAdministratorTimeouts) : MssqlManagedInstanceActiveDirectoryAdministratorState<'LoginUsername, 'ManagedInstanceId, 'ObjectId, 'TenantId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : MssqlManagedInstanceActiveDirectoryAdministratorState<'LoginUsername, 'ManagedInstanceId, 'ObjectId, 'TenantId>

        member _.Run(state: MssqlManagedInstanceActiveDirectoryAdministratorState<Present, Present, Present, Present>) : azurerm.MssqlManagedInstanceActiveDirectoryAdministrator.MssqlManagedInstanceActiveDirectoryAdministrator =
            let config = azurerm.MssqlManagedInstanceActiveDirectoryAdministrator.MssqlManagedInstanceActiveDirectoryAdministratorConfig()
            for setter in state.assignments do
                setter config
            azurerm.MssqlManagedInstanceActiveDirectoryAdministrator.MssqlManagedInstanceActiveDirectoryAdministrator(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.mssqlManagedInstanceActiveDirectoryAdministrator: missing required arguments. Must call: login_username, managed_instance_id, object_id, tenant_id.", 9999, IsError = true)>]
        member _.Run(_: MssqlManagedInstanceActiveDirectoryAdministratorState<_, _, _, _>) : azurerm.MssqlManagedInstanceActiveDirectoryAdministrator.MssqlManagedInstanceActiveDirectoryAdministrator =
            Unchecked.defaultof<azurerm.MssqlManagedInstanceActiveDirectoryAdministrator.MssqlManagedInstanceActiveDirectoryAdministrator>

namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MysqlFlexibleServerActiveDirectoryAdministratorState<'IdentityId, 'Login, 'ObjectId, 'ServerId, 'TenantId> = { assignments: ResizeArray<azurerm.MysqlFlexibleServerActiveDirectoryAdministrator.MysqlFlexibleServerActiveDirectoryAdministratorConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mysql_flexible_server_active_directory_administrator">azurerm_mysql_flexible_server_active_directory_administrator</a>.
    /// </summary>
    type MysqlFlexibleServerActiveDirectoryAdministratorBuilder(logicalId: string) =
        member _.Yield(_: unit) : MysqlFlexibleServerActiveDirectoryAdministratorState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MysqlFlexibleServerActiveDirectoryAdministratorState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : MysqlFlexibleServerActiveDirectoryAdministratorState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MysqlFlexibleServerActiveDirectoryAdministratorState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mysql_flexible_server_active_directory_administrator#identity_id-1">MysqlFlexibleServerActiveDirectoryAdministrator#identity_id</a>.
        /// </summary>
        [<CustomOperation "identity_id">]
        member _.IdentityId(state: MysqlFlexibleServerActiveDirectoryAdministratorState<Missing, 'Login, 'ObjectId, 'ServerId, 'TenantId>, value: string) : MysqlFlexibleServerActiveDirectoryAdministratorState<Present, 'Login, 'ObjectId, 'ServerId, 'TenantId> =
            state.assignments.Add(fun config -> config.IdentityId <- value)
            ({ assignments = state.assignments } : MysqlFlexibleServerActiveDirectoryAdministratorState<Present, 'Login, 'ObjectId, 'ServerId, 'TenantId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mysql_flexible_server_active_directory_administrator#login-1">MysqlFlexibleServerActiveDirectoryAdministrator#login</a>.
        /// </summary>
        [<CustomOperation "login">]
        member _.Login(state: MysqlFlexibleServerActiveDirectoryAdministratorState<'IdentityId, Missing, 'ObjectId, 'ServerId, 'TenantId>, value: string) : MysqlFlexibleServerActiveDirectoryAdministratorState<'IdentityId, Present, 'ObjectId, 'ServerId, 'TenantId> =
            state.assignments.Add(fun config -> config.Login <- value)
            ({ assignments = state.assignments } : MysqlFlexibleServerActiveDirectoryAdministratorState<'IdentityId, Present, 'ObjectId, 'ServerId, 'TenantId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mysql_flexible_server_active_directory_administrator#object_id-1">MysqlFlexibleServerActiveDirectoryAdministrator#object_id</a>.
        /// </summary>
        [<CustomOperation "object_id">]
        member _.ObjectId(state: MysqlFlexibleServerActiveDirectoryAdministratorState<'IdentityId, 'Login, Missing, 'ServerId, 'TenantId>, value: string) : MysqlFlexibleServerActiveDirectoryAdministratorState<'IdentityId, 'Login, Present, 'ServerId, 'TenantId> =
            state.assignments.Add(fun config -> config.ObjectId <- value)
            ({ assignments = state.assignments } : MysqlFlexibleServerActiveDirectoryAdministratorState<'IdentityId, 'Login, Present, 'ServerId, 'TenantId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mysql_flexible_server_active_directory_administrator#server_id-1">MysqlFlexibleServerActiveDirectoryAdministrator#server_id</a>.
        /// </summary>
        [<CustomOperation "server_id">]
        member _.ServerId(state: MysqlFlexibleServerActiveDirectoryAdministratorState<'IdentityId, 'Login, 'ObjectId, Missing, 'TenantId>, value: string) : MysqlFlexibleServerActiveDirectoryAdministratorState<'IdentityId, 'Login, 'ObjectId, Present, 'TenantId> =
            state.assignments.Add(fun config -> config.ServerId <- value)
            ({ assignments = state.assignments } : MysqlFlexibleServerActiveDirectoryAdministratorState<'IdentityId, 'Login, 'ObjectId, Present, 'TenantId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mysql_flexible_server_active_directory_administrator#tenant_id-1">MysqlFlexibleServerActiveDirectoryAdministrator#tenant_id</a>.
        /// </summary>
        [<CustomOperation "tenant_id">]
        member _.TenantId(state: MysqlFlexibleServerActiveDirectoryAdministratorState<'IdentityId, 'Login, 'ObjectId, 'ServerId, Missing>, value: string) : MysqlFlexibleServerActiveDirectoryAdministratorState<'IdentityId, 'Login, 'ObjectId, 'ServerId, Present> =
            state.assignments.Add(fun config -> config.TenantId <- value)
            ({ assignments = state.assignments } : MysqlFlexibleServerActiveDirectoryAdministratorState<'IdentityId, 'Login, 'ObjectId, 'ServerId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mysql_flexible_server_active_directory_administrator#id-1">MysqlFlexibleServerActiveDirectoryAdministrator#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MysqlFlexibleServerActiveDirectoryAdministratorState<'IdentityId, 'Login, 'ObjectId, 'ServerId, 'TenantId>, value: string) : MysqlFlexibleServerActiveDirectoryAdministratorState<'IdentityId, 'Login, 'ObjectId, 'ServerId, 'TenantId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MysqlFlexibleServerActiveDirectoryAdministratorState<'IdentityId, 'Login, 'ObjectId, 'ServerId, 'TenantId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mysql_flexible_server_active_directory_administrator#timeouts-1">MysqlFlexibleServerActiveDirectoryAdministrator#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: MysqlFlexibleServerActiveDirectoryAdministratorState<'IdentityId, 'Login, 'ObjectId, 'ServerId, 'TenantId>, value: azurerm.MysqlFlexibleServerActiveDirectoryAdministrator.MysqlFlexibleServerActiveDirectoryAdministratorTimeouts) : MysqlFlexibleServerActiveDirectoryAdministratorState<'IdentityId, 'Login, 'ObjectId, 'ServerId, 'TenantId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : MysqlFlexibleServerActiveDirectoryAdministratorState<'IdentityId, 'Login, 'ObjectId, 'ServerId, 'TenantId>

        member _.Run(state: MysqlFlexibleServerActiveDirectoryAdministratorState<Present, Present, Present, Present, Present>) : azurerm.MysqlFlexibleServerActiveDirectoryAdministrator.MysqlFlexibleServerActiveDirectoryAdministrator =
            let config = azurerm.MysqlFlexibleServerActiveDirectoryAdministrator.MysqlFlexibleServerActiveDirectoryAdministratorConfig()
            for setter in state.assignments do
                setter config
            azurerm.MysqlFlexibleServerActiveDirectoryAdministrator.MysqlFlexibleServerActiveDirectoryAdministrator(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.mysqlFlexibleServerActiveDirectoryAdministrator: missing required arguments. Must call: identity_id, login, object_id, server_id, tenant_id.", 9999, IsError = true)>]
        member _.Run(_: MysqlFlexibleServerActiveDirectoryAdministratorState<_, _, _, _, _>) : azurerm.MysqlFlexibleServerActiveDirectoryAdministrator.MysqlFlexibleServerActiveDirectoryAdministrator =
            Unchecked.defaultof<azurerm.MysqlFlexibleServerActiveDirectoryAdministrator.MysqlFlexibleServerActiveDirectoryAdministrator>

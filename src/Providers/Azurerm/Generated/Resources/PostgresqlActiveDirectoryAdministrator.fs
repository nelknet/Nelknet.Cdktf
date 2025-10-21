namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type PostgresqlActiveDirectoryAdministratorState<'Login, 'ObjectId, 'ResourceGroupName, 'ServerName, 'TenantId> = { assignments: ResizeArray<azurerm.PostgresqlActiveDirectoryAdministrator.PostgresqlActiveDirectoryAdministratorConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_active_directory_administrator">azurerm_postgresql_active_directory_administrator</a>.
    /// </summary>
    type PostgresqlActiveDirectoryAdministratorBuilder(logicalId: string) =
        member _.Yield(_: unit) : PostgresqlActiveDirectoryAdministratorState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PostgresqlActiveDirectoryAdministratorState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : PostgresqlActiveDirectoryAdministratorState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PostgresqlActiveDirectoryAdministratorState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_active_directory_administrator#login-1">PostgresqlActiveDirectoryAdministrator#login</a>.
        /// </summary>
        [<CustomOperation "login">]
        member _.Login(state: PostgresqlActiveDirectoryAdministratorState<Missing, 'ObjectId, 'ResourceGroupName, 'ServerName, 'TenantId>, value: string) : PostgresqlActiveDirectoryAdministratorState<Present, 'ObjectId, 'ResourceGroupName, 'ServerName, 'TenantId> =
            state.assignments.Add(fun config -> config.Login <- value)
            ({ assignments = state.assignments } : PostgresqlActiveDirectoryAdministratorState<Present, 'ObjectId, 'ResourceGroupName, 'ServerName, 'TenantId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_active_directory_administrator#object_id-1">PostgresqlActiveDirectoryAdministrator#object_id</a>.
        /// </summary>
        [<CustomOperation "object_id">]
        member _.ObjectId(state: PostgresqlActiveDirectoryAdministratorState<'Login, Missing, 'ResourceGroupName, 'ServerName, 'TenantId>, value: string) : PostgresqlActiveDirectoryAdministratorState<'Login, Present, 'ResourceGroupName, 'ServerName, 'TenantId> =
            state.assignments.Add(fun config -> config.ObjectId <- value)
            ({ assignments = state.assignments } : PostgresqlActiveDirectoryAdministratorState<'Login, Present, 'ResourceGroupName, 'ServerName, 'TenantId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_active_directory_administrator#resource_group_name-1">PostgresqlActiveDirectoryAdministrator#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: PostgresqlActiveDirectoryAdministratorState<'Login, 'ObjectId, Missing, 'ServerName, 'TenantId>, value: string) : PostgresqlActiveDirectoryAdministratorState<'Login, 'ObjectId, Present, 'ServerName, 'TenantId> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : PostgresqlActiveDirectoryAdministratorState<'Login, 'ObjectId, Present, 'ServerName, 'TenantId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_active_directory_administrator#server_name-1">PostgresqlActiveDirectoryAdministrator#server_name</a>.
        /// </summary>
        [<CustomOperation "server_name">]
        member _.ServerName(state: PostgresqlActiveDirectoryAdministratorState<'Login, 'ObjectId, 'ResourceGroupName, Missing, 'TenantId>, value: string) : PostgresqlActiveDirectoryAdministratorState<'Login, 'ObjectId, 'ResourceGroupName, Present, 'TenantId> =
            state.assignments.Add(fun config -> config.ServerName <- value)
            ({ assignments = state.assignments } : PostgresqlActiveDirectoryAdministratorState<'Login, 'ObjectId, 'ResourceGroupName, Present, 'TenantId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_active_directory_administrator#tenant_id-1">PostgresqlActiveDirectoryAdministrator#tenant_id</a>.
        /// </summary>
        [<CustomOperation "tenant_id">]
        member _.TenantId(state: PostgresqlActiveDirectoryAdministratorState<'Login, 'ObjectId, 'ResourceGroupName, 'ServerName, Missing>, value: string) : PostgresqlActiveDirectoryAdministratorState<'Login, 'ObjectId, 'ResourceGroupName, 'ServerName, Present> =
            state.assignments.Add(fun config -> config.TenantId <- value)
            ({ assignments = state.assignments } : PostgresqlActiveDirectoryAdministratorState<'Login, 'ObjectId, 'ResourceGroupName, 'ServerName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_active_directory_administrator#id-1">PostgresqlActiveDirectoryAdministrator#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: PostgresqlActiveDirectoryAdministratorState<'Login, 'ObjectId, 'ResourceGroupName, 'ServerName, 'TenantId>, value: string) : PostgresqlActiveDirectoryAdministratorState<'Login, 'ObjectId, 'ResourceGroupName, 'ServerName, 'TenantId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : PostgresqlActiveDirectoryAdministratorState<'Login, 'ObjectId, 'ResourceGroupName, 'ServerName, 'TenantId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_active_directory_administrator#timeouts-1">PostgresqlActiveDirectoryAdministrator#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: PostgresqlActiveDirectoryAdministratorState<'Login, 'ObjectId, 'ResourceGroupName, 'ServerName, 'TenantId>, value: azurerm.PostgresqlActiveDirectoryAdministrator.PostgresqlActiveDirectoryAdministratorTimeouts) : PostgresqlActiveDirectoryAdministratorState<'Login, 'ObjectId, 'ResourceGroupName, 'ServerName, 'TenantId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : PostgresqlActiveDirectoryAdministratorState<'Login, 'ObjectId, 'ResourceGroupName, 'ServerName, 'TenantId>

        member _.Run(state: PostgresqlActiveDirectoryAdministratorState<Present, Present, Present, Present, Present>) : azurerm.PostgresqlActiveDirectoryAdministrator.PostgresqlActiveDirectoryAdministrator =
            let config = azurerm.PostgresqlActiveDirectoryAdministrator.PostgresqlActiveDirectoryAdministratorConfig()
            for setter in state.assignments do
                setter config
            azurerm.PostgresqlActiveDirectoryAdministrator.PostgresqlActiveDirectoryAdministrator(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.postgresqlActiveDirectoryAdministrator: missing required arguments. Must call: login, object_id, resource_group_name, server_name, tenant_id.", 9999, IsError = true)>]
        member _.Run(_: PostgresqlActiveDirectoryAdministratorState<_, _, _, _, _>) : azurerm.PostgresqlActiveDirectoryAdministrator.PostgresqlActiveDirectoryAdministrator =
            Unchecked.defaultof<azurerm.PostgresqlActiveDirectoryAdministrator.PostgresqlActiveDirectoryAdministrator>

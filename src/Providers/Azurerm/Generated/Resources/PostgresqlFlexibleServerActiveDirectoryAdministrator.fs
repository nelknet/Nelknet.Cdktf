namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type PostgresqlFlexibleServerActiveDirectoryAdministratorState<'ObjectId, 'PrincipalName, 'PrincipalType, 'ResourceGroupName, 'ServerName, 'TenantId> = { assignments: ResizeArray<azurerm.PostgresqlFlexibleServerActiveDirectoryAdministrator.PostgresqlFlexibleServerActiveDirectoryAdministratorConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_flexible_server_active_directory_administrator">azurerm_postgresql_flexible_server_active_directory_administrator</a>.
    /// </summary>
    type PostgresqlFlexibleServerActiveDirectoryAdministratorBuilder(logicalId: string) =
        member _.Yield(_: unit) : PostgresqlFlexibleServerActiveDirectoryAdministratorState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PostgresqlFlexibleServerActiveDirectoryAdministratorState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : PostgresqlFlexibleServerActiveDirectoryAdministratorState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PostgresqlFlexibleServerActiveDirectoryAdministratorState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_flexible_server_active_directory_administrator#object_id-1">PostgresqlFlexibleServerActiveDirectoryAdministrator#object_id</a>.
        /// </summary>
        [<CustomOperation "object_id">]
        member _.ObjectId(state: PostgresqlFlexibleServerActiveDirectoryAdministratorState<Missing, 'PrincipalName, 'PrincipalType, 'ResourceGroupName, 'ServerName, 'TenantId>, value: string) : PostgresqlFlexibleServerActiveDirectoryAdministratorState<Present, 'PrincipalName, 'PrincipalType, 'ResourceGroupName, 'ServerName, 'TenantId> =
            state.assignments.Add(fun config -> config.ObjectId <- value)
            ({ assignments = state.assignments } : PostgresqlFlexibleServerActiveDirectoryAdministratorState<Present, 'PrincipalName, 'PrincipalType, 'ResourceGroupName, 'ServerName, 'TenantId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_flexible_server_active_directory_administrator#principal_name-1">PostgresqlFlexibleServerActiveDirectoryAdministrator#principal_name</a>.
        /// </summary>
        [<CustomOperation "principal_name">]
        member _.PrincipalName(state: PostgresqlFlexibleServerActiveDirectoryAdministratorState<'ObjectId, Missing, 'PrincipalType, 'ResourceGroupName, 'ServerName, 'TenantId>, value: string) : PostgresqlFlexibleServerActiveDirectoryAdministratorState<'ObjectId, Present, 'PrincipalType, 'ResourceGroupName, 'ServerName, 'TenantId> =
            state.assignments.Add(fun config -> config.PrincipalName <- value)
            ({ assignments = state.assignments } : PostgresqlFlexibleServerActiveDirectoryAdministratorState<'ObjectId, Present, 'PrincipalType, 'ResourceGroupName, 'ServerName, 'TenantId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_flexible_server_active_directory_administrator#principal_type-1">PostgresqlFlexibleServerActiveDirectoryAdministrator#principal_type</a>.
        /// </summary>
        [<CustomOperation "principal_type">]
        member _.PrincipalType(state: PostgresqlFlexibleServerActiveDirectoryAdministratorState<'ObjectId, 'PrincipalName, Missing, 'ResourceGroupName, 'ServerName, 'TenantId>, value: string) : PostgresqlFlexibleServerActiveDirectoryAdministratorState<'ObjectId, 'PrincipalName, Present, 'ResourceGroupName, 'ServerName, 'TenantId> =
            state.assignments.Add(fun config -> config.PrincipalType <- value)
            ({ assignments = state.assignments } : PostgresqlFlexibleServerActiveDirectoryAdministratorState<'ObjectId, 'PrincipalName, Present, 'ResourceGroupName, 'ServerName, 'TenantId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_flexible_server_active_directory_administrator#resource_group_name-1">PostgresqlFlexibleServerActiveDirectoryAdministrator#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: PostgresqlFlexibleServerActiveDirectoryAdministratorState<'ObjectId, 'PrincipalName, 'PrincipalType, Missing, 'ServerName, 'TenantId>, value: string) : PostgresqlFlexibleServerActiveDirectoryAdministratorState<'ObjectId, 'PrincipalName, 'PrincipalType, Present, 'ServerName, 'TenantId> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : PostgresqlFlexibleServerActiveDirectoryAdministratorState<'ObjectId, 'PrincipalName, 'PrincipalType, Present, 'ServerName, 'TenantId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_flexible_server_active_directory_administrator#server_name-1">PostgresqlFlexibleServerActiveDirectoryAdministrator#server_name</a>.
        /// </summary>
        [<CustomOperation "server_name">]
        member _.ServerName(state: PostgresqlFlexibleServerActiveDirectoryAdministratorState<'ObjectId, 'PrincipalName, 'PrincipalType, 'ResourceGroupName, Missing, 'TenantId>, value: string) : PostgresqlFlexibleServerActiveDirectoryAdministratorState<'ObjectId, 'PrincipalName, 'PrincipalType, 'ResourceGroupName, Present, 'TenantId> =
            state.assignments.Add(fun config -> config.ServerName <- value)
            ({ assignments = state.assignments } : PostgresqlFlexibleServerActiveDirectoryAdministratorState<'ObjectId, 'PrincipalName, 'PrincipalType, 'ResourceGroupName, Present, 'TenantId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_flexible_server_active_directory_administrator#tenant_id-1">PostgresqlFlexibleServerActiveDirectoryAdministrator#tenant_id</a>.
        /// </summary>
        [<CustomOperation "tenant_id">]
        member _.TenantId(state: PostgresqlFlexibleServerActiveDirectoryAdministratorState<'ObjectId, 'PrincipalName, 'PrincipalType, 'ResourceGroupName, 'ServerName, Missing>, value: string) : PostgresqlFlexibleServerActiveDirectoryAdministratorState<'ObjectId, 'PrincipalName, 'PrincipalType, 'ResourceGroupName, 'ServerName, Present> =
            state.assignments.Add(fun config -> config.TenantId <- value)
            ({ assignments = state.assignments } : PostgresqlFlexibleServerActiveDirectoryAdministratorState<'ObjectId, 'PrincipalName, 'PrincipalType, 'ResourceGroupName, 'ServerName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_flexible_server_active_directory_administrator#id-1">PostgresqlFlexibleServerActiveDirectoryAdministrator#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: PostgresqlFlexibleServerActiveDirectoryAdministratorState<'ObjectId, 'PrincipalName, 'PrincipalType, 'ResourceGroupName, 'ServerName, 'TenantId>, value: string) : PostgresqlFlexibleServerActiveDirectoryAdministratorState<'ObjectId, 'PrincipalName, 'PrincipalType, 'ResourceGroupName, 'ServerName, 'TenantId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : PostgresqlFlexibleServerActiveDirectoryAdministratorState<'ObjectId, 'PrincipalName, 'PrincipalType, 'ResourceGroupName, 'ServerName, 'TenantId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_flexible_server_active_directory_administrator#timeouts-1">PostgresqlFlexibleServerActiveDirectoryAdministrator#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: PostgresqlFlexibleServerActiveDirectoryAdministratorState<'ObjectId, 'PrincipalName, 'PrincipalType, 'ResourceGroupName, 'ServerName, 'TenantId>, value: azurerm.PostgresqlFlexibleServerActiveDirectoryAdministrator.PostgresqlFlexibleServerActiveDirectoryAdministratorTimeouts) : PostgresqlFlexibleServerActiveDirectoryAdministratorState<'ObjectId, 'PrincipalName, 'PrincipalType, 'ResourceGroupName, 'ServerName, 'TenantId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : PostgresqlFlexibleServerActiveDirectoryAdministratorState<'ObjectId, 'PrincipalName, 'PrincipalType, 'ResourceGroupName, 'ServerName, 'TenantId>

        member _.Run(state: PostgresqlFlexibleServerActiveDirectoryAdministratorState<Present, Present, Present, Present, Present, Present>) : azurerm.PostgresqlFlexibleServerActiveDirectoryAdministrator.PostgresqlFlexibleServerActiveDirectoryAdministrator =
            let config = azurerm.PostgresqlFlexibleServerActiveDirectoryAdministrator.PostgresqlFlexibleServerActiveDirectoryAdministratorConfig()
            for setter in state.assignments do
                setter config
            azurerm.PostgresqlFlexibleServerActiveDirectoryAdministrator.PostgresqlFlexibleServerActiveDirectoryAdministrator(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.postgresqlFlexibleServerActiveDirectoryAdministrator: missing required arguments. Must call: object_id, principal_name, principal_type, resource_group_name, server_name, tenant_id.", 9999, IsError = true)>]
        member _.Run(_: PostgresqlFlexibleServerActiveDirectoryAdministratorState<_, _, _, _, _, _>) : azurerm.PostgresqlFlexibleServerActiveDirectoryAdministrator.PostgresqlFlexibleServerActiveDirectoryAdministrator =
            Unchecked.defaultof<azurerm.PostgresqlFlexibleServerActiveDirectoryAdministrator.PostgresqlFlexibleServerActiveDirectoryAdministrator>

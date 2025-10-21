namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermDatabaseMigrationServiceState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermDatabaseMigrationService.DataAzurermDatabaseMigrationServiceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/database_migration_service">azurerm_database_migration_service</a>.
    /// </summary>
    type DataAzurermDatabaseMigrationServiceBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermDatabaseMigrationServiceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermDatabaseMigrationServiceState<Missing, Missing>)

        member _.Zero(()) : DataAzurermDatabaseMigrationServiceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermDatabaseMigrationServiceState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/database_migration_service#name-1">DataAzurermDatabaseMigrationService#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermDatabaseMigrationServiceState<Missing, 'ResourceGroupName>, value: string) : DataAzurermDatabaseMigrationServiceState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermDatabaseMigrationServiceState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/database_migration_service#resource_group_name-1">DataAzurermDatabaseMigrationService#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermDatabaseMigrationServiceState<'Name, Missing>, value: string) : DataAzurermDatabaseMigrationServiceState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermDatabaseMigrationServiceState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/database_migration_service#id-1">DataAzurermDatabaseMigrationService#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermDatabaseMigrationServiceState<'Name, 'ResourceGroupName>, value: string) : DataAzurermDatabaseMigrationServiceState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermDatabaseMigrationServiceState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/database_migration_service#timeouts-1">DataAzurermDatabaseMigrationService#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermDatabaseMigrationServiceState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermDatabaseMigrationService.DataAzurermDatabaseMigrationServiceTimeouts) : DataAzurermDatabaseMigrationServiceState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermDatabaseMigrationServiceState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermDatabaseMigrationServiceState<Present, Present>) : azurerm.DataAzurermDatabaseMigrationService.DataAzurermDatabaseMigrationService =
            let config = azurerm.DataAzurermDatabaseMigrationService.DataAzurermDatabaseMigrationServiceConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermDatabaseMigrationService.DataAzurermDatabaseMigrationService(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermDatabaseMigrationService: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermDatabaseMigrationServiceState<_, _>) : azurerm.DataAzurermDatabaseMigrationService.DataAzurermDatabaseMigrationService =
            Unchecked.defaultof<azurerm.DataAzurermDatabaseMigrationService.DataAzurermDatabaseMigrationService>

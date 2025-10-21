namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermDatabaseMigrationProjectState<'Name, 'ResourceGroupName, 'ServiceName> = { assignments: ResizeArray<azurerm.DataAzurermDatabaseMigrationProject.DataAzurermDatabaseMigrationProjectConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/database_migration_project">azurerm_database_migration_project</a>.
    /// </summary>
    type DataAzurermDatabaseMigrationProjectBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermDatabaseMigrationProjectState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermDatabaseMigrationProjectState<Missing, Missing, Missing>)

        member _.Zero(()) : DataAzurermDatabaseMigrationProjectState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermDatabaseMigrationProjectState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/database_migration_project#name-1">DataAzurermDatabaseMigrationProject#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermDatabaseMigrationProjectState<Missing, 'ResourceGroupName, 'ServiceName>, value: string) : DataAzurermDatabaseMigrationProjectState<Present, 'ResourceGroupName, 'ServiceName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermDatabaseMigrationProjectState<Present, 'ResourceGroupName, 'ServiceName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/database_migration_project#resource_group_name-1">DataAzurermDatabaseMigrationProject#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermDatabaseMigrationProjectState<'Name, Missing, 'ServiceName>, value: string) : DataAzurermDatabaseMigrationProjectState<'Name, Present, 'ServiceName> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermDatabaseMigrationProjectState<'Name, Present, 'ServiceName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/database_migration_project#service_name-1">DataAzurermDatabaseMigrationProject#service_name</a>.
        /// </summary>
        [<CustomOperation "service_name">]
        member _.ServiceName(state: DataAzurermDatabaseMigrationProjectState<'Name, 'ResourceGroupName, Missing>, value: string) : DataAzurermDatabaseMigrationProjectState<'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.ServiceName <- value)
            ({ assignments = state.assignments } : DataAzurermDatabaseMigrationProjectState<'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/database_migration_project#id-1">DataAzurermDatabaseMigrationProject#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermDatabaseMigrationProjectState<'Name, 'ResourceGroupName, 'ServiceName>, value: string) : DataAzurermDatabaseMigrationProjectState<'Name, 'ResourceGroupName, 'ServiceName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermDatabaseMigrationProjectState<'Name, 'ResourceGroupName, 'ServiceName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/database_migration_project#timeouts-1">DataAzurermDatabaseMigrationProject#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermDatabaseMigrationProjectState<'Name, 'ResourceGroupName, 'ServiceName>, value: azurerm.DataAzurermDatabaseMigrationProject.DataAzurermDatabaseMigrationProjectTimeouts) : DataAzurermDatabaseMigrationProjectState<'Name, 'ResourceGroupName, 'ServiceName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermDatabaseMigrationProjectState<'Name, 'ResourceGroupName, 'ServiceName>

        member _.Run(state: DataAzurermDatabaseMigrationProjectState<Present, Present, Present>) : azurerm.DataAzurermDatabaseMigrationProject.DataAzurermDatabaseMigrationProject =
            let config = azurerm.DataAzurermDatabaseMigrationProject.DataAzurermDatabaseMigrationProjectConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermDatabaseMigrationProject.DataAzurermDatabaseMigrationProject(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermDatabaseMigrationProject: missing required arguments. Must call: name, resource_group_name, service_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermDatabaseMigrationProjectState<_, _, _>) : azurerm.DataAzurermDatabaseMigrationProject.DataAzurermDatabaseMigrationProject =
            Unchecked.defaultof<azurerm.DataAzurermDatabaseMigrationProject.DataAzurermDatabaseMigrationProject>

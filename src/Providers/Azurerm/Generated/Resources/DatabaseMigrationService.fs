namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DatabaseMigrationServiceState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SubnetId> = { assignments: ResizeArray<azurerm.DatabaseMigrationService.DatabaseMigrationServiceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/database_migration_service">azurerm_database_migration_service</a>.
    /// </summary>
    type DatabaseMigrationServiceBuilder(logicalId: string) =
        member _.Yield(_: unit) : DatabaseMigrationServiceState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DatabaseMigrationServiceState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : DatabaseMigrationServiceState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DatabaseMigrationServiceState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/database_migration_service#location-1">DatabaseMigrationService#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: DatabaseMigrationServiceState<Missing, 'Name, 'ResourceGroupName, 'SkuName, 'SubnetId>, value: string) : DatabaseMigrationServiceState<Present, 'Name, 'ResourceGroupName, 'SkuName, 'SubnetId> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : DatabaseMigrationServiceState<Present, 'Name, 'ResourceGroupName, 'SkuName, 'SubnetId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/database_migration_service#name-1">DatabaseMigrationService#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DatabaseMigrationServiceState<'Location, Missing, 'ResourceGroupName, 'SkuName, 'SubnetId>, value: string) : DatabaseMigrationServiceState<'Location, Present, 'ResourceGroupName, 'SkuName, 'SubnetId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DatabaseMigrationServiceState<'Location, Present, 'ResourceGroupName, 'SkuName, 'SubnetId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/database_migration_service#resource_group_name-1">DatabaseMigrationService#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DatabaseMigrationServiceState<'Location, 'Name, Missing, 'SkuName, 'SubnetId>, value: string) : DatabaseMigrationServiceState<'Location, 'Name, Present, 'SkuName, 'SubnetId> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DatabaseMigrationServiceState<'Location, 'Name, Present, 'SkuName, 'SubnetId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/database_migration_service#sku_name-1">DatabaseMigrationService#sku_name</a>.
        /// </summary>
        [<CustomOperation "sku_name">]
        member _.SkuName(state: DatabaseMigrationServiceState<'Location, 'Name, 'ResourceGroupName, Missing, 'SubnetId>, value: string) : DatabaseMigrationServiceState<'Location, 'Name, 'ResourceGroupName, Present, 'SubnetId> =
            state.assignments.Add(fun config -> config.SkuName <- value)
            ({ assignments = state.assignments } : DatabaseMigrationServiceState<'Location, 'Name, 'ResourceGroupName, Present, 'SubnetId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/database_migration_service#subnet_id-1">DatabaseMigrationService#subnet_id</a>.
        /// </summary>
        [<CustomOperation "subnet_id">]
        member _.SubnetId(state: DatabaseMigrationServiceState<'Location, 'Name, 'ResourceGroupName, 'SkuName, Missing>, value: string) : DatabaseMigrationServiceState<'Location, 'Name, 'ResourceGroupName, 'SkuName, Present> =
            state.assignments.Add(fun config -> config.SubnetId <- value)
            ({ assignments = state.assignments } : DatabaseMigrationServiceState<'Location, 'Name, 'ResourceGroupName, 'SkuName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/database_migration_service#id-1">DatabaseMigrationService#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DatabaseMigrationServiceState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SubnetId>, value: string) : DatabaseMigrationServiceState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SubnetId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DatabaseMigrationServiceState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SubnetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/database_migration_service#tags-1">DatabaseMigrationService#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DatabaseMigrationServiceState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SubnetId>, value: seq<string * string>) : DatabaseMigrationServiceState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SubnetId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DatabaseMigrationServiceState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SubnetId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/database_migration_service#timeouts-1">DatabaseMigrationService#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DatabaseMigrationServiceState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SubnetId>, value: azurerm.DatabaseMigrationService.DatabaseMigrationServiceTimeouts) : DatabaseMigrationServiceState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SubnetId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DatabaseMigrationServiceState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SubnetId>

        member _.Run(state: DatabaseMigrationServiceState<Present, Present, Present, Present, Present>) : azurerm.DatabaseMigrationService.DatabaseMigrationService =
            let config = azurerm.DatabaseMigrationService.DatabaseMigrationServiceConfig()
            for setter in state.assignments do
                setter config
            azurerm.DatabaseMigrationService.DatabaseMigrationService(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.databaseMigrationService: missing required arguments. Must call: location, name, resource_group_name, sku_name, subnet_id.", 9999, IsError = true)>]
        member _.Run(_: DatabaseMigrationServiceState<_, _, _, _, _>) : azurerm.DatabaseMigrationService.DatabaseMigrationService =
            Unchecked.defaultof<azurerm.DatabaseMigrationService.DatabaseMigrationService>

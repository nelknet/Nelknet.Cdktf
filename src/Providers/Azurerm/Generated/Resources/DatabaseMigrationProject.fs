namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DatabaseMigrationProjectState<'Location, 'Name, 'ResourceGroupName, 'ServiceName, 'SourcePlatform, 'TargetPlatform> = { assignments: ResizeArray<azurerm.DatabaseMigrationProject.DatabaseMigrationProjectConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/database_migration_project">azurerm_database_migration_project</a>.
    /// </summary>
    type DatabaseMigrationProjectBuilder(logicalId: string) =
        member _.Yield(_: unit) : DatabaseMigrationProjectState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DatabaseMigrationProjectState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : DatabaseMigrationProjectState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DatabaseMigrationProjectState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/database_migration_project#location-1">DatabaseMigrationProject#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: DatabaseMigrationProjectState<Missing, 'Name, 'ResourceGroupName, 'ServiceName, 'SourcePlatform, 'TargetPlatform>, value: string) : DatabaseMigrationProjectState<Present, 'Name, 'ResourceGroupName, 'ServiceName, 'SourcePlatform, 'TargetPlatform> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : DatabaseMigrationProjectState<Present, 'Name, 'ResourceGroupName, 'ServiceName, 'SourcePlatform, 'TargetPlatform>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/database_migration_project#name-1">DatabaseMigrationProject#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DatabaseMigrationProjectState<'Location, Missing, 'ResourceGroupName, 'ServiceName, 'SourcePlatform, 'TargetPlatform>, value: string) : DatabaseMigrationProjectState<'Location, Present, 'ResourceGroupName, 'ServiceName, 'SourcePlatform, 'TargetPlatform> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DatabaseMigrationProjectState<'Location, Present, 'ResourceGroupName, 'ServiceName, 'SourcePlatform, 'TargetPlatform>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/database_migration_project#resource_group_name-1">DatabaseMigrationProject#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DatabaseMigrationProjectState<'Location, 'Name, Missing, 'ServiceName, 'SourcePlatform, 'TargetPlatform>, value: string) : DatabaseMigrationProjectState<'Location, 'Name, Present, 'ServiceName, 'SourcePlatform, 'TargetPlatform> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DatabaseMigrationProjectState<'Location, 'Name, Present, 'ServiceName, 'SourcePlatform, 'TargetPlatform>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/database_migration_project#service_name-1">DatabaseMigrationProject#service_name</a>.
        /// </summary>
        [<CustomOperation "service_name">]
        member _.ServiceName(state: DatabaseMigrationProjectState<'Location, 'Name, 'ResourceGroupName, Missing, 'SourcePlatform, 'TargetPlatform>, value: string) : DatabaseMigrationProjectState<'Location, 'Name, 'ResourceGroupName, Present, 'SourcePlatform, 'TargetPlatform> =
            state.assignments.Add(fun config -> config.ServiceName <- value)
            ({ assignments = state.assignments } : DatabaseMigrationProjectState<'Location, 'Name, 'ResourceGroupName, Present, 'SourcePlatform, 'TargetPlatform>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/database_migration_project#source_platform-1">DatabaseMigrationProject#source_platform</a>.
        /// </summary>
        [<CustomOperation "source_platform">]
        member _.SourcePlatform(state: DatabaseMigrationProjectState<'Location, 'Name, 'ResourceGroupName, 'ServiceName, Missing, 'TargetPlatform>, value: string) : DatabaseMigrationProjectState<'Location, 'Name, 'ResourceGroupName, 'ServiceName, Present, 'TargetPlatform> =
            state.assignments.Add(fun config -> config.SourcePlatform <- value)
            ({ assignments = state.assignments } : DatabaseMigrationProjectState<'Location, 'Name, 'ResourceGroupName, 'ServiceName, Present, 'TargetPlatform>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/database_migration_project#target_platform-1">DatabaseMigrationProject#target_platform</a>.
        /// </summary>
        [<CustomOperation "target_platform">]
        member _.TargetPlatform(state: DatabaseMigrationProjectState<'Location, 'Name, 'ResourceGroupName, 'ServiceName, 'SourcePlatform, Missing>, value: string) : DatabaseMigrationProjectState<'Location, 'Name, 'ResourceGroupName, 'ServiceName, 'SourcePlatform, Present> =
            state.assignments.Add(fun config -> config.TargetPlatform <- value)
            ({ assignments = state.assignments } : DatabaseMigrationProjectState<'Location, 'Name, 'ResourceGroupName, 'ServiceName, 'SourcePlatform, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/database_migration_project#id-1">DatabaseMigrationProject#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DatabaseMigrationProjectState<'Location, 'Name, 'ResourceGroupName, 'ServiceName, 'SourcePlatform, 'TargetPlatform>, value: string) : DatabaseMigrationProjectState<'Location, 'Name, 'ResourceGroupName, 'ServiceName, 'SourcePlatform, 'TargetPlatform> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DatabaseMigrationProjectState<'Location, 'Name, 'ResourceGroupName, 'ServiceName, 'SourcePlatform, 'TargetPlatform>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/database_migration_project#tags-1">DatabaseMigrationProject#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DatabaseMigrationProjectState<'Location, 'Name, 'ResourceGroupName, 'ServiceName, 'SourcePlatform, 'TargetPlatform>, value: seq<string * string>) : DatabaseMigrationProjectState<'Location, 'Name, 'ResourceGroupName, 'ServiceName, 'SourcePlatform, 'TargetPlatform> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DatabaseMigrationProjectState<'Location, 'Name, 'ResourceGroupName, 'ServiceName, 'SourcePlatform, 'TargetPlatform>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/database_migration_project#timeouts-1">DatabaseMigrationProject#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DatabaseMigrationProjectState<'Location, 'Name, 'ResourceGroupName, 'ServiceName, 'SourcePlatform, 'TargetPlatform>, value: azurerm.DatabaseMigrationProject.DatabaseMigrationProjectTimeouts) : DatabaseMigrationProjectState<'Location, 'Name, 'ResourceGroupName, 'ServiceName, 'SourcePlatform, 'TargetPlatform> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DatabaseMigrationProjectState<'Location, 'Name, 'ResourceGroupName, 'ServiceName, 'SourcePlatform, 'TargetPlatform>

        member _.Run(state: DatabaseMigrationProjectState<Present, Present, Present, Present, Present, Present>) : azurerm.DatabaseMigrationProject.DatabaseMigrationProject =
            let config = azurerm.DatabaseMigrationProject.DatabaseMigrationProjectConfig()
            for setter in state.assignments do
                setter config
            azurerm.DatabaseMigrationProject.DatabaseMigrationProject(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.databaseMigrationProject: missing required arguments. Must call: location, name, resource_group_name, service_name, source_platform, target_platform.", 9999, IsError = true)>]
        member _.Run(_: DatabaseMigrationProjectState<_, _, _, _, _, _>) : azurerm.DatabaseMigrationProject.DatabaseMigrationProject =
            Unchecked.defaultof<azurerm.DatabaseMigrationProject.DatabaseMigrationProject>

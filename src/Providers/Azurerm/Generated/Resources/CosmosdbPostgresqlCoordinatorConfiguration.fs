namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CosmosdbPostgresqlCoordinatorConfigurationState<'ClusterId, 'Name, 'Value> = { assignments: ResizeArray<azurerm.CosmosdbPostgresqlCoordinatorConfiguration.CosmosdbPostgresqlCoordinatorConfigurationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_postgresql_coordinator_configuration">azurerm_cosmosdb_postgresql_coordinator_configuration</a>.
    /// </summary>
    type CosmosdbPostgresqlCoordinatorConfigurationBuilder(logicalId: string) =
        member _.Yield(_: unit) : CosmosdbPostgresqlCoordinatorConfigurationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CosmosdbPostgresqlCoordinatorConfigurationState<Missing, Missing, Missing>)

        member _.Zero(()) : CosmosdbPostgresqlCoordinatorConfigurationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CosmosdbPostgresqlCoordinatorConfigurationState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_postgresql_coordinator_configuration#cluster_id-1">CosmosdbPostgresqlCoordinatorConfiguration#cluster_id</a>.
        /// </summary>
        [<CustomOperation "cluster_id">]
        member _.ClusterId(state: CosmosdbPostgresqlCoordinatorConfigurationState<Missing, 'Name, 'Value>, value: string) : CosmosdbPostgresqlCoordinatorConfigurationState<Present, 'Name, 'Value> =
            state.assignments.Add(fun config -> config.ClusterId <- value)
            ({ assignments = state.assignments } : CosmosdbPostgresqlCoordinatorConfigurationState<Present, 'Name, 'Value>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_postgresql_coordinator_configuration#name-1">CosmosdbPostgresqlCoordinatorConfiguration#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: CosmosdbPostgresqlCoordinatorConfigurationState<'ClusterId, Missing, 'Value>, value: string) : CosmosdbPostgresqlCoordinatorConfigurationState<'ClusterId, Present, 'Value> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : CosmosdbPostgresqlCoordinatorConfigurationState<'ClusterId, Present, 'Value>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_postgresql_coordinator_configuration#value-1">CosmosdbPostgresqlCoordinatorConfiguration#value</a>.
        /// </summary>
        [<CustomOperation "value">]
        member _.Value(state: CosmosdbPostgresqlCoordinatorConfigurationState<'ClusterId, 'Name, Missing>, value: string) : CosmosdbPostgresqlCoordinatorConfigurationState<'ClusterId, 'Name, Present> =
            state.assignments.Add(fun config -> config.Value <- value)
            ({ assignments = state.assignments } : CosmosdbPostgresqlCoordinatorConfigurationState<'ClusterId, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_postgresql_coordinator_configuration#id-1">CosmosdbPostgresqlCoordinatorConfiguration#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CosmosdbPostgresqlCoordinatorConfigurationState<'ClusterId, 'Name, 'Value>, value: string) : CosmosdbPostgresqlCoordinatorConfigurationState<'ClusterId, 'Name, 'Value> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CosmosdbPostgresqlCoordinatorConfigurationState<'ClusterId, 'Name, 'Value>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_postgresql_coordinator_configuration#timeouts-1">CosmosdbPostgresqlCoordinatorConfiguration#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: CosmosdbPostgresqlCoordinatorConfigurationState<'ClusterId, 'Name, 'Value>, value: azurerm.CosmosdbPostgresqlCoordinatorConfiguration.CosmosdbPostgresqlCoordinatorConfigurationTimeouts) : CosmosdbPostgresqlCoordinatorConfigurationState<'ClusterId, 'Name, 'Value> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : CosmosdbPostgresqlCoordinatorConfigurationState<'ClusterId, 'Name, 'Value>

        member _.Run(state: CosmosdbPostgresqlCoordinatorConfigurationState<Present, Present, Present>) : azurerm.CosmosdbPostgresqlCoordinatorConfiguration.CosmosdbPostgresqlCoordinatorConfiguration =
            let config = azurerm.CosmosdbPostgresqlCoordinatorConfiguration.CosmosdbPostgresqlCoordinatorConfigurationConfig()
            for setter in state.assignments do
                setter config
            azurerm.CosmosdbPostgresqlCoordinatorConfiguration.CosmosdbPostgresqlCoordinatorConfiguration(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.cosmosdbPostgresqlCoordinatorConfiguration: missing required arguments. Must call: cluster_id, name, value.", 9999, IsError = true)>]
        member _.Run(_: CosmosdbPostgresqlCoordinatorConfigurationState<_, _, _>) : azurerm.CosmosdbPostgresqlCoordinatorConfiguration.CosmosdbPostgresqlCoordinatorConfiguration =
            Unchecked.defaultof<azurerm.CosmosdbPostgresqlCoordinatorConfiguration.CosmosdbPostgresqlCoordinatorConfiguration>

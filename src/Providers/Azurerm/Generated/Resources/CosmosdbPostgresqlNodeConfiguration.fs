namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CosmosdbPostgresqlNodeConfigurationState<'ClusterId, 'Name, 'Value> = { assignments: ResizeArray<azurerm.CosmosdbPostgresqlNodeConfiguration.CosmosdbPostgresqlNodeConfigurationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_postgresql_node_configuration">azurerm_cosmosdb_postgresql_node_configuration</a>.
    /// </summary>
    type CosmosdbPostgresqlNodeConfigurationBuilder(logicalId: string) =
        member _.Yield(_: unit) : CosmosdbPostgresqlNodeConfigurationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CosmosdbPostgresqlNodeConfigurationState<Missing, Missing, Missing>)

        member _.Zero(()) : CosmosdbPostgresqlNodeConfigurationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CosmosdbPostgresqlNodeConfigurationState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_postgresql_node_configuration#cluster_id-1">CosmosdbPostgresqlNodeConfiguration#cluster_id</a>.
        /// </summary>
        [<CustomOperation "cluster_id">]
        member _.ClusterId(state: CosmosdbPostgresqlNodeConfigurationState<Missing, 'Name, 'Value>, value: string) : CosmosdbPostgresqlNodeConfigurationState<Present, 'Name, 'Value> =
            state.assignments.Add(fun config -> config.ClusterId <- value)
            ({ assignments = state.assignments } : CosmosdbPostgresqlNodeConfigurationState<Present, 'Name, 'Value>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_postgresql_node_configuration#name-1">CosmosdbPostgresqlNodeConfiguration#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: CosmosdbPostgresqlNodeConfigurationState<'ClusterId, Missing, 'Value>, value: string) : CosmosdbPostgresqlNodeConfigurationState<'ClusterId, Present, 'Value> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : CosmosdbPostgresqlNodeConfigurationState<'ClusterId, Present, 'Value>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_postgresql_node_configuration#value-1">CosmosdbPostgresqlNodeConfiguration#value</a>.
        /// </summary>
        [<CustomOperation "value">]
        member _.Value(state: CosmosdbPostgresqlNodeConfigurationState<'ClusterId, 'Name, Missing>, value: string) : CosmosdbPostgresqlNodeConfigurationState<'ClusterId, 'Name, Present> =
            state.assignments.Add(fun config -> config.Value <- value)
            ({ assignments = state.assignments } : CosmosdbPostgresqlNodeConfigurationState<'ClusterId, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_postgresql_node_configuration#id-1">CosmosdbPostgresqlNodeConfiguration#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CosmosdbPostgresqlNodeConfigurationState<'ClusterId, 'Name, 'Value>, value: string) : CosmosdbPostgresqlNodeConfigurationState<'ClusterId, 'Name, 'Value> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CosmosdbPostgresqlNodeConfigurationState<'ClusterId, 'Name, 'Value>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_postgresql_node_configuration#timeouts-1">CosmosdbPostgresqlNodeConfiguration#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: CosmosdbPostgresqlNodeConfigurationState<'ClusterId, 'Name, 'Value>, value: azurerm.CosmosdbPostgresqlNodeConfiguration.CosmosdbPostgresqlNodeConfigurationTimeouts) : CosmosdbPostgresqlNodeConfigurationState<'ClusterId, 'Name, 'Value> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : CosmosdbPostgresqlNodeConfigurationState<'ClusterId, 'Name, 'Value>

        member _.Run(state: CosmosdbPostgresqlNodeConfigurationState<Present, Present, Present>) : azurerm.CosmosdbPostgresqlNodeConfiguration.CosmosdbPostgresqlNodeConfiguration =
            let config = azurerm.CosmosdbPostgresqlNodeConfiguration.CosmosdbPostgresqlNodeConfigurationConfig()
            for setter in state.assignments do
                setter config
            azurerm.CosmosdbPostgresqlNodeConfiguration.CosmosdbPostgresqlNodeConfiguration(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.cosmosdbPostgresqlNodeConfiguration: missing required arguments. Must call: cluster_id, name, value.", 9999, IsError = true)>]
        member _.Run(_: CosmosdbPostgresqlNodeConfigurationState<_, _, _>) : azurerm.CosmosdbPostgresqlNodeConfiguration.CosmosdbPostgresqlNodeConfiguration =
            Unchecked.defaultof<azurerm.CosmosdbPostgresqlNodeConfiguration.CosmosdbPostgresqlNodeConfiguration>

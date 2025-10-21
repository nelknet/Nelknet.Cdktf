namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type KustoCosmosdbDataConnectionState<'CosmosdbContainerId, 'KustoDatabaseId, 'Location, 'ManagedIdentityId, 'Name, 'TableName> = { assignments: ResizeArray<azurerm.KustoCosmosdbDataConnection.KustoCosmosdbDataConnectionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_cosmosdb_data_connection">azurerm_kusto_cosmosdb_data_connection</a>.
    /// </summary>
    type KustoCosmosdbDataConnectionBuilder(logicalId: string) =
        member _.Yield(_: unit) : KustoCosmosdbDataConnectionState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : KustoCosmosdbDataConnectionState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : KustoCosmosdbDataConnectionState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : KustoCosmosdbDataConnectionState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_cosmosdb_data_connection#cosmosdb_container_id-1">KustoCosmosdbDataConnection#cosmosdb_container_id</a>.
        /// </summary>
        [<CustomOperation "cosmosdb_container_id">]
        member _.CosmosdbContainerId(state: KustoCosmosdbDataConnectionState<Missing, 'KustoDatabaseId, 'Location, 'ManagedIdentityId, 'Name, 'TableName>, value: string) : KustoCosmosdbDataConnectionState<Present, 'KustoDatabaseId, 'Location, 'ManagedIdentityId, 'Name, 'TableName> =
            state.assignments.Add(fun config -> config.CosmosdbContainerId <- value)
            ({ assignments = state.assignments } : KustoCosmosdbDataConnectionState<Present, 'KustoDatabaseId, 'Location, 'ManagedIdentityId, 'Name, 'TableName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_cosmosdb_data_connection#kusto_database_id-1">KustoCosmosdbDataConnection#kusto_database_id</a>.
        /// </summary>
        [<CustomOperation "kusto_database_id">]
        member _.KustoDatabaseId(state: KustoCosmosdbDataConnectionState<'CosmosdbContainerId, Missing, 'Location, 'ManagedIdentityId, 'Name, 'TableName>, value: string) : KustoCosmosdbDataConnectionState<'CosmosdbContainerId, Present, 'Location, 'ManagedIdentityId, 'Name, 'TableName> =
            state.assignments.Add(fun config -> config.KustoDatabaseId <- value)
            ({ assignments = state.assignments } : KustoCosmosdbDataConnectionState<'CosmosdbContainerId, Present, 'Location, 'ManagedIdentityId, 'Name, 'TableName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_cosmosdb_data_connection#location-1">KustoCosmosdbDataConnection#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: KustoCosmosdbDataConnectionState<'CosmosdbContainerId, 'KustoDatabaseId, Missing, 'ManagedIdentityId, 'Name, 'TableName>, value: string) : KustoCosmosdbDataConnectionState<'CosmosdbContainerId, 'KustoDatabaseId, Present, 'ManagedIdentityId, 'Name, 'TableName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : KustoCosmosdbDataConnectionState<'CosmosdbContainerId, 'KustoDatabaseId, Present, 'ManagedIdentityId, 'Name, 'TableName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_cosmosdb_data_connection#managed_identity_id-1">KustoCosmosdbDataConnection#managed_identity_id</a>.
        /// </summary>
        [<CustomOperation "managed_identity_id">]
        member _.ManagedIdentityId(state: KustoCosmosdbDataConnectionState<'CosmosdbContainerId, 'KustoDatabaseId, 'Location, Missing, 'Name, 'TableName>, value: string) : KustoCosmosdbDataConnectionState<'CosmosdbContainerId, 'KustoDatabaseId, 'Location, Present, 'Name, 'TableName> =
            state.assignments.Add(fun config -> config.ManagedIdentityId <- value)
            ({ assignments = state.assignments } : KustoCosmosdbDataConnectionState<'CosmosdbContainerId, 'KustoDatabaseId, 'Location, Present, 'Name, 'TableName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_cosmosdb_data_connection#name-1">KustoCosmosdbDataConnection#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: KustoCosmosdbDataConnectionState<'CosmosdbContainerId, 'KustoDatabaseId, 'Location, 'ManagedIdentityId, Missing, 'TableName>, value: string) : KustoCosmosdbDataConnectionState<'CosmosdbContainerId, 'KustoDatabaseId, 'Location, 'ManagedIdentityId, Present, 'TableName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : KustoCosmosdbDataConnectionState<'CosmosdbContainerId, 'KustoDatabaseId, 'Location, 'ManagedIdentityId, Present, 'TableName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_cosmosdb_data_connection#table_name-1">KustoCosmosdbDataConnection#table_name</a>.
        /// </summary>
        [<CustomOperation "table_name">]
        member _.TableName(state: KustoCosmosdbDataConnectionState<'CosmosdbContainerId, 'KustoDatabaseId, 'Location, 'ManagedIdentityId, 'Name, Missing>, value: string) : KustoCosmosdbDataConnectionState<'CosmosdbContainerId, 'KustoDatabaseId, 'Location, 'ManagedIdentityId, 'Name, Present> =
            state.assignments.Add(fun config -> config.TableName <- value)
            ({ assignments = state.assignments } : KustoCosmosdbDataConnectionState<'CosmosdbContainerId, 'KustoDatabaseId, 'Location, 'ManagedIdentityId, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_cosmosdb_data_connection#id-1">KustoCosmosdbDataConnection#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: KustoCosmosdbDataConnectionState<'CosmosdbContainerId, 'KustoDatabaseId, 'Location, 'ManagedIdentityId, 'Name, 'TableName>, value: string) : KustoCosmosdbDataConnectionState<'CosmosdbContainerId, 'KustoDatabaseId, 'Location, 'ManagedIdentityId, 'Name, 'TableName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : KustoCosmosdbDataConnectionState<'CosmosdbContainerId, 'KustoDatabaseId, 'Location, 'ManagedIdentityId, 'Name, 'TableName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_cosmosdb_data_connection#mapping_rule_name-1">KustoCosmosdbDataConnection#mapping_rule_name</a>.
        /// </summary>
        [<CustomOperation "mapping_rule_name">]
        member _.MappingRuleName(state: KustoCosmosdbDataConnectionState<'CosmosdbContainerId, 'KustoDatabaseId, 'Location, 'ManagedIdentityId, 'Name, 'TableName>, value: string) : KustoCosmosdbDataConnectionState<'CosmosdbContainerId, 'KustoDatabaseId, 'Location, 'ManagedIdentityId, 'Name, 'TableName> =
            state.assignments.Add(fun config -> config.MappingRuleName <- value)
            state : KustoCosmosdbDataConnectionState<'CosmosdbContainerId, 'KustoDatabaseId, 'Location, 'ManagedIdentityId, 'Name, 'TableName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_cosmosdb_data_connection#retrieval_start_date-1">KustoCosmosdbDataConnection#retrieval_start_date</a>.
        /// </summary>
        [<CustomOperation "retrieval_start_date">]
        member _.RetrievalStartDate(state: KustoCosmosdbDataConnectionState<'CosmosdbContainerId, 'KustoDatabaseId, 'Location, 'ManagedIdentityId, 'Name, 'TableName>, value: string) : KustoCosmosdbDataConnectionState<'CosmosdbContainerId, 'KustoDatabaseId, 'Location, 'ManagedIdentityId, 'Name, 'TableName> =
            state.assignments.Add(fun config -> config.RetrievalStartDate <- value)
            state : KustoCosmosdbDataConnectionState<'CosmosdbContainerId, 'KustoDatabaseId, 'Location, 'ManagedIdentityId, 'Name, 'TableName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_cosmosdb_data_connection#timeouts-1">KustoCosmosdbDataConnection#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: KustoCosmosdbDataConnectionState<'CosmosdbContainerId, 'KustoDatabaseId, 'Location, 'ManagedIdentityId, 'Name, 'TableName>, value: azurerm.KustoCosmosdbDataConnection.KustoCosmosdbDataConnectionTimeouts) : KustoCosmosdbDataConnectionState<'CosmosdbContainerId, 'KustoDatabaseId, 'Location, 'ManagedIdentityId, 'Name, 'TableName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : KustoCosmosdbDataConnectionState<'CosmosdbContainerId, 'KustoDatabaseId, 'Location, 'ManagedIdentityId, 'Name, 'TableName>

        member _.Run(state: KustoCosmosdbDataConnectionState<Present, Present, Present, Present, Present, Present>) : azurerm.KustoCosmosdbDataConnection.KustoCosmosdbDataConnection =
            let config = azurerm.KustoCosmosdbDataConnection.KustoCosmosdbDataConnectionConfig()
            for setter in state.assignments do
                setter config
            azurerm.KustoCosmosdbDataConnection.KustoCosmosdbDataConnection(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.kustoCosmosdbDataConnection: missing required arguments. Must call: cosmosdb_container_id, kusto_database_id, location, managed_identity_id, name, table_name.", 9999, IsError = true)>]
        member _.Run(_: KustoCosmosdbDataConnectionState<_, _, _, _, _, _>) : azurerm.KustoCosmosdbDataConnection.KustoCosmosdbDataConnection =
            Unchecked.defaultof<azurerm.KustoCosmosdbDataConnection.KustoCosmosdbDataConnection>

namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type StreamAnalyticsOutputCosmosdbState<'ContainerName, 'CosmosdbAccountKey, 'CosmosdbSqlDatabaseId, 'Name, 'StreamAnalyticsJobId> = { assignments: ResizeArray<azurerm.StreamAnalyticsOutputCosmosdb.StreamAnalyticsOutputCosmosdbConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_cosmosdb">azurerm_stream_analytics_output_cosmosdb</a>.
    /// </summary>
    type StreamAnalyticsOutputCosmosdbBuilder(logicalId: string) =
        member _.Yield(_: unit) : StreamAnalyticsOutputCosmosdbState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : StreamAnalyticsOutputCosmosdbState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : StreamAnalyticsOutputCosmosdbState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : StreamAnalyticsOutputCosmosdbState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_cosmosdb#container_name-1">StreamAnalyticsOutputCosmosdb#container_name</a>.
        /// </summary>
        [<CustomOperation "container_name">]
        member _.ContainerName(state: StreamAnalyticsOutputCosmosdbState<Missing, 'CosmosdbAccountKey, 'CosmosdbSqlDatabaseId, 'Name, 'StreamAnalyticsJobId>, value: string) : StreamAnalyticsOutputCosmosdbState<Present, 'CosmosdbAccountKey, 'CosmosdbSqlDatabaseId, 'Name, 'StreamAnalyticsJobId> =
            state.assignments.Add(fun config -> config.ContainerName <- value)
            ({ assignments = state.assignments } : StreamAnalyticsOutputCosmosdbState<Present, 'CosmosdbAccountKey, 'CosmosdbSqlDatabaseId, 'Name, 'StreamAnalyticsJobId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_cosmosdb#cosmosdb_account_key-1">StreamAnalyticsOutputCosmosdb#cosmosdb_account_key</a>.
        /// </summary>
        [<CustomOperation "cosmosdb_account_key">]
        member _.CosmosdbAccountKey(state: StreamAnalyticsOutputCosmosdbState<'ContainerName, Missing, 'CosmosdbSqlDatabaseId, 'Name, 'StreamAnalyticsJobId>, value: string) : StreamAnalyticsOutputCosmosdbState<'ContainerName, Present, 'CosmosdbSqlDatabaseId, 'Name, 'StreamAnalyticsJobId> =
            state.assignments.Add(fun config -> config.CosmosdbAccountKey <- value)
            ({ assignments = state.assignments } : StreamAnalyticsOutputCosmosdbState<'ContainerName, Present, 'CosmosdbSqlDatabaseId, 'Name, 'StreamAnalyticsJobId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_cosmosdb#cosmosdb_sql_database_id-1">StreamAnalyticsOutputCosmosdb#cosmosdb_sql_database_id</a>.
        /// </summary>
        [<CustomOperation "cosmosdb_sql_database_id">]
        member _.CosmosdbSqlDatabaseId(state: StreamAnalyticsOutputCosmosdbState<'ContainerName, 'CosmosdbAccountKey, Missing, 'Name, 'StreamAnalyticsJobId>, value: string) : StreamAnalyticsOutputCosmosdbState<'ContainerName, 'CosmosdbAccountKey, Present, 'Name, 'StreamAnalyticsJobId> =
            state.assignments.Add(fun config -> config.CosmosdbSqlDatabaseId <- value)
            ({ assignments = state.assignments } : StreamAnalyticsOutputCosmosdbState<'ContainerName, 'CosmosdbAccountKey, Present, 'Name, 'StreamAnalyticsJobId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_cosmosdb#name-1">StreamAnalyticsOutputCosmosdb#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: StreamAnalyticsOutputCosmosdbState<'ContainerName, 'CosmosdbAccountKey, 'CosmosdbSqlDatabaseId, Missing, 'StreamAnalyticsJobId>, value: string) : StreamAnalyticsOutputCosmosdbState<'ContainerName, 'CosmosdbAccountKey, 'CosmosdbSqlDatabaseId, Present, 'StreamAnalyticsJobId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : StreamAnalyticsOutputCosmosdbState<'ContainerName, 'CosmosdbAccountKey, 'CosmosdbSqlDatabaseId, Present, 'StreamAnalyticsJobId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_cosmosdb#stream_analytics_job_id-1">StreamAnalyticsOutputCosmosdb#stream_analytics_job_id</a>.
        /// </summary>
        [<CustomOperation "stream_analytics_job_id">]
        member _.StreamAnalyticsJobId(state: StreamAnalyticsOutputCosmosdbState<'ContainerName, 'CosmosdbAccountKey, 'CosmosdbSqlDatabaseId, 'Name, Missing>, value: string) : StreamAnalyticsOutputCosmosdbState<'ContainerName, 'CosmosdbAccountKey, 'CosmosdbSqlDatabaseId, 'Name, Present> =
            state.assignments.Add(fun config -> config.StreamAnalyticsJobId <- value)
            ({ assignments = state.assignments } : StreamAnalyticsOutputCosmosdbState<'ContainerName, 'CosmosdbAccountKey, 'CosmosdbSqlDatabaseId, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_cosmosdb#document_id-1">StreamAnalyticsOutputCosmosdb#document_id</a>.
        /// </summary>
        [<CustomOperation "document_id">]
        member _.DocumentId(state: StreamAnalyticsOutputCosmosdbState<'ContainerName, 'CosmosdbAccountKey, 'CosmosdbSqlDatabaseId, 'Name, 'StreamAnalyticsJobId>, value: string) : StreamAnalyticsOutputCosmosdbState<'ContainerName, 'CosmosdbAccountKey, 'CosmosdbSqlDatabaseId, 'Name, 'StreamAnalyticsJobId> =
            state.assignments.Add(fun config -> config.DocumentId <- value)
            state : StreamAnalyticsOutputCosmosdbState<'ContainerName, 'CosmosdbAccountKey, 'CosmosdbSqlDatabaseId, 'Name, 'StreamAnalyticsJobId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_cosmosdb#id-1">StreamAnalyticsOutputCosmosdb#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: StreamAnalyticsOutputCosmosdbState<'ContainerName, 'CosmosdbAccountKey, 'CosmosdbSqlDatabaseId, 'Name, 'StreamAnalyticsJobId>, value: string) : StreamAnalyticsOutputCosmosdbState<'ContainerName, 'CosmosdbAccountKey, 'CosmosdbSqlDatabaseId, 'Name, 'StreamAnalyticsJobId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : StreamAnalyticsOutputCosmosdbState<'ContainerName, 'CosmosdbAccountKey, 'CosmosdbSqlDatabaseId, 'Name, 'StreamAnalyticsJobId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_cosmosdb#partition_key-1">StreamAnalyticsOutputCosmosdb#partition_key</a>.
        /// </summary>
        [<CustomOperation "partition_key">]
        member _.PartitionKey(state: StreamAnalyticsOutputCosmosdbState<'ContainerName, 'CosmosdbAccountKey, 'CosmosdbSqlDatabaseId, 'Name, 'StreamAnalyticsJobId>, value: string) : StreamAnalyticsOutputCosmosdbState<'ContainerName, 'CosmosdbAccountKey, 'CosmosdbSqlDatabaseId, 'Name, 'StreamAnalyticsJobId> =
            state.assignments.Add(fun config -> config.PartitionKey <- value)
            state : StreamAnalyticsOutputCosmosdbState<'ContainerName, 'CosmosdbAccountKey, 'CosmosdbSqlDatabaseId, 'Name, 'StreamAnalyticsJobId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_output_cosmosdb#timeouts-1">StreamAnalyticsOutputCosmosdb#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: StreamAnalyticsOutputCosmosdbState<'ContainerName, 'CosmosdbAccountKey, 'CosmosdbSqlDatabaseId, 'Name, 'StreamAnalyticsJobId>, value: azurerm.StreamAnalyticsOutputCosmosdb.StreamAnalyticsOutputCosmosdbTimeouts) : StreamAnalyticsOutputCosmosdbState<'ContainerName, 'CosmosdbAccountKey, 'CosmosdbSqlDatabaseId, 'Name, 'StreamAnalyticsJobId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : StreamAnalyticsOutputCosmosdbState<'ContainerName, 'CosmosdbAccountKey, 'CosmosdbSqlDatabaseId, 'Name, 'StreamAnalyticsJobId>

        member _.Run(state: StreamAnalyticsOutputCosmosdbState<Present, Present, Present, Present, Present>) : azurerm.StreamAnalyticsOutputCosmosdb.StreamAnalyticsOutputCosmosdb =
            let config = azurerm.StreamAnalyticsOutputCosmosdb.StreamAnalyticsOutputCosmosdbConfig()
            for setter in state.assignments do
                setter config
            azurerm.StreamAnalyticsOutputCosmosdb.StreamAnalyticsOutputCosmosdb(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.streamAnalyticsOutputCosmosdb: missing required arguments. Must call: container_name, cosmosdb_account_key, cosmosdb_sql_database_id, name, stream_analytics_job_id.", 9999, IsError = true)>]
        member _.Run(_: StreamAnalyticsOutputCosmosdbState<_, _, _, _, _>) : azurerm.StreamAnalyticsOutputCosmosdb.StreamAnalyticsOutputCosmosdb =
            Unchecked.defaultof<azurerm.StreamAnalyticsOutputCosmosdb.StreamAnalyticsOutputCosmosdb>

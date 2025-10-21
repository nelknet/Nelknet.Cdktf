namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CosmosdbCassandraTableState<'CassandraKeyspaceId, 'Name, 'Schema> = { assignments: ResizeArray<azurerm.CosmosdbCassandraTable.CosmosdbCassandraTableConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_cassandra_table">azurerm_cosmosdb_cassandra_table</a>.
    /// </summary>
    type CosmosdbCassandraTableBuilder(logicalId: string) =
        member _.Yield(_: unit) : CosmosdbCassandraTableState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CosmosdbCassandraTableState<Missing, Missing, Missing>)

        member _.Zero(()) : CosmosdbCassandraTableState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CosmosdbCassandraTableState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_cassandra_table#cassandra_keyspace_id-1">CosmosdbCassandraTable#cassandra_keyspace_id</a>.
        /// </summary>
        [<CustomOperation "cassandra_keyspace_id">]
        member _.CassandraKeyspaceId(state: CosmosdbCassandraTableState<Missing, 'Name, 'Schema>, value: string) : CosmosdbCassandraTableState<Present, 'Name, 'Schema> =
            state.assignments.Add(fun config -> config.CassandraKeyspaceId <- value)
            ({ assignments = state.assignments } : CosmosdbCassandraTableState<Present, 'Name, 'Schema>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_cassandra_table#name-1">CosmosdbCassandraTable#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: CosmosdbCassandraTableState<'CassandraKeyspaceId, Missing, 'Schema>, value: string) : CosmosdbCassandraTableState<'CassandraKeyspaceId, Present, 'Schema> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : CosmosdbCassandraTableState<'CassandraKeyspaceId, Present, 'Schema>)

        /// <summary>
        /// schema block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_cassandra_table#schema-1">CosmosdbCassandraTable#schema</a>
        /// </summary>
        [<CustomOperation "schema">]
        member _.Schema(state: CosmosdbCassandraTableState<'CassandraKeyspaceId, 'Name, Missing>, value: azurerm.CosmosdbCassandraTable.CosmosdbCassandraTableSchema) : CosmosdbCassandraTableState<'CassandraKeyspaceId, 'Name, Present> =
            state.assignments.Add(fun config -> config.Schema <- value)
            ({ assignments = state.assignments } : CosmosdbCassandraTableState<'CassandraKeyspaceId, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_cassandra_table#analytical_storage_ttl-1">CosmosdbCassandraTable#analytical_storage_ttl</a>.
        /// </summary>
        [<CustomOperation "analytical_storage_ttl">]
        member _.AnalyticalStorageTtl(state: CosmosdbCassandraTableState<'CassandraKeyspaceId, 'Name, 'Schema>, value: double) : CosmosdbCassandraTableState<'CassandraKeyspaceId, 'Name, 'Schema> =
            state.assignments.Add(fun config -> config.AnalyticalStorageTtl <- value)
            state : CosmosdbCassandraTableState<'CassandraKeyspaceId, 'Name, 'Schema>

        /// <summary>
        /// autoscale_settings block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_cassandra_table#autoscale_settings-1">CosmosdbCassandraTable#autoscale_settings</a>
        /// </summary>
        [<CustomOperation "autoscale_settings">]
        member _.AutoscaleSettings(state: CosmosdbCassandraTableState<'CassandraKeyspaceId, 'Name, 'Schema>, value: azurerm.CosmosdbCassandraTable.CosmosdbCassandraTableAutoscaleSettings) : CosmosdbCassandraTableState<'CassandraKeyspaceId, 'Name, 'Schema> =
            state.assignments.Add(fun config -> config.AutoscaleSettings <- value)
            state : CosmosdbCassandraTableState<'CassandraKeyspaceId, 'Name, 'Schema>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_cassandra_table#default_ttl-1">CosmosdbCassandraTable#default_ttl</a>.
        /// </summary>
        [<CustomOperation "default_ttl">]
        member _.DefaultTtl(state: CosmosdbCassandraTableState<'CassandraKeyspaceId, 'Name, 'Schema>, value: double) : CosmosdbCassandraTableState<'CassandraKeyspaceId, 'Name, 'Schema> =
            state.assignments.Add(fun config -> config.DefaultTtl <- value)
            state : CosmosdbCassandraTableState<'CassandraKeyspaceId, 'Name, 'Schema>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_cassandra_table#id-1">CosmosdbCassandraTable#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CosmosdbCassandraTableState<'CassandraKeyspaceId, 'Name, 'Schema>, value: string) : CosmosdbCassandraTableState<'CassandraKeyspaceId, 'Name, 'Schema> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CosmosdbCassandraTableState<'CassandraKeyspaceId, 'Name, 'Schema>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_cassandra_table#throughput-1">CosmosdbCassandraTable#throughput</a>.
        /// </summary>
        [<CustomOperation "throughput">]
        member _.Throughput(state: CosmosdbCassandraTableState<'CassandraKeyspaceId, 'Name, 'Schema>, value: double) : CosmosdbCassandraTableState<'CassandraKeyspaceId, 'Name, 'Schema> =
            state.assignments.Add(fun config -> config.Throughput <- value)
            state : CosmosdbCassandraTableState<'CassandraKeyspaceId, 'Name, 'Schema>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_cassandra_table#timeouts-1">CosmosdbCassandraTable#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: CosmosdbCassandraTableState<'CassandraKeyspaceId, 'Name, 'Schema>, value: azurerm.CosmosdbCassandraTable.CosmosdbCassandraTableTimeouts) : CosmosdbCassandraTableState<'CassandraKeyspaceId, 'Name, 'Schema> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : CosmosdbCassandraTableState<'CassandraKeyspaceId, 'Name, 'Schema>

        member _.Run(state: CosmosdbCassandraTableState<Present, Present, Present>) : azurerm.CosmosdbCassandraTable.CosmosdbCassandraTable =
            let config = azurerm.CosmosdbCassandraTable.CosmosdbCassandraTableConfig()
            for setter in state.assignments do
                setter config
            azurerm.CosmosdbCassandraTable.CosmosdbCassandraTable(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.cosmosdbCassandraTable: missing required arguments. Must call: cassandra_keyspace_id, name, schema.", 9999, IsError = true)>]
        member _.Run(_: CosmosdbCassandraTableState<_, _, _>) : azurerm.CosmosdbCassandraTable.CosmosdbCassandraTable =
            Unchecked.defaultof<azurerm.CosmosdbCassandraTable.CosmosdbCassandraTable>

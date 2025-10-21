namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SpringCloudAppCosmosdbAssociationState<'ApiType, 'CosmosdbAccessKey, 'CosmosdbAccountId, 'Name, 'SpringCloudAppId> = { assignments: ResizeArray<azurerm.SpringCloudAppCosmosdbAssociation.SpringCloudAppCosmosdbAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_app_cosmosdb_association">azurerm_spring_cloud_app_cosmosdb_association</a>.
    /// </summary>
    type SpringCloudAppCosmosdbAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : SpringCloudAppCosmosdbAssociationState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SpringCloudAppCosmosdbAssociationState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : SpringCloudAppCosmosdbAssociationState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SpringCloudAppCosmosdbAssociationState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_app_cosmosdb_association#api_type-1">SpringCloudAppCosmosdbAssociation#api_type</a>.
        /// </summary>
        [<CustomOperation "api_type">]
        member _.ApiType(state: SpringCloudAppCosmosdbAssociationState<Missing, 'CosmosdbAccessKey, 'CosmosdbAccountId, 'Name, 'SpringCloudAppId>, value: string) : SpringCloudAppCosmosdbAssociationState<Present, 'CosmosdbAccessKey, 'CosmosdbAccountId, 'Name, 'SpringCloudAppId> =
            state.assignments.Add(fun config -> config.ApiType <- value)
            ({ assignments = state.assignments } : SpringCloudAppCosmosdbAssociationState<Present, 'CosmosdbAccessKey, 'CosmosdbAccountId, 'Name, 'SpringCloudAppId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_app_cosmosdb_association#cosmosdb_access_key-1">SpringCloudAppCosmosdbAssociation#cosmosdb_access_key</a>.
        /// </summary>
        [<CustomOperation "cosmosdb_access_key">]
        member _.CosmosdbAccessKey(state: SpringCloudAppCosmosdbAssociationState<'ApiType, Missing, 'CosmosdbAccountId, 'Name, 'SpringCloudAppId>, value: string) : SpringCloudAppCosmosdbAssociationState<'ApiType, Present, 'CosmosdbAccountId, 'Name, 'SpringCloudAppId> =
            state.assignments.Add(fun config -> config.CosmosdbAccessKey <- value)
            ({ assignments = state.assignments } : SpringCloudAppCosmosdbAssociationState<'ApiType, Present, 'CosmosdbAccountId, 'Name, 'SpringCloudAppId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_app_cosmosdb_association#cosmosdb_account_id-1">SpringCloudAppCosmosdbAssociation#cosmosdb_account_id</a>.
        /// </summary>
        [<CustomOperation "cosmosdb_account_id">]
        member _.CosmosdbAccountId(state: SpringCloudAppCosmosdbAssociationState<'ApiType, 'CosmosdbAccessKey, Missing, 'Name, 'SpringCloudAppId>, value: string) : SpringCloudAppCosmosdbAssociationState<'ApiType, 'CosmosdbAccessKey, Present, 'Name, 'SpringCloudAppId> =
            state.assignments.Add(fun config -> config.CosmosdbAccountId <- value)
            ({ assignments = state.assignments } : SpringCloudAppCosmosdbAssociationState<'ApiType, 'CosmosdbAccessKey, Present, 'Name, 'SpringCloudAppId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_app_cosmosdb_association#name-1">SpringCloudAppCosmosdbAssociation#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SpringCloudAppCosmosdbAssociationState<'ApiType, 'CosmosdbAccessKey, 'CosmosdbAccountId, Missing, 'SpringCloudAppId>, value: string) : SpringCloudAppCosmosdbAssociationState<'ApiType, 'CosmosdbAccessKey, 'CosmosdbAccountId, Present, 'SpringCloudAppId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SpringCloudAppCosmosdbAssociationState<'ApiType, 'CosmosdbAccessKey, 'CosmosdbAccountId, Present, 'SpringCloudAppId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_app_cosmosdb_association#spring_cloud_app_id-1">SpringCloudAppCosmosdbAssociation#spring_cloud_app_id</a>.
        /// </summary>
        [<CustomOperation "spring_cloud_app_id">]
        member _.SpringCloudAppId(state: SpringCloudAppCosmosdbAssociationState<'ApiType, 'CosmosdbAccessKey, 'CosmosdbAccountId, 'Name, Missing>, value: string) : SpringCloudAppCosmosdbAssociationState<'ApiType, 'CosmosdbAccessKey, 'CosmosdbAccountId, 'Name, Present> =
            state.assignments.Add(fun config -> config.SpringCloudAppId <- value)
            ({ assignments = state.assignments } : SpringCloudAppCosmosdbAssociationState<'ApiType, 'CosmosdbAccessKey, 'CosmosdbAccountId, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_app_cosmosdb_association#cosmosdb_cassandra_keyspace_name-1">SpringCloudAppCosmosdbAssociation#cosmosdb_cassandra_keyspace_name</a>.
        /// </summary>
        [<CustomOperation "cosmosdb_cassandra_keyspace_name">]
        member _.CosmosdbCassandraKeyspaceName(state: SpringCloudAppCosmosdbAssociationState<'ApiType, 'CosmosdbAccessKey, 'CosmosdbAccountId, 'Name, 'SpringCloudAppId>, value: string) : SpringCloudAppCosmosdbAssociationState<'ApiType, 'CosmosdbAccessKey, 'CosmosdbAccountId, 'Name, 'SpringCloudAppId> =
            state.assignments.Add(fun config -> config.CosmosdbCassandraKeyspaceName <- value)
            state : SpringCloudAppCosmosdbAssociationState<'ApiType, 'CosmosdbAccessKey, 'CosmosdbAccountId, 'Name, 'SpringCloudAppId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_app_cosmosdb_association#cosmosdb_gremlin_database_name-1">SpringCloudAppCosmosdbAssociation#cosmosdb_gremlin_database_name</a>.
        /// </summary>
        [<CustomOperation "cosmosdb_gremlin_database_name">]
        member _.CosmosdbGremlinDatabaseName(state: SpringCloudAppCosmosdbAssociationState<'ApiType, 'CosmosdbAccessKey, 'CosmosdbAccountId, 'Name, 'SpringCloudAppId>, value: string) : SpringCloudAppCosmosdbAssociationState<'ApiType, 'CosmosdbAccessKey, 'CosmosdbAccountId, 'Name, 'SpringCloudAppId> =
            state.assignments.Add(fun config -> config.CosmosdbGremlinDatabaseName <- value)
            state : SpringCloudAppCosmosdbAssociationState<'ApiType, 'CosmosdbAccessKey, 'CosmosdbAccountId, 'Name, 'SpringCloudAppId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_app_cosmosdb_association#cosmosdb_gremlin_graph_name-1">SpringCloudAppCosmosdbAssociation#cosmosdb_gremlin_graph_name</a>.
        /// </summary>
        [<CustomOperation "cosmosdb_gremlin_graph_name">]
        member _.CosmosdbGremlinGraphName(state: SpringCloudAppCosmosdbAssociationState<'ApiType, 'CosmosdbAccessKey, 'CosmosdbAccountId, 'Name, 'SpringCloudAppId>, value: string) : SpringCloudAppCosmosdbAssociationState<'ApiType, 'CosmosdbAccessKey, 'CosmosdbAccountId, 'Name, 'SpringCloudAppId> =
            state.assignments.Add(fun config -> config.CosmosdbGremlinGraphName <- value)
            state : SpringCloudAppCosmosdbAssociationState<'ApiType, 'CosmosdbAccessKey, 'CosmosdbAccountId, 'Name, 'SpringCloudAppId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_app_cosmosdb_association#cosmosdb_mongo_database_name-1">SpringCloudAppCosmosdbAssociation#cosmosdb_mongo_database_name</a>.
        /// </summary>
        [<CustomOperation "cosmosdb_mongo_database_name">]
        member _.CosmosdbMongoDatabaseName(state: SpringCloudAppCosmosdbAssociationState<'ApiType, 'CosmosdbAccessKey, 'CosmosdbAccountId, 'Name, 'SpringCloudAppId>, value: string) : SpringCloudAppCosmosdbAssociationState<'ApiType, 'CosmosdbAccessKey, 'CosmosdbAccountId, 'Name, 'SpringCloudAppId> =
            state.assignments.Add(fun config -> config.CosmosdbMongoDatabaseName <- value)
            state : SpringCloudAppCosmosdbAssociationState<'ApiType, 'CosmosdbAccessKey, 'CosmosdbAccountId, 'Name, 'SpringCloudAppId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_app_cosmosdb_association#cosmosdb_sql_database_name-1">SpringCloudAppCosmosdbAssociation#cosmosdb_sql_database_name</a>.
        /// </summary>
        [<CustomOperation "cosmosdb_sql_database_name">]
        member _.CosmosdbSqlDatabaseName(state: SpringCloudAppCosmosdbAssociationState<'ApiType, 'CosmosdbAccessKey, 'CosmosdbAccountId, 'Name, 'SpringCloudAppId>, value: string) : SpringCloudAppCosmosdbAssociationState<'ApiType, 'CosmosdbAccessKey, 'CosmosdbAccountId, 'Name, 'SpringCloudAppId> =
            state.assignments.Add(fun config -> config.CosmosdbSqlDatabaseName <- value)
            state : SpringCloudAppCosmosdbAssociationState<'ApiType, 'CosmosdbAccessKey, 'CosmosdbAccountId, 'Name, 'SpringCloudAppId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_app_cosmosdb_association#id-1">SpringCloudAppCosmosdbAssociation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SpringCloudAppCosmosdbAssociationState<'ApiType, 'CosmosdbAccessKey, 'CosmosdbAccountId, 'Name, 'SpringCloudAppId>, value: string) : SpringCloudAppCosmosdbAssociationState<'ApiType, 'CosmosdbAccessKey, 'CosmosdbAccountId, 'Name, 'SpringCloudAppId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SpringCloudAppCosmosdbAssociationState<'ApiType, 'CosmosdbAccessKey, 'CosmosdbAccountId, 'Name, 'SpringCloudAppId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_app_cosmosdb_association#timeouts-1">SpringCloudAppCosmosdbAssociation#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SpringCloudAppCosmosdbAssociationState<'ApiType, 'CosmosdbAccessKey, 'CosmosdbAccountId, 'Name, 'SpringCloudAppId>, value: azurerm.SpringCloudAppCosmosdbAssociation.SpringCloudAppCosmosdbAssociationTimeouts) : SpringCloudAppCosmosdbAssociationState<'ApiType, 'CosmosdbAccessKey, 'CosmosdbAccountId, 'Name, 'SpringCloudAppId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SpringCloudAppCosmosdbAssociationState<'ApiType, 'CosmosdbAccessKey, 'CosmosdbAccountId, 'Name, 'SpringCloudAppId>

        member _.Run(state: SpringCloudAppCosmosdbAssociationState<Present, Present, Present, Present, Present>) : azurerm.SpringCloudAppCosmosdbAssociation.SpringCloudAppCosmosdbAssociation =
            let config = azurerm.SpringCloudAppCosmosdbAssociation.SpringCloudAppCosmosdbAssociationConfig()
            for setter in state.assignments do
                setter config
            azurerm.SpringCloudAppCosmosdbAssociation.SpringCloudAppCosmosdbAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.springCloudAppCosmosdbAssociation: missing required arguments. Must call: api_type, cosmosdb_access_key, cosmosdb_account_id, name, spring_cloud_app_id.", 9999, IsError = true)>]
        member _.Run(_: SpringCloudAppCosmosdbAssociationState<_, _, _, _, _>) : azurerm.SpringCloudAppCosmosdbAssociation.SpringCloudAppCosmosdbAssociation =
            Unchecked.defaultof<azurerm.SpringCloudAppCosmosdbAssociation.SpringCloudAppCosmosdbAssociation>

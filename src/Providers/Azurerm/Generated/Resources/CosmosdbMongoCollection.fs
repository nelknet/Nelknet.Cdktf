namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CosmosdbMongoCollectionState<'AccountName, 'DatabaseName, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.CosmosdbMongoCollection.CosmosdbMongoCollectionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_mongo_collection">azurerm_cosmosdb_mongo_collection</a>.
    /// </summary>
    type CosmosdbMongoCollectionBuilder(logicalId: string) =
        member _.Yield(_: unit) : CosmosdbMongoCollectionState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CosmosdbMongoCollectionState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : CosmosdbMongoCollectionState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CosmosdbMongoCollectionState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_mongo_collection#account_name-1">CosmosdbMongoCollection#account_name</a>.
        /// </summary>
        [<CustomOperation "account_name">]
        member _.AccountName(state: CosmosdbMongoCollectionState<Missing, 'DatabaseName, 'Name, 'ResourceGroupName>, value: string) : CosmosdbMongoCollectionState<Present, 'DatabaseName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AccountName <- value)
            ({ assignments = state.assignments } : CosmosdbMongoCollectionState<Present, 'DatabaseName, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_mongo_collection#database_name-1">CosmosdbMongoCollection#database_name</a>.
        /// </summary>
        [<CustomOperation "database_name">]
        member _.DatabaseName(state: CosmosdbMongoCollectionState<'AccountName, Missing, 'Name, 'ResourceGroupName>, value: string) : CosmosdbMongoCollectionState<'AccountName, Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DatabaseName <- value)
            ({ assignments = state.assignments } : CosmosdbMongoCollectionState<'AccountName, Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_mongo_collection#name-1">CosmosdbMongoCollection#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: CosmosdbMongoCollectionState<'AccountName, 'DatabaseName, Missing, 'ResourceGroupName>, value: string) : CosmosdbMongoCollectionState<'AccountName, 'DatabaseName, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : CosmosdbMongoCollectionState<'AccountName, 'DatabaseName, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_mongo_collection#resource_group_name-1">CosmosdbMongoCollection#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: CosmosdbMongoCollectionState<'AccountName, 'DatabaseName, 'Name, Missing>, value: string) : CosmosdbMongoCollectionState<'AccountName, 'DatabaseName, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : CosmosdbMongoCollectionState<'AccountName, 'DatabaseName, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_mongo_collection#analytical_storage_ttl-1">CosmosdbMongoCollection#analytical_storage_ttl</a>.
        /// </summary>
        [<CustomOperation "analytical_storage_ttl">]
        member _.AnalyticalStorageTtl(state: CosmosdbMongoCollectionState<'AccountName, 'DatabaseName, 'Name, 'ResourceGroupName>, value: double) : CosmosdbMongoCollectionState<'AccountName, 'DatabaseName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AnalyticalStorageTtl <- value)
            state : CosmosdbMongoCollectionState<'AccountName, 'DatabaseName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// autoscale_settings block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_mongo_collection#autoscale_settings-1">CosmosdbMongoCollection#autoscale_settings</a>
        /// </summary>
        [<CustomOperation "autoscale_settings">]
        member _.AutoscaleSettings(state: CosmosdbMongoCollectionState<'AccountName, 'DatabaseName, 'Name, 'ResourceGroupName>, value: azurerm.CosmosdbMongoCollection.CosmosdbMongoCollectionAutoscaleSettings) : CosmosdbMongoCollectionState<'AccountName, 'DatabaseName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AutoscaleSettings <- value)
            state : CosmosdbMongoCollectionState<'AccountName, 'DatabaseName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_mongo_collection#default_ttl_seconds-1">CosmosdbMongoCollection#default_ttl_seconds</a>.
        /// </summary>
        [<CustomOperation "default_ttl_seconds">]
        member _.DefaultTtlSeconds(state: CosmosdbMongoCollectionState<'AccountName, 'DatabaseName, 'Name, 'ResourceGroupName>, value: double) : CosmosdbMongoCollectionState<'AccountName, 'DatabaseName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DefaultTtlSeconds <- value)
            state : CosmosdbMongoCollectionState<'AccountName, 'DatabaseName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_mongo_collection#id-1">CosmosdbMongoCollection#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CosmosdbMongoCollectionState<'AccountName, 'DatabaseName, 'Name, 'ResourceGroupName>, value: string) : CosmosdbMongoCollectionState<'AccountName, 'DatabaseName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CosmosdbMongoCollectionState<'AccountName, 'DatabaseName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// index block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_mongo_collection#index-1">CosmosdbMongoCollection#index</a> Accepts: azurerm.IResolvable | azurerm.CosmosdbMongoCollection.CosmosdbMongoCollectionIndex[]
        /// </summary>
        [<CustomOperation "index">]
        member _.Index(state: CosmosdbMongoCollectionState<'AccountName, 'DatabaseName, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : CosmosdbMongoCollectionState<'AccountName, 'DatabaseName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Index <- value)
            state : CosmosdbMongoCollectionState<'AccountName, 'DatabaseName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_mongo_collection#shard_key-1">CosmosdbMongoCollection#shard_key</a>.
        /// </summary>
        [<CustomOperation "shard_key">]
        member _.ShardKey(state: CosmosdbMongoCollectionState<'AccountName, 'DatabaseName, 'Name, 'ResourceGroupName>, value: string) : CosmosdbMongoCollectionState<'AccountName, 'DatabaseName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ShardKey <- value)
            state : CosmosdbMongoCollectionState<'AccountName, 'DatabaseName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_mongo_collection#throughput-1">CosmosdbMongoCollection#throughput</a>.
        /// </summary>
        [<CustomOperation "throughput">]
        member _.Throughput(state: CosmosdbMongoCollectionState<'AccountName, 'DatabaseName, 'Name, 'ResourceGroupName>, value: double) : CosmosdbMongoCollectionState<'AccountName, 'DatabaseName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Throughput <- value)
            state : CosmosdbMongoCollectionState<'AccountName, 'DatabaseName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_mongo_collection#timeouts-1">CosmosdbMongoCollection#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: CosmosdbMongoCollectionState<'AccountName, 'DatabaseName, 'Name, 'ResourceGroupName>, value: azurerm.CosmosdbMongoCollection.CosmosdbMongoCollectionTimeouts) : CosmosdbMongoCollectionState<'AccountName, 'DatabaseName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : CosmosdbMongoCollectionState<'AccountName, 'DatabaseName, 'Name, 'ResourceGroupName>

        member _.Run(state: CosmosdbMongoCollectionState<Present, Present, Present, Present>) : azurerm.CosmosdbMongoCollection.CosmosdbMongoCollection =
            let config = azurerm.CosmosdbMongoCollection.CosmosdbMongoCollectionConfig()
            for setter in state.assignments do
                setter config
            azurerm.CosmosdbMongoCollection.CosmosdbMongoCollection(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.cosmosdbMongoCollection: missing required arguments. Must call: account_name, database_name, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: CosmosdbMongoCollectionState<_, _, _, _>) : azurerm.CosmosdbMongoCollection.CosmosdbMongoCollection =
            Unchecked.defaultof<azurerm.CosmosdbMongoCollection.CosmosdbMongoCollection>

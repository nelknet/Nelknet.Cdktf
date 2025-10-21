namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CosmosdbGremlinGraphState<'AccountName, 'DatabaseName, 'Name, 'PartitionKeyPath, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.CosmosdbGremlinGraph.CosmosdbGremlinGraphConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_gremlin_graph">azurerm_cosmosdb_gremlin_graph</a>.
    /// </summary>
    type CosmosdbGremlinGraphBuilder(logicalId: string) =
        member _.Yield(_: unit) : CosmosdbGremlinGraphState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CosmosdbGremlinGraphState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : CosmosdbGremlinGraphState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CosmosdbGremlinGraphState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_gremlin_graph#account_name-1">CosmosdbGremlinGraph#account_name</a>.
        /// </summary>
        [<CustomOperation "account_name">]
        member _.AccountName(state: CosmosdbGremlinGraphState<Missing, 'DatabaseName, 'Name, 'PartitionKeyPath, 'ResourceGroupName>, value: string) : CosmosdbGremlinGraphState<Present, 'DatabaseName, 'Name, 'PartitionKeyPath, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AccountName <- value)
            ({ assignments = state.assignments } : CosmosdbGremlinGraphState<Present, 'DatabaseName, 'Name, 'PartitionKeyPath, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_gremlin_graph#database_name-1">CosmosdbGremlinGraph#database_name</a>.
        /// </summary>
        [<CustomOperation "database_name">]
        member _.DatabaseName(state: CosmosdbGremlinGraphState<'AccountName, Missing, 'Name, 'PartitionKeyPath, 'ResourceGroupName>, value: string) : CosmosdbGremlinGraphState<'AccountName, Present, 'Name, 'PartitionKeyPath, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DatabaseName <- value)
            ({ assignments = state.assignments } : CosmosdbGremlinGraphState<'AccountName, Present, 'Name, 'PartitionKeyPath, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_gremlin_graph#name-1">CosmosdbGremlinGraph#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: CosmosdbGremlinGraphState<'AccountName, 'DatabaseName, Missing, 'PartitionKeyPath, 'ResourceGroupName>, value: string) : CosmosdbGremlinGraphState<'AccountName, 'DatabaseName, Present, 'PartitionKeyPath, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : CosmosdbGremlinGraphState<'AccountName, 'DatabaseName, Present, 'PartitionKeyPath, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_gremlin_graph#partition_key_path-1">CosmosdbGremlinGraph#partition_key_path</a>.
        /// </summary>
        [<CustomOperation "partition_key_path">]
        member _.PartitionKeyPath(state: CosmosdbGremlinGraphState<'AccountName, 'DatabaseName, 'Name, Missing, 'ResourceGroupName>, value: string) : CosmosdbGremlinGraphState<'AccountName, 'DatabaseName, 'Name, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.PartitionKeyPath <- value)
            ({ assignments = state.assignments } : CosmosdbGremlinGraphState<'AccountName, 'DatabaseName, 'Name, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_gremlin_graph#resource_group_name-1">CosmosdbGremlinGraph#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: CosmosdbGremlinGraphState<'AccountName, 'DatabaseName, 'Name, 'PartitionKeyPath, Missing>, value: string) : CosmosdbGremlinGraphState<'AccountName, 'DatabaseName, 'Name, 'PartitionKeyPath, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : CosmosdbGremlinGraphState<'AccountName, 'DatabaseName, 'Name, 'PartitionKeyPath, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_gremlin_graph#analytical_storage_ttl-1">CosmosdbGremlinGraph#analytical_storage_ttl</a>.
        /// </summary>
        [<CustomOperation "analytical_storage_ttl">]
        member _.AnalyticalStorageTtl(state: CosmosdbGremlinGraphState<'AccountName, 'DatabaseName, 'Name, 'PartitionKeyPath, 'ResourceGroupName>, value: double) : CosmosdbGremlinGraphState<'AccountName, 'DatabaseName, 'Name, 'PartitionKeyPath, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AnalyticalStorageTtl <- value)
            state : CosmosdbGremlinGraphState<'AccountName, 'DatabaseName, 'Name, 'PartitionKeyPath, 'ResourceGroupName>

        /// <summary>
        /// autoscale_settings block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_gremlin_graph#autoscale_settings-1">CosmosdbGremlinGraph#autoscale_settings</a>
        /// </summary>
        [<CustomOperation "autoscale_settings">]
        member _.AutoscaleSettings(state: CosmosdbGremlinGraphState<'AccountName, 'DatabaseName, 'Name, 'PartitionKeyPath, 'ResourceGroupName>, value: azurerm.CosmosdbGremlinGraph.CosmosdbGremlinGraphAutoscaleSettings) : CosmosdbGremlinGraphState<'AccountName, 'DatabaseName, 'Name, 'PartitionKeyPath, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AutoscaleSettings <- value)
            state : CosmosdbGremlinGraphState<'AccountName, 'DatabaseName, 'Name, 'PartitionKeyPath, 'ResourceGroupName>

        /// <summary>
        /// conflict_resolution_policy block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_gremlin_graph#conflict_resolution_policy-1">CosmosdbGremlinGraph#conflict_resolution_policy</a>
        /// </summary>
        [<CustomOperation "conflict_resolution_policy">]
        member _.ConflictResolutionPolicy(state: CosmosdbGremlinGraphState<'AccountName, 'DatabaseName, 'Name, 'PartitionKeyPath, 'ResourceGroupName>, value: azurerm.CosmosdbGremlinGraph.CosmosdbGremlinGraphConflictResolutionPolicy) : CosmosdbGremlinGraphState<'AccountName, 'DatabaseName, 'Name, 'PartitionKeyPath, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ConflictResolutionPolicy <- value)
            state : CosmosdbGremlinGraphState<'AccountName, 'DatabaseName, 'Name, 'PartitionKeyPath, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_gremlin_graph#default_ttl-1">CosmosdbGremlinGraph#default_ttl</a>.
        /// </summary>
        [<CustomOperation "default_ttl">]
        member _.DefaultTtl(state: CosmosdbGremlinGraphState<'AccountName, 'DatabaseName, 'Name, 'PartitionKeyPath, 'ResourceGroupName>, value: double) : CosmosdbGremlinGraphState<'AccountName, 'DatabaseName, 'Name, 'PartitionKeyPath, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DefaultTtl <- value)
            state : CosmosdbGremlinGraphState<'AccountName, 'DatabaseName, 'Name, 'PartitionKeyPath, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_gremlin_graph#id-1">CosmosdbGremlinGraph#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CosmosdbGremlinGraphState<'AccountName, 'DatabaseName, 'Name, 'PartitionKeyPath, 'ResourceGroupName>, value: string) : CosmosdbGremlinGraphState<'AccountName, 'DatabaseName, 'Name, 'PartitionKeyPath, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CosmosdbGremlinGraphState<'AccountName, 'DatabaseName, 'Name, 'PartitionKeyPath, 'ResourceGroupName>

        /// <summary>
        /// index_policy block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_gremlin_graph#index_policy-1">CosmosdbGremlinGraph#index_policy</a>
        /// </summary>
        [<CustomOperation "index_policy">]
        member _.IndexPolicy(state: CosmosdbGremlinGraphState<'AccountName, 'DatabaseName, 'Name, 'PartitionKeyPath, 'ResourceGroupName>, value: azurerm.CosmosdbGremlinGraph.CosmosdbGremlinGraphIndexPolicy) : CosmosdbGremlinGraphState<'AccountName, 'DatabaseName, 'Name, 'PartitionKeyPath, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.IndexPolicy <- value)
            state : CosmosdbGremlinGraphState<'AccountName, 'DatabaseName, 'Name, 'PartitionKeyPath, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_gremlin_graph#partition_key_version-1">CosmosdbGremlinGraph#partition_key_version</a>.
        /// </summary>
        [<CustomOperation "partition_key_version">]
        member _.PartitionKeyVersion(state: CosmosdbGremlinGraphState<'AccountName, 'DatabaseName, 'Name, 'PartitionKeyPath, 'ResourceGroupName>, value: double) : CosmosdbGremlinGraphState<'AccountName, 'DatabaseName, 'Name, 'PartitionKeyPath, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.PartitionKeyVersion <- value)
            state : CosmosdbGremlinGraphState<'AccountName, 'DatabaseName, 'Name, 'PartitionKeyPath, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_gremlin_graph#throughput-1">CosmosdbGremlinGraph#throughput</a>.
        /// </summary>
        [<CustomOperation "throughput">]
        member _.Throughput(state: CosmosdbGremlinGraphState<'AccountName, 'DatabaseName, 'Name, 'PartitionKeyPath, 'ResourceGroupName>, value: double) : CosmosdbGremlinGraphState<'AccountName, 'DatabaseName, 'Name, 'PartitionKeyPath, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Throughput <- value)
            state : CosmosdbGremlinGraphState<'AccountName, 'DatabaseName, 'Name, 'PartitionKeyPath, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_gremlin_graph#timeouts-1">CosmosdbGremlinGraph#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: CosmosdbGremlinGraphState<'AccountName, 'DatabaseName, 'Name, 'PartitionKeyPath, 'ResourceGroupName>, value: azurerm.CosmosdbGremlinGraph.CosmosdbGremlinGraphTimeouts) : CosmosdbGremlinGraphState<'AccountName, 'DatabaseName, 'Name, 'PartitionKeyPath, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : CosmosdbGremlinGraphState<'AccountName, 'DatabaseName, 'Name, 'PartitionKeyPath, 'ResourceGroupName>

        /// <summary>
        /// unique_key block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_gremlin_graph#unique_key-1">CosmosdbGremlinGraph#unique_key</a> Accepts: azurerm.IResolvable | azurerm.CosmosdbGremlinGraph.CosmosdbGremlinGraphUniqueKey[]
        /// </summary>
        [<CustomOperation "unique_key">]
        member _.UniqueKey(state: CosmosdbGremlinGraphState<'AccountName, 'DatabaseName, 'Name, 'PartitionKeyPath, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : CosmosdbGremlinGraphState<'AccountName, 'DatabaseName, 'Name, 'PartitionKeyPath, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.UniqueKey <- value)
            state : CosmosdbGremlinGraphState<'AccountName, 'DatabaseName, 'Name, 'PartitionKeyPath, 'ResourceGroupName>

        member _.Run(state: CosmosdbGremlinGraphState<Present, Present, Present, Present, Present>) : azurerm.CosmosdbGremlinGraph.CosmosdbGremlinGraph =
            let config = azurerm.CosmosdbGremlinGraph.CosmosdbGremlinGraphConfig()
            for setter in state.assignments do
                setter config
            azurerm.CosmosdbGremlinGraph.CosmosdbGremlinGraph(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.cosmosdbGremlinGraph: missing required arguments. Must call: account_name, database_name, name, partition_key_path, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: CosmosdbGremlinGraphState<_, _, _, _, _>) : azurerm.CosmosdbGremlinGraph.CosmosdbGremlinGraph =
            Unchecked.defaultof<azurerm.CosmosdbGremlinGraph.CosmosdbGremlinGraph>

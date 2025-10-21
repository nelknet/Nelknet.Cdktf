namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CosmosdbSqlContainerState<'AccountName, 'DatabaseName, 'Name, 'PartitionKeyPaths, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.CosmosdbSqlContainer.CosmosdbSqlContainerConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_sql_container">azurerm_cosmosdb_sql_container</a>.
    /// </summary>
    type CosmosdbSqlContainerBuilder(logicalId: string) =
        member _.Yield(_: unit) : CosmosdbSqlContainerState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CosmosdbSqlContainerState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : CosmosdbSqlContainerState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CosmosdbSqlContainerState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_sql_container#account_name-1">CosmosdbSqlContainer#account_name</a>.
        /// </summary>
        [<CustomOperation "account_name">]
        member _.AccountName(state: CosmosdbSqlContainerState<Missing, 'DatabaseName, 'Name, 'PartitionKeyPaths, 'ResourceGroupName>, value: string) : CosmosdbSqlContainerState<Present, 'DatabaseName, 'Name, 'PartitionKeyPaths, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AccountName <- value)
            ({ assignments = state.assignments } : CosmosdbSqlContainerState<Present, 'DatabaseName, 'Name, 'PartitionKeyPaths, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_sql_container#database_name-1">CosmosdbSqlContainer#database_name</a>.
        /// </summary>
        [<CustomOperation "database_name">]
        member _.DatabaseName(state: CosmosdbSqlContainerState<'AccountName, Missing, 'Name, 'PartitionKeyPaths, 'ResourceGroupName>, value: string) : CosmosdbSqlContainerState<'AccountName, Present, 'Name, 'PartitionKeyPaths, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DatabaseName <- value)
            ({ assignments = state.assignments } : CosmosdbSqlContainerState<'AccountName, Present, 'Name, 'PartitionKeyPaths, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_sql_container#name-1">CosmosdbSqlContainer#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: CosmosdbSqlContainerState<'AccountName, 'DatabaseName, Missing, 'PartitionKeyPaths, 'ResourceGroupName>, value: string) : CosmosdbSqlContainerState<'AccountName, 'DatabaseName, Present, 'PartitionKeyPaths, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : CosmosdbSqlContainerState<'AccountName, 'DatabaseName, Present, 'PartitionKeyPaths, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_sql_container#partition_key_paths-1">CosmosdbSqlContainer#partition_key_paths</a>.
        /// </summary>
        [<CustomOperation "partition_key_paths">]
        member _.PartitionKeyPaths(state: CosmosdbSqlContainerState<'AccountName, 'DatabaseName, 'Name, Missing, 'ResourceGroupName>, value: seq<string>) : CosmosdbSqlContainerState<'AccountName, 'DatabaseName, 'Name, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.PartitionKeyPaths <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : CosmosdbSqlContainerState<'AccountName, 'DatabaseName, 'Name, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_sql_container#resource_group_name-1">CosmosdbSqlContainer#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: CosmosdbSqlContainerState<'AccountName, 'DatabaseName, 'Name, 'PartitionKeyPaths, Missing>, value: string) : CosmosdbSqlContainerState<'AccountName, 'DatabaseName, 'Name, 'PartitionKeyPaths, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : CosmosdbSqlContainerState<'AccountName, 'DatabaseName, 'Name, 'PartitionKeyPaths, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_sql_container#analytical_storage_ttl-1">CosmosdbSqlContainer#analytical_storage_ttl</a>.
        /// </summary>
        [<CustomOperation "analytical_storage_ttl">]
        member _.AnalyticalStorageTtl(state: CosmosdbSqlContainerState<'AccountName, 'DatabaseName, 'Name, 'PartitionKeyPaths, 'ResourceGroupName>, value: double) : CosmosdbSqlContainerState<'AccountName, 'DatabaseName, 'Name, 'PartitionKeyPaths, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AnalyticalStorageTtl <- value)
            state : CosmosdbSqlContainerState<'AccountName, 'DatabaseName, 'Name, 'PartitionKeyPaths, 'ResourceGroupName>

        /// <summary>
        /// autoscale_settings block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_sql_container#autoscale_settings-1">CosmosdbSqlContainer#autoscale_settings</a>
        /// </summary>
        [<CustomOperation "autoscale_settings">]
        member _.AutoscaleSettings(state: CosmosdbSqlContainerState<'AccountName, 'DatabaseName, 'Name, 'PartitionKeyPaths, 'ResourceGroupName>, value: azurerm.CosmosdbSqlContainer.CosmosdbSqlContainerAutoscaleSettings) : CosmosdbSqlContainerState<'AccountName, 'DatabaseName, 'Name, 'PartitionKeyPaths, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AutoscaleSettings <- value)
            state : CosmosdbSqlContainerState<'AccountName, 'DatabaseName, 'Name, 'PartitionKeyPaths, 'ResourceGroupName>

        /// <summary>
        /// conflict_resolution_policy block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_sql_container#conflict_resolution_policy-1">CosmosdbSqlContainer#conflict_resolution_policy</a>
        /// </summary>
        [<CustomOperation "conflict_resolution_policy">]
        member _.ConflictResolutionPolicy(state: CosmosdbSqlContainerState<'AccountName, 'DatabaseName, 'Name, 'PartitionKeyPaths, 'ResourceGroupName>, value: azurerm.CosmosdbSqlContainer.CosmosdbSqlContainerConflictResolutionPolicy) : CosmosdbSqlContainerState<'AccountName, 'DatabaseName, 'Name, 'PartitionKeyPaths, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ConflictResolutionPolicy <- value)
            state : CosmosdbSqlContainerState<'AccountName, 'DatabaseName, 'Name, 'PartitionKeyPaths, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_sql_container#default_ttl-1">CosmosdbSqlContainer#default_ttl</a>.
        /// </summary>
        [<CustomOperation "default_ttl">]
        member _.DefaultTtl(state: CosmosdbSqlContainerState<'AccountName, 'DatabaseName, 'Name, 'PartitionKeyPaths, 'ResourceGroupName>, value: double) : CosmosdbSqlContainerState<'AccountName, 'DatabaseName, 'Name, 'PartitionKeyPaths, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DefaultTtl <- value)
            state : CosmosdbSqlContainerState<'AccountName, 'DatabaseName, 'Name, 'PartitionKeyPaths, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_sql_container#id-1">CosmosdbSqlContainer#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CosmosdbSqlContainerState<'AccountName, 'DatabaseName, 'Name, 'PartitionKeyPaths, 'ResourceGroupName>, value: string) : CosmosdbSqlContainerState<'AccountName, 'DatabaseName, 'Name, 'PartitionKeyPaths, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CosmosdbSqlContainerState<'AccountName, 'DatabaseName, 'Name, 'PartitionKeyPaths, 'ResourceGroupName>

        /// <summary>
        /// indexing_policy block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_sql_container#indexing_policy-1">CosmosdbSqlContainer#indexing_policy</a>
        /// </summary>
        [<CustomOperation "indexing_policy">]
        member _.IndexingPolicy(state: CosmosdbSqlContainerState<'AccountName, 'DatabaseName, 'Name, 'PartitionKeyPaths, 'ResourceGroupName>, value: azurerm.CosmosdbSqlContainer.CosmosdbSqlContainerIndexingPolicy) : CosmosdbSqlContainerState<'AccountName, 'DatabaseName, 'Name, 'PartitionKeyPaths, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.IndexingPolicy <- value)
            state : CosmosdbSqlContainerState<'AccountName, 'DatabaseName, 'Name, 'PartitionKeyPaths, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_sql_container#partition_key_kind-1">CosmosdbSqlContainer#partition_key_kind</a>.
        /// </summary>
        [<CustomOperation "partition_key_kind">]
        member _.PartitionKeyKind(state: CosmosdbSqlContainerState<'AccountName, 'DatabaseName, 'Name, 'PartitionKeyPaths, 'ResourceGroupName>, value: string) : CosmosdbSqlContainerState<'AccountName, 'DatabaseName, 'Name, 'PartitionKeyPaths, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.PartitionKeyKind <- value)
            state : CosmosdbSqlContainerState<'AccountName, 'DatabaseName, 'Name, 'PartitionKeyPaths, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_sql_container#partition_key_version-1">CosmosdbSqlContainer#partition_key_version</a>.
        /// </summary>
        [<CustomOperation "partition_key_version">]
        member _.PartitionKeyVersion(state: CosmosdbSqlContainerState<'AccountName, 'DatabaseName, 'Name, 'PartitionKeyPaths, 'ResourceGroupName>, value: double) : CosmosdbSqlContainerState<'AccountName, 'DatabaseName, 'Name, 'PartitionKeyPaths, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.PartitionKeyVersion <- value)
            state : CosmosdbSqlContainerState<'AccountName, 'DatabaseName, 'Name, 'PartitionKeyPaths, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_sql_container#throughput-1">CosmosdbSqlContainer#throughput</a>.
        /// </summary>
        [<CustomOperation "throughput">]
        member _.Throughput(state: CosmosdbSqlContainerState<'AccountName, 'DatabaseName, 'Name, 'PartitionKeyPaths, 'ResourceGroupName>, value: double) : CosmosdbSqlContainerState<'AccountName, 'DatabaseName, 'Name, 'PartitionKeyPaths, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Throughput <- value)
            state : CosmosdbSqlContainerState<'AccountName, 'DatabaseName, 'Name, 'PartitionKeyPaths, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_sql_container#timeouts-1">CosmosdbSqlContainer#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: CosmosdbSqlContainerState<'AccountName, 'DatabaseName, 'Name, 'PartitionKeyPaths, 'ResourceGroupName>, value: azurerm.CosmosdbSqlContainer.CosmosdbSqlContainerTimeouts) : CosmosdbSqlContainerState<'AccountName, 'DatabaseName, 'Name, 'PartitionKeyPaths, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : CosmosdbSqlContainerState<'AccountName, 'DatabaseName, 'Name, 'PartitionKeyPaths, 'ResourceGroupName>

        /// <summary>
        /// unique_key block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_sql_container#unique_key-1">CosmosdbSqlContainer#unique_key</a> Accepts: azurerm.IResolvable | azurerm.CosmosdbSqlContainer.CosmosdbSqlContainerUniqueKey[]
        /// </summary>
        [<CustomOperation "unique_key">]
        member _.UniqueKey(state: CosmosdbSqlContainerState<'AccountName, 'DatabaseName, 'Name, 'PartitionKeyPaths, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : CosmosdbSqlContainerState<'AccountName, 'DatabaseName, 'Name, 'PartitionKeyPaths, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.UniqueKey <- value)
            state : CosmosdbSqlContainerState<'AccountName, 'DatabaseName, 'Name, 'PartitionKeyPaths, 'ResourceGroupName>

        member _.Run(state: CosmosdbSqlContainerState<Present, Present, Present, Present, Present>) : azurerm.CosmosdbSqlContainer.CosmosdbSqlContainer =
            let config = azurerm.CosmosdbSqlContainer.CosmosdbSqlContainerConfig()
            for setter in state.assignments do
                setter config
            azurerm.CosmosdbSqlContainer.CosmosdbSqlContainer(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.cosmosdbSqlContainer: missing required arguments. Must call: account_name, database_name, name, partition_key_paths, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: CosmosdbSqlContainerState<_, _, _, _, _>) : azurerm.CosmosdbSqlContainer.CosmosdbSqlContainer =
            Unchecked.defaultof<azurerm.CosmosdbSqlContainer.CosmosdbSqlContainer>

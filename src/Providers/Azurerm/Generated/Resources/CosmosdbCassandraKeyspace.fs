namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CosmosdbCassandraKeyspaceState<'AccountName, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.CosmosdbCassandraKeyspace.CosmosdbCassandraKeyspaceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_cassandra_keyspace">azurerm_cosmosdb_cassandra_keyspace</a>.
    /// </summary>
    type CosmosdbCassandraKeyspaceBuilder(logicalId: string) =
        member _.Yield(_: unit) : CosmosdbCassandraKeyspaceState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CosmosdbCassandraKeyspaceState<Missing, Missing, Missing>)

        member _.Zero(()) : CosmosdbCassandraKeyspaceState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CosmosdbCassandraKeyspaceState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_cassandra_keyspace#account_name-1">CosmosdbCassandraKeyspace#account_name</a>.
        /// </summary>
        [<CustomOperation "account_name">]
        member _.AccountName(state: CosmosdbCassandraKeyspaceState<Missing, 'Name, 'ResourceGroupName>, value: string) : CosmosdbCassandraKeyspaceState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AccountName <- value)
            ({ assignments = state.assignments } : CosmosdbCassandraKeyspaceState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_cassandra_keyspace#name-1">CosmosdbCassandraKeyspace#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: CosmosdbCassandraKeyspaceState<'AccountName, Missing, 'ResourceGroupName>, value: string) : CosmosdbCassandraKeyspaceState<'AccountName, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : CosmosdbCassandraKeyspaceState<'AccountName, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_cassandra_keyspace#resource_group_name-1">CosmosdbCassandraKeyspace#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: CosmosdbCassandraKeyspaceState<'AccountName, 'Name, Missing>, value: string) : CosmosdbCassandraKeyspaceState<'AccountName, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : CosmosdbCassandraKeyspaceState<'AccountName, 'Name, Present>)

        /// <summary>
        /// autoscale_settings block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_cassandra_keyspace#autoscale_settings-1">CosmosdbCassandraKeyspace#autoscale_settings</a>
        /// </summary>
        [<CustomOperation "autoscale_settings">]
        member _.AutoscaleSettings(state: CosmosdbCassandraKeyspaceState<'AccountName, 'Name, 'ResourceGroupName>, value: azurerm.CosmosdbCassandraKeyspace.CosmosdbCassandraKeyspaceAutoscaleSettings) : CosmosdbCassandraKeyspaceState<'AccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AutoscaleSettings <- value)
            state : CosmosdbCassandraKeyspaceState<'AccountName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_cassandra_keyspace#id-1">CosmosdbCassandraKeyspace#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CosmosdbCassandraKeyspaceState<'AccountName, 'Name, 'ResourceGroupName>, value: string) : CosmosdbCassandraKeyspaceState<'AccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CosmosdbCassandraKeyspaceState<'AccountName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_cassandra_keyspace#throughput-1">CosmosdbCassandraKeyspace#throughput</a>.
        /// </summary>
        [<CustomOperation "throughput">]
        member _.Throughput(state: CosmosdbCassandraKeyspaceState<'AccountName, 'Name, 'ResourceGroupName>, value: double) : CosmosdbCassandraKeyspaceState<'AccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Throughput <- value)
            state : CosmosdbCassandraKeyspaceState<'AccountName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_cassandra_keyspace#timeouts-1">CosmosdbCassandraKeyspace#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: CosmosdbCassandraKeyspaceState<'AccountName, 'Name, 'ResourceGroupName>, value: azurerm.CosmosdbCassandraKeyspace.CosmosdbCassandraKeyspaceTimeouts) : CosmosdbCassandraKeyspaceState<'AccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : CosmosdbCassandraKeyspaceState<'AccountName, 'Name, 'ResourceGroupName>

        member _.Run(state: CosmosdbCassandraKeyspaceState<Present, Present, Present>) : azurerm.CosmosdbCassandraKeyspace.CosmosdbCassandraKeyspace =
            let config = azurerm.CosmosdbCassandraKeyspace.CosmosdbCassandraKeyspaceConfig()
            for setter in state.assignments do
                setter config
            azurerm.CosmosdbCassandraKeyspace.CosmosdbCassandraKeyspace(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.cosmosdbCassandraKeyspace: missing required arguments. Must call: account_name, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: CosmosdbCassandraKeyspaceState<_, _, _>) : azurerm.CosmosdbCassandraKeyspace.CosmosdbCassandraKeyspace =
            Unchecked.defaultof<azurerm.CosmosdbCassandraKeyspace.CosmosdbCassandraKeyspace>

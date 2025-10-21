namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CosmosdbGremlinDatabaseState<'AccountName, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.CosmosdbGremlinDatabase.CosmosdbGremlinDatabaseConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_gremlin_database">azurerm_cosmosdb_gremlin_database</a>.
    /// </summary>
    type CosmosdbGremlinDatabaseBuilder(logicalId: string) =
        member _.Yield(_: unit) : CosmosdbGremlinDatabaseState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CosmosdbGremlinDatabaseState<Missing, Missing, Missing>)

        member _.Zero(()) : CosmosdbGremlinDatabaseState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CosmosdbGremlinDatabaseState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_gremlin_database#account_name-1">CosmosdbGremlinDatabase#account_name</a>.
        /// </summary>
        [<CustomOperation "account_name">]
        member _.AccountName(state: CosmosdbGremlinDatabaseState<Missing, 'Name, 'ResourceGroupName>, value: string) : CosmosdbGremlinDatabaseState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AccountName <- value)
            ({ assignments = state.assignments } : CosmosdbGremlinDatabaseState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_gremlin_database#name-1">CosmosdbGremlinDatabase#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: CosmosdbGremlinDatabaseState<'AccountName, Missing, 'ResourceGroupName>, value: string) : CosmosdbGremlinDatabaseState<'AccountName, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : CosmosdbGremlinDatabaseState<'AccountName, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_gremlin_database#resource_group_name-1">CosmosdbGremlinDatabase#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: CosmosdbGremlinDatabaseState<'AccountName, 'Name, Missing>, value: string) : CosmosdbGremlinDatabaseState<'AccountName, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : CosmosdbGremlinDatabaseState<'AccountName, 'Name, Present>)

        /// <summary>
        /// autoscale_settings block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_gremlin_database#autoscale_settings-1">CosmosdbGremlinDatabase#autoscale_settings</a>
        /// </summary>
        [<CustomOperation "autoscale_settings">]
        member _.AutoscaleSettings(state: CosmosdbGremlinDatabaseState<'AccountName, 'Name, 'ResourceGroupName>, value: azurerm.CosmosdbGremlinDatabase.CosmosdbGremlinDatabaseAutoscaleSettings) : CosmosdbGremlinDatabaseState<'AccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AutoscaleSettings <- value)
            state : CosmosdbGremlinDatabaseState<'AccountName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_gremlin_database#id-1">CosmosdbGremlinDatabase#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CosmosdbGremlinDatabaseState<'AccountName, 'Name, 'ResourceGroupName>, value: string) : CosmosdbGremlinDatabaseState<'AccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CosmosdbGremlinDatabaseState<'AccountName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_gremlin_database#throughput-1">CosmosdbGremlinDatabase#throughput</a>.
        /// </summary>
        [<CustomOperation "throughput">]
        member _.Throughput(state: CosmosdbGremlinDatabaseState<'AccountName, 'Name, 'ResourceGroupName>, value: double) : CosmosdbGremlinDatabaseState<'AccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Throughput <- value)
            state : CosmosdbGremlinDatabaseState<'AccountName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_gremlin_database#timeouts-1">CosmosdbGremlinDatabase#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: CosmosdbGremlinDatabaseState<'AccountName, 'Name, 'ResourceGroupName>, value: azurerm.CosmosdbGremlinDatabase.CosmosdbGremlinDatabaseTimeouts) : CosmosdbGremlinDatabaseState<'AccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : CosmosdbGremlinDatabaseState<'AccountName, 'Name, 'ResourceGroupName>

        member _.Run(state: CosmosdbGremlinDatabaseState<Present, Present, Present>) : azurerm.CosmosdbGremlinDatabase.CosmosdbGremlinDatabase =
            let config = azurerm.CosmosdbGremlinDatabase.CosmosdbGremlinDatabaseConfig()
            for setter in state.assignments do
                setter config
            azurerm.CosmosdbGremlinDatabase.CosmosdbGremlinDatabase(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.cosmosdbGremlinDatabase: missing required arguments. Must call: account_name, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: CosmosdbGremlinDatabaseState<_, _, _>) : azurerm.CosmosdbGremlinDatabase.CosmosdbGremlinDatabase =
            Unchecked.defaultof<azurerm.CosmosdbGremlinDatabase.CosmosdbGremlinDatabase>

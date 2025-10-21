namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CosmosdbSqlDatabaseState<'AccountName, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.CosmosdbSqlDatabase.CosmosdbSqlDatabaseConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_sql_database">azurerm_cosmosdb_sql_database</a>.
    /// </summary>
    type CosmosdbSqlDatabaseBuilder(logicalId: string) =
        member _.Yield(_: unit) : CosmosdbSqlDatabaseState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CosmosdbSqlDatabaseState<Missing, Missing, Missing>)

        member _.Zero(()) : CosmosdbSqlDatabaseState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CosmosdbSqlDatabaseState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_sql_database#account_name-1">CosmosdbSqlDatabase#account_name</a>.
        /// </summary>
        [<CustomOperation "account_name">]
        member _.AccountName(state: CosmosdbSqlDatabaseState<Missing, 'Name, 'ResourceGroupName>, value: string) : CosmosdbSqlDatabaseState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AccountName <- value)
            ({ assignments = state.assignments } : CosmosdbSqlDatabaseState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_sql_database#name-1">CosmosdbSqlDatabase#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: CosmosdbSqlDatabaseState<'AccountName, Missing, 'ResourceGroupName>, value: string) : CosmosdbSqlDatabaseState<'AccountName, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : CosmosdbSqlDatabaseState<'AccountName, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_sql_database#resource_group_name-1">CosmosdbSqlDatabase#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: CosmosdbSqlDatabaseState<'AccountName, 'Name, Missing>, value: string) : CosmosdbSqlDatabaseState<'AccountName, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : CosmosdbSqlDatabaseState<'AccountName, 'Name, Present>)

        /// <summary>
        /// autoscale_settings block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_sql_database#autoscale_settings-1">CosmosdbSqlDatabase#autoscale_settings</a>
        /// </summary>
        [<CustomOperation "autoscale_settings">]
        member _.AutoscaleSettings(state: CosmosdbSqlDatabaseState<'AccountName, 'Name, 'ResourceGroupName>, value: azurerm.CosmosdbSqlDatabase.CosmosdbSqlDatabaseAutoscaleSettings) : CosmosdbSqlDatabaseState<'AccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AutoscaleSettings <- value)
            state : CosmosdbSqlDatabaseState<'AccountName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_sql_database#id-1">CosmosdbSqlDatabase#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CosmosdbSqlDatabaseState<'AccountName, 'Name, 'ResourceGroupName>, value: string) : CosmosdbSqlDatabaseState<'AccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CosmosdbSqlDatabaseState<'AccountName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_sql_database#throughput-1">CosmosdbSqlDatabase#throughput</a>.
        /// </summary>
        [<CustomOperation "throughput">]
        member _.Throughput(state: CosmosdbSqlDatabaseState<'AccountName, 'Name, 'ResourceGroupName>, value: double) : CosmosdbSqlDatabaseState<'AccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Throughput <- value)
            state : CosmosdbSqlDatabaseState<'AccountName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_sql_database#timeouts-1">CosmosdbSqlDatabase#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: CosmosdbSqlDatabaseState<'AccountName, 'Name, 'ResourceGroupName>, value: azurerm.CosmosdbSqlDatabase.CosmosdbSqlDatabaseTimeouts) : CosmosdbSqlDatabaseState<'AccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : CosmosdbSqlDatabaseState<'AccountName, 'Name, 'ResourceGroupName>

        member _.Run(state: CosmosdbSqlDatabaseState<Present, Present, Present>) : azurerm.CosmosdbSqlDatabase.CosmosdbSqlDatabase =
            let config = azurerm.CosmosdbSqlDatabase.CosmosdbSqlDatabaseConfig()
            for setter in state.assignments do
                setter config
            azurerm.CosmosdbSqlDatabase.CosmosdbSqlDatabase(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.cosmosdbSqlDatabase: missing required arguments. Must call: account_name, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: CosmosdbSqlDatabaseState<_, _, _>) : azurerm.CosmosdbSqlDatabase.CosmosdbSqlDatabase =
            Unchecked.defaultof<azurerm.CosmosdbSqlDatabase.CosmosdbSqlDatabase>

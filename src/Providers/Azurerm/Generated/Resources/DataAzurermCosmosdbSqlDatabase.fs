namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermCosmosdbSqlDatabaseState<'AccountName, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermCosmosdbSqlDatabase.DataAzurermCosmosdbSqlDatabaseConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cosmosdb_sql_database">azurerm_cosmosdb_sql_database</a>.
    /// </summary>
    type DataAzurermCosmosdbSqlDatabaseBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermCosmosdbSqlDatabaseState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermCosmosdbSqlDatabaseState<Missing, Missing, Missing>)

        member _.Zero(()) : DataAzurermCosmosdbSqlDatabaseState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermCosmosdbSqlDatabaseState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cosmosdb_sql_database#account_name-1">DataAzurermCosmosdbSqlDatabase#account_name</a>.
        /// </summary>
        [<CustomOperation "account_name">]
        member _.AccountName(state: DataAzurermCosmosdbSqlDatabaseState<Missing, 'Name, 'ResourceGroupName>, value: string) : DataAzurermCosmosdbSqlDatabaseState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AccountName <- value)
            ({ assignments = state.assignments } : DataAzurermCosmosdbSqlDatabaseState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cosmosdb_sql_database#name-1">DataAzurermCosmosdbSqlDatabase#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermCosmosdbSqlDatabaseState<'AccountName, Missing, 'ResourceGroupName>, value: string) : DataAzurermCosmosdbSqlDatabaseState<'AccountName, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermCosmosdbSqlDatabaseState<'AccountName, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cosmosdb_sql_database#resource_group_name-1">DataAzurermCosmosdbSqlDatabase#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermCosmosdbSqlDatabaseState<'AccountName, 'Name, Missing>, value: string) : DataAzurermCosmosdbSqlDatabaseState<'AccountName, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermCosmosdbSqlDatabaseState<'AccountName, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cosmosdb_sql_database#id-1">DataAzurermCosmosdbSqlDatabase#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermCosmosdbSqlDatabaseState<'AccountName, 'Name, 'ResourceGroupName>, value: string) : DataAzurermCosmosdbSqlDatabaseState<'AccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermCosmosdbSqlDatabaseState<'AccountName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cosmosdb_sql_database#timeouts-1">DataAzurermCosmosdbSqlDatabase#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermCosmosdbSqlDatabaseState<'AccountName, 'Name, 'ResourceGroupName>, value: azurerm.DataAzurermCosmosdbSqlDatabase.DataAzurermCosmosdbSqlDatabaseTimeouts) : DataAzurermCosmosdbSqlDatabaseState<'AccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermCosmosdbSqlDatabaseState<'AccountName, 'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermCosmosdbSqlDatabaseState<Present, Present, Present>) : azurerm.DataAzurermCosmosdbSqlDatabase.DataAzurermCosmosdbSqlDatabase =
            let config = azurerm.DataAzurermCosmosdbSqlDatabase.DataAzurermCosmosdbSqlDatabaseConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermCosmosdbSqlDatabase.DataAzurermCosmosdbSqlDatabase(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermCosmosdbSqlDatabase: missing required arguments. Must call: account_name, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermCosmosdbSqlDatabaseState<_, _, _>) : azurerm.DataAzurermCosmosdbSqlDatabase.DataAzurermCosmosdbSqlDatabase =
            Unchecked.defaultof<azurerm.DataAzurermCosmosdbSqlDatabase.DataAzurermCosmosdbSqlDatabase>

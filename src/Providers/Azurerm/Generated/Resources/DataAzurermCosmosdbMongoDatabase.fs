namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermCosmosdbMongoDatabaseState<'AccountName, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermCosmosdbMongoDatabase.DataAzurermCosmosdbMongoDatabaseConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cosmosdb_mongo_database">azurerm_cosmosdb_mongo_database</a>.
    /// </summary>
    type DataAzurermCosmosdbMongoDatabaseBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermCosmosdbMongoDatabaseState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermCosmosdbMongoDatabaseState<Missing, Missing, Missing>)

        member _.Zero(()) : DataAzurermCosmosdbMongoDatabaseState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermCosmosdbMongoDatabaseState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cosmosdb_mongo_database#account_name-1">DataAzurermCosmosdbMongoDatabase#account_name</a>.
        /// </summary>
        [<CustomOperation "account_name">]
        member _.AccountName(state: DataAzurermCosmosdbMongoDatabaseState<Missing, 'Name, 'ResourceGroupName>, value: string) : DataAzurermCosmosdbMongoDatabaseState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AccountName <- value)
            ({ assignments = state.assignments } : DataAzurermCosmosdbMongoDatabaseState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cosmosdb_mongo_database#name-1">DataAzurermCosmosdbMongoDatabase#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermCosmosdbMongoDatabaseState<'AccountName, Missing, 'ResourceGroupName>, value: string) : DataAzurermCosmosdbMongoDatabaseState<'AccountName, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermCosmosdbMongoDatabaseState<'AccountName, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cosmosdb_mongo_database#resource_group_name-1">DataAzurermCosmosdbMongoDatabase#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermCosmosdbMongoDatabaseState<'AccountName, 'Name, Missing>, value: string) : DataAzurermCosmosdbMongoDatabaseState<'AccountName, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermCosmosdbMongoDatabaseState<'AccountName, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cosmosdb_mongo_database#id-1">DataAzurermCosmosdbMongoDatabase#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermCosmosdbMongoDatabaseState<'AccountName, 'Name, 'ResourceGroupName>, value: string) : DataAzurermCosmosdbMongoDatabaseState<'AccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermCosmosdbMongoDatabaseState<'AccountName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cosmosdb_mongo_database#timeouts-1">DataAzurermCosmosdbMongoDatabase#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermCosmosdbMongoDatabaseState<'AccountName, 'Name, 'ResourceGroupName>, value: azurerm.DataAzurermCosmosdbMongoDatabase.DataAzurermCosmosdbMongoDatabaseTimeouts) : DataAzurermCosmosdbMongoDatabaseState<'AccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermCosmosdbMongoDatabaseState<'AccountName, 'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermCosmosdbMongoDatabaseState<Present, Present, Present>) : azurerm.DataAzurermCosmosdbMongoDatabase.DataAzurermCosmosdbMongoDatabase =
            let config = azurerm.DataAzurermCosmosdbMongoDatabase.DataAzurermCosmosdbMongoDatabaseConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermCosmosdbMongoDatabase.DataAzurermCosmosdbMongoDatabase(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermCosmosdbMongoDatabase: missing required arguments. Must call: account_name, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermCosmosdbMongoDatabaseState<_, _, _>) : azurerm.DataAzurermCosmosdbMongoDatabase.DataAzurermCosmosdbMongoDatabase =
            Unchecked.defaultof<azurerm.DataAzurermCosmosdbMongoDatabase.DataAzurermCosmosdbMongoDatabase>

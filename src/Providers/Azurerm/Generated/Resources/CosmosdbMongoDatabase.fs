namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CosmosdbMongoDatabaseState<'AccountName, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.CosmosdbMongoDatabase.CosmosdbMongoDatabaseConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_mongo_database">azurerm_cosmosdb_mongo_database</a>.
    /// </summary>
    type CosmosdbMongoDatabaseBuilder(logicalId: string) =
        member _.Yield(_: unit) : CosmosdbMongoDatabaseState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CosmosdbMongoDatabaseState<Missing, Missing, Missing>)

        member _.Zero(()) : CosmosdbMongoDatabaseState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CosmosdbMongoDatabaseState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_mongo_database#account_name-1">CosmosdbMongoDatabase#account_name</a>.
        /// </summary>
        [<CustomOperation "account_name">]
        member _.AccountName(state: CosmosdbMongoDatabaseState<Missing, 'Name, 'ResourceGroupName>, value: string) : CosmosdbMongoDatabaseState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AccountName <- value)
            ({ assignments = state.assignments } : CosmosdbMongoDatabaseState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_mongo_database#name-1">CosmosdbMongoDatabase#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: CosmosdbMongoDatabaseState<'AccountName, Missing, 'ResourceGroupName>, value: string) : CosmosdbMongoDatabaseState<'AccountName, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : CosmosdbMongoDatabaseState<'AccountName, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_mongo_database#resource_group_name-1">CosmosdbMongoDatabase#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: CosmosdbMongoDatabaseState<'AccountName, 'Name, Missing>, value: string) : CosmosdbMongoDatabaseState<'AccountName, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : CosmosdbMongoDatabaseState<'AccountName, 'Name, Present>)

        /// <summary>
        /// autoscale_settings block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_mongo_database#autoscale_settings-1">CosmosdbMongoDatabase#autoscale_settings</a>
        /// </summary>
        [<CustomOperation "autoscale_settings">]
        member _.AutoscaleSettings(state: CosmosdbMongoDatabaseState<'AccountName, 'Name, 'ResourceGroupName>, value: azurerm.CosmosdbMongoDatabase.CosmosdbMongoDatabaseAutoscaleSettings) : CosmosdbMongoDatabaseState<'AccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AutoscaleSettings <- value)
            state : CosmosdbMongoDatabaseState<'AccountName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_mongo_database#id-1">CosmosdbMongoDatabase#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CosmosdbMongoDatabaseState<'AccountName, 'Name, 'ResourceGroupName>, value: string) : CosmosdbMongoDatabaseState<'AccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CosmosdbMongoDatabaseState<'AccountName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_mongo_database#throughput-1">CosmosdbMongoDatabase#throughput</a>.
        /// </summary>
        [<CustomOperation "throughput">]
        member _.Throughput(state: CosmosdbMongoDatabaseState<'AccountName, 'Name, 'ResourceGroupName>, value: double) : CosmosdbMongoDatabaseState<'AccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Throughput <- value)
            state : CosmosdbMongoDatabaseState<'AccountName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_mongo_database#timeouts-1">CosmosdbMongoDatabase#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: CosmosdbMongoDatabaseState<'AccountName, 'Name, 'ResourceGroupName>, value: azurerm.CosmosdbMongoDatabase.CosmosdbMongoDatabaseTimeouts) : CosmosdbMongoDatabaseState<'AccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : CosmosdbMongoDatabaseState<'AccountName, 'Name, 'ResourceGroupName>

        member _.Run(state: CosmosdbMongoDatabaseState<Present, Present, Present>) : azurerm.CosmosdbMongoDatabase.CosmosdbMongoDatabase =
            let config = azurerm.CosmosdbMongoDatabase.CosmosdbMongoDatabaseConfig()
            for setter in state.assignments do
                setter config
            azurerm.CosmosdbMongoDatabase.CosmosdbMongoDatabase(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.cosmosdbMongoDatabase: missing required arguments. Must call: account_name, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: CosmosdbMongoDatabaseState<_, _, _>) : azurerm.CosmosdbMongoDatabase.CosmosdbMongoDatabase =
            Unchecked.defaultof<azurerm.CosmosdbMongoDatabase.CosmosdbMongoDatabase>

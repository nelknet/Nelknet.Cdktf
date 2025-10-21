namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CosmosdbMongoUserDefinitionState<'CosmosMongoDatabaseId, 'Password, 'Username> = { assignments: ResizeArray<azurerm.CosmosdbMongoUserDefinition.CosmosdbMongoUserDefinitionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_mongo_user_definition">azurerm_cosmosdb_mongo_user_definition</a>.
    /// </summary>
    type CosmosdbMongoUserDefinitionBuilder(logicalId: string) =
        member _.Yield(_: unit) : CosmosdbMongoUserDefinitionState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CosmosdbMongoUserDefinitionState<Missing, Missing, Missing>)

        member _.Zero(()) : CosmosdbMongoUserDefinitionState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CosmosdbMongoUserDefinitionState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_mongo_user_definition#cosmos_mongo_database_id-1">CosmosdbMongoUserDefinition#cosmos_mongo_database_id</a>.
        /// </summary>
        [<CustomOperation "cosmos_mongo_database_id">]
        member _.CosmosMongoDatabaseId(state: CosmosdbMongoUserDefinitionState<Missing, 'Password, 'Username>, value: string) : CosmosdbMongoUserDefinitionState<Present, 'Password, 'Username> =
            state.assignments.Add(fun config -> config.CosmosMongoDatabaseId <- value)
            ({ assignments = state.assignments } : CosmosdbMongoUserDefinitionState<Present, 'Password, 'Username>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_mongo_user_definition#password-1">CosmosdbMongoUserDefinition#password</a>.
        /// </summary>
        [<CustomOperation "password">]
        member _.Password(state: CosmosdbMongoUserDefinitionState<'CosmosMongoDatabaseId, Missing, 'Username>, value: string) : CosmosdbMongoUserDefinitionState<'CosmosMongoDatabaseId, Present, 'Username> =
            state.assignments.Add(fun config -> config.Password <- value)
            ({ assignments = state.assignments } : CosmosdbMongoUserDefinitionState<'CosmosMongoDatabaseId, Present, 'Username>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_mongo_user_definition#username-1">CosmosdbMongoUserDefinition#username</a>.
        /// </summary>
        [<CustomOperation "username">]
        member _.Username(state: CosmosdbMongoUserDefinitionState<'CosmosMongoDatabaseId, 'Password, Missing>, value: string) : CosmosdbMongoUserDefinitionState<'CosmosMongoDatabaseId, 'Password, Present> =
            state.assignments.Add(fun config -> config.Username <- value)
            ({ assignments = state.assignments } : CosmosdbMongoUserDefinitionState<'CosmosMongoDatabaseId, 'Password, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_mongo_user_definition#id-1">CosmosdbMongoUserDefinition#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CosmosdbMongoUserDefinitionState<'CosmosMongoDatabaseId, 'Password, 'Username>, value: string) : CosmosdbMongoUserDefinitionState<'CosmosMongoDatabaseId, 'Password, 'Username> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CosmosdbMongoUserDefinitionState<'CosmosMongoDatabaseId, 'Password, 'Username>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_mongo_user_definition#inherited_role_names-1">CosmosdbMongoUserDefinition#inherited_role_names</a>.
        /// </summary>
        [<CustomOperation "inherited_role_names">]
        member _.InheritedRoleNames(state: CosmosdbMongoUserDefinitionState<'CosmosMongoDatabaseId, 'Password, 'Username>, value: seq<string>) : CosmosdbMongoUserDefinitionState<'CosmosMongoDatabaseId, 'Password, 'Username> =
            state.assignments.Add(fun config -> config.InheritedRoleNames <- (value |> Seq.toArray))
            state : CosmosdbMongoUserDefinitionState<'CosmosMongoDatabaseId, 'Password, 'Username>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_mongo_user_definition#timeouts-1">CosmosdbMongoUserDefinition#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: CosmosdbMongoUserDefinitionState<'CosmosMongoDatabaseId, 'Password, 'Username>, value: azurerm.CosmosdbMongoUserDefinition.CosmosdbMongoUserDefinitionTimeouts) : CosmosdbMongoUserDefinitionState<'CosmosMongoDatabaseId, 'Password, 'Username> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : CosmosdbMongoUserDefinitionState<'CosmosMongoDatabaseId, 'Password, 'Username>

        member _.Run(state: CosmosdbMongoUserDefinitionState<Present, Present, Present>) : azurerm.CosmosdbMongoUserDefinition.CosmosdbMongoUserDefinition =
            let config = azurerm.CosmosdbMongoUserDefinition.CosmosdbMongoUserDefinitionConfig()
            for setter in state.assignments do
                setter config
            azurerm.CosmosdbMongoUserDefinition.CosmosdbMongoUserDefinition(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.cosmosdbMongoUserDefinition: missing required arguments. Must call: cosmos_mongo_database_id, password, username.", 9999, IsError = true)>]
        member _.Run(_: CosmosdbMongoUserDefinitionState<_, _, _>) : azurerm.CosmosdbMongoUserDefinition.CosmosdbMongoUserDefinition =
            Unchecked.defaultof<azurerm.CosmosdbMongoUserDefinition.CosmosdbMongoUserDefinition>

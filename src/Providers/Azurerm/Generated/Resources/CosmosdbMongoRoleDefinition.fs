namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CosmosdbMongoRoleDefinitionState<'CosmosMongoDatabaseId, 'RoleName> = { assignments: ResizeArray<azurerm.CosmosdbMongoRoleDefinition.CosmosdbMongoRoleDefinitionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_mongo_role_definition">azurerm_cosmosdb_mongo_role_definition</a>.
    /// </summary>
    type CosmosdbMongoRoleDefinitionBuilder(logicalId: string) =
        member _.Yield(_: unit) : CosmosdbMongoRoleDefinitionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CosmosdbMongoRoleDefinitionState<Missing, Missing>)

        member _.Zero(()) : CosmosdbMongoRoleDefinitionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CosmosdbMongoRoleDefinitionState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_mongo_role_definition#cosmos_mongo_database_id-1">CosmosdbMongoRoleDefinition#cosmos_mongo_database_id</a>.
        /// </summary>
        [<CustomOperation "cosmos_mongo_database_id">]
        member _.CosmosMongoDatabaseId(state: CosmosdbMongoRoleDefinitionState<Missing, 'RoleName>, value: string) : CosmosdbMongoRoleDefinitionState<Present, 'RoleName> =
            state.assignments.Add(fun config -> config.CosmosMongoDatabaseId <- value)
            ({ assignments = state.assignments } : CosmosdbMongoRoleDefinitionState<Present, 'RoleName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_mongo_role_definition#role_name-1">CosmosdbMongoRoleDefinition#role_name</a>.
        /// </summary>
        [<CustomOperation "role_name">]
        member _.RoleName(state: CosmosdbMongoRoleDefinitionState<'CosmosMongoDatabaseId, Missing>, value: string) : CosmosdbMongoRoleDefinitionState<'CosmosMongoDatabaseId, Present> =
            state.assignments.Add(fun config -> config.RoleName <- value)
            ({ assignments = state.assignments } : CosmosdbMongoRoleDefinitionState<'CosmosMongoDatabaseId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_mongo_role_definition#id-1">CosmosdbMongoRoleDefinition#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CosmosdbMongoRoleDefinitionState<'CosmosMongoDatabaseId, 'RoleName>, value: string) : CosmosdbMongoRoleDefinitionState<'CosmosMongoDatabaseId, 'RoleName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CosmosdbMongoRoleDefinitionState<'CosmosMongoDatabaseId, 'RoleName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_mongo_role_definition#inherited_role_names-1">CosmosdbMongoRoleDefinition#inherited_role_names</a>.
        /// </summary>
        [<CustomOperation "inherited_role_names">]
        member _.InheritedRoleNames(state: CosmosdbMongoRoleDefinitionState<'CosmosMongoDatabaseId, 'RoleName>, value: seq<string>) : CosmosdbMongoRoleDefinitionState<'CosmosMongoDatabaseId, 'RoleName> =
            state.assignments.Add(fun config -> config.InheritedRoleNames <- (value |> Seq.toArray))
            state : CosmosdbMongoRoleDefinitionState<'CosmosMongoDatabaseId, 'RoleName>

        /// <summary>
        /// privilege block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_mongo_role_definition#privilege-1">CosmosdbMongoRoleDefinition#privilege</a> Accepts: azurerm.IResolvable | azurerm.CosmosdbMongoRoleDefinition.CosmosdbMongoRoleDefinitionPrivilege[]
        /// </summary>
        [<CustomOperation "privilege">]
        member _.Privilege(state: CosmosdbMongoRoleDefinitionState<'CosmosMongoDatabaseId, 'RoleName>, value: HashiCorp.Cdktf.IResolvable) : CosmosdbMongoRoleDefinitionState<'CosmosMongoDatabaseId, 'RoleName> =
            state.assignments.Add(fun config -> config.Privilege <- value)
            state : CosmosdbMongoRoleDefinitionState<'CosmosMongoDatabaseId, 'RoleName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_mongo_role_definition#timeouts-1">CosmosdbMongoRoleDefinition#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: CosmosdbMongoRoleDefinitionState<'CosmosMongoDatabaseId, 'RoleName>, value: azurerm.CosmosdbMongoRoleDefinition.CosmosdbMongoRoleDefinitionTimeouts) : CosmosdbMongoRoleDefinitionState<'CosmosMongoDatabaseId, 'RoleName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : CosmosdbMongoRoleDefinitionState<'CosmosMongoDatabaseId, 'RoleName>

        member _.Run(state: CosmosdbMongoRoleDefinitionState<Present, Present>) : azurerm.CosmosdbMongoRoleDefinition.CosmosdbMongoRoleDefinition =
            let config = azurerm.CosmosdbMongoRoleDefinition.CosmosdbMongoRoleDefinitionConfig()
            for setter in state.assignments do
                setter config
            azurerm.CosmosdbMongoRoleDefinition.CosmosdbMongoRoleDefinition(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.cosmosdbMongoRoleDefinition: missing required arguments. Must call: cosmos_mongo_database_id, role_name.", 9999, IsError = true)>]
        member _.Run(_: CosmosdbMongoRoleDefinitionState<_, _>) : azurerm.CosmosdbMongoRoleDefinition.CosmosdbMongoRoleDefinition =
            Unchecked.defaultof<azurerm.CosmosdbMongoRoleDefinition.CosmosdbMongoRoleDefinition>

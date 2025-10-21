namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataFactoryLinkedServiceCosmosdbMongoapiState<'DataFactoryId, 'Name> = { assignments: ResizeArray<azurerm.DataFactoryLinkedServiceCosmosdbMongoapi.DataFactoryLinkedServiceCosmosdbMongoapiConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_cosmosdb_mongoapi">azurerm_data_factory_linked_service_cosmosdb_mongoapi</a>.
    /// </summary>
    type DataFactoryLinkedServiceCosmosdbMongoapiBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataFactoryLinkedServiceCosmosdbMongoapiState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataFactoryLinkedServiceCosmosdbMongoapiState<Missing, Missing>)

        member _.Zero(()) : DataFactoryLinkedServiceCosmosdbMongoapiState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataFactoryLinkedServiceCosmosdbMongoapiState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_cosmosdb_mongoapi#data_factory_id-1">DataFactoryLinkedServiceCosmosdbMongoapi#data_factory_id</a>.
        /// </summary>
        [<CustomOperation "data_factory_id">]
        member _.DataFactoryId(state: DataFactoryLinkedServiceCosmosdbMongoapiState<Missing, 'Name>, value: string) : DataFactoryLinkedServiceCosmosdbMongoapiState<Present, 'Name> =
            state.assignments.Add(fun config -> config.DataFactoryId <- value)
            ({ assignments = state.assignments } : DataFactoryLinkedServiceCosmosdbMongoapiState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_cosmosdb_mongoapi#name-1">DataFactoryLinkedServiceCosmosdbMongoapi#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataFactoryLinkedServiceCosmosdbMongoapiState<'DataFactoryId, Missing>, value: string) : DataFactoryLinkedServiceCosmosdbMongoapiState<'DataFactoryId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataFactoryLinkedServiceCosmosdbMongoapiState<'DataFactoryId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_cosmosdb_mongoapi#additional_properties-1">DataFactoryLinkedServiceCosmosdbMongoapi#additional_properties</a>.
        /// </summary>
        [<CustomOperation "additional_properties">]
        member _.AdditionalProperties(state: DataFactoryLinkedServiceCosmosdbMongoapiState<'DataFactoryId, 'Name>, value: seq<string * string>) : DataFactoryLinkedServiceCosmosdbMongoapiState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.AdditionalProperties <- dict value)
            state : DataFactoryLinkedServiceCosmosdbMongoapiState<'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_cosmosdb_mongoapi#annotations-1">DataFactoryLinkedServiceCosmosdbMongoapi#annotations</a>.
        /// </summary>
        [<CustomOperation "annotations">]
        member _.Annotations(state: DataFactoryLinkedServiceCosmosdbMongoapiState<'DataFactoryId, 'Name>, value: seq<string>) : DataFactoryLinkedServiceCosmosdbMongoapiState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.Annotations <- (value |> Seq.toArray))
            state : DataFactoryLinkedServiceCosmosdbMongoapiState<'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_cosmosdb_mongoapi#connection_string-1">DataFactoryLinkedServiceCosmosdbMongoapi#connection_string</a>.
        /// </summary>
        [<CustomOperation "connection_string">]
        member _.ConnectionString(state: DataFactoryLinkedServiceCosmosdbMongoapiState<'DataFactoryId, 'Name>, value: string) : DataFactoryLinkedServiceCosmosdbMongoapiState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.ConnectionString <- value)
            state : DataFactoryLinkedServiceCosmosdbMongoapiState<'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_cosmosdb_mongoapi#database-1">DataFactoryLinkedServiceCosmosdbMongoapi#database</a>.
        /// </summary>
        [<CustomOperation "database">]
        member _.Database(state: DataFactoryLinkedServiceCosmosdbMongoapiState<'DataFactoryId, 'Name>, value: string) : DataFactoryLinkedServiceCosmosdbMongoapiState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.Database <- value)
            state : DataFactoryLinkedServiceCosmosdbMongoapiState<'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_cosmosdb_mongoapi#description-1">DataFactoryLinkedServiceCosmosdbMongoapi#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: DataFactoryLinkedServiceCosmosdbMongoapiState<'DataFactoryId, 'Name>, value: string) : DataFactoryLinkedServiceCosmosdbMongoapiState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : DataFactoryLinkedServiceCosmosdbMongoapiState<'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_cosmosdb_mongoapi#id-1">DataFactoryLinkedServiceCosmosdbMongoapi#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataFactoryLinkedServiceCosmosdbMongoapiState<'DataFactoryId, 'Name>, value: string) : DataFactoryLinkedServiceCosmosdbMongoapiState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataFactoryLinkedServiceCosmosdbMongoapiState<'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_cosmosdb_mongoapi#integration_runtime_name-1">DataFactoryLinkedServiceCosmosdbMongoapi#integration_runtime_name</a>.
        /// </summary>
        [<CustomOperation "integration_runtime_name">]
        member _.IntegrationRuntimeName(state: DataFactoryLinkedServiceCosmosdbMongoapiState<'DataFactoryId, 'Name>, value: string) : DataFactoryLinkedServiceCosmosdbMongoapiState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.IntegrationRuntimeName <- value)
            state : DataFactoryLinkedServiceCosmosdbMongoapiState<'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_cosmosdb_mongoapi#parameters-1">DataFactoryLinkedServiceCosmosdbMongoapi#parameters</a>.
        /// </summary>
        [<CustomOperation "parameters">]
        member _.Parameters(state: DataFactoryLinkedServiceCosmosdbMongoapiState<'DataFactoryId, 'Name>, value: seq<string * string>) : DataFactoryLinkedServiceCosmosdbMongoapiState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.Parameters <- dict value)
            state : DataFactoryLinkedServiceCosmosdbMongoapiState<'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_cosmosdb_mongoapi#server_version_is_32_or_higher-1">DataFactoryLinkedServiceCosmosdbMongoapi#server_version_is_32_or_higher</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "server_version_is32_or_higher">]
        member _.ServerVersionIs32OrHigher(state: DataFactoryLinkedServiceCosmosdbMongoapiState<'DataFactoryId, 'Name>, value: bool) : DataFactoryLinkedServiceCosmosdbMongoapiState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.ServerVersionIs32OrHigher <- value)
            state : DataFactoryLinkedServiceCosmosdbMongoapiState<'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_cosmosdb_mongoapi#server_version_is_32_or_higher-1">DataFactoryLinkedServiceCosmosdbMongoapi#server_version_is_32_or_higher</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "server_version_is32_or_higher">]
        member _.ServerVersionIs32OrHigher(state: DataFactoryLinkedServiceCosmosdbMongoapiState<'DataFactoryId, 'Name>, value: HashiCorp.Cdktf.IResolvable) : DataFactoryLinkedServiceCosmosdbMongoapiState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.ServerVersionIs32OrHigher <- value)
            state : DataFactoryLinkedServiceCosmosdbMongoapiState<'DataFactoryId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_cosmosdb_mongoapi#timeouts-1">DataFactoryLinkedServiceCosmosdbMongoapi#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataFactoryLinkedServiceCosmosdbMongoapiState<'DataFactoryId, 'Name>, value: azurerm.DataFactoryLinkedServiceCosmosdbMongoapi.DataFactoryLinkedServiceCosmosdbMongoapiTimeouts) : DataFactoryLinkedServiceCosmosdbMongoapiState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataFactoryLinkedServiceCosmosdbMongoapiState<'DataFactoryId, 'Name>

        member _.Run(state: DataFactoryLinkedServiceCosmosdbMongoapiState<Present, Present>) : azurerm.DataFactoryLinkedServiceCosmosdbMongoapi.DataFactoryLinkedServiceCosmosdbMongoapi =
            let config = azurerm.DataFactoryLinkedServiceCosmosdbMongoapi.DataFactoryLinkedServiceCosmosdbMongoapiConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataFactoryLinkedServiceCosmosdbMongoapi.DataFactoryLinkedServiceCosmosdbMongoapi(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataFactoryLinkedServiceCosmosdbMongoapi: missing required arguments. Must call: data_factory_id, name.", 9999, IsError = true)>]
        member _.Run(_: DataFactoryLinkedServiceCosmosdbMongoapiState<_, _>) : azurerm.DataFactoryLinkedServiceCosmosdbMongoapi.DataFactoryLinkedServiceCosmosdbMongoapi =
            Unchecked.defaultof<azurerm.DataFactoryLinkedServiceCosmosdbMongoapi.DataFactoryLinkedServiceCosmosdbMongoapi>

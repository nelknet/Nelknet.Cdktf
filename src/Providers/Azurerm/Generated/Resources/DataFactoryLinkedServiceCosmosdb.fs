namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataFactoryLinkedServiceCosmosdbState<'DataFactoryId, 'Name> = { assignments: ResizeArray<azurerm.DataFactoryLinkedServiceCosmosdb.DataFactoryLinkedServiceCosmosdbConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_cosmosdb">azurerm_data_factory_linked_service_cosmosdb</a>.
    /// </summary>
    type DataFactoryLinkedServiceCosmosdbBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataFactoryLinkedServiceCosmosdbState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataFactoryLinkedServiceCosmosdbState<Missing, Missing>)

        member _.Zero(()) : DataFactoryLinkedServiceCosmosdbState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataFactoryLinkedServiceCosmosdbState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_cosmosdb#data_factory_id-1">DataFactoryLinkedServiceCosmosdb#data_factory_id</a>.
        /// </summary>
        [<CustomOperation "data_factory_id">]
        member _.DataFactoryId(state: DataFactoryLinkedServiceCosmosdbState<Missing, 'Name>, value: string) : DataFactoryLinkedServiceCosmosdbState<Present, 'Name> =
            state.assignments.Add(fun config -> config.DataFactoryId <- value)
            ({ assignments = state.assignments } : DataFactoryLinkedServiceCosmosdbState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_cosmosdb#name-1">DataFactoryLinkedServiceCosmosdb#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataFactoryLinkedServiceCosmosdbState<'DataFactoryId, Missing>, value: string) : DataFactoryLinkedServiceCosmosdbState<'DataFactoryId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataFactoryLinkedServiceCosmosdbState<'DataFactoryId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_cosmosdb#account_endpoint-1">DataFactoryLinkedServiceCosmosdb#account_endpoint</a>.
        /// </summary>
        [<CustomOperation "account_endpoint">]
        member _.AccountEndpoint(state: DataFactoryLinkedServiceCosmosdbState<'DataFactoryId, 'Name>, value: string) : DataFactoryLinkedServiceCosmosdbState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.AccountEndpoint <- value)
            state : DataFactoryLinkedServiceCosmosdbState<'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_cosmosdb#account_key-1">DataFactoryLinkedServiceCosmosdb#account_key</a>.
        /// </summary>
        [<CustomOperation "account_key">]
        member _.AccountKey(state: DataFactoryLinkedServiceCosmosdbState<'DataFactoryId, 'Name>, value: string) : DataFactoryLinkedServiceCosmosdbState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.AccountKey <- value)
            state : DataFactoryLinkedServiceCosmosdbState<'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_cosmosdb#additional_properties-1">DataFactoryLinkedServiceCosmosdb#additional_properties</a>.
        /// </summary>
        [<CustomOperation "additional_properties">]
        member _.AdditionalProperties(state: DataFactoryLinkedServiceCosmosdbState<'DataFactoryId, 'Name>, value: seq<string * string>) : DataFactoryLinkedServiceCosmosdbState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.AdditionalProperties <- dict value)
            state : DataFactoryLinkedServiceCosmosdbState<'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_cosmosdb#annotations-1">DataFactoryLinkedServiceCosmosdb#annotations</a>.
        /// </summary>
        [<CustomOperation "annotations">]
        member _.Annotations(state: DataFactoryLinkedServiceCosmosdbState<'DataFactoryId, 'Name>, value: seq<string>) : DataFactoryLinkedServiceCosmosdbState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.Annotations <- (value |> Seq.toArray))
            state : DataFactoryLinkedServiceCosmosdbState<'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_cosmosdb#connection_string-1">DataFactoryLinkedServiceCosmosdb#connection_string</a>.
        /// </summary>
        [<CustomOperation "connection_string">]
        member _.ConnectionString(state: DataFactoryLinkedServiceCosmosdbState<'DataFactoryId, 'Name>, value: string) : DataFactoryLinkedServiceCosmosdbState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.ConnectionString <- value)
            state : DataFactoryLinkedServiceCosmosdbState<'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_cosmosdb#database-1">DataFactoryLinkedServiceCosmosdb#database</a>.
        /// </summary>
        [<CustomOperation "database">]
        member _.Database(state: DataFactoryLinkedServiceCosmosdbState<'DataFactoryId, 'Name>, value: string) : DataFactoryLinkedServiceCosmosdbState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.Database <- value)
            state : DataFactoryLinkedServiceCosmosdbState<'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_cosmosdb#description-1">DataFactoryLinkedServiceCosmosdb#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: DataFactoryLinkedServiceCosmosdbState<'DataFactoryId, 'Name>, value: string) : DataFactoryLinkedServiceCosmosdbState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : DataFactoryLinkedServiceCosmosdbState<'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_cosmosdb#id-1">DataFactoryLinkedServiceCosmosdb#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataFactoryLinkedServiceCosmosdbState<'DataFactoryId, 'Name>, value: string) : DataFactoryLinkedServiceCosmosdbState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataFactoryLinkedServiceCosmosdbState<'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_cosmosdb#integration_runtime_name-1">DataFactoryLinkedServiceCosmosdb#integration_runtime_name</a>.
        /// </summary>
        [<CustomOperation "integration_runtime_name">]
        member _.IntegrationRuntimeName(state: DataFactoryLinkedServiceCosmosdbState<'DataFactoryId, 'Name>, value: string) : DataFactoryLinkedServiceCosmosdbState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.IntegrationRuntimeName <- value)
            state : DataFactoryLinkedServiceCosmosdbState<'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_cosmosdb#parameters-1">DataFactoryLinkedServiceCosmosdb#parameters</a>.
        /// </summary>
        [<CustomOperation "parameters">]
        member _.Parameters(state: DataFactoryLinkedServiceCosmosdbState<'DataFactoryId, 'Name>, value: seq<string * string>) : DataFactoryLinkedServiceCosmosdbState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.Parameters <- dict value)
            state : DataFactoryLinkedServiceCosmosdbState<'DataFactoryId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_cosmosdb#timeouts-1">DataFactoryLinkedServiceCosmosdb#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataFactoryLinkedServiceCosmosdbState<'DataFactoryId, 'Name>, value: azurerm.DataFactoryLinkedServiceCosmosdb.DataFactoryLinkedServiceCosmosdbTimeouts) : DataFactoryLinkedServiceCosmosdbState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataFactoryLinkedServiceCosmosdbState<'DataFactoryId, 'Name>

        member _.Run(state: DataFactoryLinkedServiceCosmosdbState<Present, Present>) : azurerm.DataFactoryLinkedServiceCosmosdb.DataFactoryLinkedServiceCosmosdb =
            let config = azurerm.DataFactoryLinkedServiceCosmosdb.DataFactoryLinkedServiceCosmosdbConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataFactoryLinkedServiceCosmosdb.DataFactoryLinkedServiceCosmosdb(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataFactoryLinkedServiceCosmosdb: missing required arguments. Must call: data_factory_id, name.", 9999, IsError = true)>]
        member _.Run(_: DataFactoryLinkedServiceCosmosdbState<_, _>) : azurerm.DataFactoryLinkedServiceCosmosdb.DataFactoryLinkedServiceCosmosdb =
            Unchecked.defaultof<azurerm.DataFactoryLinkedServiceCosmosdb.DataFactoryLinkedServiceCosmosdb>

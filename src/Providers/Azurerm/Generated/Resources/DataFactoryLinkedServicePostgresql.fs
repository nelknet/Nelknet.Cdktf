namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataFactoryLinkedServicePostgresqlState<'ConnectionString, 'DataFactoryId, 'Name> = { assignments: ResizeArray<azurerm.DataFactoryLinkedServicePostgresql.DataFactoryLinkedServicePostgresqlConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_postgresql">azurerm_data_factory_linked_service_postgresql</a>.
    /// </summary>
    type DataFactoryLinkedServicePostgresqlBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataFactoryLinkedServicePostgresqlState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataFactoryLinkedServicePostgresqlState<Missing, Missing, Missing>)

        member _.Zero(()) : DataFactoryLinkedServicePostgresqlState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataFactoryLinkedServicePostgresqlState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_postgresql#connection_string-1">DataFactoryLinkedServicePostgresql#connection_string</a>.
        /// </summary>
        [<CustomOperation "connection_string">]
        member _.ConnectionString(state: DataFactoryLinkedServicePostgresqlState<Missing, 'DataFactoryId, 'Name>, value: string) : DataFactoryLinkedServicePostgresqlState<Present, 'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.ConnectionString <- value)
            ({ assignments = state.assignments } : DataFactoryLinkedServicePostgresqlState<Present, 'DataFactoryId, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_postgresql#data_factory_id-1">DataFactoryLinkedServicePostgresql#data_factory_id</a>.
        /// </summary>
        [<CustomOperation "data_factory_id">]
        member _.DataFactoryId(state: DataFactoryLinkedServicePostgresqlState<'ConnectionString, Missing, 'Name>, value: string) : DataFactoryLinkedServicePostgresqlState<'ConnectionString, Present, 'Name> =
            state.assignments.Add(fun config -> config.DataFactoryId <- value)
            ({ assignments = state.assignments } : DataFactoryLinkedServicePostgresqlState<'ConnectionString, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_postgresql#name-1">DataFactoryLinkedServicePostgresql#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataFactoryLinkedServicePostgresqlState<'ConnectionString, 'DataFactoryId, Missing>, value: string) : DataFactoryLinkedServicePostgresqlState<'ConnectionString, 'DataFactoryId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataFactoryLinkedServicePostgresqlState<'ConnectionString, 'DataFactoryId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_postgresql#additional_properties-1">DataFactoryLinkedServicePostgresql#additional_properties</a>.
        /// </summary>
        [<CustomOperation "additional_properties">]
        member _.AdditionalProperties(state: DataFactoryLinkedServicePostgresqlState<'ConnectionString, 'DataFactoryId, 'Name>, value: seq<string * string>) : DataFactoryLinkedServicePostgresqlState<'ConnectionString, 'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.AdditionalProperties <- dict value)
            state : DataFactoryLinkedServicePostgresqlState<'ConnectionString, 'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_postgresql#annotations-1">DataFactoryLinkedServicePostgresql#annotations</a>.
        /// </summary>
        [<CustomOperation "annotations">]
        member _.Annotations(state: DataFactoryLinkedServicePostgresqlState<'ConnectionString, 'DataFactoryId, 'Name>, value: seq<string>) : DataFactoryLinkedServicePostgresqlState<'ConnectionString, 'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.Annotations <- (value |> Seq.toArray))
            state : DataFactoryLinkedServicePostgresqlState<'ConnectionString, 'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_postgresql#description-1">DataFactoryLinkedServicePostgresql#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: DataFactoryLinkedServicePostgresqlState<'ConnectionString, 'DataFactoryId, 'Name>, value: string) : DataFactoryLinkedServicePostgresqlState<'ConnectionString, 'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : DataFactoryLinkedServicePostgresqlState<'ConnectionString, 'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_postgresql#id-1">DataFactoryLinkedServicePostgresql#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataFactoryLinkedServicePostgresqlState<'ConnectionString, 'DataFactoryId, 'Name>, value: string) : DataFactoryLinkedServicePostgresqlState<'ConnectionString, 'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataFactoryLinkedServicePostgresqlState<'ConnectionString, 'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_postgresql#integration_runtime_name-1">DataFactoryLinkedServicePostgresql#integration_runtime_name</a>.
        /// </summary>
        [<CustomOperation "integration_runtime_name">]
        member _.IntegrationRuntimeName(state: DataFactoryLinkedServicePostgresqlState<'ConnectionString, 'DataFactoryId, 'Name>, value: string) : DataFactoryLinkedServicePostgresqlState<'ConnectionString, 'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.IntegrationRuntimeName <- value)
            state : DataFactoryLinkedServicePostgresqlState<'ConnectionString, 'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_postgresql#parameters-1">DataFactoryLinkedServicePostgresql#parameters</a>.
        /// </summary>
        [<CustomOperation "parameters">]
        member _.Parameters(state: DataFactoryLinkedServicePostgresqlState<'ConnectionString, 'DataFactoryId, 'Name>, value: seq<string * string>) : DataFactoryLinkedServicePostgresqlState<'ConnectionString, 'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.Parameters <- dict value)
            state : DataFactoryLinkedServicePostgresqlState<'ConnectionString, 'DataFactoryId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_postgresql#timeouts-1">DataFactoryLinkedServicePostgresql#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataFactoryLinkedServicePostgresqlState<'ConnectionString, 'DataFactoryId, 'Name>, value: azurerm.DataFactoryLinkedServicePostgresql.DataFactoryLinkedServicePostgresqlTimeouts) : DataFactoryLinkedServicePostgresqlState<'ConnectionString, 'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataFactoryLinkedServicePostgresqlState<'ConnectionString, 'DataFactoryId, 'Name>

        member _.Run(state: DataFactoryLinkedServicePostgresqlState<Present, Present, Present>) : azurerm.DataFactoryLinkedServicePostgresql.DataFactoryLinkedServicePostgresql =
            let config = azurerm.DataFactoryLinkedServicePostgresql.DataFactoryLinkedServicePostgresqlConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataFactoryLinkedServicePostgresql.DataFactoryLinkedServicePostgresql(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataFactoryLinkedServicePostgresql: missing required arguments. Must call: connection_string, data_factory_id, name.", 9999, IsError = true)>]
        member _.Run(_: DataFactoryLinkedServicePostgresqlState<_, _, _>) : azurerm.DataFactoryLinkedServicePostgresql.DataFactoryLinkedServicePostgresql =
            Unchecked.defaultof<azurerm.DataFactoryLinkedServicePostgresql.DataFactoryLinkedServicePostgresql>

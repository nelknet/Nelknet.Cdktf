namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataFactoryLinkedServiceOdbcState<'ConnectionString, 'DataFactoryId, 'Name> = { assignments: ResizeArray<azurerm.DataFactoryLinkedServiceOdbc.DataFactoryLinkedServiceOdbcConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_odbc">azurerm_data_factory_linked_service_odbc</a>.
    /// </summary>
    type DataFactoryLinkedServiceOdbcBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataFactoryLinkedServiceOdbcState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataFactoryLinkedServiceOdbcState<Missing, Missing, Missing>)

        member _.Zero(()) : DataFactoryLinkedServiceOdbcState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataFactoryLinkedServiceOdbcState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_odbc#connection_string-1">DataFactoryLinkedServiceOdbc#connection_string</a>.
        /// </summary>
        [<CustomOperation "connection_string">]
        member _.ConnectionString(state: DataFactoryLinkedServiceOdbcState<Missing, 'DataFactoryId, 'Name>, value: string) : DataFactoryLinkedServiceOdbcState<Present, 'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.ConnectionString <- value)
            ({ assignments = state.assignments } : DataFactoryLinkedServiceOdbcState<Present, 'DataFactoryId, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_odbc#data_factory_id-1">DataFactoryLinkedServiceOdbc#data_factory_id</a>.
        /// </summary>
        [<CustomOperation "data_factory_id">]
        member _.DataFactoryId(state: DataFactoryLinkedServiceOdbcState<'ConnectionString, Missing, 'Name>, value: string) : DataFactoryLinkedServiceOdbcState<'ConnectionString, Present, 'Name> =
            state.assignments.Add(fun config -> config.DataFactoryId <- value)
            ({ assignments = state.assignments } : DataFactoryLinkedServiceOdbcState<'ConnectionString, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_odbc#name-1">DataFactoryLinkedServiceOdbc#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataFactoryLinkedServiceOdbcState<'ConnectionString, 'DataFactoryId, Missing>, value: string) : DataFactoryLinkedServiceOdbcState<'ConnectionString, 'DataFactoryId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataFactoryLinkedServiceOdbcState<'ConnectionString, 'DataFactoryId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_odbc#additional_properties-1">DataFactoryLinkedServiceOdbc#additional_properties</a>.
        /// </summary>
        [<CustomOperation "additional_properties">]
        member _.AdditionalProperties(state: DataFactoryLinkedServiceOdbcState<'ConnectionString, 'DataFactoryId, 'Name>, value: seq<string * string>) : DataFactoryLinkedServiceOdbcState<'ConnectionString, 'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.AdditionalProperties <- dict value)
            state : DataFactoryLinkedServiceOdbcState<'ConnectionString, 'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_odbc#annotations-1">DataFactoryLinkedServiceOdbc#annotations</a>.
        /// </summary>
        [<CustomOperation "annotations">]
        member _.Annotations(state: DataFactoryLinkedServiceOdbcState<'ConnectionString, 'DataFactoryId, 'Name>, value: seq<string>) : DataFactoryLinkedServiceOdbcState<'ConnectionString, 'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.Annotations <- (value |> Seq.toArray))
            state : DataFactoryLinkedServiceOdbcState<'ConnectionString, 'DataFactoryId, 'Name>

        /// <summary>
        /// basic_authentication block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_odbc#basic_authentication-1">DataFactoryLinkedServiceOdbc#basic_authentication</a>
        /// </summary>
        [<CustomOperation "basic_authentication">]
        member _.BasicAuthentication(state: DataFactoryLinkedServiceOdbcState<'ConnectionString, 'DataFactoryId, 'Name>, value: azurerm.DataFactoryLinkedServiceOdbc.DataFactoryLinkedServiceOdbcBasicAuthentication) : DataFactoryLinkedServiceOdbcState<'ConnectionString, 'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.BasicAuthentication <- value)
            state : DataFactoryLinkedServiceOdbcState<'ConnectionString, 'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_odbc#description-1">DataFactoryLinkedServiceOdbc#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: DataFactoryLinkedServiceOdbcState<'ConnectionString, 'DataFactoryId, 'Name>, value: string) : DataFactoryLinkedServiceOdbcState<'ConnectionString, 'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : DataFactoryLinkedServiceOdbcState<'ConnectionString, 'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_odbc#id-1">DataFactoryLinkedServiceOdbc#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataFactoryLinkedServiceOdbcState<'ConnectionString, 'DataFactoryId, 'Name>, value: string) : DataFactoryLinkedServiceOdbcState<'ConnectionString, 'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataFactoryLinkedServiceOdbcState<'ConnectionString, 'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_odbc#integration_runtime_name-1">DataFactoryLinkedServiceOdbc#integration_runtime_name</a>.
        /// </summary>
        [<CustomOperation "integration_runtime_name">]
        member _.IntegrationRuntimeName(state: DataFactoryLinkedServiceOdbcState<'ConnectionString, 'DataFactoryId, 'Name>, value: string) : DataFactoryLinkedServiceOdbcState<'ConnectionString, 'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.IntegrationRuntimeName <- value)
            state : DataFactoryLinkedServiceOdbcState<'ConnectionString, 'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_odbc#parameters-1">DataFactoryLinkedServiceOdbc#parameters</a>.
        /// </summary>
        [<CustomOperation "parameters">]
        member _.Parameters(state: DataFactoryLinkedServiceOdbcState<'ConnectionString, 'DataFactoryId, 'Name>, value: seq<string * string>) : DataFactoryLinkedServiceOdbcState<'ConnectionString, 'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.Parameters <- dict value)
            state : DataFactoryLinkedServiceOdbcState<'ConnectionString, 'DataFactoryId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_odbc#timeouts-1">DataFactoryLinkedServiceOdbc#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataFactoryLinkedServiceOdbcState<'ConnectionString, 'DataFactoryId, 'Name>, value: azurerm.DataFactoryLinkedServiceOdbc.DataFactoryLinkedServiceOdbcTimeouts) : DataFactoryLinkedServiceOdbcState<'ConnectionString, 'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataFactoryLinkedServiceOdbcState<'ConnectionString, 'DataFactoryId, 'Name>

        member _.Run(state: DataFactoryLinkedServiceOdbcState<Present, Present, Present>) : azurerm.DataFactoryLinkedServiceOdbc.DataFactoryLinkedServiceOdbc =
            let config = azurerm.DataFactoryLinkedServiceOdbc.DataFactoryLinkedServiceOdbcConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataFactoryLinkedServiceOdbc.DataFactoryLinkedServiceOdbc(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataFactoryLinkedServiceOdbc: missing required arguments. Must call: connection_string, data_factory_id, name.", 9999, IsError = true)>]
        member _.Run(_: DataFactoryLinkedServiceOdbcState<_, _, _>) : azurerm.DataFactoryLinkedServiceOdbc.DataFactoryLinkedServiceOdbc =
            Unchecked.defaultof<azurerm.DataFactoryLinkedServiceOdbc.DataFactoryLinkedServiceOdbc>

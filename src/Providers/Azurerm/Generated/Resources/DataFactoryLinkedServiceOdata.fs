namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataFactoryLinkedServiceOdataState<'DataFactoryId, 'Name, 'Url> = { assignments: ResizeArray<azurerm.DataFactoryLinkedServiceOdata.DataFactoryLinkedServiceOdataConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_odata">azurerm_data_factory_linked_service_odata</a>.
    /// </summary>
    type DataFactoryLinkedServiceOdataBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataFactoryLinkedServiceOdataState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataFactoryLinkedServiceOdataState<Missing, Missing, Missing>)

        member _.Zero(()) : DataFactoryLinkedServiceOdataState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataFactoryLinkedServiceOdataState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_odata#data_factory_id-1">DataFactoryLinkedServiceOdata#data_factory_id</a>.
        /// </summary>
        [<CustomOperation "data_factory_id">]
        member _.DataFactoryId(state: DataFactoryLinkedServiceOdataState<Missing, 'Name, 'Url>, value: string) : DataFactoryLinkedServiceOdataState<Present, 'Name, 'Url> =
            state.assignments.Add(fun config -> config.DataFactoryId <- value)
            ({ assignments = state.assignments } : DataFactoryLinkedServiceOdataState<Present, 'Name, 'Url>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_odata#name-1">DataFactoryLinkedServiceOdata#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataFactoryLinkedServiceOdataState<'DataFactoryId, Missing, 'Url>, value: string) : DataFactoryLinkedServiceOdataState<'DataFactoryId, Present, 'Url> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataFactoryLinkedServiceOdataState<'DataFactoryId, Present, 'Url>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_odata#url-1">DataFactoryLinkedServiceOdata#url</a>.
        /// </summary>
        [<CustomOperation "url">]
        member _.Url(state: DataFactoryLinkedServiceOdataState<'DataFactoryId, 'Name, Missing>, value: string) : DataFactoryLinkedServiceOdataState<'DataFactoryId, 'Name, Present> =
            state.assignments.Add(fun config -> config.Url <- value)
            ({ assignments = state.assignments } : DataFactoryLinkedServiceOdataState<'DataFactoryId, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_odata#additional_properties-1">DataFactoryLinkedServiceOdata#additional_properties</a>.
        /// </summary>
        [<CustomOperation "additional_properties">]
        member _.AdditionalProperties(state: DataFactoryLinkedServiceOdataState<'DataFactoryId, 'Name, 'Url>, value: seq<string * string>) : DataFactoryLinkedServiceOdataState<'DataFactoryId, 'Name, 'Url> =
            state.assignments.Add(fun config -> config.AdditionalProperties <- dict value)
            state : DataFactoryLinkedServiceOdataState<'DataFactoryId, 'Name, 'Url>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_odata#annotations-1">DataFactoryLinkedServiceOdata#annotations</a>.
        /// </summary>
        [<CustomOperation "annotations">]
        member _.Annotations(state: DataFactoryLinkedServiceOdataState<'DataFactoryId, 'Name, 'Url>, value: seq<string>) : DataFactoryLinkedServiceOdataState<'DataFactoryId, 'Name, 'Url> =
            state.assignments.Add(fun config -> config.Annotations <- (value |> Seq.toArray))
            state : DataFactoryLinkedServiceOdataState<'DataFactoryId, 'Name, 'Url>

        /// <summary>
        /// basic_authentication block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_odata#basic_authentication-1">DataFactoryLinkedServiceOdata#basic_authentication</a>
        /// </summary>
        [<CustomOperation "basic_authentication">]
        member _.BasicAuthentication(state: DataFactoryLinkedServiceOdataState<'DataFactoryId, 'Name, 'Url>, value: azurerm.DataFactoryLinkedServiceOdata.DataFactoryLinkedServiceOdataBasicAuthentication) : DataFactoryLinkedServiceOdataState<'DataFactoryId, 'Name, 'Url> =
            state.assignments.Add(fun config -> config.BasicAuthentication <- value)
            state : DataFactoryLinkedServiceOdataState<'DataFactoryId, 'Name, 'Url>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_odata#description-1">DataFactoryLinkedServiceOdata#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: DataFactoryLinkedServiceOdataState<'DataFactoryId, 'Name, 'Url>, value: string) : DataFactoryLinkedServiceOdataState<'DataFactoryId, 'Name, 'Url> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : DataFactoryLinkedServiceOdataState<'DataFactoryId, 'Name, 'Url>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_odata#id-1">DataFactoryLinkedServiceOdata#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataFactoryLinkedServiceOdataState<'DataFactoryId, 'Name, 'Url>, value: string) : DataFactoryLinkedServiceOdataState<'DataFactoryId, 'Name, 'Url> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataFactoryLinkedServiceOdataState<'DataFactoryId, 'Name, 'Url>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_odata#integration_runtime_name-1">DataFactoryLinkedServiceOdata#integration_runtime_name</a>.
        /// </summary>
        [<CustomOperation "integration_runtime_name">]
        member _.IntegrationRuntimeName(state: DataFactoryLinkedServiceOdataState<'DataFactoryId, 'Name, 'Url>, value: string) : DataFactoryLinkedServiceOdataState<'DataFactoryId, 'Name, 'Url> =
            state.assignments.Add(fun config -> config.IntegrationRuntimeName <- value)
            state : DataFactoryLinkedServiceOdataState<'DataFactoryId, 'Name, 'Url>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_odata#parameters-1">DataFactoryLinkedServiceOdata#parameters</a>.
        /// </summary>
        [<CustomOperation "parameters">]
        member _.Parameters(state: DataFactoryLinkedServiceOdataState<'DataFactoryId, 'Name, 'Url>, value: seq<string * string>) : DataFactoryLinkedServiceOdataState<'DataFactoryId, 'Name, 'Url> =
            state.assignments.Add(fun config -> config.Parameters <- dict value)
            state : DataFactoryLinkedServiceOdataState<'DataFactoryId, 'Name, 'Url>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_odata#timeouts-1">DataFactoryLinkedServiceOdata#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataFactoryLinkedServiceOdataState<'DataFactoryId, 'Name, 'Url>, value: azurerm.DataFactoryLinkedServiceOdata.DataFactoryLinkedServiceOdataTimeouts) : DataFactoryLinkedServiceOdataState<'DataFactoryId, 'Name, 'Url> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataFactoryLinkedServiceOdataState<'DataFactoryId, 'Name, 'Url>

        member _.Run(state: DataFactoryLinkedServiceOdataState<Present, Present, Present>) : azurerm.DataFactoryLinkedServiceOdata.DataFactoryLinkedServiceOdata =
            let config = azurerm.DataFactoryLinkedServiceOdata.DataFactoryLinkedServiceOdataConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataFactoryLinkedServiceOdata.DataFactoryLinkedServiceOdata(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataFactoryLinkedServiceOdata: missing required arguments. Must call: data_factory_id, name, url.", 9999, IsError = true)>]
        member _.Run(_: DataFactoryLinkedServiceOdataState<_, _, _>) : azurerm.DataFactoryLinkedServiceOdata.DataFactoryLinkedServiceOdata =
            Unchecked.defaultof<azurerm.DataFactoryLinkedServiceOdata.DataFactoryLinkedServiceOdata>

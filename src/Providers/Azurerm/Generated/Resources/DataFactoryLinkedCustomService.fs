namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataFactoryLinkedCustomServiceState<'DataFactoryId, 'Name, 'Type, 'TypePropertiesJson> = { assignments: ResizeArray<azurerm.DataFactoryLinkedCustomService.DataFactoryLinkedCustomServiceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_custom_service">azurerm_data_factory_linked_custom_service</a>.
    /// </summary>
    type DataFactoryLinkedCustomServiceBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataFactoryLinkedCustomServiceState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataFactoryLinkedCustomServiceState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : DataFactoryLinkedCustomServiceState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataFactoryLinkedCustomServiceState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_custom_service#data_factory_id-1">DataFactoryLinkedCustomService#data_factory_id</a>.
        /// </summary>
        [<CustomOperation "data_factory_id">]
        member _.DataFactoryId(state: DataFactoryLinkedCustomServiceState<Missing, 'Name, 'Type, 'TypePropertiesJson>, value: string) : DataFactoryLinkedCustomServiceState<Present, 'Name, 'Type, 'TypePropertiesJson> =
            state.assignments.Add(fun config -> config.DataFactoryId <- value)
            ({ assignments = state.assignments } : DataFactoryLinkedCustomServiceState<Present, 'Name, 'Type, 'TypePropertiesJson>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_custom_service#name-1">DataFactoryLinkedCustomService#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataFactoryLinkedCustomServiceState<'DataFactoryId, Missing, 'Type, 'TypePropertiesJson>, value: string) : DataFactoryLinkedCustomServiceState<'DataFactoryId, Present, 'Type, 'TypePropertiesJson> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataFactoryLinkedCustomServiceState<'DataFactoryId, Present, 'Type, 'TypePropertiesJson>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_custom_service#type-1">DataFactoryLinkedCustomService#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: DataFactoryLinkedCustomServiceState<'DataFactoryId, 'Name, Missing, 'TypePropertiesJson>, value: string) : DataFactoryLinkedCustomServiceState<'DataFactoryId, 'Name, Present, 'TypePropertiesJson> =
            state.assignments.Add(fun config -> config.Type <- value)
            ({ assignments = state.assignments } : DataFactoryLinkedCustomServiceState<'DataFactoryId, 'Name, Present, 'TypePropertiesJson>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_custom_service#type_properties_json-1">DataFactoryLinkedCustomService#type_properties_json</a>.
        /// </summary>
        [<CustomOperation "type_properties_json">]
        member _.TypePropertiesJson(state: DataFactoryLinkedCustomServiceState<'DataFactoryId, 'Name, 'Type, Missing>, value: string) : DataFactoryLinkedCustomServiceState<'DataFactoryId, 'Name, 'Type, Present> =
            state.assignments.Add(fun config -> config.TypePropertiesJson <- value)
            ({ assignments = state.assignments } : DataFactoryLinkedCustomServiceState<'DataFactoryId, 'Name, 'Type, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_custom_service#additional_properties-1">DataFactoryLinkedCustomService#additional_properties</a>.
        /// </summary>
        [<CustomOperation "additional_properties">]
        member _.AdditionalProperties(state: DataFactoryLinkedCustomServiceState<'DataFactoryId, 'Name, 'Type, 'TypePropertiesJson>, value: seq<string * string>) : DataFactoryLinkedCustomServiceState<'DataFactoryId, 'Name, 'Type, 'TypePropertiesJson> =
            state.assignments.Add(fun config -> config.AdditionalProperties <- dict value)
            state : DataFactoryLinkedCustomServiceState<'DataFactoryId, 'Name, 'Type, 'TypePropertiesJson>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_custom_service#annotations-1">DataFactoryLinkedCustomService#annotations</a>.
        /// </summary>
        [<CustomOperation "annotations">]
        member _.Annotations(state: DataFactoryLinkedCustomServiceState<'DataFactoryId, 'Name, 'Type, 'TypePropertiesJson>, value: seq<string>) : DataFactoryLinkedCustomServiceState<'DataFactoryId, 'Name, 'Type, 'TypePropertiesJson> =
            state.assignments.Add(fun config -> config.Annotations <- (value |> Seq.toArray))
            state : DataFactoryLinkedCustomServiceState<'DataFactoryId, 'Name, 'Type, 'TypePropertiesJson>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_custom_service#description-1">DataFactoryLinkedCustomService#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: DataFactoryLinkedCustomServiceState<'DataFactoryId, 'Name, 'Type, 'TypePropertiesJson>, value: string) : DataFactoryLinkedCustomServiceState<'DataFactoryId, 'Name, 'Type, 'TypePropertiesJson> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : DataFactoryLinkedCustomServiceState<'DataFactoryId, 'Name, 'Type, 'TypePropertiesJson>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_custom_service#id-1">DataFactoryLinkedCustomService#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataFactoryLinkedCustomServiceState<'DataFactoryId, 'Name, 'Type, 'TypePropertiesJson>, value: string) : DataFactoryLinkedCustomServiceState<'DataFactoryId, 'Name, 'Type, 'TypePropertiesJson> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataFactoryLinkedCustomServiceState<'DataFactoryId, 'Name, 'Type, 'TypePropertiesJson>

        /// <summary>
        /// integration_runtime block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_custom_service#integration_runtime-1">DataFactoryLinkedCustomService#integration_runtime</a>
        /// </summary>
        [<CustomOperation "integration_runtime">]
        member _.IntegrationRuntime(state: DataFactoryLinkedCustomServiceState<'DataFactoryId, 'Name, 'Type, 'TypePropertiesJson>, value: azurerm.DataFactoryLinkedCustomService.DataFactoryLinkedCustomServiceIntegrationRuntime) : DataFactoryLinkedCustomServiceState<'DataFactoryId, 'Name, 'Type, 'TypePropertiesJson> =
            state.assignments.Add(fun config -> config.IntegrationRuntime <- value)
            state : DataFactoryLinkedCustomServiceState<'DataFactoryId, 'Name, 'Type, 'TypePropertiesJson>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_custom_service#parameters-1">DataFactoryLinkedCustomService#parameters</a>.
        /// </summary>
        [<CustomOperation "parameters">]
        member _.Parameters(state: DataFactoryLinkedCustomServiceState<'DataFactoryId, 'Name, 'Type, 'TypePropertiesJson>, value: seq<string * string>) : DataFactoryLinkedCustomServiceState<'DataFactoryId, 'Name, 'Type, 'TypePropertiesJson> =
            state.assignments.Add(fun config -> config.Parameters <- dict value)
            state : DataFactoryLinkedCustomServiceState<'DataFactoryId, 'Name, 'Type, 'TypePropertiesJson>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_custom_service#timeouts-1">DataFactoryLinkedCustomService#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataFactoryLinkedCustomServiceState<'DataFactoryId, 'Name, 'Type, 'TypePropertiesJson>, value: azurerm.DataFactoryLinkedCustomService.DataFactoryLinkedCustomServiceTimeouts) : DataFactoryLinkedCustomServiceState<'DataFactoryId, 'Name, 'Type, 'TypePropertiesJson> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataFactoryLinkedCustomServiceState<'DataFactoryId, 'Name, 'Type, 'TypePropertiesJson>

        member _.Run(state: DataFactoryLinkedCustomServiceState<Present, Present, Present, Present>) : azurerm.DataFactoryLinkedCustomService.DataFactoryLinkedCustomService =
            let config = azurerm.DataFactoryLinkedCustomService.DataFactoryLinkedCustomServiceConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataFactoryLinkedCustomService.DataFactoryLinkedCustomService(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataFactoryLinkedCustomService: missing required arguments. Must call: data_factory_id, name, type, type_properties_json.", 9999, IsError = true)>]
        member _.Run(_: DataFactoryLinkedCustomServiceState<_, _, _, _>) : azurerm.DataFactoryLinkedCustomService.DataFactoryLinkedCustomService =
            Unchecked.defaultof<azurerm.DataFactoryLinkedCustomService.DataFactoryLinkedCustomService>

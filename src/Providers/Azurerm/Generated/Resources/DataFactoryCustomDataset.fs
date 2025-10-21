namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataFactoryCustomDatasetState<'DataFactoryId, 'LinkedService, 'Name, 'Type, 'TypePropertiesJson> = { assignments: ResizeArray<azurerm.DataFactoryCustomDataset.DataFactoryCustomDatasetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_custom_dataset">azurerm_data_factory_custom_dataset</a>.
    /// </summary>
    type DataFactoryCustomDatasetBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataFactoryCustomDatasetState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataFactoryCustomDatasetState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : DataFactoryCustomDatasetState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataFactoryCustomDatasetState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_custom_dataset#data_factory_id-1">DataFactoryCustomDataset#data_factory_id</a>.
        /// </summary>
        [<CustomOperation "data_factory_id">]
        member _.DataFactoryId(state: DataFactoryCustomDatasetState<Missing, 'LinkedService, 'Name, 'Type, 'TypePropertiesJson>, value: string) : DataFactoryCustomDatasetState<Present, 'LinkedService, 'Name, 'Type, 'TypePropertiesJson> =
            state.assignments.Add(fun config -> config.DataFactoryId <- value)
            ({ assignments = state.assignments } : DataFactoryCustomDatasetState<Present, 'LinkedService, 'Name, 'Type, 'TypePropertiesJson>)

        /// <summary>
        /// linked_service block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_custom_dataset#linked_service-1">DataFactoryCustomDataset#linked_service</a>
        /// </summary>
        [<CustomOperation "linked_service">]
        member _.LinkedService(state: DataFactoryCustomDatasetState<'DataFactoryId, Missing, 'Name, 'Type, 'TypePropertiesJson>, value: azurerm.DataFactoryCustomDataset.DataFactoryCustomDatasetLinkedService) : DataFactoryCustomDatasetState<'DataFactoryId, Present, 'Name, 'Type, 'TypePropertiesJson> =
            state.assignments.Add(fun config -> config.LinkedService <- value)
            ({ assignments = state.assignments } : DataFactoryCustomDatasetState<'DataFactoryId, Present, 'Name, 'Type, 'TypePropertiesJson>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_custom_dataset#name-1">DataFactoryCustomDataset#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataFactoryCustomDatasetState<'DataFactoryId, 'LinkedService, Missing, 'Type, 'TypePropertiesJson>, value: string) : DataFactoryCustomDatasetState<'DataFactoryId, 'LinkedService, Present, 'Type, 'TypePropertiesJson> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataFactoryCustomDatasetState<'DataFactoryId, 'LinkedService, Present, 'Type, 'TypePropertiesJson>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_custom_dataset#type-1">DataFactoryCustomDataset#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: DataFactoryCustomDatasetState<'DataFactoryId, 'LinkedService, 'Name, Missing, 'TypePropertiesJson>, value: string) : DataFactoryCustomDatasetState<'DataFactoryId, 'LinkedService, 'Name, Present, 'TypePropertiesJson> =
            state.assignments.Add(fun config -> config.Type <- value)
            ({ assignments = state.assignments } : DataFactoryCustomDatasetState<'DataFactoryId, 'LinkedService, 'Name, Present, 'TypePropertiesJson>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_custom_dataset#type_properties_json-1">DataFactoryCustomDataset#type_properties_json</a>.
        /// </summary>
        [<CustomOperation "type_properties_json">]
        member _.TypePropertiesJson(state: DataFactoryCustomDatasetState<'DataFactoryId, 'LinkedService, 'Name, 'Type, Missing>, value: string) : DataFactoryCustomDatasetState<'DataFactoryId, 'LinkedService, 'Name, 'Type, Present> =
            state.assignments.Add(fun config -> config.TypePropertiesJson <- value)
            ({ assignments = state.assignments } : DataFactoryCustomDatasetState<'DataFactoryId, 'LinkedService, 'Name, 'Type, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_custom_dataset#additional_properties-1">DataFactoryCustomDataset#additional_properties</a>.
        /// </summary>
        [<CustomOperation "additional_properties">]
        member _.AdditionalProperties(state: DataFactoryCustomDatasetState<'DataFactoryId, 'LinkedService, 'Name, 'Type, 'TypePropertiesJson>, value: seq<string * string>) : DataFactoryCustomDatasetState<'DataFactoryId, 'LinkedService, 'Name, 'Type, 'TypePropertiesJson> =
            state.assignments.Add(fun config -> config.AdditionalProperties <- dict value)
            state : DataFactoryCustomDatasetState<'DataFactoryId, 'LinkedService, 'Name, 'Type, 'TypePropertiesJson>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_custom_dataset#annotations-1">DataFactoryCustomDataset#annotations</a>.
        /// </summary>
        [<CustomOperation "annotations">]
        member _.Annotations(state: DataFactoryCustomDatasetState<'DataFactoryId, 'LinkedService, 'Name, 'Type, 'TypePropertiesJson>, value: seq<string>) : DataFactoryCustomDatasetState<'DataFactoryId, 'LinkedService, 'Name, 'Type, 'TypePropertiesJson> =
            state.assignments.Add(fun config -> config.Annotations <- (value |> Seq.toArray))
            state : DataFactoryCustomDatasetState<'DataFactoryId, 'LinkedService, 'Name, 'Type, 'TypePropertiesJson>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_custom_dataset#description-1">DataFactoryCustomDataset#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: DataFactoryCustomDatasetState<'DataFactoryId, 'LinkedService, 'Name, 'Type, 'TypePropertiesJson>, value: string) : DataFactoryCustomDatasetState<'DataFactoryId, 'LinkedService, 'Name, 'Type, 'TypePropertiesJson> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : DataFactoryCustomDatasetState<'DataFactoryId, 'LinkedService, 'Name, 'Type, 'TypePropertiesJson>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_custom_dataset#folder-1">DataFactoryCustomDataset#folder</a>.
        /// </summary>
        [<CustomOperation "folder">]
        member _.Folder(state: DataFactoryCustomDatasetState<'DataFactoryId, 'LinkedService, 'Name, 'Type, 'TypePropertiesJson>, value: string) : DataFactoryCustomDatasetState<'DataFactoryId, 'LinkedService, 'Name, 'Type, 'TypePropertiesJson> =
            state.assignments.Add(fun config -> config.Folder <- value)
            state : DataFactoryCustomDatasetState<'DataFactoryId, 'LinkedService, 'Name, 'Type, 'TypePropertiesJson>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_custom_dataset#id-1">DataFactoryCustomDataset#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataFactoryCustomDatasetState<'DataFactoryId, 'LinkedService, 'Name, 'Type, 'TypePropertiesJson>, value: string) : DataFactoryCustomDatasetState<'DataFactoryId, 'LinkedService, 'Name, 'Type, 'TypePropertiesJson> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataFactoryCustomDatasetState<'DataFactoryId, 'LinkedService, 'Name, 'Type, 'TypePropertiesJson>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_custom_dataset#parameters-1">DataFactoryCustomDataset#parameters</a>.
        /// </summary>
        [<CustomOperation "parameters">]
        member _.Parameters(state: DataFactoryCustomDatasetState<'DataFactoryId, 'LinkedService, 'Name, 'Type, 'TypePropertiesJson>, value: seq<string * string>) : DataFactoryCustomDatasetState<'DataFactoryId, 'LinkedService, 'Name, 'Type, 'TypePropertiesJson> =
            state.assignments.Add(fun config -> config.Parameters <- dict value)
            state : DataFactoryCustomDatasetState<'DataFactoryId, 'LinkedService, 'Name, 'Type, 'TypePropertiesJson>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_custom_dataset#schema_json-1">DataFactoryCustomDataset#schema_json</a>.
        /// </summary>
        [<CustomOperation "schema_json">]
        member _.SchemaJson(state: DataFactoryCustomDatasetState<'DataFactoryId, 'LinkedService, 'Name, 'Type, 'TypePropertiesJson>, value: string) : DataFactoryCustomDatasetState<'DataFactoryId, 'LinkedService, 'Name, 'Type, 'TypePropertiesJson> =
            state.assignments.Add(fun config -> config.SchemaJson <- value)
            state : DataFactoryCustomDatasetState<'DataFactoryId, 'LinkedService, 'Name, 'Type, 'TypePropertiesJson>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_custom_dataset#timeouts-1">DataFactoryCustomDataset#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataFactoryCustomDatasetState<'DataFactoryId, 'LinkedService, 'Name, 'Type, 'TypePropertiesJson>, value: azurerm.DataFactoryCustomDataset.DataFactoryCustomDatasetTimeouts) : DataFactoryCustomDatasetState<'DataFactoryId, 'LinkedService, 'Name, 'Type, 'TypePropertiesJson> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataFactoryCustomDatasetState<'DataFactoryId, 'LinkedService, 'Name, 'Type, 'TypePropertiesJson>

        member _.Run(state: DataFactoryCustomDatasetState<Present, Present, Present, Present, Present>) : azurerm.DataFactoryCustomDataset.DataFactoryCustomDataset =
            let config = azurerm.DataFactoryCustomDataset.DataFactoryCustomDatasetConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataFactoryCustomDataset.DataFactoryCustomDataset(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataFactoryCustomDataset: missing required arguments. Must call: data_factory_id, linked_service, name, type, type_properties_json.", 9999, IsError = true)>]
        member _.Run(_: DataFactoryCustomDatasetState<_, _, _, _, _>) : azurerm.DataFactoryCustomDataset.DataFactoryCustomDataset =
            Unchecked.defaultof<azurerm.DataFactoryCustomDataset.DataFactoryCustomDataset>

namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataFactoryLinkedServiceAzureTableStorageState<'ConnectionString, 'DataFactoryId, 'Name> = { assignments: ResizeArray<azurerm.DataFactoryLinkedServiceAzureTableStorage.DataFactoryLinkedServiceAzureTableStorageConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_table_storage">azurerm_data_factory_linked_service_azure_table_storage</a>.
    /// </summary>
    type DataFactoryLinkedServiceAzureTableStorageBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataFactoryLinkedServiceAzureTableStorageState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataFactoryLinkedServiceAzureTableStorageState<Missing, Missing, Missing>)

        member _.Zero(()) : DataFactoryLinkedServiceAzureTableStorageState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataFactoryLinkedServiceAzureTableStorageState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_table_storage#connection_string-1">DataFactoryLinkedServiceAzureTableStorage#connection_string</a>.
        /// </summary>
        [<CustomOperation "connection_string">]
        member _.ConnectionString(state: DataFactoryLinkedServiceAzureTableStorageState<Missing, 'DataFactoryId, 'Name>, value: string) : DataFactoryLinkedServiceAzureTableStorageState<Present, 'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.ConnectionString <- value)
            ({ assignments = state.assignments } : DataFactoryLinkedServiceAzureTableStorageState<Present, 'DataFactoryId, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_table_storage#data_factory_id-1">DataFactoryLinkedServiceAzureTableStorage#data_factory_id</a>.
        /// </summary>
        [<CustomOperation "data_factory_id">]
        member _.DataFactoryId(state: DataFactoryLinkedServiceAzureTableStorageState<'ConnectionString, Missing, 'Name>, value: string) : DataFactoryLinkedServiceAzureTableStorageState<'ConnectionString, Present, 'Name> =
            state.assignments.Add(fun config -> config.DataFactoryId <- value)
            ({ assignments = state.assignments } : DataFactoryLinkedServiceAzureTableStorageState<'ConnectionString, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_table_storage#name-1">DataFactoryLinkedServiceAzureTableStorage#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataFactoryLinkedServiceAzureTableStorageState<'ConnectionString, 'DataFactoryId, Missing>, value: string) : DataFactoryLinkedServiceAzureTableStorageState<'ConnectionString, 'DataFactoryId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataFactoryLinkedServiceAzureTableStorageState<'ConnectionString, 'DataFactoryId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_table_storage#additional_properties-1">DataFactoryLinkedServiceAzureTableStorage#additional_properties</a>.
        /// </summary>
        [<CustomOperation "additional_properties">]
        member _.AdditionalProperties(state: DataFactoryLinkedServiceAzureTableStorageState<'ConnectionString, 'DataFactoryId, 'Name>, value: seq<string * string>) : DataFactoryLinkedServiceAzureTableStorageState<'ConnectionString, 'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.AdditionalProperties <- dict value)
            state : DataFactoryLinkedServiceAzureTableStorageState<'ConnectionString, 'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_table_storage#annotations-1">DataFactoryLinkedServiceAzureTableStorage#annotations</a>.
        /// </summary>
        [<CustomOperation "annotations">]
        member _.Annotations(state: DataFactoryLinkedServiceAzureTableStorageState<'ConnectionString, 'DataFactoryId, 'Name>, value: seq<string>) : DataFactoryLinkedServiceAzureTableStorageState<'ConnectionString, 'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.Annotations <- (value |> Seq.toArray))
            state : DataFactoryLinkedServiceAzureTableStorageState<'ConnectionString, 'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_table_storage#description-1">DataFactoryLinkedServiceAzureTableStorage#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: DataFactoryLinkedServiceAzureTableStorageState<'ConnectionString, 'DataFactoryId, 'Name>, value: string) : DataFactoryLinkedServiceAzureTableStorageState<'ConnectionString, 'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : DataFactoryLinkedServiceAzureTableStorageState<'ConnectionString, 'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_table_storage#id-1">DataFactoryLinkedServiceAzureTableStorage#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataFactoryLinkedServiceAzureTableStorageState<'ConnectionString, 'DataFactoryId, 'Name>, value: string) : DataFactoryLinkedServiceAzureTableStorageState<'ConnectionString, 'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataFactoryLinkedServiceAzureTableStorageState<'ConnectionString, 'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_table_storage#integration_runtime_name-1">DataFactoryLinkedServiceAzureTableStorage#integration_runtime_name</a>.
        /// </summary>
        [<CustomOperation "integration_runtime_name">]
        member _.IntegrationRuntimeName(state: DataFactoryLinkedServiceAzureTableStorageState<'ConnectionString, 'DataFactoryId, 'Name>, value: string) : DataFactoryLinkedServiceAzureTableStorageState<'ConnectionString, 'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.IntegrationRuntimeName <- value)
            state : DataFactoryLinkedServiceAzureTableStorageState<'ConnectionString, 'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_table_storage#parameters-1">DataFactoryLinkedServiceAzureTableStorage#parameters</a>.
        /// </summary>
        [<CustomOperation "parameters">]
        member _.Parameters(state: DataFactoryLinkedServiceAzureTableStorageState<'ConnectionString, 'DataFactoryId, 'Name>, value: seq<string * string>) : DataFactoryLinkedServiceAzureTableStorageState<'ConnectionString, 'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.Parameters <- dict value)
            state : DataFactoryLinkedServiceAzureTableStorageState<'ConnectionString, 'DataFactoryId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_table_storage#timeouts-1">DataFactoryLinkedServiceAzureTableStorage#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataFactoryLinkedServiceAzureTableStorageState<'ConnectionString, 'DataFactoryId, 'Name>, value: azurerm.DataFactoryLinkedServiceAzureTableStorage.DataFactoryLinkedServiceAzureTableStorageTimeouts) : DataFactoryLinkedServiceAzureTableStorageState<'ConnectionString, 'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataFactoryLinkedServiceAzureTableStorageState<'ConnectionString, 'DataFactoryId, 'Name>

        member _.Run(state: DataFactoryLinkedServiceAzureTableStorageState<Present, Present, Present>) : azurerm.DataFactoryLinkedServiceAzureTableStorage.DataFactoryLinkedServiceAzureTableStorage =
            let config = azurerm.DataFactoryLinkedServiceAzureTableStorage.DataFactoryLinkedServiceAzureTableStorageConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataFactoryLinkedServiceAzureTableStorage.DataFactoryLinkedServiceAzureTableStorage(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataFactoryLinkedServiceAzureTableStorage: missing required arguments. Must call: connection_string, data_factory_id, name.", 9999, IsError = true)>]
        member _.Run(_: DataFactoryLinkedServiceAzureTableStorageState<_, _, _>) : azurerm.DataFactoryLinkedServiceAzureTableStorage.DataFactoryLinkedServiceAzureTableStorage =
            Unchecked.defaultof<azurerm.DataFactoryLinkedServiceAzureTableStorage.DataFactoryLinkedServiceAzureTableStorage>

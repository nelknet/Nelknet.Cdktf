namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataFactoryLinkedServiceDataLakeStorageGen2State<'DataFactoryId, 'Name, 'Url> = { assignments: ResizeArray<azurerm.DataFactoryLinkedServiceDataLakeStorageGen2.DataFactoryLinkedServiceDataLakeStorageGen2Config -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_data_lake_storage_gen2">azurerm_data_factory_linked_service_data_lake_storage_gen2</a>.
    /// </summary>
    type DataFactoryLinkedServiceDataLakeStorageGen2Builder(logicalId: string) =
        member _.Yield(_: unit) : DataFactoryLinkedServiceDataLakeStorageGen2State<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataFactoryLinkedServiceDataLakeStorageGen2State<Missing, Missing, Missing>)

        member _.Zero(()) : DataFactoryLinkedServiceDataLakeStorageGen2State<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataFactoryLinkedServiceDataLakeStorageGen2State<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_data_lake_storage_gen2#data_factory_id-1">DataFactoryLinkedServiceDataLakeStorageGen2#data_factory_id</a>.
        /// </summary>
        [<CustomOperation "data_factory_id">]
        member _.DataFactoryId(state: DataFactoryLinkedServiceDataLakeStorageGen2State<Missing, 'Name, 'Url>, value: string) : DataFactoryLinkedServiceDataLakeStorageGen2State<Present, 'Name, 'Url> =
            state.assignments.Add(fun config -> config.DataFactoryId <- value)
            ({ assignments = state.assignments } : DataFactoryLinkedServiceDataLakeStorageGen2State<Present, 'Name, 'Url>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_data_lake_storage_gen2#name-1">DataFactoryLinkedServiceDataLakeStorageGen2#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataFactoryLinkedServiceDataLakeStorageGen2State<'DataFactoryId, Missing, 'Url>, value: string) : DataFactoryLinkedServiceDataLakeStorageGen2State<'DataFactoryId, Present, 'Url> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataFactoryLinkedServiceDataLakeStorageGen2State<'DataFactoryId, Present, 'Url>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_data_lake_storage_gen2#url-1">DataFactoryLinkedServiceDataLakeStorageGen2#url</a>.
        /// </summary>
        [<CustomOperation "url">]
        member _.Url(state: DataFactoryLinkedServiceDataLakeStorageGen2State<'DataFactoryId, 'Name, Missing>, value: string) : DataFactoryLinkedServiceDataLakeStorageGen2State<'DataFactoryId, 'Name, Present> =
            state.assignments.Add(fun config -> config.Url <- value)
            ({ assignments = state.assignments } : DataFactoryLinkedServiceDataLakeStorageGen2State<'DataFactoryId, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_data_lake_storage_gen2#additional_properties-1">DataFactoryLinkedServiceDataLakeStorageGen2#additional_properties</a>.
        /// </summary>
        [<CustomOperation "additional_properties">]
        member _.AdditionalProperties(state: DataFactoryLinkedServiceDataLakeStorageGen2State<'DataFactoryId, 'Name, 'Url>, value: seq<string * string>) : DataFactoryLinkedServiceDataLakeStorageGen2State<'DataFactoryId, 'Name, 'Url> =
            state.assignments.Add(fun config -> config.AdditionalProperties <- dict value)
            state : DataFactoryLinkedServiceDataLakeStorageGen2State<'DataFactoryId, 'Name, 'Url>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_data_lake_storage_gen2#annotations-1">DataFactoryLinkedServiceDataLakeStorageGen2#annotations</a>.
        /// </summary>
        [<CustomOperation "annotations">]
        member _.Annotations(state: DataFactoryLinkedServiceDataLakeStorageGen2State<'DataFactoryId, 'Name, 'Url>, value: seq<string>) : DataFactoryLinkedServiceDataLakeStorageGen2State<'DataFactoryId, 'Name, 'Url> =
            state.assignments.Add(fun config -> config.Annotations <- (value |> Seq.toArray))
            state : DataFactoryLinkedServiceDataLakeStorageGen2State<'DataFactoryId, 'Name, 'Url>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_data_lake_storage_gen2#description-1">DataFactoryLinkedServiceDataLakeStorageGen2#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: DataFactoryLinkedServiceDataLakeStorageGen2State<'DataFactoryId, 'Name, 'Url>, value: string) : DataFactoryLinkedServiceDataLakeStorageGen2State<'DataFactoryId, 'Name, 'Url> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : DataFactoryLinkedServiceDataLakeStorageGen2State<'DataFactoryId, 'Name, 'Url>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_data_lake_storage_gen2#id-1">DataFactoryLinkedServiceDataLakeStorageGen2#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataFactoryLinkedServiceDataLakeStorageGen2State<'DataFactoryId, 'Name, 'Url>, value: string) : DataFactoryLinkedServiceDataLakeStorageGen2State<'DataFactoryId, 'Name, 'Url> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataFactoryLinkedServiceDataLakeStorageGen2State<'DataFactoryId, 'Name, 'Url>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_data_lake_storage_gen2#integration_runtime_name-1">DataFactoryLinkedServiceDataLakeStorageGen2#integration_runtime_name</a>.
        /// </summary>
        [<CustomOperation "integration_runtime_name">]
        member _.IntegrationRuntimeName(state: DataFactoryLinkedServiceDataLakeStorageGen2State<'DataFactoryId, 'Name, 'Url>, value: string) : DataFactoryLinkedServiceDataLakeStorageGen2State<'DataFactoryId, 'Name, 'Url> =
            state.assignments.Add(fun config -> config.IntegrationRuntimeName <- value)
            state : DataFactoryLinkedServiceDataLakeStorageGen2State<'DataFactoryId, 'Name, 'Url>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_data_lake_storage_gen2#parameters-1">DataFactoryLinkedServiceDataLakeStorageGen2#parameters</a>.
        /// </summary>
        [<CustomOperation "parameters">]
        member _.Parameters(state: DataFactoryLinkedServiceDataLakeStorageGen2State<'DataFactoryId, 'Name, 'Url>, value: seq<string * string>) : DataFactoryLinkedServiceDataLakeStorageGen2State<'DataFactoryId, 'Name, 'Url> =
            state.assignments.Add(fun config -> config.Parameters <- dict value)
            state : DataFactoryLinkedServiceDataLakeStorageGen2State<'DataFactoryId, 'Name, 'Url>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_data_lake_storage_gen2#service_principal_id-1">DataFactoryLinkedServiceDataLakeStorageGen2#service_principal_id</a>.
        /// </summary>
        [<CustomOperation "service_principal_id">]
        member _.ServicePrincipalId(state: DataFactoryLinkedServiceDataLakeStorageGen2State<'DataFactoryId, 'Name, 'Url>, value: string) : DataFactoryLinkedServiceDataLakeStorageGen2State<'DataFactoryId, 'Name, 'Url> =
            state.assignments.Add(fun config -> config.ServicePrincipalId <- value)
            state : DataFactoryLinkedServiceDataLakeStorageGen2State<'DataFactoryId, 'Name, 'Url>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_data_lake_storage_gen2#service_principal_key-1">DataFactoryLinkedServiceDataLakeStorageGen2#service_principal_key</a>.
        /// </summary>
        [<CustomOperation "service_principal_key">]
        member _.ServicePrincipalKey(state: DataFactoryLinkedServiceDataLakeStorageGen2State<'DataFactoryId, 'Name, 'Url>, value: string) : DataFactoryLinkedServiceDataLakeStorageGen2State<'DataFactoryId, 'Name, 'Url> =
            state.assignments.Add(fun config -> config.ServicePrincipalKey <- value)
            state : DataFactoryLinkedServiceDataLakeStorageGen2State<'DataFactoryId, 'Name, 'Url>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_data_lake_storage_gen2#storage_account_key-1">DataFactoryLinkedServiceDataLakeStorageGen2#storage_account_key</a>.
        /// </summary>
        [<CustomOperation "storage_account_key">]
        member _.StorageAccountKey(state: DataFactoryLinkedServiceDataLakeStorageGen2State<'DataFactoryId, 'Name, 'Url>, value: string) : DataFactoryLinkedServiceDataLakeStorageGen2State<'DataFactoryId, 'Name, 'Url> =
            state.assignments.Add(fun config -> config.StorageAccountKey <- value)
            state : DataFactoryLinkedServiceDataLakeStorageGen2State<'DataFactoryId, 'Name, 'Url>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_data_lake_storage_gen2#tenant-1">DataFactoryLinkedServiceDataLakeStorageGen2#tenant</a>.
        /// </summary>
        [<CustomOperation "tenant">]
        member _.Tenant(state: DataFactoryLinkedServiceDataLakeStorageGen2State<'DataFactoryId, 'Name, 'Url>, value: string) : DataFactoryLinkedServiceDataLakeStorageGen2State<'DataFactoryId, 'Name, 'Url> =
            state.assignments.Add(fun config -> config.Tenant <- value)
            state : DataFactoryLinkedServiceDataLakeStorageGen2State<'DataFactoryId, 'Name, 'Url>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_data_lake_storage_gen2#timeouts-1">DataFactoryLinkedServiceDataLakeStorageGen2#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataFactoryLinkedServiceDataLakeStorageGen2State<'DataFactoryId, 'Name, 'Url>, value: azurerm.DataFactoryLinkedServiceDataLakeStorageGen2.DataFactoryLinkedServiceDataLakeStorageGen2Timeouts) : DataFactoryLinkedServiceDataLakeStorageGen2State<'DataFactoryId, 'Name, 'Url> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataFactoryLinkedServiceDataLakeStorageGen2State<'DataFactoryId, 'Name, 'Url>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_data_lake_storage_gen2#use_managed_identity-1">DataFactoryLinkedServiceDataLakeStorageGen2#use_managed_identity</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "use_managed_identity">]
        member _.UseManagedIdentity(state: DataFactoryLinkedServiceDataLakeStorageGen2State<'DataFactoryId, 'Name, 'Url>, value: bool) : DataFactoryLinkedServiceDataLakeStorageGen2State<'DataFactoryId, 'Name, 'Url> =
            state.assignments.Add(fun config -> config.UseManagedIdentity <- value)
            state : DataFactoryLinkedServiceDataLakeStorageGen2State<'DataFactoryId, 'Name, 'Url>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_data_lake_storage_gen2#use_managed_identity-1">DataFactoryLinkedServiceDataLakeStorageGen2#use_managed_identity</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "use_managed_identity">]
        member _.UseManagedIdentity(state: DataFactoryLinkedServiceDataLakeStorageGen2State<'DataFactoryId, 'Name, 'Url>, value: HashiCorp.Cdktf.IResolvable) : DataFactoryLinkedServiceDataLakeStorageGen2State<'DataFactoryId, 'Name, 'Url> =
            state.assignments.Add(fun config -> config.UseManagedIdentity <- value)
            state : DataFactoryLinkedServiceDataLakeStorageGen2State<'DataFactoryId, 'Name, 'Url>

        member _.Run(state: DataFactoryLinkedServiceDataLakeStorageGen2State<Present, Present, Present>) : azurerm.DataFactoryLinkedServiceDataLakeStorageGen2.DataFactoryLinkedServiceDataLakeStorageGen2 =
            let config = azurerm.DataFactoryLinkedServiceDataLakeStorageGen2.DataFactoryLinkedServiceDataLakeStorageGen2Config()
            for setter in state.assignments do
                setter config
            azurerm.DataFactoryLinkedServiceDataLakeStorageGen2.DataFactoryLinkedServiceDataLakeStorageGen2(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataFactoryLinkedServiceDataLakeStorageGen2: missing required arguments. Must call: data_factory_id, name, url.", 9999, IsError = true)>]
        member _.Run(_: DataFactoryLinkedServiceDataLakeStorageGen2State<_, _, _>) : azurerm.DataFactoryLinkedServiceDataLakeStorageGen2.DataFactoryLinkedServiceDataLakeStorageGen2 =
            Unchecked.defaultof<azurerm.DataFactoryLinkedServiceDataLakeStorageGen2.DataFactoryLinkedServiceDataLakeStorageGen2>

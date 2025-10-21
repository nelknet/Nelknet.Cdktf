namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataFactoryLinkedServiceAzureFileStorageState<'ConnectionString, 'DataFactoryId, 'Name> = { assignments: ResizeArray<azurerm.DataFactoryLinkedServiceAzureFileStorage.DataFactoryLinkedServiceAzureFileStorageConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_file_storage">azurerm_data_factory_linked_service_azure_file_storage</a>.
    /// </summary>
    type DataFactoryLinkedServiceAzureFileStorageBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataFactoryLinkedServiceAzureFileStorageState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataFactoryLinkedServiceAzureFileStorageState<Missing, Missing, Missing>)

        member _.Zero(()) : DataFactoryLinkedServiceAzureFileStorageState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataFactoryLinkedServiceAzureFileStorageState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_file_storage#connection_string-1">DataFactoryLinkedServiceAzureFileStorage#connection_string</a>.
        /// </summary>
        [<CustomOperation "connection_string">]
        member _.ConnectionString(state: DataFactoryLinkedServiceAzureFileStorageState<Missing, 'DataFactoryId, 'Name>, value: string) : DataFactoryLinkedServiceAzureFileStorageState<Present, 'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.ConnectionString <- value)
            ({ assignments = state.assignments } : DataFactoryLinkedServiceAzureFileStorageState<Present, 'DataFactoryId, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_file_storage#data_factory_id-1">DataFactoryLinkedServiceAzureFileStorage#data_factory_id</a>.
        /// </summary>
        [<CustomOperation "data_factory_id">]
        member _.DataFactoryId(state: DataFactoryLinkedServiceAzureFileStorageState<'ConnectionString, Missing, 'Name>, value: string) : DataFactoryLinkedServiceAzureFileStorageState<'ConnectionString, Present, 'Name> =
            state.assignments.Add(fun config -> config.DataFactoryId <- value)
            ({ assignments = state.assignments } : DataFactoryLinkedServiceAzureFileStorageState<'ConnectionString, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_file_storage#name-1">DataFactoryLinkedServiceAzureFileStorage#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataFactoryLinkedServiceAzureFileStorageState<'ConnectionString, 'DataFactoryId, Missing>, value: string) : DataFactoryLinkedServiceAzureFileStorageState<'ConnectionString, 'DataFactoryId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataFactoryLinkedServiceAzureFileStorageState<'ConnectionString, 'DataFactoryId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_file_storage#additional_properties-1">DataFactoryLinkedServiceAzureFileStorage#additional_properties</a>.
        /// </summary>
        [<CustomOperation "additional_properties">]
        member _.AdditionalProperties(state: DataFactoryLinkedServiceAzureFileStorageState<'ConnectionString, 'DataFactoryId, 'Name>, value: seq<string * string>) : DataFactoryLinkedServiceAzureFileStorageState<'ConnectionString, 'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.AdditionalProperties <- dict value)
            state : DataFactoryLinkedServiceAzureFileStorageState<'ConnectionString, 'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_file_storage#annotations-1">DataFactoryLinkedServiceAzureFileStorage#annotations</a>.
        /// </summary>
        [<CustomOperation "annotations">]
        member _.Annotations(state: DataFactoryLinkedServiceAzureFileStorageState<'ConnectionString, 'DataFactoryId, 'Name>, value: seq<string>) : DataFactoryLinkedServiceAzureFileStorageState<'ConnectionString, 'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.Annotations <- (value |> Seq.toArray))
            state : DataFactoryLinkedServiceAzureFileStorageState<'ConnectionString, 'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_file_storage#description-1">DataFactoryLinkedServiceAzureFileStorage#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: DataFactoryLinkedServiceAzureFileStorageState<'ConnectionString, 'DataFactoryId, 'Name>, value: string) : DataFactoryLinkedServiceAzureFileStorageState<'ConnectionString, 'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : DataFactoryLinkedServiceAzureFileStorageState<'ConnectionString, 'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_file_storage#file_share-1">DataFactoryLinkedServiceAzureFileStorage#file_share</a>.
        /// </summary>
        [<CustomOperation "file_share">]
        member _.FileShare(state: DataFactoryLinkedServiceAzureFileStorageState<'ConnectionString, 'DataFactoryId, 'Name>, value: string) : DataFactoryLinkedServiceAzureFileStorageState<'ConnectionString, 'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.FileShare <- value)
            state : DataFactoryLinkedServiceAzureFileStorageState<'ConnectionString, 'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_file_storage#host-1">DataFactoryLinkedServiceAzureFileStorage#host</a>.
        /// </summary>
        [<CustomOperation "host">]
        member _.Host(state: DataFactoryLinkedServiceAzureFileStorageState<'ConnectionString, 'DataFactoryId, 'Name>, value: string) : DataFactoryLinkedServiceAzureFileStorageState<'ConnectionString, 'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.Host <- value)
            state : DataFactoryLinkedServiceAzureFileStorageState<'ConnectionString, 'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_file_storage#id-1">DataFactoryLinkedServiceAzureFileStorage#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataFactoryLinkedServiceAzureFileStorageState<'ConnectionString, 'DataFactoryId, 'Name>, value: string) : DataFactoryLinkedServiceAzureFileStorageState<'ConnectionString, 'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataFactoryLinkedServiceAzureFileStorageState<'ConnectionString, 'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_file_storage#integration_runtime_name-1">DataFactoryLinkedServiceAzureFileStorage#integration_runtime_name</a>.
        /// </summary>
        [<CustomOperation "integration_runtime_name">]
        member _.IntegrationRuntimeName(state: DataFactoryLinkedServiceAzureFileStorageState<'ConnectionString, 'DataFactoryId, 'Name>, value: string) : DataFactoryLinkedServiceAzureFileStorageState<'ConnectionString, 'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.IntegrationRuntimeName <- value)
            state : DataFactoryLinkedServiceAzureFileStorageState<'ConnectionString, 'DataFactoryId, 'Name>

        /// <summary>
        /// key_vault_password block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_file_storage#key_vault_password-1">DataFactoryLinkedServiceAzureFileStorage#key_vault_password</a>
        /// </summary>
        [<CustomOperation "key_vault_password">]
        member _.KeyVaultPassword(state: DataFactoryLinkedServiceAzureFileStorageState<'ConnectionString, 'DataFactoryId, 'Name>, value: azurerm.DataFactoryLinkedServiceAzureFileStorage.DataFactoryLinkedServiceAzureFileStorageKeyVaultPassword) : DataFactoryLinkedServiceAzureFileStorageState<'ConnectionString, 'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.KeyVaultPassword <- value)
            state : DataFactoryLinkedServiceAzureFileStorageState<'ConnectionString, 'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_file_storage#parameters-1">DataFactoryLinkedServiceAzureFileStorage#parameters</a>.
        /// </summary>
        [<CustomOperation "parameters">]
        member _.Parameters(state: DataFactoryLinkedServiceAzureFileStorageState<'ConnectionString, 'DataFactoryId, 'Name>, value: seq<string * string>) : DataFactoryLinkedServiceAzureFileStorageState<'ConnectionString, 'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.Parameters <- dict value)
            state : DataFactoryLinkedServiceAzureFileStorageState<'ConnectionString, 'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_file_storage#password-1">DataFactoryLinkedServiceAzureFileStorage#password</a>.
        /// </summary>
        [<CustomOperation "password">]
        member _.Password(state: DataFactoryLinkedServiceAzureFileStorageState<'ConnectionString, 'DataFactoryId, 'Name>, value: string) : DataFactoryLinkedServiceAzureFileStorageState<'ConnectionString, 'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.Password <- value)
            state : DataFactoryLinkedServiceAzureFileStorageState<'ConnectionString, 'DataFactoryId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_file_storage#timeouts-1">DataFactoryLinkedServiceAzureFileStorage#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataFactoryLinkedServiceAzureFileStorageState<'ConnectionString, 'DataFactoryId, 'Name>, value: azurerm.DataFactoryLinkedServiceAzureFileStorage.DataFactoryLinkedServiceAzureFileStorageTimeouts) : DataFactoryLinkedServiceAzureFileStorageState<'ConnectionString, 'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataFactoryLinkedServiceAzureFileStorageState<'ConnectionString, 'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_file_storage#user_id-1">DataFactoryLinkedServiceAzureFileStorage#user_id</a>.
        /// </summary>
        [<CustomOperation "user_id">]
        member _.UserId(state: DataFactoryLinkedServiceAzureFileStorageState<'ConnectionString, 'DataFactoryId, 'Name>, value: string) : DataFactoryLinkedServiceAzureFileStorageState<'ConnectionString, 'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.UserId <- value)
            state : DataFactoryLinkedServiceAzureFileStorageState<'ConnectionString, 'DataFactoryId, 'Name>

        member _.Run(state: DataFactoryLinkedServiceAzureFileStorageState<Present, Present, Present>) : azurerm.DataFactoryLinkedServiceAzureFileStorage.DataFactoryLinkedServiceAzureFileStorage =
            let config = azurerm.DataFactoryLinkedServiceAzureFileStorage.DataFactoryLinkedServiceAzureFileStorageConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataFactoryLinkedServiceAzureFileStorage.DataFactoryLinkedServiceAzureFileStorage(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataFactoryLinkedServiceAzureFileStorage: missing required arguments. Must call: connection_string, data_factory_id, name.", 9999, IsError = true)>]
        member _.Run(_: DataFactoryLinkedServiceAzureFileStorageState<_, _, _>) : azurerm.DataFactoryLinkedServiceAzureFileStorage.DataFactoryLinkedServiceAzureFileStorage =
            Unchecked.defaultof<azurerm.DataFactoryLinkedServiceAzureFileStorage.DataFactoryLinkedServiceAzureFileStorage>

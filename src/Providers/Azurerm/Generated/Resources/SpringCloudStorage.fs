namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SpringCloudStorageState<'Name, 'SpringCloudServiceId, 'StorageAccountKey, 'StorageAccountName> = { assignments: ResizeArray<azurerm.SpringCloudStorage.SpringCloudStorageConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_storage">azurerm_spring_cloud_storage</a>.
    /// </summary>
    type SpringCloudStorageBuilder(logicalId: string) =
        member _.Yield(_: unit) : SpringCloudStorageState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SpringCloudStorageState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : SpringCloudStorageState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SpringCloudStorageState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_storage#name-1">SpringCloudStorage#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SpringCloudStorageState<Missing, 'SpringCloudServiceId, 'StorageAccountKey, 'StorageAccountName>, value: string) : SpringCloudStorageState<Present, 'SpringCloudServiceId, 'StorageAccountKey, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SpringCloudStorageState<Present, 'SpringCloudServiceId, 'StorageAccountKey, 'StorageAccountName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_storage#spring_cloud_service_id-1">SpringCloudStorage#spring_cloud_service_id</a>.
        /// </summary>
        [<CustomOperation "spring_cloud_service_id">]
        member _.SpringCloudServiceId(state: SpringCloudStorageState<'Name, Missing, 'StorageAccountKey, 'StorageAccountName>, value: string) : SpringCloudStorageState<'Name, Present, 'StorageAccountKey, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.SpringCloudServiceId <- value)
            ({ assignments = state.assignments } : SpringCloudStorageState<'Name, Present, 'StorageAccountKey, 'StorageAccountName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_storage#storage_account_key-1">SpringCloudStorage#storage_account_key</a>.
        /// </summary>
        [<CustomOperation "storage_account_key">]
        member _.StorageAccountKey(state: SpringCloudStorageState<'Name, 'SpringCloudServiceId, Missing, 'StorageAccountName>, value: string) : SpringCloudStorageState<'Name, 'SpringCloudServiceId, Present, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.StorageAccountKey <- value)
            ({ assignments = state.assignments } : SpringCloudStorageState<'Name, 'SpringCloudServiceId, Present, 'StorageAccountName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_storage#storage_account_name-1">SpringCloudStorage#storage_account_name</a>.
        /// </summary>
        [<CustomOperation "storage_account_name">]
        member _.StorageAccountName(state: SpringCloudStorageState<'Name, 'SpringCloudServiceId, 'StorageAccountKey, Missing>, value: string) : SpringCloudStorageState<'Name, 'SpringCloudServiceId, 'StorageAccountKey, Present> =
            state.assignments.Add(fun config -> config.StorageAccountName <- value)
            ({ assignments = state.assignments } : SpringCloudStorageState<'Name, 'SpringCloudServiceId, 'StorageAccountKey, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_storage#id-1">SpringCloudStorage#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SpringCloudStorageState<'Name, 'SpringCloudServiceId, 'StorageAccountKey, 'StorageAccountName>, value: string) : SpringCloudStorageState<'Name, 'SpringCloudServiceId, 'StorageAccountKey, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SpringCloudStorageState<'Name, 'SpringCloudServiceId, 'StorageAccountKey, 'StorageAccountName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_storage#timeouts-1">SpringCloudStorage#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SpringCloudStorageState<'Name, 'SpringCloudServiceId, 'StorageAccountKey, 'StorageAccountName>, value: azurerm.SpringCloudStorage.SpringCloudStorageTimeouts) : SpringCloudStorageState<'Name, 'SpringCloudServiceId, 'StorageAccountKey, 'StorageAccountName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SpringCloudStorageState<'Name, 'SpringCloudServiceId, 'StorageAccountKey, 'StorageAccountName>

        member _.Run(state: SpringCloudStorageState<Present, Present, Present, Present>) : azurerm.SpringCloudStorage.SpringCloudStorage =
            let config = azurerm.SpringCloudStorage.SpringCloudStorageConfig()
            for setter in state.assignments do
                setter config
            azurerm.SpringCloudStorage.SpringCloudStorage(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.springCloudStorage: missing required arguments. Must call: name, spring_cloud_service_id, storage_account_key, storage_account_name.", 9999, IsError = true)>]
        member _.Run(_: SpringCloudStorageState<_, _, _, _>) : azurerm.SpringCloudStorage.SpringCloudStorage =
            Unchecked.defaultof<azurerm.SpringCloudStorage.SpringCloudStorage>

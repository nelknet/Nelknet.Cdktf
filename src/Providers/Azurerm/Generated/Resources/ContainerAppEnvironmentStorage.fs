namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ContainerAppEnvironmentStorageState<'AccessKey, 'AccessMode, 'AccountName, 'ContainerAppEnvironmentId, 'Name, 'ShareName> = { assignments: ResizeArray<azurerm.ContainerAppEnvironmentStorage.ContainerAppEnvironmentStorageConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_environment_storage">azurerm_container_app_environment_storage</a>.
    /// </summary>
    type ContainerAppEnvironmentStorageBuilder(logicalId: string) =
        member _.Yield(_: unit) : ContainerAppEnvironmentStorageState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ContainerAppEnvironmentStorageState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ContainerAppEnvironmentStorageState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ContainerAppEnvironmentStorageState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// The Storage Account Access Key. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_environment_storage#access_key-1">ContainerAppEnvironmentStorage#access_key</a>
        /// </summary>
        [<CustomOperation "access_key">]
        member _.AccessKey(state: ContainerAppEnvironmentStorageState<Missing, 'AccessMode, 'AccountName, 'ContainerAppEnvironmentId, 'Name, 'ShareName>, value: string) : ContainerAppEnvironmentStorageState<Present, 'AccessMode, 'AccountName, 'ContainerAppEnvironmentId, 'Name, 'ShareName> =
            state.assignments.Add(fun config -> config.AccessKey <- value)
            ({ assignments = state.assignments } : ContainerAppEnvironmentStorageState<Present, 'AccessMode, 'AccountName, 'ContainerAppEnvironmentId, 'Name, 'ShareName>)

        /// <summary>
        /// The access mode to connect this storage to the Container App. Possible values include `ReadOnly` and `ReadWrite`. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_environment_storage#access_mode-1">ContainerAppEnvironmentStorage#access_mode</a>
        /// </summary>
        [<CustomOperation "access_mode">]
        member _.AccessMode(state: ContainerAppEnvironmentStorageState<'AccessKey, Missing, 'AccountName, 'ContainerAppEnvironmentId, 'Name, 'ShareName>, value: string) : ContainerAppEnvironmentStorageState<'AccessKey, Present, 'AccountName, 'ContainerAppEnvironmentId, 'Name, 'ShareName> =
            state.assignments.Add(fun config -> config.AccessMode <- value)
            ({ assignments = state.assignments } : ContainerAppEnvironmentStorageState<'AccessKey, Present, 'AccountName, 'ContainerAppEnvironmentId, 'Name, 'ShareName>)

        /// <summary>
        /// The Azure Storage Account in which the Share to be used is located. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_environment_storage#account_name-1">ContainerAppEnvironmentStorage#account_name</a>
        /// </summary>
        [<CustomOperation "account_name">]
        member _.AccountName(state: ContainerAppEnvironmentStorageState<'AccessKey, 'AccessMode, Missing, 'ContainerAppEnvironmentId, 'Name, 'ShareName>, value: string) : ContainerAppEnvironmentStorageState<'AccessKey, 'AccessMode, Present, 'ContainerAppEnvironmentId, 'Name, 'ShareName> =
            state.assignments.Add(fun config -> config.AccountName <- value)
            ({ assignments = state.assignments } : ContainerAppEnvironmentStorageState<'AccessKey, 'AccessMode, Present, 'ContainerAppEnvironmentId, 'Name, 'ShareName>)

        /// <summary>
        /// The ID of the Container App Environment to which this storage belongs. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_environment_storage#container_app_environment_id-1">ContainerAppEnvironmentStorage#container_app_environment_id</a>
        /// </summary>
        [<CustomOperation "container_app_environment_id">]
        member _.ContainerAppEnvironmentId(state: ContainerAppEnvironmentStorageState<'AccessKey, 'AccessMode, 'AccountName, Missing, 'Name, 'ShareName>, value: string) : ContainerAppEnvironmentStorageState<'AccessKey, 'AccessMode, 'AccountName, Present, 'Name, 'ShareName> =
            state.assignments.Add(fun config -> config.ContainerAppEnvironmentId <- value)
            ({ assignments = state.assignments } : ContainerAppEnvironmentStorageState<'AccessKey, 'AccessMode, 'AccountName, Present, 'Name, 'ShareName>)

        /// <summary>
        /// The name for this Storage. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_environment_storage#name-1">ContainerAppEnvironmentStorage#name</a>
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ContainerAppEnvironmentStorageState<'AccessKey, 'AccessMode, 'AccountName, 'ContainerAppEnvironmentId, Missing, 'ShareName>, value: string) : ContainerAppEnvironmentStorageState<'AccessKey, 'AccessMode, 'AccountName, 'ContainerAppEnvironmentId, Present, 'ShareName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ContainerAppEnvironmentStorageState<'AccessKey, 'AccessMode, 'AccountName, 'ContainerAppEnvironmentId, Present, 'ShareName>)

        /// <summary>
        /// The name of the Azure Storage Share to use. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_environment_storage#share_name-1">ContainerAppEnvironmentStorage#share_name</a>
        /// </summary>
        [<CustomOperation "share_name">]
        member _.ShareName(state: ContainerAppEnvironmentStorageState<'AccessKey, 'AccessMode, 'AccountName, 'ContainerAppEnvironmentId, 'Name, Missing>, value: string) : ContainerAppEnvironmentStorageState<'AccessKey, 'AccessMode, 'AccountName, 'ContainerAppEnvironmentId, 'Name, Present> =
            state.assignments.Add(fun config -> config.ShareName <- value)
            ({ assignments = state.assignments } : ContainerAppEnvironmentStorageState<'AccessKey, 'AccessMode, 'AccountName, 'ContainerAppEnvironmentId, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_environment_storage#id-1">ContainerAppEnvironmentStorage#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ContainerAppEnvironmentStorageState<'AccessKey, 'AccessMode, 'AccountName, 'ContainerAppEnvironmentId, 'Name, 'ShareName>, value: string) : ContainerAppEnvironmentStorageState<'AccessKey, 'AccessMode, 'AccountName, 'ContainerAppEnvironmentId, 'Name, 'ShareName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ContainerAppEnvironmentStorageState<'AccessKey, 'AccessMode, 'AccountName, 'ContainerAppEnvironmentId, 'Name, 'ShareName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_environment_storage#timeouts-1">ContainerAppEnvironmentStorage#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ContainerAppEnvironmentStorageState<'AccessKey, 'AccessMode, 'AccountName, 'ContainerAppEnvironmentId, 'Name, 'ShareName>, value: azurerm.ContainerAppEnvironmentStorage.ContainerAppEnvironmentStorageTimeouts) : ContainerAppEnvironmentStorageState<'AccessKey, 'AccessMode, 'AccountName, 'ContainerAppEnvironmentId, 'Name, 'ShareName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ContainerAppEnvironmentStorageState<'AccessKey, 'AccessMode, 'AccountName, 'ContainerAppEnvironmentId, 'Name, 'ShareName>

        member _.Run(state: ContainerAppEnvironmentStorageState<Present, Present, Present, Present, Present, Present>) : azurerm.ContainerAppEnvironmentStorage.ContainerAppEnvironmentStorage =
            let config = azurerm.ContainerAppEnvironmentStorage.ContainerAppEnvironmentStorageConfig()
            for setter in state.assignments do
                setter config
            azurerm.ContainerAppEnvironmentStorage.ContainerAppEnvironmentStorage(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.containerAppEnvironmentStorage: missing required arguments. Must call: access_key, access_mode, account_name, container_app_environment_id, name, share_name.", 9999, IsError = true)>]
        member _.Run(_: ContainerAppEnvironmentStorageState<_, _, _, _, _, _>) : azurerm.ContainerAppEnvironmentStorage.ContainerAppEnvironmentStorage =
            Unchecked.defaultof<azurerm.ContainerAppEnvironmentStorage.ContainerAppEnvironmentStorage>

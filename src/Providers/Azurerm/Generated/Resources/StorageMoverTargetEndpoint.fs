namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type StorageMoverTargetEndpointState<'Name, 'StorageAccountId, 'StorageContainerName, 'StorageMoverId> = { assignments: ResizeArray<azurerm.StorageMoverTargetEndpoint.StorageMoverTargetEndpointConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_mover_target_endpoint">azurerm_storage_mover_target_endpoint</a>.
    /// </summary>
    type StorageMoverTargetEndpointBuilder(logicalId: string) =
        member _.Yield(_: unit) : StorageMoverTargetEndpointState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : StorageMoverTargetEndpointState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : StorageMoverTargetEndpointState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : StorageMoverTargetEndpointState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_mover_target_endpoint#name-1">StorageMoverTargetEndpoint#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: StorageMoverTargetEndpointState<Missing, 'StorageAccountId, 'StorageContainerName, 'StorageMoverId>, value: string) : StorageMoverTargetEndpointState<Present, 'StorageAccountId, 'StorageContainerName, 'StorageMoverId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : StorageMoverTargetEndpointState<Present, 'StorageAccountId, 'StorageContainerName, 'StorageMoverId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_mover_target_endpoint#storage_account_id-1">StorageMoverTargetEndpoint#storage_account_id</a>.
        /// </summary>
        [<CustomOperation "storage_account_id">]
        member _.StorageAccountId(state: StorageMoverTargetEndpointState<'Name, Missing, 'StorageContainerName, 'StorageMoverId>, value: string) : StorageMoverTargetEndpointState<'Name, Present, 'StorageContainerName, 'StorageMoverId> =
            state.assignments.Add(fun config -> config.StorageAccountId <- value)
            ({ assignments = state.assignments } : StorageMoverTargetEndpointState<'Name, Present, 'StorageContainerName, 'StorageMoverId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_mover_target_endpoint#storage_container_name-1">StorageMoverTargetEndpoint#storage_container_name</a>.
        /// </summary>
        [<CustomOperation "storage_container_name">]
        member _.StorageContainerName(state: StorageMoverTargetEndpointState<'Name, 'StorageAccountId, Missing, 'StorageMoverId>, value: string) : StorageMoverTargetEndpointState<'Name, 'StorageAccountId, Present, 'StorageMoverId> =
            state.assignments.Add(fun config -> config.StorageContainerName <- value)
            ({ assignments = state.assignments } : StorageMoverTargetEndpointState<'Name, 'StorageAccountId, Present, 'StorageMoverId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_mover_target_endpoint#storage_mover_id-1">StorageMoverTargetEndpoint#storage_mover_id</a>.
        /// </summary>
        [<CustomOperation "storage_mover_id">]
        member _.StorageMoverId(state: StorageMoverTargetEndpointState<'Name, 'StorageAccountId, 'StorageContainerName, Missing>, value: string) : StorageMoverTargetEndpointState<'Name, 'StorageAccountId, 'StorageContainerName, Present> =
            state.assignments.Add(fun config -> config.StorageMoverId <- value)
            ({ assignments = state.assignments } : StorageMoverTargetEndpointState<'Name, 'StorageAccountId, 'StorageContainerName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_mover_target_endpoint#description-1">StorageMoverTargetEndpoint#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: StorageMoverTargetEndpointState<'Name, 'StorageAccountId, 'StorageContainerName, 'StorageMoverId>, value: string) : StorageMoverTargetEndpointState<'Name, 'StorageAccountId, 'StorageContainerName, 'StorageMoverId> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : StorageMoverTargetEndpointState<'Name, 'StorageAccountId, 'StorageContainerName, 'StorageMoverId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_mover_target_endpoint#id-1">StorageMoverTargetEndpoint#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: StorageMoverTargetEndpointState<'Name, 'StorageAccountId, 'StorageContainerName, 'StorageMoverId>, value: string) : StorageMoverTargetEndpointState<'Name, 'StorageAccountId, 'StorageContainerName, 'StorageMoverId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : StorageMoverTargetEndpointState<'Name, 'StorageAccountId, 'StorageContainerName, 'StorageMoverId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_mover_target_endpoint#timeouts-1">StorageMoverTargetEndpoint#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: StorageMoverTargetEndpointState<'Name, 'StorageAccountId, 'StorageContainerName, 'StorageMoverId>, value: azurerm.StorageMoverTargetEndpoint.StorageMoverTargetEndpointTimeouts) : StorageMoverTargetEndpointState<'Name, 'StorageAccountId, 'StorageContainerName, 'StorageMoverId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : StorageMoverTargetEndpointState<'Name, 'StorageAccountId, 'StorageContainerName, 'StorageMoverId>

        member _.Run(state: StorageMoverTargetEndpointState<Present, Present, Present, Present>) : azurerm.StorageMoverTargetEndpoint.StorageMoverTargetEndpoint =
            let config = azurerm.StorageMoverTargetEndpoint.StorageMoverTargetEndpointConfig()
            for setter in state.assignments do
                setter config
            azurerm.StorageMoverTargetEndpoint.StorageMoverTargetEndpoint(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.storageMoverTargetEndpoint: missing required arguments. Must call: name, storage_account_id, storage_container_name, storage_mover_id.", 9999, IsError = true)>]
        member _.Run(_: StorageMoverTargetEndpointState<_, _, _, _>) : azurerm.StorageMoverTargetEndpoint.StorageMoverTargetEndpoint =
            Unchecked.defaultof<azurerm.StorageMoverTargetEndpoint.StorageMoverTargetEndpoint>

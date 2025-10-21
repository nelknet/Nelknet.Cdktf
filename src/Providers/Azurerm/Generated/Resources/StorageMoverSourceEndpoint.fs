namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type StorageMoverSourceEndpointState<'Host, 'Name, 'StorageMoverId> = { assignments: ResizeArray<azurerm.StorageMoverSourceEndpoint.StorageMoverSourceEndpointConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_mover_source_endpoint">azurerm_storage_mover_source_endpoint</a>.
    /// </summary>
    type StorageMoverSourceEndpointBuilder(logicalId: string) =
        member _.Yield(_: unit) : StorageMoverSourceEndpointState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : StorageMoverSourceEndpointState<Missing, Missing, Missing>)

        member _.Zero(()) : StorageMoverSourceEndpointState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : StorageMoverSourceEndpointState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_mover_source_endpoint#host-1">StorageMoverSourceEndpoint#host</a>.
        /// </summary>
        [<CustomOperation "host">]
        member _.Host(state: StorageMoverSourceEndpointState<Missing, 'Name, 'StorageMoverId>, value: string) : StorageMoverSourceEndpointState<Present, 'Name, 'StorageMoverId> =
            state.assignments.Add(fun config -> config.Host <- value)
            ({ assignments = state.assignments } : StorageMoverSourceEndpointState<Present, 'Name, 'StorageMoverId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_mover_source_endpoint#name-1">StorageMoverSourceEndpoint#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: StorageMoverSourceEndpointState<'Host, Missing, 'StorageMoverId>, value: string) : StorageMoverSourceEndpointState<'Host, Present, 'StorageMoverId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : StorageMoverSourceEndpointState<'Host, Present, 'StorageMoverId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_mover_source_endpoint#storage_mover_id-1">StorageMoverSourceEndpoint#storage_mover_id</a>.
        /// </summary>
        [<CustomOperation "storage_mover_id">]
        member _.StorageMoverId(state: StorageMoverSourceEndpointState<'Host, 'Name, Missing>, value: string) : StorageMoverSourceEndpointState<'Host, 'Name, Present> =
            state.assignments.Add(fun config -> config.StorageMoverId <- value)
            ({ assignments = state.assignments } : StorageMoverSourceEndpointState<'Host, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_mover_source_endpoint#description-1">StorageMoverSourceEndpoint#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: StorageMoverSourceEndpointState<'Host, 'Name, 'StorageMoverId>, value: string) : StorageMoverSourceEndpointState<'Host, 'Name, 'StorageMoverId> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : StorageMoverSourceEndpointState<'Host, 'Name, 'StorageMoverId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_mover_source_endpoint#export-1">StorageMoverSourceEndpoint#export</a>.
        /// </summary>
        [<CustomOperation "export">]
        member _.Export(state: StorageMoverSourceEndpointState<'Host, 'Name, 'StorageMoverId>, value: string) : StorageMoverSourceEndpointState<'Host, 'Name, 'StorageMoverId> =
            state.assignments.Add(fun config -> config.Export <- value)
            state : StorageMoverSourceEndpointState<'Host, 'Name, 'StorageMoverId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_mover_source_endpoint#id-1">StorageMoverSourceEndpoint#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: StorageMoverSourceEndpointState<'Host, 'Name, 'StorageMoverId>, value: string) : StorageMoverSourceEndpointState<'Host, 'Name, 'StorageMoverId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : StorageMoverSourceEndpointState<'Host, 'Name, 'StorageMoverId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_mover_source_endpoint#nfs_version-1">StorageMoverSourceEndpoint#nfs_version</a>.
        /// </summary>
        [<CustomOperation "nfs_version">]
        member _.NfsVersion(state: StorageMoverSourceEndpointState<'Host, 'Name, 'StorageMoverId>, value: string) : StorageMoverSourceEndpointState<'Host, 'Name, 'StorageMoverId> =
            state.assignments.Add(fun config -> config.NfsVersion <- value)
            state : StorageMoverSourceEndpointState<'Host, 'Name, 'StorageMoverId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_mover_source_endpoint#timeouts-1">StorageMoverSourceEndpoint#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: StorageMoverSourceEndpointState<'Host, 'Name, 'StorageMoverId>, value: azurerm.StorageMoverSourceEndpoint.StorageMoverSourceEndpointTimeouts) : StorageMoverSourceEndpointState<'Host, 'Name, 'StorageMoverId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : StorageMoverSourceEndpointState<'Host, 'Name, 'StorageMoverId>

        member _.Run(state: StorageMoverSourceEndpointState<Present, Present, Present>) : azurerm.StorageMoverSourceEndpoint.StorageMoverSourceEndpoint =
            let config = azurerm.StorageMoverSourceEndpoint.StorageMoverSourceEndpointConfig()
            for setter in state.assignments do
                setter config
            azurerm.StorageMoverSourceEndpoint.StorageMoverSourceEndpoint(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.storageMoverSourceEndpoint: missing required arguments. Must call: host, name, storage_mover_id.", 9999, IsError = true)>]
        member _.Run(_: StorageMoverSourceEndpointState<_, _, _>) : azurerm.StorageMoverSourceEndpoint.StorageMoverSourceEndpoint =
            Unchecked.defaultof<azurerm.StorageMoverSourceEndpoint.StorageMoverSourceEndpoint>

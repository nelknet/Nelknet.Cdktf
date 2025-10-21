namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type StorageMoverProjectState<'Name, 'StorageMoverId> = { assignments: ResizeArray<azurerm.StorageMoverProject.StorageMoverProjectConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_mover_project">azurerm_storage_mover_project</a>.
    /// </summary>
    type StorageMoverProjectBuilder(logicalId: string) =
        member _.Yield(_: unit) : StorageMoverProjectState<Missing, Missing> =
            ({ assignments = ResizeArray() } : StorageMoverProjectState<Missing, Missing>)

        member _.Zero(()) : StorageMoverProjectState<Missing, Missing> =
            ({ assignments = ResizeArray() } : StorageMoverProjectState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_mover_project#name-1">StorageMoverProject#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: StorageMoverProjectState<Missing, 'StorageMoverId>, value: string) : StorageMoverProjectState<Present, 'StorageMoverId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : StorageMoverProjectState<Present, 'StorageMoverId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_mover_project#storage_mover_id-1">StorageMoverProject#storage_mover_id</a>.
        /// </summary>
        [<CustomOperation "storage_mover_id">]
        member _.StorageMoverId(state: StorageMoverProjectState<'Name, Missing>, value: string) : StorageMoverProjectState<'Name, Present> =
            state.assignments.Add(fun config -> config.StorageMoverId <- value)
            ({ assignments = state.assignments } : StorageMoverProjectState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_mover_project#description-1">StorageMoverProject#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: StorageMoverProjectState<'Name, 'StorageMoverId>, value: string) : StorageMoverProjectState<'Name, 'StorageMoverId> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : StorageMoverProjectState<'Name, 'StorageMoverId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_mover_project#id-1">StorageMoverProject#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: StorageMoverProjectState<'Name, 'StorageMoverId>, value: string) : StorageMoverProjectState<'Name, 'StorageMoverId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : StorageMoverProjectState<'Name, 'StorageMoverId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_mover_project#timeouts-1">StorageMoverProject#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: StorageMoverProjectState<'Name, 'StorageMoverId>, value: azurerm.StorageMoverProject.StorageMoverProjectTimeouts) : StorageMoverProjectState<'Name, 'StorageMoverId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : StorageMoverProjectState<'Name, 'StorageMoverId>

        member _.Run(state: StorageMoverProjectState<Present, Present>) : azurerm.StorageMoverProject.StorageMoverProject =
            let config = azurerm.StorageMoverProject.StorageMoverProjectConfig()
            for setter in state.assignments do
                setter config
            azurerm.StorageMoverProject.StorageMoverProject(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.storageMoverProject: missing required arguments. Must call: name, storage_mover_id.", 9999, IsError = true)>]
        member _.Run(_: StorageMoverProjectState<_, _>) : azurerm.StorageMoverProject.StorageMoverProject =
            Unchecked.defaultof<azurerm.StorageMoverProject.StorageMoverProject>

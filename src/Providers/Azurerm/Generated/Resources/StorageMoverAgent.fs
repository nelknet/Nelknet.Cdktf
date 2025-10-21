namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type StorageMoverAgentState<'ArcVirtualMachineId, 'ArcVirtualMachineUuid, 'Name, 'StorageMoverId> = { assignments: ResizeArray<azurerm.StorageMoverAgent.StorageMoverAgentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_mover_agent">azurerm_storage_mover_agent</a>.
    /// </summary>
    type StorageMoverAgentBuilder(logicalId: string) =
        member _.Yield(_: unit) : StorageMoverAgentState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : StorageMoverAgentState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : StorageMoverAgentState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : StorageMoverAgentState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_mover_agent#arc_virtual_machine_id-1">StorageMoverAgent#arc_virtual_machine_id</a>.
        /// </summary>
        [<CustomOperation "arc_virtual_machine_id">]
        member _.ArcVirtualMachineId(state: StorageMoverAgentState<Missing, 'ArcVirtualMachineUuid, 'Name, 'StorageMoverId>, value: string) : StorageMoverAgentState<Present, 'ArcVirtualMachineUuid, 'Name, 'StorageMoverId> =
            state.assignments.Add(fun config -> config.ArcVirtualMachineId <- value)
            ({ assignments = state.assignments } : StorageMoverAgentState<Present, 'ArcVirtualMachineUuid, 'Name, 'StorageMoverId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_mover_agent#arc_virtual_machine_uuid-1">StorageMoverAgent#arc_virtual_machine_uuid</a>.
        /// </summary>
        [<CustomOperation "arc_virtual_machine_uuid">]
        member _.ArcVirtualMachineUuid(state: StorageMoverAgentState<'ArcVirtualMachineId, Missing, 'Name, 'StorageMoverId>, value: string) : StorageMoverAgentState<'ArcVirtualMachineId, Present, 'Name, 'StorageMoverId> =
            state.assignments.Add(fun config -> config.ArcVirtualMachineUuid <- value)
            ({ assignments = state.assignments } : StorageMoverAgentState<'ArcVirtualMachineId, Present, 'Name, 'StorageMoverId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_mover_agent#name-1">StorageMoverAgent#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: StorageMoverAgentState<'ArcVirtualMachineId, 'ArcVirtualMachineUuid, Missing, 'StorageMoverId>, value: string) : StorageMoverAgentState<'ArcVirtualMachineId, 'ArcVirtualMachineUuid, Present, 'StorageMoverId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : StorageMoverAgentState<'ArcVirtualMachineId, 'ArcVirtualMachineUuid, Present, 'StorageMoverId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_mover_agent#storage_mover_id-1">StorageMoverAgent#storage_mover_id</a>.
        /// </summary>
        [<CustomOperation "storage_mover_id">]
        member _.StorageMoverId(state: StorageMoverAgentState<'ArcVirtualMachineId, 'ArcVirtualMachineUuid, 'Name, Missing>, value: string) : StorageMoverAgentState<'ArcVirtualMachineId, 'ArcVirtualMachineUuid, 'Name, Present> =
            state.assignments.Add(fun config -> config.StorageMoverId <- value)
            ({ assignments = state.assignments } : StorageMoverAgentState<'ArcVirtualMachineId, 'ArcVirtualMachineUuid, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_mover_agent#description-1">StorageMoverAgent#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: StorageMoverAgentState<'ArcVirtualMachineId, 'ArcVirtualMachineUuid, 'Name, 'StorageMoverId>, value: string) : StorageMoverAgentState<'ArcVirtualMachineId, 'ArcVirtualMachineUuid, 'Name, 'StorageMoverId> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : StorageMoverAgentState<'ArcVirtualMachineId, 'ArcVirtualMachineUuid, 'Name, 'StorageMoverId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_mover_agent#id-1">StorageMoverAgent#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: StorageMoverAgentState<'ArcVirtualMachineId, 'ArcVirtualMachineUuid, 'Name, 'StorageMoverId>, value: string) : StorageMoverAgentState<'ArcVirtualMachineId, 'ArcVirtualMachineUuid, 'Name, 'StorageMoverId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : StorageMoverAgentState<'ArcVirtualMachineId, 'ArcVirtualMachineUuid, 'Name, 'StorageMoverId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_mover_agent#timeouts-1">StorageMoverAgent#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: StorageMoverAgentState<'ArcVirtualMachineId, 'ArcVirtualMachineUuid, 'Name, 'StorageMoverId>, value: azurerm.StorageMoverAgent.StorageMoverAgentTimeouts) : StorageMoverAgentState<'ArcVirtualMachineId, 'ArcVirtualMachineUuid, 'Name, 'StorageMoverId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : StorageMoverAgentState<'ArcVirtualMachineId, 'ArcVirtualMachineUuid, 'Name, 'StorageMoverId>

        member _.Run(state: StorageMoverAgentState<Present, Present, Present, Present>) : azurerm.StorageMoverAgent.StorageMoverAgent =
            let config = azurerm.StorageMoverAgent.StorageMoverAgentConfig()
            for setter in state.assignments do
                setter config
            azurerm.StorageMoverAgent.StorageMoverAgent(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.storageMoverAgent: missing required arguments. Must call: arc_virtual_machine_id, arc_virtual_machine_uuid, name, storage_mover_id.", 9999, IsError = true)>]
        member _.Run(_: StorageMoverAgentState<_, _, _, _>) : azurerm.StorageMoverAgent.StorageMoverAgent =
            Unchecked.defaultof<azurerm.StorageMoverAgent.StorageMoverAgent>

namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VirtualMachineRestorePointState<'Name, 'VirtualMachineRestorePointCollectionId> = { assignments: ResizeArray<azurerm.VirtualMachineRestorePoint.VirtualMachineRestorePointConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_restore_point">azurerm_virtual_machine_restore_point</a>.
    /// </summary>
    type VirtualMachineRestorePointBuilder(logicalId: string) =
        member _.Yield(_: unit) : VirtualMachineRestorePointState<Missing, Missing> =
            ({ assignments = ResizeArray() } : VirtualMachineRestorePointState<Missing, Missing>)

        member _.Zero(()) : VirtualMachineRestorePointState<Missing, Missing> =
            ({ assignments = ResizeArray() } : VirtualMachineRestorePointState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_restore_point#name-1">VirtualMachineRestorePoint#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: VirtualMachineRestorePointState<Missing, 'VirtualMachineRestorePointCollectionId>, value: string) : VirtualMachineRestorePointState<Present, 'VirtualMachineRestorePointCollectionId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : VirtualMachineRestorePointState<Present, 'VirtualMachineRestorePointCollectionId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_restore_point#virtual_machine_restore_point_collection_id-1">VirtualMachineRestorePoint#virtual_machine_restore_point_collection_id</a>.
        /// </summary>
        [<CustomOperation "virtual_machine_restore_point_collection_id">]
        member _.VirtualMachineRestorePointCollectionId(state: VirtualMachineRestorePointState<'Name, Missing>, value: string) : VirtualMachineRestorePointState<'Name, Present> =
            state.assignments.Add(fun config -> config.VirtualMachineRestorePointCollectionId <- value)
            ({ assignments = state.assignments } : VirtualMachineRestorePointState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_restore_point#crash_consistency_mode_enabled-1">VirtualMachineRestorePoint#crash_consistency_mode_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "crash_consistency_mode_enabled">]
        member _.CrashConsistencyModeEnabled(state: VirtualMachineRestorePointState<'Name, 'VirtualMachineRestorePointCollectionId>, value: bool) : VirtualMachineRestorePointState<'Name, 'VirtualMachineRestorePointCollectionId> =
            state.assignments.Add(fun config -> config.CrashConsistencyModeEnabled <- value)
            state : VirtualMachineRestorePointState<'Name, 'VirtualMachineRestorePointCollectionId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_restore_point#crash_consistency_mode_enabled-1">VirtualMachineRestorePoint#crash_consistency_mode_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "crash_consistency_mode_enabled">]
        member _.CrashConsistencyModeEnabled(state: VirtualMachineRestorePointState<'Name, 'VirtualMachineRestorePointCollectionId>, value: HashiCorp.Cdktf.IResolvable) : VirtualMachineRestorePointState<'Name, 'VirtualMachineRestorePointCollectionId> =
            state.assignments.Add(fun config -> config.CrashConsistencyModeEnabled <- value)
            state : VirtualMachineRestorePointState<'Name, 'VirtualMachineRestorePointCollectionId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_restore_point#excluded_disks-1">VirtualMachineRestorePoint#excluded_disks</a>.
        /// </summary>
        [<CustomOperation "excluded_disks">]
        member _.ExcludedDisks(state: VirtualMachineRestorePointState<'Name, 'VirtualMachineRestorePointCollectionId>, value: seq<string>) : VirtualMachineRestorePointState<'Name, 'VirtualMachineRestorePointCollectionId> =
            state.assignments.Add(fun config -> config.ExcludedDisks <- (value |> Seq.toArray))
            state : VirtualMachineRestorePointState<'Name, 'VirtualMachineRestorePointCollectionId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_restore_point#id-1">VirtualMachineRestorePoint#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VirtualMachineRestorePointState<'Name, 'VirtualMachineRestorePointCollectionId>, value: string) : VirtualMachineRestorePointState<'Name, 'VirtualMachineRestorePointCollectionId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VirtualMachineRestorePointState<'Name, 'VirtualMachineRestorePointCollectionId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_restore_point#timeouts-1">VirtualMachineRestorePoint#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: VirtualMachineRestorePointState<'Name, 'VirtualMachineRestorePointCollectionId>, value: azurerm.VirtualMachineRestorePoint.VirtualMachineRestorePointTimeouts) : VirtualMachineRestorePointState<'Name, 'VirtualMachineRestorePointCollectionId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : VirtualMachineRestorePointState<'Name, 'VirtualMachineRestorePointCollectionId>

        member _.Run(state: VirtualMachineRestorePointState<Present, Present>) : azurerm.VirtualMachineRestorePoint.VirtualMachineRestorePoint =
            let config = azurerm.VirtualMachineRestorePoint.VirtualMachineRestorePointConfig()
            for setter in state.assignments do
                setter config
            azurerm.VirtualMachineRestorePoint.VirtualMachineRestorePoint(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.virtualMachineRestorePoint: missing required arguments. Must call: name, virtual_machine_restore_point_collection_id.", 9999, IsError = true)>]
        member _.Run(_: VirtualMachineRestorePointState<_, _>) : azurerm.VirtualMachineRestorePoint.VirtualMachineRestorePoint =
            Unchecked.defaultof<azurerm.VirtualMachineRestorePoint.VirtualMachineRestorePoint>

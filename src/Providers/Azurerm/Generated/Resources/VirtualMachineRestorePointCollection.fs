namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VirtualMachineRestorePointCollectionState<'Location, 'Name, 'ResourceGroupName, 'SourceVirtualMachineId> = { assignments: ResizeArray<azurerm.VirtualMachineRestorePointCollection.VirtualMachineRestorePointCollectionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_restore_point_collection">azurerm_virtual_machine_restore_point_collection</a>.
    /// </summary>
    type VirtualMachineRestorePointCollectionBuilder(logicalId: string) =
        member _.Yield(_: unit) : VirtualMachineRestorePointCollectionState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : VirtualMachineRestorePointCollectionState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : VirtualMachineRestorePointCollectionState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : VirtualMachineRestorePointCollectionState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_restore_point_collection#location-1">VirtualMachineRestorePointCollection#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: VirtualMachineRestorePointCollectionState<Missing, 'Name, 'ResourceGroupName, 'SourceVirtualMachineId>, value: string) : VirtualMachineRestorePointCollectionState<Present, 'Name, 'ResourceGroupName, 'SourceVirtualMachineId> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : VirtualMachineRestorePointCollectionState<Present, 'Name, 'ResourceGroupName, 'SourceVirtualMachineId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_restore_point_collection#name-1">VirtualMachineRestorePointCollection#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: VirtualMachineRestorePointCollectionState<'Location, Missing, 'ResourceGroupName, 'SourceVirtualMachineId>, value: string) : VirtualMachineRestorePointCollectionState<'Location, Present, 'ResourceGroupName, 'SourceVirtualMachineId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : VirtualMachineRestorePointCollectionState<'Location, Present, 'ResourceGroupName, 'SourceVirtualMachineId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_restore_point_collection#resource_group_name-1">VirtualMachineRestorePointCollection#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: VirtualMachineRestorePointCollectionState<'Location, 'Name, Missing, 'SourceVirtualMachineId>, value: string) : VirtualMachineRestorePointCollectionState<'Location, 'Name, Present, 'SourceVirtualMachineId> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : VirtualMachineRestorePointCollectionState<'Location, 'Name, Present, 'SourceVirtualMachineId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_restore_point_collection#source_virtual_machine_id-1">VirtualMachineRestorePointCollection#source_virtual_machine_id</a>.
        /// </summary>
        [<CustomOperation "source_virtual_machine_id">]
        member _.SourceVirtualMachineId(state: VirtualMachineRestorePointCollectionState<'Location, 'Name, 'ResourceGroupName, Missing>, value: string) : VirtualMachineRestorePointCollectionState<'Location, 'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.SourceVirtualMachineId <- value)
            ({ assignments = state.assignments } : VirtualMachineRestorePointCollectionState<'Location, 'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_restore_point_collection#id-1">VirtualMachineRestorePointCollection#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VirtualMachineRestorePointCollectionState<'Location, 'Name, 'ResourceGroupName, 'SourceVirtualMachineId>, value: string) : VirtualMachineRestorePointCollectionState<'Location, 'Name, 'ResourceGroupName, 'SourceVirtualMachineId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VirtualMachineRestorePointCollectionState<'Location, 'Name, 'ResourceGroupName, 'SourceVirtualMachineId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_restore_point_collection#tags-1">VirtualMachineRestorePointCollection#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: VirtualMachineRestorePointCollectionState<'Location, 'Name, 'ResourceGroupName, 'SourceVirtualMachineId>, value: seq<string * string>) : VirtualMachineRestorePointCollectionState<'Location, 'Name, 'ResourceGroupName, 'SourceVirtualMachineId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : VirtualMachineRestorePointCollectionState<'Location, 'Name, 'ResourceGroupName, 'SourceVirtualMachineId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_restore_point_collection#timeouts-1">VirtualMachineRestorePointCollection#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: VirtualMachineRestorePointCollectionState<'Location, 'Name, 'ResourceGroupName, 'SourceVirtualMachineId>, value: azurerm.VirtualMachineRestorePointCollection.VirtualMachineRestorePointCollectionTimeouts) : VirtualMachineRestorePointCollectionState<'Location, 'Name, 'ResourceGroupName, 'SourceVirtualMachineId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : VirtualMachineRestorePointCollectionState<'Location, 'Name, 'ResourceGroupName, 'SourceVirtualMachineId>

        member _.Run(state: VirtualMachineRestorePointCollectionState<Present, Present, Present, Present>) : azurerm.VirtualMachineRestorePointCollection.VirtualMachineRestorePointCollection =
            let config = azurerm.VirtualMachineRestorePointCollection.VirtualMachineRestorePointCollectionConfig()
            for setter in state.assignments do
                setter config
            azurerm.VirtualMachineRestorePointCollection.VirtualMachineRestorePointCollection(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.virtualMachineRestorePointCollection: missing required arguments. Must call: location, name, resource_group_name, source_virtual_machine_id.", 9999, IsError = true)>]
        member _.Run(_: VirtualMachineRestorePointCollectionState<_, _, _, _>) : azurerm.VirtualMachineRestorePointCollection.VirtualMachineRestorePointCollection =
            Unchecked.defaultof<azurerm.VirtualMachineRestorePointCollection.VirtualMachineRestorePointCollection>

namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type RestorePointCollectionState<'Location, 'Name, 'ResourceGroupName, 'SourceVirtualMachineId> = { assignments: ResizeArray<azurerm.RestorePointCollection.RestorePointCollectionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/restore_point_collection">azurerm_restore_point_collection</a>.
    /// </summary>
    type RestorePointCollectionBuilder(logicalId: string) =
        member _.Yield(_: unit) : RestorePointCollectionState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : RestorePointCollectionState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : RestorePointCollectionState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : RestorePointCollectionState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/restore_point_collection#location-1">RestorePointCollection#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: RestorePointCollectionState<Missing, 'Name, 'ResourceGroupName, 'SourceVirtualMachineId>, value: string) : RestorePointCollectionState<Present, 'Name, 'ResourceGroupName, 'SourceVirtualMachineId> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : RestorePointCollectionState<Present, 'Name, 'ResourceGroupName, 'SourceVirtualMachineId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/restore_point_collection#name-1">RestorePointCollection#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: RestorePointCollectionState<'Location, Missing, 'ResourceGroupName, 'SourceVirtualMachineId>, value: string) : RestorePointCollectionState<'Location, Present, 'ResourceGroupName, 'SourceVirtualMachineId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : RestorePointCollectionState<'Location, Present, 'ResourceGroupName, 'SourceVirtualMachineId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/restore_point_collection#resource_group_name-1">RestorePointCollection#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: RestorePointCollectionState<'Location, 'Name, Missing, 'SourceVirtualMachineId>, value: string) : RestorePointCollectionState<'Location, 'Name, Present, 'SourceVirtualMachineId> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : RestorePointCollectionState<'Location, 'Name, Present, 'SourceVirtualMachineId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/restore_point_collection#source_virtual_machine_id-1">RestorePointCollection#source_virtual_machine_id</a>.
        /// </summary>
        [<CustomOperation "source_virtual_machine_id">]
        member _.SourceVirtualMachineId(state: RestorePointCollectionState<'Location, 'Name, 'ResourceGroupName, Missing>, value: string) : RestorePointCollectionState<'Location, 'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.SourceVirtualMachineId <- value)
            ({ assignments = state.assignments } : RestorePointCollectionState<'Location, 'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/restore_point_collection#id-1">RestorePointCollection#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: RestorePointCollectionState<'Location, 'Name, 'ResourceGroupName, 'SourceVirtualMachineId>, value: string) : RestorePointCollectionState<'Location, 'Name, 'ResourceGroupName, 'SourceVirtualMachineId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : RestorePointCollectionState<'Location, 'Name, 'ResourceGroupName, 'SourceVirtualMachineId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/restore_point_collection#tags-1">RestorePointCollection#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: RestorePointCollectionState<'Location, 'Name, 'ResourceGroupName, 'SourceVirtualMachineId>, value: seq<string * string>) : RestorePointCollectionState<'Location, 'Name, 'ResourceGroupName, 'SourceVirtualMachineId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : RestorePointCollectionState<'Location, 'Name, 'ResourceGroupName, 'SourceVirtualMachineId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/restore_point_collection#timeouts-1">RestorePointCollection#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: RestorePointCollectionState<'Location, 'Name, 'ResourceGroupName, 'SourceVirtualMachineId>, value: azurerm.RestorePointCollection.RestorePointCollectionTimeouts) : RestorePointCollectionState<'Location, 'Name, 'ResourceGroupName, 'SourceVirtualMachineId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : RestorePointCollectionState<'Location, 'Name, 'ResourceGroupName, 'SourceVirtualMachineId>

        member _.Run(state: RestorePointCollectionState<Present, Present, Present, Present>) : azurerm.RestorePointCollection.RestorePointCollection =
            let config = azurerm.RestorePointCollection.RestorePointCollectionConfig()
            for setter in state.assignments do
                setter config
            azurerm.RestorePointCollection.RestorePointCollection(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.restorePointCollection: missing required arguments. Must call: location, name, resource_group_name, source_virtual_machine_id.", 9999, IsError = true)>]
        member _.Run(_: RestorePointCollectionState<_, _, _, _>) : azurerm.RestorePointCollection.RestorePointCollection =
            Unchecked.defaultof<azurerm.RestorePointCollection.RestorePointCollection>

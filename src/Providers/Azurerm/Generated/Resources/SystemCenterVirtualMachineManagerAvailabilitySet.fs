namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SystemCenterVirtualMachineManagerAvailabilitySetState<'CustomLocationId, 'Location, 'Name, 'ResourceGroupName, 'SystemCenterVirtualMachineManagerServerId> = { assignments: ResizeArray<azurerm.SystemCenterVirtualMachineManagerAvailabilitySet.SystemCenterVirtualMachineManagerAvailabilitySetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/system_center_virtual_machine_manager_availability_set">azurerm_system_center_virtual_machine_manager_availability_set</a>.
    /// </summary>
    type SystemCenterVirtualMachineManagerAvailabilitySetBuilder(logicalId: string) =
        member _.Yield(_: unit) : SystemCenterVirtualMachineManagerAvailabilitySetState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SystemCenterVirtualMachineManagerAvailabilitySetState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : SystemCenterVirtualMachineManagerAvailabilitySetState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SystemCenterVirtualMachineManagerAvailabilitySetState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/system_center_virtual_machine_manager_availability_set#custom_location_id-1">SystemCenterVirtualMachineManagerAvailabilitySet#custom_location_id</a>.
        /// </summary>
        [<CustomOperation "custom_location_id">]
        member _.CustomLocationId(state: SystemCenterVirtualMachineManagerAvailabilitySetState<Missing, 'Location, 'Name, 'ResourceGroupName, 'SystemCenterVirtualMachineManagerServerId>, value: string) : SystemCenterVirtualMachineManagerAvailabilitySetState<Present, 'Location, 'Name, 'ResourceGroupName, 'SystemCenterVirtualMachineManagerServerId> =
            state.assignments.Add(fun config -> config.CustomLocationId <- value)
            ({ assignments = state.assignments } : SystemCenterVirtualMachineManagerAvailabilitySetState<Present, 'Location, 'Name, 'ResourceGroupName, 'SystemCenterVirtualMachineManagerServerId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/system_center_virtual_machine_manager_availability_set#location-1">SystemCenterVirtualMachineManagerAvailabilitySet#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: SystemCenterVirtualMachineManagerAvailabilitySetState<'CustomLocationId, Missing, 'Name, 'ResourceGroupName, 'SystemCenterVirtualMachineManagerServerId>, value: string) : SystemCenterVirtualMachineManagerAvailabilitySetState<'CustomLocationId, Present, 'Name, 'ResourceGroupName, 'SystemCenterVirtualMachineManagerServerId> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : SystemCenterVirtualMachineManagerAvailabilitySetState<'CustomLocationId, Present, 'Name, 'ResourceGroupName, 'SystemCenterVirtualMachineManagerServerId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/system_center_virtual_machine_manager_availability_set#name-1">SystemCenterVirtualMachineManagerAvailabilitySet#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SystemCenterVirtualMachineManagerAvailabilitySetState<'CustomLocationId, 'Location, Missing, 'ResourceGroupName, 'SystemCenterVirtualMachineManagerServerId>, value: string) : SystemCenterVirtualMachineManagerAvailabilitySetState<'CustomLocationId, 'Location, Present, 'ResourceGroupName, 'SystemCenterVirtualMachineManagerServerId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SystemCenterVirtualMachineManagerAvailabilitySetState<'CustomLocationId, 'Location, Present, 'ResourceGroupName, 'SystemCenterVirtualMachineManagerServerId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/system_center_virtual_machine_manager_availability_set#resource_group_name-1">SystemCenterVirtualMachineManagerAvailabilitySet#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: SystemCenterVirtualMachineManagerAvailabilitySetState<'CustomLocationId, 'Location, 'Name, Missing, 'SystemCenterVirtualMachineManagerServerId>, value: string) : SystemCenterVirtualMachineManagerAvailabilitySetState<'CustomLocationId, 'Location, 'Name, Present, 'SystemCenterVirtualMachineManagerServerId> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : SystemCenterVirtualMachineManagerAvailabilitySetState<'CustomLocationId, 'Location, 'Name, Present, 'SystemCenterVirtualMachineManagerServerId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/system_center_virtual_machine_manager_availability_set#system_center_virtual_machine_manager_server_id-1">SystemCenterVirtualMachineManagerAvailabilitySet#system_center_virtual_machine_manager_server_id</a>.
        /// </summary>
        [<CustomOperation "system_center_virtual_machine_manager_server_id">]
        member _.SystemCenterVirtualMachineManagerServerId(state: SystemCenterVirtualMachineManagerAvailabilitySetState<'CustomLocationId, 'Location, 'Name, 'ResourceGroupName, Missing>, value: string) : SystemCenterVirtualMachineManagerAvailabilitySetState<'CustomLocationId, 'Location, 'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.SystemCenterVirtualMachineManagerServerId <- value)
            ({ assignments = state.assignments } : SystemCenterVirtualMachineManagerAvailabilitySetState<'CustomLocationId, 'Location, 'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/system_center_virtual_machine_manager_availability_set#id-1">SystemCenterVirtualMachineManagerAvailabilitySet#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SystemCenterVirtualMachineManagerAvailabilitySetState<'CustomLocationId, 'Location, 'Name, 'ResourceGroupName, 'SystemCenterVirtualMachineManagerServerId>, value: string) : SystemCenterVirtualMachineManagerAvailabilitySetState<'CustomLocationId, 'Location, 'Name, 'ResourceGroupName, 'SystemCenterVirtualMachineManagerServerId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SystemCenterVirtualMachineManagerAvailabilitySetState<'CustomLocationId, 'Location, 'Name, 'ResourceGroupName, 'SystemCenterVirtualMachineManagerServerId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/system_center_virtual_machine_manager_availability_set#tags-1">SystemCenterVirtualMachineManagerAvailabilitySet#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: SystemCenterVirtualMachineManagerAvailabilitySetState<'CustomLocationId, 'Location, 'Name, 'ResourceGroupName, 'SystemCenterVirtualMachineManagerServerId>, value: seq<string * string>) : SystemCenterVirtualMachineManagerAvailabilitySetState<'CustomLocationId, 'Location, 'Name, 'ResourceGroupName, 'SystemCenterVirtualMachineManagerServerId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : SystemCenterVirtualMachineManagerAvailabilitySetState<'CustomLocationId, 'Location, 'Name, 'ResourceGroupName, 'SystemCenterVirtualMachineManagerServerId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/system_center_virtual_machine_manager_availability_set#timeouts-1">SystemCenterVirtualMachineManagerAvailabilitySet#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SystemCenterVirtualMachineManagerAvailabilitySetState<'CustomLocationId, 'Location, 'Name, 'ResourceGroupName, 'SystemCenterVirtualMachineManagerServerId>, value: azurerm.SystemCenterVirtualMachineManagerAvailabilitySet.SystemCenterVirtualMachineManagerAvailabilitySetTimeouts) : SystemCenterVirtualMachineManagerAvailabilitySetState<'CustomLocationId, 'Location, 'Name, 'ResourceGroupName, 'SystemCenterVirtualMachineManagerServerId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SystemCenterVirtualMachineManagerAvailabilitySetState<'CustomLocationId, 'Location, 'Name, 'ResourceGroupName, 'SystemCenterVirtualMachineManagerServerId>

        member _.Run(state: SystemCenterVirtualMachineManagerAvailabilitySetState<Present, Present, Present, Present, Present>) : azurerm.SystemCenterVirtualMachineManagerAvailabilitySet.SystemCenterVirtualMachineManagerAvailabilitySet =
            let config = azurerm.SystemCenterVirtualMachineManagerAvailabilitySet.SystemCenterVirtualMachineManagerAvailabilitySetConfig()
            for setter in state.assignments do
                setter config
            azurerm.SystemCenterVirtualMachineManagerAvailabilitySet.SystemCenterVirtualMachineManagerAvailabilitySet(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.systemCenterVirtualMachineManagerAvailabilitySet: missing required arguments. Must call: custom_location_id, location, name, resource_group_name, system_center_virtual_machine_manager_server_id.", 9999, IsError = true)>]
        member _.Run(_: SystemCenterVirtualMachineManagerAvailabilitySetState<_, _, _, _, _>) : azurerm.SystemCenterVirtualMachineManagerAvailabilitySet.SystemCenterVirtualMachineManagerAvailabilitySet =
            Unchecked.defaultof<azurerm.SystemCenterVirtualMachineManagerAvailabilitySet.SystemCenterVirtualMachineManagerAvailabilitySet>

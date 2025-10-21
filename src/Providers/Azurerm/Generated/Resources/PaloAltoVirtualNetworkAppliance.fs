namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type PaloAltoVirtualNetworkApplianceState<'Name, 'VirtualHubId> = { assignments: ResizeArray<azurerm.PaloAltoVirtualNetworkAppliance.PaloAltoVirtualNetworkApplianceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_virtual_network_appliance">azurerm_palo_alto_virtual_network_appliance</a>.
    /// </summary>
    type PaloAltoVirtualNetworkApplianceBuilder(logicalId: string) =
        member _.Yield(_: unit) : PaloAltoVirtualNetworkApplianceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : PaloAltoVirtualNetworkApplianceState<Missing, Missing>)

        member _.Zero(()) : PaloAltoVirtualNetworkApplianceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : PaloAltoVirtualNetworkApplianceState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_virtual_network_appliance#name-1">PaloAltoVirtualNetworkAppliance#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: PaloAltoVirtualNetworkApplianceState<Missing, 'VirtualHubId>, value: string) : PaloAltoVirtualNetworkApplianceState<Present, 'VirtualHubId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : PaloAltoVirtualNetworkApplianceState<Present, 'VirtualHubId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_virtual_network_appliance#virtual_hub_id-1">PaloAltoVirtualNetworkAppliance#virtual_hub_id</a>.
        /// </summary>
        [<CustomOperation "virtual_hub_id">]
        member _.VirtualHubId(state: PaloAltoVirtualNetworkApplianceState<'Name, Missing>, value: string) : PaloAltoVirtualNetworkApplianceState<'Name, Present> =
            state.assignments.Add(fun config -> config.VirtualHubId <- value)
            ({ assignments = state.assignments } : PaloAltoVirtualNetworkApplianceState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_virtual_network_appliance#id-1">PaloAltoVirtualNetworkAppliance#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: PaloAltoVirtualNetworkApplianceState<'Name, 'VirtualHubId>, value: string) : PaloAltoVirtualNetworkApplianceState<'Name, 'VirtualHubId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : PaloAltoVirtualNetworkApplianceState<'Name, 'VirtualHubId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_virtual_network_appliance#timeouts-1">PaloAltoVirtualNetworkAppliance#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: PaloAltoVirtualNetworkApplianceState<'Name, 'VirtualHubId>, value: azurerm.PaloAltoVirtualNetworkAppliance.PaloAltoVirtualNetworkApplianceTimeouts) : PaloAltoVirtualNetworkApplianceState<'Name, 'VirtualHubId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : PaloAltoVirtualNetworkApplianceState<'Name, 'VirtualHubId>

        member _.Run(state: PaloAltoVirtualNetworkApplianceState<Present, Present>) : azurerm.PaloAltoVirtualNetworkAppliance.PaloAltoVirtualNetworkAppliance =
            let config = azurerm.PaloAltoVirtualNetworkAppliance.PaloAltoVirtualNetworkApplianceConfig()
            for setter in state.assignments do
                setter config
            azurerm.PaloAltoVirtualNetworkAppliance.PaloAltoVirtualNetworkAppliance(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.paloAltoVirtualNetworkAppliance: missing required arguments. Must call: name, virtual_hub_id.", 9999, IsError = true)>]
        member _.Run(_: PaloAltoVirtualNetworkApplianceState<_, _>) : azurerm.PaloAltoVirtualNetworkAppliance.PaloAltoVirtualNetworkAppliance =
            Unchecked.defaultof<azurerm.PaloAltoVirtualNetworkAppliance.PaloAltoVirtualNetworkAppliance>

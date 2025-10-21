namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type StackHciLogicalNetworkState<'CustomLocationId, 'Location, 'Name, 'ResourceGroupName, 'Subnet, 'VirtualSwitchName> = { assignments: ResizeArray<azurerm.StackHciLogicalNetwork.StackHciLogicalNetworkConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stack_hci_logical_network">azurerm_stack_hci_logical_network</a>.
    /// </summary>
    type StackHciLogicalNetworkBuilder(logicalId: string) =
        member _.Yield(_: unit) : StackHciLogicalNetworkState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : StackHciLogicalNetworkState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : StackHciLogicalNetworkState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : StackHciLogicalNetworkState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stack_hci_logical_network#custom_location_id-1">StackHciLogicalNetwork#custom_location_id</a>.
        /// </summary>
        [<CustomOperation "custom_location_id">]
        member _.CustomLocationId(state: StackHciLogicalNetworkState<Missing, 'Location, 'Name, 'ResourceGroupName, 'Subnet, 'VirtualSwitchName>, value: string) : StackHciLogicalNetworkState<Present, 'Location, 'Name, 'ResourceGroupName, 'Subnet, 'VirtualSwitchName> =
            state.assignments.Add(fun config -> config.CustomLocationId <- value)
            ({ assignments = state.assignments } : StackHciLogicalNetworkState<Present, 'Location, 'Name, 'ResourceGroupName, 'Subnet, 'VirtualSwitchName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stack_hci_logical_network#location-1">StackHciLogicalNetwork#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: StackHciLogicalNetworkState<'CustomLocationId, Missing, 'Name, 'ResourceGroupName, 'Subnet, 'VirtualSwitchName>, value: string) : StackHciLogicalNetworkState<'CustomLocationId, Present, 'Name, 'ResourceGroupName, 'Subnet, 'VirtualSwitchName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : StackHciLogicalNetworkState<'CustomLocationId, Present, 'Name, 'ResourceGroupName, 'Subnet, 'VirtualSwitchName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stack_hci_logical_network#name-1">StackHciLogicalNetwork#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: StackHciLogicalNetworkState<'CustomLocationId, 'Location, Missing, 'ResourceGroupName, 'Subnet, 'VirtualSwitchName>, value: string) : StackHciLogicalNetworkState<'CustomLocationId, 'Location, Present, 'ResourceGroupName, 'Subnet, 'VirtualSwitchName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : StackHciLogicalNetworkState<'CustomLocationId, 'Location, Present, 'ResourceGroupName, 'Subnet, 'VirtualSwitchName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stack_hci_logical_network#resource_group_name-1">StackHciLogicalNetwork#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: StackHciLogicalNetworkState<'CustomLocationId, 'Location, 'Name, Missing, 'Subnet, 'VirtualSwitchName>, value: string) : StackHciLogicalNetworkState<'CustomLocationId, 'Location, 'Name, Present, 'Subnet, 'VirtualSwitchName> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : StackHciLogicalNetworkState<'CustomLocationId, 'Location, 'Name, Present, 'Subnet, 'VirtualSwitchName>)

        /// <summary>
        /// subnet block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stack_hci_logical_network#subnet-1">StackHciLogicalNetwork#subnet</a>
        /// </summary>
        [<CustomOperation "subnet">]
        member _.Subnet(state: StackHciLogicalNetworkState<'CustomLocationId, 'Location, 'Name, 'ResourceGroupName, Missing, 'VirtualSwitchName>, value: azurerm.StackHciLogicalNetwork.StackHciLogicalNetworkSubnet) : StackHciLogicalNetworkState<'CustomLocationId, 'Location, 'Name, 'ResourceGroupName, Present, 'VirtualSwitchName> =
            state.assignments.Add(fun config -> config.Subnet <- value)
            ({ assignments = state.assignments } : StackHciLogicalNetworkState<'CustomLocationId, 'Location, 'Name, 'ResourceGroupName, Present, 'VirtualSwitchName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stack_hci_logical_network#virtual_switch_name-1">StackHciLogicalNetwork#virtual_switch_name</a>.
        /// </summary>
        [<CustomOperation "virtual_switch_name">]
        member _.VirtualSwitchName(state: StackHciLogicalNetworkState<'CustomLocationId, 'Location, 'Name, 'ResourceGroupName, 'Subnet, Missing>, value: string) : StackHciLogicalNetworkState<'CustomLocationId, 'Location, 'Name, 'ResourceGroupName, 'Subnet, Present> =
            state.assignments.Add(fun config -> config.VirtualSwitchName <- value)
            ({ assignments = state.assignments } : StackHciLogicalNetworkState<'CustomLocationId, 'Location, 'Name, 'ResourceGroupName, 'Subnet, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stack_hci_logical_network#dns_servers-1">StackHciLogicalNetwork#dns_servers</a>.
        /// </summary>
        [<CustomOperation "dns_servers">]
        member _.DnsServers(state: StackHciLogicalNetworkState<'CustomLocationId, 'Location, 'Name, 'ResourceGroupName, 'Subnet, 'VirtualSwitchName>, value: seq<string>) : StackHciLogicalNetworkState<'CustomLocationId, 'Location, 'Name, 'ResourceGroupName, 'Subnet, 'VirtualSwitchName> =
            state.assignments.Add(fun config -> config.DnsServers <- (value |> Seq.toArray))
            state : StackHciLogicalNetworkState<'CustomLocationId, 'Location, 'Name, 'ResourceGroupName, 'Subnet, 'VirtualSwitchName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stack_hci_logical_network#id-1">StackHciLogicalNetwork#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: StackHciLogicalNetworkState<'CustomLocationId, 'Location, 'Name, 'ResourceGroupName, 'Subnet, 'VirtualSwitchName>, value: string) : StackHciLogicalNetworkState<'CustomLocationId, 'Location, 'Name, 'ResourceGroupName, 'Subnet, 'VirtualSwitchName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : StackHciLogicalNetworkState<'CustomLocationId, 'Location, 'Name, 'ResourceGroupName, 'Subnet, 'VirtualSwitchName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stack_hci_logical_network#tags-1">StackHciLogicalNetwork#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: StackHciLogicalNetworkState<'CustomLocationId, 'Location, 'Name, 'ResourceGroupName, 'Subnet, 'VirtualSwitchName>, value: seq<string * string>) : StackHciLogicalNetworkState<'CustomLocationId, 'Location, 'Name, 'ResourceGroupName, 'Subnet, 'VirtualSwitchName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : StackHciLogicalNetworkState<'CustomLocationId, 'Location, 'Name, 'ResourceGroupName, 'Subnet, 'VirtualSwitchName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stack_hci_logical_network#timeouts-1">StackHciLogicalNetwork#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: StackHciLogicalNetworkState<'CustomLocationId, 'Location, 'Name, 'ResourceGroupName, 'Subnet, 'VirtualSwitchName>, value: azurerm.StackHciLogicalNetwork.StackHciLogicalNetworkTimeouts) : StackHciLogicalNetworkState<'CustomLocationId, 'Location, 'Name, 'ResourceGroupName, 'Subnet, 'VirtualSwitchName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : StackHciLogicalNetworkState<'CustomLocationId, 'Location, 'Name, 'ResourceGroupName, 'Subnet, 'VirtualSwitchName>

        member _.Run(state: StackHciLogicalNetworkState<Present, Present, Present, Present, Present, Present>) : azurerm.StackHciLogicalNetwork.StackHciLogicalNetwork =
            let config = azurerm.StackHciLogicalNetwork.StackHciLogicalNetworkConfig()
            for setter in state.assignments do
                setter config
            azurerm.StackHciLogicalNetwork.StackHciLogicalNetwork(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.stackHciLogicalNetwork: missing required arguments. Must call: custom_location_id, location, name, resource_group_name, subnet, virtual_switch_name.", 9999, IsError = true)>]
        member _.Run(_: StackHciLogicalNetworkState<_, _, _, _, _, _>) : azurerm.StackHciLogicalNetwork.StackHciLogicalNetwork =
            Unchecked.defaultof<azurerm.StackHciLogicalNetwork.StackHciLogicalNetwork>

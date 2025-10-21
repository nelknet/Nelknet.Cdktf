namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VirtualNetworkState<'AddressSpace, 'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.VirtualNetwork.VirtualNetworkConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network">azurerm_virtual_network</a>.
    /// </summary>
    type VirtualNetworkBuilder(logicalId: string) =
        member _.Yield(_: unit) : VirtualNetworkState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : VirtualNetworkState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : VirtualNetworkState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : VirtualNetworkState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network#address_space-1">VirtualNetwork#address_space</a>.
        /// </summary>
        [<CustomOperation "address_space">]
        member _.AddressSpace(state: VirtualNetworkState<Missing, 'Location, 'Name, 'ResourceGroupName>, value: seq<string>) : VirtualNetworkState<Present, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AddressSpace <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : VirtualNetworkState<Present, 'Location, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network#location-1">VirtualNetwork#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: VirtualNetworkState<'AddressSpace, Missing, 'Name, 'ResourceGroupName>, value: string) : VirtualNetworkState<'AddressSpace, Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : VirtualNetworkState<'AddressSpace, Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network#name-1">VirtualNetwork#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: VirtualNetworkState<'AddressSpace, 'Location, Missing, 'ResourceGroupName>, value: string) : VirtualNetworkState<'AddressSpace, 'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : VirtualNetworkState<'AddressSpace, 'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network#resource_group_name-1">VirtualNetwork#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: VirtualNetworkState<'AddressSpace, 'Location, 'Name, Missing>, value: string) : VirtualNetworkState<'AddressSpace, 'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : VirtualNetworkState<'AddressSpace, 'Location, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network#bgp_community-1">VirtualNetwork#bgp_community</a>.
        /// </summary>
        [<CustomOperation "bgp_community">]
        member _.BgpCommunity(state: VirtualNetworkState<'AddressSpace, 'Location, 'Name, 'ResourceGroupName>, value: string) : VirtualNetworkState<'AddressSpace, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.BgpCommunity <- value)
            state : VirtualNetworkState<'AddressSpace, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// ddos_protection_plan block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network#ddos_protection_plan-1">VirtualNetwork#ddos_protection_plan</a>
        /// </summary>
        [<CustomOperation "ddos_protection_plan">]
        member _.DdosProtectionPlan(state: VirtualNetworkState<'AddressSpace, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.VirtualNetwork.VirtualNetworkDdosProtectionPlan) : VirtualNetworkState<'AddressSpace, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DdosProtectionPlan <- value)
            state : VirtualNetworkState<'AddressSpace, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network#dns_servers-1">VirtualNetwork#dns_servers</a>.
        /// </summary>
        [<CustomOperation "dns_servers">]
        member _.DnsServers(state: VirtualNetworkState<'AddressSpace, 'Location, 'Name, 'ResourceGroupName>, value: seq<string>) : VirtualNetworkState<'AddressSpace, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DnsServers <- (value |> Seq.toArray))
            state : VirtualNetworkState<'AddressSpace, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network#edge_zone-1">VirtualNetwork#edge_zone</a>.
        /// </summary>
        [<CustomOperation "edge_zone">]
        member _.EdgeZone(state: VirtualNetworkState<'AddressSpace, 'Location, 'Name, 'ResourceGroupName>, value: string) : VirtualNetworkState<'AddressSpace, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.EdgeZone <- value)
            state : VirtualNetworkState<'AddressSpace, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// encryption block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network#encryption-1">VirtualNetwork#encryption</a>
        /// </summary>
        [<CustomOperation "encryption">]
        member _.Encryption(state: VirtualNetworkState<'AddressSpace, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.VirtualNetwork.VirtualNetworkEncryption) : VirtualNetworkState<'AddressSpace, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Encryption <- value)
            state : VirtualNetworkState<'AddressSpace, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network#flow_timeout_in_minutes-1">VirtualNetwork#flow_timeout_in_minutes</a>.
        /// </summary>
        [<CustomOperation "flow_timeout_in_minutes">]
        member _.FlowTimeoutInMinutes(state: VirtualNetworkState<'AddressSpace, 'Location, 'Name, 'ResourceGroupName>, value: double) : VirtualNetworkState<'AddressSpace, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.FlowTimeoutInMinutes <- value)
            state : VirtualNetworkState<'AddressSpace, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network#id-1">VirtualNetwork#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VirtualNetworkState<'AddressSpace, 'Location, 'Name, 'ResourceGroupName>, value: string) : VirtualNetworkState<'AddressSpace, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VirtualNetworkState<'AddressSpace, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network#subnet-1">VirtualNetwork#subnet</a>. Accepts: azurerm.IResolvable | azurerm.VirtualNetwork.VirtualNetworkSubnet[]
        /// </summary>
        [<CustomOperation "subnet">]
        member _.Subnet(state: VirtualNetworkState<'AddressSpace, 'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : VirtualNetworkState<'AddressSpace, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Subnet <- value)
            state : VirtualNetworkState<'AddressSpace, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network#tags-1">VirtualNetwork#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: VirtualNetworkState<'AddressSpace, 'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : VirtualNetworkState<'AddressSpace, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : VirtualNetworkState<'AddressSpace, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network#timeouts-1">VirtualNetwork#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: VirtualNetworkState<'AddressSpace, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.VirtualNetwork.VirtualNetworkTimeouts) : VirtualNetworkState<'AddressSpace, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : VirtualNetworkState<'AddressSpace, 'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: VirtualNetworkState<Present, Present, Present, Present>) : azurerm.VirtualNetwork.VirtualNetwork =
            let config = azurerm.VirtualNetwork.VirtualNetworkConfig()
            for setter in state.assignments do
                setter config
            azurerm.VirtualNetwork.VirtualNetwork(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.virtualNetwork: missing required arguments. Must call: address_space, location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: VirtualNetworkState<_, _, _, _>) : azurerm.VirtualNetwork.VirtualNetwork =
            Unchecked.defaultof<azurerm.VirtualNetwork.VirtualNetwork>

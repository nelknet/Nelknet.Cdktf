namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type NetworkInterfaceState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.NetworkInterface.NetworkInterfaceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_interface">azurerm_network_interface</a>.
    /// </summary>
    type NetworkInterfaceBuilder(logicalId: string) =
        member _.Yield(_: unit) : NetworkInterfaceState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkInterfaceState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : NetworkInterfaceState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkInterfaceState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// ip_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_interface#ip_configuration-1">NetworkInterface#ip_configuration</a> Accepts: azurerm.IResolvable | azurerm.NetworkInterface.NetworkInterfaceIpConfiguration[]
        /// </summary>
        [<CustomOperation "ip_configuration">]
        member _.IpConfiguration(state: NetworkInterfaceState<Missing, 'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : NetworkInterfaceState<Present, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.IpConfiguration <- value)
            ({ assignments = state.assignments } : NetworkInterfaceState<Present, 'Location, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_interface#location-1">NetworkInterface#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: NetworkInterfaceState<'IpConfiguration, Missing, 'Name, 'ResourceGroupName>, value: string) : NetworkInterfaceState<'IpConfiguration, Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : NetworkInterfaceState<'IpConfiguration, Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_interface#name-1">NetworkInterface#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: NetworkInterfaceState<'IpConfiguration, 'Location, Missing, 'ResourceGroupName>, value: string) : NetworkInterfaceState<'IpConfiguration, 'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : NetworkInterfaceState<'IpConfiguration, 'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_interface#resource_group_name-1">NetworkInterface#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: NetworkInterfaceState<'IpConfiguration, 'Location, 'Name, Missing>, value: string) : NetworkInterfaceState<'IpConfiguration, 'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : NetworkInterfaceState<'IpConfiguration, 'Location, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_interface#accelerated_networking_enabled-1">NetworkInterface#accelerated_networking_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "accelerated_networking_enabled">]
        member _.AcceleratedNetworkingEnabled(state: NetworkInterfaceState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName>, value: bool) : NetworkInterfaceState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AcceleratedNetworkingEnabled <- value)
            state : NetworkInterfaceState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_interface#accelerated_networking_enabled-1">NetworkInterface#accelerated_networking_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "accelerated_networking_enabled">]
        member _.AcceleratedNetworkingEnabled(state: NetworkInterfaceState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : NetworkInterfaceState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AcceleratedNetworkingEnabled <- value)
            state : NetworkInterfaceState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_interface#auxiliary_mode-1">NetworkInterface#auxiliary_mode</a>.
        /// </summary>
        [<CustomOperation "auxiliary_mode">]
        member _.AuxiliaryMode(state: NetworkInterfaceState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName>, value: string) : NetworkInterfaceState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AuxiliaryMode <- value)
            state : NetworkInterfaceState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_interface#auxiliary_sku-1">NetworkInterface#auxiliary_sku</a>.
        /// </summary>
        [<CustomOperation "auxiliary_sku">]
        member _.AuxiliarySku(state: NetworkInterfaceState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName>, value: string) : NetworkInterfaceState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AuxiliarySku <- value)
            state : NetworkInterfaceState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_interface#dns_servers-1">NetworkInterface#dns_servers</a>.
        /// </summary>
        [<CustomOperation "dns_servers">]
        member _.DnsServers(state: NetworkInterfaceState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName>, value: seq<string>) : NetworkInterfaceState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DnsServers <- (value |> Seq.toArray))
            state : NetworkInterfaceState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_interface#edge_zone-1">NetworkInterface#edge_zone</a>.
        /// </summary>
        [<CustomOperation "edge_zone">]
        member _.EdgeZone(state: NetworkInterfaceState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName>, value: string) : NetworkInterfaceState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.EdgeZone <- value)
            state : NetworkInterfaceState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_interface#id-1">NetworkInterface#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: NetworkInterfaceState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName>, value: string) : NetworkInterfaceState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : NetworkInterfaceState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_interface#internal_dns_name_label-1">NetworkInterface#internal_dns_name_label</a>.
        /// </summary>
        [<CustomOperation "internal_dns_name_label">]
        member _.InternalDnsNameLabel(state: NetworkInterfaceState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName>, value: string) : NetworkInterfaceState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.InternalDnsNameLabel <- value)
            state : NetworkInterfaceState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_interface#ip_forwarding_enabled-1">NetworkInterface#ip_forwarding_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "ip_forwarding_enabled">]
        member _.IpForwardingEnabled(state: NetworkInterfaceState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName>, value: bool) : NetworkInterfaceState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.IpForwardingEnabled <- value)
            state : NetworkInterfaceState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_interface#ip_forwarding_enabled-1">NetworkInterface#ip_forwarding_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "ip_forwarding_enabled">]
        member _.IpForwardingEnabled(state: NetworkInterfaceState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : NetworkInterfaceState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.IpForwardingEnabled <- value)
            state : NetworkInterfaceState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_interface#tags-1">NetworkInterface#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: NetworkInterfaceState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : NetworkInterfaceState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : NetworkInterfaceState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_interface#timeouts-1">NetworkInterface#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: NetworkInterfaceState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.NetworkInterface.NetworkInterfaceTimeouts) : NetworkInterfaceState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : NetworkInterfaceState<'IpConfiguration, 'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: NetworkInterfaceState<Present, Present, Present, Present>) : azurerm.NetworkInterface.NetworkInterface =
            let config = azurerm.NetworkInterface.NetworkInterfaceConfig()
            for setter in state.assignments do
                setter config
            azurerm.NetworkInterface.NetworkInterface(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.networkInterface: missing required arguments. Must call: ip_configuration, location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: NetworkInterfaceState<_, _, _, _>) : azurerm.NetworkInterface.NetworkInterface =
            Unchecked.defaultof<azurerm.NetworkInterface.NetworkInterface>

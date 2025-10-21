namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type PaloAltoNextGenerationFirewallVirtualNetworkPanoramaState<'Location, 'Name, 'NetworkProfile, 'PanoramaBase64Config, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.PaloAltoNextGenerationFirewallVirtualNetworkPanorama.PaloAltoNextGenerationFirewallVirtualNetworkPanoramaConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_network_panorama">azurerm_palo_alto_next_generation_firewall_virtual_network_panorama</a>.
    /// </summary>
    type PaloAltoNextGenerationFirewallVirtualNetworkPanoramaBuilder(logicalId: string) =
        member _.Yield(_: unit) : PaloAltoNextGenerationFirewallVirtualNetworkPanoramaState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PaloAltoNextGenerationFirewallVirtualNetworkPanoramaState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : PaloAltoNextGenerationFirewallVirtualNetworkPanoramaState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PaloAltoNextGenerationFirewallVirtualNetworkPanoramaState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_network_panorama#location-1">PaloAltoNextGenerationFirewallVirtualNetworkPanorama#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: PaloAltoNextGenerationFirewallVirtualNetworkPanoramaState<Missing, 'Name, 'NetworkProfile, 'PanoramaBase64Config, 'ResourceGroupName>, value: string) : PaloAltoNextGenerationFirewallVirtualNetworkPanoramaState<Present, 'Name, 'NetworkProfile, 'PanoramaBase64Config, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : PaloAltoNextGenerationFirewallVirtualNetworkPanoramaState<Present, 'Name, 'NetworkProfile, 'PanoramaBase64Config, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_network_panorama#name-1">PaloAltoNextGenerationFirewallVirtualNetworkPanorama#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: PaloAltoNextGenerationFirewallVirtualNetworkPanoramaState<'Location, Missing, 'NetworkProfile, 'PanoramaBase64Config, 'ResourceGroupName>, value: string) : PaloAltoNextGenerationFirewallVirtualNetworkPanoramaState<'Location, Present, 'NetworkProfile, 'PanoramaBase64Config, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : PaloAltoNextGenerationFirewallVirtualNetworkPanoramaState<'Location, Present, 'NetworkProfile, 'PanoramaBase64Config, 'ResourceGroupName>)

        /// <summary>
        /// network_profile block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_network_panorama#network_profile-1">PaloAltoNextGenerationFirewallVirtualNetworkPanorama#network_profile</a>
        /// </summary>
        [<CustomOperation "network_profile">]
        member _.NetworkProfile(state: PaloAltoNextGenerationFirewallVirtualNetworkPanoramaState<'Location, 'Name, Missing, 'PanoramaBase64Config, 'ResourceGroupName>, value: azurerm.PaloAltoNextGenerationFirewallVirtualNetworkPanorama.PaloAltoNextGenerationFirewallVirtualNetworkPanoramaNetworkProfile) : PaloAltoNextGenerationFirewallVirtualNetworkPanoramaState<'Location, 'Name, Present, 'PanoramaBase64Config, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.NetworkProfile <- value)
            ({ assignments = state.assignments } : PaloAltoNextGenerationFirewallVirtualNetworkPanoramaState<'Location, 'Name, Present, 'PanoramaBase64Config, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_network_panorama#panorama_base64_config-1">PaloAltoNextGenerationFirewallVirtualNetworkPanorama#panorama_base64_config</a>.
        /// </summary>
        [<CustomOperation "panorama_base64_config">]
        member _.PanoramaBase64Config(state: PaloAltoNextGenerationFirewallVirtualNetworkPanoramaState<'Location, 'Name, 'NetworkProfile, Missing, 'ResourceGroupName>, value: string) : PaloAltoNextGenerationFirewallVirtualNetworkPanoramaState<'Location, 'Name, 'NetworkProfile, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.PanoramaBase64Config <- value)
            ({ assignments = state.assignments } : PaloAltoNextGenerationFirewallVirtualNetworkPanoramaState<'Location, 'Name, 'NetworkProfile, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_network_panorama#resource_group_name-1">PaloAltoNextGenerationFirewallVirtualNetworkPanorama#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: PaloAltoNextGenerationFirewallVirtualNetworkPanoramaState<'Location, 'Name, 'NetworkProfile, 'PanoramaBase64Config, Missing>, value: string) : PaloAltoNextGenerationFirewallVirtualNetworkPanoramaState<'Location, 'Name, 'NetworkProfile, 'PanoramaBase64Config, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : PaloAltoNextGenerationFirewallVirtualNetworkPanoramaState<'Location, 'Name, 'NetworkProfile, 'PanoramaBase64Config, Present>)

        /// <summary>
        /// destination_nat block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_network_panorama#destination_nat-1">PaloAltoNextGenerationFirewallVirtualNetworkPanorama#destination_nat</a> Accepts: azurerm.IResolvable | azurerm.PaloAltoNextGenerationFirewallVirtualNetworkPanorama.PaloAltoNextGenerationFirewallVirtualNetworkPanoramaDestinationNat[]
        /// </summary>
        [<CustomOperation "destination_nat">]
        member _.DestinationNat(state: PaloAltoNextGenerationFirewallVirtualNetworkPanoramaState<'Location, 'Name, 'NetworkProfile, 'PanoramaBase64Config, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : PaloAltoNextGenerationFirewallVirtualNetworkPanoramaState<'Location, 'Name, 'NetworkProfile, 'PanoramaBase64Config, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DestinationNat <- value)
            state : PaloAltoNextGenerationFirewallVirtualNetworkPanoramaState<'Location, 'Name, 'NetworkProfile, 'PanoramaBase64Config, 'ResourceGroupName>

        /// <summary>
        /// dns_settings block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_network_panorama#dns_settings-1">PaloAltoNextGenerationFirewallVirtualNetworkPanorama#dns_settings</a>
        /// </summary>
        [<CustomOperation "dns_settings">]
        member _.DnsSettings(state: PaloAltoNextGenerationFirewallVirtualNetworkPanoramaState<'Location, 'Name, 'NetworkProfile, 'PanoramaBase64Config, 'ResourceGroupName>, value: azurerm.PaloAltoNextGenerationFirewallVirtualNetworkPanorama.PaloAltoNextGenerationFirewallVirtualNetworkPanoramaDnsSettings) : PaloAltoNextGenerationFirewallVirtualNetworkPanoramaState<'Location, 'Name, 'NetworkProfile, 'PanoramaBase64Config, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DnsSettings <- value)
            state : PaloAltoNextGenerationFirewallVirtualNetworkPanoramaState<'Location, 'Name, 'NetworkProfile, 'PanoramaBase64Config, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_network_panorama#id-1">PaloAltoNextGenerationFirewallVirtualNetworkPanorama#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: PaloAltoNextGenerationFirewallVirtualNetworkPanoramaState<'Location, 'Name, 'NetworkProfile, 'PanoramaBase64Config, 'ResourceGroupName>, value: string) : PaloAltoNextGenerationFirewallVirtualNetworkPanoramaState<'Location, 'Name, 'NetworkProfile, 'PanoramaBase64Config, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : PaloAltoNextGenerationFirewallVirtualNetworkPanoramaState<'Location, 'Name, 'NetworkProfile, 'PanoramaBase64Config, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_network_panorama#tags-1">PaloAltoNextGenerationFirewallVirtualNetworkPanorama#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: PaloAltoNextGenerationFirewallVirtualNetworkPanoramaState<'Location, 'Name, 'NetworkProfile, 'PanoramaBase64Config, 'ResourceGroupName>, value: seq<string * string>) : PaloAltoNextGenerationFirewallVirtualNetworkPanoramaState<'Location, 'Name, 'NetworkProfile, 'PanoramaBase64Config, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : PaloAltoNextGenerationFirewallVirtualNetworkPanoramaState<'Location, 'Name, 'NetworkProfile, 'PanoramaBase64Config, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_network_panorama#timeouts-1">PaloAltoNextGenerationFirewallVirtualNetworkPanorama#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: PaloAltoNextGenerationFirewallVirtualNetworkPanoramaState<'Location, 'Name, 'NetworkProfile, 'PanoramaBase64Config, 'ResourceGroupName>, value: azurerm.PaloAltoNextGenerationFirewallVirtualNetworkPanorama.PaloAltoNextGenerationFirewallVirtualNetworkPanoramaTimeouts) : PaloAltoNextGenerationFirewallVirtualNetworkPanoramaState<'Location, 'Name, 'NetworkProfile, 'PanoramaBase64Config, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : PaloAltoNextGenerationFirewallVirtualNetworkPanoramaState<'Location, 'Name, 'NetworkProfile, 'PanoramaBase64Config, 'ResourceGroupName>

        member _.Run(state: PaloAltoNextGenerationFirewallVirtualNetworkPanoramaState<Present, Present, Present, Present, Present>) : azurerm.PaloAltoNextGenerationFirewallVirtualNetworkPanorama.PaloAltoNextGenerationFirewallVirtualNetworkPanorama =
            let config = azurerm.PaloAltoNextGenerationFirewallVirtualNetworkPanorama.PaloAltoNextGenerationFirewallVirtualNetworkPanoramaConfig()
            for setter in state.assignments do
                setter config
            azurerm.PaloAltoNextGenerationFirewallVirtualNetworkPanorama.PaloAltoNextGenerationFirewallVirtualNetworkPanorama(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.paloAltoNextGenerationFirewallVirtualNetworkPanorama: missing required arguments. Must call: location, name, network_profile, panorama_base64_config, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: PaloAltoNextGenerationFirewallVirtualNetworkPanoramaState<_, _, _, _, _>) : azurerm.PaloAltoNextGenerationFirewallVirtualNetworkPanorama.PaloAltoNextGenerationFirewallVirtualNetworkPanorama =
            Unchecked.defaultof<azurerm.PaloAltoNextGenerationFirewallVirtualNetworkPanorama.PaloAltoNextGenerationFirewallVirtualNetworkPanorama>

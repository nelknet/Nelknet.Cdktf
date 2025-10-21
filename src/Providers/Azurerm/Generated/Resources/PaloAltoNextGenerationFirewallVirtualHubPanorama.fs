namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type PaloAltoNextGenerationFirewallVirtualHubPanoramaState<'Location, 'Name, 'NetworkProfile, 'PanoramaBase64Config, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.PaloAltoNextGenerationFirewallVirtualHubPanorama.PaloAltoNextGenerationFirewallVirtualHubPanoramaConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_hub_panorama">azurerm_palo_alto_next_generation_firewall_virtual_hub_panorama</a>.
    /// </summary>
    type PaloAltoNextGenerationFirewallVirtualHubPanoramaBuilder(logicalId: string) =
        member _.Yield(_: unit) : PaloAltoNextGenerationFirewallVirtualHubPanoramaState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PaloAltoNextGenerationFirewallVirtualHubPanoramaState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : PaloAltoNextGenerationFirewallVirtualHubPanoramaState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PaloAltoNextGenerationFirewallVirtualHubPanoramaState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_hub_panorama#location-1">PaloAltoNextGenerationFirewallVirtualHubPanorama#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: PaloAltoNextGenerationFirewallVirtualHubPanoramaState<Missing, 'Name, 'NetworkProfile, 'PanoramaBase64Config, 'ResourceGroupName>, value: string) : PaloAltoNextGenerationFirewallVirtualHubPanoramaState<Present, 'Name, 'NetworkProfile, 'PanoramaBase64Config, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : PaloAltoNextGenerationFirewallVirtualHubPanoramaState<Present, 'Name, 'NetworkProfile, 'PanoramaBase64Config, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_hub_panorama#name-1">PaloAltoNextGenerationFirewallVirtualHubPanorama#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: PaloAltoNextGenerationFirewallVirtualHubPanoramaState<'Location, Missing, 'NetworkProfile, 'PanoramaBase64Config, 'ResourceGroupName>, value: string) : PaloAltoNextGenerationFirewallVirtualHubPanoramaState<'Location, Present, 'NetworkProfile, 'PanoramaBase64Config, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : PaloAltoNextGenerationFirewallVirtualHubPanoramaState<'Location, Present, 'NetworkProfile, 'PanoramaBase64Config, 'ResourceGroupName>)

        /// <summary>
        /// network_profile block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_hub_panorama#network_profile-1">PaloAltoNextGenerationFirewallVirtualHubPanorama#network_profile</a>
        /// </summary>
        [<CustomOperation "network_profile">]
        member _.NetworkProfile(state: PaloAltoNextGenerationFirewallVirtualHubPanoramaState<'Location, 'Name, Missing, 'PanoramaBase64Config, 'ResourceGroupName>, value: azurerm.PaloAltoNextGenerationFirewallVirtualHubPanorama.PaloAltoNextGenerationFirewallVirtualHubPanoramaNetworkProfile) : PaloAltoNextGenerationFirewallVirtualHubPanoramaState<'Location, 'Name, Present, 'PanoramaBase64Config, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.NetworkProfile <- value)
            ({ assignments = state.assignments } : PaloAltoNextGenerationFirewallVirtualHubPanoramaState<'Location, 'Name, Present, 'PanoramaBase64Config, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_hub_panorama#panorama_base64_config-1">PaloAltoNextGenerationFirewallVirtualHubPanorama#panorama_base64_config</a>.
        /// </summary>
        [<CustomOperation "panorama_base64_config">]
        member _.PanoramaBase64Config(state: PaloAltoNextGenerationFirewallVirtualHubPanoramaState<'Location, 'Name, 'NetworkProfile, Missing, 'ResourceGroupName>, value: string) : PaloAltoNextGenerationFirewallVirtualHubPanoramaState<'Location, 'Name, 'NetworkProfile, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.PanoramaBase64Config <- value)
            ({ assignments = state.assignments } : PaloAltoNextGenerationFirewallVirtualHubPanoramaState<'Location, 'Name, 'NetworkProfile, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_hub_panorama#resource_group_name-1">PaloAltoNextGenerationFirewallVirtualHubPanorama#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: PaloAltoNextGenerationFirewallVirtualHubPanoramaState<'Location, 'Name, 'NetworkProfile, 'PanoramaBase64Config, Missing>, value: string) : PaloAltoNextGenerationFirewallVirtualHubPanoramaState<'Location, 'Name, 'NetworkProfile, 'PanoramaBase64Config, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : PaloAltoNextGenerationFirewallVirtualHubPanoramaState<'Location, 'Name, 'NetworkProfile, 'PanoramaBase64Config, Present>)

        /// <summary>
        /// destination_nat block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_hub_panorama#destination_nat-1">PaloAltoNextGenerationFirewallVirtualHubPanorama#destination_nat</a> Accepts: azurerm.IResolvable | azurerm.PaloAltoNextGenerationFirewallVirtualHubPanorama.PaloAltoNextGenerationFirewallVirtualHubPanoramaDestinationNat[]
        /// </summary>
        [<CustomOperation "destination_nat">]
        member _.DestinationNat(state: PaloAltoNextGenerationFirewallVirtualHubPanoramaState<'Location, 'Name, 'NetworkProfile, 'PanoramaBase64Config, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : PaloAltoNextGenerationFirewallVirtualHubPanoramaState<'Location, 'Name, 'NetworkProfile, 'PanoramaBase64Config, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DestinationNat <- value)
            state : PaloAltoNextGenerationFirewallVirtualHubPanoramaState<'Location, 'Name, 'NetworkProfile, 'PanoramaBase64Config, 'ResourceGroupName>

        /// <summary>
        /// dns_settings block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_hub_panorama#dns_settings-1">PaloAltoNextGenerationFirewallVirtualHubPanorama#dns_settings</a>
        /// </summary>
        [<CustomOperation "dns_settings">]
        member _.DnsSettings(state: PaloAltoNextGenerationFirewallVirtualHubPanoramaState<'Location, 'Name, 'NetworkProfile, 'PanoramaBase64Config, 'ResourceGroupName>, value: azurerm.PaloAltoNextGenerationFirewallVirtualHubPanorama.PaloAltoNextGenerationFirewallVirtualHubPanoramaDnsSettings) : PaloAltoNextGenerationFirewallVirtualHubPanoramaState<'Location, 'Name, 'NetworkProfile, 'PanoramaBase64Config, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DnsSettings <- value)
            state : PaloAltoNextGenerationFirewallVirtualHubPanoramaState<'Location, 'Name, 'NetworkProfile, 'PanoramaBase64Config, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_hub_panorama#id-1">PaloAltoNextGenerationFirewallVirtualHubPanorama#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: PaloAltoNextGenerationFirewallVirtualHubPanoramaState<'Location, 'Name, 'NetworkProfile, 'PanoramaBase64Config, 'ResourceGroupName>, value: string) : PaloAltoNextGenerationFirewallVirtualHubPanoramaState<'Location, 'Name, 'NetworkProfile, 'PanoramaBase64Config, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : PaloAltoNextGenerationFirewallVirtualHubPanoramaState<'Location, 'Name, 'NetworkProfile, 'PanoramaBase64Config, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_hub_panorama#tags-1">PaloAltoNextGenerationFirewallVirtualHubPanorama#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: PaloAltoNextGenerationFirewallVirtualHubPanoramaState<'Location, 'Name, 'NetworkProfile, 'PanoramaBase64Config, 'ResourceGroupName>, value: seq<string * string>) : PaloAltoNextGenerationFirewallVirtualHubPanoramaState<'Location, 'Name, 'NetworkProfile, 'PanoramaBase64Config, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : PaloAltoNextGenerationFirewallVirtualHubPanoramaState<'Location, 'Name, 'NetworkProfile, 'PanoramaBase64Config, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_next_generation_firewall_virtual_hub_panorama#timeouts-1">PaloAltoNextGenerationFirewallVirtualHubPanorama#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: PaloAltoNextGenerationFirewallVirtualHubPanoramaState<'Location, 'Name, 'NetworkProfile, 'PanoramaBase64Config, 'ResourceGroupName>, value: azurerm.PaloAltoNextGenerationFirewallVirtualHubPanorama.PaloAltoNextGenerationFirewallVirtualHubPanoramaTimeouts) : PaloAltoNextGenerationFirewallVirtualHubPanoramaState<'Location, 'Name, 'NetworkProfile, 'PanoramaBase64Config, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : PaloAltoNextGenerationFirewallVirtualHubPanoramaState<'Location, 'Name, 'NetworkProfile, 'PanoramaBase64Config, 'ResourceGroupName>

        member _.Run(state: PaloAltoNextGenerationFirewallVirtualHubPanoramaState<Present, Present, Present, Present, Present>) : azurerm.PaloAltoNextGenerationFirewallVirtualHubPanorama.PaloAltoNextGenerationFirewallVirtualHubPanorama =
            let config = azurerm.PaloAltoNextGenerationFirewallVirtualHubPanorama.PaloAltoNextGenerationFirewallVirtualHubPanoramaConfig()
            for setter in state.assignments do
                setter config
            azurerm.PaloAltoNextGenerationFirewallVirtualHubPanorama.PaloAltoNextGenerationFirewallVirtualHubPanorama(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.paloAltoNextGenerationFirewallVirtualHubPanorama: missing required arguments. Must call: location, name, network_profile, panorama_base64_config, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: PaloAltoNextGenerationFirewallVirtualHubPanoramaState<_, _, _, _, _>) : azurerm.PaloAltoNextGenerationFirewallVirtualHubPanorama.PaloAltoNextGenerationFirewallVirtualHubPanorama =
            Unchecked.defaultof<azurerm.PaloAltoNextGenerationFirewallVirtualHubPanorama.PaloAltoNextGenerationFirewallVirtualHubPanorama>

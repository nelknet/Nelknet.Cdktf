namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type PointToSiteVpnGatewayState<'ConnectionConfiguration, 'Location, 'Name, 'ResourceGroupName, 'ScaleUnit, 'VirtualHubId, 'VpnServerConfigurationId> = { assignments: ResizeArray<azurerm.PointToSiteVpnGateway.PointToSiteVpnGatewayConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/point_to_site_vpn_gateway">azurerm_point_to_site_vpn_gateway</a>.
    /// </summary>
    type PointToSiteVpnGatewayBuilder(logicalId: string) =
        member _.Yield(_: unit) : PointToSiteVpnGatewayState<Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PointToSiteVpnGatewayState<Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : PointToSiteVpnGatewayState<Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PointToSiteVpnGatewayState<Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// connection_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/point_to_site_vpn_gateway#connection_configuration-1">PointToSiteVpnGateway#connection_configuration</a> Accepts: azurerm.IResolvable | azurerm.PointToSiteVpnGateway.PointToSiteVpnGatewayConnectionConfiguration[]
        /// </summary>
        [<CustomOperation "connection_configuration">]
        member _.ConnectionConfiguration(state: PointToSiteVpnGatewayState<Missing, 'Location, 'Name, 'ResourceGroupName, 'ScaleUnit, 'VirtualHubId, 'VpnServerConfigurationId>, value: HashiCorp.Cdktf.IResolvable) : PointToSiteVpnGatewayState<Present, 'Location, 'Name, 'ResourceGroupName, 'ScaleUnit, 'VirtualHubId, 'VpnServerConfigurationId> =
            state.assignments.Add(fun config -> config.ConnectionConfiguration <- value)
            ({ assignments = state.assignments } : PointToSiteVpnGatewayState<Present, 'Location, 'Name, 'ResourceGroupName, 'ScaleUnit, 'VirtualHubId, 'VpnServerConfigurationId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/point_to_site_vpn_gateway#location-1">PointToSiteVpnGateway#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: PointToSiteVpnGatewayState<'ConnectionConfiguration, Missing, 'Name, 'ResourceGroupName, 'ScaleUnit, 'VirtualHubId, 'VpnServerConfigurationId>, value: string) : PointToSiteVpnGatewayState<'ConnectionConfiguration, Present, 'Name, 'ResourceGroupName, 'ScaleUnit, 'VirtualHubId, 'VpnServerConfigurationId> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : PointToSiteVpnGatewayState<'ConnectionConfiguration, Present, 'Name, 'ResourceGroupName, 'ScaleUnit, 'VirtualHubId, 'VpnServerConfigurationId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/point_to_site_vpn_gateway#name-1">PointToSiteVpnGateway#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: PointToSiteVpnGatewayState<'ConnectionConfiguration, 'Location, Missing, 'ResourceGroupName, 'ScaleUnit, 'VirtualHubId, 'VpnServerConfigurationId>, value: string) : PointToSiteVpnGatewayState<'ConnectionConfiguration, 'Location, Present, 'ResourceGroupName, 'ScaleUnit, 'VirtualHubId, 'VpnServerConfigurationId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : PointToSiteVpnGatewayState<'ConnectionConfiguration, 'Location, Present, 'ResourceGroupName, 'ScaleUnit, 'VirtualHubId, 'VpnServerConfigurationId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/point_to_site_vpn_gateway#resource_group_name-1">PointToSiteVpnGateway#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: PointToSiteVpnGatewayState<'ConnectionConfiguration, 'Location, 'Name, Missing, 'ScaleUnit, 'VirtualHubId, 'VpnServerConfigurationId>, value: string) : PointToSiteVpnGatewayState<'ConnectionConfiguration, 'Location, 'Name, Present, 'ScaleUnit, 'VirtualHubId, 'VpnServerConfigurationId> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : PointToSiteVpnGatewayState<'ConnectionConfiguration, 'Location, 'Name, Present, 'ScaleUnit, 'VirtualHubId, 'VpnServerConfigurationId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/point_to_site_vpn_gateway#scale_unit-1">PointToSiteVpnGateway#scale_unit</a>.
        /// </summary>
        [<CustomOperation "scale_unit">]
        member _.ScaleUnit(state: PointToSiteVpnGatewayState<'ConnectionConfiguration, 'Location, 'Name, 'ResourceGroupName, Missing, 'VirtualHubId, 'VpnServerConfigurationId>, value: double) : PointToSiteVpnGatewayState<'ConnectionConfiguration, 'Location, 'Name, 'ResourceGroupName, Present, 'VirtualHubId, 'VpnServerConfigurationId> =
            state.assignments.Add(fun config -> config.ScaleUnit <- value)
            ({ assignments = state.assignments } : PointToSiteVpnGatewayState<'ConnectionConfiguration, 'Location, 'Name, 'ResourceGroupName, Present, 'VirtualHubId, 'VpnServerConfigurationId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/point_to_site_vpn_gateway#virtual_hub_id-1">PointToSiteVpnGateway#virtual_hub_id</a>.
        /// </summary>
        [<CustomOperation "virtual_hub_id">]
        member _.VirtualHubId(state: PointToSiteVpnGatewayState<'ConnectionConfiguration, 'Location, 'Name, 'ResourceGroupName, 'ScaleUnit, Missing, 'VpnServerConfigurationId>, value: string) : PointToSiteVpnGatewayState<'ConnectionConfiguration, 'Location, 'Name, 'ResourceGroupName, 'ScaleUnit, Present, 'VpnServerConfigurationId> =
            state.assignments.Add(fun config -> config.VirtualHubId <- value)
            ({ assignments = state.assignments } : PointToSiteVpnGatewayState<'ConnectionConfiguration, 'Location, 'Name, 'ResourceGroupName, 'ScaleUnit, Present, 'VpnServerConfigurationId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/point_to_site_vpn_gateway#vpn_server_configuration_id-1">PointToSiteVpnGateway#vpn_server_configuration_id</a>.
        /// </summary>
        [<CustomOperation "vpn_server_configuration_id">]
        member _.VpnServerConfigurationId(state: PointToSiteVpnGatewayState<'ConnectionConfiguration, 'Location, 'Name, 'ResourceGroupName, 'ScaleUnit, 'VirtualHubId, Missing>, value: string) : PointToSiteVpnGatewayState<'ConnectionConfiguration, 'Location, 'Name, 'ResourceGroupName, 'ScaleUnit, 'VirtualHubId, Present> =
            state.assignments.Add(fun config -> config.VpnServerConfigurationId <- value)
            ({ assignments = state.assignments } : PointToSiteVpnGatewayState<'ConnectionConfiguration, 'Location, 'Name, 'ResourceGroupName, 'ScaleUnit, 'VirtualHubId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/point_to_site_vpn_gateway#dns_servers-1">PointToSiteVpnGateway#dns_servers</a>.
        /// </summary>
        [<CustomOperation "dns_servers">]
        member _.DnsServers(state: PointToSiteVpnGatewayState<'ConnectionConfiguration, 'Location, 'Name, 'ResourceGroupName, 'ScaleUnit, 'VirtualHubId, 'VpnServerConfigurationId>, value: seq<string>) : PointToSiteVpnGatewayState<'ConnectionConfiguration, 'Location, 'Name, 'ResourceGroupName, 'ScaleUnit, 'VirtualHubId, 'VpnServerConfigurationId> =
            state.assignments.Add(fun config -> config.DnsServers <- (value |> Seq.toArray))
            state : PointToSiteVpnGatewayState<'ConnectionConfiguration, 'Location, 'Name, 'ResourceGroupName, 'ScaleUnit, 'VirtualHubId, 'VpnServerConfigurationId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/point_to_site_vpn_gateway#id-1">PointToSiteVpnGateway#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: PointToSiteVpnGatewayState<'ConnectionConfiguration, 'Location, 'Name, 'ResourceGroupName, 'ScaleUnit, 'VirtualHubId, 'VpnServerConfigurationId>, value: string) : PointToSiteVpnGatewayState<'ConnectionConfiguration, 'Location, 'Name, 'ResourceGroupName, 'ScaleUnit, 'VirtualHubId, 'VpnServerConfigurationId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : PointToSiteVpnGatewayState<'ConnectionConfiguration, 'Location, 'Name, 'ResourceGroupName, 'ScaleUnit, 'VirtualHubId, 'VpnServerConfigurationId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/point_to_site_vpn_gateway#routing_preference_internet_enabled-1">PointToSiteVpnGateway#routing_preference_internet_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "routing_preference_internet_enabled">]
        member _.RoutingPreferenceInternetEnabled(state: PointToSiteVpnGatewayState<'ConnectionConfiguration, 'Location, 'Name, 'ResourceGroupName, 'ScaleUnit, 'VirtualHubId, 'VpnServerConfigurationId>, value: bool) : PointToSiteVpnGatewayState<'ConnectionConfiguration, 'Location, 'Name, 'ResourceGroupName, 'ScaleUnit, 'VirtualHubId, 'VpnServerConfigurationId> =
            state.assignments.Add(fun config -> config.RoutingPreferenceInternetEnabled <- value)
            state : PointToSiteVpnGatewayState<'ConnectionConfiguration, 'Location, 'Name, 'ResourceGroupName, 'ScaleUnit, 'VirtualHubId, 'VpnServerConfigurationId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/point_to_site_vpn_gateway#routing_preference_internet_enabled-1">PointToSiteVpnGateway#routing_preference_internet_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "routing_preference_internet_enabled">]
        member _.RoutingPreferenceInternetEnabled(state: PointToSiteVpnGatewayState<'ConnectionConfiguration, 'Location, 'Name, 'ResourceGroupName, 'ScaleUnit, 'VirtualHubId, 'VpnServerConfigurationId>, value: HashiCorp.Cdktf.IResolvable) : PointToSiteVpnGatewayState<'ConnectionConfiguration, 'Location, 'Name, 'ResourceGroupName, 'ScaleUnit, 'VirtualHubId, 'VpnServerConfigurationId> =
            state.assignments.Add(fun config -> config.RoutingPreferenceInternetEnabled <- value)
            state : PointToSiteVpnGatewayState<'ConnectionConfiguration, 'Location, 'Name, 'ResourceGroupName, 'ScaleUnit, 'VirtualHubId, 'VpnServerConfigurationId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/point_to_site_vpn_gateway#tags-1">PointToSiteVpnGateway#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: PointToSiteVpnGatewayState<'ConnectionConfiguration, 'Location, 'Name, 'ResourceGroupName, 'ScaleUnit, 'VirtualHubId, 'VpnServerConfigurationId>, value: seq<string * string>) : PointToSiteVpnGatewayState<'ConnectionConfiguration, 'Location, 'Name, 'ResourceGroupName, 'ScaleUnit, 'VirtualHubId, 'VpnServerConfigurationId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : PointToSiteVpnGatewayState<'ConnectionConfiguration, 'Location, 'Name, 'ResourceGroupName, 'ScaleUnit, 'VirtualHubId, 'VpnServerConfigurationId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/point_to_site_vpn_gateway#timeouts-1">PointToSiteVpnGateway#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: PointToSiteVpnGatewayState<'ConnectionConfiguration, 'Location, 'Name, 'ResourceGroupName, 'ScaleUnit, 'VirtualHubId, 'VpnServerConfigurationId>, value: azurerm.PointToSiteVpnGateway.PointToSiteVpnGatewayTimeouts) : PointToSiteVpnGatewayState<'ConnectionConfiguration, 'Location, 'Name, 'ResourceGroupName, 'ScaleUnit, 'VirtualHubId, 'VpnServerConfigurationId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : PointToSiteVpnGatewayState<'ConnectionConfiguration, 'Location, 'Name, 'ResourceGroupName, 'ScaleUnit, 'VirtualHubId, 'VpnServerConfigurationId>

        member _.Run(state: PointToSiteVpnGatewayState<Present, Present, Present, Present, Present, Present, Present>) : azurerm.PointToSiteVpnGateway.PointToSiteVpnGateway =
            let config = azurerm.PointToSiteVpnGateway.PointToSiteVpnGatewayConfig()
            for setter in state.assignments do
                setter config
            azurerm.PointToSiteVpnGateway.PointToSiteVpnGateway(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.pointToSiteVpnGateway: missing required arguments. Must call: connection_configuration, location, name, resource_group_name, scale_unit, virtual_hub_id, vpn_server_configuration_id.", 9999, IsError = true)>]
        member _.Run(_: PointToSiteVpnGatewayState<_, _, _, _, _, _, _>) : azurerm.PointToSiteVpnGateway.PointToSiteVpnGateway =
            Unchecked.defaultof<azurerm.PointToSiteVpnGateway.PointToSiteVpnGateway>

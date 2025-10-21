namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VpnGatewayConnectionState<'Name, 'RemoteVpnSiteId, 'VpnGatewayId, 'VpnLink> = { assignments: ResizeArray<azurerm.VpnGatewayConnection.VpnGatewayConnectionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway_connection">azurerm_vpn_gateway_connection</a>.
    /// </summary>
    type VpnGatewayConnectionBuilder(logicalId: string) =
        member _.Yield(_: unit) : VpnGatewayConnectionState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : VpnGatewayConnectionState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : VpnGatewayConnectionState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : VpnGatewayConnectionState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway_connection#name-1">VpnGatewayConnection#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: VpnGatewayConnectionState<Missing, 'RemoteVpnSiteId, 'VpnGatewayId, 'VpnLink>, value: string) : VpnGatewayConnectionState<Present, 'RemoteVpnSiteId, 'VpnGatewayId, 'VpnLink> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : VpnGatewayConnectionState<Present, 'RemoteVpnSiteId, 'VpnGatewayId, 'VpnLink>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway_connection#remote_vpn_site_id-1">VpnGatewayConnection#remote_vpn_site_id</a>.
        /// </summary>
        [<CustomOperation "remote_vpn_site_id">]
        member _.RemoteVpnSiteId(state: VpnGatewayConnectionState<'Name, Missing, 'VpnGatewayId, 'VpnLink>, value: string) : VpnGatewayConnectionState<'Name, Present, 'VpnGatewayId, 'VpnLink> =
            state.assignments.Add(fun config -> config.RemoteVpnSiteId <- value)
            ({ assignments = state.assignments } : VpnGatewayConnectionState<'Name, Present, 'VpnGatewayId, 'VpnLink>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway_connection#vpn_gateway_id-1">VpnGatewayConnection#vpn_gateway_id</a>.
        /// </summary>
        [<CustomOperation "vpn_gateway_id">]
        member _.VpnGatewayId(state: VpnGatewayConnectionState<'Name, 'RemoteVpnSiteId, Missing, 'VpnLink>, value: string) : VpnGatewayConnectionState<'Name, 'RemoteVpnSiteId, Present, 'VpnLink> =
            state.assignments.Add(fun config -> config.VpnGatewayId <- value)
            ({ assignments = state.assignments } : VpnGatewayConnectionState<'Name, 'RemoteVpnSiteId, Present, 'VpnLink>)

        /// <summary>
        /// vpn_link block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway_connection#vpn_link-1">VpnGatewayConnection#vpn_link</a> Accepts: azurerm.IResolvable | azurerm.VpnGatewayConnection.VpnGatewayConnectionVpnLink[]
        /// </summary>
        [<CustomOperation "vpn_link">]
        member _.VpnLink(state: VpnGatewayConnectionState<'Name, 'RemoteVpnSiteId, 'VpnGatewayId, Missing>, value: HashiCorp.Cdktf.IResolvable) : VpnGatewayConnectionState<'Name, 'RemoteVpnSiteId, 'VpnGatewayId, Present> =
            state.assignments.Add(fun config -> config.VpnLink <- value)
            ({ assignments = state.assignments } : VpnGatewayConnectionState<'Name, 'RemoteVpnSiteId, 'VpnGatewayId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway_connection#id-1">VpnGatewayConnection#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VpnGatewayConnectionState<'Name, 'RemoteVpnSiteId, 'VpnGatewayId, 'VpnLink>, value: string) : VpnGatewayConnectionState<'Name, 'RemoteVpnSiteId, 'VpnGatewayId, 'VpnLink> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VpnGatewayConnectionState<'Name, 'RemoteVpnSiteId, 'VpnGatewayId, 'VpnLink>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway_connection#internet_security_enabled-1">VpnGatewayConnection#internet_security_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "internet_security_enabled">]
        member _.InternetSecurityEnabled(state: VpnGatewayConnectionState<'Name, 'RemoteVpnSiteId, 'VpnGatewayId, 'VpnLink>, value: bool) : VpnGatewayConnectionState<'Name, 'RemoteVpnSiteId, 'VpnGatewayId, 'VpnLink> =
            state.assignments.Add(fun config -> config.InternetSecurityEnabled <- value)
            state : VpnGatewayConnectionState<'Name, 'RemoteVpnSiteId, 'VpnGatewayId, 'VpnLink>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway_connection#internet_security_enabled-1">VpnGatewayConnection#internet_security_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "internet_security_enabled">]
        member _.InternetSecurityEnabled(state: VpnGatewayConnectionState<'Name, 'RemoteVpnSiteId, 'VpnGatewayId, 'VpnLink>, value: HashiCorp.Cdktf.IResolvable) : VpnGatewayConnectionState<'Name, 'RemoteVpnSiteId, 'VpnGatewayId, 'VpnLink> =
            state.assignments.Add(fun config -> config.InternetSecurityEnabled <- value)
            state : VpnGatewayConnectionState<'Name, 'RemoteVpnSiteId, 'VpnGatewayId, 'VpnLink>

        /// <summary>
        /// routing block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway_connection#routing-1">VpnGatewayConnection#routing</a>
        /// </summary>
        [<CustomOperation "routing">]
        member _.Routing(state: VpnGatewayConnectionState<'Name, 'RemoteVpnSiteId, 'VpnGatewayId, 'VpnLink>, value: azurerm.VpnGatewayConnection.VpnGatewayConnectionRouting) : VpnGatewayConnectionState<'Name, 'RemoteVpnSiteId, 'VpnGatewayId, 'VpnLink> =
            state.assignments.Add(fun config -> config.Routing <- value)
            state : VpnGatewayConnectionState<'Name, 'RemoteVpnSiteId, 'VpnGatewayId, 'VpnLink>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway_connection#timeouts-1">VpnGatewayConnection#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: VpnGatewayConnectionState<'Name, 'RemoteVpnSiteId, 'VpnGatewayId, 'VpnLink>, value: azurerm.VpnGatewayConnection.VpnGatewayConnectionTimeouts) : VpnGatewayConnectionState<'Name, 'RemoteVpnSiteId, 'VpnGatewayId, 'VpnLink> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : VpnGatewayConnectionState<'Name, 'RemoteVpnSiteId, 'VpnGatewayId, 'VpnLink>

        /// <summary>
        /// traffic_selector_policy block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway_connection#traffic_selector_policy-1">VpnGatewayConnection#traffic_selector_policy</a> Accepts: azurerm.IResolvable | azurerm.VpnGatewayConnection.VpnGatewayConnectionTrafficSelectorPolicy[]
        /// </summary>
        [<CustomOperation "traffic_selector_policy">]
        member _.TrafficSelectorPolicy(state: VpnGatewayConnectionState<'Name, 'RemoteVpnSiteId, 'VpnGatewayId, 'VpnLink>, value: HashiCorp.Cdktf.IResolvable) : VpnGatewayConnectionState<'Name, 'RemoteVpnSiteId, 'VpnGatewayId, 'VpnLink> =
            state.assignments.Add(fun config -> config.TrafficSelectorPolicy <- value)
            state : VpnGatewayConnectionState<'Name, 'RemoteVpnSiteId, 'VpnGatewayId, 'VpnLink>

        member _.Run(state: VpnGatewayConnectionState<Present, Present, Present, Present>) : azurerm.VpnGatewayConnection.VpnGatewayConnection =
            let config = azurerm.VpnGatewayConnection.VpnGatewayConnectionConfig()
            for setter in state.assignments do
                setter config
            azurerm.VpnGatewayConnection.VpnGatewayConnection(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.vpnGatewayConnection: missing required arguments. Must call: name, remote_vpn_site_id, vpn_gateway_id, vpn_link.", 9999, IsError = true)>]
        member _.Run(_: VpnGatewayConnectionState<_, _, _, _>) : azurerm.VpnGatewayConnection.VpnGatewayConnection =
            Unchecked.defaultof<azurerm.VpnGatewayConnection.VpnGatewayConnection>

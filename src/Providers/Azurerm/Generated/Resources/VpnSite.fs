namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VpnSiteState<'Location, 'Name, 'ResourceGroupName, 'VirtualWanId> = { assignments: ResizeArray<azurerm.VpnSite.VpnSiteConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_site">azurerm_vpn_site</a>.
    /// </summary>
    type VpnSiteBuilder(logicalId: string) =
        member _.Yield(_: unit) : VpnSiteState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : VpnSiteState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : VpnSiteState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : VpnSiteState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_site#location-1">VpnSite#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: VpnSiteState<Missing, 'Name, 'ResourceGroupName, 'VirtualWanId>, value: string) : VpnSiteState<Present, 'Name, 'ResourceGroupName, 'VirtualWanId> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : VpnSiteState<Present, 'Name, 'ResourceGroupName, 'VirtualWanId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_site#name-1">VpnSite#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: VpnSiteState<'Location, Missing, 'ResourceGroupName, 'VirtualWanId>, value: string) : VpnSiteState<'Location, Present, 'ResourceGroupName, 'VirtualWanId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : VpnSiteState<'Location, Present, 'ResourceGroupName, 'VirtualWanId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_site#resource_group_name-1">VpnSite#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: VpnSiteState<'Location, 'Name, Missing, 'VirtualWanId>, value: string) : VpnSiteState<'Location, 'Name, Present, 'VirtualWanId> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : VpnSiteState<'Location, 'Name, Present, 'VirtualWanId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_site#virtual_wan_id-1">VpnSite#virtual_wan_id</a>.
        /// </summary>
        [<CustomOperation "virtual_wan_id">]
        member _.VirtualWanId(state: VpnSiteState<'Location, 'Name, 'ResourceGroupName, Missing>, value: string) : VpnSiteState<'Location, 'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.VirtualWanId <- value)
            ({ assignments = state.assignments } : VpnSiteState<'Location, 'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_site#address_cidrs-1">VpnSite#address_cidrs</a>.
        /// </summary>
        [<CustomOperation "address_cidrs">]
        member _.AddressCidrs(state: VpnSiteState<'Location, 'Name, 'ResourceGroupName, 'VirtualWanId>, value: seq<string>) : VpnSiteState<'Location, 'Name, 'ResourceGroupName, 'VirtualWanId> =
            state.assignments.Add(fun config -> config.AddressCidrs <- (value |> Seq.toArray))
            state : VpnSiteState<'Location, 'Name, 'ResourceGroupName, 'VirtualWanId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_site#device_model-1">VpnSite#device_model</a>.
        /// </summary>
        [<CustomOperation "device_model">]
        member _.DeviceModel(state: VpnSiteState<'Location, 'Name, 'ResourceGroupName, 'VirtualWanId>, value: string) : VpnSiteState<'Location, 'Name, 'ResourceGroupName, 'VirtualWanId> =
            state.assignments.Add(fun config -> config.DeviceModel <- value)
            state : VpnSiteState<'Location, 'Name, 'ResourceGroupName, 'VirtualWanId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_site#device_vendor-1">VpnSite#device_vendor</a>.
        /// </summary>
        [<CustomOperation "device_vendor">]
        member _.DeviceVendor(state: VpnSiteState<'Location, 'Name, 'ResourceGroupName, 'VirtualWanId>, value: string) : VpnSiteState<'Location, 'Name, 'ResourceGroupName, 'VirtualWanId> =
            state.assignments.Add(fun config -> config.DeviceVendor <- value)
            state : VpnSiteState<'Location, 'Name, 'ResourceGroupName, 'VirtualWanId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_site#id-1">VpnSite#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VpnSiteState<'Location, 'Name, 'ResourceGroupName, 'VirtualWanId>, value: string) : VpnSiteState<'Location, 'Name, 'ResourceGroupName, 'VirtualWanId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VpnSiteState<'Location, 'Name, 'ResourceGroupName, 'VirtualWanId>

        /// <summary>
        /// link block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_site#link-1">VpnSite#link</a> Accepts: azurerm.IResolvable | azurerm.VpnSite.VpnSiteLink[]
        /// </summary>
        [<CustomOperation "link">]
        member _.Link(state: VpnSiteState<'Location, 'Name, 'ResourceGroupName, 'VirtualWanId>, value: HashiCorp.Cdktf.IResolvable) : VpnSiteState<'Location, 'Name, 'ResourceGroupName, 'VirtualWanId> =
            state.assignments.Add(fun config -> config.Link <- value)
            state : VpnSiteState<'Location, 'Name, 'ResourceGroupName, 'VirtualWanId>

        /// <summary>
        /// o365_policy block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_site#o365_policy-1">VpnSite#o365_policy</a>
        /// </summary>
        [<CustomOperation "o365_policy">]
        member _.O365Policy(state: VpnSiteState<'Location, 'Name, 'ResourceGroupName, 'VirtualWanId>, value: azurerm.VpnSite.VpnSiteO365Policy) : VpnSiteState<'Location, 'Name, 'ResourceGroupName, 'VirtualWanId> =
            state.assignments.Add(fun config -> config.O365Policy <- value)
            state : VpnSiteState<'Location, 'Name, 'ResourceGroupName, 'VirtualWanId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_site#tags-1">VpnSite#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: VpnSiteState<'Location, 'Name, 'ResourceGroupName, 'VirtualWanId>, value: seq<string * string>) : VpnSiteState<'Location, 'Name, 'ResourceGroupName, 'VirtualWanId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : VpnSiteState<'Location, 'Name, 'ResourceGroupName, 'VirtualWanId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_site#timeouts-1">VpnSite#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: VpnSiteState<'Location, 'Name, 'ResourceGroupName, 'VirtualWanId>, value: azurerm.VpnSite.VpnSiteTimeouts) : VpnSiteState<'Location, 'Name, 'ResourceGroupName, 'VirtualWanId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : VpnSiteState<'Location, 'Name, 'ResourceGroupName, 'VirtualWanId>

        member _.Run(state: VpnSiteState<Present, Present, Present, Present>) : azurerm.VpnSite.VpnSite =
            let config = azurerm.VpnSite.VpnSiteConfig()
            for setter in state.assignments do
                setter config
            azurerm.VpnSite.VpnSite(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.vpnSite: missing required arguments. Must call: location, name, resource_group_name, virtual_wan_id.", 9999, IsError = true)>]
        member _.Run(_: VpnSiteState<_, _, _, _>) : azurerm.VpnSite.VpnSite =
            Unchecked.defaultof<azurerm.VpnSite.VpnSite>

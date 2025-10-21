namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LocalNetworkGatewayState<'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.LocalNetworkGateway.LocalNetworkGatewayConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/local_network_gateway">azurerm_local_network_gateway</a>.
    /// </summary>
    type LocalNetworkGatewayBuilder(logicalId: string) =
        member _.Yield(_: unit) : LocalNetworkGatewayState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LocalNetworkGatewayState<Missing, Missing, Missing>)

        member _.Zero(()) : LocalNetworkGatewayState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LocalNetworkGatewayState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/local_network_gateway#location-1">LocalNetworkGateway#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: LocalNetworkGatewayState<Missing, 'Name, 'ResourceGroupName>, value: string) : LocalNetworkGatewayState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : LocalNetworkGatewayState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/local_network_gateway#name-1">LocalNetworkGateway#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: LocalNetworkGatewayState<'Location, Missing, 'ResourceGroupName>, value: string) : LocalNetworkGatewayState<'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : LocalNetworkGatewayState<'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/local_network_gateway#resource_group_name-1">LocalNetworkGateway#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: LocalNetworkGatewayState<'Location, 'Name, Missing>, value: string) : LocalNetworkGatewayState<'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : LocalNetworkGatewayState<'Location, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/local_network_gateway#address_space-1">LocalNetworkGateway#address_space</a>.
        /// </summary>
        [<CustomOperation "address_space">]
        member _.AddressSpace(state: LocalNetworkGatewayState<'Location, 'Name, 'ResourceGroupName>, value: seq<string>) : LocalNetworkGatewayState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AddressSpace <- (value |> Seq.toArray))
            state : LocalNetworkGatewayState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// bgp_settings block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/local_network_gateway#bgp_settings-1">LocalNetworkGateway#bgp_settings</a>
        /// </summary>
        [<CustomOperation "bgp_settings">]
        member _.BgpSettings(state: LocalNetworkGatewayState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.LocalNetworkGateway.LocalNetworkGatewayBgpSettings) : LocalNetworkGatewayState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.BgpSettings <- value)
            state : LocalNetworkGatewayState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/local_network_gateway#gateway_address-1">LocalNetworkGateway#gateway_address</a>.
        /// </summary>
        [<CustomOperation "gateway_address">]
        member _.GatewayAddress(state: LocalNetworkGatewayState<'Location, 'Name, 'ResourceGroupName>, value: string) : LocalNetworkGatewayState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.GatewayAddress <- value)
            state : LocalNetworkGatewayState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/local_network_gateway#gateway_fqdn-1">LocalNetworkGateway#gateway_fqdn</a>.
        /// </summary>
        [<CustomOperation "gateway_fqdn">]
        member _.GatewayFqdn(state: LocalNetworkGatewayState<'Location, 'Name, 'ResourceGroupName>, value: string) : LocalNetworkGatewayState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.GatewayFqdn <- value)
            state : LocalNetworkGatewayState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/local_network_gateway#id-1">LocalNetworkGateway#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LocalNetworkGatewayState<'Location, 'Name, 'ResourceGroupName>, value: string) : LocalNetworkGatewayState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LocalNetworkGatewayState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/local_network_gateway#tags-1">LocalNetworkGateway#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: LocalNetworkGatewayState<'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : LocalNetworkGatewayState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : LocalNetworkGatewayState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/local_network_gateway#timeouts-1">LocalNetworkGateway#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: LocalNetworkGatewayState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.LocalNetworkGateway.LocalNetworkGatewayTimeouts) : LocalNetworkGatewayState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : LocalNetworkGatewayState<'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: LocalNetworkGatewayState<Present, Present, Present>) : azurerm.LocalNetworkGateway.LocalNetworkGateway =
            let config = azurerm.LocalNetworkGateway.LocalNetworkGatewayConfig()
            for setter in state.assignments do
                setter config
            azurerm.LocalNetworkGateway.LocalNetworkGateway(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.localNetworkGateway: missing required arguments. Must call: location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: LocalNetworkGatewayState<_, _, _>) : azurerm.LocalNetworkGateway.LocalNetworkGateway =
            Unchecked.defaultof<azurerm.LocalNetworkGateway.LocalNetworkGateway>

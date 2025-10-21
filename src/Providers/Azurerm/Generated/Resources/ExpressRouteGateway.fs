namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ExpressRouteGatewayState<'Location, 'Name, 'ResourceGroupName, 'ScaleUnits, 'VirtualHubId> = { assignments: ResizeArray<azurerm.ExpressRouteGateway.ExpressRouteGatewayConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_gateway">azurerm_express_route_gateway</a>.
    /// </summary>
    type ExpressRouteGatewayBuilder(logicalId: string) =
        member _.Yield(_: unit) : ExpressRouteGatewayState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ExpressRouteGatewayState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ExpressRouteGatewayState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ExpressRouteGatewayState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_gateway#location-1">ExpressRouteGateway#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: ExpressRouteGatewayState<Missing, 'Name, 'ResourceGroupName, 'ScaleUnits, 'VirtualHubId>, value: string) : ExpressRouteGatewayState<Present, 'Name, 'ResourceGroupName, 'ScaleUnits, 'VirtualHubId> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : ExpressRouteGatewayState<Present, 'Name, 'ResourceGroupName, 'ScaleUnits, 'VirtualHubId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_gateway#name-1">ExpressRouteGateway#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ExpressRouteGatewayState<'Location, Missing, 'ResourceGroupName, 'ScaleUnits, 'VirtualHubId>, value: string) : ExpressRouteGatewayState<'Location, Present, 'ResourceGroupName, 'ScaleUnits, 'VirtualHubId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ExpressRouteGatewayState<'Location, Present, 'ResourceGroupName, 'ScaleUnits, 'VirtualHubId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_gateway#resource_group_name-1">ExpressRouteGateway#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: ExpressRouteGatewayState<'Location, 'Name, Missing, 'ScaleUnits, 'VirtualHubId>, value: string) : ExpressRouteGatewayState<'Location, 'Name, Present, 'ScaleUnits, 'VirtualHubId> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : ExpressRouteGatewayState<'Location, 'Name, Present, 'ScaleUnits, 'VirtualHubId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_gateway#scale_units-1">ExpressRouteGateway#scale_units</a>.
        /// </summary>
        [<CustomOperation "scale_units">]
        member _.ScaleUnits(state: ExpressRouteGatewayState<'Location, 'Name, 'ResourceGroupName, Missing, 'VirtualHubId>, value: double) : ExpressRouteGatewayState<'Location, 'Name, 'ResourceGroupName, Present, 'VirtualHubId> =
            state.assignments.Add(fun config -> config.ScaleUnits <- value)
            ({ assignments = state.assignments } : ExpressRouteGatewayState<'Location, 'Name, 'ResourceGroupName, Present, 'VirtualHubId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_gateway#virtual_hub_id-1">ExpressRouteGateway#virtual_hub_id</a>.
        /// </summary>
        [<CustomOperation "virtual_hub_id">]
        member _.VirtualHubId(state: ExpressRouteGatewayState<'Location, 'Name, 'ResourceGroupName, 'ScaleUnits, Missing>, value: string) : ExpressRouteGatewayState<'Location, 'Name, 'ResourceGroupName, 'ScaleUnits, Present> =
            state.assignments.Add(fun config -> config.VirtualHubId <- value)
            ({ assignments = state.assignments } : ExpressRouteGatewayState<'Location, 'Name, 'ResourceGroupName, 'ScaleUnits, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_gateway#allow_non_virtual_wan_traffic-1">ExpressRouteGateway#allow_non_virtual_wan_traffic</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "allow_non_virtual_wan_traffic">]
        member _.AllowNonVirtualWanTraffic(state: ExpressRouteGatewayState<'Location, 'Name, 'ResourceGroupName, 'ScaleUnits, 'VirtualHubId>, value: bool) : ExpressRouteGatewayState<'Location, 'Name, 'ResourceGroupName, 'ScaleUnits, 'VirtualHubId> =
            state.assignments.Add(fun config -> config.AllowNonVirtualWanTraffic <- value)
            state : ExpressRouteGatewayState<'Location, 'Name, 'ResourceGroupName, 'ScaleUnits, 'VirtualHubId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_gateway#allow_non_virtual_wan_traffic-1">ExpressRouteGateway#allow_non_virtual_wan_traffic</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "allow_non_virtual_wan_traffic">]
        member _.AllowNonVirtualWanTraffic(state: ExpressRouteGatewayState<'Location, 'Name, 'ResourceGroupName, 'ScaleUnits, 'VirtualHubId>, value: HashiCorp.Cdktf.IResolvable) : ExpressRouteGatewayState<'Location, 'Name, 'ResourceGroupName, 'ScaleUnits, 'VirtualHubId> =
            state.assignments.Add(fun config -> config.AllowNonVirtualWanTraffic <- value)
            state : ExpressRouteGatewayState<'Location, 'Name, 'ResourceGroupName, 'ScaleUnits, 'VirtualHubId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_gateway#id-1">ExpressRouteGateway#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ExpressRouteGatewayState<'Location, 'Name, 'ResourceGroupName, 'ScaleUnits, 'VirtualHubId>, value: string) : ExpressRouteGatewayState<'Location, 'Name, 'ResourceGroupName, 'ScaleUnits, 'VirtualHubId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ExpressRouteGatewayState<'Location, 'Name, 'ResourceGroupName, 'ScaleUnits, 'VirtualHubId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_gateway#tags-1">ExpressRouteGateway#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ExpressRouteGatewayState<'Location, 'Name, 'ResourceGroupName, 'ScaleUnits, 'VirtualHubId>, value: seq<string * string>) : ExpressRouteGatewayState<'Location, 'Name, 'ResourceGroupName, 'ScaleUnits, 'VirtualHubId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ExpressRouteGatewayState<'Location, 'Name, 'ResourceGroupName, 'ScaleUnits, 'VirtualHubId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_gateway#timeouts-1">ExpressRouteGateway#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ExpressRouteGatewayState<'Location, 'Name, 'ResourceGroupName, 'ScaleUnits, 'VirtualHubId>, value: azurerm.ExpressRouteGateway.ExpressRouteGatewayTimeouts) : ExpressRouteGatewayState<'Location, 'Name, 'ResourceGroupName, 'ScaleUnits, 'VirtualHubId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ExpressRouteGatewayState<'Location, 'Name, 'ResourceGroupName, 'ScaleUnits, 'VirtualHubId>

        member _.Run(state: ExpressRouteGatewayState<Present, Present, Present, Present, Present>) : azurerm.ExpressRouteGateway.ExpressRouteGateway =
            let config = azurerm.ExpressRouteGateway.ExpressRouteGatewayConfig()
            for setter in state.assignments do
                setter config
            azurerm.ExpressRouteGateway.ExpressRouteGateway(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.expressRouteGateway: missing required arguments. Must call: location, name, resource_group_name, scale_units, virtual_hub_id.", 9999, IsError = true)>]
        member _.Run(_: ExpressRouteGatewayState<_, _, _, _, _>) : azurerm.ExpressRouteGateway.ExpressRouteGateway =
            Unchecked.defaultof<azurerm.ExpressRouteGateway.ExpressRouteGateway>

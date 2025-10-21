namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ExpressRoutePortState<'BandwidthInGbps, 'Encapsulation, 'Location, 'Name, 'PeeringLocation, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.ExpressRoutePort.ExpressRoutePortConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_port">azurerm_express_route_port</a>.
    /// </summary>
    type ExpressRoutePortBuilder(logicalId: string) =
        member _.Yield(_: unit) : ExpressRoutePortState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ExpressRoutePortState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ExpressRoutePortState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ExpressRoutePortState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_port#bandwidth_in_gbps-1">ExpressRoutePort#bandwidth_in_gbps</a>.
        /// </summary>
        [<CustomOperation "bandwidth_in_gbps">]
        member _.BandwidthInGbps(state: ExpressRoutePortState<Missing, 'Encapsulation, 'Location, 'Name, 'PeeringLocation, 'ResourceGroupName>, value: double) : ExpressRoutePortState<Present, 'Encapsulation, 'Location, 'Name, 'PeeringLocation, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.BandwidthInGbps <- value)
            ({ assignments = state.assignments } : ExpressRoutePortState<Present, 'Encapsulation, 'Location, 'Name, 'PeeringLocation, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_port#encapsulation-1">ExpressRoutePort#encapsulation</a>.
        /// </summary>
        [<CustomOperation "encapsulation">]
        member _.Encapsulation(state: ExpressRoutePortState<'BandwidthInGbps, Missing, 'Location, 'Name, 'PeeringLocation, 'ResourceGroupName>, value: string) : ExpressRoutePortState<'BandwidthInGbps, Present, 'Location, 'Name, 'PeeringLocation, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Encapsulation <- value)
            ({ assignments = state.assignments } : ExpressRoutePortState<'BandwidthInGbps, Present, 'Location, 'Name, 'PeeringLocation, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_port#location-1">ExpressRoutePort#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: ExpressRoutePortState<'BandwidthInGbps, 'Encapsulation, Missing, 'Name, 'PeeringLocation, 'ResourceGroupName>, value: string) : ExpressRoutePortState<'BandwidthInGbps, 'Encapsulation, Present, 'Name, 'PeeringLocation, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : ExpressRoutePortState<'BandwidthInGbps, 'Encapsulation, Present, 'Name, 'PeeringLocation, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_port#name-1">ExpressRoutePort#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ExpressRoutePortState<'BandwidthInGbps, 'Encapsulation, 'Location, Missing, 'PeeringLocation, 'ResourceGroupName>, value: string) : ExpressRoutePortState<'BandwidthInGbps, 'Encapsulation, 'Location, Present, 'PeeringLocation, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ExpressRoutePortState<'BandwidthInGbps, 'Encapsulation, 'Location, Present, 'PeeringLocation, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_port#peering_location-1">ExpressRoutePort#peering_location</a>.
        /// </summary>
        [<CustomOperation "peering_location">]
        member _.PeeringLocation(state: ExpressRoutePortState<'BandwidthInGbps, 'Encapsulation, 'Location, 'Name, Missing, 'ResourceGroupName>, value: string) : ExpressRoutePortState<'BandwidthInGbps, 'Encapsulation, 'Location, 'Name, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.PeeringLocation <- value)
            ({ assignments = state.assignments } : ExpressRoutePortState<'BandwidthInGbps, 'Encapsulation, 'Location, 'Name, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_port#resource_group_name-1">ExpressRoutePort#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: ExpressRoutePortState<'BandwidthInGbps, 'Encapsulation, 'Location, 'Name, 'PeeringLocation, Missing>, value: string) : ExpressRoutePortState<'BandwidthInGbps, 'Encapsulation, 'Location, 'Name, 'PeeringLocation, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : ExpressRoutePortState<'BandwidthInGbps, 'Encapsulation, 'Location, 'Name, 'PeeringLocation, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_port#billing_type-1">ExpressRoutePort#billing_type</a>.
        /// </summary>
        [<CustomOperation "billing_type">]
        member _.BillingType(state: ExpressRoutePortState<'BandwidthInGbps, 'Encapsulation, 'Location, 'Name, 'PeeringLocation, 'ResourceGroupName>, value: string) : ExpressRoutePortState<'BandwidthInGbps, 'Encapsulation, 'Location, 'Name, 'PeeringLocation, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.BillingType <- value)
            state : ExpressRoutePortState<'BandwidthInGbps, 'Encapsulation, 'Location, 'Name, 'PeeringLocation, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_port#id-1">ExpressRoutePort#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ExpressRoutePortState<'BandwidthInGbps, 'Encapsulation, 'Location, 'Name, 'PeeringLocation, 'ResourceGroupName>, value: string) : ExpressRoutePortState<'BandwidthInGbps, 'Encapsulation, 'Location, 'Name, 'PeeringLocation, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ExpressRoutePortState<'BandwidthInGbps, 'Encapsulation, 'Location, 'Name, 'PeeringLocation, 'ResourceGroupName>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_port#identity-1">ExpressRoutePort#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: ExpressRoutePortState<'BandwidthInGbps, 'Encapsulation, 'Location, 'Name, 'PeeringLocation, 'ResourceGroupName>, value: azurerm.ExpressRoutePort.ExpressRoutePortIdentity) : ExpressRoutePortState<'BandwidthInGbps, 'Encapsulation, 'Location, 'Name, 'PeeringLocation, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : ExpressRoutePortState<'BandwidthInGbps, 'Encapsulation, 'Location, 'Name, 'PeeringLocation, 'ResourceGroupName>

        /// <summary>
        /// link1 block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_port#link1-1">ExpressRoutePort#link1</a>
        /// </summary>
        [<CustomOperation "link1">]
        member _.Link1(state: ExpressRoutePortState<'BandwidthInGbps, 'Encapsulation, 'Location, 'Name, 'PeeringLocation, 'ResourceGroupName>, value: azurerm.ExpressRoutePort.ExpressRoutePortLink1) : ExpressRoutePortState<'BandwidthInGbps, 'Encapsulation, 'Location, 'Name, 'PeeringLocation, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Link1 <- value)
            state : ExpressRoutePortState<'BandwidthInGbps, 'Encapsulation, 'Location, 'Name, 'PeeringLocation, 'ResourceGroupName>

        /// <summary>
        /// link2 block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_port#link2-1">ExpressRoutePort#link2</a>
        /// </summary>
        [<CustomOperation "link2">]
        member _.Link2(state: ExpressRoutePortState<'BandwidthInGbps, 'Encapsulation, 'Location, 'Name, 'PeeringLocation, 'ResourceGroupName>, value: azurerm.ExpressRoutePort.ExpressRoutePortLink2) : ExpressRoutePortState<'BandwidthInGbps, 'Encapsulation, 'Location, 'Name, 'PeeringLocation, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Link2 <- value)
            state : ExpressRoutePortState<'BandwidthInGbps, 'Encapsulation, 'Location, 'Name, 'PeeringLocation, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_port#tags-1">ExpressRoutePort#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ExpressRoutePortState<'BandwidthInGbps, 'Encapsulation, 'Location, 'Name, 'PeeringLocation, 'ResourceGroupName>, value: seq<string * string>) : ExpressRoutePortState<'BandwidthInGbps, 'Encapsulation, 'Location, 'Name, 'PeeringLocation, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ExpressRoutePortState<'BandwidthInGbps, 'Encapsulation, 'Location, 'Name, 'PeeringLocation, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_port#timeouts-1">ExpressRoutePort#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ExpressRoutePortState<'BandwidthInGbps, 'Encapsulation, 'Location, 'Name, 'PeeringLocation, 'ResourceGroupName>, value: azurerm.ExpressRoutePort.ExpressRoutePortTimeouts) : ExpressRoutePortState<'BandwidthInGbps, 'Encapsulation, 'Location, 'Name, 'PeeringLocation, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ExpressRoutePortState<'BandwidthInGbps, 'Encapsulation, 'Location, 'Name, 'PeeringLocation, 'ResourceGroupName>

        member _.Run(state: ExpressRoutePortState<Present, Present, Present, Present, Present, Present>) : azurerm.ExpressRoutePort.ExpressRoutePort =
            let config = azurerm.ExpressRoutePort.ExpressRoutePortConfig()
            for setter in state.assignments do
                setter config
            azurerm.ExpressRoutePort.ExpressRoutePort(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.expressRoutePort: missing required arguments. Must call: bandwidth_in_gbps, encapsulation, location, name, peering_location, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: ExpressRoutePortState<_, _, _, _, _, _>) : azurerm.ExpressRoutePort.ExpressRoutePort =
            Unchecked.defaultof<azurerm.ExpressRoutePort.ExpressRoutePort>

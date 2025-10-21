namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type RouteState<'AddressPrefix, 'Name, 'NextHopType, 'ResourceGroupName, 'RouteTableName> = { assignments: ResizeArray<azurerm.Route.RouteConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/route">azurerm_route</a>.
    /// </summary>
    type RouteBuilder(logicalId: string) =
        member _.Yield(_: unit) : RouteState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : RouteState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : RouteState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : RouteState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/route#address_prefix-1">Route#address_prefix</a>.
        /// </summary>
        [<CustomOperation "address_prefix">]
        member _.AddressPrefix(state: RouteState<Missing, 'Name, 'NextHopType, 'ResourceGroupName, 'RouteTableName>, value: string) : RouteState<Present, 'Name, 'NextHopType, 'ResourceGroupName, 'RouteTableName> =
            state.assignments.Add(fun config -> config.AddressPrefix <- value)
            ({ assignments = state.assignments } : RouteState<Present, 'Name, 'NextHopType, 'ResourceGroupName, 'RouteTableName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/route#name-1">Route#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: RouteState<'AddressPrefix, Missing, 'NextHopType, 'ResourceGroupName, 'RouteTableName>, value: string) : RouteState<'AddressPrefix, Present, 'NextHopType, 'ResourceGroupName, 'RouteTableName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : RouteState<'AddressPrefix, Present, 'NextHopType, 'ResourceGroupName, 'RouteTableName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/route#next_hop_type-1">Route#next_hop_type</a>.
        /// </summary>
        [<CustomOperation "next_hop_type">]
        member _.NextHopType(state: RouteState<'AddressPrefix, 'Name, Missing, 'ResourceGroupName, 'RouteTableName>, value: string) : RouteState<'AddressPrefix, 'Name, Present, 'ResourceGroupName, 'RouteTableName> =
            state.assignments.Add(fun config -> config.NextHopType <- value)
            ({ assignments = state.assignments } : RouteState<'AddressPrefix, 'Name, Present, 'ResourceGroupName, 'RouteTableName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/route#resource_group_name-1">Route#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: RouteState<'AddressPrefix, 'Name, 'NextHopType, Missing, 'RouteTableName>, value: string) : RouteState<'AddressPrefix, 'Name, 'NextHopType, Present, 'RouteTableName> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : RouteState<'AddressPrefix, 'Name, 'NextHopType, Present, 'RouteTableName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/route#route_table_name-1">Route#route_table_name</a>.
        /// </summary>
        [<CustomOperation "route_table_name">]
        member _.RouteTableName(state: RouteState<'AddressPrefix, 'Name, 'NextHopType, 'ResourceGroupName, Missing>, value: string) : RouteState<'AddressPrefix, 'Name, 'NextHopType, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.RouteTableName <- value)
            ({ assignments = state.assignments } : RouteState<'AddressPrefix, 'Name, 'NextHopType, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/route#id-1">Route#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: RouteState<'AddressPrefix, 'Name, 'NextHopType, 'ResourceGroupName, 'RouteTableName>, value: string) : RouteState<'AddressPrefix, 'Name, 'NextHopType, 'ResourceGroupName, 'RouteTableName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : RouteState<'AddressPrefix, 'Name, 'NextHopType, 'ResourceGroupName, 'RouteTableName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/route#next_hop_in_ip_address-1">Route#next_hop_in_ip_address</a>.
        /// </summary>
        [<CustomOperation "next_hop_in_ip_address">]
        member _.NextHopInIpAddress(state: RouteState<'AddressPrefix, 'Name, 'NextHopType, 'ResourceGroupName, 'RouteTableName>, value: string) : RouteState<'AddressPrefix, 'Name, 'NextHopType, 'ResourceGroupName, 'RouteTableName> =
            state.assignments.Add(fun config -> config.NextHopInIpAddress <- value)
            state : RouteState<'AddressPrefix, 'Name, 'NextHopType, 'ResourceGroupName, 'RouteTableName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/route#timeouts-1">Route#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: RouteState<'AddressPrefix, 'Name, 'NextHopType, 'ResourceGroupName, 'RouteTableName>, value: azurerm.Route.RouteTimeouts) : RouteState<'AddressPrefix, 'Name, 'NextHopType, 'ResourceGroupName, 'RouteTableName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : RouteState<'AddressPrefix, 'Name, 'NextHopType, 'ResourceGroupName, 'RouteTableName>

        member _.Run(state: RouteState<Present, Present, Present, Present, Present>) : azurerm.Route.Route =
            let config = azurerm.Route.RouteConfig()
            for setter in state.assignments do
                setter config
            azurerm.Route.Route(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.route: missing required arguments. Must call: address_prefix, name, next_hop_type, resource_group_name, route_table_name.", 9999, IsError = true)>]
        member _.Run(_: RouteState<_, _, _, _, _>) : azurerm.Route.Route =
            Unchecked.defaultof<azurerm.Route.Route>

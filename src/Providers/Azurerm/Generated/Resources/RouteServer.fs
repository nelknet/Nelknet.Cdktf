namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type RouteServerState<'Location, 'Name, 'PublicIpAddressId, 'ResourceGroupName, 'Sku, 'SubnetId> = { assignments: ResizeArray<azurerm.RouteServer.RouteServerConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/route_server">azurerm_route_server</a>.
    /// </summary>
    type RouteServerBuilder(logicalId: string) =
        member _.Yield(_: unit) : RouteServerState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : RouteServerState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : RouteServerState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : RouteServerState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/route_server#location-1">RouteServer#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: RouteServerState<Missing, 'Name, 'PublicIpAddressId, 'ResourceGroupName, 'Sku, 'SubnetId>, value: string) : RouteServerState<Present, 'Name, 'PublicIpAddressId, 'ResourceGroupName, 'Sku, 'SubnetId> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : RouteServerState<Present, 'Name, 'PublicIpAddressId, 'ResourceGroupName, 'Sku, 'SubnetId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/route_server#name-1">RouteServer#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: RouteServerState<'Location, Missing, 'PublicIpAddressId, 'ResourceGroupName, 'Sku, 'SubnetId>, value: string) : RouteServerState<'Location, Present, 'PublicIpAddressId, 'ResourceGroupName, 'Sku, 'SubnetId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : RouteServerState<'Location, Present, 'PublicIpAddressId, 'ResourceGroupName, 'Sku, 'SubnetId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/route_server#public_ip_address_id-1">RouteServer#public_ip_address_id</a>.
        /// </summary>
        [<CustomOperation "public_ip_address_id">]
        member _.PublicIpAddressId(state: RouteServerState<'Location, 'Name, Missing, 'ResourceGroupName, 'Sku, 'SubnetId>, value: string) : RouteServerState<'Location, 'Name, Present, 'ResourceGroupName, 'Sku, 'SubnetId> =
            state.assignments.Add(fun config -> config.PublicIpAddressId <- value)
            ({ assignments = state.assignments } : RouteServerState<'Location, 'Name, Present, 'ResourceGroupName, 'Sku, 'SubnetId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/route_server#resource_group_name-1">RouteServer#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: RouteServerState<'Location, 'Name, 'PublicIpAddressId, Missing, 'Sku, 'SubnetId>, value: string) : RouteServerState<'Location, 'Name, 'PublicIpAddressId, Present, 'Sku, 'SubnetId> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : RouteServerState<'Location, 'Name, 'PublicIpAddressId, Present, 'Sku, 'SubnetId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/route_server#sku-1">RouteServer#sku</a>.
        /// </summary>
        [<CustomOperation "sku">]
        member _.Sku(state: RouteServerState<'Location, 'Name, 'PublicIpAddressId, 'ResourceGroupName, Missing, 'SubnetId>, value: string) : RouteServerState<'Location, 'Name, 'PublicIpAddressId, 'ResourceGroupName, Present, 'SubnetId> =
            state.assignments.Add(fun config -> config.Sku <- value)
            ({ assignments = state.assignments } : RouteServerState<'Location, 'Name, 'PublicIpAddressId, 'ResourceGroupName, Present, 'SubnetId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/route_server#subnet_id-1">RouteServer#subnet_id</a>.
        /// </summary>
        [<CustomOperation "subnet_id">]
        member _.SubnetId(state: RouteServerState<'Location, 'Name, 'PublicIpAddressId, 'ResourceGroupName, 'Sku, Missing>, value: string) : RouteServerState<'Location, 'Name, 'PublicIpAddressId, 'ResourceGroupName, 'Sku, Present> =
            state.assignments.Add(fun config -> config.SubnetId <- value)
            ({ assignments = state.assignments } : RouteServerState<'Location, 'Name, 'PublicIpAddressId, 'ResourceGroupName, 'Sku, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/route_server#branch_to_branch_traffic_enabled-1">RouteServer#branch_to_branch_traffic_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "branch_to_branch_traffic_enabled">]
        member _.BranchToBranchTrafficEnabled(state: RouteServerState<'Location, 'Name, 'PublicIpAddressId, 'ResourceGroupName, 'Sku, 'SubnetId>, value: bool) : RouteServerState<'Location, 'Name, 'PublicIpAddressId, 'ResourceGroupName, 'Sku, 'SubnetId> =
            state.assignments.Add(fun config -> config.BranchToBranchTrafficEnabled <- value)
            state : RouteServerState<'Location, 'Name, 'PublicIpAddressId, 'ResourceGroupName, 'Sku, 'SubnetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/route_server#branch_to_branch_traffic_enabled-1">RouteServer#branch_to_branch_traffic_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "branch_to_branch_traffic_enabled">]
        member _.BranchToBranchTrafficEnabled(state: RouteServerState<'Location, 'Name, 'PublicIpAddressId, 'ResourceGroupName, 'Sku, 'SubnetId>, value: HashiCorp.Cdktf.IResolvable) : RouteServerState<'Location, 'Name, 'PublicIpAddressId, 'ResourceGroupName, 'Sku, 'SubnetId> =
            state.assignments.Add(fun config -> config.BranchToBranchTrafficEnabled <- value)
            state : RouteServerState<'Location, 'Name, 'PublicIpAddressId, 'ResourceGroupName, 'Sku, 'SubnetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/route_server#id-1">RouteServer#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: RouteServerState<'Location, 'Name, 'PublicIpAddressId, 'ResourceGroupName, 'Sku, 'SubnetId>, value: string) : RouteServerState<'Location, 'Name, 'PublicIpAddressId, 'ResourceGroupName, 'Sku, 'SubnetId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : RouteServerState<'Location, 'Name, 'PublicIpAddressId, 'ResourceGroupName, 'Sku, 'SubnetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/route_server#tags-1">RouteServer#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: RouteServerState<'Location, 'Name, 'PublicIpAddressId, 'ResourceGroupName, 'Sku, 'SubnetId>, value: seq<string * string>) : RouteServerState<'Location, 'Name, 'PublicIpAddressId, 'ResourceGroupName, 'Sku, 'SubnetId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : RouteServerState<'Location, 'Name, 'PublicIpAddressId, 'ResourceGroupName, 'Sku, 'SubnetId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/route_server#timeouts-1">RouteServer#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: RouteServerState<'Location, 'Name, 'PublicIpAddressId, 'ResourceGroupName, 'Sku, 'SubnetId>, value: azurerm.RouteServer.RouteServerTimeouts) : RouteServerState<'Location, 'Name, 'PublicIpAddressId, 'ResourceGroupName, 'Sku, 'SubnetId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : RouteServerState<'Location, 'Name, 'PublicIpAddressId, 'ResourceGroupName, 'Sku, 'SubnetId>

        member _.Run(state: RouteServerState<Present, Present, Present, Present, Present, Present>) : azurerm.RouteServer.RouteServer =
            let config = azurerm.RouteServer.RouteServerConfig()
            for setter in state.assignments do
                setter config
            azurerm.RouteServer.RouteServer(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.routeServer: missing required arguments. Must call: location, name, public_ip_address_id, resource_group_name, sku, subnet_id.", 9999, IsError = true)>]
        member _.Run(_: RouteServerState<_, _, _, _, _, _>) : azurerm.RouteServer.RouteServer =
            Unchecked.defaultof<azurerm.RouteServer.RouteServer>

namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VirtualHubState<'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.VirtualHub.VirtualHubConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub">azurerm_virtual_hub</a>.
    /// </summary>
    type VirtualHubBuilder(logicalId: string) =
        member _.Yield(_: unit) : VirtualHubState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : VirtualHubState<Missing, Missing, Missing>)

        member _.Zero(()) : VirtualHubState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : VirtualHubState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub#location-1">VirtualHub#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: VirtualHubState<Missing, 'Name, 'ResourceGroupName>, value: string) : VirtualHubState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : VirtualHubState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub#name-1">VirtualHub#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: VirtualHubState<'Location, Missing, 'ResourceGroupName>, value: string) : VirtualHubState<'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : VirtualHubState<'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub#resource_group_name-1">VirtualHub#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: VirtualHubState<'Location, 'Name, Missing>, value: string) : VirtualHubState<'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : VirtualHubState<'Location, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub#address_prefix-1">VirtualHub#address_prefix</a>.
        /// </summary>
        [<CustomOperation "address_prefix">]
        member _.AddressPrefix(state: VirtualHubState<'Location, 'Name, 'ResourceGroupName>, value: string) : VirtualHubState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AddressPrefix <- value)
            state : VirtualHubState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub#hub_routing_preference-1">VirtualHub#hub_routing_preference</a>.
        /// </summary>
        [<CustomOperation "hub_routing_preference">]
        member _.HubRoutingPreference(state: VirtualHubState<'Location, 'Name, 'ResourceGroupName>, value: string) : VirtualHubState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.HubRoutingPreference <- value)
            state : VirtualHubState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub#id-1">VirtualHub#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VirtualHubState<'Location, 'Name, 'ResourceGroupName>, value: string) : VirtualHubState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VirtualHubState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// route block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub#route-1">VirtualHub#route</a> Accepts: azurerm.IResolvable | azurerm.VirtualHub.VirtualHubRoute[]
        /// </summary>
        [<CustomOperation "route">]
        member _.Route(state: VirtualHubState<'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : VirtualHubState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Route <- value)
            state : VirtualHubState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub#sku-1">VirtualHub#sku</a>.
        /// </summary>
        [<CustomOperation "sku">]
        member _.Sku(state: VirtualHubState<'Location, 'Name, 'ResourceGroupName>, value: string) : VirtualHubState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Sku <- value)
            state : VirtualHubState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub#tags-1">VirtualHub#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: VirtualHubState<'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : VirtualHubState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : VirtualHubState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub#timeouts-1">VirtualHub#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: VirtualHubState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.VirtualHub.VirtualHubTimeouts) : VirtualHubState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : VirtualHubState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub#virtual_router_auto_scale_min_capacity-1">VirtualHub#virtual_router_auto_scale_min_capacity</a>.
        /// </summary>
        [<CustomOperation "virtual_router_auto_scale_min_capacity">]
        member _.VirtualRouterAutoScaleMinCapacity(state: VirtualHubState<'Location, 'Name, 'ResourceGroupName>, value: double) : VirtualHubState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.VirtualRouterAutoScaleMinCapacity <- value)
            state : VirtualHubState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub#virtual_wan_id-1">VirtualHub#virtual_wan_id</a>.
        /// </summary>
        [<CustomOperation "virtual_wan_id">]
        member _.VirtualWanId(state: VirtualHubState<'Location, 'Name, 'ResourceGroupName>, value: string) : VirtualHubState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.VirtualWanId <- value)
            state : VirtualHubState<'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: VirtualHubState<Present, Present, Present>) : azurerm.VirtualHub.VirtualHub =
            let config = azurerm.VirtualHub.VirtualHubConfig()
            for setter in state.assignments do
                setter config
            azurerm.VirtualHub.VirtualHub(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.virtualHub: missing required arguments. Must call: location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: VirtualHubState<_, _, _>) : azurerm.VirtualHub.VirtualHub =
            Unchecked.defaultof<azurerm.VirtualHub.VirtualHub>

namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VirtualHubRoutingIntentState<'Name, 'RoutingPolicy, 'VirtualHubId> = { assignments: ResizeArray<azurerm.VirtualHubRoutingIntent.VirtualHubRoutingIntentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub_routing_intent">azurerm_virtual_hub_routing_intent</a>.
    /// </summary>
    type VirtualHubRoutingIntentBuilder(logicalId: string) =
        member _.Yield(_: unit) : VirtualHubRoutingIntentState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : VirtualHubRoutingIntentState<Missing, Missing, Missing>)

        member _.Zero(()) : VirtualHubRoutingIntentState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : VirtualHubRoutingIntentState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub_routing_intent#name-1">VirtualHubRoutingIntent#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: VirtualHubRoutingIntentState<Missing, 'RoutingPolicy, 'VirtualHubId>, value: string) : VirtualHubRoutingIntentState<Present, 'RoutingPolicy, 'VirtualHubId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : VirtualHubRoutingIntentState<Present, 'RoutingPolicy, 'VirtualHubId>)

        /// <summary>
        /// routing_policy block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub_routing_intent#routing_policy-1">VirtualHubRoutingIntent#routing_policy</a> Accepts: azurerm.IResolvable | azurerm.VirtualHubRoutingIntent.VirtualHubRoutingIntentRoutingPolicy[]
        /// </summary>
        [<CustomOperation "routing_policy">]
        member _.RoutingPolicy(state: VirtualHubRoutingIntentState<'Name, Missing, 'VirtualHubId>, value: HashiCorp.Cdktf.IResolvable) : VirtualHubRoutingIntentState<'Name, Present, 'VirtualHubId> =
            state.assignments.Add(fun config -> config.RoutingPolicy <- value)
            ({ assignments = state.assignments } : VirtualHubRoutingIntentState<'Name, Present, 'VirtualHubId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub_routing_intent#virtual_hub_id-1">VirtualHubRoutingIntent#virtual_hub_id</a>.
        /// </summary>
        [<CustomOperation "virtual_hub_id">]
        member _.VirtualHubId(state: VirtualHubRoutingIntentState<'Name, 'RoutingPolicy, Missing>, value: string) : VirtualHubRoutingIntentState<'Name, 'RoutingPolicy, Present> =
            state.assignments.Add(fun config -> config.VirtualHubId <- value)
            ({ assignments = state.assignments } : VirtualHubRoutingIntentState<'Name, 'RoutingPolicy, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub_routing_intent#id-1">VirtualHubRoutingIntent#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VirtualHubRoutingIntentState<'Name, 'RoutingPolicy, 'VirtualHubId>, value: string) : VirtualHubRoutingIntentState<'Name, 'RoutingPolicy, 'VirtualHubId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VirtualHubRoutingIntentState<'Name, 'RoutingPolicy, 'VirtualHubId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_hub_routing_intent#timeouts-1">VirtualHubRoutingIntent#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: VirtualHubRoutingIntentState<'Name, 'RoutingPolicy, 'VirtualHubId>, value: azurerm.VirtualHubRoutingIntent.VirtualHubRoutingIntentTimeouts) : VirtualHubRoutingIntentState<'Name, 'RoutingPolicy, 'VirtualHubId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : VirtualHubRoutingIntentState<'Name, 'RoutingPolicy, 'VirtualHubId>

        member _.Run(state: VirtualHubRoutingIntentState<Present, Present, Present>) : azurerm.VirtualHubRoutingIntent.VirtualHubRoutingIntent =
            let config = azurerm.VirtualHubRoutingIntent.VirtualHubRoutingIntentConfig()
            for setter in state.assignments do
                setter config
            azurerm.VirtualHubRoutingIntent.VirtualHubRoutingIntent(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.virtualHubRoutingIntent: missing required arguments. Must call: name, routing_policy, virtual_hub_id.", 9999, IsError = true)>]
        member _.Run(_: VirtualHubRoutingIntentState<_, _, _>) : azurerm.VirtualHubRoutingIntent.VirtualHubRoutingIntent =
            Unchecked.defaultof<azurerm.VirtualHubRoutingIntent.VirtualHubRoutingIntent>

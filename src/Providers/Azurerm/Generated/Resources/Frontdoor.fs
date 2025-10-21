namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type FrontdoorState<'BackendPool, 'BackendPoolHealthProbe, 'BackendPoolLoadBalancing, 'FrontendEndpoint, 'Name, 'ResourceGroupName, 'RoutingRule> = { assignments: ResizeArray<azurerm.Frontdoor.FrontdoorConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor">azurerm_frontdoor</a>.
    /// </summary>
    type FrontdoorBuilder(logicalId: string) =
        member _.Yield(_: unit) : FrontdoorState<Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : FrontdoorState<Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : FrontdoorState<Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : FrontdoorState<Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// backend_pool block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#backend_pool-1">Frontdoor#backend_pool</a> Accepts: azurerm.IResolvable | azurerm.Frontdoor.FrontdoorBackendPool[]
        /// </summary>
        [<CustomOperation "backend_pool">]
        member _.BackendPool(state: FrontdoorState<Missing, 'BackendPoolHealthProbe, 'BackendPoolLoadBalancing, 'FrontendEndpoint, 'Name, 'ResourceGroupName, 'RoutingRule>, value: HashiCorp.Cdktf.IResolvable) : FrontdoorState<Present, 'BackendPoolHealthProbe, 'BackendPoolLoadBalancing, 'FrontendEndpoint, 'Name, 'ResourceGroupName, 'RoutingRule> =
            state.assignments.Add(fun config -> config.BackendPool <- value)
            ({ assignments = state.assignments } : FrontdoorState<Present, 'BackendPoolHealthProbe, 'BackendPoolLoadBalancing, 'FrontendEndpoint, 'Name, 'ResourceGroupName, 'RoutingRule>)

        /// <summary>
        /// backend_pool_health_probe block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#backend_pool_health_probe-1">Frontdoor#backend_pool_health_probe</a> Accepts: azurerm.IResolvable | azurerm.Frontdoor.FrontdoorBackendPoolHealthProbe[]
        /// </summary>
        [<CustomOperation "backend_pool_health_probe">]
        member _.BackendPoolHealthProbe(state: FrontdoorState<'BackendPool, Missing, 'BackendPoolLoadBalancing, 'FrontendEndpoint, 'Name, 'ResourceGroupName, 'RoutingRule>, value: HashiCorp.Cdktf.IResolvable) : FrontdoorState<'BackendPool, Present, 'BackendPoolLoadBalancing, 'FrontendEndpoint, 'Name, 'ResourceGroupName, 'RoutingRule> =
            state.assignments.Add(fun config -> config.BackendPoolHealthProbe <- value)
            ({ assignments = state.assignments } : FrontdoorState<'BackendPool, Present, 'BackendPoolLoadBalancing, 'FrontendEndpoint, 'Name, 'ResourceGroupName, 'RoutingRule>)

        /// <summary>
        /// backend_pool_load_balancing block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#backend_pool_load_balancing-1">Frontdoor#backend_pool_load_balancing</a> Accepts: azurerm.IResolvable | azurerm.Frontdoor.FrontdoorBackendPoolLoadBalancing[]
        /// </summary>
        [<CustomOperation "backend_pool_load_balancing">]
        member _.BackendPoolLoadBalancing(state: FrontdoorState<'BackendPool, 'BackendPoolHealthProbe, Missing, 'FrontendEndpoint, 'Name, 'ResourceGroupName, 'RoutingRule>, value: HashiCorp.Cdktf.IResolvable) : FrontdoorState<'BackendPool, 'BackendPoolHealthProbe, Present, 'FrontendEndpoint, 'Name, 'ResourceGroupName, 'RoutingRule> =
            state.assignments.Add(fun config -> config.BackendPoolLoadBalancing <- value)
            ({ assignments = state.assignments } : FrontdoorState<'BackendPool, 'BackendPoolHealthProbe, Present, 'FrontendEndpoint, 'Name, 'ResourceGroupName, 'RoutingRule>)

        /// <summary>
        /// frontend_endpoint block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#frontend_endpoint-1">Frontdoor#frontend_endpoint</a> Accepts: azurerm.IResolvable | azurerm.Frontdoor.FrontdoorFrontendEndpoint[]
        /// </summary>
        [<CustomOperation "frontend_endpoint">]
        member _.FrontendEndpoint(state: FrontdoorState<'BackendPool, 'BackendPoolHealthProbe, 'BackendPoolLoadBalancing, Missing, 'Name, 'ResourceGroupName, 'RoutingRule>, value: HashiCorp.Cdktf.IResolvable) : FrontdoorState<'BackendPool, 'BackendPoolHealthProbe, 'BackendPoolLoadBalancing, Present, 'Name, 'ResourceGroupName, 'RoutingRule> =
            state.assignments.Add(fun config -> config.FrontendEndpoint <- value)
            ({ assignments = state.assignments } : FrontdoorState<'BackendPool, 'BackendPoolHealthProbe, 'BackendPoolLoadBalancing, Present, 'Name, 'ResourceGroupName, 'RoutingRule>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#name-1">Frontdoor#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: FrontdoorState<'BackendPool, 'BackendPoolHealthProbe, 'BackendPoolLoadBalancing, 'FrontendEndpoint, Missing, 'ResourceGroupName, 'RoutingRule>, value: string) : FrontdoorState<'BackendPool, 'BackendPoolHealthProbe, 'BackendPoolLoadBalancing, 'FrontendEndpoint, Present, 'ResourceGroupName, 'RoutingRule> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : FrontdoorState<'BackendPool, 'BackendPoolHealthProbe, 'BackendPoolLoadBalancing, 'FrontendEndpoint, Present, 'ResourceGroupName, 'RoutingRule>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#resource_group_name-1">Frontdoor#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: FrontdoorState<'BackendPool, 'BackendPoolHealthProbe, 'BackendPoolLoadBalancing, 'FrontendEndpoint, 'Name, Missing, 'RoutingRule>, value: string) : FrontdoorState<'BackendPool, 'BackendPoolHealthProbe, 'BackendPoolLoadBalancing, 'FrontendEndpoint, 'Name, Present, 'RoutingRule> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : FrontdoorState<'BackendPool, 'BackendPoolHealthProbe, 'BackendPoolLoadBalancing, 'FrontendEndpoint, 'Name, Present, 'RoutingRule>)

        /// <summary>
        /// routing_rule block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#routing_rule-1">Frontdoor#routing_rule</a> Accepts: azurerm.IResolvable | azurerm.Frontdoor.FrontdoorRoutingRule[]
        /// </summary>
        [<CustomOperation "routing_rule">]
        member _.RoutingRule(state: FrontdoorState<'BackendPool, 'BackendPoolHealthProbe, 'BackendPoolLoadBalancing, 'FrontendEndpoint, 'Name, 'ResourceGroupName, Missing>, value: HashiCorp.Cdktf.IResolvable) : FrontdoorState<'BackendPool, 'BackendPoolHealthProbe, 'BackendPoolLoadBalancing, 'FrontendEndpoint, 'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.RoutingRule <- value)
            ({ assignments = state.assignments } : FrontdoorState<'BackendPool, 'BackendPoolHealthProbe, 'BackendPoolLoadBalancing, 'FrontendEndpoint, 'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// backend_pool_settings block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#backend_pool_settings-1">Frontdoor#backend_pool_settings</a> Accepts: azurerm.IResolvable | azurerm.Frontdoor.FrontdoorBackendPoolSettings[]
        /// </summary>
        [<CustomOperation "backend_pool_settings">]
        member _.BackendPoolSettings(state: FrontdoorState<'BackendPool, 'BackendPoolHealthProbe, 'BackendPoolLoadBalancing, 'FrontendEndpoint, 'Name, 'ResourceGroupName, 'RoutingRule>, value: HashiCorp.Cdktf.IResolvable) : FrontdoorState<'BackendPool, 'BackendPoolHealthProbe, 'BackendPoolLoadBalancing, 'FrontendEndpoint, 'Name, 'ResourceGroupName, 'RoutingRule> =
            state.assignments.Add(fun config -> config.BackendPoolSettings <- value)
            state : FrontdoorState<'BackendPool, 'BackendPoolHealthProbe, 'BackendPoolLoadBalancing, 'FrontendEndpoint, 'Name, 'ResourceGroupName, 'RoutingRule>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#friendly_name-1">Frontdoor#friendly_name</a>.
        /// </summary>
        [<CustomOperation "friendly_name">]
        member _.FriendlyName(state: FrontdoorState<'BackendPool, 'BackendPoolHealthProbe, 'BackendPoolLoadBalancing, 'FrontendEndpoint, 'Name, 'ResourceGroupName, 'RoutingRule>, value: string) : FrontdoorState<'BackendPool, 'BackendPoolHealthProbe, 'BackendPoolLoadBalancing, 'FrontendEndpoint, 'Name, 'ResourceGroupName, 'RoutingRule> =
            state.assignments.Add(fun config -> config.FriendlyName <- value)
            state : FrontdoorState<'BackendPool, 'BackendPoolHealthProbe, 'BackendPoolLoadBalancing, 'FrontendEndpoint, 'Name, 'ResourceGroupName, 'RoutingRule>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#id-1">Frontdoor#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: FrontdoorState<'BackendPool, 'BackendPoolHealthProbe, 'BackendPoolLoadBalancing, 'FrontendEndpoint, 'Name, 'ResourceGroupName, 'RoutingRule>, value: string) : FrontdoorState<'BackendPool, 'BackendPoolHealthProbe, 'BackendPoolLoadBalancing, 'FrontendEndpoint, 'Name, 'ResourceGroupName, 'RoutingRule> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : FrontdoorState<'BackendPool, 'BackendPoolHealthProbe, 'BackendPoolLoadBalancing, 'FrontendEndpoint, 'Name, 'ResourceGroupName, 'RoutingRule>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#load_balancer_enabled-1">Frontdoor#load_balancer_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "load_balancer_enabled">]
        member _.LoadBalancerEnabled(state: FrontdoorState<'BackendPool, 'BackendPoolHealthProbe, 'BackendPoolLoadBalancing, 'FrontendEndpoint, 'Name, 'ResourceGroupName, 'RoutingRule>, value: bool) : FrontdoorState<'BackendPool, 'BackendPoolHealthProbe, 'BackendPoolLoadBalancing, 'FrontendEndpoint, 'Name, 'ResourceGroupName, 'RoutingRule> =
            state.assignments.Add(fun config -> config.LoadBalancerEnabled <- value)
            state : FrontdoorState<'BackendPool, 'BackendPoolHealthProbe, 'BackendPoolLoadBalancing, 'FrontendEndpoint, 'Name, 'ResourceGroupName, 'RoutingRule>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#load_balancer_enabled-1">Frontdoor#load_balancer_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "load_balancer_enabled">]
        member _.LoadBalancerEnabled(state: FrontdoorState<'BackendPool, 'BackendPoolHealthProbe, 'BackendPoolLoadBalancing, 'FrontendEndpoint, 'Name, 'ResourceGroupName, 'RoutingRule>, value: HashiCorp.Cdktf.IResolvable) : FrontdoorState<'BackendPool, 'BackendPoolHealthProbe, 'BackendPoolLoadBalancing, 'FrontendEndpoint, 'Name, 'ResourceGroupName, 'RoutingRule> =
            state.assignments.Add(fun config -> config.LoadBalancerEnabled <- value)
            state : FrontdoorState<'BackendPool, 'BackendPoolHealthProbe, 'BackendPoolLoadBalancing, 'FrontendEndpoint, 'Name, 'ResourceGroupName, 'RoutingRule>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#tags-1">Frontdoor#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: FrontdoorState<'BackendPool, 'BackendPoolHealthProbe, 'BackendPoolLoadBalancing, 'FrontendEndpoint, 'Name, 'ResourceGroupName, 'RoutingRule>, value: seq<string * string>) : FrontdoorState<'BackendPool, 'BackendPoolHealthProbe, 'BackendPoolLoadBalancing, 'FrontendEndpoint, 'Name, 'ResourceGroupName, 'RoutingRule> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : FrontdoorState<'BackendPool, 'BackendPoolHealthProbe, 'BackendPoolLoadBalancing, 'FrontendEndpoint, 'Name, 'ResourceGroupName, 'RoutingRule>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#timeouts-1">Frontdoor#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: FrontdoorState<'BackendPool, 'BackendPoolHealthProbe, 'BackendPoolLoadBalancing, 'FrontendEndpoint, 'Name, 'ResourceGroupName, 'RoutingRule>, value: azurerm.Frontdoor.FrontdoorTimeouts) : FrontdoorState<'BackendPool, 'BackendPoolHealthProbe, 'BackendPoolLoadBalancing, 'FrontendEndpoint, 'Name, 'ResourceGroupName, 'RoutingRule> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : FrontdoorState<'BackendPool, 'BackendPoolHealthProbe, 'BackendPoolLoadBalancing, 'FrontendEndpoint, 'Name, 'ResourceGroupName, 'RoutingRule>

        member _.Run(state: FrontdoorState<Present, Present, Present, Present, Present, Present, Present>) : azurerm.Frontdoor.Frontdoor =
            let config = azurerm.Frontdoor.FrontdoorConfig()
            for setter in state.assignments do
                setter config
            azurerm.Frontdoor.Frontdoor(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.frontdoor: missing required arguments. Must call: backend_pool, backend_pool_health_probe, backend_pool_load_balancing, frontend_endpoint, name, resource_group_name, routing_rule.", 9999, IsError = true)>]
        member _.Run(_: FrontdoorState<_, _, _, _, _, _, _>) : azurerm.Frontdoor.Frontdoor =
            Unchecked.defaultof<azurerm.Frontdoor.Frontdoor>

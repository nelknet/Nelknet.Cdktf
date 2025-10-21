namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SpringCloudGatewayRouteConfigState<'Name, 'Protocol, 'SpringCloudGatewayId> = { assignments: ResizeArray<azurerm.SpringCloudGatewayRouteConfig.SpringCloudGatewayRouteConfigConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_gateway_route_config">azurerm_spring_cloud_gateway_route_config</a>.
    /// </summary>
    type SpringCloudGatewayRouteConfigBuilder(logicalId: string) =
        member _.Yield(_: unit) : SpringCloudGatewayRouteConfigState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SpringCloudGatewayRouteConfigState<Missing, Missing, Missing>)

        member _.Zero(()) : SpringCloudGatewayRouteConfigState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SpringCloudGatewayRouteConfigState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_gateway_route_config#name-1">SpringCloudGatewayRouteConfig#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SpringCloudGatewayRouteConfigState<Missing, 'Protocol, 'SpringCloudGatewayId>, value: string) : SpringCloudGatewayRouteConfigState<Present, 'Protocol, 'SpringCloudGatewayId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SpringCloudGatewayRouteConfigState<Present, 'Protocol, 'SpringCloudGatewayId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_gateway_route_config#protocol-1">SpringCloudGatewayRouteConfig#protocol</a>.
        /// </summary>
        [<CustomOperation "protocol">]
        member _.Protocol(state: SpringCloudGatewayRouteConfigState<'Name, Missing, 'SpringCloudGatewayId>, value: string) : SpringCloudGatewayRouteConfigState<'Name, Present, 'SpringCloudGatewayId> =
            state.assignments.Add(fun config -> config.Protocol <- value)
            ({ assignments = state.assignments } : SpringCloudGatewayRouteConfigState<'Name, Present, 'SpringCloudGatewayId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_gateway_route_config#spring_cloud_gateway_id-1">SpringCloudGatewayRouteConfig#spring_cloud_gateway_id</a>.
        /// </summary>
        [<CustomOperation "spring_cloud_gateway_id">]
        member _.SpringCloudGatewayId(state: SpringCloudGatewayRouteConfigState<'Name, 'Protocol, Missing>, value: string) : SpringCloudGatewayRouteConfigState<'Name, 'Protocol, Present> =
            state.assignments.Add(fun config -> config.SpringCloudGatewayId <- value)
            ({ assignments = state.assignments } : SpringCloudGatewayRouteConfigState<'Name, 'Protocol, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_gateway_route_config#filters-1">SpringCloudGatewayRouteConfig#filters</a>.
        /// </summary>
        [<CustomOperation "filters">]
        member _.Filters(state: SpringCloudGatewayRouteConfigState<'Name, 'Protocol, 'SpringCloudGatewayId>, value: seq<string>) : SpringCloudGatewayRouteConfigState<'Name, 'Protocol, 'SpringCloudGatewayId> =
            state.assignments.Add(fun config -> config.Filters <- (value |> Seq.toArray))
            state : SpringCloudGatewayRouteConfigState<'Name, 'Protocol, 'SpringCloudGatewayId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_gateway_route_config#id-1">SpringCloudGatewayRouteConfig#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SpringCloudGatewayRouteConfigState<'Name, 'Protocol, 'SpringCloudGatewayId>, value: string) : SpringCloudGatewayRouteConfigState<'Name, 'Protocol, 'SpringCloudGatewayId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SpringCloudGatewayRouteConfigState<'Name, 'Protocol, 'SpringCloudGatewayId>

        /// <summary>
        /// open_api block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_gateway_route_config#open_api-1">SpringCloudGatewayRouteConfig#open_api</a>
        /// </summary>
        [<CustomOperation "open_api">]
        member _.OpenApi(state: SpringCloudGatewayRouteConfigState<'Name, 'Protocol, 'SpringCloudGatewayId>, value: azurerm.SpringCloudGatewayRouteConfig.SpringCloudGatewayRouteConfigOpenApi) : SpringCloudGatewayRouteConfigState<'Name, 'Protocol, 'SpringCloudGatewayId> =
            state.assignments.Add(fun config -> config.OpenApi <- value)
            state : SpringCloudGatewayRouteConfigState<'Name, 'Protocol, 'SpringCloudGatewayId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_gateway_route_config#predicates-1">SpringCloudGatewayRouteConfig#predicates</a>.
        /// </summary>
        [<CustomOperation "predicates">]
        member _.Predicates(state: SpringCloudGatewayRouteConfigState<'Name, 'Protocol, 'SpringCloudGatewayId>, value: seq<string>) : SpringCloudGatewayRouteConfigState<'Name, 'Protocol, 'SpringCloudGatewayId> =
            state.assignments.Add(fun config -> config.Predicates <- (value |> Seq.toArray))
            state : SpringCloudGatewayRouteConfigState<'Name, 'Protocol, 'SpringCloudGatewayId>

        /// <summary>
        /// route block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_gateway_route_config#route-1">SpringCloudGatewayRouteConfig#route</a> Accepts: azurerm.IResolvable | azurerm.SpringCloudGatewayRouteConfig.SpringCloudGatewayRouteConfigRoute[]
        /// </summary>
        [<CustomOperation "route">]
        member _.Route(state: SpringCloudGatewayRouteConfigState<'Name, 'Protocol, 'SpringCloudGatewayId>, value: HashiCorp.Cdktf.IResolvable) : SpringCloudGatewayRouteConfigState<'Name, 'Protocol, 'SpringCloudGatewayId> =
            state.assignments.Add(fun config -> config.Route <- value)
            state : SpringCloudGatewayRouteConfigState<'Name, 'Protocol, 'SpringCloudGatewayId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_gateway_route_config#spring_cloud_app_id-1">SpringCloudGatewayRouteConfig#spring_cloud_app_id</a>.
        /// </summary>
        [<CustomOperation "spring_cloud_app_id">]
        member _.SpringCloudAppId(state: SpringCloudGatewayRouteConfigState<'Name, 'Protocol, 'SpringCloudGatewayId>, value: string) : SpringCloudGatewayRouteConfigState<'Name, 'Protocol, 'SpringCloudGatewayId> =
            state.assignments.Add(fun config -> config.SpringCloudAppId <- value)
            state : SpringCloudGatewayRouteConfigState<'Name, 'Protocol, 'SpringCloudGatewayId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_gateway_route_config#sso_validation_enabled-1">SpringCloudGatewayRouteConfig#sso_validation_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "sso_validation_enabled">]
        member _.SsoValidationEnabled(state: SpringCloudGatewayRouteConfigState<'Name, 'Protocol, 'SpringCloudGatewayId>, value: bool) : SpringCloudGatewayRouteConfigState<'Name, 'Protocol, 'SpringCloudGatewayId> =
            state.assignments.Add(fun config -> config.SsoValidationEnabled <- value)
            state : SpringCloudGatewayRouteConfigState<'Name, 'Protocol, 'SpringCloudGatewayId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_gateway_route_config#sso_validation_enabled-1">SpringCloudGatewayRouteConfig#sso_validation_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "sso_validation_enabled">]
        member _.SsoValidationEnabled(state: SpringCloudGatewayRouteConfigState<'Name, 'Protocol, 'SpringCloudGatewayId>, value: HashiCorp.Cdktf.IResolvable) : SpringCloudGatewayRouteConfigState<'Name, 'Protocol, 'SpringCloudGatewayId> =
            state.assignments.Add(fun config -> config.SsoValidationEnabled <- value)
            state : SpringCloudGatewayRouteConfigState<'Name, 'Protocol, 'SpringCloudGatewayId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_gateway_route_config#timeouts-1">SpringCloudGatewayRouteConfig#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SpringCloudGatewayRouteConfigState<'Name, 'Protocol, 'SpringCloudGatewayId>, value: azurerm.SpringCloudGatewayRouteConfig.SpringCloudGatewayRouteConfigTimeouts) : SpringCloudGatewayRouteConfigState<'Name, 'Protocol, 'SpringCloudGatewayId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SpringCloudGatewayRouteConfigState<'Name, 'Protocol, 'SpringCloudGatewayId>

        member _.Run(state: SpringCloudGatewayRouteConfigState<Present, Present, Present>) : azurerm.SpringCloudGatewayRouteConfig.SpringCloudGatewayRouteConfig =
            let config = azurerm.SpringCloudGatewayRouteConfig.SpringCloudGatewayRouteConfigConfig()
            for setter in state.assignments do
                setter config
            azurerm.SpringCloudGatewayRouteConfig.SpringCloudGatewayRouteConfig(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.springCloudGatewayRouteConfig: missing required arguments. Must call: name, protocol, spring_cloud_gateway_id.", 9999, IsError = true)>]
        member _.Run(_: SpringCloudGatewayRouteConfigState<_, _, _>) : azurerm.SpringCloudGatewayRouteConfig.SpringCloudGatewayRouteConfig =
            Unchecked.defaultof<azurerm.SpringCloudGatewayRouteConfig.SpringCloudGatewayRouteConfig>

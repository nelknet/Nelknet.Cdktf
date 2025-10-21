namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type TrafficManagerNestedEndpointState<'MinimumChildEndpoints, 'Name, 'ProfileId, 'TargetResourceId> = { assignments: ResizeArray<azurerm.TrafficManagerNestedEndpoint.TrafficManagerNestedEndpointConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/traffic_manager_nested_endpoint">azurerm_traffic_manager_nested_endpoint</a>.
    /// </summary>
    type TrafficManagerNestedEndpointBuilder(logicalId: string) =
        member _.Yield(_: unit) : TrafficManagerNestedEndpointState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : TrafficManagerNestedEndpointState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : TrafficManagerNestedEndpointState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : TrafficManagerNestedEndpointState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/traffic_manager_nested_endpoint#minimum_child_endpoints-1">TrafficManagerNestedEndpoint#minimum_child_endpoints</a>.
        /// </summary>
        [<CustomOperation "minimum_child_endpoints">]
        member _.MinimumChildEndpoints(state: TrafficManagerNestedEndpointState<Missing, 'Name, 'ProfileId, 'TargetResourceId>, value: double) : TrafficManagerNestedEndpointState<Present, 'Name, 'ProfileId, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.MinimumChildEndpoints <- value)
            ({ assignments = state.assignments } : TrafficManagerNestedEndpointState<Present, 'Name, 'ProfileId, 'TargetResourceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/traffic_manager_nested_endpoint#name-1">TrafficManagerNestedEndpoint#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: TrafficManagerNestedEndpointState<'MinimumChildEndpoints, Missing, 'ProfileId, 'TargetResourceId>, value: string) : TrafficManagerNestedEndpointState<'MinimumChildEndpoints, Present, 'ProfileId, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : TrafficManagerNestedEndpointState<'MinimumChildEndpoints, Present, 'ProfileId, 'TargetResourceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/traffic_manager_nested_endpoint#profile_id-1">TrafficManagerNestedEndpoint#profile_id</a>.
        /// </summary>
        [<CustomOperation "profile_id">]
        member _.ProfileId(state: TrafficManagerNestedEndpointState<'MinimumChildEndpoints, 'Name, Missing, 'TargetResourceId>, value: string) : TrafficManagerNestedEndpointState<'MinimumChildEndpoints, 'Name, Present, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.ProfileId <- value)
            ({ assignments = state.assignments } : TrafficManagerNestedEndpointState<'MinimumChildEndpoints, 'Name, Present, 'TargetResourceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/traffic_manager_nested_endpoint#target_resource_id-1">TrafficManagerNestedEndpoint#target_resource_id</a>.
        /// </summary>
        [<CustomOperation "target_resource_id">]
        member _.TargetResourceId(state: TrafficManagerNestedEndpointState<'MinimumChildEndpoints, 'Name, 'ProfileId, Missing>, value: string) : TrafficManagerNestedEndpointState<'MinimumChildEndpoints, 'Name, 'ProfileId, Present> =
            state.assignments.Add(fun config -> config.TargetResourceId <- value)
            ({ assignments = state.assignments } : TrafficManagerNestedEndpointState<'MinimumChildEndpoints, 'Name, 'ProfileId, Present>)

        /// <summary>
        /// custom_header block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/traffic_manager_nested_endpoint#custom_header-1">TrafficManagerNestedEndpoint#custom_header</a> Accepts: azurerm.IResolvable | azurerm.TrafficManagerNestedEndpoint.TrafficManagerNestedEndpointCustomHeader[]
        /// </summary>
        [<CustomOperation "custom_header">]
        member _.CustomHeader(state: TrafficManagerNestedEndpointState<'MinimumChildEndpoints, 'Name, 'ProfileId, 'TargetResourceId>, value: HashiCorp.Cdktf.IResolvable) : TrafficManagerNestedEndpointState<'MinimumChildEndpoints, 'Name, 'ProfileId, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.CustomHeader <- value)
            state : TrafficManagerNestedEndpointState<'MinimumChildEndpoints, 'Name, 'ProfileId, 'TargetResourceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/traffic_manager_nested_endpoint#enabled-1">TrafficManagerNestedEndpoint#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: TrafficManagerNestedEndpointState<'MinimumChildEndpoints, 'Name, 'ProfileId, 'TargetResourceId>, value: bool) : TrafficManagerNestedEndpointState<'MinimumChildEndpoints, 'Name, 'ProfileId, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : TrafficManagerNestedEndpointState<'MinimumChildEndpoints, 'Name, 'ProfileId, 'TargetResourceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/traffic_manager_nested_endpoint#enabled-1">TrafficManagerNestedEndpoint#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: TrafficManagerNestedEndpointState<'MinimumChildEndpoints, 'Name, 'ProfileId, 'TargetResourceId>, value: HashiCorp.Cdktf.IResolvable) : TrafficManagerNestedEndpointState<'MinimumChildEndpoints, 'Name, 'ProfileId, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : TrafficManagerNestedEndpointState<'MinimumChildEndpoints, 'Name, 'ProfileId, 'TargetResourceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/traffic_manager_nested_endpoint#endpoint_location-1">TrafficManagerNestedEndpoint#endpoint_location</a>.
        /// </summary>
        [<CustomOperation "endpoint_location">]
        member _.EndpointLocation(state: TrafficManagerNestedEndpointState<'MinimumChildEndpoints, 'Name, 'ProfileId, 'TargetResourceId>, value: string) : TrafficManagerNestedEndpointState<'MinimumChildEndpoints, 'Name, 'ProfileId, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.EndpointLocation <- value)
            state : TrafficManagerNestedEndpointState<'MinimumChildEndpoints, 'Name, 'ProfileId, 'TargetResourceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/traffic_manager_nested_endpoint#geo_mappings-1">TrafficManagerNestedEndpoint#geo_mappings</a>.
        /// </summary>
        [<CustomOperation "geo_mappings">]
        member _.GeoMappings(state: TrafficManagerNestedEndpointState<'MinimumChildEndpoints, 'Name, 'ProfileId, 'TargetResourceId>, value: seq<string>) : TrafficManagerNestedEndpointState<'MinimumChildEndpoints, 'Name, 'ProfileId, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.GeoMappings <- (value |> Seq.toArray))
            state : TrafficManagerNestedEndpointState<'MinimumChildEndpoints, 'Name, 'ProfileId, 'TargetResourceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/traffic_manager_nested_endpoint#id-1">TrafficManagerNestedEndpoint#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: TrafficManagerNestedEndpointState<'MinimumChildEndpoints, 'Name, 'ProfileId, 'TargetResourceId>, value: string) : TrafficManagerNestedEndpointState<'MinimumChildEndpoints, 'Name, 'ProfileId, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : TrafficManagerNestedEndpointState<'MinimumChildEndpoints, 'Name, 'ProfileId, 'TargetResourceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/traffic_manager_nested_endpoint#minimum_required_child_endpoints_ipv4-1">TrafficManagerNestedEndpoint#minimum_required_child_endpoints_ipv4</a>.
        /// </summary>
        [<CustomOperation "minimum_required_child_endpoints_ipv4">]
        member _.MinimumRequiredChildEndpointsIpv4(state: TrafficManagerNestedEndpointState<'MinimumChildEndpoints, 'Name, 'ProfileId, 'TargetResourceId>, value: double) : TrafficManagerNestedEndpointState<'MinimumChildEndpoints, 'Name, 'ProfileId, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.MinimumRequiredChildEndpointsIpv4 <- value)
            state : TrafficManagerNestedEndpointState<'MinimumChildEndpoints, 'Name, 'ProfileId, 'TargetResourceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/traffic_manager_nested_endpoint#minimum_required_child_endpoints_ipv6-1">TrafficManagerNestedEndpoint#minimum_required_child_endpoints_ipv6</a>.
        /// </summary>
        [<CustomOperation "minimum_required_child_endpoints_ipv6">]
        member _.MinimumRequiredChildEndpointsIpv6(state: TrafficManagerNestedEndpointState<'MinimumChildEndpoints, 'Name, 'ProfileId, 'TargetResourceId>, value: double) : TrafficManagerNestedEndpointState<'MinimumChildEndpoints, 'Name, 'ProfileId, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.MinimumRequiredChildEndpointsIpv6 <- value)
            state : TrafficManagerNestedEndpointState<'MinimumChildEndpoints, 'Name, 'ProfileId, 'TargetResourceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/traffic_manager_nested_endpoint#priority-1">TrafficManagerNestedEndpoint#priority</a>.
        /// </summary>
        [<CustomOperation "priority">]
        member _.Priority(state: TrafficManagerNestedEndpointState<'MinimumChildEndpoints, 'Name, 'ProfileId, 'TargetResourceId>, value: double) : TrafficManagerNestedEndpointState<'MinimumChildEndpoints, 'Name, 'ProfileId, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.Priority <- value)
            state : TrafficManagerNestedEndpointState<'MinimumChildEndpoints, 'Name, 'ProfileId, 'TargetResourceId>

        /// <summary>
        /// subnet block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/traffic_manager_nested_endpoint#subnet-1">TrafficManagerNestedEndpoint#subnet</a> Accepts: azurerm.IResolvable | azurerm.TrafficManagerNestedEndpoint.TrafficManagerNestedEndpointSubnet[]
        /// </summary>
        [<CustomOperation "subnet">]
        member _.Subnet(state: TrafficManagerNestedEndpointState<'MinimumChildEndpoints, 'Name, 'ProfileId, 'TargetResourceId>, value: HashiCorp.Cdktf.IResolvable) : TrafficManagerNestedEndpointState<'MinimumChildEndpoints, 'Name, 'ProfileId, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.Subnet <- value)
            state : TrafficManagerNestedEndpointState<'MinimumChildEndpoints, 'Name, 'ProfileId, 'TargetResourceId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/traffic_manager_nested_endpoint#timeouts-1">TrafficManagerNestedEndpoint#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: TrafficManagerNestedEndpointState<'MinimumChildEndpoints, 'Name, 'ProfileId, 'TargetResourceId>, value: azurerm.TrafficManagerNestedEndpoint.TrafficManagerNestedEndpointTimeouts) : TrafficManagerNestedEndpointState<'MinimumChildEndpoints, 'Name, 'ProfileId, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : TrafficManagerNestedEndpointState<'MinimumChildEndpoints, 'Name, 'ProfileId, 'TargetResourceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/traffic_manager_nested_endpoint#weight-1">TrafficManagerNestedEndpoint#weight</a>.
        /// </summary>
        [<CustomOperation "weight">]
        member _.Weight(state: TrafficManagerNestedEndpointState<'MinimumChildEndpoints, 'Name, 'ProfileId, 'TargetResourceId>, value: double) : TrafficManagerNestedEndpointState<'MinimumChildEndpoints, 'Name, 'ProfileId, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.Weight <- value)
            state : TrafficManagerNestedEndpointState<'MinimumChildEndpoints, 'Name, 'ProfileId, 'TargetResourceId>

        member _.Run(state: TrafficManagerNestedEndpointState<Present, Present, Present, Present>) : azurerm.TrafficManagerNestedEndpoint.TrafficManagerNestedEndpoint =
            let config = azurerm.TrafficManagerNestedEndpoint.TrafficManagerNestedEndpointConfig()
            for setter in state.assignments do
                setter config
            azurerm.TrafficManagerNestedEndpoint.TrafficManagerNestedEndpoint(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.trafficManagerNestedEndpoint: missing required arguments. Must call: minimum_child_endpoints, name, profile_id, target_resource_id.", 9999, IsError = true)>]
        member _.Run(_: TrafficManagerNestedEndpointState<_, _, _, _>) : azurerm.TrafficManagerNestedEndpoint.TrafficManagerNestedEndpoint =
            Unchecked.defaultof<azurerm.TrafficManagerNestedEndpoint.TrafficManagerNestedEndpoint>

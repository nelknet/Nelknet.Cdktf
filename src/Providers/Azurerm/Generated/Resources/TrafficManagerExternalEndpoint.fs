namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type TrafficManagerExternalEndpointState<'Name, 'ProfileId, 'Target> = { assignments: ResizeArray<azurerm.TrafficManagerExternalEndpoint.TrafficManagerExternalEndpointConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/traffic_manager_external_endpoint">azurerm_traffic_manager_external_endpoint</a>.
    /// </summary>
    type TrafficManagerExternalEndpointBuilder(logicalId: string) =
        member _.Yield(_: unit) : TrafficManagerExternalEndpointState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : TrafficManagerExternalEndpointState<Missing, Missing, Missing>)

        member _.Zero(()) : TrafficManagerExternalEndpointState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : TrafficManagerExternalEndpointState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/traffic_manager_external_endpoint#name-1">TrafficManagerExternalEndpoint#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: TrafficManagerExternalEndpointState<Missing, 'ProfileId, 'Target>, value: string) : TrafficManagerExternalEndpointState<Present, 'ProfileId, 'Target> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : TrafficManagerExternalEndpointState<Present, 'ProfileId, 'Target>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/traffic_manager_external_endpoint#profile_id-1">TrafficManagerExternalEndpoint#profile_id</a>.
        /// </summary>
        [<CustomOperation "profile_id">]
        member _.ProfileId(state: TrafficManagerExternalEndpointState<'Name, Missing, 'Target>, value: string) : TrafficManagerExternalEndpointState<'Name, Present, 'Target> =
            state.assignments.Add(fun config -> config.ProfileId <- value)
            ({ assignments = state.assignments } : TrafficManagerExternalEndpointState<'Name, Present, 'Target>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/traffic_manager_external_endpoint#target-1">TrafficManagerExternalEndpoint#target</a>.
        /// </summary>
        [<CustomOperation "target">]
        member _.Target(state: TrafficManagerExternalEndpointState<'Name, 'ProfileId, Missing>, value: string) : TrafficManagerExternalEndpointState<'Name, 'ProfileId, Present> =
            state.assignments.Add(fun config -> config.Target <- value)
            ({ assignments = state.assignments } : TrafficManagerExternalEndpointState<'Name, 'ProfileId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/traffic_manager_external_endpoint#always_serve_enabled-1">TrafficManagerExternalEndpoint#always_serve_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "always_serve_enabled">]
        member _.AlwaysServeEnabled(state: TrafficManagerExternalEndpointState<'Name, 'ProfileId, 'Target>, value: bool) : TrafficManagerExternalEndpointState<'Name, 'ProfileId, 'Target> =
            state.assignments.Add(fun config -> config.AlwaysServeEnabled <- value)
            state : TrafficManagerExternalEndpointState<'Name, 'ProfileId, 'Target>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/traffic_manager_external_endpoint#always_serve_enabled-1">TrafficManagerExternalEndpoint#always_serve_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "always_serve_enabled">]
        member _.AlwaysServeEnabled(state: TrafficManagerExternalEndpointState<'Name, 'ProfileId, 'Target>, value: HashiCorp.Cdktf.IResolvable) : TrafficManagerExternalEndpointState<'Name, 'ProfileId, 'Target> =
            state.assignments.Add(fun config -> config.AlwaysServeEnabled <- value)
            state : TrafficManagerExternalEndpointState<'Name, 'ProfileId, 'Target>

        /// <summary>
        /// custom_header block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/traffic_manager_external_endpoint#custom_header-1">TrafficManagerExternalEndpoint#custom_header</a> Accepts: azurerm.IResolvable | azurerm.TrafficManagerExternalEndpoint.TrafficManagerExternalEndpointCustomHeader[]
        /// </summary>
        [<CustomOperation "custom_header">]
        member _.CustomHeader(state: TrafficManagerExternalEndpointState<'Name, 'ProfileId, 'Target>, value: HashiCorp.Cdktf.IResolvable) : TrafficManagerExternalEndpointState<'Name, 'ProfileId, 'Target> =
            state.assignments.Add(fun config -> config.CustomHeader <- value)
            state : TrafficManagerExternalEndpointState<'Name, 'ProfileId, 'Target>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/traffic_manager_external_endpoint#enabled-1">TrafficManagerExternalEndpoint#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: TrafficManagerExternalEndpointState<'Name, 'ProfileId, 'Target>, value: bool) : TrafficManagerExternalEndpointState<'Name, 'ProfileId, 'Target> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : TrafficManagerExternalEndpointState<'Name, 'ProfileId, 'Target>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/traffic_manager_external_endpoint#enabled-1">TrafficManagerExternalEndpoint#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: TrafficManagerExternalEndpointState<'Name, 'ProfileId, 'Target>, value: HashiCorp.Cdktf.IResolvable) : TrafficManagerExternalEndpointState<'Name, 'ProfileId, 'Target> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : TrafficManagerExternalEndpointState<'Name, 'ProfileId, 'Target>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/traffic_manager_external_endpoint#endpoint_location-1">TrafficManagerExternalEndpoint#endpoint_location</a>.
        /// </summary>
        [<CustomOperation "endpoint_location">]
        member _.EndpointLocation(state: TrafficManagerExternalEndpointState<'Name, 'ProfileId, 'Target>, value: string) : TrafficManagerExternalEndpointState<'Name, 'ProfileId, 'Target> =
            state.assignments.Add(fun config -> config.EndpointLocation <- value)
            state : TrafficManagerExternalEndpointState<'Name, 'ProfileId, 'Target>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/traffic_manager_external_endpoint#geo_mappings-1">TrafficManagerExternalEndpoint#geo_mappings</a>.
        /// </summary>
        [<CustomOperation "geo_mappings">]
        member _.GeoMappings(state: TrafficManagerExternalEndpointState<'Name, 'ProfileId, 'Target>, value: seq<string>) : TrafficManagerExternalEndpointState<'Name, 'ProfileId, 'Target> =
            state.assignments.Add(fun config -> config.GeoMappings <- (value |> Seq.toArray))
            state : TrafficManagerExternalEndpointState<'Name, 'ProfileId, 'Target>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/traffic_manager_external_endpoint#id-1">TrafficManagerExternalEndpoint#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: TrafficManagerExternalEndpointState<'Name, 'ProfileId, 'Target>, value: string) : TrafficManagerExternalEndpointState<'Name, 'ProfileId, 'Target> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : TrafficManagerExternalEndpointState<'Name, 'ProfileId, 'Target>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/traffic_manager_external_endpoint#priority-1">TrafficManagerExternalEndpoint#priority</a>.
        /// </summary>
        [<CustomOperation "priority">]
        member _.Priority(state: TrafficManagerExternalEndpointState<'Name, 'ProfileId, 'Target>, value: double) : TrafficManagerExternalEndpointState<'Name, 'ProfileId, 'Target> =
            state.assignments.Add(fun config -> config.Priority <- value)
            state : TrafficManagerExternalEndpointState<'Name, 'ProfileId, 'Target>

        /// <summary>
        /// subnet block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/traffic_manager_external_endpoint#subnet-1">TrafficManagerExternalEndpoint#subnet</a> Accepts: azurerm.IResolvable | azurerm.TrafficManagerExternalEndpoint.TrafficManagerExternalEndpointSubnet[]
        /// </summary>
        [<CustomOperation "subnet">]
        member _.Subnet(state: TrafficManagerExternalEndpointState<'Name, 'ProfileId, 'Target>, value: HashiCorp.Cdktf.IResolvable) : TrafficManagerExternalEndpointState<'Name, 'ProfileId, 'Target> =
            state.assignments.Add(fun config -> config.Subnet <- value)
            state : TrafficManagerExternalEndpointState<'Name, 'ProfileId, 'Target>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/traffic_manager_external_endpoint#timeouts-1">TrafficManagerExternalEndpoint#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: TrafficManagerExternalEndpointState<'Name, 'ProfileId, 'Target>, value: azurerm.TrafficManagerExternalEndpoint.TrafficManagerExternalEndpointTimeouts) : TrafficManagerExternalEndpointState<'Name, 'ProfileId, 'Target> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : TrafficManagerExternalEndpointState<'Name, 'ProfileId, 'Target>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/traffic_manager_external_endpoint#weight-1">TrafficManagerExternalEndpoint#weight</a>.
        /// </summary>
        [<CustomOperation "weight">]
        member _.Weight(state: TrafficManagerExternalEndpointState<'Name, 'ProfileId, 'Target>, value: double) : TrafficManagerExternalEndpointState<'Name, 'ProfileId, 'Target> =
            state.assignments.Add(fun config -> config.Weight <- value)
            state : TrafficManagerExternalEndpointState<'Name, 'ProfileId, 'Target>

        member _.Run(state: TrafficManagerExternalEndpointState<Present, Present, Present>) : azurerm.TrafficManagerExternalEndpoint.TrafficManagerExternalEndpoint =
            let config = azurerm.TrafficManagerExternalEndpoint.TrafficManagerExternalEndpointConfig()
            for setter in state.assignments do
                setter config
            azurerm.TrafficManagerExternalEndpoint.TrafficManagerExternalEndpoint(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.trafficManagerExternalEndpoint: missing required arguments. Must call: name, profile_id, target.", 9999, IsError = true)>]
        member _.Run(_: TrafficManagerExternalEndpointState<_, _, _>) : azurerm.TrafficManagerExternalEndpoint.TrafficManagerExternalEndpoint =
            Unchecked.defaultof<azurerm.TrafficManagerExternalEndpoint.TrafficManagerExternalEndpoint>

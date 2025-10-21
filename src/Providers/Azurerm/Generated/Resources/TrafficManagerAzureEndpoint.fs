namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type TrafficManagerAzureEndpointState<'Name, 'ProfileId, 'TargetResourceId> = { assignments: ResizeArray<azurerm.TrafficManagerAzureEndpoint.TrafficManagerAzureEndpointConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/traffic_manager_azure_endpoint">azurerm_traffic_manager_azure_endpoint</a>.
    /// </summary>
    type TrafficManagerAzureEndpointBuilder(logicalId: string) =
        member _.Yield(_: unit) : TrafficManagerAzureEndpointState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : TrafficManagerAzureEndpointState<Missing, Missing, Missing>)

        member _.Zero(()) : TrafficManagerAzureEndpointState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : TrafficManagerAzureEndpointState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/traffic_manager_azure_endpoint#name-1">TrafficManagerAzureEndpoint#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: TrafficManagerAzureEndpointState<Missing, 'ProfileId, 'TargetResourceId>, value: string) : TrafficManagerAzureEndpointState<Present, 'ProfileId, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : TrafficManagerAzureEndpointState<Present, 'ProfileId, 'TargetResourceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/traffic_manager_azure_endpoint#profile_id-1">TrafficManagerAzureEndpoint#profile_id</a>.
        /// </summary>
        [<CustomOperation "profile_id">]
        member _.ProfileId(state: TrafficManagerAzureEndpointState<'Name, Missing, 'TargetResourceId>, value: string) : TrafficManagerAzureEndpointState<'Name, Present, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.ProfileId <- value)
            ({ assignments = state.assignments } : TrafficManagerAzureEndpointState<'Name, Present, 'TargetResourceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/traffic_manager_azure_endpoint#target_resource_id-1">TrafficManagerAzureEndpoint#target_resource_id</a>.
        /// </summary>
        [<CustomOperation "target_resource_id">]
        member _.TargetResourceId(state: TrafficManagerAzureEndpointState<'Name, 'ProfileId, Missing>, value: string) : TrafficManagerAzureEndpointState<'Name, 'ProfileId, Present> =
            state.assignments.Add(fun config -> config.TargetResourceId <- value)
            ({ assignments = state.assignments } : TrafficManagerAzureEndpointState<'Name, 'ProfileId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/traffic_manager_azure_endpoint#always_serve_enabled-1">TrafficManagerAzureEndpoint#always_serve_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "always_serve_enabled">]
        member _.AlwaysServeEnabled(state: TrafficManagerAzureEndpointState<'Name, 'ProfileId, 'TargetResourceId>, value: bool) : TrafficManagerAzureEndpointState<'Name, 'ProfileId, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.AlwaysServeEnabled <- value)
            state : TrafficManagerAzureEndpointState<'Name, 'ProfileId, 'TargetResourceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/traffic_manager_azure_endpoint#always_serve_enabled-1">TrafficManagerAzureEndpoint#always_serve_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "always_serve_enabled">]
        member _.AlwaysServeEnabled(state: TrafficManagerAzureEndpointState<'Name, 'ProfileId, 'TargetResourceId>, value: HashiCorp.Cdktf.IResolvable) : TrafficManagerAzureEndpointState<'Name, 'ProfileId, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.AlwaysServeEnabled <- value)
            state : TrafficManagerAzureEndpointState<'Name, 'ProfileId, 'TargetResourceId>

        /// <summary>
        /// custom_header block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/traffic_manager_azure_endpoint#custom_header-1">TrafficManagerAzureEndpoint#custom_header</a> Accepts: azurerm.IResolvable | azurerm.TrafficManagerAzureEndpoint.TrafficManagerAzureEndpointCustomHeader[]
        /// </summary>
        [<CustomOperation "custom_header">]
        member _.CustomHeader(state: TrafficManagerAzureEndpointState<'Name, 'ProfileId, 'TargetResourceId>, value: HashiCorp.Cdktf.IResolvable) : TrafficManagerAzureEndpointState<'Name, 'ProfileId, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.CustomHeader <- value)
            state : TrafficManagerAzureEndpointState<'Name, 'ProfileId, 'TargetResourceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/traffic_manager_azure_endpoint#enabled-1">TrafficManagerAzureEndpoint#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: TrafficManagerAzureEndpointState<'Name, 'ProfileId, 'TargetResourceId>, value: bool) : TrafficManagerAzureEndpointState<'Name, 'ProfileId, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : TrafficManagerAzureEndpointState<'Name, 'ProfileId, 'TargetResourceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/traffic_manager_azure_endpoint#enabled-1">TrafficManagerAzureEndpoint#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: TrafficManagerAzureEndpointState<'Name, 'ProfileId, 'TargetResourceId>, value: HashiCorp.Cdktf.IResolvable) : TrafficManagerAzureEndpointState<'Name, 'ProfileId, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : TrafficManagerAzureEndpointState<'Name, 'ProfileId, 'TargetResourceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/traffic_manager_azure_endpoint#geo_mappings-1">TrafficManagerAzureEndpoint#geo_mappings</a>.
        /// </summary>
        [<CustomOperation "geo_mappings">]
        member _.GeoMappings(state: TrafficManagerAzureEndpointState<'Name, 'ProfileId, 'TargetResourceId>, value: seq<string>) : TrafficManagerAzureEndpointState<'Name, 'ProfileId, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.GeoMappings <- (value |> Seq.toArray))
            state : TrafficManagerAzureEndpointState<'Name, 'ProfileId, 'TargetResourceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/traffic_manager_azure_endpoint#id-1">TrafficManagerAzureEndpoint#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: TrafficManagerAzureEndpointState<'Name, 'ProfileId, 'TargetResourceId>, value: string) : TrafficManagerAzureEndpointState<'Name, 'ProfileId, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : TrafficManagerAzureEndpointState<'Name, 'ProfileId, 'TargetResourceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/traffic_manager_azure_endpoint#priority-1">TrafficManagerAzureEndpoint#priority</a>.
        /// </summary>
        [<CustomOperation "priority">]
        member _.Priority(state: TrafficManagerAzureEndpointState<'Name, 'ProfileId, 'TargetResourceId>, value: double) : TrafficManagerAzureEndpointState<'Name, 'ProfileId, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.Priority <- value)
            state : TrafficManagerAzureEndpointState<'Name, 'ProfileId, 'TargetResourceId>

        /// <summary>
        /// subnet block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/traffic_manager_azure_endpoint#subnet-1">TrafficManagerAzureEndpoint#subnet</a> Accepts: azurerm.IResolvable | azurerm.TrafficManagerAzureEndpoint.TrafficManagerAzureEndpointSubnet[]
        /// </summary>
        [<CustomOperation "subnet">]
        member _.Subnet(state: TrafficManagerAzureEndpointState<'Name, 'ProfileId, 'TargetResourceId>, value: HashiCorp.Cdktf.IResolvable) : TrafficManagerAzureEndpointState<'Name, 'ProfileId, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.Subnet <- value)
            state : TrafficManagerAzureEndpointState<'Name, 'ProfileId, 'TargetResourceId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/traffic_manager_azure_endpoint#timeouts-1">TrafficManagerAzureEndpoint#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: TrafficManagerAzureEndpointState<'Name, 'ProfileId, 'TargetResourceId>, value: azurerm.TrafficManagerAzureEndpoint.TrafficManagerAzureEndpointTimeouts) : TrafficManagerAzureEndpointState<'Name, 'ProfileId, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : TrafficManagerAzureEndpointState<'Name, 'ProfileId, 'TargetResourceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/traffic_manager_azure_endpoint#weight-1">TrafficManagerAzureEndpoint#weight</a>.
        /// </summary>
        [<CustomOperation "weight">]
        member _.Weight(state: TrafficManagerAzureEndpointState<'Name, 'ProfileId, 'TargetResourceId>, value: double) : TrafficManagerAzureEndpointState<'Name, 'ProfileId, 'TargetResourceId> =
            state.assignments.Add(fun config -> config.Weight <- value)
            state : TrafficManagerAzureEndpointState<'Name, 'ProfileId, 'TargetResourceId>

        member _.Run(state: TrafficManagerAzureEndpointState<Present, Present, Present>) : azurerm.TrafficManagerAzureEndpoint.TrafficManagerAzureEndpoint =
            let config = azurerm.TrafficManagerAzureEndpoint.TrafficManagerAzureEndpointConfig()
            for setter in state.assignments do
                setter config
            azurerm.TrafficManagerAzureEndpoint.TrafficManagerAzureEndpoint(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.trafficManagerAzureEndpoint: missing required arguments. Must call: name, profile_id, target_resource_id.", 9999, IsError = true)>]
        member _.Run(_: TrafficManagerAzureEndpointState<_, _, _>) : azurerm.TrafficManagerAzureEndpoint.TrafficManagerAzureEndpoint =
            Unchecked.defaultof<azurerm.TrafficManagerAzureEndpoint.TrafficManagerAzureEndpoint>

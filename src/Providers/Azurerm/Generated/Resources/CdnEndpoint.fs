namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CdnEndpointState<'Location, 'Name, 'Origin, 'ProfileName, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.CdnEndpoint.CdnEndpointConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint">azurerm_cdn_endpoint</a>.
    /// </summary>
    type CdnEndpointBuilder(logicalId: string) =
        member _.Yield(_: unit) : CdnEndpointState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CdnEndpointState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : CdnEndpointState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CdnEndpointState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#location-1">CdnEndpoint#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: CdnEndpointState<Missing, 'Name, 'Origin, 'ProfileName, 'ResourceGroupName>, value: string) : CdnEndpointState<Present, 'Name, 'Origin, 'ProfileName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : CdnEndpointState<Present, 'Name, 'Origin, 'ProfileName, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#name-1">CdnEndpoint#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: CdnEndpointState<'Location, Missing, 'Origin, 'ProfileName, 'ResourceGroupName>, value: string) : CdnEndpointState<'Location, Present, 'Origin, 'ProfileName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : CdnEndpointState<'Location, Present, 'Origin, 'ProfileName, 'ResourceGroupName>)

        /// <summary>
        /// origin block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#origin-1">CdnEndpoint#origin</a> Accepts: azurerm.IResolvable | azurerm.CdnEndpoint.CdnEndpointOrigin[]
        /// </summary>
        [<CustomOperation "origin">]
        member _.Origin(state: CdnEndpointState<'Location, 'Name, Missing, 'ProfileName, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : CdnEndpointState<'Location, 'Name, Present, 'ProfileName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Origin <- value)
            ({ assignments = state.assignments } : CdnEndpointState<'Location, 'Name, Present, 'ProfileName, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#profile_name-1">CdnEndpoint#profile_name</a>.
        /// </summary>
        [<CustomOperation "profile_name">]
        member _.ProfileName(state: CdnEndpointState<'Location, 'Name, 'Origin, Missing, 'ResourceGroupName>, value: string) : CdnEndpointState<'Location, 'Name, 'Origin, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ProfileName <- value)
            ({ assignments = state.assignments } : CdnEndpointState<'Location, 'Name, 'Origin, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#resource_group_name-1">CdnEndpoint#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: CdnEndpointState<'Location, 'Name, 'Origin, 'ProfileName, Missing>, value: string) : CdnEndpointState<'Location, 'Name, 'Origin, 'ProfileName, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : CdnEndpointState<'Location, 'Name, 'Origin, 'ProfileName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#content_types_to_compress-1">CdnEndpoint#content_types_to_compress</a>.
        /// </summary>
        [<CustomOperation "content_types_to_compress">]
        member _.ContentTypesToCompress(state: CdnEndpointState<'Location, 'Name, 'Origin, 'ProfileName, 'ResourceGroupName>, value: seq<string>) : CdnEndpointState<'Location, 'Name, 'Origin, 'ProfileName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ContentTypesToCompress <- (value |> Seq.toArray))
            state : CdnEndpointState<'Location, 'Name, 'Origin, 'ProfileName, 'ResourceGroupName>

        /// <summary>
        /// delivery_rule block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#delivery_rule-1">CdnEndpoint#delivery_rule</a> Accepts: azurerm.IResolvable | azurerm.CdnEndpoint.CdnEndpointDeliveryRule[]
        /// </summary>
        [<CustomOperation "delivery_rule">]
        member _.DeliveryRule(state: CdnEndpointState<'Location, 'Name, 'Origin, 'ProfileName, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : CdnEndpointState<'Location, 'Name, 'Origin, 'ProfileName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DeliveryRule <- value)
            state : CdnEndpointState<'Location, 'Name, 'Origin, 'ProfileName, 'ResourceGroupName>

        /// <summary>
        /// geo_filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#geo_filter-1">CdnEndpoint#geo_filter</a> Accepts: azurerm.IResolvable | azurerm.CdnEndpoint.CdnEndpointGeoFilter[]
        /// </summary>
        [<CustomOperation "geo_filter">]
        member _.GeoFilter(state: CdnEndpointState<'Location, 'Name, 'Origin, 'ProfileName, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : CdnEndpointState<'Location, 'Name, 'Origin, 'ProfileName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.GeoFilter <- value)
            state : CdnEndpointState<'Location, 'Name, 'Origin, 'ProfileName, 'ResourceGroupName>

        /// <summary>
        /// global_delivery_rule block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#global_delivery_rule-1">CdnEndpoint#global_delivery_rule</a>
        /// </summary>
        [<CustomOperation "global_delivery_rule">]
        member _.GlobalDeliveryRule(state: CdnEndpointState<'Location, 'Name, 'Origin, 'ProfileName, 'ResourceGroupName>, value: azurerm.CdnEndpoint.CdnEndpointGlobalDeliveryRule) : CdnEndpointState<'Location, 'Name, 'Origin, 'ProfileName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.GlobalDeliveryRule <- value)
            state : CdnEndpointState<'Location, 'Name, 'Origin, 'ProfileName, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#id-1">CdnEndpoint#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CdnEndpointState<'Location, 'Name, 'Origin, 'ProfileName, 'ResourceGroupName>, value: string) : CdnEndpointState<'Location, 'Name, 'Origin, 'ProfileName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CdnEndpointState<'Location, 'Name, 'Origin, 'ProfileName, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#is_compression_enabled-1">CdnEndpoint#is_compression_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "is_compression_enabled">]
        member _.IsCompressionEnabled(state: CdnEndpointState<'Location, 'Name, 'Origin, 'ProfileName, 'ResourceGroupName>, value: bool) : CdnEndpointState<'Location, 'Name, 'Origin, 'ProfileName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.IsCompressionEnabled <- value)
            state : CdnEndpointState<'Location, 'Name, 'Origin, 'ProfileName, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#is_compression_enabled-1">CdnEndpoint#is_compression_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "is_compression_enabled">]
        member _.IsCompressionEnabled(state: CdnEndpointState<'Location, 'Name, 'Origin, 'ProfileName, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : CdnEndpointState<'Location, 'Name, 'Origin, 'ProfileName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.IsCompressionEnabled <- value)
            state : CdnEndpointState<'Location, 'Name, 'Origin, 'ProfileName, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#is_http_allowed-1">CdnEndpoint#is_http_allowed</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "is_http_allowed">]
        member _.IsHttpAllowed(state: CdnEndpointState<'Location, 'Name, 'Origin, 'ProfileName, 'ResourceGroupName>, value: bool) : CdnEndpointState<'Location, 'Name, 'Origin, 'ProfileName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.IsHttpAllowed <- value)
            state : CdnEndpointState<'Location, 'Name, 'Origin, 'ProfileName, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#is_http_allowed-1">CdnEndpoint#is_http_allowed</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "is_http_allowed">]
        member _.IsHttpAllowed(state: CdnEndpointState<'Location, 'Name, 'Origin, 'ProfileName, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : CdnEndpointState<'Location, 'Name, 'Origin, 'ProfileName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.IsHttpAllowed <- value)
            state : CdnEndpointState<'Location, 'Name, 'Origin, 'ProfileName, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#is_https_allowed-1">CdnEndpoint#is_https_allowed</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "is_https_allowed">]
        member _.IsHttpsAllowed(state: CdnEndpointState<'Location, 'Name, 'Origin, 'ProfileName, 'ResourceGroupName>, value: bool) : CdnEndpointState<'Location, 'Name, 'Origin, 'ProfileName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.IsHttpsAllowed <- value)
            state : CdnEndpointState<'Location, 'Name, 'Origin, 'ProfileName, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#is_https_allowed-1">CdnEndpoint#is_https_allowed</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "is_https_allowed">]
        member _.IsHttpsAllowed(state: CdnEndpointState<'Location, 'Name, 'Origin, 'ProfileName, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : CdnEndpointState<'Location, 'Name, 'Origin, 'ProfileName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.IsHttpsAllowed <- value)
            state : CdnEndpointState<'Location, 'Name, 'Origin, 'ProfileName, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#optimization_type-1">CdnEndpoint#optimization_type</a>.
        /// </summary>
        [<CustomOperation "optimization_type">]
        member _.OptimizationType(state: CdnEndpointState<'Location, 'Name, 'Origin, 'ProfileName, 'ResourceGroupName>, value: string) : CdnEndpointState<'Location, 'Name, 'Origin, 'ProfileName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.OptimizationType <- value)
            state : CdnEndpointState<'Location, 'Name, 'Origin, 'ProfileName, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#origin_host_header-1">CdnEndpoint#origin_host_header</a>.
        /// </summary>
        [<CustomOperation "origin_host_header">]
        member _.OriginHostHeader(state: CdnEndpointState<'Location, 'Name, 'Origin, 'ProfileName, 'ResourceGroupName>, value: string) : CdnEndpointState<'Location, 'Name, 'Origin, 'ProfileName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.OriginHostHeader <- value)
            state : CdnEndpointState<'Location, 'Name, 'Origin, 'ProfileName, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#origin_path-1">CdnEndpoint#origin_path</a>.
        /// </summary>
        [<CustomOperation "origin_path">]
        member _.OriginPath(state: CdnEndpointState<'Location, 'Name, 'Origin, 'ProfileName, 'ResourceGroupName>, value: string) : CdnEndpointState<'Location, 'Name, 'Origin, 'ProfileName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.OriginPath <- value)
            state : CdnEndpointState<'Location, 'Name, 'Origin, 'ProfileName, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#probe_path-1">CdnEndpoint#probe_path</a>.
        /// </summary>
        [<CustomOperation "probe_path">]
        member _.ProbePath(state: CdnEndpointState<'Location, 'Name, 'Origin, 'ProfileName, 'ResourceGroupName>, value: string) : CdnEndpointState<'Location, 'Name, 'Origin, 'ProfileName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ProbePath <- value)
            state : CdnEndpointState<'Location, 'Name, 'Origin, 'ProfileName, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#querystring_caching_behaviour-1">CdnEndpoint#querystring_caching_behaviour</a>.
        /// </summary>
        [<CustomOperation "querystring_caching_behaviour">]
        member _.QuerystringCachingBehaviour(state: CdnEndpointState<'Location, 'Name, 'Origin, 'ProfileName, 'ResourceGroupName>, value: string) : CdnEndpointState<'Location, 'Name, 'Origin, 'ProfileName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.QuerystringCachingBehaviour <- value)
            state : CdnEndpointState<'Location, 'Name, 'Origin, 'ProfileName, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#tags-1">CdnEndpoint#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: CdnEndpointState<'Location, 'Name, 'Origin, 'ProfileName, 'ResourceGroupName>, value: seq<string * string>) : CdnEndpointState<'Location, 'Name, 'Origin, 'ProfileName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : CdnEndpointState<'Location, 'Name, 'Origin, 'ProfileName, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#timeouts-1">CdnEndpoint#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: CdnEndpointState<'Location, 'Name, 'Origin, 'ProfileName, 'ResourceGroupName>, value: azurerm.CdnEndpoint.CdnEndpointTimeouts) : CdnEndpointState<'Location, 'Name, 'Origin, 'ProfileName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : CdnEndpointState<'Location, 'Name, 'Origin, 'ProfileName, 'ResourceGroupName>

        member _.Run(state: CdnEndpointState<Present, Present, Present, Present, Present>) : azurerm.CdnEndpoint.CdnEndpoint =
            let config = azurerm.CdnEndpoint.CdnEndpointConfig()
            for setter in state.assignments do
                setter config
            azurerm.CdnEndpoint.CdnEndpoint(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.cdnEndpoint: missing required arguments. Must call: location, name, origin, profile_name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: CdnEndpointState<_, _, _, _, _>) : azurerm.CdnEndpoint.CdnEndpoint =
            Unchecked.defaultof<azurerm.CdnEndpoint.CdnEndpoint>

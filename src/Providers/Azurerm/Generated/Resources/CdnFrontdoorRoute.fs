namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CdnFrontdoorRouteState<'CdnFrontdoorEndpointId, 'CdnFrontdoorOriginGroupId, 'CdnFrontdoorOriginIds, 'Name, 'PatternsToMatch, 'SupportedProtocols> = { assignments: ResizeArray<azurerm.CdnFrontdoorRoute.CdnFrontdoorRouteConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_route">azurerm_cdn_frontdoor_route</a>.
    /// </summary>
    type CdnFrontdoorRouteBuilder(logicalId: string) =
        member _.Yield(_: unit) : CdnFrontdoorRouteState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CdnFrontdoorRouteState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : CdnFrontdoorRouteState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CdnFrontdoorRouteState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_route#cdn_frontdoor_endpoint_id-1">CdnFrontdoorRoute#cdn_frontdoor_endpoint_id</a>.
        /// </summary>
        [<CustomOperation "cdn_frontdoor_endpoint_id">]
        member _.CdnFrontdoorEndpointId(state: CdnFrontdoorRouteState<Missing, 'CdnFrontdoorOriginGroupId, 'CdnFrontdoorOriginIds, 'Name, 'PatternsToMatch, 'SupportedProtocols>, value: string) : CdnFrontdoorRouteState<Present, 'CdnFrontdoorOriginGroupId, 'CdnFrontdoorOriginIds, 'Name, 'PatternsToMatch, 'SupportedProtocols> =
            state.assignments.Add(fun config -> config.CdnFrontdoorEndpointId <- value)
            ({ assignments = state.assignments } : CdnFrontdoorRouteState<Present, 'CdnFrontdoorOriginGroupId, 'CdnFrontdoorOriginIds, 'Name, 'PatternsToMatch, 'SupportedProtocols>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_route#cdn_frontdoor_origin_group_id-1">CdnFrontdoorRoute#cdn_frontdoor_origin_group_id</a>.
        /// </summary>
        [<CustomOperation "cdn_frontdoor_origin_group_id">]
        member _.CdnFrontdoorOriginGroupId(state: CdnFrontdoorRouteState<'CdnFrontdoorEndpointId, Missing, 'CdnFrontdoorOriginIds, 'Name, 'PatternsToMatch, 'SupportedProtocols>, value: string) : CdnFrontdoorRouteState<'CdnFrontdoorEndpointId, Present, 'CdnFrontdoorOriginIds, 'Name, 'PatternsToMatch, 'SupportedProtocols> =
            state.assignments.Add(fun config -> config.CdnFrontdoorOriginGroupId <- value)
            ({ assignments = state.assignments } : CdnFrontdoorRouteState<'CdnFrontdoorEndpointId, Present, 'CdnFrontdoorOriginIds, 'Name, 'PatternsToMatch, 'SupportedProtocols>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_route#cdn_frontdoor_origin_ids-1">CdnFrontdoorRoute#cdn_frontdoor_origin_ids</a>.
        /// </summary>
        [<CustomOperation "cdn_frontdoor_origin_ids">]
        member _.CdnFrontdoorOriginIds(state: CdnFrontdoorRouteState<'CdnFrontdoorEndpointId, 'CdnFrontdoorOriginGroupId, Missing, 'Name, 'PatternsToMatch, 'SupportedProtocols>, value: seq<string>) : CdnFrontdoorRouteState<'CdnFrontdoorEndpointId, 'CdnFrontdoorOriginGroupId, Present, 'Name, 'PatternsToMatch, 'SupportedProtocols> =
            state.assignments.Add(fun config -> config.CdnFrontdoorOriginIds <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : CdnFrontdoorRouteState<'CdnFrontdoorEndpointId, 'CdnFrontdoorOriginGroupId, Present, 'Name, 'PatternsToMatch, 'SupportedProtocols>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_route#name-1">CdnFrontdoorRoute#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: CdnFrontdoorRouteState<'CdnFrontdoorEndpointId, 'CdnFrontdoorOriginGroupId, 'CdnFrontdoorOriginIds, Missing, 'PatternsToMatch, 'SupportedProtocols>, value: string) : CdnFrontdoorRouteState<'CdnFrontdoorEndpointId, 'CdnFrontdoorOriginGroupId, 'CdnFrontdoorOriginIds, Present, 'PatternsToMatch, 'SupportedProtocols> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : CdnFrontdoorRouteState<'CdnFrontdoorEndpointId, 'CdnFrontdoorOriginGroupId, 'CdnFrontdoorOriginIds, Present, 'PatternsToMatch, 'SupportedProtocols>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_route#patterns_to_match-1">CdnFrontdoorRoute#patterns_to_match</a>.
        /// </summary>
        [<CustomOperation "patterns_to_match">]
        member _.PatternsToMatch(state: CdnFrontdoorRouteState<'CdnFrontdoorEndpointId, 'CdnFrontdoorOriginGroupId, 'CdnFrontdoorOriginIds, 'Name, Missing, 'SupportedProtocols>, value: seq<string>) : CdnFrontdoorRouteState<'CdnFrontdoorEndpointId, 'CdnFrontdoorOriginGroupId, 'CdnFrontdoorOriginIds, 'Name, Present, 'SupportedProtocols> =
            state.assignments.Add(fun config -> config.PatternsToMatch <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : CdnFrontdoorRouteState<'CdnFrontdoorEndpointId, 'CdnFrontdoorOriginGroupId, 'CdnFrontdoorOriginIds, 'Name, Present, 'SupportedProtocols>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_route#supported_protocols-1">CdnFrontdoorRoute#supported_protocols</a>.
        /// </summary>
        [<CustomOperation "supported_protocols">]
        member _.SupportedProtocols(state: CdnFrontdoorRouteState<'CdnFrontdoorEndpointId, 'CdnFrontdoorOriginGroupId, 'CdnFrontdoorOriginIds, 'Name, 'PatternsToMatch, Missing>, value: seq<string>) : CdnFrontdoorRouteState<'CdnFrontdoorEndpointId, 'CdnFrontdoorOriginGroupId, 'CdnFrontdoorOriginIds, 'Name, 'PatternsToMatch, Present> =
            state.assignments.Add(fun config -> config.SupportedProtocols <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : CdnFrontdoorRouteState<'CdnFrontdoorEndpointId, 'CdnFrontdoorOriginGroupId, 'CdnFrontdoorOriginIds, 'Name, 'PatternsToMatch, Present>)

        /// <summary>
        /// cache block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_route#cache-1">CdnFrontdoorRoute#cache</a>
        /// </summary>
        [<CustomOperation "cache">]
        member _.Cache(state: CdnFrontdoorRouteState<'CdnFrontdoorEndpointId, 'CdnFrontdoorOriginGroupId, 'CdnFrontdoorOriginIds, 'Name, 'PatternsToMatch, 'SupportedProtocols>, value: azurerm.CdnFrontdoorRoute.CdnFrontdoorRouteCache) : CdnFrontdoorRouteState<'CdnFrontdoorEndpointId, 'CdnFrontdoorOriginGroupId, 'CdnFrontdoorOriginIds, 'Name, 'PatternsToMatch, 'SupportedProtocols> =
            state.assignments.Add(fun config -> config.Cache <- value)
            state : CdnFrontdoorRouteState<'CdnFrontdoorEndpointId, 'CdnFrontdoorOriginGroupId, 'CdnFrontdoorOriginIds, 'Name, 'PatternsToMatch, 'SupportedProtocols>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_route#cdn_frontdoor_custom_domain_ids-1">CdnFrontdoorRoute#cdn_frontdoor_custom_domain_ids</a>.
        /// </summary>
        [<CustomOperation "cdn_frontdoor_custom_domain_ids">]
        member _.CdnFrontdoorCustomDomainIds(state: CdnFrontdoorRouteState<'CdnFrontdoorEndpointId, 'CdnFrontdoorOriginGroupId, 'CdnFrontdoorOriginIds, 'Name, 'PatternsToMatch, 'SupportedProtocols>, value: seq<string>) : CdnFrontdoorRouteState<'CdnFrontdoorEndpointId, 'CdnFrontdoorOriginGroupId, 'CdnFrontdoorOriginIds, 'Name, 'PatternsToMatch, 'SupportedProtocols> =
            state.assignments.Add(fun config -> config.CdnFrontdoorCustomDomainIds <- (value |> Seq.toArray))
            state : CdnFrontdoorRouteState<'CdnFrontdoorEndpointId, 'CdnFrontdoorOriginGroupId, 'CdnFrontdoorOriginIds, 'Name, 'PatternsToMatch, 'SupportedProtocols>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_route#cdn_frontdoor_origin_path-1">CdnFrontdoorRoute#cdn_frontdoor_origin_path</a>.
        /// </summary>
        [<CustomOperation "cdn_frontdoor_origin_path">]
        member _.CdnFrontdoorOriginPath(state: CdnFrontdoorRouteState<'CdnFrontdoorEndpointId, 'CdnFrontdoorOriginGroupId, 'CdnFrontdoorOriginIds, 'Name, 'PatternsToMatch, 'SupportedProtocols>, value: string) : CdnFrontdoorRouteState<'CdnFrontdoorEndpointId, 'CdnFrontdoorOriginGroupId, 'CdnFrontdoorOriginIds, 'Name, 'PatternsToMatch, 'SupportedProtocols> =
            state.assignments.Add(fun config -> config.CdnFrontdoorOriginPath <- value)
            state : CdnFrontdoorRouteState<'CdnFrontdoorEndpointId, 'CdnFrontdoorOriginGroupId, 'CdnFrontdoorOriginIds, 'Name, 'PatternsToMatch, 'SupportedProtocols>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_route#cdn_frontdoor_rule_set_ids-1">CdnFrontdoorRoute#cdn_frontdoor_rule_set_ids</a>.
        /// </summary>
        [<CustomOperation "cdn_frontdoor_rule_set_ids">]
        member _.CdnFrontdoorRuleSetIds(state: CdnFrontdoorRouteState<'CdnFrontdoorEndpointId, 'CdnFrontdoorOriginGroupId, 'CdnFrontdoorOriginIds, 'Name, 'PatternsToMatch, 'SupportedProtocols>, value: seq<string>) : CdnFrontdoorRouteState<'CdnFrontdoorEndpointId, 'CdnFrontdoorOriginGroupId, 'CdnFrontdoorOriginIds, 'Name, 'PatternsToMatch, 'SupportedProtocols> =
            state.assignments.Add(fun config -> config.CdnFrontdoorRuleSetIds <- (value |> Seq.toArray))
            state : CdnFrontdoorRouteState<'CdnFrontdoorEndpointId, 'CdnFrontdoorOriginGroupId, 'CdnFrontdoorOriginIds, 'Name, 'PatternsToMatch, 'SupportedProtocols>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_route#enabled-1">CdnFrontdoorRoute#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: CdnFrontdoorRouteState<'CdnFrontdoorEndpointId, 'CdnFrontdoorOriginGroupId, 'CdnFrontdoorOriginIds, 'Name, 'PatternsToMatch, 'SupportedProtocols>, value: bool) : CdnFrontdoorRouteState<'CdnFrontdoorEndpointId, 'CdnFrontdoorOriginGroupId, 'CdnFrontdoorOriginIds, 'Name, 'PatternsToMatch, 'SupportedProtocols> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : CdnFrontdoorRouteState<'CdnFrontdoorEndpointId, 'CdnFrontdoorOriginGroupId, 'CdnFrontdoorOriginIds, 'Name, 'PatternsToMatch, 'SupportedProtocols>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_route#enabled-1">CdnFrontdoorRoute#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: CdnFrontdoorRouteState<'CdnFrontdoorEndpointId, 'CdnFrontdoorOriginGroupId, 'CdnFrontdoorOriginIds, 'Name, 'PatternsToMatch, 'SupportedProtocols>, value: HashiCorp.Cdktf.IResolvable) : CdnFrontdoorRouteState<'CdnFrontdoorEndpointId, 'CdnFrontdoorOriginGroupId, 'CdnFrontdoorOriginIds, 'Name, 'PatternsToMatch, 'SupportedProtocols> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : CdnFrontdoorRouteState<'CdnFrontdoorEndpointId, 'CdnFrontdoorOriginGroupId, 'CdnFrontdoorOriginIds, 'Name, 'PatternsToMatch, 'SupportedProtocols>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_route#forwarding_protocol-1">CdnFrontdoorRoute#forwarding_protocol</a>.
        /// </summary>
        [<CustomOperation "forwarding_protocol">]
        member _.ForwardingProtocol(state: CdnFrontdoorRouteState<'CdnFrontdoorEndpointId, 'CdnFrontdoorOriginGroupId, 'CdnFrontdoorOriginIds, 'Name, 'PatternsToMatch, 'SupportedProtocols>, value: string) : CdnFrontdoorRouteState<'CdnFrontdoorEndpointId, 'CdnFrontdoorOriginGroupId, 'CdnFrontdoorOriginIds, 'Name, 'PatternsToMatch, 'SupportedProtocols> =
            state.assignments.Add(fun config -> config.ForwardingProtocol <- value)
            state : CdnFrontdoorRouteState<'CdnFrontdoorEndpointId, 'CdnFrontdoorOriginGroupId, 'CdnFrontdoorOriginIds, 'Name, 'PatternsToMatch, 'SupportedProtocols>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_route#https_redirect_enabled-1">CdnFrontdoorRoute#https_redirect_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "https_redirect_enabled">]
        member _.HttpsRedirectEnabled(state: CdnFrontdoorRouteState<'CdnFrontdoorEndpointId, 'CdnFrontdoorOriginGroupId, 'CdnFrontdoorOriginIds, 'Name, 'PatternsToMatch, 'SupportedProtocols>, value: bool) : CdnFrontdoorRouteState<'CdnFrontdoorEndpointId, 'CdnFrontdoorOriginGroupId, 'CdnFrontdoorOriginIds, 'Name, 'PatternsToMatch, 'SupportedProtocols> =
            state.assignments.Add(fun config -> config.HttpsRedirectEnabled <- value)
            state : CdnFrontdoorRouteState<'CdnFrontdoorEndpointId, 'CdnFrontdoorOriginGroupId, 'CdnFrontdoorOriginIds, 'Name, 'PatternsToMatch, 'SupportedProtocols>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_route#https_redirect_enabled-1">CdnFrontdoorRoute#https_redirect_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "https_redirect_enabled">]
        member _.HttpsRedirectEnabled(state: CdnFrontdoorRouteState<'CdnFrontdoorEndpointId, 'CdnFrontdoorOriginGroupId, 'CdnFrontdoorOriginIds, 'Name, 'PatternsToMatch, 'SupportedProtocols>, value: HashiCorp.Cdktf.IResolvable) : CdnFrontdoorRouteState<'CdnFrontdoorEndpointId, 'CdnFrontdoorOriginGroupId, 'CdnFrontdoorOriginIds, 'Name, 'PatternsToMatch, 'SupportedProtocols> =
            state.assignments.Add(fun config -> config.HttpsRedirectEnabled <- value)
            state : CdnFrontdoorRouteState<'CdnFrontdoorEndpointId, 'CdnFrontdoorOriginGroupId, 'CdnFrontdoorOriginIds, 'Name, 'PatternsToMatch, 'SupportedProtocols>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_route#id-1">CdnFrontdoorRoute#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CdnFrontdoorRouteState<'CdnFrontdoorEndpointId, 'CdnFrontdoorOriginGroupId, 'CdnFrontdoorOriginIds, 'Name, 'PatternsToMatch, 'SupportedProtocols>, value: string) : CdnFrontdoorRouteState<'CdnFrontdoorEndpointId, 'CdnFrontdoorOriginGroupId, 'CdnFrontdoorOriginIds, 'Name, 'PatternsToMatch, 'SupportedProtocols> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CdnFrontdoorRouteState<'CdnFrontdoorEndpointId, 'CdnFrontdoorOriginGroupId, 'CdnFrontdoorOriginIds, 'Name, 'PatternsToMatch, 'SupportedProtocols>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_route#link_to_default_domain-1">CdnFrontdoorRoute#link_to_default_domain</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "link_to_default_domain">]
        member _.LinkToDefaultDomain(state: CdnFrontdoorRouteState<'CdnFrontdoorEndpointId, 'CdnFrontdoorOriginGroupId, 'CdnFrontdoorOriginIds, 'Name, 'PatternsToMatch, 'SupportedProtocols>, value: bool) : CdnFrontdoorRouteState<'CdnFrontdoorEndpointId, 'CdnFrontdoorOriginGroupId, 'CdnFrontdoorOriginIds, 'Name, 'PatternsToMatch, 'SupportedProtocols> =
            state.assignments.Add(fun config -> config.LinkToDefaultDomain <- value)
            state : CdnFrontdoorRouteState<'CdnFrontdoorEndpointId, 'CdnFrontdoorOriginGroupId, 'CdnFrontdoorOriginIds, 'Name, 'PatternsToMatch, 'SupportedProtocols>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_route#link_to_default_domain-1">CdnFrontdoorRoute#link_to_default_domain</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "link_to_default_domain">]
        member _.LinkToDefaultDomain(state: CdnFrontdoorRouteState<'CdnFrontdoorEndpointId, 'CdnFrontdoorOriginGroupId, 'CdnFrontdoorOriginIds, 'Name, 'PatternsToMatch, 'SupportedProtocols>, value: HashiCorp.Cdktf.IResolvable) : CdnFrontdoorRouteState<'CdnFrontdoorEndpointId, 'CdnFrontdoorOriginGroupId, 'CdnFrontdoorOriginIds, 'Name, 'PatternsToMatch, 'SupportedProtocols> =
            state.assignments.Add(fun config -> config.LinkToDefaultDomain <- value)
            state : CdnFrontdoorRouteState<'CdnFrontdoorEndpointId, 'CdnFrontdoorOriginGroupId, 'CdnFrontdoorOriginIds, 'Name, 'PatternsToMatch, 'SupportedProtocols>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_route#timeouts-1">CdnFrontdoorRoute#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: CdnFrontdoorRouteState<'CdnFrontdoorEndpointId, 'CdnFrontdoorOriginGroupId, 'CdnFrontdoorOriginIds, 'Name, 'PatternsToMatch, 'SupportedProtocols>, value: azurerm.CdnFrontdoorRoute.CdnFrontdoorRouteTimeouts) : CdnFrontdoorRouteState<'CdnFrontdoorEndpointId, 'CdnFrontdoorOriginGroupId, 'CdnFrontdoorOriginIds, 'Name, 'PatternsToMatch, 'SupportedProtocols> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : CdnFrontdoorRouteState<'CdnFrontdoorEndpointId, 'CdnFrontdoorOriginGroupId, 'CdnFrontdoorOriginIds, 'Name, 'PatternsToMatch, 'SupportedProtocols>

        member _.Run(state: CdnFrontdoorRouteState<Present, Present, Present, Present, Present, Present>) : azurerm.CdnFrontdoorRoute.CdnFrontdoorRoute =
            let config = azurerm.CdnFrontdoorRoute.CdnFrontdoorRouteConfig()
            for setter in state.assignments do
                setter config
            azurerm.CdnFrontdoorRoute.CdnFrontdoorRoute(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.cdnFrontdoorRoute: missing required arguments. Must call: cdn_frontdoor_endpoint_id, cdn_frontdoor_origin_group_id, cdn_frontdoor_origin_ids, name, patterns_to_match, supported_protocols.", 9999, IsError = true)>]
        member _.Run(_: CdnFrontdoorRouteState<_, _, _, _, _, _>) : azurerm.CdnFrontdoorRoute.CdnFrontdoorRoute =
            Unchecked.defaultof<azurerm.CdnFrontdoorRoute.CdnFrontdoorRoute>

namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CdnFrontdoorOriginState<'CdnFrontdoorOriginGroupId, 'CertificateNameCheckEnabled, 'HostName, 'Name> = { assignments: ResizeArray<azurerm.CdnFrontdoorOrigin.CdnFrontdoorOriginConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_origin">azurerm_cdn_frontdoor_origin</a>.
    /// </summary>
    type CdnFrontdoorOriginBuilder(logicalId: string) =
        member _.Yield(_: unit) : CdnFrontdoorOriginState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CdnFrontdoorOriginState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : CdnFrontdoorOriginState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CdnFrontdoorOriginState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_origin#cdn_frontdoor_origin_group_id-1">CdnFrontdoorOrigin#cdn_frontdoor_origin_group_id</a>.
        /// </summary>
        [<CustomOperation "cdn_frontdoor_origin_group_id">]
        member _.CdnFrontdoorOriginGroupId(state: CdnFrontdoorOriginState<Missing, 'CertificateNameCheckEnabled, 'HostName, 'Name>, value: string) : CdnFrontdoorOriginState<Present, 'CertificateNameCheckEnabled, 'HostName, 'Name> =
            state.assignments.Add(fun config -> config.CdnFrontdoorOriginGroupId <- value)
            ({ assignments = state.assignments } : CdnFrontdoorOriginState<Present, 'CertificateNameCheckEnabled, 'HostName, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_origin#certificate_name_check_enabled-1">CdnFrontdoorOrigin#certificate_name_check_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "certificate_name_check_enabled">]
        member _.CertificateNameCheckEnabled(state: CdnFrontdoorOriginState<'CdnFrontdoorOriginGroupId, Missing, 'HostName, 'Name>, value: bool) : CdnFrontdoorOriginState<'CdnFrontdoorOriginGroupId, Present, 'HostName, 'Name> =
            state.assignments.Add(fun config -> config.CertificateNameCheckEnabled <- value)
            ({ assignments = state.assignments } : CdnFrontdoorOriginState<'CdnFrontdoorOriginGroupId, Present, 'HostName, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_origin#certificate_name_check_enabled-1">CdnFrontdoorOrigin#certificate_name_check_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "certificate_name_check_enabled">]
        member _.CertificateNameCheckEnabled(state: CdnFrontdoorOriginState<'CdnFrontdoorOriginGroupId, Missing, 'HostName, 'Name>, value: HashiCorp.Cdktf.IResolvable) : CdnFrontdoorOriginState<'CdnFrontdoorOriginGroupId, Present, 'HostName, 'Name> =
            state.assignments.Add(fun config -> config.CertificateNameCheckEnabled <- value)
            ({ assignments = state.assignments } : CdnFrontdoorOriginState<'CdnFrontdoorOriginGroupId, Present, 'HostName, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_origin#host_name-1">CdnFrontdoorOrigin#host_name</a>.
        /// </summary>
        [<CustomOperation "host_name">]
        member _.HostName(state: CdnFrontdoorOriginState<'CdnFrontdoorOriginGroupId, 'CertificateNameCheckEnabled, Missing, 'Name>, value: string) : CdnFrontdoorOriginState<'CdnFrontdoorOriginGroupId, 'CertificateNameCheckEnabled, Present, 'Name> =
            state.assignments.Add(fun config -> config.HostName <- value)
            ({ assignments = state.assignments } : CdnFrontdoorOriginState<'CdnFrontdoorOriginGroupId, 'CertificateNameCheckEnabled, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_origin#name-1">CdnFrontdoorOrigin#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: CdnFrontdoorOriginState<'CdnFrontdoorOriginGroupId, 'CertificateNameCheckEnabled, 'HostName, Missing>, value: string) : CdnFrontdoorOriginState<'CdnFrontdoorOriginGroupId, 'CertificateNameCheckEnabled, 'HostName, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : CdnFrontdoorOriginState<'CdnFrontdoorOriginGroupId, 'CertificateNameCheckEnabled, 'HostName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_origin#enabled-1">CdnFrontdoorOrigin#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: CdnFrontdoorOriginState<'CdnFrontdoorOriginGroupId, 'CertificateNameCheckEnabled, 'HostName, 'Name>, value: bool) : CdnFrontdoorOriginState<'CdnFrontdoorOriginGroupId, 'CertificateNameCheckEnabled, 'HostName, 'Name> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : CdnFrontdoorOriginState<'CdnFrontdoorOriginGroupId, 'CertificateNameCheckEnabled, 'HostName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_origin#enabled-1">CdnFrontdoorOrigin#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: CdnFrontdoorOriginState<'CdnFrontdoorOriginGroupId, 'CertificateNameCheckEnabled, 'HostName, 'Name>, value: HashiCorp.Cdktf.IResolvable) : CdnFrontdoorOriginState<'CdnFrontdoorOriginGroupId, 'CertificateNameCheckEnabled, 'HostName, 'Name> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : CdnFrontdoorOriginState<'CdnFrontdoorOriginGroupId, 'CertificateNameCheckEnabled, 'HostName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_origin#http_port-1">CdnFrontdoorOrigin#http_port</a>.
        /// </summary>
        [<CustomOperation "http_port">]
        member _.HttpPort(state: CdnFrontdoorOriginState<'CdnFrontdoorOriginGroupId, 'CertificateNameCheckEnabled, 'HostName, 'Name>, value: double) : CdnFrontdoorOriginState<'CdnFrontdoorOriginGroupId, 'CertificateNameCheckEnabled, 'HostName, 'Name> =
            state.assignments.Add(fun config -> config.HttpPort <- value)
            state : CdnFrontdoorOriginState<'CdnFrontdoorOriginGroupId, 'CertificateNameCheckEnabled, 'HostName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_origin#https_port-1">CdnFrontdoorOrigin#https_port</a>.
        /// </summary>
        [<CustomOperation "https_port">]
        member _.HttpsPort(state: CdnFrontdoorOriginState<'CdnFrontdoorOriginGroupId, 'CertificateNameCheckEnabled, 'HostName, 'Name>, value: double) : CdnFrontdoorOriginState<'CdnFrontdoorOriginGroupId, 'CertificateNameCheckEnabled, 'HostName, 'Name> =
            state.assignments.Add(fun config -> config.HttpsPort <- value)
            state : CdnFrontdoorOriginState<'CdnFrontdoorOriginGroupId, 'CertificateNameCheckEnabled, 'HostName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_origin#id-1">CdnFrontdoorOrigin#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CdnFrontdoorOriginState<'CdnFrontdoorOriginGroupId, 'CertificateNameCheckEnabled, 'HostName, 'Name>, value: string) : CdnFrontdoorOriginState<'CdnFrontdoorOriginGroupId, 'CertificateNameCheckEnabled, 'HostName, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CdnFrontdoorOriginState<'CdnFrontdoorOriginGroupId, 'CertificateNameCheckEnabled, 'HostName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_origin#origin_host_header-1">CdnFrontdoorOrigin#origin_host_header</a>.
        /// </summary>
        [<CustomOperation "origin_host_header">]
        member _.OriginHostHeader(state: CdnFrontdoorOriginState<'CdnFrontdoorOriginGroupId, 'CertificateNameCheckEnabled, 'HostName, 'Name>, value: string) : CdnFrontdoorOriginState<'CdnFrontdoorOriginGroupId, 'CertificateNameCheckEnabled, 'HostName, 'Name> =
            state.assignments.Add(fun config -> config.OriginHostHeader <- value)
            state : CdnFrontdoorOriginState<'CdnFrontdoorOriginGroupId, 'CertificateNameCheckEnabled, 'HostName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_origin#priority-1">CdnFrontdoorOrigin#priority</a>.
        /// </summary>
        [<CustomOperation "priority">]
        member _.Priority(state: CdnFrontdoorOriginState<'CdnFrontdoorOriginGroupId, 'CertificateNameCheckEnabled, 'HostName, 'Name>, value: double) : CdnFrontdoorOriginState<'CdnFrontdoorOriginGroupId, 'CertificateNameCheckEnabled, 'HostName, 'Name> =
            state.assignments.Add(fun config -> config.Priority <- value)
            state : CdnFrontdoorOriginState<'CdnFrontdoorOriginGroupId, 'CertificateNameCheckEnabled, 'HostName, 'Name>

        /// <summary>
        /// private_link block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_origin#private_link-1">CdnFrontdoorOrigin#private_link</a>
        /// </summary>
        [<CustomOperation "private_link">]
        member _.PrivateLink(state: CdnFrontdoorOriginState<'CdnFrontdoorOriginGroupId, 'CertificateNameCheckEnabled, 'HostName, 'Name>, value: azurerm.CdnFrontdoorOrigin.CdnFrontdoorOriginPrivateLink) : CdnFrontdoorOriginState<'CdnFrontdoorOriginGroupId, 'CertificateNameCheckEnabled, 'HostName, 'Name> =
            state.assignments.Add(fun config -> config.PrivateLink <- value)
            state : CdnFrontdoorOriginState<'CdnFrontdoorOriginGroupId, 'CertificateNameCheckEnabled, 'HostName, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_origin#timeouts-1">CdnFrontdoorOrigin#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: CdnFrontdoorOriginState<'CdnFrontdoorOriginGroupId, 'CertificateNameCheckEnabled, 'HostName, 'Name>, value: azurerm.CdnFrontdoorOrigin.CdnFrontdoorOriginTimeouts) : CdnFrontdoorOriginState<'CdnFrontdoorOriginGroupId, 'CertificateNameCheckEnabled, 'HostName, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : CdnFrontdoorOriginState<'CdnFrontdoorOriginGroupId, 'CertificateNameCheckEnabled, 'HostName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_origin#weight-1">CdnFrontdoorOrigin#weight</a>.
        /// </summary>
        [<CustomOperation "weight">]
        member _.Weight(state: CdnFrontdoorOriginState<'CdnFrontdoorOriginGroupId, 'CertificateNameCheckEnabled, 'HostName, 'Name>, value: double) : CdnFrontdoorOriginState<'CdnFrontdoorOriginGroupId, 'CertificateNameCheckEnabled, 'HostName, 'Name> =
            state.assignments.Add(fun config -> config.Weight <- value)
            state : CdnFrontdoorOriginState<'CdnFrontdoorOriginGroupId, 'CertificateNameCheckEnabled, 'HostName, 'Name>

        member _.Run(state: CdnFrontdoorOriginState<Present, Present, Present, Present>) : azurerm.CdnFrontdoorOrigin.CdnFrontdoorOrigin =
            let config = azurerm.CdnFrontdoorOrigin.CdnFrontdoorOriginConfig()
            for setter in state.assignments do
                setter config
            azurerm.CdnFrontdoorOrigin.CdnFrontdoorOrigin(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.cdnFrontdoorOrigin: missing required arguments. Must call: cdn_frontdoor_origin_group_id, certificate_name_check_enabled, host_name, name.", 9999, IsError = true)>]
        member _.Run(_: CdnFrontdoorOriginState<_, _, _, _>) : azurerm.CdnFrontdoorOrigin.CdnFrontdoorOrigin =
            Unchecked.defaultof<azurerm.CdnFrontdoorOrigin.CdnFrontdoorOrigin>

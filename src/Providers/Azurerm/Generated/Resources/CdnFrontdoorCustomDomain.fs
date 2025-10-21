namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CdnFrontdoorCustomDomainState<'CdnFrontdoorProfileId, 'HostName, 'Name, 'Tls> = { assignments: ResizeArray<azurerm.CdnFrontdoorCustomDomain.CdnFrontdoorCustomDomainConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_custom_domain">azurerm_cdn_frontdoor_custom_domain</a>.
    /// </summary>
    type CdnFrontdoorCustomDomainBuilder(logicalId: string) =
        member _.Yield(_: unit) : CdnFrontdoorCustomDomainState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CdnFrontdoorCustomDomainState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : CdnFrontdoorCustomDomainState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CdnFrontdoorCustomDomainState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_custom_domain#cdn_frontdoor_profile_id-1">CdnFrontdoorCustomDomain#cdn_frontdoor_profile_id</a>.
        /// </summary>
        [<CustomOperation "cdn_frontdoor_profile_id">]
        member _.CdnFrontdoorProfileId(state: CdnFrontdoorCustomDomainState<Missing, 'HostName, 'Name, 'Tls>, value: string) : CdnFrontdoorCustomDomainState<Present, 'HostName, 'Name, 'Tls> =
            state.assignments.Add(fun config -> config.CdnFrontdoorProfileId <- value)
            ({ assignments = state.assignments } : CdnFrontdoorCustomDomainState<Present, 'HostName, 'Name, 'Tls>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_custom_domain#host_name-1">CdnFrontdoorCustomDomain#host_name</a>.
        /// </summary>
        [<CustomOperation "host_name">]
        member _.HostName(state: CdnFrontdoorCustomDomainState<'CdnFrontdoorProfileId, Missing, 'Name, 'Tls>, value: string) : CdnFrontdoorCustomDomainState<'CdnFrontdoorProfileId, Present, 'Name, 'Tls> =
            state.assignments.Add(fun config -> config.HostName <- value)
            ({ assignments = state.assignments } : CdnFrontdoorCustomDomainState<'CdnFrontdoorProfileId, Present, 'Name, 'Tls>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_custom_domain#name-1">CdnFrontdoorCustomDomain#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: CdnFrontdoorCustomDomainState<'CdnFrontdoorProfileId, 'HostName, Missing, 'Tls>, value: string) : CdnFrontdoorCustomDomainState<'CdnFrontdoorProfileId, 'HostName, Present, 'Tls> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : CdnFrontdoorCustomDomainState<'CdnFrontdoorProfileId, 'HostName, Present, 'Tls>)

        /// <summary>
        /// tls block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_custom_domain#tls-1">CdnFrontdoorCustomDomain#tls</a>
        /// </summary>
        [<CustomOperation "tls">]
        member _.Tls(state: CdnFrontdoorCustomDomainState<'CdnFrontdoorProfileId, 'HostName, 'Name, Missing>, value: azurerm.CdnFrontdoorCustomDomain.CdnFrontdoorCustomDomainTls) : CdnFrontdoorCustomDomainState<'CdnFrontdoorProfileId, 'HostName, 'Name, Present> =
            state.assignments.Add(fun config -> config.Tls <- value)
            ({ assignments = state.assignments } : CdnFrontdoorCustomDomainState<'CdnFrontdoorProfileId, 'HostName, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_custom_domain#dns_zone_id-1">CdnFrontdoorCustomDomain#dns_zone_id</a>.
        /// </summary>
        [<CustomOperation "dns_zone_id">]
        member _.DnsZoneId(state: CdnFrontdoorCustomDomainState<'CdnFrontdoorProfileId, 'HostName, 'Name, 'Tls>, value: string) : CdnFrontdoorCustomDomainState<'CdnFrontdoorProfileId, 'HostName, 'Name, 'Tls> =
            state.assignments.Add(fun config -> config.DnsZoneId <- value)
            state : CdnFrontdoorCustomDomainState<'CdnFrontdoorProfileId, 'HostName, 'Name, 'Tls>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_custom_domain#id-1">CdnFrontdoorCustomDomain#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CdnFrontdoorCustomDomainState<'CdnFrontdoorProfileId, 'HostName, 'Name, 'Tls>, value: string) : CdnFrontdoorCustomDomainState<'CdnFrontdoorProfileId, 'HostName, 'Name, 'Tls> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CdnFrontdoorCustomDomainState<'CdnFrontdoorProfileId, 'HostName, 'Name, 'Tls>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_custom_domain#timeouts-1">CdnFrontdoorCustomDomain#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: CdnFrontdoorCustomDomainState<'CdnFrontdoorProfileId, 'HostName, 'Name, 'Tls>, value: azurerm.CdnFrontdoorCustomDomain.CdnFrontdoorCustomDomainTimeouts) : CdnFrontdoorCustomDomainState<'CdnFrontdoorProfileId, 'HostName, 'Name, 'Tls> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : CdnFrontdoorCustomDomainState<'CdnFrontdoorProfileId, 'HostName, 'Name, 'Tls>

        member _.Run(state: CdnFrontdoorCustomDomainState<Present, Present, Present, Present>) : azurerm.CdnFrontdoorCustomDomain.CdnFrontdoorCustomDomain =
            let config = azurerm.CdnFrontdoorCustomDomain.CdnFrontdoorCustomDomainConfig()
            for setter in state.assignments do
                setter config
            azurerm.CdnFrontdoorCustomDomain.CdnFrontdoorCustomDomain(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.cdnFrontdoorCustomDomain: missing required arguments. Must call: cdn_frontdoor_profile_id, host_name, name, tls.", 9999, IsError = true)>]
        member _.Run(_: CdnFrontdoorCustomDomainState<_, _, _, _>) : azurerm.CdnFrontdoorCustomDomain.CdnFrontdoorCustomDomain =
            Unchecked.defaultof<azurerm.CdnFrontdoorCustomDomain.CdnFrontdoorCustomDomain>

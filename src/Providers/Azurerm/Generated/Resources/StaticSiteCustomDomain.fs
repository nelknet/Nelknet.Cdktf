namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type StaticSiteCustomDomainState<'DomainName, 'StaticSiteId> = { assignments: ResizeArray<azurerm.StaticSiteCustomDomain.StaticSiteCustomDomainConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/static_site_custom_domain">azurerm_static_site_custom_domain</a>.
    /// </summary>
    type StaticSiteCustomDomainBuilder(logicalId: string) =
        member _.Yield(_: unit) : StaticSiteCustomDomainState<Missing, Missing> =
            ({ assignments = ResizeArray() } : StaticSiteCustomDomainState<Missing, Missing>)

        member _.Zero(()) : StaticSiteCustomDomainState<Missing, Missing> =
            ({ assignments = ResizeArray() } : StaticSiteCustomDomainState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/static_site_custom_domain#domain_name-1">StaticSiteCustomDomain#domain_name</a>.
        /// </summary>
        [<CustomOperation "domain_name">]
        member _.DomainName(state: StaticSiteCustomDomainState<Missing, 'StaticSiteId>, value: string) : StaticSiteCustomDomainState<Present, 'StaticSiteId> =
            state.assignments.Add(fun config -> config.DomainName <- value)
            ({ assignments = state.assignments } : StaticSiteCustomDomainState<Present, 'StaticSiteId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/static_site_custom_domain#static_site_id-1">StaticSiteCustomDomain#static_site_id</a>.
        /// </summary>
        [<CustomOperation "static_site_id">]
        member _.StaticSiteId(state: StaticSiteCustomDomainState<'DomainName, Missing>, value: string) : StaticSiteCustomDomainState<'DomainName, Present> =
            state.assignments.Add(fun config -> config.StaticSiteId <- value)
            ({ assignments = state.assignments } : StaticSiteCustomDomainState<'DomainName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/static_site_custom_domain#id-1">StaticSiteCustomDomain#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: StaticSiteCustomDomainState<'DomainName, 'StaticSiteId>, value: string) : StaticSiteCustomDomainState<'DomainName, 'StaticSiteId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : StaticSiteCustomDomainState<'DomainName, 'StaticSiteId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/static_site_custom_domain#timeouts-1">StaticSiteCustomDomain#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: StaticSiteCustomDomainState<'DomainName, 'StaticSiteId>, value: azurerm.StaticSiteCustomDomain.StaticSiteCustomDomainTimeouts) : StaticSiteCustomDomainState<'DomainName, 'StaticSiteId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : StaticSiteCustomDomainState<'DomainName, 'StaticSiteId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/static_site_custom_domain#validation_type-1">StaticSiteCustomDomain#validation_type</a>.
        /// </summary>
        [<CustomOperation "validation_type">]
        member _.ValidationType(state: StaticSiteCustomDomainState<'DomainName, 'StaticSiteId>, value: string) : StaticSiteCustomDomainState<'DomainName, 'StaticSiteId> =
            state.assignments.Add(fun config -> config.ValidationType <- value)
            state : StaticSiteCustomDomainState<'DomainName, 'StaticSiteId>

        member _.Run(state: StaticSiteCustomDomainState<Present, Present>) : azurerm.StaticSiteCustomDomain.StaticSiteCustomDomain =
            let config = azurerm.StaticSiteCustomDomain.StaticSiteCustomDomainConfig()
            for setter in state.assignments do
                setter config
            azurerm.StaticSiteCustomDomain.StaticSiteCustomDomain(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.staticSiteCustomDomain: missing required arguments. Must call: domain_name, static_site_id.", 9999, IsError = true)>]
        member _.Run(_: StaticSiteCustomDomainState<_, _>) : azurerm.StaticSiteCustomDomain.StaticSiteCustomDomain =
            Unchecked.defaultof<azurerm.StaticSiteCustomDomain.StaticSiteCustomDomain>

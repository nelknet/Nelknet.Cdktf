namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CdnFrontdoorCustomDomainAssociationState<'CdnFrontdoorCustomDomainId, 'CdnFrontdoorRouteIds> = { assignments: ResizeArray<azurerm.CdnFrontdoorCustomDomainAssociation.CdnFrontdoorCustomDomainAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_custom_domain_association">azurerm_cdn_frontdoor_custom_domain_association</a>.
    /// </summary>
    type CdnFrontdoorCustomDomainAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : CdnFrontdoorCustomDomainAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CdnFrontdoorCustomDomainAssociationState<Missing, Missing>)

        member _.Zero(()) : CdnFrontdoorCustomDomainAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CdnFrontdoorCustomDomainAssociationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_custom_domain_association#cdn_frontdoor_custom_domain_id-1">CdnFrontdoorCustomDomainAssociation#cdn_frontdoor_custom_domain_id</a>.
        /// </summary>
        [<CustomOperation "cdn_frontdoor_custom_domain_id">]
        member _.CdnFrontdoorCustomDomainId(state: CdnFrontdoorCustomDomainAssociationState<Missing, 'CdnFrontdoorRouteIds>, value: string) : CdnFrontdoorCustomDomainAssociationState<Present, 'CdnFrontdoorRouteIds> =
            state.assignments.Add(fun config -> config.CdnFrontdoorCustomDomainId <- value)
            ({ assignments = state.assignments } : CdnFrontdoorCustomDomainAssociationState<Present, 'CdnFrontdoorRouteIds>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_custom_domain_association#cdn_frontdoor_route_ids-1">CdnFrontdoorCustomDomainAssociation#cdn_frontdoor_route_ids</a>.
        /// </summary>
        [<CustomOperation "cdn_frontdoor_route_ids">]
        member _.CdnFrontdoorRouteIds(state: CdnFrontdoorCustomDomainAssociationState<'CdnFrontdoorCustomDomainId, Missing>, value: seq<string>) : CdnFrontdoorCustomDomainAssociationState<'CdnFrontdoorCustomDomainId, Present> =
            state.assignments.Add(fun config -> config.CdnFrontdoorRouteIds <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : CdnFrontdoorCustomDomainAssociationState<'CdnFrontdoorCustomDomainId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_custom_domain_association#id-1">CdnFrontdoorCustomDomainAssociation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CdnFrontdoorCustomDomainAssociationState<'CdnFrontdoorCustomDomainId, 'CdnFrontdoorRouteIds>, value: string) : CdnFrontdoorCustomDomainAssociationState<'CdnFrontdoorCustomDomainId, 'CdnFrontdoorRouteIds> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CdnFrontdoorCustomDomainAssociationState<'CdnFrontdoorCustomDomainId, 'CdnFrontdoorRouteIds>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_custom_domain_association#timeouts-1">CdnFrontdoorCustomDomainAssociation#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: CdnFrontdoorCustomDomainAssociationState<'CdnFrontdoorCustomDomainId, 'CdnFrontdoorRouteIds>, value: azurerm.CdnFrontdoorCustomDomainAssociation.CdnFrontdoorCustomDomainAssociationTimeouts) : CdnFrontdoorCustomDomainAssociationState<'CdnFrontdoorCustomDomainId, 'CdnFrontdoorRouteIds> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : CdnFrontdoorCustomDomainAssociationState<'CdnFrontdoorCustomDomainId, 'CdnFrontdoorRouteIds>

        member _.Run(state: CdnFrontdoorCustomDomainAssociationState<Present, Present>) : azurerm.CdnFrontdoorCustomDomainAssociation.CdnFrontdoorCustomDomainAssociation =
            let config = azurerm.CdnFrontdoorCustomDomainAssociation.CdnFrontdoorCustomDomainAssociationConfig()
            for setter in state.assignments do
                setter config
            azurerm.CdnFrontdoorCustomDomainAssociation.CdnFrontdoorCustomDomainAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.cdnFrontdoorCustomDomainAssociation: missing required arguments. Must call: cdn_frontdoor_custom_domain_id, cdn_frontdoor_route_ids.", 9999, IsError = true)>]
        member _.Run(_: CdnFrontdoorCustomDomainAssociationState<_, _>) : azurerm.CdnFrontdoorCustomDomainAssociation.CdnFrontdoorCustomDomainAssociation =
            Unchecked.defaultof<azurerm.CdnFrontdoorCustomDomainAssociation.CdnFrontdoorCustomDomainAssociation>

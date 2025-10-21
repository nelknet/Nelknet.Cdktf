namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CdnFrontdoorRuleSetState<'CdnFrontdoorProfileId, 'Name> = { assignments: ResizeArray<azurerm.CdnFrontdoorRuleSet.CdnFrontdoorRuleSetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_rule_set">azurerm_cdn_frontdoor_rule_set</a>.
    /// </summary>
    type CdnFrontdoorRuleSetBuilder(logicalId: string) =
        member _.Yield(_: unit) : CdnFrontdoorRuleSetState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CdnFrontdoorRuleSetState<Missing, Missing>)

        member _.Zero(()) : CdnFrontdoorRuleSetState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CdnFrontdoorRuleSetState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_rule_set#cdn_frontdoor_profile_id-1">CdnFrontdoorRuleSet#cdn_frontdoor_profile_id</a>.
        /// </summary>
        [<CustomOperation "cdn_frontdoor_profile_id">]
        member _.CdnFrontdoorProfileId(state: CdnFrontdoorRuleSetState<Missing, 'Name>, value: string) : CdnFrontdoorRuleSetState<Present, 'Name> =
            state.assignments.Add(fun config -> config.CdnFrontdoorProfileId <- value)
            ({ assignments = state.assignments } : CdnFrontdoorRuleSetState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_rule_set#name-1">CdnFrontdoorRuleSet#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: CdnFrontdoorRuleSetState<'CdnFrontdoorProfileId, Missing>, value: string) : CdnFrontdoorRuleSetState<'CdnFrontdoorProfileId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : CdnFrontdoorRuleSetState<'CdnFrontdoorProfileId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_rule_set#id-1">CdnFrontdoorRuleSet#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CdnFrontdoorRuleSetState<'CdnFrontdoorProfileId, 'Name>, value: string) : CdnFrontdoorRuleSetState<'CdnFrontdoorProfileId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CdnFrontdoorRuleSetState<'CdnFrontdoorProfileId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_rule_set#timeouts-1">CdnFrontdoorRuleSet#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: CdnFrontdoorRuleSetState<'CdnFrontdoorProfileId, 'Name>, value: azurerm.CdnFrontdoorRuleSet.CdnFrontdoorRuleSetTimeouts) : CdnFrontdoorRuleSetState<'CdnFrontdoorProfileId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : CdnFrontdoorRuleSetState<'CdnFrontdoorProfileId, 'Name>

        member _.Run(state: CdnFrontdoorRuleSetState<Present, Present>) : azurerm.CdnFrontdoorRuleSet.CdnFrontdoorRuleSet =
            let config = azurerm.CdnFrontdoorRuleSet.CdnFrontdoorRuleSetConfig()
            for setter in state.assignments do
                setter config
            azurerm.CdnFrontdoorRuleSet.CdnFrontdoorRuleSet(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.cdnFrontdoorRuleSet: missing required arguments. Must call: cdn_frontdoor_profile_id, name.", 9999, IsError = true)>]
        member _.Run(_: CdnFrontdoorRuleSetState<_, _>) : azurerm.CdnFrontdoorRuleSet.CdnFrontdoorRuleSet =
            Unchecked.defaultof<azurerm.CdnFrontdoorRuleSet.CdnFrontdoorRuleSet>

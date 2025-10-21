namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CdnFrontdoorRuleState<'Actions, 'CdnFrontdoorRuleSetId, 'Name, 'Order> = { assignments: ResizeArray<azurerm.CdnFrontdoorRule.CdnFrontdoorRuleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_rule">azurerm_cdn_frontdoor_rule</a>.
    /// </summary>
    type CdnFrontdoorRuleBuilder(logicalId: string) =
        member _.Yield(_: unit) : CdnFrontdoorRuleState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CdnFrontdoorRuleState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : CdnFrontdoorRuleState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CdnFrontdoorRuleState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// actions block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_rule#actions-1">CdnFrontdoorRule#actions</a>
        /// </summary>
        [<CustomOperation "actions">]
        member _.Actions(state: CdnFrontdoorRuleState<Missing, 'CdnFrontdoorRuleSetId, 'Name, 'Order>, value: azurerm.CdnFrontdoorRule.CdnFrontdoorRuleActions) : CdnFrontdoorRuleState<Present, 'CdnFrontdoorRuleSetId, 'Name, 'Order> =
            state.assignments.Add(fun config -> config.Actions <- value)
            ({ assignments = state.assignments } : CdnFrontdoorRuleState<Present, 'CdnFrontdoorRuleSetId, 'Name, 'Order>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_rule#cdn_frontdoor_rule_set_id-1">CdnFrontdoorRule#cdn_frontdoor_rule_set_id</a>.
        /// </summary>
        [<CustomOperation "cdn_frontdoor_rule_set_id">]
        member _.CdnFrontdoorRuleSetId(state: CdnFrontdoorRuleState<'Actions, Missing, 'Name, 'Order>, value: string) : CdnFrontdoorRuleState<'Actions, Present, 'Name, 'Order> =
            state.assignments.Add(fun config -> config.CdnFrontdoorRuleSetId <- value)
            ({ assignments = state.assignments } : CdnFrontdoorRuleState<'Actions, Present, 'Name, 'Order>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_rule#name-1">CdnFrontdoorRule#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: CdnFrontdoorRuleState<'Actions, 'CdnFrontdoorRuleSetId, Missing, 'Order>, value: string) : CdnFrontdoorRuleState<'Actions, 'CdnFrontdoorRuleSetId, Present, 'Order> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : CdnFrontdoorRuleState<'Actions, 'CdnFrontdoorRuleSetId, Present, 'Order>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_rule#order-1">CdnFrontdoorRule#order</a>.
        /// </summary>
        [<CustomOperation "order">]
        member _.Order(state: CdnFrontdoorRuleState<'Actions, 'CdnFrontdoorRuleSetId, 'Name, Missing>, value: double) : CdnFrontdoorRuleState<'Actions, 'CdnFrontdoorRuleSetId, 'Name, Present> =
            state.assignments.Add(fun config -> config.Order <- value)
            ({ assignments = state.assignments } : CdnFrontdoorRuleState<'Actions, 'CdnFrontdoorRuleSetId, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_rule#behavior_on_match-1">CdnFrontdoorRule#behavior_on_match</a>.
        /// </summary>
        [<CustomOperation "behavior_on_match">]
        member _.BehaviorOnMatch(state: CdnFrontdoorRuleState<'Actions, 'CdnFrontdoorRuleSetId, 'Name, 'Order>, value: string) : CdnFrontdoorRuleState<'Actions, 'CdnFrontdoorRuleSetId, 'Name, 'Order> =
            state.assignments.Add(fun config -> config.BehaviorOnMatch <- value)
            state : CdnFrontdoorRuleState<'Actions, 'CdnFrontdoorRuleSetId, 'Name, 'Order>

        /// <summary>
        /// conditions block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_rule#conditions-1">CdnFrontdoorRule#conditions</a>
        /// </summary>
        [<CustomOperation "conditions">]
        member _.Conditions(state: CdnFrontdoorRuleState<'Actions, 'CdnFrontdoorRuleSetId, 'Name, 'Order>, value: azurerm.CdnFrontdoorRule.CdnFrontdoorRuleConditions) : CdnFrontdoorRuleState<'Actions, 'CdnFrontdoorRuleSetId, 'Name, 'Order> =
            state.assignments.Add(fun config -> config.Conditions <- value)
            state : CdnFrontdoorRuleState<'Actions, 'CdnFrontdoorRuleSetId, 'Name, 'Order>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_rule#id-1">CdnFrontdoorRule#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CdnFrontdoorRuleState<'Actions, 'CdnFrontdoorRuleSetId, 'Name, 'Order>, value: string) : CdnFrontdoorRuleState<'Actions, 'CdnFrontdoorRuleSetId, 'Name, 'Order> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CdnFrontdoorRuleState<'Actions, 'CdnFrontdoorRuleSetId, 'Name, 'Order>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_rule#timeouts-1">CdnFrontdoorRule#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: CdnFrontdoorRuleState<'Actions, 'CdnFrontdoorRuleSetId, 'Name, 'Order>, value: azurerm.CdnFrontdoorRule.CdnFrontdoorRuleTimeouts) : CdnFrontdoorRuleState<'Actions, 'CdnFrontdoorRuleSetId, 'Name, 'Order> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : CdnFrontdoorRuleState<'Actions, 'CdnFrontdoorRuleSetId, 'Name, 'Order>

        member _.Run(state: CdnFrontdoorRuleState<Present, Present, Present, Present>) : azurerm.CdnFrontdoorRule.CdnFrontdoorRule =
            let config = azurerm.CdnFrontdoorRule.CdnFrontdoorRuleConfig()
            for setter in state.assignments do
                setter config
            azurerm.CdnFrontdoorRule.CdnFrontdoorRule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.cdnFrontdoorRule: missing required arguments. Must call: actions, cdn_frontdoor_rule_set_id, name, order.", 9999, IsError = true)>]
        member _.Run(_: CdnFrontdoorRuleState<_, _, _, _>) : azurerm.CdnFrontdoorRule.CdnFrontdoorRule =
            Unchecked.defaultof<azurerm.CdnFrontdoorRule.CdnFrontdoorRule>

namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermLbOutboundRuleState<'LoadbalancerId, 'Name> = { assignments: ResizeArray<azurerm.DataAzurermLbOutboundRule.DataAzurermLbOutboundRuleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/lb_outbound_rule">azurerm_lb_outbound_rule</a>.
    /// </summary>
    type DataAzurermLbOutboundRuleBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermLbOutboundRuleState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermLbOutboundRuleState<Missing, Missing>)

        member _.Zero(()) : DataAzurermLbOutboundRuleState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermLbOutboundRuleState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/lb_outbound_rule#loadbalancer_id-1">DataAzurermLbOutboundRule#loadbalancer_id</a>.
        /// </summary>
        [<CustomOperation "loadbalancer_id">]
        member _.LoadbalancerId(state: DataAzurermLbOutboundRuleState<Missing, 'Name>, value: string) : DataAzurermLbOutboundRuleState<Present, 'Name> =
            state.assignments.Add(fun config -> config.LoadbalancerId <- value)
            ({ assignments = state.assignments } : DataAzurermLbOutboundRuleState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/lb_outbound_rule#name-1">DataAzurermLbOutboundRule#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermLbOutboundRuleState<'LoadbalancerId, Missing>, value: string) : DataAzurermLbOutboundRuleState<'LoadbalancerId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermLbOutboundRuleState<'LoadbalancerId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/lb_outbound_rule#id-1">DataAzurermLbOutboundRule#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermLbOutboundRuleState<'LoadbalancerId, 'Name>, value: string) : DataAzurermLbOutboundRuleState<'LoadbalancerId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermLbOutboundRuleState<'LoadbalancerId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/lb_outbound_rule#timeouts-1">DataAzurermLbOutboundRule#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermLbOutboundRuleState<'LoadbalancerId, 'Name>, value: azurerm.DataAzurermLbOutboundRule.DataAzurermLbOutboundRuleTimeouts) : DataAzurermLbOutboundRuleState<'LoadbalancerId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermLbOutboundRuleState<'LoadbalancerId, 'Name>

        member _.Run(state: DataAzurermLbOutboundRuleState<Present, Present>) : azurerm.DataAzurermLbOutboundRule.DataAzurermLbOutboundRule =
            let config = azurerm.DataAzurermLbOutboundRule.DataAzurermLbOutboundRuleConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermLbOutboundRule.DataAzurermLbOutboundRule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermLbOutboundRule: missing required arguments. Must call: loadbalancer_id, name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermLbOutboundRuleState<_, _>) : azurerm.DataAzurermLbOutboundRule.DataAzurermLbOutboundRule =
            Unchecked.defaultof<azurerm.DataAzurermLbOutboundRule.DataAzurermLbOutboundRule>

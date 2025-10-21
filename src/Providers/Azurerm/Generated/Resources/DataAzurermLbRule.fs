namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermLbRuleState<'LoadbalancerId, 'Name> = { assignments: ResizeArray<azurerm.DataAzurermLbRule.DataAzurermLbRuleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/lb_rule">azurerm_lb_rule</a>.
    /// </summary>
    type DataAzurermLbRuleBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermLbRuleState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermLbRuleState<Missing, Missing>)

        member _.Zero(()) : DataAzurermLbRuleState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermLbRuleState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/lb_rule#loadbalancer_id-1">DataAzurermLbRule#loadbalancer_id</a>.
        /// </summary>
        [<CustomOperation "loadbalancer_id">]
        member _.LoadbalancerId(state: DataAzurermLbRuleState<Missing, 'Name>, value: string) : DataAzurermLbRuleState<Present, 'Name> =
            state.assignments.Add(fun config -> config.LoadbalancerId <- value)
            ({ assignments = state.assignments } : DataAzurermLbRuleState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/lb_rule#name-1">DataAzurermLbRule#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermLbRuleState<'LoadbalancerId, Missing>, value: string) : DataAzurermLbRuleState<'LoadbalancerId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermLbRuleState<'LoadbalancerId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/lb_rule#id-1">DataAzurermLbRule#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermLbRuleState<'LoadbalancerId, 'Name>, value: string) : DataAzurermLbRuleState<'LoadbalancerId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermLbRuleState<'LoadbalancerId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/lb_rule#timeouts-1">DataAzurermLbRule#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermLbRuleState<'LoadbalancerId, 'Name>, value: azurerm.DataAzurermLbRule.DataAzurermLbRuleTimeouts) : DataAzurermLbRuleState<'LoadbalancerId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermLbRuleState<'LoadbalancerId, 'Name>

        member _.Run(state: DataAzurermLbRuleState<Present, Present>) : azurerm.DataAzurermLbRule.DataAzurermLbRule =
            let config = azurerm.DataAzurermLbRule.DataAzurermLbRuleConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermLbRule.DataAzurermLbRule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermLbRule: missing required arguments. Must call: loadbalancer_id, name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermLbRuleState<_, _>) : azurerm.DataAzurermLbRule.DataAzurermLbRule =
            Unchecked.defaultof<azurerm.DataAzurermLbRule.DataAzurermLbRule>

namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ServicebusSubscriptionRuleState<'FilterType, 'Name, 'SubscriptionId> = { assignments: ResizeArray<azurerm.ServicebusSubscriptionRule.ServicebusSubscriptionRuleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_subscription_rule">azurerm_servicebus_subscription_rule</a>.
    /// </summary>
    type ServicebusSubscriptionRuleBuilder(logicalId: string) =
        member _.Yield(_: unit) : ServicebusSubscriptionRuleState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ServicebusSubscriptionRuleState<Missing, Missing, Missing>)

        member _.Zero(()) : ServicebusSubscriptionRuleState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ServicebusSubscriptionRuleState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_subscription_rule#filter_type-1">ServicebusSubscriptionRule#filter_type</a>.
        /// </summary>
        [<CustomOperation "filter_type">]
        member _.FilterType(state: ServicebusSubscriptionRuleState<Missing, 'Name, 'SubscriptionId>, value: string) : ServicebusSubscriptionRuleState<Present, 'Name, 'SubscriptionId> =
            state.assignments.Add(fun config -> config.FilterType <- value)
            ({ assignments = state.assignments } : ServicebusSubscriptionRuleState<Present, 'Name, 'SubscriptionId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_subscription_rule#name-1">ServicebusSubscriptionRule#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ServicebusSubscriptionRuleState<'FilterType, Missing, 'SubscriptionId>, value: string) : ServicebusSubscriptionRuleState<'FilterType, Present, 'SubscriptionId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ServicebusSubscriptionRuleState<'FilterType, Present, 'SubscriptionId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_subscription_rule#subscription_id-1">ServicebusSubscriptionRule#subscription_id</a>.
        /// </summary>
        [<CustomOperation "subscription_id">]
        member _.SubscriptionId(state: ServicebusSubscriptionRuleState<'FilterType, 'Name, Missing>, value: string) : ServicebusSubscriptionRuleState<'FilterType, 'Name, Present> =
            state.assignments.Add(fun config -> config.SubscriptionId <- value)
            ({ assignments = state.assignments } : ServicebusSubscriptionRuleState<'FilterType, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_subscription_rule#action-1">ServicebusSubscriptionRule#action</a>.
        /// </summary>
        [<CustomOperation "action">]
        member _.Action(state: ServicebusSubscriptionRuleState<'FilterType, 'Name, 'SubscriptionId>, value: string) : ServicebusSubscriptionRuleState<'FilterType, 'Name, 'SubscriptionId> =
            state.assignments.Add(fun config -> config.Action <- value)
            state : ServicebusSubscriptionRuleState<'FilterType, 'Name, 'SubscriptionId>

        /// <summary>
        /// correlation_filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_subscription_rule#correlation_filter-1">ServicebusSubscriptionRule#correlation_filter</a>
        /// </summary>
        [<CustomOperation "correlation_filter">]
        member _.CorrelationFilter(state: ServicebusSubscriptionRuleState<'FilterType, 'Name, 'SubscriptionId>, value: azurerm.ServicebusSubscriptionRule.ServicebusSubscriptionRuleCorrelationFilter) : ServicebusSubscriptionRuleState<'FilterType, 'Name, 'SubscriptionId> =
            state.assignments.Add(fun config -> config.CorrelationFilter <- value)
            state : ServicebusSubscriptionRuleState<'FilterType, 'Name, 'SubscriptionId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_subscription_rule#id-1">ServicebusSubscriptionRule#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ServicebusSubscriptionRuleState<'FilterType, 'Name, 'SubscriptionId>, value: string) : ServicebusSubscriptionRuleState<'FilterType, 'Name, 'SubscriptionId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ServicebusSubscriptionRuleState<'FilterType, 'Name, 'SubscriptionId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_subscription_rule#sql_filter-1">ServicebusSubscriptionRule#sql_filter</a>.
        /// </summary>
        [<CustomOperation "sql_filter">]
        member _.SqlFilter(state: ServicebusSubscriptionRuleState<'FilterType, 'Name, 'SubscriptionId>, value: string) : ServicebusSubscriptionRuleState<'FilterType, 'Name, 'SubscriptionId> =
            state.assignments.Add(fun config -> config.SqlFilter <- value)
            state : ServicebusSubscriptionRuleState<'FilterType, 'Name, 'SubscriptionId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_subscription_rule#timeouts-1">ServicebusSubscriptionRule#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ServicebusSubscriptionRuleState<'FilterType, 'Name, 'SubscriptionId>, value: azurerm.ServicebusSubscriptionRule.ServicebusSubscriptionRuleTimeouts) : ServicebusSubscriptionRuleState<'FilterType, 'Name, 'SubscriptionId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ServicebusSubscriptionRuleState<'FilterType, 'Name, 'SubscriptionId>

        member _.Run(state: ServicebusSubscriptionRuleState<Present, Present, Present>) : azurerm.ServicebusSubscriptionRule.ServicebusSubscriptionRule =
            let config = azurerm.ServicebusSubscriptionRule.ServicebusSubscriptionRuleConfig()
            for setter in state.assignments do
                setter config
            azurerm.ServicebusSubscriptionRule.ServicebusSubscriptionRule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.servicebusSubscriptionRule: missing required arguments. Must call: filter_type, name, subscription_id.", 9999, IsError = true)>]
        member _.Run(_: ServicebusSubscriptionRuleState<_, _, _>) : azurerm.ServicebusSubscriptionRule.ServicebusSubscriptionRule =
            Unchecked.defaultof<azurerm.ServicebusSubscriptionRule.ServicebusSubscriptionRule>

namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ConsumptionBudgetSubscriptionState<'Amount, 'Name, 'Notification, 'SubscriptionId, 'TimePeriod> = { assignments: ResizeArray<azurerm.ConsumptionBudgetSubscription.ConsumptionBudgetSubscriptionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/consumption_budget_subscription">azurerm_consumption_budget_subscription</a>.
    /// </summary>
    type ConsumptionBudgetSubscriptionBuilder(logicalId: string) =
        member _.Yield(_: unit) : ConsumptionBudgetSubscriptionState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ConsumptionBudgetSubscriptionState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ConsumptionBudgetSubscriptionState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ConsumptionBudgetSubscriptionState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/consumption_budget_subscription#amount-1">ConsumptionBudgetSubscription#amount</a>.
        /// </summary>
        [<CustomOperation "amount">]
        member _.Amount(state: ConsumptionBudgetSubscriptionState<Missing, 'Name, 'Notification, 'SubscriptionId, 'TimePeriod>, value: double) : ConsumptionBudgetSubscriptionState<Present, 'Name, 'Notification, 'SubscriptionId, 'TimePeriod> =
            state.assignments.Add(fun config -> config.Amount <- value)
            ({ assignments = state.assignments } : ConsumptionBudgetSubscriptionState<Present, 'Name, 'Notification, 'SubscriptionId, 'TimePeriod>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/consumption_budget_subscription#name-1">ConsumptionBudgetSubscription#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ConsumptionBudgetSubscriptionState<'Amount, Missing, 'Notification, 'SubscriptionId, 'TimePeriod>, value: string) : ConsumptionBudgetSubscriptionState<'Amount, Present, 'Notification, 'SubscriptionId, 'TimePeriod> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ConsumptionBudgetSubscriptionState<'Amount, Present, 'Notification, 'SubscriptionId, 'TimePeriod>)

        /// <summary>
        /// notification block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/consumption_budget_subscription#notification-1">ConsumptionBudgetSubscription#notification</a> Accepts: azurerm.IResolvable | azurerm.ConsumptionBudgetSubscription.ConsumptionBudgetSubscriptionNotification[]
        /// </summary>
        [<CustomOperation "notification">]
        member _.Notification(state: ConsumptionBudgetSubscriptionState<'Amount, 'Name, Missing, 'SubscriptionId, 'TimePeriod>, value: HashiCorp.Cdktf.IResolvable) : ConsumptionBudgetSubscriptionState<'Amount, 'Name, Present, 'SubscriptionId, 'TimePeriod> =
            state.assignments.Add(fun config -> config.Notification <- value)
            ({ assignments = state.assignments } : ConsumptionBudgetSubscriptionState<'Amount, 'Name, Present, 'SubscriptionId, 'TimePeriod>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/consumption_budget_subscription#subscription_id-1">ConsumptionBudgetSubscription#subscription_id</a>.
        /// </summary>
        [<CustomOperation "subscription_id">]
        member _.SubscriptionId(state: ConsumptionBudgetSubscriptionState<'Amount, 'Name, 'Notification, Missing, 'TimePeriod>, value: string) : ConsumptionBudgetSubscriptionState<'Amount, 'Name, 'Notification, Present, 'TimePeriod> =
            state.assignments.Add(fun config -> config.SubscriptionId <- value)
            ({ assignments = state.assignments } : ConsumptionBudgetSubscriptionState<'Amount, 'Name, 'Notification, Present, 'TimePeriod>)

        /// <summary>
        /// time_period block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/consumption_budget_subscription#time_period-1">ConsumptionBudgetSubscription#time_period</a>
        /// </summary>
        [<CustomOperation "time_period">]
        member _.TimePeriod(state: ConsumptionBudgetSubscriptionState<'Amount, 'Name, 'Notification, 'SubscriptionId, Missing>, value: azurerm.ConsumptionBudgetSubscription.ConsumptionBudgetSubscriptionTimePeriod) : ConsumptionBudgetSubscriptionState<'Amount, 'Name, 'Notification, 'SubscriptionId, Present> =
            state.assignments.Add(fun config -> config.TimePeriod <- value)
            ({ assignments = state.assignments } : ConsumptionBudgetSubscriptionState<'Amount, 'Name, 'Notification, 'SubscriptionId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/consumption_budget_subscription#etag-1">ConsumptionBudgetSubscription#etag</a>.
        /// </summary>
        [<CustomOperation "etag">]
        member _.Etag(state: ConsumptionBudgetSubscriptionState<'Amount, 'Name, 'Notification, 'SubscriptionId, 'TimePeriod>, value: string) : ConsumptionBudgetSubscriptionState<'Amount, 'Name, 'Notification, 'SubscriptionId, 'TimePeriod> =
            state.assignments.Add(fun config -> config.Etag <- value)
            state : ConsumptionBudgetSubscriptionState<'Amount, 'Name, 'Notification, 'SubscriptionId, 'TimePeriod>

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/consumption_budget_subscription#filter-1">ConsumptionBudgetSubscription#filter</a>
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: ConsumptionBudgetSubscriptionState<'Amount, 'Name, 'Notification, 'SubscriptionId, 'TimePeriod>, value: azurerm.ConsumptionBudgetSubscription.ConsumptionBudgetSubscriptionFilter) : ConsumptionBudgetSubscriptionState<'Amount, 'Name, 'Notification, 'SubscriptionId, 'TimePeriod> =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : ConsumptionBudgetSubscriptionState<'Amount, 'Name, 'Notification, 'SubscriptionId, 'TimePeriod>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/consumption_budget_subscription#id-1">ConsumptionBudgetSubscription#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ConsumptionBudgetSubscriptionState<'Amount, 'Name, 'Notification, 'SubscriptionId, 'TimePeriod>, value: string) : ConsumptionBudgetSubscriptionState<'Amount, 'Name, 'Notification, 'SubscriptionId, 'TimePeriod> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ConsumptionBudgetSubscriptionState<'Amount, 'Name, 'Notification, 'SubscriptionId, 'TimePeriod>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/consumption_budget_subscription#time_grain-1">ConsumptionBudgetSubscription#time_grain</a>.
        /// </summary>
        [<CustomOperation "time_grain">]
        member _.TimeGrain(state: ConsumptionBudgetSubscriptionState<'Amount, 'Name, 'Notification, 'SubscriptionId, 'TimePeriod>, value: string) : ConsumptionBudgetSubscriptionState<'Amount, 'Name, 'Notification, 'SubscriptionId, 'TimePeriod> =
            state.assignments.Add(fun config -> config.TimeGrain <- value)
            state : ConsumptionBudgetSubscriptionState<'Amount, 'Name, 'Notification, 'SubscriptionId, 'TimePeriod>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/consumption_budget_subscription#timeouts-1">ConsumptionBudgetSubscription#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ConsumptionBudgetSubscriptionState<'Amount, 'Name, 'Notification, 'SubscriptionId, 'TimePeriod>, value: azurerm.ConsumptionBudgetSubscription.ConsumptionBudgetSubscriptionTimeouts) : ConsumptionBudgetSubscriptionState<'Amount, 'Name, 'Notification, 'SubscriptionId, 'TimePeriod> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ConsumptionBudgetSubscriptionState<'Amount, 'Name, 'Notification, 'SubscriptionId, 'TimePeriod>

        member _.Run(state: ConsumptionBudgetSubscriptionState<Present, Present, Present, Present, Present>) : azurerm.ConsumptionBudgetSubscription.ConsumptionBudgetSubscription =
            let config = azurerm.ConsumptionBudgetSubscription.ConsumptionBudgetSubscriptionConfig()
            for setter in state.assignments do
                setter config
            azurerm.ConsumptionBudgetSubscription.ConsumptionBudgetSubscription(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.consumptionBudgetSubscription: missing required arguments. Must call: amount, name, notification, subscription_id, time_period.", 9999, IsError = true)>]
        member _.Run(_: ConsumptionBudgetSubscriptionState<_, _, _, _, _>) : azurerm.ConsumptionBudgetSubscription.ConsumptionBudgetSubscription =
            Unchecked.defaultof<azurerm.ConsumptionBudgetSubscription.ConsumptionBudgetSubscription>

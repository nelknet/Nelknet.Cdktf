namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermConsumptionBudgetSubscriptionState<'Name, 'SubscriptionId> = { assignments: ResizeArray<azurerm.DataAzurermConsumptionBudgetSubscription.DataAzurermConsumptionBudgetSubscriptionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/consumption_budget_subscription">azurerm_consumption_budget_subscription</a>.
    /// </summary>
    type DataAzurermConsumptionBudgetSubscriptionBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermConsumptionBudgetSubscriptionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermConsumptionBudgetSubscriptionState<Missing, Missing>)

        member _.Zero(()) : DataAzurermConsumptionBudgetSubscriptionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermConsumptionBudgetSubscriptionState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/consumption_budget_subscription#name-1">DataAzurermConsumptionBudgetSubscription#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermConsumptionBudgetSubscriptionState<Missing, 'SubscriptionId>, value: string) : DataAzurermConsumptionBudgetSubscriptionState<Present, 'SubscriptionId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermConsumptionBudgetSubscriptionState<Present, 'SubscriptionId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/consumption_budget_subscription#subscription_id-1">DataAzurermConsumptionBudgetSubscription#subscription_id</a>.
        /// </summary>
        [<CustomOperation "subscription_id">]
        member _.SubscriptionId(state: DataAzurermConsumptionBudgetSubscriptionState<'Name, Missing>, value: string) : DataAzurermConsumptionBudgetSubscriptionState<'Name, Present> =
            state.assignments.Add(fun config -> config.SubscriptionId <- value)
            ({ assignments = state.assignments } : DataAzurermConsumptionBudgetSubscriptionState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/consumption_budget_subscription#id-1">DataAzurermConsumptionBudgetSubscription#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermConsumptionBudgetSubscriptionState<'Name, 'SubscriptionId>, value: string) : DataAzurermConsumptionBudgetSubscriptionState<'Name, 'SubscriptionId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermConsumptionBudgetSubscriptionState<'Name, 'SubscriptionId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/consumption_budget_subscription#timeouts-1">DataAzurermConsumptionBudgetSubscription#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermConsumptionBudgetSubscriptionState<'Name, 'SubscriptionId>, value: azurerm.DataAzurermConsumptionBudgetSubscription.DataAzurermConsumptionBudgetSubscriptionTimeouts) : DataAzurermConsumptionBudgetSubscriptionState<'Name, 'SubscriptionId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermConsumptionBudgetSubscriptionState<'Name, 'SubscriptionId>

        member _.Run(state: DataAzurermConsumptionBudgetSubscriptionState<Present, Present>) : azurerm.DataAzurermConsumptionBudgetSubscription.DataAzurermConsumptionBudgetSubscription =
            let config = azurerm.DataAzurermConsumptionBudgetSubscription.DataAzurermConsumptionBudgetSubscriptionConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermConsumptionBudgetSubscription.DataAzurermConsumptionBudgetSubscription(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermConsumptionBudgetSubscription: missing required arguments. Must call: name, subscription_id.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermConsumptionBudgetSubscriptionState<_, _>) : azurerm.DataAzurermConsumptionBudgetSubscription.DataAzurermConsumptionBudgetSubscription =
            Unchecked.defaultof<azurerm.DataAzurermConsumptionBudgetSubscription.DataAzurermConsumptionBudgetSubscription>

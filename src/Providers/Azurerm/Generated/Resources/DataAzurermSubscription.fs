namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermSubscriptionState = { assignments: ResizeArray<azurerm.DataAzurermSubscription.DataAzurermSubscriptionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/subscription">azurerm_subscription</a>.
    /// </summary>
    type DataAzurermSubscriptionBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermSubscriptionState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAzurermSubscriptionState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/subscription#id-1">DataAzurermSubscription#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermSubscriptionState, value: string) : DataAzurermSubscriptionState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermSubscriptionState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/subscription#subscription_id-1">DataAzurermSubscription#subscription_id</a>.
        /// </summary>
        [<CustomOperation "subscription_id">]
        member _.SubscriptionId(state: DataAzurermSubscriptionState, value: string) : DataAzurermSubscriptionState =
            state.assignments.Add(fun config -> config.SubscriptionId <- value)
            state : DataAzurermSubscriptionState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/subscription#timeouts-1">DataAzurermSubscription#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermSubscriptionState, value: azurerm.DataAzurermSubscription.DataAzurermSubscriptionTimeouts) : DataAzurermSubscriptionState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermSubscriptionState

        member _.Run(state: DataAzurermSubscriptionState) : azurerm.DataAzurermSubscription.DataAzurermSubscription =
            let config = azurerm.DataAzurermSubscription.DataAzurermSubscriptionConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermSubscription.DataAzurermSubscription(StackContext.get (), logicalId, config)

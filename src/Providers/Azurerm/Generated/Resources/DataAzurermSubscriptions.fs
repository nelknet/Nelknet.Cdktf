namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermSubscriptionsState = { assignments: ResizeArray<azurerm.DataAzurermSubscriptions.DataAzurermSubscriptionsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/subscriptions">azurerm_subscriptions</a>.
    /// </summary>
    type DataAzurermSubscriptionsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermSubscriptionsState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAzurermSubscriptionsState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/subscriptions#display_name_contains-1">DataAzurermSubscriptions#display_name_contains</a>.
        /// </summary>
        [<CustomOperation "display_name_contains">]
        member _.DisplayNameContains(state: DataAzurermSubscriptionsState, value: string) : DataAzurermSubscriptionsState =
            state.assignments.Add(fun config -> config.DisplayNameContains <- value)
            state : DataAzurermSubscriptionsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/subscriptions#display_name_prefix-1">DataAzurermSubscriptions#display_name_prefix</a>.
        /// </summary>
        [<CustomOperation "display_name_prefix">]
        member _.DisplayNamePrefix(state: DataAzurermSubscriptionsState, value: string) : DataAzurermSubscriptionsState =
            state.assignments.Add(fun config -> config.DisplayNamePrefix <- value)
            state : DataAzurermSubscriptionsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/subscriptions#id-1">DataAzurermSubscriptions#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermSubscriptionsState, value: string) : DataAzurermSubscriptionsState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermSubscriptionsState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/subscriptions#timeouts-1">DataAzurermSubscriptions#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermSubscriptionsState, value: azurerm.DataAzurermSubscriptions.DataAzurermSubscriptionsTimeouts) : DataAzurermSubscriptionsState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermSubscriptionsState

        member _.Run(state: DataAzurermSubscriptionsState) : azurerm.DataAzurermSubscriptions.DataAzurermSubscriptions =
            let config = azurerm.DataAzurermSubscriptions.DataAzurermSubscriptionsConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermSubscriptions.DataAzurermSubscriptions(StackContext.get (), logicalId, config)

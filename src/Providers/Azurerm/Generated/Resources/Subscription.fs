namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SubscriptionState<'SubscriptionName> = { assignments: ResizeArray<azurerm.Subscription.SubscriptionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription">azurerm_subscription</a>.
    /// </summary>
    type SubscriptionBuilder(logicalId: string) =
        member _.Yield(_: unit) : SubscriptionState<Missing> =
            ({ assignments = ResizeArray() } : SubscriptionState<Missing>)

        member _.Zero(()) : SubscriptionState<Missing> =
            ({ assignments = ResizeArray() } : SubscriptionState<Missing>)

        /// <summary>
        /// The Display Name for the Subscription. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription#subscription_name-1">Subscription#subscription_name</a>
        /// </summary>
        [<CustomOperation "subscription_name">]
        member _.SubscriptionName(state: SubscriptionState<Missing>, value: string) : SubscriptionState<Present> =
            state.assignments.Add(fun config -> config.SubscriptionName <- value)
            ({ assignments = state.assignments } : SubscriptionState<Present>)

        /// <summary>
        /// The Alias Name of the subscription. If omitted a new UUID will be generated for this property. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription#alias-1">Subscription#alias</a>
        /// </summary>
        [<CustomOperation "alias">]
        member _.Alias(state: SubscriptionState<'SubscriptionName>, value: string) : SubscriptionState<'SubscriptionName> =
            state.assignments.Add(fun config -> config.Alias <- value)
            state : SubscriptionState<'SubscriptionName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription#billing_scope_id-1">Subscription#billing_scope_id</a>.
        /// </summary>
        [<CustomOperation "billing_scope_id">]
        member _.BillingScopeId(state: SubscriptionState<'SubscriptionName>, value: string) : SubscriptionState<'SubscriptionName> =
            state.assignments.Add(fun config -> config.BillingScopeId <- value)
            state : SubscriptionState<'SubscriptionName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription#id-1">Subscription#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SubscriptionState<'SubscriptionName>, value: string) : SubscriptionState<'SubscriptionName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SubscriptionState<'SubscriptionName>

        /// <summary>
        /// The GUID of the Subscription. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription#subscription_id-1">Subscription#subscription_id</a>
        /// </summary>
        [<CustomOperation "subscription_id">]
        member _.SubscriptionId(state: SubscriptionState<'SubscriptionName>, value: string) : SubscriptionState<'SubscriptionName> =
            state.assignments.Add(fun config -> config.SubscriptionId <- value)
            state : SubscriptionState<'SubscriptionName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription#tags-1">Subscription#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: SubscriptionState<'SubscriptionName>, value: seq<string * string>) : SubscriptionState<'SubscriptionName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : SubscriptionState<'SubscriptionName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription#timeouts-1">Subscription#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SubscriptionState<'SubscriptionName>, value: azurerm.Subscription.SubscriptionTimeouts) : SubscriptionState<'SubscriptionName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SubscriptionState<'SubscriptionName>

        /// <summary>
        /// The workload type for the Subscription. Possible values are `Production` (default) and `DevTest`. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription#workload-1">Subscription#workload</a>
        /// </summary>
        [<CustomOperation "workload">]
        member _.Workload(state: SubscriptionState<'SubscriptionName>, value: string) : SubscriptionState<'SubscriptionName> =
            state.assignments.Add(fun config -> config.Workload <- value)
            state : SubscriptionState<'SubscriptionName>

        member _.Run(state: SubscriptionState<Present>) : azurerm.Subscription.Subscription =
            let config = azurerm.Subscription.SubscriptionConfig()
            for setter in state.assignments do
                setter config
            azurerm.Subscription.Subscription(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.subscription: missing required arguments. Must call: subscription_name.", 9999, IsError = true)>]
        member _.Run(_: SubscriptionState<_>) : azurerm.Subscription.Subscription =
            Unchecked.defaultof<azurerm.Subscription.Subscription>

namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermServicebusSubscriptionState<'Name> = { assignments: ResizeArray<azurerm.DataAzurermServicebusSubscription.DataAzurermServicebusSubscriptionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/servicebus_subscription">azurerm_servicebus_subscription</a>.
    /// </summary>
    type DataAzurermServicebusSubscriptionBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermServicebusSubscriptionState<Missing> =
            ({ assignments = ResizeArray() } : DataAzurermServicebusSubscriptionState<Missing>)

        member _.Zero(()) : DataAzurermServicebusSubscriptionState<Missing> =
            ({ assignments = ResizeArray() } : DataAzurermServicebusSubscriptionState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/servicebus_subscription#name-1">DataAzurermServicebusSubscription#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermServicebusSubscriptionState<Missing>, value: string) : DataAzurermServicebusSubscriptionState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermServicebusSubscriptionState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/servicebus_subscription#id-1">DataAzurermServicebusSubscription#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermServicebusSubscriptionState<'Name>, value: string) : DataAzurermServicebusSubscriptionState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermServicebusSubscriptionState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/servicebus_subscription#namespace_name-1">DataAzurermServicebusSubscription#namespace_name</a>.
        /// </summary>
        [<CustomOperation "namespace_name">]
        member _.NamespaceName(state: DataAzurermServicebusSubscriptionState<'Name>, value: string) : DataAzurermServicebusSubscriptionState<'Name> =
            state.assignments.Add(fun config -> config.NamespaceName <- value)
            state : DataAzurermServicebusSubscriptionState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/servicebus_subscription#resource_group_name-1">DataAzurermServicebusSubscription#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermServicebusSubscriptionState<'Name>, value: string) : DataAzurermServicebusSubscriptionState<'Name> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            state : DataAzurermServicebusSubscriptionState<'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/servicebus_subscription#timeouts-1">DataAzurermServicebusSubscription#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermServicebusSubscriptionState<'Name>, value: azurerm.DataAzurermServicebusSubscription.DataAzurermServicebusSubscriptionTimeouts) : DataAzurermServicebusSubscriptionState<'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermServicebusSubscriptionState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/servicebus_subscription#topic_id-1">DataAzurermServicebusSubscription#topic_id</a>.
        /// </summary>
        [<CustomOperation "topic_id">]
        member _.TopicId(state: DataAzurermServicebusSubscriptionState<'Name>, value: string) : DataAzurermServicebusSubscriptionState<'Name> =
            state.assignments.Add(fun config -> config.TopicId <- value)
            state : DataAzurermServicebusSubscriptionState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/servicebus_subscription#topic_name-1">DataAzurermServicebusSubscription#topic_name</a>.
        /// </summary>
        [<CustomOperation "topic_name">]
        member _.TopicName(state: DataAzurermServicebusSubscriptionState<'Name>, value: string) : DataAzurermServicebusSubscriptionState<'Name> =
            state.assignments.Add(fun config -> config.TopicName <- value)
            state : DataAzurermServicebusSubscriptionState<'Name>

        member _.Run(state: DataAzurermServicebusSubscriptionState<Present>) : azurerm.DataAzurermServicebusSubscription.DataAzurermServicebusSubscription =
            let config = azurerm.DataAzurermServicebusSubscription.DataAzurermServicebusSubscriptionConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermServicebusSubscription.DataAzurermServicebusSubscription(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermServicebusSubscription: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermServicebusSubscriptionState<_>) : azurerm.DataAzurermServicebusSubscription.DataAzurermServicebusSubscription =
            Unchecked.defaultof<azurerm.DataAzurermServicebusSubscription.DataAzurermServicebusSubscription>

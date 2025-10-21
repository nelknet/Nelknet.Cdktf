namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ApiManagementSubscriptionState<'ApiManagementName, 'DisplayName, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.ApiManagementSubscription.ApiManagementSubscriptionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_subscription">azurerm_api_management_subscription</a>.
    /// </summary>
    type ApiManagementSubscriptionBuilder(logicalId: string) =
        member _.Yield(_: unit) : ApiManagementSubscriptionState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiManagementSubscriptionState<Missing, Missing, Missing>)

        member _.Zero(()) : ApiManagementSubscriptionState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiManagementSubscriptionState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_subscription#api_management_name-1">ApiManagementSubscription#api_management_name</a>.
        /// </summary>
        [<CustomOperation "api_management_name">]
        member _.ApiManagementName(state: ApiManagementSubscriptionState<Missing, 'DisplayName, 'ResourceGroupName>, value: string) : ApiManagementSubscriptionState<Present, 'DisplayName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ApiManagementName <- value)
            ({ assignments = state.assignments } : ApiManagementSubscriptionState<Present, 'DisplayName, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_subscription#display_name-1">ApiManagementSubscription#display_name</a>.
        /// </summary>
        [<CustomOperation "display_name">]
        member _.DisplayName(state: ApiManagementSubscriptionState<'ApiManagementName, Missing, 'ResourceGroupName>, value: string) : ApiManagementSubscriptionState<'ApiManagementName, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DisplayName <- value)
            ({ assignments = state.assignments } : ApiManagementSubscriptionState<'ApiManagementName, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_subscription#resource_group_name-1">ApiManagementSubscription#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: ApiManagementSubscriptionState<'ApiManagementName, 'DisplayName, Missing>, value: string) : ApiManagementSubscriptionState<'ApiManagementName, 'DisplayName, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : ApiManagementSubscriptionState<'ApiManagementName, 'DisplayName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_subscription#allow_tracing-1">ApiManagementSubscription#allow_tracing</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "allow_tracing">]
        member _.AllowTracing(state: ApiManagementSubscriptionState<'ApiManagementName, 'DisplayName, 'ResourceGroupName>, value: bool) : ApiManagementSubscriptionState<'ApiManagementName, 'DisplayName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AllowTracing <- value)
            state : ApiManagementSubscriptionState<'ApiManagementName, 'DisplayName, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_subscription#allow_tracing-1">ApiManagementSubscription#allow_tracing</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "allow_tracing">]
        member _.AllowTracing(state: ApiManagementSubscriptionState<'ApiManagementName, 'DisplayName, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : ApiManagementSubscriptionState<'ApiManagementName, 'DisplayName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AllowTracing <- value)
            state : ApiManagementSubscriptionState<'ApiManagementName, 'DisplayName, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_subscription#api_id-1">ApiManagementSubscription#api_id</a>.
        /// </summary>
        [<CustomOperation "api_id">]
        member _.ApiId(state: ApiManagementSubscriptionState<'ApiManagementName, 'DisplayName, 'ResourceGroupName>, value: string) : ApiManagementSubscriptionState<'ApiManagementName, 'DisplayName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ApiId <- value)
            state : ApiManagementSubscriptionState<'ApiManagementName, 'DisplayName, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_subscription#id-1">ApiManagementSubscription#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ApiManagementSubscriptionState<'ApiManagementName, 'DisplayName, 'ResourceGroupName>, value: string) : ApiManagementSubscriptionState<'ApiManagementName, 'DisplayName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ApiManagementSubscriptionState<'ApiManagementName, 'DisplayName, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_subscription#primary_key-1">ApiManagementSubscription#primary_key</a>.
        /// </summary>
        [<CustomOperation "primary_key">]
        member _.PrimaryKey(state: ApiManagementSubscriptionState<'ApiManagementName, 'DisplayName, 'ResourceGroupName>, value: string) : ApiManagementSubscriptionState<'ApiManagementName, 'DisplayName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.PrimaryKey <- value)
            state : ApiManagementSubscriptionState<'ApiManagementName, 'DisplayName, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_subscription#product_id-1">ApiManagementSubscription#product_id</a>.
        /// </summary>
        [<CustomOperation "product_id">]
        member _.ProductId(state: ApiManagementSubscriptionState<'ApiManagementName, 'DisplayName, 'ResourceGroupName>, value: string) : ApiManagementSubscriptionState<'ApiManagementName, 'DisplayName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ProductId <- value)
            state : ApiManagementSubscriptionState<'ApiManagementName, 'DisplayName, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_subscription#secondary_key-1">ApiManagementSubscription#secondary_key</a>.
        /// </summary>
        [<CustomOperation "secondary_key">]
        member _.SecondaryKey(state: ApiManagementSubscriptionState<'ApiManagementName, 'DisplayName, 'ResourceGroupName>, value: string) : ApiManagementSubscriptionState<'ApiManagementName, 'DisplayName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.SecondaryKey <- value)
            state : ApiManagementSubscriptionState<'ApiManagementName, 'DisplayName, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_subscription#state-1">ApiManagementSubscription#state</a>.
        /// </summary>
        [<CustomOperation "state">]
        member _.State(state: ApiManagementSubscriptionState<'ApiManagementName, 'DisplayName, 'ResourceGroupName>, value: string) : ApiManagementSubscriptionState<'ApiManagementName, 'DisplayName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.State <- value)
            state : ApiManagementSubscriptionState<'ApiManagementName, 'DisplayName, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_subscription#subscription_id-1">ApiManagementSubscription#subscription_id</a>.
        /// </summary>
        [<CustomOperation "subscription_id">]
        member _.SubscriptionId(state: ApiManagementSubscriptionState<'ApiManagementName, 'DisplayName, 'ResourceGroupName>, value: string) : ApiManagementSubscriptionState<'ApiManagementName, 'DisplayName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.SubscriptionId <- value)
            state : ApiManagementSubscriptionState<'ApiManagementName, 'DisplayName, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_subscription#timeouts-1">ApiManagementSubscription#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ApiManagementSubscriptionState<'ApiManagementName, 'DisplayName, 'ResourceGroupName>, value: azurerm.ApiManagementSubscription.ApiManagementSubscriptionTimeouts) : ApiManagementSubscriptionState<'ApiManagementName, 'DisplayName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ApiManagementSubscriptionState<'ApiManagementName, 'DisplayName, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_subscription#user_id-1">ApiManagementSubscription#user_id</a>.
        /// </summary>
        [<CustomOperation "user_id">]
        member _.UserId(state: ApiManagementSubscriptionState<'ApiManagementName, 'DisplayName, 'ResourceGroupName>, value: string) : ApiManagementSubscriptionState<'ApiManagementName, 'DisplayName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.UserId <- value)
            state : ApiManagementSubscriptionState<'ApiManagementName, 'DisplayName, 'ResourceGroupName>

        member _.Run(state: ApiManagementSubscriptionState<Present, Present, Present>) : azurerm.ApiManagementSubscription.ApiManagementSubscription =
            let config = azurerm.ApiManagementSubscription.ApiManagementSubscriptionConfig()
            for setter in state.assignments do
                setter config
            azurerm.ApiManagementSubscription.ApiManagementSubscription(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.apiManagementSubscription: missing required arguments. Must call: api_management_name, display_name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: ApiManagementSubscriptionState<_, _, _>) : azurerm.ApiManagementSubscription.ApiManagementSubscription =
            Unchecked.defaultof<azurerm.ApiManagementSubscription.ApiManagementSubscription>

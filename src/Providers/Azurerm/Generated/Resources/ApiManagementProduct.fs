namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ApiManagementProductState<'ApiManagementName, 'DisplayName, 'ProductId, 'Published, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.ApiManagementProduct.ApiManagementProductConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_product">azurerm_api_management_product</a>.
    /// </summary>
    type ApiManagementProductBuilder(logicalId: string) =
        member _.Yield(_: unit) : ApiManagementProductState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiManagementProductState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ApiManagementProductState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiManagementProductState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_product#api_management_name-1">ApiManagementProduct#api_management_name</a>.
        /// </summary>
        [<CustomOperation "api_management_name">]
        member _.ApiManagementName(state: ApiManagementProductState<Missing, 'DisplayName, 'ProductId, 'Published, 'ResourceGroupName>, value: string) : ApiManagementProductState<Present, 'DisplayName, 'ProductId, 'Published, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ApiManagementName <- value)
            ({ assignments = state.assignments } : ApiManagementProductState<Present, 'DisplayName, 'ProductId, 'Published, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_product#display_name-1">ApiManagementProduct#display_name</a>.
        /// </summary>
        [<CustomOperation "display_name">]
        member _.DisplayName(state: ApiManagementProductState<'ApiManagementName, Missing, 'ProductId, 'Published, 'ResourceGroupName>, value: string) : ApiManagementProductState<'ApiManagementName, Present, 'ProductId, 'Published, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DisplayName <- value)
            ({ assignments = state.assignments } : ApiManagementProductState<'ApiManagementName, Present, 'ProductId, 'Published, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_product#product_id-1">ApiManagementProduct#product_id</a>.
        /// </summary>
        [<CustomOperation "product_id">]
        member _.ProductId(state: ApiManagementProductState<'ApiManagementName, 'DisplayName, Missing, 'Published, 'ResourceGroupName>, value: string) : ApiManagementProductState<'ApiManagementName, 'DisplayName, Present, 'Published, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ProductId <- value)
            ({ assignments = state.assignments } : ApiManagementProductState<'ApiManagementName, 'DisplayName, Present, 'Published, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_product#published-1">ApiManagementProduct#published</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "published">]
        member _.Published(state: ApiManagementProductState<'ApiManagementName, 'DisplayName, 'ProductId, Missing, 'ResourceGroupName>, value: bool) : ApiManagementProductState<'ApiManagementName, 'DisplayName, 'ProductId, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Published <- value)
            ({ assignments = state.assignments } : ApiManagementProductState<'ApiManagementName, 'DisplayName, 'ProductId, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_product#published-1">ApiManagementProduct#published</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "published">]
        member _.Published(state: ApiManagementProductState<'ApiManagementName, 'DisplayName, 'ProductId, Missing, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : ApiManagementProductState<'ApiManagementName, 'DisplayName, 'ProductId, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Published <- value)
            ({ assignments = state.assignments } : ApiManagementProductState<'ApiManagementName, 'DisplayName, 'ProductId, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_product#resource_group_name-1">ApiManagementProduct#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: ApiManagementProductState<'ApiManagementName, 'DisplayName, 'ProductId, 'Published, Missing>, value: string) : ApiManagementProductState<'ApiManagementName, 'DisplayName, 'ProductId, 'Published, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : ApiManagementProductState<'ApiManagementName, 'DisplayName, 'ProductId, 'Published, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_product#approval_required-1">ApiManagementProduct#approval_required</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "approval_required">]
        member _.ApprovalRequired(state: ApiManagementProductState<'ApiManagementName, 'DisplayName, 'ProductId, 'Published, 'ResourceGroupName>, value: bool) : ApiManagementProductState<'ApiManagementName, 'DisplayName, 'ProductId, 'Published, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ApprovalRequired <- value)
            state : ApiManagementProductState<'ApiManagementName, 'DisplayName, 'ProductId, 'Published, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_product#approval_required-1">ApiManagementProduct#approval_required</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "approval_required">]
        member _.ApprovalRequired(state: ApiManagementProductState<'ApiManagementName, 'DisplayName, 'ProductId, 'Published, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : ApiManagementProductState<'ApiManagementName, 'DisplayName, 'ProductId, 'Published, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ApprovalRequired <- value)
            state : ApiManagementProductState<'ApiManagementName, 'DisplayName, 'ProductId, 'Published, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_product#description-1">ApiManagementProduct#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: ApiManagementProductState<'ApiManagementName, 'DisplayName, 'ProductId, 'Published, 'ResourceGroupName>, value: string) : ApiManagementProductState<'ApiManagementName, 'DisplayName, 'ProductId, 'Published, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : ApiManagementProductState<'ApiManagementName, 'DisplayName, 'ProductId, 'Published, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_product#id-1">ApiManagementProduct#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ApiManagementProductState<'ApiManagementName, 'DisplayName, 'ProductId, 'Published, 'ResourceGroupName>, value: string) : ApiManagementProductState<'ApiManagementName, 'DisplayName, 'ProductId, 'Published, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ApiManagementProductState<'ApiManagementName, 'DisplayName, 'ProductId, 'Published, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_product#subscription_required-1">ApiManagementProduct#subscription_required</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "subscription_required">]
        member _.SubscriptionRequired(state: ApiManagementProductState<'ApiManagementName, 'DisplayName, 'ProductId, 'Published, 'ResourceGroupName>, value: bool) : ApiManagementProductState<'ApiManagementName, 'DisplayName, 'ProductId, 'Published, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.SubscriptionRequired <- value)
            state : ApiManagementProductState<'ApiManagementName, 'DisplayName, 'ProductId, 'Published, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_product#subscription_required-1">ApiManagementProduct#subscription_required</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "subscription_required">]
        member _.SubscriptionRequired(state: ApiManagementProductState<'ApiManagementName, 'DisplayName, 'ProductId, 'Published, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : ApiManagementProductState<'ApiManagementName, 'DisplayName, 'ProductId, 'Published, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.SubscriptionRequired <- value)
            state : ApiManagementProductState<'ApiManagementName, 'DisplayName, 'ProductId, 'Published, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_product#subscriptions_limit-1">ApiManagementProduct#subscriptions_limit</a>.
        /// </summary>
        [<CustomOperation "subscriptions_limit">]
        member _.SubscriptionsLimit(state: ApiManagementProductState<'ApiManagementName, 'DisplayName, 'ProductId, 'Published, 'ResourceGroupName>, value: double) : ApiManagementProductState<'ApiManagementName, 'DisplayName, 'ProductId, 'Published, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.SubscriptionsLimit <- value)
            state : ApiManagementProductState<'ApiManagementName, 'DisplayName, 'ProductId, 'Published, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_product#terms-1">ApiManagementProduct#terms</a>.
        /// </summary>
        [<CustomOperation "terms">]
        member _.Terms(state: ApiManagementProductState<'ApiManagementName, 'DisplayName, 'ProductId, 'Published, 'ResourceGroupName>, value: string) : ApiManagementProductState<'ApiManagementName, 'DisplayName, 'ProductId, 'Published, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Terms <- value)
            state : ApiManagementProductState<'ApiManagementName, 'DisplayName, 'ProductId, 'Published, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_product#timeouts-1">ApiManagementProduct#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ApiManagementProductState<'ApiManagementName, 'DisplayName, 'ProductId, 'Published, 'ResourceGroupName>, value: azurerm.ApiManagementProduct.ApiManagementProductTimeouts) : ApiManagementProductState<'ApiManagementName, 'DisplayName, 'ProductId, 'Published, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ApiManagementProductState<'ApiManagementName, 'DisplayName, 'ProductId, 'Published, 'ResourceGroupName>

        member _.Run(state: ApiManagementProductState<Present, Present, Present, Present, Present>) : azurerm.ApiManagementProduct.ApiManagementProduct =
            let config = azurerm.ApiManagementProduct.ApiManagementProductConfig()
            for setter in state.assignments do
                setter config
            azurerm.ApiManagementProduct.ApiManagementProduct(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.apiManagementProduct: missing required arguments. Must call: api_management_name, display_name, product_id, published, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: ApiManagementProductState<_, _, _, _, _>) : azurerm.ApiManagementProduct.ApiManagementProduct =
            Unchecked.defaultof<azurerm.ApiManagementProduct.ApiManagementProduct>

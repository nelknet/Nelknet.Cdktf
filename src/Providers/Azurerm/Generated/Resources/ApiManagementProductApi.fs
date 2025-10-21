namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ApiManagementProductApiState<'ApiManagementName, 'ApiName, 'ProductId, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.ApiManagementProductApi.ApiManagementProductApiConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_product_api">azurerm_api_management_product_api</a>.
    /// </summary>
    type ApiManagementProductApiBuilder(logicalId: string) =
        member _.Yield(_: unit) : ApiManagementProductApiState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiManagementProductApiState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ApiManagementProductApiState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiManagementProductApiState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_product_api#api_management_name-1">ApiManagementProductApi#api_management_name</a>.
        /// </summary>
        [<CustomOperation "api_management_name">]
        member _.ApiManagementName(state: ApiManagementProductApiState<Missing, 'ApiName, 'ProductId, 'ResourceGroupName>, value: string) : ApiManagementProductApiState<Present, 'ApiName, 'ProductId, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ApiManagementName <- value)
            ({ assignments = state.assignments } : ApiManagementProductApiState<Present, 'ApiName, 'ProductId, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_product_api#api_name-1">ApiManagementProductApi#api_name</a>.
        /// </summary>
        [<CustomOperation "api_name">]
        member _.ApiName(state: ApiManagementProductApiState<'ApiManagementName, Missing, 'ProductId, 'ResourceGroupName>, value: string) : ApiManagementProductApiState<'ApiManagementName, Present, 'ProductId, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ApiName <- value)
            ({ assignments = state.assignments } : ApiManagementProductApiState<'ApiManagementName, Present, 'ProductId, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_product_api#product_id-1">ApiManagementProductApi#product_id</a>.
        /// </summary>
        [<CustomOperation "product_id">]
        member _.ProductId(state: ApiManagementProductApiState<'ApiManagementName, 'ApiName, Missing, 'ResourceGroupName>, value: string) : ApiManagementProductApiState<'ApiManagementName, 'ApiName, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ProductId <- value)
            ({ assignments = state.assignments } : ApiManagementProductApiState<'ApiManagementName, 'ApiName, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_product_api#resource_group_name-1">ApiManagementProductApi#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: ApiManagementProductApiState<'ApiManagementName, 'ApiName, 'ProductId, Missing>, value: string) : ApiManagementProductApiState<'ApiManagementName, 'ApiName, 'ProductId, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : ApiManagementProductApiState<'ApiManagementName, 'ApiName, 'ProductId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_product_api#id-1">ApiManagementProductApi#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ApiManagementProductApiState<'ApiManagementName, 'ApiName, 'ProductId, 'ResourceGroupName>, value: string) : ApiManagementProductApiState<'ApiManagementName, 'ApiName, 'ProductId, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ApiManagementProductApiState<'ApiManagementName, 'ApiName, 'ProductId, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_product_api#timeouts-1">ApiManagementProductApi#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ApiManagementProductApiState<'ApiManagementName, 'ApiName, 'ProductId, 'ResourceGroupName>, value: azurerm.ApiManagementProductApi.ApiManagementProductApiTimeouts) : ApiManagementProductApiState<'ApiManagementName, 'ApiName, 'ProductId, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ApiManagementProductApiState<'ApiManagementName, 'ApiName, 'ProductId, 'ResourceGroupName>

        member _.Run(state: ApiManagementProductApiState<Present, Present, Present, Present>) : azurerm.ApiManagementProductApi.ApiManagementProductApi =
            let config = azurerm.ApiManagementProductApi.ApiManagementProductApiConfig()
            for setter in state.assignments do
                setter config
            azurerm.ApiManagementProductApi.ApiManagementProductApi(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.apiManagementProductApi: missing required arguments. Must call: api_management_name, api_name, product_id, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: ApiManagementProductApiState<_, _, _, _>) : azurerm.ApiManagementProductApi.ApiManagementProductApi =
            Unchecked.defaultof<azurerm.ApiManagementProductApi.ApiManagementProductApi>

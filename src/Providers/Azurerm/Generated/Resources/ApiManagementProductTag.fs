namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ApiManagementProductTagState<'ApiManagementName, 'ApiManagementProductId, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.ApiManagementProductTag.ApiManagementProductTagConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_product_tag">azurerm_api_management_product_tag</a>.
    /// </summary>
    type ApiManagementProductTagBuilder(logicalId: string) =
        member _.Yield(_: unit) : ApiManagementProductTagState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiManagementProductTagState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ApiManagementProductTagState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiManagementProductTagState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_product_tag#api_management_name-1">ApiManagementProductTag#api_management_name</a>.
        /// </summary>
        [<CustomOperation "api_management_name">]
        member _.ApiManagementName(state: ApiManagementProductTagState<Missing, 'ApiManagementProductId, 'Name, 'ResourceGroupName>, value: string) : ApiManagementProductTagState<Present, 'ApiManagementProductId, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ApiManagementName <- value)
            ({ assignments = state.assignments } : ApiManagementProductTagState<Present, 'ApiManagementProductId, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_product_tag#api_management_product_id-1">ApiManagementProductTag#api_management_product_id</a>.
        /// </summary>
        [<CustomOperation "api_management_product_id">]
        member _.ApiManagementProductId(state: ApiManagementProductTagState<'ApiManagementName, Missing, 'Name, 'ResourceGroupName>, value: string) : ApiManagementProductTagState<'ApiManagementName, Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ApiManagementProductId <- value)
            ({ assignments = state.assignments } : ApiManagementProductTagState<'ApiManagementName, Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_product_tag#name-1">ApiManagementProductTag#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ApiManagementProductTagState<'ApiManagementName, 'ApiManagementProductId, Missing, 'ResourceGroupName>, value: string) : ApiManagementProductTagState<'ApiManagementName, 'ApiManagementProductId, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ApiManagementProductTagState<'ApiManagementName, 'ApiManagementProductId, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_product_tag#resource_group_name-1">ApiManagementProductTag#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: ApiManagementProductTagState<'ApiManagementName, 'ApiManagementProductId, 'Name, Missing>, value: string) : ApiManagementProductTagState<'ApiManagementName, 'ApiManagementProductId, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : ApiManagementProductTagState<'ApiManagementName, 'ApiManagementProductId, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_product_tag#id-1">ApiManagementProductTag#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ApiManagementProductTagState<'ApiManagementName, 'ApiManagementProductId, 'Name, 'ResourceGroupName>, value: string) : ApiManagementProductTagState<'ApiManagementName, 'ApiManagementProductId, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ApiManagementProductTagState<'ApiManagementName, 'ApiManagementProductId, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_product_tag#timeouts-1">ApiManagementProductTag#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ApiManagementProductTagState<'ApiManagementName, 'ApiManagementProductId, 'Name, 'ResourceGroupName>, value: azurerm.ApiManagementProductTag.ApiManagementProductTagTimeouts) : ApiManagementProductTagState<'ApiManagementName, 'ApiManagementProductId, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ApiManagementProductTagState<'ApiManagementName, 'ApiManagementProductId, 'Name, 'ResourceGroupName>

        member _.Run(state: ApiManagementProductTagState<Present, Present, Present, Present>) : azurerm.ApiManagementProductTag.ApiManagementProductTag =
            let config = azurerm.ApiManagementProductTag.ApiManagementProductTagConfig()
            for setter in state.assignments do
                setter config
            azurerm.ApiManagementProductTag.ApiManagementProductTag(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.apiManagementProductTag: missing required arguments. Must call: api_management_name, api_management_product_id, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: ApiManagementProductTagState<_, _, _, _>) : azurerm.ApiManagementProductTag.ApiManagementProductTag =
            Unchecked.defaultof<azurerm.ApiManagementProductTag.ApiManagementProductTag>

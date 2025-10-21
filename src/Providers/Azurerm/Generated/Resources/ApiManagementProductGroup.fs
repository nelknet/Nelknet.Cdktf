namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ApiManagementProductGroupState<'ApiManagementName, 'GroupName, 'ProductId, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.ApiManagementProductGroup.ApiManagementProductGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_product_group">azurerm_api_management_product_group</a>.
    /// </summary>
    type ApiManagementProductGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : ApiManagementProductGroupState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiManagementProductGroupState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ApiManagementProductGroupState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiManagementProductGroupState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_product_group#api_management_name-1">ApiManagementProductGroup#api_management_name</a>.
        /// </summary>
        [<CustomOperation "api_management_name">]
        member _.ApiManagementName(state: ApiManagementProductGroupState<Missing, 'GroupName, 'ProductId, 'ResourceGroupName>, value: string) : ApiManagementProductGroupState<Present, 'GroupName, 'ProductId, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ApiManagementName <- value)
            ({ assignments = state.assignments } : ApiManagementProductGroupState<Present, 'GroupName, 'ProductId, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_product_group#group_name-1">ApiManagementProductGroup#group_name</a>.
        /// </summary>
        [<CustomOperation "group_name">]
        member _.GroupName(state: ApiManagementProductGroupState<'ApiManagementName, Missing, 'ProductId, 'ResourceGroupName>, value: string) : ApiManagementProductGroupState<'ApiManagementName, Present, 'ProductId, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.GroupName <- value)
            ({ assignments = state.assignments } : ApiManagementProductGroupState<'ApiManagementName, Present, 'ProductId, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_product_group#product_id-1">ApiManagementProductGroup#product_id</a>.
        /// </summary>
        [<CustomOperation "product_id">]
        member _.ProductId(state: ApiManagementProductGroupState<'ApiManagementName, 'GroupName, Missing, 'ResourceGroupName>, value: string) : ApiManagementProductGroupState<'ApiManagementName, 'GroupName, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ProductId <- value)
            ({ assignments = state.assignments } : ApiManagementProductGroupState<'ApiManagementName, 'GroupName, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_product_group#resource_group_name-1">ApiManagementProductGroup#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: ApiManagementProductGroupState<'ApiManagementName, 'GroupName, 'ProductId, Missing>, value: string) : ApiManagementProductGroupState<'ApiManagementName, 'GroupName, 'ProductId, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : ApiManagementProductGroupState<'ApiManagementName, 'GroupName, 'ProductId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_product_group#id-1">ApiManagementProductGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ApiManagementProductGroupState<'ApiManagementName, 'GroupName, 'ProductId, 'ResourceGroupName>, value: string) : ApiManagementProductGroupState<'ApiManagementName, 'GroupName, 'ProductId, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ApiManagementProductGroupState<'ApiManagementName, 'GroupName, 'ProductId, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_product_group#timeouts-1">ApiManagementProductGroup#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ApiManagementProductGroupState<'ApiManagementName, 'GroupName, 'ProductId, 'ResourceGroupName>, value: azurerm.ApiManagementProductGroup.ApiManagementProductGroupTimeouts) : ApiManagementProductGroupState<'ApiManagementName, 'GroupName, 'ProductId, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ApiManagementProductGroupState<'ApiManagementName, 'GroupName, 'ProductId, 'ResourceGroupName>

        member _.Run(state: ApiManagementProductGroupState<Present, Present, Present, Present>) : azurerm.ApiManagementProductGroup.ApiManagementProductGroup =
            let config = azurerm.ApiManagementProductGroup.ApiManagementProductGroupConfig()
            for setter in state.assignments do
                setter config
            azurerm.ApiManagementProductGroup.ApiManagementProductGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.apiManagementProductGroup: missing required arguments. Must call: api_management_name, group_name, product_id, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: ApiManagementProductGroupState<_, _, _, _>) : azurerm.ApiManagementProductGroup.ApiManagementProductGroup =
            Unchecked.defaultof<azurerm.ApiManagementProductGroup.ApiManagementProductGroup>

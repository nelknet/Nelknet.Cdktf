namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ApiManagementProductPolicyState<'ApiManagementName, 'ProductId, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.ApiManagementProductPolicy.ApiManagementProductPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_product_policy">azurerm_api_management_product_policy</a>.
    /// </summary>
    type ApiManagementProductPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : ApiManagementProductPolicyState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiManagementProductPolicyState<Missing, Missing, Missing>)

        member _.Zero(()) : ApiManagementProductPolicyState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiManagementProductPolicyState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_product_policy#api_management_name-1">ApiManagementProductPolicy#api_management_name</a>.
        /// </summary>
        [<CustomOperation "api_management_name">]
        member _.ApiManagementName(state: ApiManagementProductPolicyState<Missing, 'ProductId, 'ResourceGroupName>, value: string) : ApiManagementProductPolicyState<Present, 'ProductId, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ApiManagementName <- value)
            ({ assignments = state.assignments } : ApiManagementProductPolicyState<Present, 'ProductId, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_product_policy#product_id-1">ApiManagementProductPolicy#product_id</a>.
        /// </summary>
        [<CustomOperation "product_id">]
        member _.ProductId(state: ApiManagementProductPolicyState<'ApiManagementName, Missing, 'ResourceGroupName>, value: string) : ApiManagementProductPolicyState<'ApiManagementName, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ProductId <- value)
            ({ assignments = state.assignments } : ApiManagementProductPolicyState<'ApiManagementName, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_product_policy#resource_group_name-1">ApiManagementProductPolicy#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: ApiManagementProductPolicyState<'ApiManagementName, 'ProductId, Missing>, value: string) : ApiManagementProductPolicyState<'ApiManagementName, 'ProductId, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : ApiManagementProductPolicyState<'ApiManagementName, 'ProductId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_product_policy#id-1">ApiManagementProductPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ApiManagementProductPolicyState<'ApiManagementName, 'ProductId, 'ResourceGroupName>, value: string) : ApiManagementProductPolicyState<'ApiManagementName, 'ProductId, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ApiManagementProductPolicyState<'ApiManagementName, 'ProductId, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_product_policy#timeouts-1">ApiManagementProductPolicy#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ApiManagementProductPolicyState<'ApiManagementName, 'ProductId, 'ResourceGroupName>, value: azurerm.ApiManagementProductPolicy.ApiManagementProductPolicyTimeouts) : ApiManagementProductPolicyState<'ApiManagementName, 'ProductId, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ApiManagementProductPolicyState<'ApiManagementName, 'ProductId, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_product_policy#xml_content-1">ApiManagementProductPolicy#xml_content</a>.
        /// </summary>
        [<CustomOperation "xml_content">]
        member _.XmlContent(state: ApiManagementProductPolicyState<'ApiManagementName, 'ProductId, 'ResourceGroupName>, value: string) : ApiManagementProductPolicyState<'ApiManagementName, 'ProductId, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.XmlContent <- value)
            state : ApiManagementProductPolicyState<'ApiManagementName, 'ProductId, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_product_policy#xml_link-1">ApiManagementProductPolicy#xml_link</a>.
        /// </summary>
        [<CustomOperation "xml_link">]
        member _.XmlLink(state: ApiManagementProductPolicyState<'ApiManagementName, 'ProductId, 'ResourceGroupName>, value: string) : ApiManagementProductPolicyState<'ApiManagementName, 'ProductId, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.XmlLink <- value)
            state : ApiManagementProductPolicyState<'ApiManagementName, 'ProductId, 'ResourceGroupName>

        member _.Run(state: ApiManagementProductPolicyState<Present, Present, Present>) : azurerm.ApiManagementProductPolicy.ApiManagementProductPolicy =
            let config = azurerm.ApiManagementProductPolicy.ApiManagementProductPolicyConfig()
            for setter in state.assignments do
                setter config
            azurerm.ApiManagementProductPolicy.ApiManagementProductPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.apiManagementProductPolicy: missing required arguments. Must call: api_management_name, product_id, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: ApiManagementProductPolicyState<_, _, _>) : azurerm.ApiManagementProductPolicy.ApiManagementProductPolicy =
            Unchecked.defaultof<azurerm.ApiManagementProductPolicy.ApiManagementProductPolicy>

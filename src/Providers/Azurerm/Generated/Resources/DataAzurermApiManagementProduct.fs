namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermApiManagementProductState<'ApiManagementName, 'ProductId, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermApiManagementProduct.DataAzurermApiManagementProductConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/api_management_product">azurerm_api_management_product</a>.
    /// </summary>
    type DataAzurermApiManagementProductBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermApiManagementProductState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermApiManagementProductState<Missing, Missing, Missing>)

        member _.Zero(()) : DataAzurermApiManagementProductState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermApiManagementProductState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/api_management_product#api_management_name-1">DataAzurermApiManagementProduct#api_management_name</a>.
        /// </summary>
        [<CustomOperation "api_management_name">]
        member _.ApiManagementName(state: DataAzurermApiManagementProductState<Missing, 'ProductId, 'ResourceGroupName>, value: string) : DataAzurermApiManagementProductState<Present, 'ProductId, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ApiManagementName <- value)
            ({ assignments = state.assignments } : DataAzurermApiManagementProductState<Present, 'ProductId, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/api_management_product#product_id-1">DataAzurermApiManagementProduct#product_id</a>.
        /// </summary>
        [<CustomOperation "product_id">]
        member _.ProductId(state: DataAzurermApiManagementProductState<'ApiManagementName, Missing, 'ResourceGroupName>, value: string) : DataAzurermApiManagementProductState<'ApiManagementName, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ProductId <- value)
            ({ assignments = state.assignments } : DataAzurermApiManagementProductState<'ApiManagementName, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/api_management_product#resource_group_name-1">DataAzurermApiManagementProduct#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermApiManagementProductState<'ApiManagementName, 'ProductId, Missing>, value: string) : DataAzurermApiManagementProductState<'ApiManagementName, 'ProductId, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermApiManagementProductState<'ApiManagementName, 'ProductId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/api_management_product#id-1">DataAzurermApiManagementProduct#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermApiManagementProductState<'ApiManagementName, 'ProductId, 'ResourceGroupName>, value: string) : DataAzurermApiManagementProductState<'ApiManagementName, 'ProductId, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermApiManagementProductState<'ApiManagementName, 'ProductId, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/api_management_product#timeouts-1">DataAzurermApiManagementProduct#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermApiManagementProductState<'ApiManagementName, 'ProductId, 'ResourceGroupName>, value: azurerm.DataAzurermApiManagementProduct.DataAzurermApiManagementProductTimeouts) : DataAzurermApiManagementProductState<'ApiManagementName, 'ProductId, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermApiManagementProductState<'ApiManagementName, 'ProductId, 'ResourceGroupName>

        member _.Run(state: DataAzurermApiManagementProductState<Present, Present, Present>) : azurerm.DataAzurermApiManagementProduct.DataAzurermApiManagementProduct =
            let config = azurerm.DataAzurermApiManagementProduct.DataAzurermApiManagementProductConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermApiManagementProduct.DataAzurermApiManagementProduct(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermApiManagementProduct: missing required arguments. Must call: api_management_name, product_id, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermApiManagementProductState<_, _, _>) : azurerm.DataAzurermApiManagementProduct.DataAzurermApiManagementProduct =
            Unchecked.defaultof<azurerm.DataAzurermApiManagementProduct.DataAzurermApiManagementProduct>

namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermApiManagementApiState<'ApiManagementName, 'Name, 'ResourceGroupName, 'Revision> = { assignments: ResizeArray<azurerm.DataAzurermApiManagementApi.DataAzurermApiManagementApiConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/api_management_api">azurerm_api_management_api</a>.
    /// </summary>
    type DataAzurermApiManagementApiBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermApiManagementApiState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermApiManagementApiState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : DataAzurermApiManagementApiState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermApiManagementApiState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/api_management_api#api_management_name-1">DataAzurermApiManagementApi#api_management_name</a>.
        /// </summary>
        [<CustomOperation "api_management_name">]
        member _.ApiManagementName(state: DataAzurermApiManagementApiState<Missing, 'Name, 'ResourceGroupName, 'Revision>, value: string) : DataAzurermApiManagementApiState<Present, 'Name, 'ResourceGroupName, 'Revision> =
            state.assignments.Add(fun config -> config.ApiManagementName <- value)
            ({ assignments = state.assignments } : DataAzurermApiManagementApiState<Present, 'Name, 'ResourceGroupName, 'Revision>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/api_management_api#name-1">DataAzurermApiManagementApi#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermApiManagementApiState<'ApiManagementName, Missing, 'ResourceGroupName, 'Revision>, value: string) : DataAzurermApiManagementApiState<'ApiManagementName, Present, 'ResourceGroupName, 'Revision> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermApiManagementApiState<'ApiManagementName, Present, 'ResourceGroupName, 'Revision>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/api_management_api#resource_group_name-1">DataAzurermApiManagementApi#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermApiManagementApiState<'ApiManagementName, 'Name, Missing, 'Revision>, value: string) : DataAzurermApiManagementApiState<'ApiManagementName, 'Name, Present, 'Revision> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermApiManagementApiState<'ApiManagementName, 'Name, Present, 'Revision>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/api_management_api#revision-1">DataAzurermApiManagementApi#revision</a>.
        /// </summary>
        [<CustomOperation "revision">]
        member _.Revision(state: DataAzurermApiManagementApiState<'ApiManagementName, 'Name, 'ResourceGroupName, Missing>, value: string) : DataAzurermApiManagementApiState<'ApiManagementName, 'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.Revision <- value)
            ({ assignments = state.assignments } : DataAzurermApiManagementApiState<'ApiManagementName, 'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/api_management_api#id-1">DataAzurermApiManagementApi#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermApiManagementApiState<'ApiManagementName, 'Name, 'ResourceGroupName, 'Revision>, value: string) : DataAzurermApiManagementApiState<'ApiManagementName, 'Name, 'ResourceGroupName, 'Revision> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermApiManagementApiState<'ApiManagementName, 'Name, 'ResourceGroupName, 'Revision>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/api_management_api#timeouts-1">DataAzurermApiManagementApi#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermApiManagementApiState<'ApiManagementName, 'Name, 'ResourceGroupName, 'Revision>, value: azurerm.DataAzurermApiManagementApi.DataAzurermApiManagementApiTimeouts) : DataAzurermApiManagementApiState<'ApiManagementName, 'Name, 'ResourceGroupName, 'Revision> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermApiManagementApiState<'ApiManagementName, 'Name, 'ResourceGroupName, 'Revision>

        member _.Run(state: DataAzurermApiManagementApiState<Present, Present, Present, Present>) : azurerm.DataAzurermApiManagementApi.DataAzurermApiManagementApi =
            let config = azurerm.DataAzurermApiManagementApi.DataAzurermApiManagementApiConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermApiManagementApi.DataAzurermApiManagementApi(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermApiManagementApi: missing required arguments. Must call: api_management_name, name, resource_group_name, revision.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermApiManagementApiState<_, _, _, _>) : azurerm.DataAzurermApiManagementApi.DataAzurermApiManagementApi =
            Unchecked.defaultof<azurerm.DataAzurermApiManagementApi.DataAzurermApiManagementApi>

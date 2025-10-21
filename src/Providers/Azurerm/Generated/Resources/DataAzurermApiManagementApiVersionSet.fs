namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermApiManagementApiVersionSetState<'ApiManagementName, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermApiManagementApiVersionSet.DataAzurermApiManagementApiVersionSetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/api_management_api_version_set">azurerm_api_management_api_version_set</a>.
    /// </summary>
    type DataAzurermApiManagementApiVersionSetBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermApiManagementApiVersionSetState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermApiManagementApiVersionSetState<Missing, Missing, Missing>)

        member _.Zero(()) : DataAzurermApiManagementApiVersionSetState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermApiManagementApiVersionSetState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/api_management_api_version_set#api_management_name-1">DataAzurermApiManagementApiVersionSet#api_management_name</a>.
        /// </summary>
        [<CustomOperation "api_management_name">]
        member _.ApiManagementName(state: DataAzurermApiManagementApiVersionSetState<Missing, 'Name, 'ResourceGroupName>, value: string) : DataAzurermApiManagementApiVersionSetState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ApiManagementName <- value)
            ({ assignments = state.assignments } : DataAzurermApiManagementApiVersionSetState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/api_management_api_version_set#name-1">DataAzurermApiManagementApiVersionSet#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermApiManagementApiVersionSetState<'ApiManagementName, Missing, 'ResourceGroupName>, value: string) : DataAzurermApiManagementApiVersionSetState<'ApiManagementName, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermApiManagementApiVersionSetState<'ApiManagementName, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/api_management_api_version_set#resource_group_name-1">DataAzurermApiManagementApiVersionSet#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermApiManagementApiVersionSetState<'ApiManagementName, 'Name, Missing>, value: string) : DataAzurermApiManagementApiVersionSetState<'ApiManagementName, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermApiManagementApiVersionSetState<'ApiManagementName, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/api_management_api_version_set#id-1">DataAzurermApiManagementApiVersionSet#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermApiManagementApiVersionSetState<'ApiManagementName, 'Name, 'ResourceGroupName>, value: string) : DataAzurermApiManagementApiVersionSetState<'ApiManagementName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermApiManagementApiVersionSetState<'ApiManagementName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/api_management_api_version_set#timeouts-1">DataAzurermApiManagementApiVersionSet#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermApiManagementApiVersionSetState<'ApiManagementName, 'Name, 'ResourceGroupName>, value: azurerm.DataAzurermApiManagementApiVersionSet.DataAzurermApiManagementApiVersionSetTimeouts) : DataAzurermApiManagementApiVersionSetState<'ApiManagementName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermApiManagementApiVersionSetState<'ApiManagementName, 'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermApiManagementApiVersionSetState<Present, Present, Present>) : azurerm.DataAzurermApiManagementApiVersionSet.DataAzurermApiManagementApiVersionSet =
            let config = azurerm.DataAzurermApiManagementApiVersionSet.DataAzurermApiManagementApiVersionSetConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermApiManagementApiVersionSet.DataAzurermApiManagementApiVersionSet(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermApiManagementApiVersionSet: missing required arguments. Must call: api_management_name, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermApiManagementApiVersionSetState<_, _, _>) : azurerm.DataAzurermApiManagementApiVersionSet.DataAzurermApiManagementApiVersionSet =
            Unchecked.defaultof<azurerm.DataAzurermApiManagementApiVersionSet.DataAzurermApiManagementApiVersionSet>

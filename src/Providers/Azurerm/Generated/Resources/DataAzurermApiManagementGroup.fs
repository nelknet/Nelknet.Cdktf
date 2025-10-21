namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermApiManagementGroupState<'ApiManagementName, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermApiManagementGroup.DataAzurermApiManagementGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/api_management_group">azurerm_api_management_group</a>.
    /// </summary>
    type DataAzurermApiManagementGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermApiManagementGroupState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermApiManagementGroupState<Missing, Missing, Missing>)

        member _.Zero(()) : DataAzurermApiManagementGroupState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermApiManagementGroupState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/api_management_group#api_management_name-1">DataAzurermApiManagementGroup#api_management_name</a>.
        /// </summary>
        [<CustomOperation "api_management_name">]
        member _.ApiManagementName(state: DataAzurermApiManagementGroupState<Missing, 'Name, 'ResourceGroupName>, value: string) : DataAzurermApiManagementGroupState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ApiManagementName <- value)
            ({ assignments = state.assignments } : DataAzurermApiManagementGroupState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/api_management_group#name-1">DataAzurermApiManagementGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermApiManagementGroupState<'ApiManagementName, Missing, 'ResourceGroupName>, value: string) : DataAzurermApiManagementGroupState<'ApiManagementName, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermApiManagementGroupState<'ApiManagementName, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/api_management_group#resource_group_name-1">DataAzurermApiManagementGroup#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermApiManagementGroupState<'ApiManagementName, 'Name, Missing>, value: string) : DataAzurermApiManagementGroupState<'ApiManagementName, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermApiManagementGroupState<'ApiManagementName, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/api_management_group#id-1">DataAzurermApiManagementGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermApiManagementGroupState<'ApiManagementName, 'Name, 'ResourceGroupName>, value: string) : DataAzurermApiManagementGroupState<'ApiManagementName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermApiManagementGroupState<'ApiManagementName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/api_management_group#timeouts-1">DataAzurermApiManagementGroup#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermApiManagementGroupState<'ApiManagementName, 'Name, 'ResourceGroupName>, value: azurerm.DataAzurermApiManagementGroup.DataAzurermApiManagementGroupTimeouts) : DataAzurermApiManagementGroupState<'ApiManagementName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermApiManagementGroupState<'ApiManagementName, 'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermApiManagementGroupState<Present, Present, Present>) : azurerm.DataAzurermApiManagementGroup.DataAzurermApiManagementGroup =
            let config = azurerm.DataAzurermApiManagementGroup.DataAzurermApiManagementGroupConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermApiManagementGroup.DataAzurermApiManagementGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermApiManagementGroup: missing required arguments. Must call: api_management_name, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermApiManagementGroupState<_, _, _>) : azurerm.DataAzurermApiManagementGroup.DataAzurermApiManagementGroup =
            Unchecked.defaultof<azurerm.DataAzurermApiManagementGroup.DataAzurermApiManagementGroup>

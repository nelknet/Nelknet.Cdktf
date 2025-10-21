namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermApiManagementUserState<'ApiManagementName, 'ResourceGroupName, 'UserId> = { assignments: ResizeArray<azurerm.DataAzurermApiManagementUser.DataAzurermApiManagementUserConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/api_management_user">azurerm_api_management_user</a>.
    /// </summary>
    type DataAzurermApiManagementUserBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermApiManagementUserState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermApiManagementUserState<Missing, Missing, Missing>)

        member _.Zero(()) : DataAzurermApiManagementUserState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermApiManagementUserState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/api_management_user#api_management_name-1">DataAzurermApiManagementUser#api_management_name</a>.
        /// </summary>
        [<CustomOperation "api_management_name">]
        member _.ApiManagementName(state: DataAzurermApiManagementUserState<Missing, 'ResourceGroupName, 'UserId>, value: string) : DataAzurermApiManagementUserState<Present, 'ResourceGroupName, 'UserId> =
            state.assignments.Add(fun config -> config.ApiManagementName <- value)
            ({ assignments = state.assignments } : DataAzurermApiManagementUserState<Present, 'ResourceGroupName, 'UserId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/api_management_user#resource_group_name-1">DataAzurermApiManagementUser#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermApiManagementUserState<'ApiManagementName, Missing, 'UserId>, value: string) : DataAzurermApiManagementUserState<'ApiManagementName, Present, 'UserId> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermApiManagementUserState<'ApiManagementName, Present, 'UserId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/api_management_user#user_id-1">DataAzurermApiManagementUser#user_id</a>.
        /// </summary>
        [<CustomOperation "user_id">]
        member _.UserId(state: DataAzurermApiManagementUserState<'ApiManagementName, 'ResourceGroupName, Missing>, value: string) : DataAzurermApiManagementUserState<'ApiManagementName, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.UserId <- value)
            ({ assignments = state.assignments } : DataAzurermApiManagementUserState<'ApiManagementName, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/api_management_user#id-1">DataAzurermApiManagementUser#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermApiManagementUserState<'ApiManagementName, 'ResourceGroupName, 'UserId>, value: string) : DataAzurermApiManagementUserState<'ApiManagementName, 'ResourceGroupName, 'UserId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermApiManagementUserState<'ApiManagementName, 'ResourceGroupName, 'UserId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/api_management_user#timeouts-1">DataAzurermApiManagementUser#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermApiManagementUserState<'ApiManagementName, 'ResourceGroupName, 'UserId>, value: azurerm.DataAzurermApiManagementUser.DataAzurermApiManagementUserTimeouts) : DataAzurermApiManagementUserState<'ApiManagementName, 'ResourceGroupName, 'UserId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermApiManagementUserState<'ApiManagementName, 'ResourceGroupName, 'UserId>

        member _.Run(state: DataAzurermApiManagementUserState<Present, Present, Present>) : azurerm.DataAzurermApiManagementUser.DataAzurermApiManagementUser =
            let config = azurerm.DataAzurermApiManagementUser.DataAzurermApiManagementUserConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermApiManagementUser.DataAzurermApiManagementUser(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermApiManagementUser: missing required arguments. Must call: api_management_name, resource_group_name, user_id.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermApiManagementUserState<_, _, _>) : azurerm.DataAzurermApiManagementUser.DataAzurermApiManagementUser =
            Unchecked.defaultof<azurerm.DataAzurermApiManagementUser.DataAzurermApiManagementUser>

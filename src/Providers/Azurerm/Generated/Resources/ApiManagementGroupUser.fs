namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ApiManagementGroupUserState<'ApiManagementName, 'GroupName, 'ResourceGroupName, 'UserId> = { assignments: ResizeArray<azurerm.ApiManagementGroupUser.ApiManagementGroupUserConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_group_user">azurerm_api_management_group_user</a>.
    /// </summary>
    type ApiManagementGroupUserBuilder(logicalId: string) =
        member _.Yield(_: unit) : ApiManagementGroupUserState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiManagementGroupUserState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ApiManagementGroupUserState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiManagementGroupUserState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_group_user#api_management_name-1">ApiManagementGroupUser#api_management_name</a>.
        /// </summary>
        [<CustomOperation "api_management_name">]
        member _.ApiManagementName(state: ApiManagementGroupUserState<Missing, 'GroupName, 'ResourceGroupName, 'UserId>, value: string) : ApiManagementGroupUserState<Present, 'GroupName, 'ResourceGroupName, 'UserId> =
            state.assignments.Add(fun config -> config.ApiManagementName <- value)
            ({ assignments = state.assignments } : ApiManagementGroupUserState<Present, 'GroupName, 'ResourceGroupName, 'UserId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_group_user#group_name-1">ApiManagementGroupUser#group_name</a>.
        /// </summary>
        [<CustomOperation "group_name">]
        member _.GroupName(state: ApiManagementGroupUserState<'ApiManagementName, Missing, 'ResourceGroupName, 'UserId>, value: string) : ApiManagementGroupUserState<'ApiManagementName, Present, 'ResourceGroupName, 'UserId> =
            state.assignments.Add(fun config -> config.GroupName <- value)
            ({ assignments = state.assignments } : ApiManagementGroupUserState<'ApiManagementName, Present, 'ResourceGroupName, 'UserId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_group_user#resource_group_name-1">ApiManagementGroupUser#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: ApiManagementGroupUserState<'ApiManagementName, 'GroupName, Missing, 'UserId>, value: string) : ApiManagementGroupUserState<'ApiManagementName, 'GroupName, Present, 'UserId> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : ApiManagementGroupUserState<'ApiManagementName, 'GroupName, Present, 'UserId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_group_user#user_id-1">ApiManagementGroupUser#user_id</a>.
        /// </summary>
        [<CustomOperation "user_id">]
        member _.UserId(state: ApiManagementGroupUserState<'ApiManagementName, 'GroupName, 'ResourceGroupName, Missing>, value: string) : ApiManagementGroupUserState<'ApiManagementName, 'GroupName, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.UserId <- value)
            ({ assignments = state.assignments } : ApiManagementGroupUserState<'ApiManagementName, 'GroupName, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_group_user#id-1">ApiManagementGroupUser#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ApiManagementGroupUserState<'ApiManagementName, 'GroupName, 'ResourceGroupName, 'UserId>, value: string) : ApiManagementGroupUserState<'ApiManagementName, 'GroupName, 'ResourceGroupName, 'UserId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ApiManagementGroupUserState<'ApiManagementName, 'GroupName, 'ResourceGroupName, 'UserId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_group_user#timeouts-1">ApiManagementGroupUser#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ApiManagementGroupUserState<'ApiManagementName, 'GroupName, 'ResourceGroupName, 'UserId>, value: azurerm.ApiManagementGroupUser.ApiManagementGroupUserTimeouts) : ApiManagementGroupUserState<'ApiManagementName, 'GroupName, 'ResourceGroupName, 'UserId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ApiManagementGroupUserState<'ApiManagementName, 'GroupName, 'ResourceGroupName, 'UserId>

        member _.Run(state: ApiManagementGroupUserState<Present, Present, Present, Present>) : azurerm.ApiManagementGroupUser.ApiManagementGroupUser =
            let config = azurerm.ApiManagementGroupUser.ApiManagementGroupUserConfig()
            for setter in state.assignments do
                setter config
            azurerm.ApiManagementGroupUser.ApiManagementGroupUser(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.apiManagementGroupUser: missing required arguments. Must call: api_management_name, group_name, resource_group_name, user_id.", 9999, IsError = true)>]
        member _.Run(_: ApiManagementGroupUserState<_, _, _, _>) : azurerm.ApiManagementGroupUser.ApiManagementGroupUser =
            Unchecked.defaultof<azurerm.ApiManagementGroupUser.ApiManagementGroupUser>

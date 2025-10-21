namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ApiManagementUserState<'ApiManagementName, 'Email, 'FirstName, 'LastName, 'ResourceGroupName, 'UserId> = { assignments: ResizeArray<azurerm.ApiManagementUser.ApiManagementUserConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_user">azurerm_api_management_user</a>.
    /// </summary>
    type ApiManagementUserBuilder(logicalId: string) =
        member _.Yield(_: unit) : ApiManagementUserState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiManagementUserState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ApiManagementUserState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiManagementUserState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_user#api_management_name-1">ApiManagementUser#api_management_name</a>.
        /// </summary>
        [<CustomOperation "api_management_name">]
        member _.ApiManagementName(state: ApiManagementUserState<Missing, 'Email, 'FirstName, 'LastName, 'ResourceGroupName, 'UserId>, value: string) : ApiManagementUserState<Present, 'Email, 'FirstName, 'LastName, 'ResourceGroupName, 'UserId> =
            state.assignments.Add(fun config -> config.ApiManagementName <- value)
            ({ assignments = state.assignments } : ApiManagementUserState<Present, 'Email, 'FirstName, 'LastName, 'ResourceGroupName, 'UserId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_user#email-1">ApiManagementUser#email</a>.
        /// </summary>
        [<CustomOperation "email">]
        member _.Email(state: ApiManagementUserState<'ApiManagementName, Missing, 'FirstName, 'LastName, 'ResourceGroupName, 'UserId>, value: string) : ApiManagementUserState<'ApiManagementName, Present, 'FirstName, 'LastName, 'ResourceGroupName, 'UserId> =
            state.assignments.Add(fun config -> config.Email <- value)
            ({ assignments = state.assignments } : ApiManagementUserState<'ApiManagementName, Present, 'FirstName, 'LastName, 'ResourceGroupName, 'UserId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_user#first_name-1">ApiManagementUser#first_name</a>.
        /// </summary>
        [<CustomOperation "first_name">]
        member _.FirstName(state: ApiManagementUserState<'ApiManagementName, 'Email, Missing, 'LastName, 'ResourceGroupName, 'UserId>, value: string) : ApiManagementUserState<'ApiManagementName, 'Email, Present, 'LastName, 'ResourceGroupName, 'UserId> =
            state.assignments.Add(fun config -> config.FirstName <- value)
            ({ assignments = state.assignments } : ApiManagementUserState<'ApiManagementName, 'Email, Present, 'LastName, 'ResourceGroupName, 'UserId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_user#last_name-1">ApiManagementUser#last_name</a>.
        /// </summary>
        [<CustomOperation "last_name">]
        member _.LastName(state: ApiManagementUserState<'ApiManagementName, 'Email, 'FirstName, Missing, 'ResourceGroupName, 'UserId>, value: string) : ApiManagementUserState<'ApiManagementName, 'Email, 'FirstName, Present, 'ResourceGroupName, 'UserId> =
            state.assignments.Add(fun config -> config.LastName <- value)
            ({ assignments = state.assignments } : ApiManagementUserState<'ApiManagementName, 'Email, 'FirstName, Present, 'ResourceGroupName, 'UserId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_user#resource_group_name-1">ApiManagementUser#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: ApiManagementUserState<'ApiManagementName, 'Email, 'FirstName, 'LastName, Missing, 'UserId>, value: string) : ApiManagementUserState<'ApiManagementName, 'Email, 'FirstName, 'LastName, Present, 'UserId> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : ApiManagementUserState<'ApiManagementName, 'Email, 'FirstName, 'LastName, Present, 'UserId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_user#user_id-1">ApiManagementUser#user_id</a>.
        /// </summary>
        [<CustomOperation "user_id">]
        member _.UserId(state: ApiManagementUserState<'ApiManagementName, 'Email, 'FirstName, 'LastName, 'ResourceGroupName, Missing>, value: string) : ApiManagementUserState<'ApiManagementName, 'Email, 'FirstName, 'LastName, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.UserId <- value)
            ({ assignments = state.assignments } : ApiManagementUserState<'ApiManagementName, 'Email, 'FirstName, 'LastName, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_user#confirmation-1">ApiManagementUser#confirmation</a>.
        /// </summary>
        [<CustomOperation "confirmation">]
        member _.Confirmation(state: ApiManagementUserState<'ApiManagementName, 'Email, 'FirstName, 'LastName, 'ResourceGroupName, 'UserId>, value: string) : ApiManagementUserState<'ApiManagementName, 'Email, 'FirstName, 'LastName, 'ResourceGroupName, 'UserId> =
            state.assignments.Add(fun config -> config.Confirmation <- value)
            state : ApiManagementUserState<'ApiManagementName, 'Email, 'FirstName, 'LastName, 'ResourceGroupName, 'UserId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_user#id-1">ApiManagementUser#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ApiManagementUserState<'ApiManagementName, 'Email, 'FirstName, 'LastName, 'ResourceGroupName, 'UserId>, value: string) : ApiManagementUserState<'ApiManagementName, 'Email, 'FirstName, 'LastName, 'ResourceGroupName, 'UserId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ApiManagementUserState<'ApiManagementName, 'Email, 'FirstName, 'LastName, 'ResourceGroupName, 'UserId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_user#note-1">ApiManagementUser#note</a>.
        /// </summary>
        [<CustomOperation "note">]
        member _.Note(state: ApiManagementUserState<'ApiManagementName, 'Email, 'FirstName, 'LastName, 'ResourceGroupName, 'UserId>, value: string) : ApiManagementUserState<'ApiManagementName, 'Email, 'FirstName, 'LastName, 'ResourceGroupName, 'UserId> =
            state.assignments.Add(fun config -> config.Note <- value)
            state : ApiManagementUserState<'ApiManagementName, 'Email, 'FirstName, 'LastName, 'ResourceGroupName, 'UserId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_user#password-1">ApiManagementUser#password</a>.
        /// </summary>
        [<CustomOperation "password">]
        member _.Password(state: ApiManagementUserState<'ApiManagementName, 'Email, 'FirstName, 'LastName, 'ResourceGroupName, 'UserId>, value: string) : ApiManagementUserState<'ApiManagementName, 'Email, 'FirstName, 'LastName, 'ResourceGroupName, 'UserId> =
            state.assignments.Add(fun config -> config.Password <- value)
            state : ApiManagementUserState<'ApiManagementName, 'Email, 'FirstName, 'LastName, 'ResourceGroupName, 'UserId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_user#state-1">ApiManagementUser#state</a>.
        /// </summary>
        [<CustomOperation "state">]
        member _.State(state: ApiManagementUserState<'ApiManagementName, 'Email, 'FirstName, 'LastName, 'ResourceGroupName, 'UserId>, value: string) : ApiManagementUserState<'ApiManagementName, 'Email, 'FirstName, 'LastName, 'ResourceGroupName, 'UserId> =
            state.assignments.Add(fun config -> config.State <- value)
            state : ApiManagementUserState<'ApiManagementName, 'Email, 'FirstName, 'LastName, 'ResourceGroupName, 'UserId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_user#timeouts-1">ApiManagementUser#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ApiManagementUserState<'ApiManagementName, 'Email, 'FirstName, 'LastName, 'ResourceGroupName, 'UserId>, value: azurerm.ApiManagementUser.ApiManagementUserTimeouts) : ApiManagementUserState<'ApiManagementName, 'Email, 'FirstName, 'LastName, 'ResourceGroupName, 'UserId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ApiManagementUserState<'ApiManagementName, 'Email, 'FirstName, 'LastName, 'ResourceGroupName, 'UserId>

        member _.Run(state: ApiManagementUserState<Present, Present, Present, Present, Present, Present>) : azurerm.ApiManagementUser.ApiManagementUser =
            let config = azurerm.ApiManagementUser.ApiManagementUserConfig()
            for setter in state.assignments do
                setter config
            azurerm.ApiManagementUser.ApiManagementUser(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.apiManagementUser: missing required arguments. Must call: api_management_name, email, first_name, last_name, resource_group_name, user_id.", 9999, IsError = true)>]
        member _.Run(_: ApiManagementUserState<_, _, _, _, _, _>) : azurerm.ApiManagementUser.ApiManagementUser =
            Unchecked.defaultof<azurerm.ApiManagementUser.ApiManagementUser>

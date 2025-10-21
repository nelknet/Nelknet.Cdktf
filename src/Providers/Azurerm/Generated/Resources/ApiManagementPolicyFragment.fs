namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ApiManagementPolicyFragmentState<'ApiManagementId, 'Name, 'Value> = { assignments: ResizeArray<azurerm.ApiManagementPolicyFragment.ApiManagementPolicyFragmentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_policy_fragment">azurerm_api_management_policy_fragment</a>.
    /// </summary>
    type ApiManagementPolicyFragmentBuilder(logicalId: string) =
        member _.Yield(_: unit) : ApiManagementPolicyFragmentState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiManagementPolicyFragmentState<Missing, Missing, Missing>)

        member _.Zero(()) : ApiManagementPolicyFragmentState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiManagementPolicyFragmentState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_policy_fragment#api_management_id-1">ApiManagementPolicyFragment#api_management_id</a>.
        /// </summary>
        [<CustomOperation "api_management_id">]
        member _.ApiManagementId(state: ApiManagementPolicyFragmentState<Missing, 'Name, 'Value>, value: string) : ApiManagementPolicyFragmentState<Present, 'Name, 'Value> =
            state.assignments.Add(fun config -> config.ApiManagementId <- value)
            ({ assignments = state.assignments } : ApiManagementPolicyFragmentState<Present, 'Name, 'Value>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_policy_fragment#name-1">ApiManagementPolicyFragment#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ApiManagementPolicyFragmentState<'ApiManagementId, Missing, 'Value>, value: string) : ApiManagementPolicyFragmentState<'ApiManagementId, Present, 'Value> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ApiManagementPolicyFragmentState<'ApiManagementId, Present, 'Value>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_policy_fragment#value-1">ApiManagementPolicyFragment#value</a>.
        /// </summary>
        [<CustomOperation "value">]
        member _.Value(state: ApiManagementPolicyFragmentState<'ApiManagementId, 'Name, Missing>, value: string) : ApiManagementPolicyFragmentState<'ApiManagementId, 'Name, Present> =
            state.assignments.Add(fun config -> config.Value <- value)
            ({ assignments = state.assignments } : ApiManagementPolicyFragmentState<'ApiManagementId, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_policy_fragment#description-1">ApiManagementPolicyFragment#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: ApiManagementPolicyFragmentState<'ApiManagementId, 'Name, 'Value>, value: string) : ApiManagementPolicyFragmentState<'ApiManagementId, 'Name, 'Value> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : ApiManagementPolicyFragmentState<'ApiManagementId, 'Name, 'Value>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_policy_fragment#format-1">ApiManagementPolicyFragment#format</a>.
        /// </summary>
        [<CustomOperation "format">]
        member _.Format(state: ApiManagementPolicyFragmentState<'ApiManagementId, 'Name, 'Value>, value: string) : ApiManagementPolicyFragmentState<'ApiManagementId, 'Name, 'Value> =
            state.assignments.Add(fun config -> config.Format <- value)
            state : ApiManagementPolicyFragmentState<'ApiManagementId, 'Name, 'Value>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_policy_fragment#id-1">ApiManagementPolicyFragment#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ApiManagementPolicyFragmentState<'ApiManagementId, 'Name, 'Value>, value: string) : ApiManagementPolicyFragmentState<'ApiManagementId, 'Name, 'Value> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ApiManagementPolicyFragmentState<'ApiManagementId, 'Name, 'Value>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_policy_fragment#timeouts-1">ApiManagementPolicyFragment#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ApiManagementPolicyFragmentState<'ApiManagementId, 'Name, 'Value>, value: azurerm.ApiManagementPolicyFragment.ApiManagementPolicyFragmentTimeouts) : ApiManagementPolicyFragmentState<'ApiManagementId, 'Name, 'Value> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ApiManagementPolicyFragmentState<'ApiManagementId, 'Name, 'Value>

        member _.Run(state: ApiManagementPolicyFragmentState<Present, Present, Present>) : azurerm.ApiManagementPolicyFragment.ApiManagementPolicyFragment =
            let config = azurerm.ApiManagementPolicyFragment.ApiManagementPolicyFragmentConfig()
            for setter in state.assignments do
                setter config
            azurerm.ApiManagementPolicyFragment.ApiManagementPolicyFragment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.apiManagementPolicyFragment: missing required arguments. Must call: api_management_id, name, value.", 9999, IsError = true)>]
        member _.Run(_: ApiManagementPolicyFragmentState<_, _, _>) : azurerm.ApiManagementPolicyFragment.ApiManagementPolicyFragment =
            Unchecked.defaultof<azurerm.ApiManagementPolicyFragment.ApiManagementPolicyFragment>

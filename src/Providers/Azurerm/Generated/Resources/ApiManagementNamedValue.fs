namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ApiManagementNamedValueState<'ApiManagementName, 'DisplayName, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.ApiManagementNamedValue.ApiManagementNamedValueConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_named_value">azurerm_api_management_named_value</a>.
    /// </summary>
    type ApiManagementNamedValueBuilder(logicalId: string) =
        member _.Yield(_: unit) : ApiManagementNamedValueState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiManagementNamedValueState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ApiManagementNamedValueState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiManagementNamedValueState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_named_value#api_management_name-1">ApiManagementNamedValue#api_management_name</a>.
        /// </summary>
        [<CustomOperation "api_management_name">]
        member _.ApiManagementName(state: ApiManagementNamedValueState<Missing, 'DisplayName, 'Name, 'ResourceGroupName>, value: string) : ApiManagementNamedValueState<Present, 'DisplayName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ApiManagementName <- value)
            ({ assignments = state.assignments } : ApiManagementNamedValueState<Present, 'DisplayName, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_named_value#display_name-1">ApiManagementNamedValue#display_name</a>.
        /// </summary>
        [<CustomOperation "display_name">]
        member _.DisplayName(state: ApiManagementNamedValueState<'ApiManagementName, Missing, 'Name, 'ResourceGroupName>, value: string) : ApiManagementNamedValueState<'ApiManagementName, Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DisplayName <- value)
            ({ assignments = state.assignments } : ApiManagementNamedValueState<'ApiManagementName, Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_named_value#name-1">ApiManagementNamedValue#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ApiManagementNamedValueState<'ApiManagementName, 'DisplayName, Missing, 'ResourceGroupName>, value: string) : ApiManagementNamedValueState<'ApiManagementName, 'DisplayName, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ApiManagementNamedValueState<'ApiManagementName, 'DisplayName, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_named_value#resource_group_name-1">ApiManagementNamedValue#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: ApiManagementNamedValueState<'ApiManagementName, 'DisplayName, 'Name, Missing>, value: string) : ApiManagementNamedValueState<'ApiManagementName, 'DisplayName, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : ApiManagementNamedValueState<'ApiManagementName, 'DisplayName, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_named_value#id-1">ApiManagementNamedValue#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ApiManagementNamedValueState<'ApiManagementName, 'DisplayName, 'Name, 'ResourceGroupName>, value: string) : ApiManagementNamedValueState<'ApiManagementName, 'DisplayName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ApiManagementNamedValueState<'ApiManagementName, 'DisplayName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_named_value#secret-1">ApiManagementNamedValue#secret</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "secret">]
        member _.Secret(state: ApiManagementNamedValueState<'ApiManagementName, 'DisplayName, 'Name, 'ResourceGroupName>, value: bool) : ApiManagementNamedValueState<'ApiManagementName, 'DisplayName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Secret <- value)
            state : ApiManagementNamedValueState<'ApiManagementName, 'DisplayName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_named_value#secret-1">ApiManagementNamedValue#secret</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "secret">]
        member _.Secret(state: ApiManagementNamedValueState<'ApiManagementName, 'DisplayName, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : ApiManagementNamedValueState<'ApiManagementName, 'DisplayName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Secret <- value)
            state : ApiManagementNamedValueState<'ApiManagementName, 'DisplayName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_named_value#tags-1">ApiManagementNamedValue#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ApiManagementNamedValueState<'ApiManagementName, 'DisplayName, 'Name, 'ResourceGroupName>, value: seq<string>) : ApiManagementNamedValueState<'ApiManagementName, 'DisplayName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- (value |> Seq.toArray))
            state : ApiManagementNamedValueState<'ApiManagementName, 'DisplayName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_named_value#timeouts-1">ApiManagementNamedValue#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ApiManagementNamedValueState<'ApiManagementName, 'DisplayName, 'Name, 'ResourceGroupName>, value: azurerm.ApiManagementNamedValue.ApiManagementNamedValueTimeouts) : ApiManagementNamedValueState<'ApiManagementName, 'DisplayName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ApiManagementNamedValueState<'ApiManagementName, 'DisplayName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_named_value#value-1">ApiManagementNamedValue#value</a>.
        /// </summary>
        [<CustomOperation "value">]
        member _.Value(state: ApiManagementNamedValueState<'ApiManagementName, 'DisplayName, 'Name, 'ResourceGroupName>, value: string) : ApiManagementNamedValueState<'ApiManagementName, 'DisplayName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Value <- value)
            state : ApiManagementNamedValueState<'ApiManagementName, 'DisplayName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// value_from_key_vault block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_named_value#value_from_key_vault-1">ApiManagementNamedValue#value_from_key_vault</a>
        /// </summary>
        [<CustomOperation "value_from_key_vault">]
        member _.ValueFromKeyVault(state: ApiManagementNamedValueState<'ApiManagementName, 'DisplayName, 'Name, 'ResourceGroupName>, value: azurerm.ApiManagementNamedValue.ApiManagementNamedValueValueFromKeyVault) : ApiManagementNamedValueState<'ApiManagementName, 'DisplayName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ValueFromKeyVault <- value)
            state : ApiManagementNamedValueState<'ApiManagementName, 'DisplayName, 'Name, 'ResourceGroupName>

        member _.Run(state: ApiManagementNamedValueState<Present, Present, Present, Present>) : azurerm.ApiManagementNamedValue.ApiManagementNamedValue =
            let config = azurerm.ApiManagementNamedValue.ApiManagementNamedValueConfig()
            for setter in state.assignments do
                setter config
            azurerm.ApiManagementNamedValue.ApiManagementNamedValue(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.apiManagementNamedValue: missing required arguments. Must call: api_management_name, display_name, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: ApiManagementNamedValueState<_, _, _, _>) : azurerm.ApiManagementNamedValue.ApiManagementNamedValue =
            Unchecked.defaultof<azurerm.ApiManagementNamedValue.ApiManagementNamedValue>

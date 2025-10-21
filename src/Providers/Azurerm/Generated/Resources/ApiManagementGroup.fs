namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ApiManagementGroupState<'ApiManagementName, 'DisplayName, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.ApiManagementGroup.ApiManagementGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_group">azurerm_api_management_group</a>.
    /// </summary>
    type ApiManagementGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : ApiManagementGroupState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiManagementGroupState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ApiManagementGroupState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiManagementGroupState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_group#api_management_name-1">ApiManagementGroup#api_management_name</a>.
        /// </summary>
        [<CustomOperation "api_management_name">]
        member _.ApiManagementName(state: ApiManagementGroupState<Missing, 'DisplayName, 'Name, 'ResourceGroupName>, value: string) : ApiManagementGroupState<Present, 'DisplayName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ApiManagementName <- value)
            ({ assignments = state.assignments } : ApiManagementGroupState<Present, 'DisplayName, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_group#display_name-1">ApiManagementGroup#display_name</a>.
        /// </summary>
        [<CustomOperation "display_name">]
        member _.DisplayName(state: ApiManagementGroupState<'ApiManagementName, Missing, 'Name, 'ResourceGroupName>, value: string) : ApiManagementGroupState<'ApiManagementName, Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DisplayName <- value)
            ({ assignments = state.assignments } : ApiManagementGroupState<'ApiManagementName, Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_group#name-1">ApiManagementGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ApiManagementGroupState<'ApiManagementName, 'DisplayName, Missing, 'ResourceGroupName>, value: string) : ApiManagementGroupState<'ApiManagementName, 'DisplayName, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ApiManagementGroupState<'ApiManagementName, 'DisplayName, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_group#resource_group_name-1">ApiManagementGroup#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: ApiManagementGroupState<'ApiManagementName, 'DisplayName, 'Name, Missing>, value: string) : ApiManagementGroupState<'ApiManagementName, 'DisplayName, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : ApiManagementGroupState<'ApiManagementName, 'DisplayName, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_group#description-1">ApiManagementGroup#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: ApiManagementGroupState<'ApiManagementName, 'DisplayName, 'Name, 'ResourceGroupName>, value: string) : ApiManagementGroupState<'ApiManagementName, 'DisplayName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : ApiManagementGroupState<'ApiManagementName, 'DisplayName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_group#external_id-1">ApiManagementGroup#external_id</a>.
        /// </summary>
        [<CustomOperation "external_id">]
        member _.ExternalId(state: ApiManagementGroupState<'ApiManagementName, 'DisplayName, 'Name, 'ResourceGroupName>, value: string) : ApiManagementGroupState<'ApiManagementName, 'DisplayName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ExternalId <- value)
            state : ApiManagementGroupState<'ApiManagementName, 'DisplayName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_group#id-1">ApiManagementGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ApiManagementGroupState<'ApiManagementName, 'DisplayName, 'Name, 'ResourceGroupName>, value: string) : ApiManagementGroupState<'ApiManagementName, 'DisplayName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ApiManagementGroupState<'ApiManagementName, 'DisplayName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_group#timeouts-1">ApiManagementGroup#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ApiManagementGroupState<'ApiManagementName, 'DisplayName, 'Name, 'ResourceGroupName>, value: azurerm.ApiManagementGroup.ApiManagementGroupTimeouts) : ApiManagementGroupState<'ApiManagementName, 'DisplayName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ApiManagementGroupState<'ApiManagementName, 'DisplayName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_group#type-1">ApiManagementGroup#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: ApiManagementGroupState<'ApiManagementName, 'DisplayName, 'Name, 'ResourceGroupName>, value: string) : ApiManagementGroupState<'ApiManagementName, 'DisplayName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Type <- value)
            state : ApiManagementGroupState<'ApiManagementName, 'DisplayName, 'Name, 'ResourceGroupName>

        member _.Run(state: ApiManagementGroupState<Present, Present, Present, Present>) : azurerm.ApiManagementGroup.ApiManagementGroup =
            let config = azurerm.ApiManagementGroup.ApiManagementGroupConfig()
            for setter in state.assignments do
                setter config
            azurerm.ApiManagementGroup.ApiManagementGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.apiManagementGroup: missing required arguments. Must call: api_management_name, display_name, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: ApiManagementGroupState<_, _, _, _>) : azurerm.ApiManagementGroup.ApiManagementGroup =
            Unchecked.defaultof<azurerm.ApiManagementGroup.ApiManagementGroup>

namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ApiManagementApiOperationPolicyState<'ApiManagementName, 'ApiName, 'OperationId, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.ApiManagementApiOperationPolicy.ApiManagementApiOperationPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_operation_policy">azurerm_api_management_api_operation_policy</a>.
    /// </summary>
    type ApiManagementApiOperationPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : ApiManagementApiOperationPolicyState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiManagementApiOperationPolicyState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ApiManagementApiOperationPolicyState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiManagementApiOperationPolicyState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_operation_policy#api_management_name-1">ApiManagementApiOperationPolicy#api_management_name</a>.
        /// </summary>
        [<CustomOperation "api_management_name">]
        member _.ApiManagementName(state: ApiManagementApiOperationPolicyState<Missing, 'ApiName, 'OperationId, 'ResourceGroupName>, value: string) : ApiManagementApiOperationPolicyState<Present, 'ApiName, 'OperationId, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ApiManagementName <- value)
            ({ assignments = state.assignments } : ApiManagementApiOperationPolicyState<Present, 'ApiName, 'OperationId, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_operation_policy#api_name-1">ApiManagementApiOperationPolicy#api_name</a>.
        /// </summary>
        [<CustomOperation "api_name">]
        member _.ApiName(state: ApiManagementApiOperationPolicyState<'ApiManagementName, Missing, 'OperationId, 'ResourceGroupName>, value: string) : ApiManagementApiOperationPolicyState<'ApiManagementName, Present, 'OperationId, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ApiName <- value)
            ({ assignments = state.assignments } : ApiManagementApiOperationPolicyState<'ApiManagementName, Present, 'OperationId, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_operation_policy#operation_id-1">ApiManagementApiOperationPolicy#operation_id</a>.
        /// </summary>
        [<CustomOperation "operation_id">]
        member _.OperationId(state: ApiManagementApiOperationPolicyState<'ApiManagementName, 'ApiName, Missing, 'ResourceGroupName>, value: string) : ApiManagementApiOperationPolicyState<'ApiManagementName, 'ApiName, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.OperationId <- value)
            ({ assignments = state.assignments } : ApiManagementApiOperationPolicyState<'ApiManagementName, 'ApiName, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_operation_policy#resource_group_name-1">ApiManagementApiOperationPolicy#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: ApiManagementApiOperationPolicyState<'ApiManagementName, 'ApiName, 'OperationId, Missing>, value: string) : ApiManagementApiOperationPolicyState<'ApiManagementName, 'ApiName, 'OperationId, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : ApiManagementApiOperationPolicyState<'ApiManagementName, 'ApiName, 'OperationId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_operation_policy#id-1">ApiManagementApiOperationPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ApiManagementApiOperationPolicyState<'ApiManagementName, 'ApiName, 'OperationId, 'ResourceGroupName>, value: string) : ApiManagementApiOperationPolicyState<'ApiManagementName, 'ApiName, 'OperationId, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ApiManagementApiOperationPolicyState<'ApiManagementName, 'ApiName, 'OperationId, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_operation_policy#timeouts-1">ApiManagementApiOperationPolicy#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ApiManagementApiOperationPolicyState<'ApiManagementName, 'ApiName, 'OperationId, 'ResourceGroupName>, value: azurerm.ApiManagementApiOperationPolicy.ApiManagementApiOperationPolicyTimeouts) : ApiManagementApiOperationPolicyState<'ApiManagementName, 'ApiName, 'OperationId, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ApiManagementApiOperationPolicyState<'ApiManagementName, 'ApiName, 'OperationId, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_operation_policy#xml_content-1">ApiManagementApiOperationPolicy#xml_content</a>.
        /// </summary>
        [<CustomOperation "xml_content">]
        member _.XmlContent(state: ApiManagementApiOperationPolicyState<'ApiManagementName, 'ApiName, 'OperationId, 'ResourceGroupName>, value: string) : ApiManagementApiOperationPolicyState<'ApiManagementName, 'ApiName, 'OperationId, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.XmlContent <- value)
            state : ApiManagementApiOperationPolicyState<'ApiManagementName, 'ApiName, 'OperationId, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_operation_policy#xml_link-1">ApiManagementApiOperationPolicy#xml_link</a>.
        /// </summary>
        [<CustomOperation "xml_link">]
        member _.XmlLink(state: ApiManagementApiOperationPolicyState<'ApiManagementName, 'ApiName, 'OperationId, 'ResourceGroupName>, value: string) : ApiManagementApiOperationPolicyState<'ApiManagementName, 'ApiName, 'OperationId, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.XmlLink <- value)
            state : ApiManagementApiOperationPolicyState<'ApiManagementName, 'ApiName, 'OperationId, 'ResourceGroupName>

        member _.Run(state: ApiManagementApiOperationPolicyState<Present, Present, Present, Present>) : azurerm.ApiManagementApiOperationPolicy.ApiManagementApiOperationPolicy =
            let config = azurerm.ApiManagementApiOperationPolicy.ApiManagementApiOperationPolicyConfig()
            for setter in state.assignments do
                setter config
            azurerm.ApiManagementApiOperationPolicy.ApiManagementApiOperationPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.apiManagementApiOperationPolicy: missing required arguments. Must call: api_management_name, api_name, operation_id, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: ApiManagementApiOperationPolicyState<_, _, _, _>) : azurerm.ApiManagementApiOperationPolicy.ApiManagementApiOperationPolicy =
            Unchecked.defaultof<azurerm.ApiManagementApiOperationPolicy.ApiManagementApiOperationPolicy>

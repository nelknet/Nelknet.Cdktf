namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ApiManagementApiPolicyState<'ApiManagementName, 'ApiName, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.ApiManagementApiPolicy.ApiManagementApiPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_policy">azurerm_api_management_api_policy</a>.
    /// </summary>
    type ApiManagementApiPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : ApiManagementApiPolicyState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiManagementApiPolicyState<Missing, Missing, Missing>)

        member _.Zero(()) : ApiManagementApiPolicyState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiManagementApiPolicyState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_policy#api_management_name-1">ApiManagementApiPolicy#api_management_name</a>.
        /// </summary>
        [<CustomOperation "api_management_name">]
        member _.ApiManagementName(state: ApiManagementApiPolicyState<Missing, 'ApiName, 'ResourceGroupName>, value: string) : ApiManagementApiPolicyState<Present, 'ApiName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ApiManagementName <- value)
            ({ assignments = state.assignments } : ApiManagementApiPolicyState<Present, 'ApiName, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_policy#api_name-1">ApiManagementApiPolicy#api_name</a>.
        /// </summary>
        [<CustomOperation "api_name">]
        member _.ApiName(state: ApiManagementApiPolicyState<'ApiManagementName, Missing, 'ResourceGroupName>, value: string) : ApiManagementApiPolicyState<'ApiManagementName, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ApiName <- value)
            ({ assignments = state.assignments } : ApiManagementApiPolicyState<'ApiManagementName, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_policy#resource_group_name-1">ApiManagementApiPolicy#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: ApiManagementApiPolicyState<'ApiManagementName, 'ApiName, Missing>, value: string) : ApiManagementApiPolicyState<'ApiManagementName, 'ApiName, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : ApiManagementApiPolicyState<'ApiManagementName, 'ApiName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_policy#id-1">ApiManagementApiPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ApiManagementApiPolicyState<'ApiManagementName, 'ApiName, 'ResourceGroupName>, value: string) : ApiManagementApiPolicyState<'ApiManagementName, 'ApiName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ApiManagementApiPolicyState<'ApiManagementName, 'ApiName, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_policy#timeouts-1">ApiManagementApiPolicy#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ApiManagementApiPolicyState<'ApiManagementName, 'ApiName, 'ResourceGroupName>, value: azurerm.ApiManagementApiPolicy.ApiManagementApiPolicyTimeouts) : ApiManagementApiPolicyState<'ApiManagementName, 'ApiName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ApiManagementApiPolicyState<'ApiManagementName, 'ApiName, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_policy#xml_content-1">ApiManagementApiPolicy#xml_content</a>.
        /// </summary>
        [<CustomOperation "xml_content">]
        member _.XmlContent(state: ApiManagementApiPolicyState<'ApiManagementName, 'ApiName, 'ResourceGroupName>, value: string) : ApiManagementApiPolicyState<'ApiManagementName, 'ApiName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.XmlContent <- value)
            state : ApiManagementApiPolicyState<'ApiManagementName, 'ApiName, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_policy#xml_link-1">ApiManagementApiPolicy#xml_link</a>.
        /// </summary>
        [<CustomOperation "xml_link">]
        member _.XmlLink(state: ApiManagementApiPolicyState<'ApiManagementName, 'ApiName, 'ResourceGroupName>, value: string) : ApiManagementApiPolicyState<'ApiManagementName, 'ApiName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.XmlLink <- value)
            state : ApiManagementApiPolicyState<'ApiManagementName, 'ApiName, 'ResourceGroupName>

        member _.Run(state: ApiManagementApiPolicyState<Present, Present, Present>) : azurerm.ApiManagementApiPolicy.ApiManagementApiPolicy =
            let config = azurerm.ApiManagementApiPolicy.ApiManagementApiPolicyConfig()
            for setter in state.assignments do
                setter config
            azurerm.ApiManagementApiPolicy.ApiManagementApiPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.apiManagementApiPolicy: missing required arguments. Must call: api_management_name, api_name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: ApiManagementApiPolicyState<_, _, _>) : azurerm.ApiManagementApiPolicy.ApiManagementApiPolicy =
            Unchecked.defaultof<azurerm.ApiManagementApiPolicy.ApiManagementApiPolicy>

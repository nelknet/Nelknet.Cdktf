namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ApiManagementPolicyState<'ApiManagementId> = { assignments: ResizeArray<azurerm.ApiManagementPolicy.ApiManagementPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_policy">azurerm_api_management_policy</a>.
    /// </summary>
    type ApiManagementPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : ApiManagementPolicyState<Missing> =
            ({ assignments = ResizeArray() } : ApiManagementPolicyState<Missing>)

        member _.Zero(()) : ApiManagementPolicyState<Missing> =
            ({ assignments = ResizeArray() } : ApiManagementPolicyState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_policy#api_management_id-1">ApiManagementPolicy#api_management_id</a>.
        /// </summary>
        [<CustomOperation "api_management_id">]
        member _.ApiManagementId(state: ApiManagementPolicyState<Missing>, value: string) : ApiManagementPolicyState<Present> =
            state.assignments.Add(fun config -> config.ApiManagementId <- value)
            ({ assignments = state.assignments } : ApiManagementPolicyState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_policy#id-1">ApiManagementPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ApiManagementPolicyState<'ApiManagementId>, value: string) : ApiManagementPolicyState<'ApiManagementId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ApiManagementPolicyState<'ApiManagementId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_policy#timeouts-1">ApiManagementPolicy#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ApiManagementPolicyState<'ApiManagementId>, value: azurerm.ApiManagementPolicy.ApiManagementPolicyTimeouts) : ApiManagementPolicyState<'ApiManagementId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ApiManagementPolicyState<'ApiManagementId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_policy#xml_content-1">ApiManagementPolicy#xml_content</a>.
        /// </summary>
        [<CustomOperation "xml_content">]
        member _.XmlContent(state: ApiManagementPolicyState<'ApiManagementId>, value: string) : ApiManagementPolicyState<'ApiManagementId> =
            state.assignments.Add(fun config -> config.XmlContent <- value)
            state : ApiManagementPolicyState<'ApiManagementId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_policy#xml_link-1">ApiManagementPolicy#xml_link</a>.
        /// </summary>
        [<CustomOperation "xml_link">]
        member _.XmlLink(state: ApiManagementPolicyState<'ApiManagementId>, value: string) : ApiManagementPolicyState<'ApiManagementId> =
            state.assignments.Add(fun config -> config.XmlLink <- value)
            state : ApiManagementPolicyState<'ApiManagementId>

        member _.Run(state: ApiManagementPolicyState<Present>) : azurerm.ApiManagementPolicy.ApiManagementPolicy =
            let config = azurerm.ApiManagementPolicy.ApiManagementPolicyConfig()
            for setter in state.assignments do
                setter config
            azurerm.ApiManagementPolicy.ApiManagementPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.apiManagementPolicy: missing required arguments. Must call: api_management_id.", 9999, IsError = true)>]
        member _.Run(_: ApiManagementPolicyState<_>) : azurerm.ApiManagementPolicy.ApiManagementPolicy =
            Unchecked.defaultof<azurerm.ApiManagementPolicy.ApiManagementPolicy>

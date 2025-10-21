namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ApiManagementCustomDomainState<'ApiManagementId> = { assignments: ResizeArray<azurerm.ApiManagementCustomDomain.ApiManagementCustomDomainConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_custom_domain">azurerm_api_management_custom_domain</a>.
    /// </summary>
    type ApiManagementCustomDomainBuilder(logicalId: string) =
        member _.Yield(_: unit) : ApiManagementCustomDomainState<Missing> =
            ({ assignments = ResizeArray() } : ApiManagementCustomDomainState<Missing>)

        member _.Zero(()) : ApiManagementCustomDomainState<Missing> =
            ({ assignments = ResizeArray() } : ApiManagementCustomDomainState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_custom_domain#api_management_id-1">ApiManagementCustomDomain#api_management_id</a>.
        /// </summary>
        [<CustomOperation "api_management_id">]
        member _.ApiManagementId(state: ApiManagementCustomDomainState<Missing>, value: string) : ApiManagementCustomDomainState<Present> =
            state.assignments.Add(fun config -> config.ApiManagementId <- value)
            ({ assignments = state.assignments } : ApiManagementCustomDomainState<Present>)

        /// <summary>
        /// developer_portal block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_custom_domain#developer_portal-1">ApiManagementCustomDomain#developer_portal</a> Accepts: azurerm.IResolvable | azurerm.ApiManagementCustomDomain.ApiManagementCustomDomainDeveloperPortal[]
        /// </summary>
        [<CustomOperation "developer_portal">]
        member _.DeveloperPortal(state: ApiManagementCustomDomainState<'ApiManagementId>, value: HashiCorp.Cdktf.IResolvable) : ApiManagementCustomDomainState<'ApiManagementId> =
            state.assignments.Add(fun config -> config.DeveloperPortal <- value)
            state : ApiManagementCustomDomainState<'ApiManagementId>

        /// <summary>
        /// gateway block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_custom_domain#gateway-1">ApiManagementCustomDomain#gateway</a> Accepts: azurerm.IResolvable | azurerm.ApiManagementCustomDomain.ApiManagementCustomDomainGateway[]
        /// </summary>
        [<CustomOperation "gateway">]
        member _.Gateway(state: ApiManagementCustomDomainState<'ApiManagementId>, value: HashiCorp.Cdktf.IResolvable) : ApiManagementCustomDomainState<'ApiManagementId> =
            state.assignments.Add(fun config -> config.Gateway <- value)
            state : ApiManagementCustomDomainState<'ApiManagementId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_custom_domain#id-1">ApiManagementCustomDomain#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ApiManagementCustomDomainState<'ApiManagementId>, value: string) : ApiManagementCustomDomainState<'ApiManagementId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ApiManagementCustomDomainState<'ApiManagementId>

        /// <summary>
        /// management block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_custom_domain#management-1">ApiManagementCustomDomain#management</a> Accepts: azurerm.IResolvable | azurerm.ApiManagementCustomDomain.ApiManagementCustomDomainManagement[]
        /// </summary>
        [<CustomOperation "management">]
        member _.Management(state: ApiManagementCustomDomainState<'ApiManagementId>, value: HashiCorp.Cdktf.IResolvable) : ApiManagementCustomDomainState<'ApiManagementId> =
            state.assignments.Add(fun config -> config.Management <- value)
            state : ApiManagementCustomDomainState<'ApiManagementId>

        /// <summary>
        /// portal block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_custom_domain#portal-1">ApiManagementCustomDomain#portal</a> Accepts: azurerm.IResolvable | azurerm.ApiManagementCustomDomain.ApiManagementCustomDomainPortal[]
        /// </summary>
        [<CustomOperation "portal">]
        member _.Portal(state: ApiManagementCustomDomainState<'ApiManagementId>, value: HashiCorp.Cdktf.IResolvable) : ApiManagementCustomDomainState<'ApiManagementId> =
            state.assignments.Add(fun config -> config.Portal <- value)
            state : ApiManagementCustomDomainState<'ApiManagementId>

        /// <summary>
        /// scm block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_custom_domain#scm-1">ApiManagementCustomDomain#scm</a> Accepts: azurerm.IResolvable | azurerm.ApiManagementCustomDomain.ApiManagementCustomDomainScm[]
        /// </summary>
        [<CustomOperation "scm">]
        member _.Scm(state: ApiManagementCustomDomainState<'ApiManagementId>, value: HashiCorp.Cdktf.IResolvable) : ApiManagementCustomDomainState<'ApiManagementId> =
            state.assignments.Add(fun config -> config.Scm <- value)
            state : ApiManagementCustomDomainState<'ApiManagementId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_custom_domain#timeouts-1">ApiManagementCustomDomain#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ApiManagementCustomDomainState<'ApiManagementId>, value: azurerm.ApiManagementCustomDomain.ApiManagementCustomDomainTimeouts) : ApiManagementCustomDomainState<'ApiManagementId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ApiManagementCustomDomainState<'ApiManagementId>

        member _.Run(state: ApiManagementCustomDomainState<Present>) : azurerm.ApiManagementCustomDomain.ApiManagementCustomDomain =
            let config = azurerm.ApiManagementCustomDomain.ApiManagementCustomDomainConfig()
            for setter in state.assignments do
                setter config
            azurerm.ApiManagementCustomDomain.ApiManagementCustomDomain(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.apiManagementCustomDomain: missing required arguments. Must call: api_management_id.", 9999, IsError = true)>]
        member _.Run(_: ApiManagementCustomDomainState<_>) : azurerm.ApiManagementCustomDomain.ApiManagementCustomDomain =
            Unchecked.defaultof<azurerm.ApiManagementCustomDomain.ApiManagementCustomDomain>

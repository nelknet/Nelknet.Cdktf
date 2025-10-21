namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SpringCloudApiPortalCustomDomainState<'Name, 'SpringCloudApiPortalId> = { assignments: ResizeArray<azurerm.SpringCloudApiPortalCustomDomain.SpringCloudApiPortalCustomDomainConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_api_portal_custom_domain">azurerm_spring_cloud_api_portal_custom_domain</a>.
    /// </summary>
    type SpringCloudApiPortalCustomDomainBuilder(logicalId: string) =
        member _.Yield(_: unit) : SpringCloudApiPortalCustomDomainState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SpringCloudApiPortalCustomDomainState<Missing, Missing>)

        member _.Zero(()) : SpringCloudApiPortalCustomDomainState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SpringCloudApiPortalCustomDomainState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_api_portal_custom_domain#name-1">SpringCloudApiPortalCustomDomain#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SpringCloudApiPortalCustomDomainState<Missing, 'SpringCloudApiPortalId>, value: string) : SpringCloudApiPortalCustomDomainState<Present, 'SpringCloudApiPortalId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SpringCloudApiPortalCustomDomainState<Present, 'SpringCloudApiPortalId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_api_portal_custom_domain#spring_cloud_api_portal_id-1">SpringCloudApiPortalCustomDomain#spring_cloud_api_portal_id</a>.
        /// </summary>
        [<CustomOperation "spring_cloud_api_portal_id">]
        member _.SpringCloudApiPortalId(state: SpringCloudApiPortalCustomDomainState<'Name, Missing>, value: string) : SpringCloudApiPortalCustomDomainState<'Name, Present> =
            state.assignments.Add(fun config -> config.SpringCloudApiPortalId <- value)
            ({ assignments = state.assignments } : SpringCloudApiPortalCustomDomainState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_api_portal_custom_domain#id-1">SpringCloudApiPortalCustomDomain#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SpringCloudApiPortalCustomDomainState<'Name, 'SpringCloudApiPortalId>, value: string) : SpringCloudApiPortalCustomDomainState<'Name, 'SpringCloudApiPortalId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SpringCloudApiPortalCustomDomainState<'Name, 'SpringCloudApiPortalId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_api_portal_custom_domain#thumbprint-1">SpringCloudApiPortalCustomDomain#thumbprint</a>.
        /// </summary>
        [<CustomOperation "thumbprint">]
        member _.Thumbprint(state: SpringCloudApiPortalCustomDomainState<'Name, 'SpringCloudApiPortalId>, value: string) : SpringCloudApiPortalCustomDomainState<'Name, 'SpringCloudApiPortalId> =
            state.assignments.Add(fun config -> config.Thumbprint <- value)
            state : SpringCloudApiPortalCustomDomainState<'Name, 'SpringCloudApiPortalId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_api_portal_custom_domain#timeouts-1">SpringCloudApiPortalCustomDomain#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SpringCloudApiPortalCustomDomainState<'Name, 'SpringCloudApiPortalId>, value: azurerm.SpringCloudApiPortalCustomDomain.SpringCloudApiPortalCustomDomainTimeouts) : SpringCloudApiPortalCustomDomainState<'Name, 'SpringCloudApiPortalId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SpringCloudApiPortalCustomDomainState<'Name, 'SpringCloudApiPortalId>

        member _.Run(state: SpringCloudApiPortalCustomDomainState<Present, Present>) : azurerm.SpringCloudApiPortalCustomDomain.SpringCloudApiPortalCustomDomain =
            let config = azurerm.SpringCloudApiPortalCustomDomain.SpringCloudApiPortalCustomDomainConfig()
            for setter in state.assignments do
                setter config
            azurerm.SpringCloudApiPortalCustomDomain.SpringCloudApiPortalCustomDomain(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.springCloudApiPortalCustomDomain: missing required arguments. Must call: name, spring_cloud_api_portal_id.", 9999, IsError = true)>]
        member _.Run(_: SpringCloudApiPortalCustomDomainState<_, _>) : azurerm.SpringCloudApiPortalCustomDomain.SpringCloudApiPortalCustomDomain =
            Unchecked.defaultof<azurerm.SpringCloudApiPortalCustomDomain.SpringCloudApiPortalCustomDomain>

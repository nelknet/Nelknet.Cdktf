namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SpringCloudCustomDomainState<'Name, 'SpringCloudAppId> = { assignments: ResizeArray<azurerm.SpringCloudCustomDomain.SpringCloudCustomDomainConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_custom_domain">azurerm_spring_cloud_custom_domain</a>.
    /// </summary>
    type SpringCloudCustomDomainBuilder(logicalId: string) =
        member _.Yield(_: unit) : SpringCloudCustomDomainState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SpringCloudCustomDomainState<Missing, Missing>)

        member _.Zero(()) : SpringCloudCustomDomainState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SpringCloudCustomDomainState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_custom_domain#name-1">SpringCloudCustomDomain#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SpringCloudCustomDomainState<Missing, 'SpringCloudAppId>, value: string) : SpringCloudCustomDomainState<Present, 'SpringCloudAppId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SpringCloudCustomDomainState<Present, 'SpringCloudAppId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_custom_domain#spring_cloud_app_id-1">SpringCloudCustomDomain#spring_cloud_app_id</a>.
        /// </summary>
        [<CustomOperation "spring_cloud_app_id">]
        member _.SpringCloudAppId(state: SpringCloudCustomDomainState<'Name, Missing>, value: string) : SpringCloudCustomDomainState<'Name, Present> =
            state.assignments.Add(fun config -> config.SpringCloudAppId <- value)
            ({ assignments = state.assignments } : SpringCloudCustomDomainState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_custom_domain#certificate_name-1">SpringCloudCustomDomain#certificate_name</a>.
        /// </summary>
        [<CustomOperation "certificate_name">]
        member _.CertificateName(state: SpringCloudCustomDomainState<'Name, 'SpringCloudAppId>, value: string) : SpringCloudCustomDomainState<'Name, 'SpringCloudAppId> =
            state.assignments.Add(fun config -> config.CertificateName <- value)
            state : SpringCloudCustomDomainState<'Name, 'SpringCloudAppId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_custom_domain#id-1">SpringCloudCustomDomain#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SpringCloudCustomDomainState<'Name, 'SpringCloudAppId>, value: string) : SpringCloudCustomDomainState<'Name, 'SpringCloudAppId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SpringCloudCustomDomainState<'Name, 'SpringCloudAppId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_custom_domain#thumbprint-1">SpringCloudCustomDomain#thumbprint</a>.
        /// </summary>
        [<CustomOperation "thumbprint">]
        member _.Thumbprint(state: SpringCloudCustomDomainState<'Name, 'SpringCloudAppId>, value: string) : SpringCloudCustomDomainState<'Name, 'SpringCloudAppId> =
            state.assignments.Add(fun config -> config.Thumbprint <- value)
            state : SpringCloudCustomDomainState<'Name, 'SpringCloudAppId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_custom_domain#timeouts-1">SpringCloudCustomDomain#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SpringCloudCustomDomainState<'Name, 'SpringCloudAppId>, value: azurerm.SpringCloudCustomDomain.SpringCloudCustomDomainTimeouts) : SpringCloudCustomDomainState<'Name, 'SpringCloudAppId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SpringCloudCustomDomainState<'Name, 'SpringCloudAppId>

        member _.Run(state: SpringCloudCustomDomainState<Present, Present>) : azurerm.SpringCloudCustomDomain.SpringCloudCustomDomain =
            let config = azurerm.SpringCloudCustomDomain.SpringCloudCustomDomainConfig()
            for setter in state.assignments do
                setter config
            azurerm.SpringCloudCustomDomain.SpringCloudCustomDomain(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.springCloudCustomDomain: missing required arguments. Must call: name, spring_cloud_app_id.", 9999, IsError = true)>]
        member _.Run(_: SpringCloudCustomDomainState<_, _>) : azurerm.SpringCloudCustomDomain.SpringCloudCustomDomain =
            Unchecked.defaultof<azurerm.SpringCloudCustomDomain.SpringCloudCustomDomain>

namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CdnEndpointCustomDomainState<'CdnEndpointId, 'HostName, 'Name> = { assignments: ResizeArray<azurerm.CdnEndpointCustomDomain.CdnEndpointCustomDomainConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint_custom_domain">azurerm_cdn_endpoint_custom_domain</a>.
    /// </summary>
    type CdnEndpointCustomDomainBuilder(logicalId: string) =
        member _.Yield(_: unit) : CdnEndpointCustomDomainState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CdnEndpointCustomDomainState<Missing, Missing, Missing>)

        member _.Zero(()) : CdnEndpointCustomDomainState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CdnEndpointCustomDomainState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint_custom_domain#cdn_endpoint_id-1">CdnEndpointCustomDomain#cdn_endpoint_id</a>.
        /// </summary>
        [<CustomOperation "cdn_endpoint_id">]
        member _.CdnEndpointId(state: CdnEndpointCustomDomainState<Missing, 'HostName, 'Name>, value: string) : CdnEndpointCustomDomainState<Present, 'HostName, 'Name> =
            state.assignments.Add(fun config -> config.CdnEndpointId <- value)
            ({ assignments = state.assignments } : CdnEndpointCustomDomainState<Present, 'HostName, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint_custom_domain#host_name-1">CdnEndpointCustomDomain#host_name</a>.
        /// </summary>
        [<CustomOperation "host_name">]
        member _.HostName(state: CdnEndpointCustomDomainState<'CdnEndpointId, Missing, 'Name>, value: string) : CdnEndpointCustomDomainState<'CdnEndpointId, Present, 'Name> =
            state.assignments.Add(fun config -> config.HostName <- value)
            ({ assignments = state.assignments } : CdnEndpointCustomDomainState<'CdnEndpointId, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint_custom_domain#name-1">CdnEndpointCustomDomain#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: CdnEndpointCustomDomainState<'CdnEndpointId, 'HostName, Missing>, value: string) : CdnEndpointCustomDomainState<'CdnEndpointId, 'HostName, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : CdnEndpointCustomDomainState<'CdnEndpointId, 'HostName, Present>)

        /// <summary>
        /// cdn_managed_https block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint_custom_domain#cdn_managed_https-1">CdnEndpointCustomDomain#cdn_managed_https</a>
        /// </summary>
        [<CustomOperation "cdn_managed_https">]
        member _.CdnManagedHttps(state: CdnEndpointCustomDomainState<'CdnEndpointId, 'HostName, 'Name>, value: azurerm.CdnEndpointCustomDomain.CdnEndpointCustomDomainCdnManagedHttps) : CdnEndpointCustomDomainState<'CdnEndpointId, 'HostName, 'Name> =
            state.assignments.Add(fun config -> config.CdnManagedHttps <- value)
            state : CdnEndpointCustomDomainState<'CdnEndpointId, 'HostName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint_custom_domain#id-1">CdnEndpointCustomDomain#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CdnEndpointCustomDomainState<'CdnEndpointId, 'HostName, 'Name>, value: string) : CdnEndpointCustomDomainState<'CdnEndpointId, 'HostName, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CdnEndpointCustomDomainState<'CdnEndpointId, 'HostName, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint_custom_domain#timeouts-1">CdnEndpointCustomDomain#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: CdnEndpointCustomDomainState<'CdnEndpointId, 'HostName, 'Name>, value: azurerm.CdnEndpointCustomDomain.CdnEndpointCustomDomainTimeouts) : CdnEndpointCustomDomainState<'CdnEndpointId, 'HostName, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : CdnEndpointCustomDomainState<'CdnEndpointId, 'HostName, 'Name>

        /// <summary>
        /// user_managed_https block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint_custom_domain#user_managed_https-1">CdnEndpointCustomDomain#user_managed_https</a>
        /// </summary>
        [<CustomOperation "user_managed_https">]
        member _.UserManagedHttps(state: CdnEndpointCustomDomainState<'CdnEndpointId, 'HostName, 'Name>, value: azurerm.CdnEndpointCustomDomain.CdnEndpointCustomDomainUserManagedHttps) : CdnEndpointCustomDomainState<'CdnEndpointId, 'HostName, 'Name> =
            state.assignments.Add(fun config -> config.UserManagedHttps <- value)
            state : CdnEndpointCustomDomainState<'CdnEndpointId, 'HostName, 'Name>

        member _.Run(state: CdnEndpointCustomDomainState<Present, Present, Present>) : azurerm.CdnEndpointCustomDomain.CdnEndpointCustomDomain =
            let config = azurerm.CdnEndpointCustomDomain.CdnEndpointCustomDomainConfig()
            for setter in state.assignments do
                setter config
            azurerm.CdnEndpointCustomDomain.CdnEndpointCustomDomain(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.cdnEndpointCustomDomain: missing required arguments. Must call: cdn_endpoint_id, host_name, name.", 9999, IsError = true)>]
        member _.Run(_: CdnEndpointCustomDomainState<_, _, _>) : azurerm.CdnEndpointCustomDomain.CdnEndpointCustomDomain =
            Unchecked.defaultof<azurerm.CdnEndpointCustomDomain.CdnEndpointCustomDomain>

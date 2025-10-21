namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ActiveDirectoryDomainServiceTrustState<'DomainServiceId, 'Name, 'Password, 'TrustedDomainDnsIps, 'TrustedDomainFqdn> = { assignments: ResizeArray<azurerm.ActiveDirectoryDomainServiceTrust.ActiveDirectoryDomainServiceTrustConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/active_directory_domain_service_trust">azurerm_active_directory_domain_service_trust</a>.
    /// </summary>
    type ActiveDirectoryDomainServiceTrustBuilder(logicalId: string) =
        member _.Yield(_: unit) : ActiveDirectoryDomainServiceTrustState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ActiveDirectoryDomainServiceTrustState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ActiveDirectoryDomainServiceTrustState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ActiveDirectoryDomainServiceTrustState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/active_directory_domain_service_trust#domain_service_id-1">ActiveDirectoryDomainServiceTrust#domain_service_id</a>.
        /// </summary>
        [<CustomOperation "domain_service_id">]
        member _.DomainServiceId(state: ActiveDirectoryDomainServiceTrustState<Missing, 'Name, 'Password, 'TrustedDomainDnsIps, 'TrustedDomainFqdn>, value: string) : ActiveDirectoryDomainServiceTrustState<Present, 'Name, 'Password, 'TrustedDomainDnsIps, 'TrustedDomainFqdn> =
            state.assignments.Add(fun config -> config.DomainServiceId <- value)
            ({ assignments = state.assignments } : ActiveDirectoryDomainServiceTrustState<Present, 'Name, 'Password, 'TrustedDomainDnsIps, 'TrustedDomainFqdn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/active_directory_domain_service_trust#name-1">ActiveDirectoryDomainServiceTrust#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ActiveDirectoryDomainServiceTrustState<'DomainServiceId, Missing, 'Password, 'TrustedDomainDnsIps, 'TrustedDomainFqdn>, value: string) : ActiveDirectoryDomainServiceTrustState<'DomainServiceId, Present, 'Password, 'TrustedDomainDnsIps, 'TrustedDomainFqdn> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ActiveDirectoryDomainServiceTrustState<'DomainServiceId, Present, 'Password, 'TrustedDomainDnsIps, 'TrustedDomainFqdn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/active_directory_domain_service_trust#password-1">ActiveDirectoryDomainServiceTrust#password</a>.
        /// </summary>
        [<CustomOperation "password">]
        member _.Password(state: ActiveDirectoryDomainServiceTrustState<'DomainServiceId, 'Name, Missing, 'TrustedDomainDnsIps, 'TrustedDomainFqdn>, value: string) : ActiveDirectoryDomainServiceTrustState<'DomainServiceId, 'Name, Present, 'TrustedDomainDnsIps, 'TrustedDomainFqdn> =
            state.assignments.Add(fun config -> config.Password <- value)
            ({ assignments = state.assignments } : ActiveDirectoryDomainServiceTrustState<'DomainServiceId, 'Name, Present, 'TrustedDomainDnsIps, 'TrustedDomainFqdn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/active_directory_domain_service_trust#trusted_domain_dns_ips-1">ActiveDirectoryDomainServiceTrust#trusted_domain_dns_ips</a>.
        /// </summary>
        [<CustomOperation "trusted_domain_dns_ips">]
        member _.TrustedDomainDnsIps(state: ActiveDirectoryDomainServiceTrustState<'DomainServiceId, 'Name, 'Password, Missing, 'TrustedDomainFqdn>, value: seq<string>) : ActiveDirectoryDomainServiceTrustState<'DomainServiceId, 'Name, 'Password, Present, 'TrustedDomainFqdn> =
            state.assignments.Add(fun config -> config.TrustedDomainDnsIps <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : ActiveDirectoryDomainServiceTrustState<'DomainServiceId, 'Name, 'Password, Present, 'TrustedDomainFqdn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/active_directory_domain_service_trust#trusted_domain_fqdn-1">ActiveDirectoryDomainServiceTrust#trusted_domain_fqdn</a>.
        /// </summary>
        [<CustomOperation "trusted_domain_fqdn">]
        member _.TrustedDomainFqdn(state: ActiveDirectoryDomainServiceTrustState<'DomainServiceId, 'Name, 'Password, 'TrustedDomainDnsIps, Missing>, value: string) : ActiveDirectoryDomainServiceTrustState<'DomainServiceId, 'Name, 'Password, 'TrustedDomainDnsIps, Present> =
            state.assignments.Add(fun config -> config.TrustedDomainFqdn <- value)
            ({ assignments = state.assignments } : ActiveDirectoryDomainServiceTrustState<'DomainServiceId, 'Name, 'Password, 'TrustedDomainDnsIps, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/active_directory_domain_service_trust#id-1">ActiveDirectoryDomainServiceTrust#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ActiveDirectoryDomainServiceTrustState<'DomainServiceId, 'Name, 'Password, 'TrustedDomainDnsIps, 'TrustedDomainFqdn>, value: string) : ActiveDirectoryDomainServiceTrustState<'DomainServiceId, 'Name, 'Password, 'TrustedDomainDnsIps, 'TrustedDomainFqdn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ActiveDirectoryDomainServiceTrustState<'DomainServiceId, 'Name, 'Password, 'TrustedDomainDnsIps, 'TrustedDomainFqdn>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/active_directory_domain_service_trust#timeouts-1">ActiveDirectoryDomainServiceTrust#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ActiveDirectoryDomainServiceTrustState<'DomainServiceId, 'Name, 'Password, 'TrustedDomainDnsIps, 'TrustedDomainFqdn>, value: azurerm.ActiveDirectoryDomainServiceTrust.ActiveDirectoryDomainServiceTrustTimeouts) : ActiveDirectoryDomainServiceTrustState<'DomainServiceId, 'Name, 'Password, 'TrustedDomainDnsIps, 'TrustedDomainFqdn> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ActiveDirectoryDomainServiceTrustState<'DomainServiceId, 'Name, 'Password, 'TrustedDomainDnsIps, 'TrustedDomainFqdn>

        member _.Run(state: ActiveDirectoryDomainServiceTrustState<Present, Present, Present, Present, Present>) : azurerm.ActiveDirectoryDomainServiceTrust.ActiveDirectoryDomainServiceTrust =
            let config = azurerm.ActiveDirectoryDomainServiceTrust.ActiveDirectoryDomainServiceTrustConfig()
            for setter in state.assignments do
                setter config
            azurerm.ActiveDirectoryDomainServiceTrust.ActiveDirectoryDomainServiceTrust(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.activeDirectoryDomainServiceTrust: missing required arguments. Must call: domain_service_id, name, password, trusted_domain_dns_ips, trusted_domain_fqdn.", 9999, IsError = true)>]
        member _.Run(_: ActiveDirectoryDomainServiceTrustState<_, _, _, _, _>) : azurerm.ActiveDirectoryDomainServiceTrust.ActiveDirectoryDomainServiceTrust =
            Unchecked.defaultof<azurerm.ActiveDirectoryDomainServiceTrust.ActiveDirectoryDomainServiceTrust>

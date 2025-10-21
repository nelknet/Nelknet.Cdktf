namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VpnServerConfigurationState<'Location, 'Name, 'ResourceGroupName, 'VpnAuthenticationTypes> = { assignments: ResizeArray<azurerm.VpnServerConfiguration.VpnServerConfigurationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_server_configuration">azurerm_vpn_server_configuration</a>.
    /// </summary>
    type VpnServerConfigurationBuilder(logicalId: string) =
        member _.Yield(_: unit) : VpnServerConfigurationState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : VpnServerConfigurationState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : VpnServerConfigurationState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : VpnServerConfigurationState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_server_configuration#location-1">VpnServerConfiguration#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: VpnServerConfigurationState<Missing, 'Name, 'ResourceGroupName, 'VpnAuthenticationTypes>, value: string) : VpnServerConfigurationState<Present, 'Name, 'ResourceGroupName, 'VpnAuthenticationTypes> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : VpnServerConfigurationState<Present, 'Name, 'ResourceGroupName, 'VpnAuthenticationTypes>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_server_configuration#name-1">VpnServerConfiguration#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: VpnServerConfigurationState<'Location, Missing, 'ResourceGroupName, 'VpnAuthenticationTypes>, value: string) : VpnServerConfigurationState<'Location, Present, 'ResourceGroupName, 'VpnAuthenticationTypes> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : VpnServerConfigurationState<'Location, Present, 'ResourceGroupName, 'VpnAuthenticationTypes>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_server_configuration#resource_group_name-1">VpnServerConfiguration#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: VpnServerConfigurationState<'Location, 'Name, Missing, 'VpnAuthenticationTypes>, value: string) : VpnServerConfigurationState<'Location, 'Name, Present, 'VpnAuthenticationTypes> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : VpnServerConfigurationState<'Location, 'Name, Present, 'VpnAuthenticationTypes>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_server_configuration#vpn_authentication_types-1">VpnServerConfiguration#vpn_authentication_types</a>.
        /// </summary>
        [<CustomOperation "vpn_authentication_types">]
        member _.VpnAuthenticationTypes(state: VpnServerConfigurationState<'Location, 'Name, 'ResourceGroupName, Missing>, value: seq<string>) : VpnServerConfigurationState<'Location, 'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.VpnAuthenticationTypes <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : VpnServerConfigurationState<'Location, 'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// azure_active_directory_authentication block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_server_configuration#azure_active_directory_authentication-1">VpnServerConfiguration#azure_active_directory_authentication</a> Accepts: azurerm.IResolvable | azurerm.VpnServerConfiguration.VpnServerConfigurationAzureActiveDirectoryAuthentication[]
        /// </summary>
        [<CustomOperation "azure_active_directory_authentication">]
        member _.AzureActiveDirectoryAuthentication(state: VpnServerConfigurationState<'Location, 'Name, 'ResourceGroupName, 'VpnAuthenticationTypes>, value: HashiCorp.Cdktf.IResolvable) : VpnServerConfigurationState<'Location, 'Name, 'ResourceGroupName, 'VpnAuthenticationTypes> =
            state.assignments.Add(fun config -> config.AzureActiveDirectoryAuthentication <- value)
            state : VpnServerConfigurationState<'Location, 'Name, 'ResourceGroupName, 'VpnAuthenticationTypes>

        /// <summary>
        /// client_revoked_certificate block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_server_configuration#client_revoked_certificate-1">VpnServerConfiguration#client_revoked_certificate</a> Accepts: azurerm.IResolvable | azurerm.VpnServerConfiguration.VpnServerConfigurationClientRevokedCertificate[]
        /// </summary>
        [<CustomOperation "client_revoked_certificate">]
        member _.ClientRevokedCertificate(state: VpnServerConfigurationState<'Location, 'Name, 'ResourceGroupName, 'VpnAuthenticationTypes>, value: HashiCorp.Cdktf.IResolvable) : VpnServerConfigurationState<'Location, 'Name, 'ResourceGroupName, 'VpnAuthenticationTypes> =
            state.assignments.Add(fun config -> config.ClientRevokedCertificate <- value)
            state : VpnServerConfigurationState<'Location, 'Name, 'ResourceGroupName, 'VpnAuthenticationTypes>

        /// <summary>
        /// client_root_certificate block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_server_configuration#client_root_certificate-1">VpnServerConfiguration#client_root_certificate</a> Accepts: azurerm.IResolvable | azurerm.VpnServerConfiguration.VpnServerConfigurationClientRootCertificate[]
        /// </summary>
        [<CustomOperation "client_root_certificate">]
        member _.ClientRootCertificate(state: VpnServerConfigurationState<'Location, 'Name, 'ResourceGroupName, 'VpnAuthenticationTypes>, value: HashiCorp.Cdktf.IResolvable) : VpnServerConfigurationState<'Location, 'Name, 'ResourceGroupName, 'VpnAuthenticationTypes> =
            state.assignments.Add(fun config -> config.ClientRootCertificate <- value)
            state : VpnServerConfigurationState<'Location, 'Name, 'ResourceGroupName, 'VpnAuthenticationTypes>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_server_configuration#id-1">VpnServerConfiguration#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VpnServerConfigurationState<'Location, 'Name, 'ResourceGroupName, 'VpnAuthenticationTypes>, value: string) : VpnServerConfigurationState<'Location, 'Name, 'ResourceGroupName, 'VpnAuthenticationTypes> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VpnServerConfigurationState<'Location, 'Name, 'ResourceGroupName, 'VpnAuthenticationTypes>

        /// <summary>
        /// ipsec_policy block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_server_configuration#ipsec_policy-1">VpnServerConfiguration#ipsec_policy</a>
        /// </summary>
        [<CustomOperation "ipsec_policy">]
        member _.IpsecPolicy(state: VpnServerConfigurationState<'Location, 'Name, 'ResourceGroupName, 'VpnAuthenticationTypes>, value: azurerm.VpnServerConfiguration.VpnServerConfigurationIpsecPolicy) : VpnServerConfigurationState<'Location, 'Name, 'ResourceGroupName, 'VpnAuthenticationTypes> =
            state.assignments.Add(fun config -> config.IpsecPolicy <- value)
            state : VpnServerConfigurationState<'Location, 'Name, 'ResourceGroupName, 'VpnAuthenticationTypes>

        /// <summary>
        /// radius block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_server_configuration#radius-1">VpnServerConfiguration#radius</a>
        /// </summary>
        [<CustomOperation "radius">]
        member _.Radius(state: VpnServerConfigurationState<'Location, 'Name, 'ResourceGroupName, 'VpnAuthenticationTypes>, value: azurerm.VpnServerConfiguration.VpnServerConfigurationRadius) : VpnServerConfigurationState<'Location, 'Name, 'ResourceGroupName, 'VpnAuthenticationTypes> =
            state.assignments.Add(fun config -> config.Radius <- value)
            state : VpnServerConfigurationState<'Location, 'Name, 'ResourceGroupName, 'VpnAuthenticationTypes>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_server_configuration#tags-1">VpnServerConfiguration#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: VpnServerConfigurationState<'Location, 'Name, 'ResourceGroupName, 'VpnAuthenticationTypes>, value: seq<string * string>) : VpnServerConfigurationState<'Location, 'Name, 'ResourceGroupName, 'VpnAuthenticationTypes> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : VpnServerConfigurationState<'Location, 'Name, 'ResourceGroupName, 'VpnAuthenticationTypes>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_server_configuration#timeouts-1">VpnServerConfiguration#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: VpnServerConfigurationState<'Location, 'Name, 'ResourceGroupName, 'VpnAuthenticationTypes>, value: azurerm.VpnServerConfiguration.VpnServerConfigurationTimeouts) : VpnServerConfigurationState<'Location, 'Name, 'ResourceGroupName, 'VpnAuthenticationTypes> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : VpnServerConfigurationState<'Location, 'Name, 'ResourceGroupName, 'VpnAuthenticationTypes>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_server_configuration#vpn_protocols-1">VpnServerConfiguration#vpn_protocols</a>.
        /// </summary>
        [<CustomOperation "vpn_protocols">]
        member _.VpnProtocols(state: VpnServerConfigurationState<'Location, 'Name, 'ResourceGroupName, 'VpnAuthenticationTypes>, value: seq<string>) : VpnServerConfigurationState<'Location, 'Name, 'ResourceGroupName, 'VpnAuthenticationTypes> =
            state.assignments.Add(fun config -> config.VpnProtocols <- (value |> Seq.toArray))
            state : VpnServerConfigurationState<'Location, 'Name, 'ResourceGroupName, 'VpnAuthenticationTypes>

        member _.Run(state: VpnServerConfigurationState<Present, Present, Present, Present>) : azurerm.VpnServerConfiguration.VpnServerConfiguration =
            let config = azurerm.VpnServerConfiguration.VpnServerConfigurationConfig()
            for setter in state.assignments do
                setter config
            azurerm.VpnServerConfiguration.VpnServerConfiguration(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.vpnServerConfiguration: missing required arguments. Must call: location, name, resource_group_name, vpn_authentication_types.", 9999, IsError = true)>]
        member _.Run(_: VpnServerConfigurationState<_, _, _, _>) : azurerm.VpnServerConfiguration.VpnServerConfiguration =
            Unchecked.defaultof<azurerm.VpnServerConfiguration.VpnServerConfiguration>

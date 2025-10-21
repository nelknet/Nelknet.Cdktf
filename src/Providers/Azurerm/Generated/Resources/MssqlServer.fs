namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MssqlServerState<'Location, 'Name, 'ResourceGroupName, 'Version> = { assignments: ResizeArray<azurerm.MssqlServer.MssqlServerConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_server">azurerm_mssql_server</a>.
    /// </summary>
    type MssqlServerBuilder(logicalId: string) =
        member _.Yield(_: unit) : MssqlServerState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MssqlServerState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : MssqlServerState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MssqlServerState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_server#location-1">MssqlServer#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: MssqlServerState<Missing, 'Name, 'ResourceGroupName, 'Version>, value: string) : MssqlServerState<Present, 'Name, 'ResourceGroupName, 'Version> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : MssqlServerState<Present, 'Name, 'ResourceGroupName, 'Version>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_server#name-1">MssqlServer#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: MssqlServerState<'Location, Missing, 'ResourceGroupName, 'Version>, value: string) : MssqlServerState<'Location, Present, 'ResourceGroupName, 'Version> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : MssqlServerState<'Location, Present, 'ResourceGroupName, 'Version>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_server#resource_group_name-1">MssqlServer#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: MssqlServerState<'Location, 'Name, Missing, 'Version>, value: string) : MssqlServerState<'Location, 'Name, Present, 'Version> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : MssqlServerState<'Location, 'Name, Present, 'Version>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_server#version-1">MssqlServer#version</a>.
        /// </summary>
        [<CustomOperation "version">]
        member _.Version(state: MssqlServerState<'Location, 'Name, 'ResourceGroupName, Missing>, value: string) : MssqlServerState<'Location, 'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.Version <- value)
            ({ assignments = state.assignments } : MssqlServerState<'Location, 'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_server#administrator_login-1">MssqlServer#administrator_login</a>.
        /// </summary>
        [<CustomOperation "administrator_login">]
        member _.AdministratorLogin(state: MssqlServerState<'Location, 'Name, 'ResourceGroupName, 'Version>, value: string) : MssqlServerState<'Location, 'Name, 'ResourceGroupName, 'Version> =
            state.assignments.Add(fun config -> config.AdministratorLogin <- value)
            state : MssqlServerState<'Location, 'Name, 'ResourceGroupName, 'Version>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_server#administrator_login_password-1">MssqlServer#administrator_login_password</a>.
        /// </summary>
        [<CustomOperation "administrator_login_password">]
        member _.AdministratorLoginPassword(state: MssqlServerState<'Location, 'Name, 'ResourceGroupName, 'Version>, value: string) : MssqlServerState<'Location, 'Name, 'ResourceGroupName, 'Version> =
            state.assignments.Add(fun config -> config.AdministratorLoginPassword <- value)
            state : MssqlServerState<'Location, 'Name, 'ResourceGroupName, 'Version>

        /// <summary>
        /// azuread_administrator block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_server#azuread_administrator-1">MssqlServer#azuread_administrator</a>
        /// </summary>
        [<CustomOperation "azuread_administrator">]
        member _.AzureadAdministrator(state: MssqlServerState<'Location, 'Name, 'ResourceGroupName, 'Version>, value: azurerm.MssqlServer.MssqlServerAzureadAdministrator) : MssqlServerState<'Location, 'Name, 'ResourceGroupName, 'Version> =
            state.assignments.Add(fun config -> config.AzureadAdministrator <- value)
            state : MssqlServerState<'Location, 'Name, 'ResourceGroupName, 'Version>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_server#connection_policy-1">MssqlServer#connection_policy</a>.
        /// </summary>
        [<CustomOperation "connection_policy">]
        member _.ConnectionPolicy(state: MssqlServerState<'Location, 'Name, 'ResourceGroupName, 'Version>, value: string) : MssqlServerState<'Location, 'Name, 'ResourceGroupName, 'Version> =
            state.assignments.Add(fun config -> config.ConnectionPolicy <- value)
            state : MssqlServerState<'Location, 'Name, 'ResourceGroupName, 'Version>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_server#id-1">MssqlServer#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MssqlServerState<'Location, 'Name, 'ResourceGroupName, 'Version>, value: string) : MssqlServerState<'Location, 'Name, 'ResourceGroupName, 'Version> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MssqlServerState<'Location, 'Name, 'ResourceGroupName, 'Version>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_server#identity-1">MssqlServer#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: MssqlServerState<'Location, 'Name, 'ResourceGroupName, 'Version>, value: azurerm.MssqlServer.MssqlServerIdentity) : MssqlServerState<'Location, 'Name, 'ResourceGroupName, 'Version> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : MssqlServerState<'Location, 'Name, 'ResourceGroupName, 'Version>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_server#minimum_tls_version-1">MssqlServer#minimum_tls_version</a>.
        /// </summary>
        [<CustomOperation "minimum_tls_version">]
        member _.MinimumTlsVersion(state: MssqlServerState<'Location, 'Name, 'ResourceGroupName, 'Version>, value: string) : MssqlServerState<'Location, 'Name, 'ResourceGroupName, 'Version> =
            state.assignments.Add(fun config -> config.MinimumTlsVersion <- value)
            state : MssqlServerState<'Location, 'Name, 'ResourceGroupName, 'Version>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_server#outbound_network_restriction_enabled-1">MssqlServer#outbound_network_restriction_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "outbound_network_restriction_enabled">]
        member _.OutboundNetworkRestrictionEnabled(state: MssqlServerState<'Location, 'Name, 'ResourceGroupName, 'Version>, value: bool) : MssqlServerState<'Location, 'Name, 'ResourceGroupName, 'Version> =
            state.assignments.Add(fun config -> config.OutboundNetworkRestrictionEnabled <- value)
            state : MssqlServerState<'Location, 'Name, 'ResourceGroupName, 'Version>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_server#outbound_network_restriction_enabled-1">MssqlServer#outbound_network_restriction_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "outbound_network_restriction_enabled">]
        member _.OutboundNetworkRestrictionEnabled(state: MssqlServerState<'Location, 'Name, 'ResourceGroupName, 'Version>, value: HashiCorp.Cdktf.IResolvable) : MssqlServerState<'Location, 'Name, 'ResourceGroupName, 'Version> =
            state.assignments.Add(fun config -> config.OutboundNetworkRestrictionEnabled <- value)
            state : MssqlServerState<'Location, 'Name, 'ResourceGroupName, 'Version>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_server#primary_user_assigned_identity_id-1">MssqlServer#primary_user_assigned_identity_id</a>.
        /// </summary>
        [<CustomOperation "primary_user_assigned_identity_id">]
        member _.PrimaryUserAssignedIdentityId(state: MssqlServerState<'Location, 'Name, 'ResourceGroupName, 'Version>, value: string) : MssqlServerState<'Location, 'Name, 'ResourceGroupName, 'Version> =
            state.assignments.Add(fun config -> config.PrimaryUserAssignedIdentityId <- value)
            state : MssqlServerState<'Location, 'Name, 'ResourceGroupName, 'Version>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_server#public_network_access_enabled-1">MssqlServer#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: MssqlServerState<'Location, 'Name, 'ResourceGroupName, 'Version>, value: bool) : MssqlServerState<'Location, 'Name, 'ResourceGroupName, 'Version> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            state : MssqlServerState<'Location, 'Name, 'ResourceGroupName, 'Version>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_server#public_network_access_enabled-1">MssqlServer#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: MssqlServerState<'Location, 'Name, 'ResourceGroupName, 'Version>, value: HashiCorp.Cdktf.IResolvable) : MssqlServerState<'Location, 'Name, 'ResourceGroupName, 'Version> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            state : MssqlServerState<'Location, 'Name, 'ResourceGroupName, 'Version>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_server#tags-1">MssqlServer#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: MssqlServerState<'Location, 'Name, 'ResourceGroupName, 'Version>, value: seq<string * string>) : MssqlServerState<'Location, 'Name, 'ResourceGroupName, 'Version> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : MssqlServerState<'Location, 'Name, 'ResourceGroupName, 'Version>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_server#timeouts-1">MssqlServer#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: MssqlServerState<'Location, 'Name, 'ResourceGroupName, 'Version>, value: azurerm.MssqlServer.MssqlServerTimeouts) : MssqlServerState<'Location, 'Name, 'ResourceGroupName, 'Version> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : MssqlServerState<'Location, 'Name, 'ResourceGroupName, 'Version>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_server#transparent_data_encryption_key_vault_key_id-1">MssqlServer#transparent_data_encryption_key_vault_key_id</a>.
        /// </summary>
        [<CustomOperation "transparent_data_encryption_key_vault_key_id">]
        member _.TransparentDataEncryptionKeyVaultKeyId(state: MssqlServerState<'Location, 'Name, 'ResourceGroupName, 'Version>, value: string) : MssqlServerState<'Location, 'Name, 'ResourceGroupName, 'Version> =
            state.assignments.Add(fun config -> config.TransparentDataEncryptionKeyVaultKeyId <- value)
            state : MssqlServerState<'Location, 'Name, 'ResourceGroupName, 'Version>

        member _.Run(state: MssqlServerState<Present, Present, Present, Present>) : azurerm.MssqlServer.MssqlServer =
            let config = azurerm.MssqlServer.MssqlServerConfig()
            for setter in state.assignments do
                setter config
            azurerm.MssqlServer.MssqlServer(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.mssqlServer: missing required arguments. Must call: location, name, resource_group_name, version.", 9999, IsError = true)>]
        member _.Run(_: MssqlServerState<_, _, _, _>) : azurerm.MssqlServer.MssqlServer =
            Unchecked.defaultof<azurerm.MssqlServer.MssqlServer>

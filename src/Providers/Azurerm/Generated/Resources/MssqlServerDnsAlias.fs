namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MssqlServerDnsAliasState<'MssqlServerId, 'Name> = { assignments: ResizeArray<azurerm.MssqlServerDnsAlias.MssqlServerDnsAliasConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_server_dns_alias">azurerm_mssql_server_dns_alias</a>.
    /// </summary>
    type MssqlServerDnsAliasBuilder(logicalId: string) =
        member _.Yield(_: unit) : MssqlServerDnsAliasState<Missing, Missing> =
            ({ assignments = ResizeArray() } : MssqlServerDnsAliasState<Missing, Missing>)

        member _.Zero(()) : MssqlServerDnsAliasState<Missing, Missing> =
            ({ assignments = ResizeArray() } : MssqlServerDnsAliasState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_server_dns_alias#mssql_server_id-1">MssqlServerDnsAlias#mssql_server_id</a>.
        /// </summary>
        [<CustomOperation "mssql_server_id">]
        member _.MssqlServerId(state: MssqlServerDnsAliasState<Missing, 'Name>, value: string) : MssqlServerDnsAliasState<Present, 'Name> =
            state.assignments.Add(fun config -> config.MssqlServerId <- value)
            ({ assignments = state.assignments } : MssqlServerDnsAliasState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_server_dns_alias#name-1">MssqlServerDnsAlias#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: MssqlServerDnsAliasState<'MssqlServerId, Missing>, value: string) : MssqlServerDnsAliasState<'MssqlServerId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : MssqlServerDnsAliasState<'MssqlServerId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_server_dns_alias#id-1">MssqlServerDnsAlias#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MssqlServerDnsAliasState<'MssqlServerId, 'Name>, value: string) : MssqlServerDnsAliasState<'MssqlServerId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MssqlServerDnsAliasState<'MssqlServerId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_server_dns_alias#timeouts-1">MssqlServerDnsAlias#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: MssqlServerDnsAliasState<'MssqlServerId, 'Name>, value: azurerm.MssqlServerDnsAlias.MssqlServerDnsAliasTimeouts) : MssqlServerDnsAliasState<'MssqlServerId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : MssqlServerDnsAliasState<'MssqlServerId, 'Name>

        member _.Run(state: MssqlServerDnsAliasState<Present, Present>) : azurerm.MssqlServerDnsAlias.MssqlServerDnsAlias =
            let config = azurerm.MssqlServerDnsAlias.MssqlServerDnsAliasConfig()
            for setter in state.assignments do
                setter config
            azurerm.MssqlServerDnsAlias.MssqlServerDnsAlias(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.mssqlServerDnsAlias: missing required arguments. Must call: mssql_server_id, name.", 9999, IsError = true)>]
        member _.Run(_: MssqlServerDnsAliasState<_, _>) : azurerm.MssqlServerDnsAlias.MssqlServerDnsAlias =
            Unchecked.defaultof<azurerm.MssqlServerDnsAlias.MssqlServerDnsAlias>

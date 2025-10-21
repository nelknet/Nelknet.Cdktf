namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type PostgresqlServerKeyState<'KeyVaultKeyId, 'ServerId> = { assignments: ResizeArray<azurerm.PostgresqlServerKey.PostgresqlServerKeyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_server_key">azurerm_postgresql_server_key</a>.
    /// </summary>
    type PostgresqlServerKeyBuilder(logicalId: string) =
        member _.Yield(_: unit) : PostgresqlServerKeyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : PostgresqlServerKeyState<Missing, Missing>)

        member _.Zero(()) : PostgresqlServerKeyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : PostgresqlServerKeyState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_server_key#key_vault_key_id-1">PostgresqlServerKey#key_vault_key_id</a>.
        /// </summary>
        [<CustomOperation "key_vault_key_id">]
        member _.KeyVaultKeyId(state: PostgresqlServerKeyState<Missing, 'ServerId>, value: string) : PostgresqlServerKeyState<Present, 'ServerId> =
            state.assignments.Add(fun config -> config.KeyVaultKeyId <- value)
            ({ assignments = state.assignments } : PostgresqlServerKeyState<Present, 'ServerId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_server_key#server_id-1">PostgresqlServerKey#server_id</a>.
        /// </summary>
        [<CustomOperation "server_id">]
        member _.ServerId(state: PostgresqlServerKeyState<'KeyVaultKeyId, Missing>, value: string) : PostgresqlServerKeyState<'KeyVaultKeyId, Present> =
            state.assignments.Add(fun config -> config.ServerId <- value)
            ({ assignments = state.assignments } : PostgresqlServerKeyState<'KeyVaultKeyId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_server_key#id-1">PostgresqlServerKey#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: PostgresqlServerKeyState<'KeyVaultKeyId, 'ServerId>, value: string) : PostgresqlServerKeyState<'KeyVaultKeyId, 'ServerId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : PostgresqlServerKeyState<'KeyVaultKeyId, 'ServerId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_server_key#timeouts-1">PostgresqlServerKey#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: PostgresqlServerKeyState<'KeyVaultKeyId, 'ServerId>, value: azurerm.PostgresqlServerKey.PostgresqlServerKeyTimeouts) : PostgresqlServerKeyState<'KeyVaultKeyId, 'ServerId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : PostgresqlServerKeyState<'KeyVaultKeyId, 'ServerId>

        member _.Run(state: PostgresqlServerKeyState<Present, Present>) : azurerm.PostgresqlServerKey.PostgresqlServerKey =
            let config = azurerm.PostgresqlServerKey.PostgresqlServerKeyConfig()
            for setter in state.assignments do
                setter config
            azurerm.PostgresqlServerKey.PostgresqlServerKey(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.postgresqlServerKey: missing required arguments. Must call: key_vault_key_id, server_id.", 9999, IsError = true)>]
        member _.Run(_: PostgresqlServerKeyState<_, _>) : azurerm.PostgresqlServerKey.PostgresqlServerKey =
            Unchecked.defaultof<azurerm.PostgresqlServerKey.PostgresqlServerKey>

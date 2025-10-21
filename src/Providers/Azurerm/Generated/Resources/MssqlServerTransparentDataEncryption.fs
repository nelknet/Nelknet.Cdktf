namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MssqlServerTransparentDataEncryptionState<'ServerId> = { assignments: ResizeArray<azurerm.MssqlServerTransparentDataEncryption.MssqlServerTransparentDataEncryptionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_server_transparent_data_encryption">azurerm_mssql_server_transparent_data_encryption</a>.
    /// </summary>
    type MssqlServerTransparentDataEncryptionBuilder(logicalId: string) =
        member _.Yield(_: unit) : MssqlServerTransparentDataEncryptionState<Missing> =
            ({ assignments = ResizeArray() } : MssqlServerTransparentDataEncryptionState<Missing>)

        member _.Zero(()) : MssqlServerTransparentDataEncryptionState<Missing> =
            ({ assignments = ResizeArray() } : MssqlServerTransparentDataEncryptionState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_server_transparent_data_encryption#server_id-1">MssqlServerTransparentDataEncryption#server_id</a>.
        /// </summary>
        [<CustomOperation "server_id">]
        member _.ServerId(state: MssqlServerTransparentDataEncryptionState<Missing>, value: string) : MssqlServerTransparentDataEncryptionState<Present> =
            state.assignments.Add(fun config -> config.ServerId <- value)
            ({ assignments = state.assignments } : MssqlServerTransparentDataEncryptionState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_server_transparent_data_encryption#auto_rotation_enabled-1">MssqlServerTransparentDataEncryption#auto_rotation_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "auto_rotation_enabled">]
        member _.AutoRotationEnabled(state: MssqlServerTransparentDataEncryptionState<'ServerId>, value: bool) : MssqlServerTransparentDataEncryptionState<'ServerId> =
            state.assignments.Add(fun config -> config.AutoRotationEnabled <- value)
            state : MssqlServerTransparentDataEncryptionState<'ServerId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_server_transparent_data_encryption#auto_rotation_enabled-1">MssqlServerTransparentDataEncryption#auto_rotation_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "auto_rotation_enabled">]
        member _.AutoRotationEnabled(state: MssqlServerTransparentDataEncryptionState<'ServerId>, value: HashiCorp.Cdktf.IResolvable) : MssqlServerTransparentDataEncryptionState<'ServerId> =
            state.assignments.Add(fun config -> config.AutoRotationEnabled <- value)
            state : MssqlServerTransparentDataEncryptionState<'ServerId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_server_transparent_data_encryption#id-1">MssqlServerTransparentDataEncryption#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MssqlServerTransparentDataEncryptionState<'ServerId>, value: string) : MssqlServerTransparentDataEncryptionState<'ServerId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MssqlServerTransparentDataEncryptionState<'ServerId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_server_transparent_data_encryption#key_vault_key_id-1">MssqlServerTransparentDataEncryption#key_vault_key_id</a>.
        /// </summary>
        [<CustomOperation "key_vault_key_id">]
        member _.KeyVaultKeyId(state: MssqlServerTransparentDataEncryptionState<'ServerId>, value: string) : MssqlServerTransparentDataEncryptionState<'ServerId> =
            state.assignments.Add(fun config -> config.KeyVaultKeyId <- value)
            state : MssqlServerTransparentDataEncryptionState<'ServerId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_server_transparent_data_encryption#managed_hsm_key_id-1">MssqlServerTransparentDataEncryption#managed_hsm_key_id</a>.
        /// </summary>
        [<CustomOperation "managed_hsm_key_id">]
        member _.ManagedHsmKeyId(state: MssqlServerTransparentDataEncryptionState<'ServerId>, value: string) : MssqlServerTransparentDataEncryptionState<'ServerId> =
            state.assignments.Add(fun config -> config.ManagedHsmKeyId <- value)
            state : MssqlServerTransparentDataEncryptionState<'ServerId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_server_transparent_data_encryption#timeouts-1">MssqlServerTransparentDataEncryption#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: MssqlServerTransparentDataEncryptionState<'ServerId>, value: azurerm.MssqlServerTransparentDataEncryption.MssqlServerTransparentDataEncryptionTimeouts) : MssqlServerTransparentDataEncryptionState<'ServerId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : MssqlServerTransparentDataEncryptionState<'ServerId>

        member _.Run(state: MssqlServerTransparentDataEncryptionState<Present>) : azurerm.MssqlServerTransparentDataEncryption.MssqlServerTransparentDataEncryption =
            let config = azurerm.MssqlServerTransparentDataEncryption.MssqlServerTransparentDataEncryptionConfig()
            for setter in state.assignments do
                setter config
            azurerm.MssqlServerTransparentDataEncryption.MssqlServerTransparentDataEncryption(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.mssqlServerTransparentDataEncryption: missing required arguments. Must call: server_id.", 9999, IsError = true)>]
        member _.Run(_: MssqlServerTransparentDataEncryptionState<_>) : azurerm.MssqlServerTransparentDataEncryption.MssqlServerTransparentDataEncryption =
            Unchecked.defaultof<azurerm.MssqlServerTransparentDataEncryption.MssqlServerTransparentDataEncryption>

namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermKeyVaultEncryptedValueState<'Algorithm, 'KeyVaultKeyId> = { assignments: ResizeArray<azurerm.DataAzurermKeyVaultEncryptedValue.DataAzurermKeyVaultEncryptedValueConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/key_vault_encrypted_value">azurerm_key_vault_encrypted_value</a>.
    /// </summary>
    type DataAzurermKeyVaultEncryptedValueBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermKeyVaultEncryptedValueState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermKeyVaultEncryptedValueState<Missing, Missing>)

        member _.Zero(()) : DataAzurermKeyVaultEncryptedValueState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermKeyVaultEncryptedValueState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/key_vault_encrypted_value#algorithm-1">DataAzurermKeyVaultEncryptedValue#algorithm</a>.
        /// </summary>
        [<CustomOperation "algorithm">]
        member _.Algorithm(state: DataAzurermKeyVaultEncryptedValueState<Missing, 'KeyVaultKeyId>, value: string) : DataAzurermKeyVaultEncryptedValueState<Present, 'KeyVaultKeyId> =
            state.assignments.Add(fun config -> config.Algorithm <- value)
            ({ assignments = state.assignments } : DataAzurermKeyVaultEncryptedValueState<Present, 'KeyVaultKeyId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/key_vault_encrypted_value#key_vault_key_id-1">DataAzurermKeyVaultEncryptedValue#key_vault_key_id</a>.
        /// </summary>
        [<CustomOperation "key_vault_key_id">]
        member _.KeyVaultKeyId(state: DataAzurermKeyVaultEncryptedValueState<'Algorithm, Missing>, value: string) : DataAzurermKeyVaultEncryptedValueState<'Algorithm, Present> =
            state.assignments.Add(fun config -> config.KeyVaultKeyId <- value)
            ({ assignments = state.assignments } : DataAzurermKeyVaultEncryptedValueState<'Algorithm, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/key_vault_encrypted_value#encrypted_data-1">DataAzurermKeyVaultEncryptedValue#encrypted_data</a>.
        /// </summary>
        [<CustomOperation "encrypted_data">]
        member _.EncryptedData(state: DataAzurermKeyVaultEncryptedValueState<'Algorithm, 'KeyVaultKeyId>, value: string) : DataAzurermKeyVaultEncryptedValueState<'Algorithm, 'KeyVaultKeyId> =
            state.assignments.Add(fun config -> config.EncryptedData <- value)
            state : DataAzurermKeyVaultEncryptedValueState<'Algorithm, 'KeyVaultKeyId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/key_vault_encrypted_value#id-1">DataAzurermKeyVaultEncryptedValue#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermKeyVaultEncryptedValueState<'Algorithm, 'KeyVaultKeyId>, value: string) : DataAzurermKeyVaultEncryptedValueState<'Algorithm, 'KeyVaultKeyId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermKeyVaultEncryptedValueState<'Algorithm, 'KeyVaultKeyId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/key_vault_encrypted_value#plain_text_value-1">DataAzurermKeyVaultEncryptedValue#plain_text_value</a>.
        /// </summary>
        [<CustomOperation "plain_text_value">]
        member _.PlainTextValue(state: DataAzurermKeyVaultEncryptedValueState<'Algorithm, 'KeyVaultKeyId>, value: string) : DataAzurermKeyVaultEncryptedValueState<'Algorithm, 'KeyVaultKeyId> =
            state.assignments.Add(fun config -> config.PlainTextValue <- value)
            state : DataAzurermKeyVaultEncryptedValueState<'Algorithm, 'KeyVaultKeyId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/key_vault_encrypted_value#timeouts-1">DataAzurermKeyVaultEncryptedValue#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermKeyVaultEncryptedValueState<'Algorithm, 'KeyVaultKeyId>, value: azurerm.DataAzurermKeyVaultEncryptedValue.DataAzurermKeyVaultEncryptedValueTimeouts) : DataAzurermKeyVaultEncryptedValueState<'Algorithm, 'KeyVaultKeyId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermKeyVaultEncryptedValueState<'Algorithm, 'KeyVaultKeyId>

        member _.Run(state: DataAzurermKeyVaultEncryptedValueState<Present, Present>) : azurerm.DataAzurermKeyVaultEncryptedValue.DataAzurermKeyVaultEncryptedValue =
            let config = azurerm.DataAzurermKeyVaultEncryptedValue.DataAzurermKeyVaultEncryptedValueConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermKeyVaultEncryptedValue.DataAzurermKeyVaultEncryptedValue(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermKeyVaultEncryptedValue: missing required arguments. Must call: algorithm, key_vault_key_id.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermKeyVaultEncryptedValueState<_, _>) : azurerm.DataAzurermKeyVaultEncryptedValue.DataAzurermKeyVaultEncryptedValue =
            Unchecked.defaultof<azurerm.DataAzurermKeyVaultEncryptedValue.DataAzurermKeyVaultEncryptedValue>

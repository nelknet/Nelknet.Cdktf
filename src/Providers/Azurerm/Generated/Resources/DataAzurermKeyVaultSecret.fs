namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermKeyVaultSecretState<'KeyVaultId, 'Name> = { assignments: ResizeArray<azurerm.DataAzurermKeyVaultSecret.DataAzurermKeyVaultSecretConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/key_vault_secret">azurerm_key_vault_secret</a>.
    /// </summary>
    type DataAzurermKeyVaultSecretBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermKeyVaultSecretState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermKeyVaultSecretState<Missing, Missing>)

        member _.Zero(()) : DataAzurermKeyVaultSecretState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermKeyVaultSecretState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/key_vault_secret#key_vault_id-1">DataAzurermKeyVaultSecret#key_vault_id</a>.
        /// </summary>
        [<CustomOperation "key_vault_id">]
        member _.KeyVaultId(state: DataAzurermKeyVaultSecretState<Missing, 'Name>, value: string) : DataAzurermKeyVaultSecretState<Present, 'Name> =
            state.assignments.Add(fun config -> config.KeyVaultId <- value)
            ({ assignments = state.assignments } : DataAzurermKeyVaultSecretState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/key_vault_secret#name-1">DataAzurermKeyVaultSecret#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermKeyVaultSecretState<'KeyVaultId, Missing>, value: string) : DataAzurermKeyVaultSecretState<'KeyVaultId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermKeyVaultSecretState<'KeyVaultId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/key_vault_secret#id-1">DataAzurermKeyVaultSecret#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermKeyVaultSecretState<'KeyVaultId, 'Name>, value: string) : DataAzurermKeyVaultSecretState<'KeyVaultId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermKeyVaultSecretState<'KeyVaultId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/key_vault_secret#timeouts-1">DataAzurermKeyVaultSecret#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermKeyVaultSecretState<'KeyVaultId, 'Name>, value: azurerm.DataAzurermKeyVaultSecret.DataAzurermKeyVaultSecretTimeouts) : DataAzurermKeyVaultSecretState<'KeyVaultId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermKeyVaultSecretState<'KeyVaultId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/key_vault_secret#version-1">DataAzurermKeyVaultSecret#version</a>.
        /// </summary>
        [<CustomOperation "version">]
        member _.Version(state: DataAzurermKeyVaultSecretState<'KeyVaultId, 'Name>, value: string) : DataAzurermKeyVaultSecretState<'KeyVaultId, 'Name> =
            state.assignments.Add(fun config -> config.Version <- value)
            state : DataAzurermKeyVaultSecretState<'KeyVaultId, 'Name>

        member _.Run(state: DataAzurermKeyVaultSecretState<Present, Present>) : azurerm.DataAzurermKeyVaultSecret.DataAzurermKeyVaultSecret =
            let config = azurerm.DataAzurermKeyVaultSecret.DataAzurermKeyVaultSecretConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermKeyVaultSecret.DataAzurermKeyVaultSecret(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermKeyVaultSecret: missing required arguments. Must call: key_vault_id, name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermKeyVaultSecretState<_, _>) : azurerm.DataAzurermKeyVaultSecret.DataAzurermKeyVaultSecret =
            Unchecked.defaultof<azurerm.DataAzurermKeyVaultSecret.DataAzurermKeyVaultSecret>

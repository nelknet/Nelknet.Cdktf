namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermKeyVaultKeyState<'KeyVaultId, 'Name> = { assignments: ResizeArray<azurerm.DataAzurermKeyVaultKey.DataAzurermKeyVaultKeyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/key_vault_key">azurerm_key_vault_key</a>.
    /// </summary>
    type DataAzurermKeyVaultKeyBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermKeyVaultKeyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermKeyVaultKeyState<Missing, Missing>)

        member _.Zero(()) : DataAzurermKeyVaultKeyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermKeyVaultKeyState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/key_vault_key#key_vault_id-1">DataAzurermKeyVaultKey#key_vault_id</a>.
        /// </summary>
        [<CustomOperation "key_vault_id">]
        member _.KeyVaultId(state: DataAzurermKeyVaultKeyState<Missing, 'Name>, value: string) : DataAzurermKeyVaultKeyState<Present, 'Name> =
            state.assignments.Add(fun config -> config.KeyVaultId <- value)
            ({ assignments = state.assignments } : DataAzurermKeyVaultKeyState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/key_vault_key#name-1">DataAzurermKeyVaultKey#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermKeyVaultKeyState<'KeyVaultId, Missing>, value: string) : DataAzurermKeyVaultKeyState<'KeyVaultId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermKeyVaultKeyState<'KeyVaultId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/key_vault_key#id-1">DataAzurermKeyVaultKey#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermKeyVaultKeyState<'KeyVaultId, 'Name>, value: string) : DataAzurermKeyVaultKeyState<'KeyVaultId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermKeyVaultKeyState<'KeyVaultId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/key_vault_key#timeouts-1">DataAzurermKeyVaultKey#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermKeyVaultKeyState<'KeyVaultId, 'Name>, value: azurerm.DataAzurermKeyVaultKey.DataAzurermKeyVaultKeyTimeouts) : DataAzurermKeyVaultKeyState<'KeyVaultId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermKeyVaultKeyState<'KeyVaultId, 'Name>

        member _.Run(state: DataAzurermKeyVaultKeyState<Present, Present>) : azurerm.DataAzurermKeyVaultKey.DataAzurermKeyVaultKey =
            let config = azurerm.DataAzurermKeyVaultKey.DataAzurermKeyVaultKeyConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermKeyVaultKey.DataAzurermKeyVaultKey(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermKeyVaultKey: missing required arguments. Must call: key_vault_id, name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermKeyVaultKeyState<_, _>) : azurerm.DataAzurermKeyVaultKey.DataAzurermKeyVaultKey =
            Unchecked.defaultof<azurerm.DataAzurermKeyVaultKey.DataAzurermKeyVaultKey>

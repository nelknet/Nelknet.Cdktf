namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermKeyVaultSecretsState<'KeyVaultId> = { assignments: ResizeArray<azurerm.DataAzurermKeyVaultSecrets.DataAzurermKeyVaultSecretsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/key_vault_secrets">azurerm_key_vault_secrets</a>.
    /// </summary>
    type DataAzurermKeyVaultSecretsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermKeyVaultSecretsState<Missing> =
            ({ assignments = ResizeArray() } : DataAzurermKeyVaultSecretsState<Missing>)

        member _.Zero(()) : DataAzurermKeyVaultSecretsState<Missing> =
            ({ assignments = ResizeArray() } : DataAzurermKeyVaultSecretsState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/key_vault_secrets#key_vault_id-1">DataAzurermKeyVaultSecrets#key_vault_id</a>.
        /// </summary>
        [<CustomOperation "key_vault_id">]
        member _.KeyVaultId(state: DataAzurermKeyVaultSecretsState<Missing>, value: string) : DataAzurermKeyVaultSecretsState<Present> =
            state.assignments.Add(fun config -> config.KeyVaultId <- value)
            ({ assignments = state.assignments } : DataAzurermKeyVaultSecretsState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/key_vault_secrets#id-1">DataAzurermKeyVaultSecrets#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermKeyVaultSecretsState<'KeyVaultId>, value: string) : DataAzurermKeyVaultSecretsState<'KeyVaultId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermKeyVaultSecretsState<'KeyVaultId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/key_vault_secrets#timeouts-1">DataAzurermKeyVaultSecrets#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermKeyVaultSecretsState<'KeyVaultId>, value: azurerm.DataAzurermKeyVaultSecrets.DataAzurermKeyVaultSecretsTimeouts) : DataAzurermKeyVaultSecretsState<'KeyVaultId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermKeyVaultSecretsState<'KeyVaultId>

        member _.Run(state: DataAzurermKeyVaultSecretsState<Present>) : azurerm.DataAzurermKeyVaultSecrets.DataAzurermKeyVaultSecrets =
            let config = azurerm.DataAzurermKeyVaultSecrets.DataAzurermKeyVaultSecretsConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermKeyVaultSecrets.DataAzurermKeyVaultSecrets(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermKeyVaultSecrets: missing required arguments. Must call: key_vault_id.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermKeyVaultSecretsState<_>) : azurerm.DataAzurermKeyVaultSecrets.DataAzurermKeyVaultSecrets =
            Unchecked.defaultof<azurerm.DataAzurermKeyVaultSecrets.DataAzurermKeyVaultSecrets>

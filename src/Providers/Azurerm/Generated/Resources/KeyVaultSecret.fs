namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type KeyVaultSecretState<'KeyVaultId, 'Name, 'Value> = { assignments: ResizeArray<azurerm.KeyVaultSecret.KeyVaultSecretConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_secret">azurerm_key_vault_secret</a>.
    /// </summary>
    type KeyVaultSecretBuilder(logicalId: string) =
        member _.Yield(_: unit) : KeyVaultSecretState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : KeyVaultSecretState<Missing, Missing, Missing>)

        member _.Zero(()) : KeyVaultSecretState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : KeyVaultSecretState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_secret#key_vault_id-1">KeyVaultSecret#key_vault_id</a>.
        /// </summary>
        [<CustomOperation "key_vault_id">]
        member _.KeyVaultId(state: KeyVaultSecretState<Missing, 'Name, 'Value>, value: string) : KeyVaultSecretState<Present, 'Name, 'Value> =
            state.assignments.Add(fun config -> config.KeyVaultId <- value)
            ({ assignments = state.assignments } : KeyVaultSecretState<Present, 'Name, 'Value>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_secret#name-1">KeyVaultSecret#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: KeyVaultSecretState<'KeyVaultId, Missing, 'Value>, value: string) : KeyVaultSecretState<'KeyVaultId, Present, 'Value> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : KeyVaultSecretState<'KeyVaultId, Present, 'Value>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_secret#value-1">KeyVaultSecret#value</a>.
        /// </summary>
        [<CustomOperation "value">]
        member _.Value(state: KeyVaultSecretState<'KeyVaultId, 'Name, Missing>, value: string) : KeyVaultSecretState<'KeyVaultId, 'Name, Present> =
            state.assignments.Add(fun config -> config.Value <- value)
            ({ assignments = state.assignments } : KeyVaultSecretState<'KeyVaultId, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_secret#content_type-1">KeyVaultSecret#content_type</a>.
        /// </summary>
        [<CustomOperation "content_type">]
        member _.ContentType(state: KeyVaultSecretState<'KeyVaultId, 'Name, 'Value>, value: string) : KeyVaultSecretState<'KeyVaultId, 'Name, 'Value> =
            state.assignments.Add(fun config -> config.ContentType <- value)
            state : KeyVaultSecretState<'KeyVaultId, 'Name, 'Value>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_secret#expiration_date-1">KeyVaultSecret#expiration_date</a>.
        /// </summary>
        [<CustomOperation "expiration_date">]
        member _.ExpirationDate(state: KeyVaultSecretState<'KeyVaultId, 'Name, 'Value>, value: string) : KeyVaultSecretState<'KeyVaultId, 'Name, 'Value> =
            state.assignments.Add(fun config -> config.ExpirationDate <- value)
            state : KeyVaultSecretState<'KeyVaultId, 'Name, 'Value>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_secret#id-1">KeyVaultSecret#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: KeyVaultSecretState<'KeyVaultId, 'Name, 'Value>, value: string) : KeyVaultSecretState<'KeyVaultId, 'Name, 'Value> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : KeyVaultSecretState<'KeyVaultId, 'Name, 'Value>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_secret#not_before_date-1">KeyVaultSecret#not_before_date</a>.
        /// </summary>
        [<CustomOperation "not_before_date">]
        member _.NotBeforeDate(state: KeyVaultSecretState<'KeyVaultId, 'Name, 'Value>, value: string) : KeyVaultSecretState<'KeyVaultId, 'Name, 'Value> =
            state.assignments.Add(fun config -> config.NotBeforeDate <- value)
            state : KeyVaultSecretState<'KeyVaultId, 'Name, 'Value>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_secret#tags-1">KeyVaultSecret#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: KeyVaultSecretState<'KeyVaultId, 'Name, 'Value>, value: seq<string * string>) : KeyVaultSecretState<'KeyVaultId, 'Name, 'Value> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : KeyVaultSecretState<'KeyVaultId, 'Name, 'Value>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_secret#timeouts-1">KeyVaultSecret#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: KeyVaultSecretState<'KeyVaultId, 'Name, 'Value>, value: azurerm.KeyVaultSecret.KeyVaultSecretTimeouts) : KeyVaultSecretState<'KeyVaultId, 'Name, 'Value> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : KeyVaultSecretState<'KeyVaultId, 'Name, 'Value>

        member _.Run(state: KeyVaultSecretState<Present, Present, Present>) : azurerm.KeyVaultSecret.KeyVaultSecret =
            let config = azurerm.KeyVaultSecret.KeyVaultSecretConfig()
            for setter in state.assignments do
                setter config
            azurerm.KeyVaultSecret.KeyVaultSecret(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.keyVaultSecret: missing required arguments. Must call: key_vault_id, name, value.", 9999, IsError = true)>]
        member _.Run(_: KeyVaultSecretState<_, _, _>) : azurerm.KeyVaultSecret.KeyVaultSecret =
            Unchecked.defaultof<azurerm.KeyVaultSecret.KeyVaultSecret>

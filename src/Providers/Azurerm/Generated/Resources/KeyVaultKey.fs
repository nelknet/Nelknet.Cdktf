namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type KeyVaultKeyState<'KeyOpts, 'KeyType, 'KeyVaultId, 'Name> = { assignments: ResizeArray<azurerm.KeyVaultKey.KeyVaultKeyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_key">azurerm_key_vault_key</a>.
    /// </summary>
    type KeyVaultKeyBuilder(logicalId: string) =
        member _.Yield(_: unit) : KeyVaultKeyState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : KeyVaultKeyState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : KeyVaultKeyState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : KeyVaultKeyState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_key#key_opts-1">KeyVaultKey#key_opts</a>.
        /// </summary>
        [<CustomOperation "key_opts">]
        member _.KeyOpts(state: KeyVaultKeyState<Missing, 'KeyType, 'KeyVaultId, 'Name>, value: seq<string>) : KeyVaultKeyState<Present, 'KeyType, 'KeyVaultId, 'Name> =
            state.assignments.Add(fun config -> config.KeyOpts <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : KeyVaultKeyState<Present, 'KeyType, 'KeyVaultId, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_key#key_type-1">KeyVaultKey#key_type</a>.
        /// </summary>
        [<CustomOperation "key_type">]
        member _.KeyType(state: KeyVaultKeyState<'KeyOpts, Missing, 'KeyVaultId, 'Name>, value: string) : KeyVaultKeyState<'KeyOpts, Present, 'KeyVaultId, 'Name> =
            state.assignments.Add(fun config -> config.KeyType <- value)
            ({ assignments = state.assignments } : KeyVaultKeyState<'KeyOpts, Present, 'KeyVaultId, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_key#key_vault_id-1">KeyVaultKey#key_vault_id</a>.
        /// </summary>
        [<CustomOperation "key_vault_id">]
        member _.KeyVaultId(state: KeyVaultKeyState<'KeyOpts, 'KeyType, Missing, 'Name>, value: string) : KeyVaultKeyState<'KeyOpts, 'KeyType, Present, 'Name> =
            state.assignments.Add(fun config -> config.KeyVaultId <- value)
            ({ assignments = state.assignments } : KeyVaultKeyState<'KeyOpts, 'KeyType, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_key#name-1">KeyVaultKey#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: KeyVaultKeyState<'KeyOpts, 'KeyType, 'KeyVaultId, Missing>, value: string) : KeyVaultKeyState<'KeyOpts, 'KeyType, 'KeyVaultId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : KeyVaultKeyState<'KeyOpts, 'KeyType, 'KeyVaultId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_key#curve-1">KeyVaultKey#curve</a>.
        /// </summary>
        [<CustomOperation "curve">]
        member _.Curve(state: KeyVaultKeyState<'KeyOpts, 'KeyType, 'KeyVaultId, 'Name>, value: string) : KeyVaultKeyState<'KeyOpts, 'KeyType, 'KeyVaultId, 'Name> =
            state.assignments.Add(fun config -> config.Curve <- value)
            state : KeyVaultKeyState<'KeyOpts, 'KeyType, 'KeyVaultId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_key#expiration_date-1">KeyVaultKey#expiration_date</a>.
        /// </summary>
        [<CustomOperation "expiration_date">]
        member _.ExpirationDate(state: KeyVaultKeyState<'KeyOpts, 'KeyType, 'KeyVaultId, 'Name>, value: string) : KeyVaultKeyState<'KeyOpts, 'KeyType, 'KeyVaultId, 'Name> =
            state.assignments.Add(fun config -> config.ExpirationDate <- value)
            state : KeyVaultKeyState<'KeyOpts, 'KeyType, 'KeyVaultId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_key#id-1">KeyVaultKey#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: KeyVaultKeyState<'KeyOpts, 'KeyType, 'KeyVaultId, 'Name>, value: string) : KeyVaultKeyState<'KeyOpts, 'KeyType, 'KeyVaultId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : KeyVaultKeyState<'KeyOpts, 'KeyType, 'KeyVaultId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_key#key_size-1">KeyVaultKey#key_size</a>.
        /// </summary>
        [<CustomOperation "key_size">]
        member _.KeySize(state: KeyVaultKeyState<'KeyOpts, 'KeyType, 'KeyVaultId, 'Name>, value: double) : KeyVaultKeyState<'KeyOpts, 'KeyType, 'KeyVaultId, 'Name> =
            state.assignments.Add(fun config -> config.KeySize <- value)
            state : KeyVaultKeyState<'KeyOpts, 'KeyType, 'KeyVaultId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_key#not_before_date-1">KeyVaultKey#not_before_date</a>.
        /// </summary>
        [<CustomOperation "not_before_date">]
        member _.NotBeforeDate(state: KeyVaultKeyState<'KeyOpts, 'KeyType, 'KeyVaultId, 'Name>, value: string) : KeyVaultKeyState<'KeyOpts, 'KeyType, 'KeyVaultId, 'Name> =
            state.assignments.Add(fun config -> config.NotBeforeDate <- value)
            state : KeyVaultKeyState<'KeyOpts, 'KeyType, 'KeyVaultId, 'Name>

        /// <summary>
        /// rotation_policy block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_key#rotation_policy-1">KeyVaultKey#rotation_policy</a>
        /// </summary>
        [<CustomOperation "rotation_policy">]
        member _.RotationPolicy(state: KeyVaultKeyState<'KeyOpts, 'KeyType, 'KeyVaultId, 'Name>, value: azurerm.KeyVaultKey.KeyVaultKeyRotationPolicy) : KeyVaultKeyState<'KeyOpts, 'KeyType, 'KeyVaultId, 'Name> =
            state.assignments.Add(fun config -> config.RotationPolicy <- value)
            state : KeyVaultKeyState<'KeyOpts, 'KeyType, 'KeyVaultId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_key#tags-1">KeyVaultKey#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: KeyVaultKeyState<'KeyOpts, 'KeyType, 'KeyVaultId, 'Name>, value: seq<string * string>) : KeyVaultKeyState<'KeyOpts, 'KeyType, 'KeyVaultId, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : KeyVaultKeyState<'KeyOpts, 'KeyType, 'KeyVaultId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_key#timeouts-1">KeyVaultKey#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: KeyVaultKeyState<'KeyOpts, 'KeyType, 'KeyVaultId, 'Name>, value: azurerm.KeyVaultKey.KeyVaultKeyTimeouts) : KeyVaultKeyState<'KeyOpts, 'KeyType, 'KeyVaultId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : KeyVaultKeyState<'KeyOpts, 'KeyType, 'KeyVaultId, 'Name>

        member _.Run(state: KeyVaultKeyState<Present, Present, Present, Present>) : azurerm.KeyVaultKey.KeyVaultKey =
            let config = azurerm.KeyVaultKey.KeyVaultKeyConfig()
            for setter in state.assignments do
                setter config
            azurerm.KeyVaultKey.KeyVaultKey(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.keyVaultKey: missing required arguments. Must call: key_opts, key_type, key_vault_id, name.", 9999, IsError = true)>]
        member _.Run(_: KeyVaultKeyState<_, _, _, _>) : azurerm.KeyVaultKey.KeyVaultKey =
            Unchecked.defaultof<azurerm.KeyVaultKey.KeyVaultKey>

namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type KeyVaultManagedHardwareSecurityModuleKeyState<'KeyOpts, 'KeyType, 'ManagedHsmId, 'Name> = { assignments: ResizeArray<azurerm.KeyVaultManagedHardwareSecurityModuleKey.KeyVaultManagedHardwareSecurityModuleKeyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_managed_hardware_security_module_key">azurerm_key_vault_managed_hardware_security_module_key</a>.
    /// </summary>
    type KeyVaultManagedHardwareSecurityModuleKeyBuilder(logicalId: string) =
        member _.Yield(_: unit) : KeyVaultManagedHardwareSecurityModuleKeyState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : KeyVaultManagedHardwareSecurityModuleKeyState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : KeyVaultManagedHardwareSecurityModuleKeyState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : KeyVaultManagedHardwareSecurityModuleKeyState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_managed_hardware_security_module_key#key_opts-1">KeyVaultManagedHardwareSecurityModuleKey#key_opts</a>.
        /// </summary>
        [<CustomOperation "key_opts">]
        member _.KeyOpts(state: KeyVaultManagedHardwareSecurityModuleKeyState<Missing, 'KeyType, 'ManagedHsmId, 'Name>, value: seq<string>) : KeyVaultManagedHardwareSecurityModuleKeyState<Present, 'KeyType, 'ManagedHsmId, 'Name> =
            state.assignments.Add(fun config -> config.KeyOpts <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : KeyVaultManagedHardwareSecurityModuleKeyState<Present, 'KeyType, 'ManagedHsmId, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_managed_hardware_security_module_key#key_type-1">KeyVaultManagedHardwareSecurityModuleKey#key_type</a>.
        /// </summary>
        [<CustomOperation "key_type">]
        member _.KeyType(state: KeyVaultManagedHardwareSecurityModuleKeyState<'KeyOpts, Missing, 'ManagedHsmId, 'Name>, value: string) : KeyVaultManagedHardwareSecurityModuleKeyState<'KeyOpts, Present, 'ManagedHsmId, 'Name> =
            state.assignments.Add(fun config -> config.KeyType <- value)
            ({ assignments = state.assignments } : KeyVaultManagedHardwareSecurityModuleKeyState<'KeyOpts, Present, 'ManagedHsmId, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_managed_hardware_security_module_key#managed_hsm_id-1">KeyVaultManagedHardwareSecurityModuleKey#managed_hsm_id</a>.
        /// </summary>
        [<CustomOperation "managed_hsm_id">]
        member _.ManagedHsmId(state: KeyVaultManagedHardwareSecurityModuleKeyState<'KeyOpts, 'KeyType, Missing, 'Name>, value: string) : KeyVaultManagedHardwareSecurityModuleKeyState<'KeyOpts, 'KeyType, Present, 'Name> =
            state.assignments.Add(fun config -> config.ManagedHsmId <- value)
            ({ assignments = state.assignments } : KeyVaultManagedHardwareSecurityModuleKeyState<'KeyOpts, 'KeyType, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_managed_hardware_security_module_key#name-1">KeyVaultManagedHardwareSecurityModuleKey#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: KeyVaultManagedHardwareSecurityModuleKeyState<'KeyOpts, 'KeyType, 'ManagedHsmId, Missing>, value: string) : KeyVaultManagedHardwareSecurityModuleKeyState<'KeyOpts, 'KeyType, 'ManagedHsmId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : KeyVaultManagedHardwareSecurityModuleKeyState<'KeyOpts, 'KeyType, 'ManagedHsmId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_managed_hardware_security_module_key#curve-1">KeyVaultManagedHardwareSecurityModuleKey#curve</a>.
        /// </summary>
        [<CustomOperation "curve">]
        member _.Curve(state: KeyVaultManagedHardwareSecurityModuleKeyState<'KeyOpts, 'KeyType, 'ManagedHsmId, 'Name>, value: string) : KeyVaultManagedHardwareSecurityModuleKeyState<'KeyOpts, 'KeyType, 'ManagedHsmId, 'Name> =
            state.assignments.Add(fun config -> config.Curve <- value)
            state : KeyVaultManagedHardwareSecurityModuleKeyState<'KeyOpts, 'KeyType, 'ManagedHsmId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_managed_hardware_security_module_key#expiration_date-1">KeyVaultManagedHardwareSecurityModuleKey#expiration_date</a>.
        /// </summary>
        [<CustomOperation "expiration_date">]
        member _.ExpirationDate(state: KeyVaultManagedHardwareSecurityModuleKeyState<'KeyOpts, 'KeyType, 'ManagedHsmId, 'Name>, value: string) : KeyVaultManagedHardwareSecurityModuleKeyState<'KeyOpts, 'KeyType, 'ManagedHsmId, 'Name> =
            state.assignments.Add(fun config -> config.ExpirationDate <- value)
            state : KeyVaultManagedHardwareSecurityModuleKeyState<'KeyOpts, 'KeyType, 'ManagedHsmId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_managed_hardware_security_module_key#id-1">KeyVaultManagedHardwareSecurityModuleKey#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: KeyVaultManagedHardwareSecurityModuleKeyState<'KeyOpts, 'KeyType, 'ManagedHsmId, 'Name>, value: string) : KeyVaultManagedHardwareSecurityModuleKeyState<'KeyOpts, 'KeyType, 'ManagedHsmId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : KeyVaultManagedHardwareSecurityModuleKeyState<'KeyOpts, 'KeyType, 'ManagedHsmId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_managed_hardware_security_module_key#key_size-1">KeyVaultManagedHardwareSecurityModuleKey#key_size</a>.
        /// </summary>
        [<CustomOperation "key_size">]
        member _.KeySize(state: KeyVaultManagedHardwareSecurityModuleKeyState<'KeyOpts, 'KeyType, 'ManagedHsmId, 'Name>, value: double) : KeyVaultManagedHardwareSecurityModuleKeyState<'KeyOpts, 'KeyType, 'ManagedHsmId, 'Name> =
            state.assignments.Add(fun config -> config.KeySize <- value)
            state : KeyVaultManagedHardwareSecurityModuleKeyState<'KeyOpts, 'KeyType, 'ManagedHsmId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_managed_hardware_security_module_key#not_before_date-1">KeyVaultManagedHardwareSecurityModuleKey#not_before_date</a>.
        /// </summary>
        [<CustomOperation "not_before_date">]
        member _.NotBeforeDate(state: KeyVaultManagedHardwareSecurityModuleKeyState<'KeyOpts, 'KeyType, 'ManagedHsmId, 'Name>, value: string) : KeyVaultManagedHardwareSecurityModuleKeyState<'KeyOpts, 'KeyType, 'ManagedHsmId, 'Name> =
            state.assignments.Add(fun config -> config.NotBeforeDate <- value)
            state : KeyVaultManagedHardwareSecurityModuleKeyState<'KeyOpts, 'KeyType, 'ManagedHsmId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_managed_hardware_security_module_key#tags-1">KeyVaultManagedHardwareSecurityModuleKey#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: KeyVaultManagedHardwareSecurityModuleKeyState<'KeyOpts, 'KeyType, 'ManagedHsmId, 'Name>, value: seq<string * string>) : KeyVaultManagedHardwareSecurityModuleKeyState<'KeyOpts, 'KeyType, 'ManagedHsmId, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : KeyVaultManagedHardwareSecurityModuleKeyState<'KeyOpts, 'KeyType, 'ManagedHsmId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_managed_hardware_security_module_key#timeouts-1">KeyVaultManagedHardwareSecurityModuleKey#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: KeyVaultManagedHardwareSecurityModuleKeyState<'KeyOpts, 'KeyType, 'ManagedHsmId, 'Name>, value: azurerm.KeyVaultManagedHardwareSecurityModuleKey.KeyVaultManagedHardwareSecurityModuleKeyTimeouts) : KeyVaultManagedHardwareSecurityModuleKeyState<'KeyOpts, 'KeyType, 'ManagedHsmId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : KeyVaultManagedHardwareSecurityModuleKeyState<'KeyOpts, 'KeyType, 'ManagedHsmId, 'Name>

        member _.Run(state: KeyVaultManagedHardwareSecurityModuleKeyState<Present, Present, Present, Present>) : azurerm.KeyVaultManagedHardwareSecurityModuleKey.KeyVaultManagedHardwareSecurityModuleKey =
            let config = azurerm.KeyVaultManagedHardwareSecurityModuleKey.KeyVaultManagedHardwareSecurityModuleKeyConfig()
            for setter in state.assignments do
                setter config
            azurerm.KeyVaultManagedHardwareSecurityModuleKey.KeyVaultManagedHardwareSecurityModuleKey(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.keyVaultManagedHardwareSecurityModuleKey: missing required arguments. Must call: key_opts, key_type, managed_hsm_id, name.", 9999, IsError = true)>]
        member _.Run(_: KeyVaultManagedHardwareSecurityModuleKeyState<_, _, _, _>) : azurerm.KeyVaultManagedHardwareSecurityModuleKey.KeyVaultManagedHardwareSecurityModuleKey =
            Unchecked.defaultof<azurerm.KeyVaultManagedHardwareSecurityModuleKey.KeyVaultManagedHardwareSecurityModuleKey>

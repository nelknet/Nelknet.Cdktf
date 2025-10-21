namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CognitiveAccountCustomerManagedKeyAState<'CognitiveAccountId, 'KeyVaultKeyId> = { assignments: ResizeArray<azurerm.CognitiveAccountCustomerManagedKey.CognitiveAccountCustomerManagedKeyAConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cognitive_account_customer_managed_key">azurerm_cognitive_account_customer_managed_key</a>.
    /// </summary>
    type CognitiveAccountCustomerManagedKeyABuilder(logicalId: string) =
        member _.Yield(_: unit) : CognitiveAccountCustomerManagedKeyAState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CognitiveAccountCustomerManagedKeyAState<Missing, Missing>)

        member _.Zero(()) : CognitiveAccountCustomerManagedKeyAState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CognitiveAccountCustomerManagedKeyAState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cognitive_account_customer_managed_key#cognitive_account_id-1">CognitiveAccountCustomerManagedKeyA#cognitive_account_id</a>.
        /// </summary>
        [<CustomOperation "cognitive_account_id">]
        member _.CognitiveAccountId(state: CognitiveAccountCustomerManagedKeyAState<Missing, 'KeyVaultKeyId>, value: string) : CognitiveAccountCustomerManagedKeyAState<Present, 'KeyVaultKeyId> =
            state.assignments.Add(fun config -> config.CognitiveAccountId <- value)
            ({ assignments = state.assignments } : CognitiveAccountCustomerManagedKeyAState<Present, 'KeyVaultKeyId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cognitive_account_customer_managed_key#key_vault_key_id-1">CognitiveAccountCustomerManagedKeyA#key_vault_key_id</a>.
        /// </summary>
        [<CustomOperation "key_vault_key_id">]
        member _.KeyVaultKeyId(state: CognitiveAccountCustomerManagedKeyAState<'CognitiveAccountId, Missing>, value: string) : CognitiveAccountCustomerManagedKeyAState<'CognitiveAccountId, Present> =
            state.assignments.Add(fun config -> config.KeyVaultKeyId <- value)
            ({ assignments = state.assignments } : CognitiveAccountCustomerManagedKeyAState<'CognitiveAccountId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cognitive_account_customer_managed_key#id-1">CognitiveAccountCustomerManagedKeyA#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CognitiveAccountCustomerManagedKeyAState<'CognitiveAccountId, 'KeyVaultKeyId>, value: string) : CognitiveAccountCustomerManagedKeyAState<'CognitiveAccountId, 'KeyVaultKeyId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CognitiveAccountCustomerManagedKeyAState<'CognitiveAccountId, 'KeyVaultKeyId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cognitive_account_customer_managed_key#identity_client_id-1">CognitiveAccountCustomerManagedKeyA#identity_client_id</a>.
        /// </summary>
        [<CustomOperation "identity_client_id">]
        member _.IdentityClientId(state: CognitiveAccountCustomerManagedKeyAState<'CognitiveAccountId, 'KeyVaultKeyId>, value: string) : CognitiveAccountCustomerManagedKeyAState<'CognitiveAccountId, 'KeyVaultKeyId> =
            state.assignments.Add(fun config -> config.IdentityClientId <- value)
            state : CognitiveAccountCustomerManagedKeyAState<'CognitiveAccountId, 'KeyVaultKeyId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cognitive_account_customer_managed_key#timeouts-1">CognitiveAccountCustomerManagedKeyA#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: CognitiveAccountCustomerManagedKeyAState<'CognitiveAccountId, 'KeyVaultKeyId>, value: azurerm.CognitiveAccountCustomerManagedKey.CognitiveAccountCustomerManagedKeyTimeouts) : CognitiveAccountCustomerManagedKeyAState<'CognitiveAccountId, 'KeyVaultKeyId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : CognitiveAccountCustomerManagedKeyAState<'CognitiveAccountId, 'KeyVaultKeyId>

        member _.Run(state: CognitiveAccountCustomerManagedKeyAState<Present, Present>) : azurerm.CognitiveAccountCustomerManagedKey.CognitiveAccountCustomerManagedKeyA =
            let config = azurerm.CognitiveAccountCustomerManagedKey.CognitiveAccountCustomerManagedKeyAConfig()
            for setter in state.assignments do
                setter config
            azurerm.CognitiveAccountCustomerManagedKey.CognitiveAccountCustomerManagedKeyA(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.cognitiveAccountCustomerManagedKeyA: missing required arguments. Must call: cognitive_account_id, key_vault_key_id.", 9999, IsError = true)>]
        member _.Run(_: CognitiveAccountCustomerManagedKeyAState<_, _>) : azurerm.CognitiveAccountCustomerManagedKey.CognitiveAccountCustomerManagedKeyA =
            Unchecked.defaultof<azurerm.CognitiveAccountCustomerManagedKey.CognitiveAccountCustomerManagedKeyA>

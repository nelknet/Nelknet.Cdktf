namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type EventhubNamespaceCustomerManagedKeyState<'EventhubNamespaceId, 'KeyVaultKeyIds> = { assignments: ResizeArray<azurerm.EventhubNamespaceCustomerManagedKey.EventhubNamespaceCustomerManagedKeyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub_namespace_customer_managed_key">azurerm_eventhub_namespace_customer_managed_key</a>.
    /// </summary>
    type EventhubNamespaceCustomerManagedKeyBuilder(logicalId: string) =
        member _.Yield(_: unit) : EventhubNamespaceCustomerManagedKeyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : EventhubNamespaceCustomerManagedKeyState<Missing, Missing>)

        member _.Zero(()) : EventhubNamespaceCustomerManagedKeyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : EventhubNamespaceCustomerManagedKeyState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub_namespace_customer_managed_key#eventhub_namespace_id-1">EventhubNamespaceCustomerManagedKey#eventhub_namespace_id</a>.
        /// </summary>
        [<CustomOperation "eventhub_namespace_id">]
        member _.EventhubNamespaceId(state: EventhubNamespaceCustomerManagedKeyState<Missing, 'KeyVaultKeyIds>, value: string) : EventhubNamespaceCustomerManagedKeyState<Present, 'KeyVaultKeyIds> =
            state.assignments.Add(fun config -> config.EventhubNamespaceId <- value)
            ({ assignments = state.assignments } : EventhubNamespaceCustomerManagedKeyState<Present, 'KeyVaultKeyIds>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub_namespace_customer_managed_key#key_vault_key_ids-1">EventhubNamespaceCustomerManagedKey#key_vault_key_ids</a>.
        /// </summary>
        [<CustomOperation "key_vault_key_ids">]
        member _.KeyVaultKeyIds(state: EventhubNamespaceCustomerManagedKeyState<'EventhubNamespaceId, Missing>, value: seq<string>) : EventhubNamespaceCustomerManagedKeyState<'EventhubNamespaceId, Present> =
            state.assignments.Add(fun config -> config.KeyVaultKeyIds <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : EventhubNamespaceCustomerManagedKeyState<'EventhubNamespaceId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub_namespace_customer_managed_key#id-1">EventhubNamespaceCustomerManagedKey#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: EventhubNamespaceCustomerManagedKeyState<'EventhubNamespaceId, 'KeyVaultKeyIds>, value: string) : EventhubNamespaceCustomerManagedKeyState<'EventhubNamespaceId, 'KeyVaultKeyIds> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : EventhubNamespaceCustomerManagedKeyState<'EventhubNamespaceId, 'KeyVaultKeyIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub_namespace_customer_managed_key#infrastructure_encryption_enabled-1">EventhubNamespaceCustomerManagedKey#infrastructure_encryption_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "infrastructure_encryption_enabled">]
        member _.InfrastructureEncryptionEnabled(state: EventhubNamespaceCustomerManagedKeyState<'EventhubNamespaceId, 'KeyVaultKeyIds>, value: bool) : EventhubNamespaceCustomerManagedKeyState<'EventhubNamespaceId, 'KeyVaultKeyIds> =
            state.assignments.Add(fun config -> config.InfrastructureEncryptionEnabled <- value)
            state : EventhubNamespaceCustomerManagedKeyState<'EventhubNamespaceId, 'KeyVaultKeyIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub_namespace_customer_managed_key#infrastructure_encryption_enabled-1">EventhubNamespaceCustomerManagedKey#infrastructure_encryption_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "infrastructure_encryption_enabled">]
        member _.InfrastructureEncryptionEnabled(state: EventhubNamespaceCustomerManagedKeyState<'EventhubNamespaceId, 'KeyVaultKeyIds>, value: HashiCorp.Cdktf.IResolvable) : EventhubNamespaceCustomerManagedKeyState<'EventhubNamespaceId, 'KeyVaultKeyIds> =
            state.assignments.Add(fun config -> config.InfrastructureEncryptionEnabled <- value)
            state : EventhubNamespaceCustomerManagedKeyState<'EventhubNamespaceId, 'KeyVaultKeyIds>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub_namespace_customer_managed_key#timeouts-1">EventhubNamespaceCustomerManagedKey#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: EventhubNamespaceCustomerManagedKeyState<'EventhubNamespaceId, 'KeyVaultKeyIds>, value: azurerm.EventhubNamespaceCustomerManagedKey.EventhubNamespaceCustomerManagedKeyTimeouts) : EventhubNamespaceCustomerManagedKeyState<'EventhubNamespaceId, 'KeyVaultKeyIds> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : EventhubNamespaceCustomerManagedKeyState<'EventhubNamespaceId, 'KeyVaultKeyIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub_namespace_customer_managed_key#user_assigned_identity_id-1">EventhubNamespaceCustomerManagedKey#user_assigned_identity_id</a>.
        /// </summary>
        [<CustomOperation "user_assigned_identity_id">]
        member _.UserAssignedIdentityId(state: EventhubNamespaceCustomerManagedKeyState<'EventhubNamespaceId, 'KeyVaultKeyIds>, value: string) : EventhubNamespaceCustomerManagedKeyState<'EventhubNamespaceId, 'KeyVaultKeyIds> =
            state.assignments.Add(fun config -> config.UserAssignedIdentityId <- value)
            state : EventhubNamespaceCustomerManagedKeyState<'EventhubNamespaceId, 'KeyVaultKeyIds>

        member _.Run(state: EventhubNamespaceCustomerManagedKeyState<Present, Present>) : azurerm.EventhubNamespaceCustomerManagedKey.EventhubNamespaceCustomerManagedKey =
            let config = azurerm.EventhubNamespaceCustomerManagedKey.EventhubNamespaceCustomerManagedKeyConfig()
            for setter in state.assignments do
                setter config
            azurerm.EventhubNamespaceCustomerManagedKey.EventhubNamespaceCustomerManagedKey(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.eventhubNamespaceCustomerManagedKey: missing required arguments. Must call: eventhub_namespace_id, key_vault_key_ids.", 9999, IsError = true)>]
        member _.Run(_: EventhubNamespaceCustomerManagedKeyState<_, _>) : azurerm.EventhubNamespaceCustomerManagedKey.EventhubNamespaceCustomerManagedKey =
            Unchecked.defaultof<azurerm.EventhubNamespaceCustomerManagedKey.EventhubNamespaceCustomerManagedKey>

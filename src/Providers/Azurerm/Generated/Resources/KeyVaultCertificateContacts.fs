namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type KeyVaultCertificateContactsState<'KeyVaultId> = { assignments: ResizeArray<azurerm.KeyVaultCertificateContacts.KeyVaultCertificateContactsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_certificate_contacts">azurerm_key_vault_certificate_contacts</a>.
    /// </summary>
    type KeyVaultCertificateContactsBuilder(logicalId: string) =
        member _.Yield(_: unit) : KeyVaultCertificateContactsState<Missing> =
            ({ assignments = ResizeArray() } : KeyVaultCertificateContactsState<Missing>)

        member _.Zero(()) : KeyVaultCertificateContactsState<Missing> =
            ({ assignments = ResizeArray() } : KeyVaultCertificateContactsState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_certificate_contacts#key_vault_id-1">KeyVaultCertificateContacts#key_vault_id</a>.
        /// </summary>
        [<CustomOperation "key_vault_id">]
        member _.KeyVaultId(state: KeyVaultCertificateContactsState<Missing>, value: string) : KeyVaultCertificateContactsState<Present> =
            state.assignments.Add(fun config -> config.KeyVaultId <- value)
            ({ assignments = state.assignments } : KeyVaultCertificateContactsState<Present>)

        /// <summary>
        /// contact block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_certificate_contacts#contact-1">KeyVaultCertificateContacts#contact</a> Accepts: azurerm.IResolvable | azurerm.KeyVaultCertificateContacts.KeyVaultCertificateContactsContact[]
        /// </summary>
        [<CustomOperation "contact">]
        member _.Contact(state: KeyVaultCertificateContactsState<'KeyVaultId>, value: HashiCorp.Cdktf.IResolvable) : KeyVaultCertificateContactsState<'KeyVaultId> =
            state.assignments.Add(fun config -> config.Contact <- value)
            state : KeyVaultCertificateContactsState<'KeyVaultId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_certificate_contacts#id-1">KeyVaultCertificateContacts#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: KeyVaultCertificateContactsState<'KeyVaultId>, value: string) : KeyVaultCertificateContactsState<'KeyVaultId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : KeyVaultCertificateContactsState<'KeyVaultId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_certificate_contacts#timeouts-1">KeyVaultCertificateContacts#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: KeyVaultCertificateContactsState<'KeyVaultId>, value: azurerm.KeyVaultCertificateContacts.KeyVaultCertificateContactsTimeouts) : KeyVaultCertificateContactsState<'KeyVaultId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : KeyVaultCertificateContactsState<'KeyVaultId>

        member _.Run(state: KeyVaultCertificateContactsState<Present>) : azurerm.KeyVaultCertificateContacts.KeyVaultCertificateContacts =
            let config = azurerm.KeyVaultCertificateContacts.KeyVaultCertificateContactsConfig()
            for setter in state.assignments do
                setter config
            azurerm.KeyVaultCertificateContacts.KeyVaultCertificateContacts(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.keyVaultCertificateContacts: missing required arguments. Must call: key_vault_id.", 9999, IsError = true)>]
        member _.Run(_: KeyVaultCertificateContactsState<_>) : azurerm.KeyVaultCertificateContacts.KeyVaultCertificateContacts =
            Unchecked.defaultof<azurerm.KeyVaultCertificateContacts.KeyVaultCertificateContacts>

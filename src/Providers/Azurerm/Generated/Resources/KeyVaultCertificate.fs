namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type KeyVaultCertificateState<'KeyVaultId, 'Name> = { assignments: ResizeArray<azurerm.KeyVaultCertificate.KeyVaultCertificateConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_certificate">azurerm_key_vault_certificate</a>.
    /// </summary>
    type KeyVaultCertificateBuilder(logicalId: string) =
        member _.Yield(_: unit) : KeyVaultCertificateState<Missing, Missing> =
            ({ assignments = ResizeArray() } : KeyVaultCertificateState<Missing, Missing>)

        member _.Zero(()) : KeyVaultCertificateState<Missing, Missing> =
            ({ assignments = ResizeArray() } : KeyVaultCertificateState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_certificate#key_vault_id-1">KeyVaultCertificate#key_vault_id</a>.
        /// </summary>
        [<CustomOperation "key_vault_id">]
        member _.KeyVaultId(state: KeyVaultCertificateState<Missing, 'Name>, value: string) : KeyVaultCertificateState<Present, 'Name> =
            state.assignments.Add(fun config -> config.KeyVaultId <- value)
            ({ assignments = state.assignments } : KeyVaultCertificateState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_certificate#name-1">KeyVaultCertificate#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: KeyVaultCertificateState<'KeyVaultId, Missing>, value: string) : KeyVaultCertificateState<'KeyVaultId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : KeyVaultCertificateState<'KeyVaultId, Present>)

        /// <summary>
        /// certificate block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_certificate#certificate-1">KeyVaultCertificate#certificate</a>
        /// </summary>
        [<CustomOperation "certificate">]
        member _.Certificate(state: KeyVaultCertificateState<'KeyVaultId, 'Name>, value: azurerm.KeyVaultCertificate.KeyVaultCertificateCertificate) : KeyVaultCertificateState<'KeyVaultId, 'Name> =
            state.assignments.Add(fun config -> config.Certificate <- value)
            state : KeyVaultCertificateState<'KeyVaultId, 'Name>

        /// <summary>
        /// certificate_policy block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_certificate#certificate_policy-1">KeyVaultCertificate#certificate_policy</a>
        /// </summary>
        [<CustomOperation "certificate_policy">]
        member _.CertificatePolicy(state: KeyVaultCertificateState<'KeyVaultId, 'Name>, value: azurerm.KeyVaultCertificate.KeyVaultCertificateCertificatePolicy) : KeyVaultCertificateState<'KeyVaultId, 'Name> =
            state.assignments.Add(fun config -> config.CertificatePolicy <- value)
            state : KeyVaultCertificateState<'KeyVaultId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_certificate#id-1">KeyVaultCertificate#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: KeyVaultCertificateState<'KeyVaultId, 'Name>, value: string) : KeyVaultCertificateState<'KeyVaultId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : KeyVaultCertificateState<'KeyVaultId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_certificate#tags-1">KeyVaultCertificate#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: KeyVaultCertificateState<'KeyVaultId, 'Name>, value: seq<string * string>) : KeyVaultCertificateState<'KeyVaultId, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : KeyVaultCertificateState<'KeyVaultId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_certificate#timeouts-1">KeyVaultCertificate#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: KeyVaultCertificateState<'KeyVaultId, 'Name>, value: azurerm.KeyVaultCertificate.KeyVaultCertificateTimeouts) : KeyVaultCertificateState<'KeyVaultId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : KeyVaultCertificateState<'KeyVaultId, 'Name>

        member _.Run(state: KeyVaultCertificateState<Present, Present>) : azurerm.KeyVaultCertificate.KeyVaultCertificate =
            let config = azurerm.KeyVaultCertificate.KeyVaultCertificateConfig()
            for setter in state.assignments do
                setter config
            azurerm.KeyVaultCertificate.KeyVaultCertificate(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.keyVaultCertificate: missing required arguments. Must call: key_vault_id, name.", 9999, IsError = true)>]
        member _.Run(_: KeyVaultCertificateState<_, _>) : azurerm.KeyVaultCertificate.KeyVaultCertificate =
            Unchecked.defaultof<azurerm.KeyVaultCertificate.KeyVaultCertificate>

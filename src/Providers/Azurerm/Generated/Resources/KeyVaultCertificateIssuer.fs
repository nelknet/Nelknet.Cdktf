namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type KeyVaultCertificateIssuerState<'KeyVaultId, 'Name, 'ProviderName> = { assignments: ResizeArray<azurerm.KeyVaultCertificateIssuer.KeyVaultCertificateIssuerConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_certificate_issuer">azurerm_key_vault_certificate_issuer</a>.
    /// </summary>
    type KeyVaultCertificateIssuerBuilder(logicalId: string) =
        member _.Yield(_: unit) : KeyVaultCertificateIssuerState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : KeyVaultCertificateIssuerState<Missing, Missing, Missing>)

        member _.Zero(()) : KeyVaultCertificateIssuerState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : KeyVaultCertificateIssuerState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_certificate_issuer#key_vault_id-1">KeyVaultCertificateIssuer#key_vault_id</a>.
        /// </summary>
        [<CustomOperation "key_vault_id">]
        member _.KeyVaultId(state: KeyVaultCertificateIssuerState<Missing, 'Name, 'ProviderName>, value: string) : KeyVaultCertificateIssuerState<Present, 'Name, 'ProviderName> =
            state.assignments.Add(fun config -> config.KeyVaultId <- value)
            ({ assignments = state.assignments } : KeyVaultCertificateIssuerState<Present, 'Name, 'ProviderName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_certificate_issuer#name-1">KeyVaultCertificateIssuer#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: KeyVaultCertificateIssuerState<'KeyVaultId, Missing, 'ProviderName>, value: string) : KeyVaultCertificateIssuerState<'KeyVaultId, Present, 'ProviderName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : KeyVaultCertificateIssuerState<'KeyVaultId, Present, 'ProviderName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_certificate_issuer#provider_name-1">KeyVaultCertificateIssuer#provider_name</a>.
        /// </summary>
        [<CustomOperation "provider_name">]
        member _.ProviderName(state: KeyVaultCertificateIssuerState<'KeyVaultId, 'Name, Missing>, value: string) : KeyVaultCertificateIssuerState<'KeyVaultId, 'Name, Present> =
            state.assignments.Add(fun config -> config.ProviderName <- value)
            ({ assignments = state.assignments } : KeyVaultCertificateIssuerState<'KeyVaultId, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_certificate_issuer#account_id-1">KeyVaultCertificateIssuer#account_id</a>.
        /// </summary>
        [<CustomOperation "account_id">]
        member _.AccountId(state: KeyVaultCertificateIssuerState<'KeyVaultId, 'Name, 'ProviderName>, value: string) : KeyVaultCertificateIssuerState<'KeyVaultId, 'Name, 'ProviderName> =
            state.assignments.Add(fun config -> config.AccountId <- value)
            state : KeyVaultCertificateIssuerState<'KeyVaultId, 'Name, 'ProviderName>

        /// <summary>
        /// admin block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_certificate_issuer#admin-1">KeyVaultCertificateIssuer#admin</a> Accepts: azurerm.IResolvable | azurerm.KeyVaultCertificateIssuer.KeyVaultCertificateIssuerAdmin[]
        /// </summary>
        [<CustomOperation "admin">]
        member _.Admin(state: KeyVaultCertificateIssuerState<'KeyVaultId, 'Name, 'ProviderName>, value: HashiCorp.Cdktf.IResolvable) : KeyVaultCertificateIssuerState<'KeyVaultId, 'Name, 'ProviderName> =
            state.assignments.Add(fun config -> config.Admin <- value)
            state : KeyVaultCertificateIssuerState<'KeyVaultId, 'Name, 'ProviderName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_certificate_issuer#id-1">KeyVaultCertificateIssuer#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: KeyVaultCertificateIssuerState<'KeyVaultId, 'Name, 'ProviderName>, value: string) : KeyVaultCertificateIssuerState<'KeyVaultId, 'Name, 'ProviderName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : KeyVaultCertificateIssuerState<'KeyVaultId, 'Name, 'ProviderName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_certificate_issuer#org_id-1">KeyVaultCertificateIssuer#org_id</a>.
        /// </summary>
        [<CustomOperation "org_id">]
        member _.OrgId(state: KeyVaultCertificateIssuerState<'KeyVaultId, 'Name, 'ProviderName>, value: string) : KeyVaultCertificateIssuerState<'KeyVaultId, 'Name, 'ProviderName> =
            state.assignments.Add(fun config -> config.OrgId <- value)
            state : KeyVaultCertificateIssuerState<'KeyVaultId, 'Name, 'ProviderName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_certificate_issuer#password-1">KeyVaultCertificateIssuer#password</a>.
        /// </summary>
        [<CustomOperation "password">]
        member _.Password(state: KeyVaultCertificateIssuerState<'KeyVaultId, 'Name, 'ProviderName>, value: string) : KeyVaultCertificateIssuerState<'KeyVaultId, 'Name, 'ProviderName> =
            state.assignments.Add(fun config -> config.Password <- value)
            state : KeyVaultCertificateIssuerState<'KeyVaultId, 'Name, 'ProviderName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_certificate_issuer#timeouts-1">KeyVaultCertificateIssuer#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: KeyVaultCertificateIssuerState<'KeyVaultId, 'Name, 'ProviderName>, value: azurerm.KeyVaultCertificateIssuer.KeyVaultCertificateIssuerTimeouts) : KeyVaultCertificateIssuerState<'KeyVaultId, 'Name, 'ProviderName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : KeyVaultCertificateIssuerState<'KeyVaultId, 'Name, 'ProviderName>

        member _.Run(state: KeyVaultCertificateIssuerState<Present, Present, Present>) : azurerm.KeyVaultCertificateIssuer.KeyVaultCertificateIssuer =
            let config = azurerm.KeyVaultCertificateIssuer.KeyVaultCertificateIssuerConfig()
            for setter in state.assignments do
                setter config
            azurerm.KeyVaultCertificateIssuer.KeyVaultCertificateIssuer(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.keyVaultCertificateIssuer: missing required arguments. Must call: key_vault_id, name, provider_name.", 9999, IsError = true)>]
        member _.Run(_: KeyVaultCertificateIssuerState<_, _, _>) : azurerm.KeyVaultCertificateIssuer.KeyVaultCertificateIssuer =
            Unchecked.defaultof<azurerm.KeyVaultCertificateIssuer.KeyVaultCertificateIssuer>

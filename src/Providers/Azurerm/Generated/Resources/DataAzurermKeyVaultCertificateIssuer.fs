namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermKeyVaultCertificateIssuerState<'KeyVaultId, 'Name> = { assignments: ResizeArray<azurerm.DataAzurermKeyVaultCertificateIssuer.DataAzurermKeyVaultCertificateIssuerConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/key_vault_certificate_issuer">azurerm_key_vault_certificate_issuer</a>.
    /// </summary>
    type DataAzurermKeyVaultCertificateIssuerBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermKeyVaultCertificateIssuerState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermKeyVaultCertificateIssuerState<Missing, Missing>)

        member _.Zero(()) : DataAzurermKeyVaultCertificateIssuerState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermKeyVaultCertificateIssuerState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/key_vault_certificate_issuer#key_vault_id-1">DataAzurermKeyVaultCertificateIssuer#key_vault_id</a>.
        /// </summary>
        [<CustomOperation "key_vault_id">]
        member _.KeyVaultId(state: DataAzurermKeyVaultCertificateIssuerState<Missing, 'Name>, value: string) : DataAzurermKeyVaultCertificateIssuerState<Present, 'Name> =
            state.assignments.Add(fun config -> config.KeyVaultId <- value)
            ({ assignments = state.assignments } : DataAzurermKeyVaultCertificateIssuerState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/key_vault_certificate_issuer#name-1">DataAzurermKeyVaultCertificateIssuer#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermKeyVaultCertificateIssuerState<'KeyVaultId, Missing>, value: string) : DataAzurermKeyVaultCertificateIssuerState<'KeyVaultId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermKeyVaultCertificateIssuerState<'KeyVaultId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/key_vault_certificate_issuer#id-1">DataAzurermKeyVaultCertificateIssuer#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermKeyVaultCertificateIssuerState<'KeyVaultId, 'Name>, value: string) : DataAzurermKeyVaultCertificateIssuerState<'KeyVaultId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermKeyVaultCertificateIssuerState<'KeyVaultId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/key_vault_certificate_issuer#timeouts-1">DataAzurermKeyVaultCertificateIssuer#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermKeyVaultCertificateIssuerState<'KeyVaultId, 'Name>, value: azurerm.DataAzurermKeyVaultCertificateIssuer.DataAzurermKeyVaultCertificateIssuerTimeouts) : DataAzurermKeyVaultCertificateIssuerState<'KeyVaultId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermKeyVaultCertificateIssuerState<'KeyVaultId, 'Name>

        member _.Run(state: DataAzurermKeyVaultCertificateIssuerState<Present, Present>) : azurerm.DataAzurermKeyVaultCertificateIssuer.DataAzurermKeyVaultCertificateIssuer =
            let config = azurerm.DataAzurermKeyVaultCertificateIssuer.DataAzurermKeyVaultCertificateIssuerConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermKeyVaultCertificateIssuer.DataAzurermKeyVaultCertificateIssuer(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermKeyVaultCertificateIssuer: missing required arguments. Must call: key_vault_id, name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermKeyVaultCertificateIssuerState<_, _>) : azurerm.DataAzurermKeyVaultCertificateIssuer.DataAzurermKeyVaultCertificateIssuer =
            Unchecked.defaultof<azurerm.DataAzurermKeyVaultCertificateIssuer.DataAzurermKeyVaultCertificateIssuer>

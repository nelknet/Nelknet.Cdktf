namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermKeyVaultCertificateState<'KeyVaultId, 'Name> = { assignments: ResizeArray<azurerm.DataAzurermKeyVaultCertificate.DataAzurermKeyVaultCertificateConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/key_vault_certificate">azurerm_key_vault_certificate</a>.
    /// </summary>
    type DataAzurermKeyVaultCertificateBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermKeyVaultCertificateState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermKeyVaultCertificateState<Missing, Missing>)

        member _.Zero(()) : DataAzurermKeyVaultCertificateState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermKeyVaultCertificateState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/key_vault_certificate#key_vault_id-1">DataAzurermKeyVaultCertificate#key_vault_id</a>.
        /// </summary>
        [<CustomOperation "key_vault_id">]
        member _.KeyVaultId(state: DataAzurermKeyVaultCertificateState<Missing, 'Name>, value: string) : DataAzurermKeyVaultCertificateState<Present, 'Name> =
            state.assignments.Add(fun config -> config.KeyVaultId <- value)
            ({ assignments = state.assignments } : DataAzurermKeyVaultCertificateState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/key_vault_certificate#name-1">DataAzurermKeyVaultCertificate#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermKeyVaultCertificateState<'KeyVaultId, Missing>, value: string) : DataAzurermKeyVaultCertificateState<'KeyVaultId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermKeyVaultCertificateState<'KeyVaultId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/key_vault_certificate#id-1">DataAzurermKeyVaultCertificate#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermKeyVaultCertificateState<'KeyVaultId, 'Name>, value: string) : DataAzurermKeyVaultCertificateState<'KeyVaultId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermKeyVaultCertificateState<'KeyVaultId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/key_vault_certificate#timeouts-1">DataAzurermKeyVaultCertificate#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermKeyVaultCertificateState<'KeyVaultId, 'Name>, value: azurerm.DataAzurermKeyVaultCertificate.DataAzurermKeyVaultCertificateTimeouts) : DataAzurermKeyVaultCertificateState<'KeyVaultId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermKeyVaultCertificateState<'KeyVaultId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/key_vault_certificate#version-1">DataAzurermKeyVaultCertificate#version</a>.
        /// </summary>
        [<CustomOperation "version">]
        member _.Version(state: DataAzurermKeyVaultCertificateState<'KeyVaultId, 'Name>, value: string) : DataAzurermKeyVaultCertificateState<'KeyVaultId, 'Name> =
            state.assignments.Add(fun config -> config.Version <- value)
            state : DataAzurermKeyVaultCertificateState<'KeyVaultId, 'Name>

        member _.Run(state: DataAzurermKeyVaultCertificateState<Present, Present>) : azurerm.DataAzurermKeyVaultCertificate.DataAzurermKeyVaultCertificate =
            let config = azurerm.DataAzurermKeyVaultCertificate.DataAzurermKeyVaultCertificateConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermKeyVaultCertificate.DataAzurermKeyVaultCertificate(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermKeyVaultCertificate: missing required arguments. Must call: key_vault_id, name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermKeyVaultCertificateState<_, _>) : azurerm.DataAzurermKeyVaultCertificate.DataAzurermKeyVaultCertificate =
            Unchecked.defaultof<azurerm.DataAzurermKeyVaultCertificate.DataAzurermKeyVaultCertificate>

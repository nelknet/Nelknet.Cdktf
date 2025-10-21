namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermKeyVaultCertificateDataState<'KeyVaultId, 'Name> = { assignments: ResizeArray<azurerm.DataAzurermKeyVaultCertificateData.DataAzurermKeyVaultCertificateDataConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/key_vault_certificate_data">azurerm_key_vault_certificate_data</a>.
    /// </summary>
    type DataAzurermKeyVaultCertificateDataBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermKeyVaultCertificateDataState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermKeyVaultCertificateDataState<Missing, Missing>)

        member _.Zero(()) : DataAzurermKeyVaultCertificateDataState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermKeyVaultCertificateDataState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/key_vault_certificate_data#key_vault_id-1">DataAzurermKeyVaultCertificateData#key_vault_id</a>.
        /// </summary>
        [<CustomOperation "key_vault_id">]
        member _.KeyVaultId(state: DataAzurermKeyVaultCertificateDataState<Missing, 'Name>, value: string) : DataAzurermKeyVaultCertificateDataState<Present, 'Name> =
            state.assignments.Add(fun config -> config.KeyVaultId <- value)
            ({ assignments = state.assignments } : DataAzurermKeyVaultCertificateDataState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/key_vault_certificate_data#name-1">DataAzurermKeyVaultCertificateData#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermKeyVaultCertificateDataState<'KeyVaultId, Missing>, value: string) : DataAzurermKeyVaultCertificateDataState<'KeyVaultId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermKeyVaultCertificateDataState<'KeyVaultId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/key_vault_certificate_data#id-1">DataAzurermKeyVaultCertificateData#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermKeyVaultCertificateDataState<'KeyVaultId, 'Name>, value: string) : DataAzurermKeyVaultCertificateDataState<'KeyVaultId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermKeyVaultCertificateDataState<'KeyVaultId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/key_vault_certificate_data#timeouts-1">DataAzurermKeyVaultCertificateData#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermKeyVaultCertificateDataState<'KeyVaultId, 'Name>, value: azurerm.DataAzurermKeyVaultCertificateData.DataAzurermKeyVaultCertificateDataTimeouts) : DataAzurermKeyVaultCertificateDataState<'KeyVaultId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermKeyVaultCertificateDataState<'KeyVaultId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/key_vault_certificate_data#version-1">DataAzurermKeyVaultCertificateData#version</a>.
        /// </summary>
        [<CustomOperation "version">]
        member _.Version(state: DataAzurermKeyVaultCertificateDataState<'KeyVaultId, 'Name>, value: string) : DataAzurermKeyVaultCertificateDataState<'KeyVaultId, 'Name> =
            state.assignments.Add(fun config -> config.Version <- value)
            state : DataAzurermKeyVaultCertificateDataState<'KeyVaultId, 'Name>

        member _.Run(state: DataAzurermKeyVaultCertificateDataState<Present, Present>) : azurerm.DataAzurermKeyVaultCertificateData.DataAzurermKeyVaultCertificateData =
            let config = azurerm.DataAzurermKeyVaultCertificateData.DataAzurermKeyVaultCertificateDataConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermKeyVaultCertificateData.DataAzurermKeyVaultCertificateData(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermKeyVaultCertificateData: missing required arguments. Must call: key_vault_id, name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermKeyVaultCertificateDataState<_, _>) : azurerm.DataAzurermKeyVaultCertificateData.DataAzurermKeyVaultCertificateData =
            Unchecked.defaultof<azurerm.DataAzurermKeyVaultCertificateData.DataAzurermKeyVaultCertificateData>

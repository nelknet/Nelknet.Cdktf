namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermKeyVaultCertificatesState<'KeyVaultId> = { assignments: ResizeArray<azurerm.DataAzurermKeyVaultCertificates.DataAzurermKeyVaultCertificatesConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/key_vault_certificates">azurerm_key_vault_certificates</a>.
    /// </summary>
    type DataAzurermKeyVaultCertificatesBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermKeyVaultCertificatesState<Missing> =
            ({ assignments = ResizeArray() } : DataAzurermKeyVaultCertificatesState<Missing>)

        member _.Zero(()) : DataAzurermKeyVaultCertificatesState<Missing> =
            ({ assignments = ResizeArray() } : DataAzurermKeyVaultCertificatesState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/key_vault_certificates#key_vault_id-1">DataAzurermKeyVaultCertificates#key_vault_id</a>.
        /// </summary>
        [<CustomOperation "key_vault_id">]
        member _.KeyVaultId(state: DataAzurermKeyVaultCertificatesState<Missing>, value: string) : DataAzurermKeyVaultCertificatesState<Present> =
            state.assignments.Add(fun config -> config.KeyVaultId <- value)
            ({ assignments = state.assignments } : DataAzurermKeyVaultCertificatesState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/key_vault_certificates#id-1">DataAzurermKeyVaultCertificates#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermKeyVaultCertificatesState<'KeyVaultId>, value: string) : DataAzurermKeyVaultCertificatesState<'KeyVaultId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermKeyVaultCertificatesState<'KeyVaultId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/key_vault_certificates#include_pending-1">DataAzurermKeyVaultCertificates#include_pending</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "include_pending">]
        member _.IncludePending(state: DataAzurermKeyVaultCertificatesState<'KeyVaultId>, value: bool) : DataAzurermKeyVaultCertificatesState<'KeyVaultId> =
            state.assignments.Add(fun config -> config.IncludePending <- value)
            state : DataAzurermKeyVaultCertificatesState<'KeyVaultId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/key_vault_certificates#include_pending-1">DataAzurermKeyVaultCertificates#include_pending</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "include_pending">]
        member _.IncludePending(state: DataAzurermKeyVaultCertificatesState<'KeyVaultId>, value: HashiCorp.Cdktf.IResolvable) : DataAzurermKeyVaultCertificatesState<'KeyVaultId> =
            state.assignments.Add(fun config -> config.IncludePending <- value)
            state : DataAzurermKeyVaultCertificatesState<'KeyVaultId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/key_vault_certificates#timeouts-1">DataAzurermKeyVaultCertificates#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermKeyVaultCertificatesState<'KeyVaultId>, value: azurerm.DataAzurermKeyVaultCertificates.DataAzurermKeyVaultCertificatesTimeouts) : DataAzurermKeyVaultCertificatesState<'KeyVaultId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermKeyVaultCertificatesState<'KeyVaultId>

        member _.Run(state: DataAzurermKeyVaultCertificatesState<Present>) : azurerm.DataAzurermKeyVaultCertificates.DataAzurermKeyVaultCertificates =
            let config = azurerm.DataAzurermKeyVaultCertificates.DataAzurermKeyVaultCertificatesConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermKeyVaultCertificates.DataAzurermKeyVaultCertificates(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermKeyVaultCertificates: missing required arguments. Must call: key_vault_id.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermKeyVaultCertificatesState<_>) : azurerm.DataAzurermKeyVaultCertificates.DataAzurermKeyVaultCertificates =
            Unchecked.defaultof<azurerm.DataAzurermKeyVaultCertificates.DataAzurermKeyVaultCertificates>

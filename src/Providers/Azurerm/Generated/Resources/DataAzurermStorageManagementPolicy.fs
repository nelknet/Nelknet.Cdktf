namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermStorageManagementPolicyState<'StorageAccountId> = { assignments: ResizeArray<azurerm.DataAzurermStorageManagementPolicy.DataAzurermStorageManagementPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_management_policy">azurerm_storage_management_policy</a>.
    /// </summary>
    type DataAzurermStorageManagementPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermStorageManagementPolicyState<Missing> =
            ({ assignments = ResizeArray() } : DataAzurermStorageManagementPolicyState<Missing>)

        member _.Zero(()) : DataAzurermStorageManagementPolicyState<Missing> =
            ({ assignments = ResizeArray() } : DataAzurermStorageManagementPolicyState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_management_policy#storage_account_id-1">DataAzurermStorageManagementPolicy#storage_account_id</a>.
        /// </summary>
        [<CustomOperation "storage_account_id">]
        member _.StorageAccountId(state: DataAzurermStorageManagementPolicyState<Missing>, value: string) : DataAzurermStorageManagementPolicyState<Present> =
            state.assignments.Add(fun config -> config.StorageAccountId <- value)
            ({ assignments = state.assignments } : DataAzurermStorageManagementPolicyState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_management_policy#id-1">DataAzurermStorageManagementPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermStorageManagementPolicyState<'StorageAccountId>, value: string) : DataAzurermStorageManagementPolicyState<'StorageAccountId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermStorageManagementPolicyState<'StorageAccountId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_management_policy#timeouts-1">DataAzurermStorageManagementPolicy#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermStorageManagementPolicyState<'StorageAccountId>, value: azurerm.DataAzurermStorageManagementPolicy.DataAzurermStorageManagementPolicyTimeouts) : DataAzurermStorageManagementPolicyState<'StorageAccountId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermStorageManagementPolicyState<'StorageAccountId>

        member _.Run(state: DataAzurermStorageManagementPolicyState<Present>) : azurerm.DataAzurermStorageManagementPolicy.DataAzurermStorageManagementPolicy =
            let config = azurerm.DataAzurermStorageManagementPolicy.DataAzurermStorageManagementPolicyConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermStorageManagementPolicy.DataAzurermStorageManagementPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermStorageManagementPolicy: missing required arguments. Must call: storage_account_id.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermStorageManagementPolicyState<_>) : azurerm.DataAzurermStorageManagementPolicy.DataAzurermStorageManagementPolicy =
            Unchecked.defaultof<azurerm.DataAzurermStorageManagementPolicy.DataAzurermStorageManagementPolicy>

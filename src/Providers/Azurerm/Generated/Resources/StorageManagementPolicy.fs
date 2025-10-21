namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type StorageManagementPolicyState<'StorageAccountId> = { assignments: ResizeArray<azurerm.StorageManagementPolicy.StorageManagementPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_management_policy">azurerm_storage_management_policy</a>.
    /// </summary>
    type StorageManagementPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : StorageManagementPolicyState<Missing> =
            ({ assignments = ResizeArray() } : StorageManagementPolicyState<Missing>)

        member _.Zero(()) : StorageManagementPolicyState<Missing> =
            ({ assignments = ResizeArray() } : StorageManagementPolicyState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_management_policy#storage_account_id-1">StorageManagementPolicy#storage_account_id</a>.
        /// </summary>
        [<CustomOperation "storage_account_id">]
        member _.StorageAccountId(state: StorageManagementPolicyState<Missing>, value: string) : StorageManagementPolicyState<Present> =
            state.assignments.Add(fun config -> config.StorageAccountId <- value)
            ({ assignments = state.assignments } : StorageManagementPolicyState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_management_policy#id-1">StorageManagementPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: StorageManagementPolicyState<'StorageAccountId>, value: string) : StorageManagementPolicyState<'StorageAccountId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : StorageManagementPolicyState<'StorageAccountId>

        /// <summary>
        /// rule block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_management_policy#rule-1">StorageManagementPolicy#rule</a> Accepts: azurerm.IResolvable | azurerm.StorageManagementPolicy.StorageManagementPolicyRule[]
        /// </summary>
        [<CustomOperation "rule">]
        member _.Rule(state: StorageManagementPolicyState<'StorageAccountId>, value: HashiCorp.Cdktf.IResolvable) : StorageManagementPolicyState<'StorageAccountId> =
            state.assignments.Add(fun config -> config.Rule <- value)
            state : StorageManagementPolicyState<'StorageAccountId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_management_policy#timeouts-1">StorageManagementPolicy#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: StorageManagementPolicyState<'StorageAccountId>, value: azurerm.StorageManagementPolicy.StorageManagementPolicyTimeouts) : StorageManagementPolicyState<'StorageAccountId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : StorageManagementPolicyState<'StorageAccountId>

        member _.Run(state: StorageManagementPolicyState<Present>) : azurerm.StorageManagementPolicy.StorageManagementPolicy =
            let config = azurerm.StorageManagementPolicy.StorageManagementPolicyConfig()
            for setter in state.assignments do
                setter config
            azurerm.StorageManagementPolicy.StorageManagementPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.storageManagementPolicy: missing required arguments. Must call: storage_account_id.", 9999, IsError = true)>]
        member _.Run(_: StorageManagementPolicyState<_>) : azurerm.StorageManagementPolicy.StorageManagementPolicy =
            Unchecked.defaultof<azurerm.StorageManagementPolicy.StorageManagementPolicy>

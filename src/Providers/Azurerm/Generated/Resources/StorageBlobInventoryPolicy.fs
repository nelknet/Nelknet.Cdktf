namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type StorageBlobInventoryPolicyState<'Rules, 'StorageAccountId> = { assignments: ResizeArray<azurerm.StorageBlobInventoryPolicy.StorageBlobInventoryPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_blob_inventory_policy">azurerm_storage_blob_inventory_policy</a>.
    /// </summary>
    type StorageBlobInventoryPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : StorageBlobInventoryPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : StorageBlobInventoryPolicyState<Missing, Missing>)

        member _.Zero(()) : StorageBlobInventoryPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : StorageBlobInventoryPolicyState<Missing, Missing>)

        /// <summary>
        /// rules block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_blob_inventory_policy#rules-1">StorageBlobInventoryPolicy#rules</a> Accepts: azurerm.IResolvable | azurerm.StorageBlobInventoryPolicy.StorageBlobInventoryPolicyRules[]
        /// </summary>
        [<CustomOperation "rules">]
        member _.Rules(state: StorageBlobInventoryPolicyState<Missing, 'StorageAccountId>, value: HashiCorp.Cdktf.IResolvable) : StorageBlobInventoryPolicyState<Present, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.Rules <- value)
            ({ assignments = state.assignments } : StorageBlobInventoryPolicyState<Present, 'StorageAccountId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_blob_inventory_policy#storage_account_id-1">StorageBlobInventoryPolicy#storage_account_id</a>.
        /// </summary>
        [<CustomOperation "storage_account_id">]
        member _.StorageAccountId(state: StorageBlobInventoryPolicyState<'Rules, Missing>, value: string) : StorageBlobInventoryPolicyState<'Rules, Present> =
            state.assignments.Add(fun config -> config.StorageAccountId <- value)
            ({ assignments = state.assignments } : StorageBlobInventoryPolicyState<'Rules, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_blob_inventory_policy#id-1">StorageBlobInventoryPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: StorageBlobInventoryPolicyState<'Rules, 'StorageAccountId>, value: string) : StorageBlobInventoryPolicyState<'Rules, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : StorageBlobInventoryPolicyState<'Rules, 'StorageAccountId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_blob_inventory_policy#timeouts-1">StorageBlobInventoryPolicy#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: StorageBlobInventoryPolicyState<'Rules, 'StorageAccountId>, value: azurerm.StorageBlobInventoryPolicy.StorageBlobInventoryPolicyTimeouts) : StorageBlobInventoryPolicyState<'Rules, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : StorageBlobInventoryPolicyState<'Rules, 'StorageAccountId>

        member _.Run(state: StorageBlobInventoryPolicyState<Present, Present>) : azurerm.StorageBlobInventoryPolicy.StorageBlobInventoryPolicy =
            let config = azurerm.StorageBlobInventoryPolicy.StorageBlobInventoryPolicyConfig()
            for setter in state.assignments do
                setter config
            azurerm.StorageBlobInventoryPolicy.StorageBlobInventoryPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.storageBlobInventoryPolicy: missing required arguments. Must call: rules, storage_account_id.", 9999, IsError = true)>]
        member _.Run(_: StorageBlobInventoryPolicyState<_, _>) : azurerm.StorageBlobInventoryPolicy.StorageBlobInventoryPolicy =
            Unchecked.defaultof<azurerm.StorageBlobInventoryPolicy.StorageBlobInventoryPolicy>

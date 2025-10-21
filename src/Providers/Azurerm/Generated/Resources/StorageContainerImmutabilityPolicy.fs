namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type StorageContainerImmutabilityPolicyState<'ImmutabilityPeriodInDays, 'StorageContainerResourceManagerId> = { assignments: ResizeArray<azurerm.StorageContainerImmutabilityPolicy.StorageContainerImmutabilityPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_container_immutability_policy">azurerm_storage_container_immutability_policy</a>.
    /// </summary>
    type StorageContainerImmutabilityPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : StorageContainerImmutabilityPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : StorageContainerImmutabilityPolicyState<Missing, Missing>)

        member _.Zero(()) : StorageContainerImmutabilityPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : StorageContainerImmutabilityPolicyState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_container_immutability_policy#immutability_period_in_days-1">StorageContainerImmutabilityPolicy#immutability_period_in_days</a>.
        /// </summary>
        [<CustomOperation "immutability_period_in_days">]
        member _.ImmutabilityPeriodInDays(state: StorageContainerImmutabilityPolicyState<Missing, 'StorageContainerResourceManagerId>, value: double) : StorageContainerImmutabilityPolicyState<Present, 'StorageContainerResourceManagerId> =
            state.assignments.Add(fun config -> config.ImmutabilityPeriodInDays <- value)
            ({ assignments = state.assignments } : StorageContainerImmutabilityPolicyState<Present, 'StorageContainerResourceManagerId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_container_immutability_policy#storage_container_resource_manager_id-1">StorageContainerImmutabilityPolicy#storage_container_resource_manager_id</a>.
        /// </summary>
        [<CustomOperation "storage_container_resource_manager_id">]
        member _.StorageContainerResourceManagerId(state: StorageContainerImmutabilityPolicyState<'ImmutabilityPeriodInDays, Missing>, value: string) : StorageContainerImmutabilityPolicyState<'ImmutabilityPeriodInDays, Present> =
            state.assignments.Add(fun config -> config.StorageContainerResourceManagerId <- value)
            ({ assignments = state.assignments } : StorageContainerImmutabilityPolicyState<'ImmutabilityPeriodInDays, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_container_immutability_policy#id-1">StorageContainerImmutabilityPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: StorageContainerImmutabilityPolicyState<'ImmutabilityPeriodInDays, 'StorageContainerResourceManagerId>, value: string) : StorageContainerImmutabilityPolicyState<'ImmutabilityPeriodInDays, 'StorageContainerResourceManagerId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : StorageContainerImmutabilityPolicyState<'ImmutabilityPeriodInDays, 'StorageContainerResourceManagerId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_container_immutability_policy#locked-1">StorageContainerImmutabilityPolicy#locked</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "locked">]
        member _.Locked(state: StorageContainerImmutabilityPolicyState<'ImmutabilityPeriodInDays, 'StorageContainerResourceManagerId>, value: bool) : StorageContainerImmutabilityPolicyState<'ImmutabilityPeriodInDays, 'StorageContainerResourceManagerId> =
            state.assignments.Add(fun config -> config.Locked <- value)
            state : StorageContainerImmutabilityPolicyState<'ImmutabilityPeriodInDays, 'StorageContainerResourceManagerId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_container_immutability_policy#locked-1">StorageContainerImmutabilityPolicy#locked</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "locked">]
        member _.Locked(state: StorageContainerImmutabilityPolicyState<'ImmutabilityPeriodInDays, 'StorageContainerResourceManagerId>, value: HashiCorp.Cdktf.IResolvable) : StorageContainerImmutabilityPolicyState<'ImmutabilityPeriodInDays, 'StorageContainerResourceManagerId> =
            state.assignments.Add(fun config -> config.Locked <- value)
            state : StorageContainerImmutabilityPolicyState<'ImmutabilityPeriodInDays, 'StorageContainerResourceManagerId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_container_immutability_policy#protected_append_writes_all_enabled-1">StorageContainerImmutabilityPolicy#protected_append_writes_all_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "protected_append_writes_all_enabled">]
        member _.ProtectedAppendWritesAllEnabled(state: StorageContainerImmutabilityPolicyState<'ImmutabilityPeriodInDays, 'StorageContainerResourceManagerId>, value: bool) : StorageContainerImmutabilityPolicyState<'ImmutabilityPeriodInDays, 'StorageContainerResourceManagerId> =
            state.assignments.Add(fun config -> config.ProtectedAppendWritesAllEnabled <- value)
            state : StorageContainerImmutabilityPolicyState<'ImmutabilityPeriodInDays, 'StorageContainerResourceManagerId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_container_immutability_policy#protected_append_writes_all_enabled-1">StorageContainerImmutabilityPolicy#protected_append_writes_all_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "protected_append_writes_all_enabled">]
        member _.ProtectedAppendWritesAllEnabled(state: StorageContainerImmutabilityPolicyState<'ImmutabilityPeriodInDays, 'StorageContainerResourceManagerId>, value: HashiCorp.Cdktf.IResolvable) : StorageContainerImmutabilityPolicyState<'ImmutabilityPeriodInDays, 'StorageContainerResourceManagerId> =
            state.assignments.Add(fun config -> config.ProtectedAppendWritesAllEnabled <- value)
            state : StorageContainerImmutabilityPolicyState<'ImmutabilityPeriodInDays, 'StorageContainerResourceManagerId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_container_immutability_policy#protected_append_writes_enabled-1">StorageContainerImmutabilityPolicy#protected_append_writes_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "protected_append_writes_enabled">]
        member _.ProtectedAppendWritesEnabled(state: StorageContainerImmutabilityPolicyState<'ImmutabilityPeriodInDays, 'StorageContainerResourceManagerId>, value: bool) : StorageContainerImmutabilityPolicyState<'ImmutabilityPeriodInDays, 'StorageContainerResourceManagerId> =
            state.assignments.Add(fun config -> config.ProtectedAppendWritesEnabled <- value)
            state : StorageContainerImmutabilityPolicyState<'ImmutabilityPeriodInDays, 'StorageContainerResourceManagerId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_container_immutability_policy#protected_append_writes_enabled-1">StorageContainerImmutabilityPolicy#protected_append_writes_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "protected_append_writes_enabled">]
        member _.ProtectedAppendWritesEnabled(state: StorageContainerImmutabilityPolicyState<'ImmutabilityPeriodInDays, 'StorageContainerResourceManagerId>, value: HashiCorp.Cdktf.IResolvable) : StorageContainerImmutabilityPolicyState<'ImmutabilityPeriodInDays, 'StorageContainerResourceManagerId> =
            state.assignments.Add(fun config -> config.ProtectedAppendWritesEnabled <- value)
            state : StorageContainerImmutabilityPolicyState<'ImmutabilityPeriodInDays, 'StorageContainerResourceManagerId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_container_immutability_policy#timeouts-1">StorageContainerImmutabilityPolicy#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: StorageContainerImmutabilityPolicyState<'ImmutabilityPeriodInDays, 'StorageContainerResourceManagerId>, value: azurerm.StorageContainerImmutabilityPolicy.StorageContainerImmutabilityPolicyTimeouts) : StorageContainerImmutabilityPolicyState<'ImmutabilityPeriodInDays, 'StorageContainerResourceManagerId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : StorageContainerImmutabilityPolicyState<'ImmutabilityPeriodInDays, 'StorageContainerResourceManagerId>

        member _.Run(state: StorageContainerImmutabilityPolicyState<Present, Present>) : azurerm.StorageContainerImmutabilityPolicy.StorageContainerImmutabilityPolicy =
            let config = azurerm.StorageContainerImmutabilityPolicy.StorageContainerImmutabilityPolicyConfig()
            for setter in state.assignments do
                setter config
            azurerm.StorageContainerImmutabilityPolicy.StorageContainerImmutabilityPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.storageContainerImmutabilityPolicy: missing required arguments. Must call: immutability_period_in_days, storage_container_resource_manager_id.", 9999, IsError = true)>]
        member _.Run(_: StorageContainerImmutabilityPolicyState<_, _>) : azurerm.StorageContainerImmutabilityPolicy.StorageContainerImmutabilityPolicy =
            Unchecked.defaultof<azurerm.StorageContainerImmutabilityPolicy.StorageContainerImmutabilityPolicy>

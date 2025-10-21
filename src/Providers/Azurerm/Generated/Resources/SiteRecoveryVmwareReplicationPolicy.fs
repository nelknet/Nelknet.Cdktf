namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SiteRecoveryVmwareReplicationPolicyState<'ApplicationConsistentSnapshotFrequencyInMinutes, 'Name, 'RecoveryPointRetentionInMinutes, 'RecoveryVaultId> = { assignments: ResizeArray<azurerm.SiteRecoveryVmwareReplicationPolicy.SiteRecoveryVmwareReplicationPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_vmware_replication_policy">azurerm_site_recovery_vmware_replication_policy</a>.
    /// </summary>
    type SiteRecoveryVmwareReplicationPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : SiteRecoveryVmwareReplicationPolicyState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SiteRecoveryVmwareReplicationPolicyState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : SiteRecoveryVmwareReplicationPolicyState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SiteRecoveryVmwareReplicationPolicyState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_vmware_replication_policy#application_consistent_snapshot_frequency_in_minutes-1">SiteRecoveryVmwareReplicationPolicy#application_consistent_snapshot_frequency_in_minutes</a>.
        /// </summary>
        [<CustomOperation "application_consistent_snapshot_frequency_in_minutes">]
        member _.ApplicationConsistentSnapshotFrequencyInMinutes(state: SiteRecoveryVmwareReplicationPolicyState<Missing, 'Name, 'RecoveryPointRetentionInMinutes, 'RecoveryVaultId>, value: double) : SiteRecoveryVmwareReplicationPolicyState<Present, 'Name, 'RecoveryPointRetentionInMinutes, 'RecoveryVaultId> =
            state.assignments.Add(fun config -> config.ApplicationConsistentSnapshotFrequencyInMinutes <- value)
            ({ assignments = state.assignments } : SiteRecoveryVmwareReplicationPolicyState<Present, 'Name, 'RecoveryPointRetentionInMinutes, 'RecoveryVaultId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_vmware_replication_policy#name-1">SiteRecoveryVmwareReplicationPolicy#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SiteRecoveryVmwareReplicationPolicyState<'ApplicationConsistentSnapshotFrequencyInMinutes, Missing, 'RecoveryPointRetentionInMinutes, 'RecoveryVaultId>, value: string) : SiteRecoveryVmwareReplicationPolicyState<'ApplicationConsistentSnapshotFrequencyInMinutes, Present, 'RecoveryPointRetentionInMinutes, 'RecoveryVaultId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SiteRecoveryVmwareReplicationPolicyState<'ApplicationConsistentSnapshotFrequencyInMinutes, Present, 'RecoveryPointRetentionInMinutes, 'RecoveryVaultId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_vmware_replication_policy#recovery_point_retention_in_minutes-1">SiteRecoveryVmwareReplicationPolicy#recovery_point_retention_in_minutes</a>.
        /// </summary>
        [<CustomOperation "recovery_point_retention_in_minutes">]
        member _.RecoveryPointRetentionInMinutes(state: SiteRecoveryVmwareReplicationPolicyState<'ApplicationConsistentSnapshotFrequencyInMinutes, 'Name, Missing, 'RecoveryVaultId>, value: double) : SiteRecoveryVmwareReplicationPolicyState<'ApplicationConsistentSnapshotFrequencyInMinutes, 'Name, Present, 'RecoveryVaultId> =
            state.assignments.Add(fun config -> config.RecoveryPointRetentionInMinutes <- value)
            ({ assignments = state.assignments } : SiteRecoveryVmwareReplicationPolicyState<'ApplicationConsistentSnapshotFrequencyInMinutes, 'Name, Present, 'RecoveryVaultId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_vmware_replication_policy#recovery_vault_id-1">SiteRecoveryVmwareReplicationPolicy#recovery_vault_id</a>.
        /// </summary>
        [<CustomOperation "recovery_vault_id">]
        member _.RecoveryVaultId(state: SiteRecoveryVmwareReplicationPolicyState<'ApplicationConsistentSnapshotFrequencyInMinutes, 'Name, 'RecoveryPointRetentionInMinutes, Missing>, value: string) : SiteRecoveryVmwareReplicationPolicyState<'ApplicationConsistentSnapshotFrequencyInMinutes, 'Name, 'RecoveryPointRetentionInMinutes, Present> =
            state.assignments.Add(fun config -> config.RecoveryVaultId <- value)
            ({ assignments = state.assignments } : SiteRecoveryVmwareReplicationPolicyState<'ApplicationConsistentSnapshotFrequencyInMinutes, 'Name, 'RecoveryPointRetentionInMinutes, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_vmware_replication_policy#id-1">SiteRecoveryVmwareReplicationPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SiteRecoveryVmwareReplicationPolicyState<'ApplicationConsistentSnapshotFrequencyInMinutes, 'Name, 'RecoveryPointRetentionInMinutes, 'RecoveryVaultId>, value: string) : SiteRecoveryVmwareReplicationPolicyState<'ApplicationConsistentSnapshotFrequencyInMinutes, 'Name, 'RecoveryPointRetentionInMinutes, 'RecoveryVaultId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SiteRecoveryVmwareReplicationPolicyState<'ApplicationConsistentSnapshotFrequencyInMinutes, 'Name, 'RecoveryPointRetentionInMinutes, 'RecoveryVaultId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_vmware_replication_policy#timeouts-1">SiteRecoveryVmwareReplicationPolicy#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SiteRecoveryVmwareReplicationPolicyState<'ApplicationConsistentSnapshotFrequencyInMinutes, 'Name, 'RecoveryPointRetentionInMinutes, 'RecoveryVaultId>, value: azurerm.SiteRecoveryVmwareReplicationPolicy.SiteRecoveryVmwareReplicationPolicyTimeouts) : SiteRecoveryVmwareReplicationPolicyState<'ApplicationConsistentSnapshotFrequencyInMinutes, 'Name, 'RecoveryPointRetentionInMinutes, 'RecoveryVaultId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SiteRecoveryVmwareReplicationPolicyState<'ApplicationConsistentSnapshotFrequencyInMinutes, 'Name, 'RecoveryPointRetentionInMinutes, 'RecoveryVaultId>

        member _.Run(state: SiteRecoveryVmwareReplicationPolicyState<Present, Present, Present, Present>) : azurerm.SiteRecoveryVmwareReplicationPolicy.SiteRecoveryVmwareReplicationPolicy =
            let config = azurerm.SiteRecoveryVmwareReplicationPolicy.SiteRecoveryVmwareReplicationPolicyConfig()
            for setter in state.assignments do
                setter config
            azurerm.SiteRecoveryVmwareReplicationPolicy.SiteRecoveryVmwareReplicationPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.siteRecoveryVmwareReplicationPolicy: missing required arguments. Must call: application_consistent_snapshot_frequency_in_minutes, name, recovery_point_retention_in_minutes, recovery_vault_id.", 9999, IsError = true)>]
        member _.Run(_: SiteRecoveryVmwareReplicationPolicyState<_, _, _, _>) : azurerm.SiteRecoveryVmwareReplicationPolicy.SiteRecoveryVmwareReplicationPolicy =
            Unchecked.defaultof<azurerm.SiteRecoveryVmwareReplicationPolicy.SiteRecoveryVmwareReplicationPolicy>

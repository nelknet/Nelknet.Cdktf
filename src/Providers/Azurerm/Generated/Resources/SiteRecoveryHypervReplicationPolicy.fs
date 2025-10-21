namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SiteRecoveryHypervReplicationPolicyState<'ApplicationConsistentSnapshotFrequencyInHours, 'Name, 'RecoveryPointRetentionInHours, 'RecoveryVaultId, 'ReplicationIntervalInSeconds> = { assignments: ResizeArray<azurerm.SiteRecoveryHypervReplicationPolicy.SiteRecoveryHypervReplicationPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_hyperv_replication_policy">azurerm_site_recovery_hyperv_replication_policy</a>.
    /// </summary>
    type SiteRecoveryHypervReplicationPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : SiteRecoveryHypervReplicationPolicyState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SiteRecoveryHypervReplicationPolicyState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : SiteRecoveryHypervReplicationPolicyState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SiteRecoveryHypervReplicationPolicyState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_hyperv_replication_policy#application_consistent_snapshot_frequency_in_hours-1">SiteRecoveryHypervReplicationPolicy#application_consistent_snapshot_frequency_in_hours</a>.
        /// </summary>
        [<CustomOperation "application_consistent_snapshot_frequency_in_hours">]
        member _.ApplicationConsistentSnapshotFrequencyInHours(state: SiteRecoveryHypervReplicationPolicyState<Missing, 'Name, 'RecoveryPointRetentionInHours, 'RecoveryVaultId, 'ReplicationIntervalInSeconds>, value: double) : SiteRecoveryHypervReplicationPolicyState<Present, 'Name, 'RecoveryPointRetentionInHours, 'RecoveryVaultId, 'ReplicationIntervalInSeconds> =
            state.assignments.Add(fun config -> config.ApplicationConsistentSnapshotFrequencyInHours <- value)
            ({ assignments = state.assignments } : SiteRecoveryHypervReplicationPolicyState<Present, 'Name, 'RecoveryPointRetentionInHours, 'RecoveryVaultId, 'ReplicationIntervalInSeconds>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_hyperv_replication_policy#name-1">SiteRecoveryHypervReplicationPolicy#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SiteRecoveryHypervReplicationPolicyState<'ApplicationConsistentSnapshotFrequencyInHours, Missing, 'RecoveryPointRetentionInHours, 'RecoveryVaultId, 'ReplicationIntervalInSeconds>, value: string) : SiteRecoveryHypervReplicationPolicyState<'ApplicationConsistentSnapshotFrequencyInHours, Present, 'RecoveryPointRetentionInHours, 'RecoveryVaultId, 'ReplicationIntervalInSeconds> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SiteRecoveryHypervReplicationPolicyState<'ApplicationConsistentSnapshotFrequencyInHours, Present, 'RecoveryPointRetentionInHours, 'RecoveryVaultId, 'ReplicationIntervalInSeconds>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_hyperv_replication_policy#recovery_point_retention_in_hours-1">SiteRecoveryHypervReplicationPolicy#recovery_point_retention_in_hours</a>.
        /// </summary>
        [<CustomOperation "recovery_point_retention_in_hours">]
        member _.RecoveryPointRetentionInHours(state: SiteRecoveryHypervReplicationPolicyState<'ApplicationConsistentSnapshotFrequencyInHours, 'Name, Missing, 'RecoveryVaultId, 'ReplicationIntervalInSeconds>, value: double) : SiteRecoveryHypervReplicationPolicyState<'ApplicationConsistentSnapshotFrequencyInHours, 'Name, Present, 'RecoveryVaultId, 'ReplicationIntervalInSeconds> =
            state.assignments.Add(fun config -> config.RecoveryPointRetentionInHours <- value)
            ({ assignments = state.assignments } : SiteRecoveryHypervReplicationPolicyState<'ApplicationConsistentSnapshotFrequencyInHours, 'Name, Present, 'RecoveryVaultId, 'ReplicationIntervalInSeconds>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_hyperv_replication_policy#recovery_vault_id-1">SiteRecoveryHypervReplicationPolicy#recovery_vault_id</a>.
        /// </summary>
        [<CustomOperation "recovery_vault_id">]
        member _.RecoveryVaultId(state: SiteRecoveryHypervReplicationPolicyState<'ApplicationConsistentSnapshotFrequencyInHours, 'Name, 'RecoveryPointRetentionInHours, Missing, 'ReplicationIntervalInSeconds>, value: string) : SiteRecoveryHypervReplicationPolicyState<'ApplicationConsistentSnapshotFrequencyInHours, 'Name, 'RecoveryPointRetentionInHours, Present, 'ReplicationIntervalInSeconds> =
            state.assignments.Add(fun config -> config.RecoveryVaultId <- value)
            ({ assignments = state.assignments } : SiteRecoveryHypervReplicationPolicyState<'ApplicationConsistentSnapshotFrequencyInHours, 'Name, 'RecoveryPointRetentionInHours, Present, 'ReplicationIntervalInSeconds>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_hyperv_replication_policy#replication_interval_in_seconds-1">SiteRecoveryHypervReplicationPolicy#replication_interval_in_seconds</a>.
        /// </summary>
        [<CustomOperation "replication_interval_in_seconds">]
        member _.ReplicationIntervalInSeconds(state: SiteRecoveryHypervReplicationPolicyState<'ApplicationConsistentSnapshotFrequencyInHours, 'Name, 'RecoveryPointRetentionInHours, 'RecoveryVaultId, Missing>, value: double) : SiteRecoveryHypervReplicationPolicyState<'ApplicationConsistentSnapshotFrequencyInHours, 'Name, 'RecoveryPointRetentionInHours, 'RecoveryVaultId, Present> =
            state.assignments.Add(fun config -> config.ReplicationIntervalInSeconds <- value)
            ({ assignments = state.assignments } : SiteRecoveryHypervReplicationPolicyState<'ApplicationConsistentSnapshotFrequencyInHours, 'Name, 'RecoveryPointRetentionInHours, 'RecoveryVaultId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_hyperv_replication_policy#id-1">SiteRecoveryHypervReplicationPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SiteRecoveryHypervReplicationPolicyState<'ApplicationConsistentSnapshotFrequencyInHours, 'Name, 'RecoveryPointRetentionInHours, 'RecoveryVaultId, 'ReplicationIntervalInSeconds>, value: string) : SiteRecoveryHypervReplicationPolicyState<'ApplicationConsistentSnapshotFrequencyInHours, 'Name, 'RecoveryPointRetentionInHours, 'RecoveryVaultId, 'ReplicationIntervalInSeconds> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SiteRecoveryHypervReplicationPolicyState<'ApplicationConsistentSnapshotFrequencyInHours, 'Name, 'RecoveryPointRetentionInHours, 'RecoveryVaultId, 'ReplicationIntervalInSeconds>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_hyperv_replication_policy#timeouts-1">SiteRecoveryHypervReplicationPolicy#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SiteRecoveryHypervReplicationPolicyState<'ApplicationConsistentSnapshotFrequencyInHours, 'Name, 'RecoveryPointRetentionInHours, 'RecoveryVaultId, 'ReplicationIntervalInSeconds>, value: azurerm.SiteRecoveryHypervReplicationPolicy.SiteRecoveryHypervReplicationPolicyTimeouts) : SiteRecoveryHypervReplicationPolicyState<'ApplicationConsistentSnapshotFrequencyInHours, 'Name, 'RecoveryPointRetentionInHours, 'RecoveryVaultId, 'ReplicationIntervalInSeconds> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SiteRecoveryHypervReplicationPolicyState<'ApplicationConsistentSnapshotFrequencyInHours, 'Name, 'RecoveryPointRetentionInHours, 'RecoveryVaultId, 'ReplicationIntervalInSeconds>

        member _.Run(state: SiteRecoveryHypervReplicationPolicyState<Present, Present, Present, Present, Present>) : azurerm.SiteRecoveryHypervReplicationPolicy.SiteRecoveryHypervReplicationPolicy =
            let config = azurerm.SiteRecoveryHypervReplicationPolicy.SiteRecoveryHypervReplicationPolicyConfig()
            for setter in state.assignments do
                setter config
            azurerm.SiteRecoveryHypervReplicationPolicy.SiteRecoveryHypervReplicationPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.siteRecoveryHypervReplicationPolicy: missing required arguments. Must call: application_consistent_snapshot_frequency_in_hours, name, recovery_point_retention_in_hours, recovery_vault_id, replication_interval_in_seconds.", 9999, IsError = true)>]
        member _.Run(_: SiteRecoveryHypervReplicationPolicyState<_, _, _, _, _>) : azurerm.SiteRecoveryHypervReplicationPolicy.SiteRecoveryHypervReplicationPolicy =
            Unchecked.defaultof<azurerm.SiteRecoveryHypervReplicationPolicy.SiteRecoveryHypervReplicationPolicy>

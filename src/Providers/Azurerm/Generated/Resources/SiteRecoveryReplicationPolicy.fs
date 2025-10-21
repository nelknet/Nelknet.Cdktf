namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SiteRecoveryReplicationPolicyState<'ApplicationConsistentSnapshotFrequencyInMinutes, 'Name, 'RecoveryPointRetentionInMinutes, 'RecoveryVaultName, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.SiteRecoveryReplicationPolicy.SiteRecoveryReplicationPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_replication_policy">azurerm_site_recovery_replication_policy</a>.
    /// </summary>
    type SiteRecoveryReplicationPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : SiteRecoveryReplicationPolicyState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SiteRecoveryReplicationPolicyState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : SiteRecoveryReplicationPolicyState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SiteRecoveryReplicationPolicyState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_replication_policy#application_consistent_snapshot_frequency_in_minutes-1">SiteRecoveryReplicationPolicy#application_consistent_snapshot_frequency_in_minutes</a>.
        /// </summary>
        [<CustomOperation "application_consistent_snapshot_frequency_in_minutes">]
        member _.ApplicationConsistentSnapshotFrequencyInMinutes(state: SiteRecoveryReplicationPolicyState<Missing, 'Name, 'RecoveryPointRetentionInMinutes, 'RecoveryVaultName, 'ResourceGroupName>, value: double) : SiteRecoveryReplicationPolicyState<Present, 'Name, 'RecoveryPointRetentionInMinutes, 'RecoveryVaultName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ApplicationConsistentSnapshotFrequencyInMinutes <- value)
            ({ assignments = state.assignments } : SiteRecoveryReplicationPolicyState<Present, 'Name, 'RecoveryPointRetentionInMinutes, 'RecoveryVaultName, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_replication_policy#name-1">SiteRecoveryReplicationPolicy#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SiteRecoveryReplicationPolicyState<'ApplicationConsistentSnapshotFrequencyInMinutes, Missing, 'RecoveryPointRetentionInMinutes, 'RecoveryVaultName, 'ResourceGroupName>, value: string) : SiteRecoveryReplicationPolicyState<'ApplicationConsistentSnapshotFrequencyInMinutes, Present, 'RecoveryPointRetentionInMinutes, 'RecoveryVaultName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SiteRecoveryReplicationPolicyState<'ApplicationConsistentSnapshotFrequencyInMinutes, Present, 'RecoveryPointRetentionInMinutes, 'RecoveryVaultName, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_replication_policy#recovery_point_retention_in_minutes-1">SiteRecoveryReplicationPolicy#recovery_point_retention_in_minutes</a>.
        /// </summary>
        [<CustomOperation "recovery_point_retention_in_minutes">]
        member _.RecoveryPointRetentionInMinutes(state: SiteRecoveryReplicationPolicyState<'ApplicationConsistentSnapshotFrequencyInMinutes, 'Name, Missing, 'RecoveryVaultName, 'ResourceGroupName>, value: double) : SiteRecoveryReplicationPolicyState<'ApplicationConsistentSnapshotFrequencyInMinutes, 'Name, Present, 'RecoveryVaultName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.RecoveryPointRetentionInMinutes <- value)
            ({ assignments = state.assignments } : SiteRecoveryReplicationPolicyState<'ApplicationConsistentSnapshotFrequencyInMinutes, 'Name, Present, 'RecoveryVaultName, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_replication_policy#recovery_vault_name-1">SiteRecoveryReplicationPolicy#recovery_vault_name</a>.
        /// </summary>
        [<CustomOperation "recovery_vault_name">]
        member _.RecoveryVaultName(state: SiteRecoveryReplicationPolicyState<'ApplicationConsistentSnapshotFrequencyInMinutes, 'Name, 'RecoveryPointRetentionInMinutes, Missing, 'ResourceGroupName>, value: string) : SiteRecoveryReplicationPolicyState<'ApplicationConsistentSnapshotFrequencyInMinutes, 'Name, 'RecoveryPointRetentionInMinutes, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.RecoveryVaultName <- value)
            ({ assignments = state.assignments } : SiteRecoveryReplicationPolicyState<'ApplicationConsistentSnapshotFrequencyInMinutes, 'Name, 'RecoveryPointRetentionInMinutes, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_replication_policy#resource_group_name-1">SiteRecoveryReplicationPolicy#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: SiteRecoveryReplicationPolicyState<'ApplicationConsistentSnapshotFrequencyInMinutes, 'Name, 'RecoveryPointRetentionInMinutes, 'RecoveryVaultName, Missing>, value: string) : SiteRecoveryReplicationPolicyState<'ApplicationConsistentSnapshotFrequencyInMinutes, 'Name, 'RecoveryPointRetentionInMinutes, 'RecoveryVaultName, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : SiteRecoveryReplicationPolicyState<'ApplicationConsistentSnapshotFrequencyInMinutes, 'Name, 'RecoveryPointRetentionInMinutes, 'RecoveryVaultName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_replication_policy#id-1">SiteRecoveryReplicationPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SiteRecoveryReplicationPolicyState<'ApplicationConsistentSnapshotFrequencyInMinutes, 'Name, 'RecoveryPointRetentionInMinutes, 'RecoveryVaultName, 'ResourceGroupName>, value: string) : SiteRecoveryReplicationPolicyState<'ApplicationConsistentSnapshotFrequencyInMinutes, 'Name, 'RecoveryPointRetentionInMinutes, 'RecoveryVaultName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SiteRecoveryReplicationPolicyState<'ApplicationConsistentSnapshotFrequencyInMinutes, 'Name, 'RecoveryPointRetentionInMinutes, 'RecoveryVaultName, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_replication_policy#timeouts-1">SiteRecoveryReplicationPolicy#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SiteRecoveryReplicationPolicyState<'ApplicationConsistentSnapshotFrequencyInMinutes, 'Name, 'RecoveryPointRetentionInMinutes, 'RecoveryVaultName, 'ResourceGroupName>, value: azurerm.SiteRecoveryReplicationPolicy.SiteRecoveryReplicationPolicyTimeouts) : SiteRecoveryReplicationPolicyState<'ApplicationConsistentSnapshotFrequencyInMinutes, 'Name, 'RecoveryPointRetentionInMinutes, 'RecoveryVaultName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SiteRecoveryReplicationPolicyState<'ApplicationConsistentSnapshotFrequencyInMinutes, 'Name, 'RecoveryPointRetentionInMinutes, 'RecoveryVaultName, 'ResourceGroupName>

        member _.Run(state: SiteRecoveryReplicationPolicyState<Present, Present, Present, Present, Present>) : azurerm.SiteRecoveryReplicationPolicy.SiteRecoveryReplicationPolicy =
            let config = azurerm.SiteRecoveryReplicationPolicy.SiteRecoveryReplicationPolicyConfig()
            for setter in state.assignments do
                setter config
            azurerm.SiteRecoveryReplicationPolicy.SiteRecoveryReplicationPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.siteRecoveryReplicationPolicy: missing required arguments. Must call: application_consistent_snapshot_frequency_in_minutes, name, recovery_point_retention_in_minutes, recovery_vault_name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: SiteRecoveryReplicationPolicyState<_, _, _, _, _>) : azurerm.SiteRecoveryReplicationPolicy.SiteRecoveryReplicationPolicy =
            Unchecked.defaultof<azurerm.SiteRecoveryReplicationPolicy.SiteRecoveryReplicationPolicy>

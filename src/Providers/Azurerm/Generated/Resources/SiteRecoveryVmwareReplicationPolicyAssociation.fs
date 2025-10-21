namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SiteRecoveryVmwareReplicationPolicyAssociationState<'Name, 'PolicyId, 'RecoveryVaultId> = { assignments: ResizeArray<azurerm.SiteRecoveryVmwareReplicationPolicyAssociation.SiteRecoveryVmwareReplicationPolicyAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_vmware_replication_policy_association">azurerm_site_recovery_vmware_replication_policy_association</a>.
    /// </summary>
    type SiteRecoveryVmwareReplicationPolicyAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : SiteRecoveryVmwareReplicationPolicyAssociationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SiteRecoveryVmwareReplicationPolicyAssociationState<Missing, Missing, Missing>)

        member _.Zero(()) : SiteRecoveryVmwareReplicationPolicyAssociationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SiteRecoveryVmwareReplicationPolicyAssociationState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_vmware_replication_policy_association#name-1">SiteRecoveryVmwareReplicationPolicyAssociation#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SiteRecoveryVmwareReplicationPolicyAssociationState<Missing, 'PolicyId, 'RecoveryVaultId>, value: string) : SiteRecoveryVmwareReplicationPolicyAssociationState<Present, 'PolicyId, 'RecoveryVaultId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SiteRecoveryVmwareReplicationPolicyAssociationState<Present, 'PolicyId, 'RecoveryVaultId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_vmware_replication_policy_association#policy_id-1">SiteRecoveryVmwareReplicationPolicyAssociation#policy_id</a>.
        /// </summary>
        [<CustomOperation "policy_id">]
        member _.PolicyId(state: SiteRecoveryVmwareReplicationPolicyAssociationState<'Name, Missing, 'RecoveryVaultId>, value: string) : SiteRecoveryVmwareReplicationPolicyAssociationState<'Name, Present, 'RecoveryVaultId> =
            state.assignments.Add(fun config -> config.PolicyId <- value)
            ({ assignments = state.assignments } : SiteRecoveryVmwareReplicationPolicyAssociationState<'Name, Present, 'RecoveryVaultId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_vmware_replication_policy_association#recovery_vault_id-1">SiteRecoveryVmwareReplicationPolicyAssociation#recovery_vault_id</a>.
        /// </summary>
        [<CustomOperation "recovery_vault_id">]
        member _.RecoveryVaultId(state: SiteRecoveryVmwareReplicationPolicyAssociationState<'Name, 'PolicyId, Missing>, value: string) : SiteRecoveryVmwareReplicationPolicyAssociationState<'Name, 'PolicyId, Present> =
            state.assignments.Add(fun config -> config.RecoveryVaultId <- value)
            ({ assignments = state.assignments } : SiteRecoveryVmwareReplicationPolicyAssociationState<'Name, 'PolicyId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_vmware_replication_policy_association#id-1">SiteRecoveryVmwareReplicationPolicyAssociation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SiteRecoveryVmwareReplicationPolicyAssociationState<'Name, 'PolicyId, 'RecoveryVaultId>, value: string) : SiteRecoveryVmwareReplicationPolicyAssociationState<'Name, 'PolicyId, 'RecoveryVaultId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SiteRecoveryVmwareReplicationPolicyAssociationState<'Name, 'PolicyId, 'RecoveryVaultId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_vmware_replication_policy_association#timeouts-1">SiteRecoveryVmwareReplicationPolicyAssociation#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SiteRecoveryVmwareReplicationPolicyAssociationState<'Name, 'PolicyId, 'RecoveryVaultId>, value: azurerm.SiteRecoveryVmwareReplicationPolicyAssociation.SiteRecoveryVmwareReplicationPolicyAssociationTimeouts) : SiteRecoveryVmwareReplicationPolicyAssociationState<'Name, 'PolicyId, 'RecoveryVaultId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SiteRecoveryVmwareReplicationPolicyAssociationState<'Name, 'PolicyId, 'RecoveryVaultId>

        member _.Run(state: SiteRecoveryVmwareReplicationPolicyAssociationState<Present, Present, Present>) : azurerm.SiteRecoveryVmwareReplicationPolicyAssociation.SiteRecoveryVmwareReplicationPolicyAssociation =
            let config = azurerm.SiteRecoveryVmwareReplicationPolicyAssociation.SiteRecoveryVmwareReplicationPolicyAssociationConfig()
            for setter in state.assignments do
                setter config
            azurerm.SiteRecoveryVmwareReplicationPolicyAssociation.SiteRecoveryVmwareReplicationPolicyAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.siteRecoveryVmwareReplicationPolicyAssociation: missing required arguments. Must call: name, policy_id, recovery_vault_id.", 9999, IsError = true)>]
        member _.Run(_: SiteRecoveryVmwareReplicationPolicyAssociationState<_, _, _>) : azurerm.SiteRecoveryVmwareReplicationPolicyAssociation.SiteRecoveryVmwareReplicationPolicyAssociation =
            Unchecked.defaultof<azurerm.SiteRecoveryVmwareReplicationPolicyAssociation.SiteRecoveryVmwareReplicationPolicyAssociation>

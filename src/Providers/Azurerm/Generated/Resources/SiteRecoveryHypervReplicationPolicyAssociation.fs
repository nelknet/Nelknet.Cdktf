namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SiteRecoveryHypervReplicationPolicyAssociationState<'HypervSiteId, 'Name, 'PolicyId> = { assignments: ResizeArray<azurerm.SiteRecoveryHypervReplicationPolicyAssociation.SiteRecoveryHypervReplicationPolicyAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_hyperv_replication_policy_association">azurerm_site_recovery_hyperv_replication_policy_association</a>.
    /// </summary>
    type SiteRecoveryHypervReplicationPolicyAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : SiteRecoveryHypervReplicationPolicyAssociationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SiteRecoveryHypervReplicationPolicyAssociationState<Missing, Missing, Missing>)

        member _.Zero(()) : SiteRecoveryHypervReplicationPolicyAssociationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SiteRecoveryHypervReplicationPolicyAssociationState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_hyperv_replication_policy_association#hyperv_site_id-1">SiteRecoveryHypervReplicationPolicyAssociation#hyperv_site_id</a>.
        /// </summary>
        [<CustomOperation "hyperv_site_id">]
        member _.HypervSiteId(state: SiteRecoveryHypervReplicationPolicyAssociationState<Missing, 'Name, 'PolicyId>, value: string) : SiteRecoveryHypervReplicationPolicyAssociationState<Present, 'Name, 'PolicyId> =
            state.assignments.Add(fun config -> config.HypervSiteId <- value)
            ({ assignments = state.assignments } : SiteRecoveryHypervReplicationPolicyAssociationState<Present, 'Name, 'PolicyId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_hyperv_replication_policy_association#name-1">SiteRecoveryHypervReplicationPolicyAssociation#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SiteRecoveryHypervReplicationPolicyAssociationState<'HypervSiteId, Missing, 'PolicyId>, value: string) : SiteRecoveryHypervReplicationPolicyAssociationState<'HypervSiteId, Present, 'PolicyId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SiteRecoveryHypervReplicationPolicyAssociationState<'HypervSiteId, Present, 'PolicyId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_hyperv_replication_policy_association#policy_id-1">SiteRecoveryHypervReplicationPolicyAssociation#policy_id</a>.
        /// </summary>
        [<CustomOperation "policy_id">]
        member _.PolicyId(state: SiteRecoveryHypervReplicationPolicyAssociationState<'HypervSiteId, 'Name, Missing>, value: string) : SiteRecoveryHypervReplicationPolicyAssociationState<'HypervSiteId, 'Name, Present> =
            state.assignments.Add(fun config -> config.PolicyId <- value)
            ({ assignments = state.assignments } : SiteRecoveryHypervReplicationPolicyAssociationState<'HypervSiteId, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_hyperv_replication_policy_association#id-1">SiteRecoveryHypervReplicationPolicyAssociation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SiteRecoveryHypervReplicationPolicyAssociationState<'HypervSiteId, 'Name, 'PolicyId>, value: string) : SiteRecoveryHypervReplicationPolicyAssociationState<'HypervSiteId, 'Name, 'PolicyId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SiteRecoveryHypervReplicationPolicyAssociationState<'HypervSiteId, 'Name, 'PolicyId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_hyperv_replication_policy_association#timeouts-1">SiteRecoveryHypervReplicationPolicyAssociation#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SiteRecoveryHypervReplicationPolicyAssociationState<'HypervSiteId, 'Name, 'PolicyId>, value: azurerm.SiteRecoveryHypervReplicationPolicyAssociation.SiteRecoveryHypervReplicationPolicyAssociationTimeouts) : SiteRecoveryHypervReplicationPolicyAssociationState<'HypervSiteId, 'Name, 'PolicyId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SiteRecoveryHypervReplicationPolicyAssociationState<'HypervSiteId, 'Name, 'PolicyId>

        member _.Run(state: SiteRecoveryHypervReplicationPolicyAssociationState<Present, Present, Present>) : azurerm.SiteRecoveryHypervReplicationPolicyAssociation.SiteRecoveryHypervReplicationPolicyAssociation =
            let config = azurerm.SiteRecoveryHypervReplicationPolicyAssociation.SiteRecoveryHypervReplicationPolicyAssociationConfig()
            for setter in state.assignments do
                setter config
            azurerm.SiteRecoveryHypervReplicationPolicyAssociation.SiteRecoveryHypervReplicationPolicyAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.siteRecoveryHypervReplicationPolicyAssociation: missing required arguments. Must call: hyperv_site_id, name, policy_id.", 9999, IsError = true)>]
        member _.Run(_: SiteRecoveryHypervReplicationPolicyAssociationState<_, _, _>) : azurerm.SiteRecoveryHypervReplicationPolicyAssociation.SiteRecoveryHypervReplicationPolicyAssociation =
            Unchecked.defaultof<azurerm.SiteRecoveryHypervReplicationPolicyAssociation.SiteRecoveryHypervReplicationPolicyAssociation>

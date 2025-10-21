namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermSiteRecoveryReplicationRecoveryPlanState<'Name, 'RecoveryVaultId> = { assignments: ResizeArray<azurerm.DataAzurermSiteRecoveryReplicationRecoveryPlan.DataAzurermSiteRecoveryReplicationRecoveryPlanConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/site_recovery_replication_recovery_plan">azurerm_site_recovery_replication_recovery_plan</a>.
    /// </summary>
    type DataAzurermSiteRecoveryReplicationRecoveryPlanBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermSiteRecoveryReplicationRecoveryPlanState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermSiteRecoveryReplicationRecoveryPlanState<Missing, Missing>)

        member _.Zero(()) : DataAzurermSiteRecoveryReplicationRecoveryPlanState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermSiteRecoveryReplicationRecoveryPlanState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/site_recovery_replication_recovery_plan#name-1">DataAzurermSiteRecoveryReplicationRecoveryPlan#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermSiteRecoveryReplicationRecoveryPlanState<Missing, 'RecoveryVaultId>, value: string) : DataAzurermSiteRecoveryReplicationRecoveryPlanState<Present, 'RecoveryVaultId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermSiteRecoveryReplicationRecoveryPlanState<Present, 'RecoveryVaultId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/site_recovery_replication_recovery_plan#recovery_vault_id-1">DataAzurermSiteRecoveryReplicationRecoveryPlan#recovery_vault_id</a>.
        /// </summary>
        [<CustomOperation "recovery_vault_id">]
        member _.RecoveryVaultId(state: DataAzurermSiteRecoveryReplicationRecoveryPlanState<'Name, Missing>, value: string) : DataAzurermSiteRecoveryReplicationRecoveryPlanState<'Name, Present> =
            state.assignments.Add(fun config -> config.RecoveryVaultId <- value)
            ({ assignments = state.assignments } : DataAzurermSiteRecoveryReplicationRecoveryPlanState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/site_recovery_replication_recovery_plan#id-1">DataAzurermSiteRecoveryReplicationRecoveryPlan#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermSiteRecoveryReplicationRecoveryPlanState<'Name, 'RecoveryVaultId>, value: string) : DataAzurermSiteRecoveryReplicationRecoveryPlanState<'Name, 'RecoveryVaultId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermSiteRecoveryReplicationRecoveryPlanState<'Name, 'RecoveryVaultId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/site_recovery_replication_recovery_plan#timeouts-1">DataAzurermSiteRecoveryReplicationRecoveryPlan#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermSiteRecoveryReplicationRecoveryPlanState<'Name, 'RecoveryVaultId>, value: azurerm.DataAzurermSiteRecoveryReplicationRecoveryPlan.DataAzurermSiteRecoveryReplicationRecoveryPlanTimeouts) : DataAzurermSiteRecoveryReplicationRecoveryPlanState<'Name, 'RecoveryVaultId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermSiteRecoveryReplicationRecoveryPlanState<'Name, 'RecoveryVaultId>

        member _.Run(state: DataAzurermSiteRecoveryReplicationRecoveryPlanState<Present, Present>) : azurerm.DataAzurermSiteRecoveryReplicationRecoveryPlan.DataAzurermSiteRecoveryReplicationRecoveryPlan =
            let config = azurerm.DataAzurermSiteRecoveryReplicationRecoveryPlan.DataAzurermSiteRecoveryReplicationRecoveryPlanConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermSiteRecoveryReplicationRecoveryPlan.DataAzurermSiteRecoveryReplicationRecoveryPlan(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermSiteRecoveryReplicationRecoveryPlan: missing required arguments. Must call: name, recovery_vault_id.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermSiteRecoveryReplicationRecoveryPlanState<_, _>) : azurerm.DataAzurermSiteRecoveryReplicationRecoveryPlan.DataAzurermSiteRecoveryReplicationRecoveryPlan =
            Unchecked.defaultof<azurerm.DataAzurermSiteRecoveryReplicationRecoveryPlan.DataAzurermSiteRecoveryReplicationRecoveryPlan>

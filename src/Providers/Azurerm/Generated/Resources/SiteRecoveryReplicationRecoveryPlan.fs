namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SiteRecoveryReplicationRecoveryPlanState<'BootRecoveryGroup, 'FailoverRecoveryGroup, 'Name, 'RecoveryVaultId, 'ShutdownRecoveryGroup, 'SourceRecoveryFabricId, 'TargetRecoveryFabricId> = { assignments: ResizeArray<azurerm.SiteRecoveryReplicationRecoveryPlan.SiteRecoveryReplicationRecoveryPlanConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_replication_recovery_plan">azurerm_site_recovery_replication_recovery_plan</a>.
    /// </summary>
    type SiteRecoveryReplicationRecoveryPlanBuilder(logicalId: string) =
        member _.Yield(_: unit) : SiteRecoveryReplicationRecoveryPlanState<Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SiteRecoveryReplicationRecoveryPlanState<Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : SiteRecoveryReplicationRecoveryPlanState<Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SiteRecoveryReplicationRecoveryPlanState<Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// boot_recovery_group block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_replication_recovery_plan#boot_recovery_group-1">SiteRecoveryReplicationRecoveryPlan#boot_recovery_group</a> Accepts: azurerm.IResolvable | azurerm.SiteRecoveryReplicationRecoveryPlan.SiteRecoveryReplicationRecoveryPlanBootRecoveryGroup[]
        /// </summary>
        [<CustomOperation "boot_recovery_group">]
        member _.BootRecoveryGroup(state: SiteRecoveryReplicationRecoveryPlanState<Missing, 'FailoverRecoveryGroup, 'Name, 'RecoveryVaultId, 'ShutdownRecoveryGroup, 'SourceRecoveryFabricId, 'TargetRecoveryFabricId>, value: HashiCorp.Cdktf.IResolvable) : SiteRecoveryReplicationRecoveryPlanState<Present, 'FailoverRecoveryGroup, 'Name, 'RecoveryVaultId, 'ShutdownRecoveryGroup, 'SourceRecoveryFabricId, 'TargetRecoveryFabricId> =
            state.assignments.Add(fun config -> config.BootRecoveryGroup <- value)
            ({ assignments = state.assignments } : SiteRecoveryReplicationRecoveryPlanState<Present, 'FailoverRecoveryGroup, 'Name, 'RecoveryVaultId, 'ShutdownRecoveryGroup, 'SourceRecoveryFabricId, 'TargetRecoveryFabricId>)

        /// <summary>
        /// failover_recovery_group block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_replication_recovery_plan#failover_recovery_group-1">SiteRecoveryReplicationRecoveryPlan#failover_recovery_group</a>
        /// </summary>
        [<CustomOperation "failover_recovery_group">]
        member _.FailoverRecoveryGroup(state: SiteRecoveryReplicationRecoveryPlanState<'BootRecoveryGroup, Missing, 'Name, 'RecoveryVaultId, 'ShutdownRecoveryGroup, 'SourceRecoveryFabricId, 'TargetRecoveryFabricId>, value: azurerm.SiteRecoveryReplicationRecoveryPlan.SiteRecoveryReplicationRecoveryPlanFailoverRecoveryGroup) : SiteRecoveryReplicationRecoveryPlanState<'BootRecoveryGroup, Present, 'Name, 'RecoveryVaultId, 'ShutdownRecoveryGroup, 'SourceRecoveryFabricId, 'TargetRecoveryFabricId> =
            state.assignments.Add(fun config -> config.FailoverRecoveryGroup <- value)
            ({ assignments = state.assignments } : SiteRecoveryReplicationRecoveryPlanState<'BootRecoveryGroup, Present, 'Name, 'RecoveryVaultId, 'ShutdownRecoveryGroup, 'SourceRecoveryFabricId, 'TargetRecoveryFabricId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_replication_recovery_plan#name-1">SiteRecoveryReplicationRecoveryPlan#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SiteRecoveryReplicationRecoveryPlanState<'BootRecoveryGroup, 'FailoverRecoveryGroup, Missing, 'RecoveryVaultId, 'ShutdownRecoveryGroup, 'SourceRecoveryFabricId, 'TargetRecoveryFabricId>, value: string) : SiteRecoveryReplicationRecoveryPlanState<'BootRecoveryGroup, 'FailoverRecoveryGroup, Present, 'RecoveryVaultId, 'ShutdownRecoveryGroup, 'SourceRecoveryFabricId, 'TargetRecoveryFabricId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SiteRecoveryReplicationRecoveryPlanState<'BootRecoveryGroup, 'FailoverRecoveryGroup, Present, 'RecoveryVaultId, 'ShutdownRecoveryGroup, 'SourceRecoveryFabricId, 'TargetRecoveryFabricId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_replication_recovery_plan#recovery_vault_id-1">SiteRecoveryReplicationRecoveryPlan#recovery_vault_id</a>.
        /// </summary>
        [<CustomOperation "recovery_vault_id">]
        member _.RecoveryVaultId(state: SiteRecoveryReplicationRecoveryPlanState<'BootRecoveryGroup, 'FailoverRecoveryGroup, 'Name, Missing, 'ShutdownRecoveryGroup, 'SourceRecoveryFabricId, 'TargetRecoveryFabricId>, value: string) : SiteRecoveryReplicationRecoveryPlanState<'BootRecoveryGroup, 'FailoverRecoveryGroup, 'Name, Present, 'ShutdownRecoveryGroup, 'SourceRecoveryFabricId, 'TargetRecoveryFabricId> =
            state.assignments.Add(fun config -> config.RecoveryVaultId <- value)
            ({ assignments = state.assignments } : SiteRecoveryReplicationRecoveryPlanState<'BootRecoveryGroup, 'FailoverRecoveryGroup, 'Name, Present, 'ShutdownRecoveryGroup, 'SourceRecoveryFabricId, 'TargetRecoveryFabricId>)

        /// <summary>
        /// shutdown_recovery_group block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_replication_recovery_plan#shutdown_recovery_group-1">SiteRecoveryReplicationRecoveryPlan#shutdown_recovery_group</a>
        /// </summary>
        [<CustomOperation "shutdown_recovery_group">]
        member _.ShutdownRecoveryGroup(state: SiteRecoveryReplicationRecoveryPlanState<'BootRecoveryGroup, 'FailoverRecoveryGroup, 'Name, 'RecoveryVaultId, Missing, 'SourceRecoveryFabricId, 'TargetRecoveryFabricId>, value: azurerm.SiteRecoveryReplicationRecoveryPlan.SiteRecoveryReplicationRecoveryPlanShutdownRecoveryGroup) : SiteRecoveryReplicationRecoveryPlanState<'BootRecoveryGroup, 'FailoverRecoveryGroup, 'Name, 'RecoveryVaultId, Present, 'SourceRecoveryFabricId, 'TargetRecoveryFabricId> =
            state.assignments.Add(fun config -> config.ShutdownRecoveryGroup <- value)
            ({ assignments = state.assignments } : SiteRecoveryReplicationRecoveryPlanState<'BootRecoveryGroup, 'FailoverRecoveryGroup, 'Name, 'RecoveryVaultId, Present, 'SourceRecoveryFabricId, 'TargetRecoveryFabricId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_replication_recovery_plan#source_recovery_fabric_id-1">SiteRecoveryReplicationRecoveryPlan#source_recovery_fabric_id</a>.
        /// </summary>
        [<CustomOperation "source_recovery_fabric_id">]
        member _.SourceRecoveryFabricId(state: SiteRecoveryReplicationRecoveryPlanState<'BootRecoveryGroup, 'FailoverRecoveryGroup, 'Name, 'RecoveryVaultId, 'ShutdownRecoveryGroup, Missing, 'TargetRecoveryFabricId>, value: string) : SiteRecoveryReplicationRecoveryPlanState<'BootRecoveryGroup, 'FailoverRecoveryGroup, 'Name, 'RecoveryVaultId, 'ShutdownRecoveryGroup, Present, 'TargetRecoveryFabricId> =
            state.assignments.Add(fun config -> config.SourceRecoveryFabricId <- value)
            ({ assignments = state.assignments } : SiteRecoveryReplicationRecoveryPlanState<'BootRecoveryGroup, 'FailoverRecoveryGroup, 'Name, 'RecoveryVaultId, 'ShutdownRecoveryGroup, Present, 'TargetRecoveryFabricId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_replication_recovery_plan#target_recovery_fabric_id-1">SiteRecoveryReplicationRecoveryPlan#target_recovery_fabric_id</a>.
        /// </summary>
        [<CustomOperation "target_recovery_fabric_id">]
        member _.TargetRecoveryFabricId(state: SiteRecoveryReplicationRecoveryPlanState<'BootRecoveryGroup, 'FailoverRecoveryGroup, 'Name, 'RecoveryVaultId, 'ShutdownRecoveryGroup, 'SourceRecoveryFabricId, Missing>, value: string) : SiteRecoveryReplicationRecoveryPlanState<'BootRecoveryGroup, 'FailoverRecoveryGroup, 'Name, 'RecoveryVaultId, 'ShutdownRecoveryGroup, 'SourceRecoveryFabricId, Present> =
            state.assignments.Add(fun config -> config.TargetRecoveryFabricId <- value)
            ({ assignments = state.assignments } : SiteRecoveryReplicationRecoveryPlanState<'BootRecoveryGroup, 'FailoverRecoveryGroup, 'Name, 'RecoveryVaultId, 'ShutdownRecoveryGroup, 'SourceRecoveryFabricId, Present>)

        /// <summary>
        /// azure_to_azure_settings block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_replication_recovery_plan#azure_to_azure_settings-1">SiteRecoveryReplicationRecoveryPlan#azure_to_azure_settings</a>
        /// </summary>
        [<CustomOperation "azure_to_azure_settings">]
        member _.AzureToAzureSettings(state: SiteRecoveryReplicationRecoveryPlanState<'BootRecoveryGroup, 'FailoverRecoveryGroup, 'Name, 'RecoveryVaultId, 'ShutdownRecoveryGroup, 'SourceRecoveryFabricId, 'TargetRecoveryFabricId>, value: azurerm.SiteRecoveryReplicationRecoveryPlan.SiteRecoveryReplicationRecoveryPlanAzureToAzureSettings) : SiteRecoveryReplicationRecoveryPlanState<'BootRecoveryGroup, 'FailoverRecoveryGroup, 'Name, 'RecoveryVaultId, 'ShutdownRecoveryGroup, 'SourceRecoveryFabricId, 'TargetRecoveryFabricId> =
            state.assignments.Add(fun config -> config.AzureToAzureSettings <- value)
            state : SiteRecoveryReplicationRecoveryPlanState<'BootRecoveryGroup, 'FailoverRecoveryGroup, 'Name, 'RecoveryVaultId, 'ShutdownRecoveryGroup, 'SourceRecoveryFabricId, 'TargetRecoveryFabricId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_replication_recovery_plan#id-1">SiteRecoveryReplicationRecoveryPlan#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SiteRecoveryReplicationRecoveryPlanState<'BootRecoveryGroup, 'FailoverRecoveryGroup, 'Name, 'RecoveryVaultId, 'ShutdownRecoveryGroup, 'SourceRecoveryFabricId, 'TargetRecoveryFabricId>, value: string) : SiteRecoveryReplicationRecoveryPlanState<'BootRecoveryGroup, 'FailoverRecoveryGroup, 'Name, 'RecoveryVaultId, 'ShutdownRecoveryGroup, 'SourceRecoveryFabricId, 'TargetRecoveryFabricId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SiteRecoveryReplicationRecoveryPlanState<'BootRecoveryGroup, 'FailoverRecoveryGroup, 'Name, 'RecoveryVaultId, 'ShutdownRecoveryGroup, 'SourceRecoveryFabricId, 'TargetRecoveryFabricId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_replication_recovery_plan#timeouts-1">SiteRecoveryReplicationRecoveryPlan#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SiteRecoveryReplicationRecoveryPlanState<'BootRecoveryGroup, 'FailoverRecoveryGroup, 'Name, 'RecoveryVaultId, 'ShutdownRecoveryGroup, 'SourceRecoveryFabricId, 'TargetRecoveryFabricId>, value: azurerm.SiteRecoveryReplicationRecoveryPlan.SiteRecoveryReplicationRecoveryPlanTimeouts) : SiteRecoveryReplicationRecoveryPlanState<'BootRecoveryGroup, 'FailoverRecoveryGroup, 'Name, 'RecoveryVaultId, 'ShutdownRecoveryGroup, 'SourceRecoveryFabricId, 'TargetRecoveryFabricId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SiteRecoveryReplicationRecoveryPlanState<'BootRecoveryGroup, 'FailoverRecoveryGroup, 'Name, 'RecoveryVaultId, 'ShutdownRecoveryGroup, 'SourceRecoveryFabricId, 'TargetRecoveryFabricId>

        member _.Run(state: SiteRecoveryReplicationRecoveryPlanState<Present, Present, Present, Present, Present, Present, Present>) : azurerm.SiteRecoveryReplicationRecoveryPlan.SiteRecoveryReplicationRecoveryPlan =
            let config = azurerm.SiteRecoveryReplicationRecoveryPlan.SiteRecoveryReplicationRecoveryPlanConfig()
            for setter in state.assignments do
                setter config
            azurerm.SiteRecoveryReplicationRecoveryPlan.SiteRecoveryReplicationRecoveryPlan(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.siteRecoveryReplicationRecoveryPlan: missing required arguments. Must call: boot_recovery_group, failover_recovery_group, name, recovery_vault_id, shutdown_recovery_group, source_recovery_fabric_id, target_recovery_fabric_id.", 9999, IsError = true)>]
        member _.Run(_: SiteRecoveryReplicationRecoveryPlanState<_, _, _, _, _, _, _>) : azurerm.SiteRecoveryReplicationRecoveryPlan.SiteRecoveryReplicationRecoveryPlan =
            Unchecked.defaultof<azurerm.SiteRecoveryReplicationRecoveryPlan.SiteRecoveryReplicationRecoveryPlan>

namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SiteRecoveryProtectionContainerMappingState<'Name, 'RecoveryFabricName, 'RecoveryReplicationPolicyId, 'RecoverySourceProtectionContainerName, 'RecoveryTargetProtectionContainerId, 'RecoveryVaultName, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.SiteRecoveryProtectionContainerMapping.SiteRecoveryProtectionContainerMappingConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_protection_container_mapping">azurerm_site_recovery_protection_container_mapping</a>.
    /// </summary>
    type SiteRecoveryProtectionContainerMappingBuilder(logicalId: string) =
        member _.Yield(_: unit) : SiteRecoveryProtectionContainerMappingState<Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SiteRecoveryProtectionContainerMappingState<Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : SiteRecoveryProtectionContainerMappingState<Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SiteRecoveryProtectionContainerMappingState<Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_protection_container_mapping#name-1">SiteRecoveryProtectionContainerMapping#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SiteRecoveryProtectionContainerMappingState<Missing, 'RecoveryFabricName, 'RecoveryReplicationPolicyId, 'RecoverySourceProtectionContainerName, 'RecoveryTargetProtectionContainerId, 'RecoveryVaultName, 'ResourceGroupName>, value: string) : SiteRecoveryProtectionContainerMappingState<Present, 'RecoveryFabricName, 'RecoveryReplicationPolicyId, 'RecoverySourceProtectionContainerName, 'RecoveryTargetProtectionContainerId, 'RecoveryVaultName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SiteRecoveryProtectionContainerMappingState<Present, 'RecoveryFabricName, 'RecoveryReplicationPolicyId, 'RecoverySourceProtectionContainerName, 'RecoveryTargetProtectionContainerId, 'RecoveryVaultName, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_protection_container_mapping#recovery_fabric_name-1">SiteRecoveryProtectionContainerMapping#recovery_fabric_name</a>.
        /// </summary>
        [<CustomOperation "recovery_fabric_name">]
        member _.RecoveryFabricName(state: SiteRecoveryProtectionContainerMappingState<'Name, Missing, 'RecoveryReplicationPolicyId, 'RecoverySourceProtectionContainerName, 'RecoveryTargetProtectionContainerId, 'RecoveryVaultName, 'ResourceGroupName>, value: string) : SiteRecoveryProtectionContainerMappingState<'Name, Present, 'RecoveryReplicationPolicyId, 'RecoverySourceProtectionContainerName, 'RecoveryTargetProtectionContainerId, 'RecoveryVaultName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.RecoveryFabricName <- value)
            ({ assignments = state.assignments } : SiteRecoveryProtectionContainerMappingState<'Name, Present, 'RecoveryReplicationPolicyId, 'RecoverySourceProtectionContainerName, 'RecoveryTargetProtectionContainerId, 'RecoveryVaultName, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_protection_container_mapping#recovery_replication_policy_id-1">SiteRecoveryProtectionContainerMapping#recovery_replication_policy_id</a>.
        /// </summary>
        [<CustomOperation "recovery_replication_policy_id">]
        member _.RecoveryReplicationPolicyId(state: SiteRecoveryProtectionContainerMappingState<'Name, 'RecoveryFabricName, Missing, 'RecoverySourceProtectionContainerName, 'RecoveryTargetProtectionContainerId, 'RecoveryVaultName, 'ResourceGroupName>, value: string) : SiteRecoveryProtectionContainerMappingState<'Name, 'RecoveryFabricName, Present, 'RecoverySourceProtectionContainerName, 'RecoveryTargetProtectionContainerId, 'RecoveryVaultName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.RecoveryReplicationPolicyId <- value)
            ({ assignments = state.assignments } : SiteRecoveryProtectionContainerMappingState<'Name, 'RecoveryFabricName, Present, 'RecoverySourceProtectionContainerName, 'RecoveryTargetProtectionContainerId, 'RecoveryVaultName, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_protection_container_mapping#recovery_source_protection_container_name-1">SiteRecoveryProtectionContainerMapping#recovery_source_protection_container_name</a>.
        /// </summary>
        [<CustomOperation "recovery_source_protection_container_name">]
        member _.RecoverySourceProtectionContainerName(state: SiteRecoveryProtectionContainerMappingState<'Name, 'RecoveryFabricName, 'RecoveryReplicationPolicyId, Missing, 'RecoveryTargetProtectionContainerId, 'RecoveryVaultName, 'ResourceGroupName>, value: string) : SiteRecoveryProtectionContainerMappingState<'Name, 'RecoveryFabricName, 'RecoveryReplicationPolicyId, Present, 'RecoveryTargetProtectionContainerId, 'RecoveryVaultName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.RecoverySourceProtectionContainerName <- value)
            ({ assignments = state.assignments } : SiteRecoveryProtectionContainerMappingState<'Name, 'RecoveryFabricName, 'RecoveryReplicationPolicyId, Present, 'RecoveryTargetProtectionContainerId, 'RecoveryVaultName, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_protection_container_mapping#recovery_target_protection_container_id-1">SiteRecoveryProtectionContainerMapping#recovery_target_protection_container_id</a>.
        /// </summary>
        [<CustomOperation "recovery_target_protection_container_id">]
        member _.RecoveryTargetProtectionContainerId(state: SiteRecoveryProtectionContainerMappingState<'Name, 'RecoveryFabricName, 'RecoveryReplicationPolicyId, 'RecoverySourceProtectionContainerName, Missing, 'RecoveryVaultName, 'ResourceGroupName>, value: string) : SiteRecoveryProtectionContainerMappingState<'Name, 'RecoveryFabricName, 'RecoveryReplicationPolicyId, 'RecoverySourceProtectionContainerName, Present, 'RecoveryVaultName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.RecoveryTargetProtectionContainerId <- value)
            ({ assignments = state.assignments } : SiteRecoveryProtectionContainerMappingState<'Name, 'RecoveryFabricName, 'RecoveryReplicationPolicyId, 'RecoverySourceProtectionContainerName, Present, 'RecoveryVaultName, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_protection_container_mapping#recovery_vault_name-1">SiteRecoveryProtectionContainerMapping#recovery_vault_name</a>.
        /// </summary>
        [<CustomOperation "recovery_vault_name">]
        member _.RecoveryVaultName(state: SiteRecoveryProtectionContainerMappingState<'Name, 'RecoveryFabricName, 'RecoveryReplicationPolicyId, 'RecoverySourceProtectionContainerName, 'RecoveryTargetProtectionContainerId, Missing, 'ResourceGroupName>, value: string) : SiteRecoveryProtectionContainerMappingState<'Name, 'RecoveryFabricName, 'RecoveryReplicationPolicyId, 'RecoverySourceProtectionContainerName, 'RecoveryTargetProtectionContainerId, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.RecoveryVaultName <- value)
            ({ assignments = state.assignments } : SiteRecoveryProtectionContainerMappingState<'Name, 'RecoveryFabricName, 'RecoveryReplicationPolicyId, 'RecoverySourceProtectionContainerName, 'RecoveryTargetProtectionContainerId, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_protection_container_mapping#resource_group_name-1">SiteRecoveryProtectionContainerMapping#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: SiteRecoveryProtectionContainerMappingState<'Name, 'RecoveryFabricName, 'RecoveryReplicationPolicyId, 'RecoverySourceProtectionContainerName, 'RecoveryTargetProtectionContainerId, 'RecoveryVaultName, Missing>, value: string) : SiteRecoveryProtectionContainerMappingState<'Name, 'RecoveryFabricName, 'RecoveryReplicationPolicyId, 'RecoverySourceProtectionContainerName, 'RecoveryTargetProtectionContainerId, 'RecoveryVaultName, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : SiteRecoveryProtectionContainerMappingState<'Name, 'RecoveryFabricName, 'RecoveryReplicationPolicyId, 'RecoverySourceProtectionContainerName, 'RecoveryTargetProtectionContainerId, 'RecoveryVaultName, Present>)

        /// <summary>
        /// automatic_update block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_protection_container_mapping#automatic_update-1">SiteRecoveryProtectionContainerMapping#automatic_update</a>
        /// </summary>
        [<CustomOperation "automatic_update">]
        member _.AutomaticUpdate(state: SiteRecoveryProtectionContainerMappingState<'Name, 'RecoveryFabricName, 'RecoveryReplicationPolicyId, 'RecoverySourceProtectionContainerName, 'RecoveryTargetProtectionContainerId, 'RecoveryVaultName, 'ResourceGroupName>, value: azurerm.SiteRecoveryProtectionContainerMapping.SiteRecoveryProtectionContainerMappingAutomaticUpdate) : SiteRecoveryProtectionContainerMappingState<'Name, 'RecoveryFabricName, 'RecoveryReplicationPolicyId, 'RecoverySourceProtectionContainerName, 'RecoveryTargetProtectionContainerId, 'RecoveryVaultName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AutomaticUpdate <- value)
            state : SiteRecoveryProtectionContainerMappingState<'Name, 'RecoveryFabricName, 'RecoveryReplicationPolicyId, 'RecoverySourceProtectionContainerName, 'RecoveryTargetProtectionContainerId, 'RecoveryVaultName, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_protection_container_mapping#id-1">SiteRecoveryProtectionContainerMapping#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SiteRecoveryProtectionContainerMappingState<'Name, 'RecoveryFabricName, 'RecoveryReplicationPolicyId, 'RecoverySourceProtectionContainerName, 'RecoveryTargetProtectionContainerId, 'RecoveryVaultName, 'ResourceGroupName>, value: string) : SiteRecoveryProtectionContainerMappingState<'Name, 'RecoveryFabricName, 'RecoveryReplicationPolicyId, 'RecoverySourceProtectionContainerName, 'RecoveryTargetProtectionContainerId, 'RecoveryVaultName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SiteRecoveryProtectionContainerMappingState<'Name, 'RecoveryFabricName, 'RecoveryReplicationPolicyId, 'RecoverySourceProtectionContainerName, 'RecoveryTargetProtectionContainerId, 'RecoveryVaultName, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_protection_container_mapping#timeouts-1">SiteRecoveryProtectionContainerMapping#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SiteRecoveryProtectionContainerMappingState<'Name, 'RecoveryFabricName, 'RecoveryReplicationPolicyId, 'RecoverySourceProtectionContainerName, 'RecoveryTargetProtectionContainerId, 'RecoveryVaultName, 'ResourceGroupName>, value: azurerm.SiteRecoveryProtectionContainerMapping.SiteRecoveryProtectionContainerMappingTimeouts) : SiteRecoveryProtectionContainerMappingState<'Name, 'RecoveryFabricName, 'RecoveryReplicationPolicyId, 'RecoverySourceProtectionContainerName, 'RecoveryTargetProtectionContainerId, 'RecoveryVaultName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SiteRecoveryProtectionContainerMappingState<'Name, 'RecoveryFabricName, 'RecoveryReplicationPolicyId, 'RecoverySourceProtectionContainerName, 'RecoveryTargetProtectionContainerId, 'RecoveryVaultName, 'ResourceGroupName>

        member _.Run(state: SiteRecoveryProtectionContainerMappingState<Present, Present, Present, Present, Present, Present, Present>) : azurerm.SiteRecoveryProtectionContainerMapping.SiteRecoveryProtectionContainerMapping =
            let config = azurerm.SiteRecoveryProtectionContainerMapping.SiteRecoveryProtectionContainerMappingConfig()
            for setter in state.assignments do
                setter config
            azurerm.SiteRecoveryProtectionContainerMapping.SiteRecoveryProtectionContainerMapping(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.siteRecoveryProtectionContainerMapping: missing required arguments. Must call: name, recovery_fabric_name, recovery_replication_policy_id, recovery_source_protection_container_name, recovery_target_protection_container_id, recovery_vault_name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: SiteRecoveryProtectionContainerMappingState<_, _, _, _, _, _, _>) : azurerm.SiteRecoveryProtectionContainerMapping.SiteRecoveryProtectionContainerMapping =
            Unchecked.defaultof<azurerm.SiteRecoveryProtectionContainerMapping.SiteRecoveryProtectionContainerMapping>

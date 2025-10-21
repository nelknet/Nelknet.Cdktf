namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SiteRecoveryNetworkMappingState<'Name, 'RecoveryVaultName, 'ResourceGroupName, 'SourceNetworkId, 'SourceRecoveryFabricName, 'TargetNetworkId, 'TargetRecoveryFabricName> = { assignments: ResizeArray<azurerm.SiteRecoveryNetworkMapping.SiteRecoveryNetworkMappingConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_network_mapping">azurerm_site_recovery_network_mapping</a>.
    /// </summary>
    type SiteRecoveryNetworkMappingBuilder(logicalId: string) =
        member _.Yield(_: unit) : SiteRecoveryNetworkMappingState<Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SiteRecoveryNetworkMappingState<Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : SiteRecoveryNetworkMappingState<Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SiteRecoveryNetworkMappingState<Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_network_mapping#name-1">SiteRecoveryNetworkMapping#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SiteRecoveryNetworkMappingState<Missing, 'RecoveryVaultName, 'ResourceGroupName, 'SourceNetworkId, 'SourceRecoveryFabricName, 'TargetNetworkId, 'TargetRecoveryFabricName>, value: string) : SiteRecoveryNetworkMappingState<Present, 'RecoveryVaultName, 'ResourceGroupName, 'SourceNetworkId, 'SourceRecoveryFabricName, 'TargetNetworkId, 'TargetRecoveryFabricName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SiteRecoveryNetworkMappingState<Present, 'RecoveryVaultName, 'ResourceGroupName, 'SourceNetworkId, 'SourceRecoveryFabricName, 'TargetNetworkId, 'TargetRecoveryFabricName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_network_mapping#recovery_vault_name-1">SiteRecoveryNetworkMapping#recovery_vault_name</a>.
        /// </summary>
        [<CustomOperation "recovery_vault_name">]
        member _.RecoveryVaultName(state: SiteRecoveryNetworkMappingState<'Name, Missing, 'ResourceGroupName, 'SourceNetworkId, 'SourceRecoveryFabricName, 'TargetNetworkId, 'TargetRecoveryFabricName>, value: string) : SiteRecoveryNetworkMappingState<'Name, Present, 'ResourceGroupName, 'SourceNetworkId, 'SourceRecoveryFabricName, 'TargetNetworkId, 'TargetRecoveryFabricName> =
            state.assignments.Add(fun config -> config.RecoveryVaultName <- value)
            ({ assignments = state.assignments } : SiteRecoveryNetworkMappingState<'Name, Present, 'ResourceGroupName, 'SourceNetworkId, 'SourceRecoveryFabricName, 'TargetNetworkId, 'TargetRecoveryFabricName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_network_mapping#resource_group_name-1">SiteRecoveryNetworkMapping#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: SiteRecoveryNetworkMappingState<'Name, 'RecoveryVaultName, Missing, 'SourceNetworkId, 'SourceRecoveryFabricName, 'TargetNetworkId, 'TargetRecoveryFabricName>, value: string) : SiteRecoveryNetworkMappingState<'Name, 'RecoveryVaultName, Present, 'SourceNetworkId, 'SourceRecoveryFabricName, 'TargetNetworkId, 'TargetRecoveryFabricName> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : SiteRecoveryNetworkMappingState<'Name, 'RecoveryVaultName, Present, 'SourceNetworkId, 'SourceRecoveryFabricName, 'TargetNetworkId, 'TargetRecoveryFabricName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_network_mapping#source_network_id-1">SiteRecoveryNetworkMapping#source_network_id</a>.
        /// </summary>
        [<CustomOperation "source_network_id">]
        member _.SourceNetworkId(state: SiteRecoveryNetworkMappingState<'Name, 'RecoveryVaultName, 'ResourceGroupName, Missing, 'SourceRecoveryFabricName, 'TargetNetworkId, 'TargetRecoveryFabricName>, value: string) : SiteRecoveryNetworkMappingState<'Name, 'RecoveryVaultName, 'ResourceGroupName, Present, 'SourceRecoveryFabricName, 'TargetNetworkId, 'TargetRecoveryFabricName> =
            state.assignments.Add(fun config -> config.SourceNetworkId <- value)
            ({ assignments = state.assignments } : SiteRecoveryNetworkMappingState<'Name, 'RecoveryVaultName, 'ResourceGroupName, Present, 'SourceRecoveryFabricName, 'TargetNetworkId, 'TargetRecoveryFabricName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_network_mapping#source_recovery_fabric_name-1">SiteRecoveryNetworkMapping#source_recovery_fabric_name</a>.
        /// </summary>
        [<CustomOperation "source_recovery_fabric_name">]
        member _.SourceRecoveryFabricName(state: SiteRecoveryNetworkMappingState<'Name, 'RecoveryVaultName, 'ResourceGroupName, 'SourceNetworkId, Missing, 'TargetNetworkId, 'TargetRecoveryFabricName>, value: string) : SiteRecoveryNetworkMappingState<'Name, 'RecoveryVaultName, 'ResourceGroupName, 'SourceNetworkId, Present, 'TargetNetworkId, 'TargetRecoveryFabricName> =
            state.assignments.Add(fun config -> config.SourceRecoveryFabricName <- value)
            ({ assignments = state.assignments } : SiteRecoveryNetworkMappingState<'Name, 'RecoveryVaultName, 'ResourceGroupName, 'SourceNetworkId, Present, 'TargetNetworkId, 'TargetRecoveryFabricName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_network_mapping#target_network_id-1">SiteRecoveryNetworkMapping#target_network_id</a>.
        /// </summary>
        [<CustomOperation "target_network_id">]
        member _.TargetNetworkId(state: SiteRecoveryNetworkMappingState<'Name, 'RecoveryVaultName, 'ResourceGroupName, 'SourceNetworkId, 'SourceRecoveryFabricName, Missing, 'TargetRecoveryFabricName>, value: string) : SiteRecoveryNetworkMappingState<'Name, 'RecoveryVaultName, 'ResourceGroupName, 'SourceNetworkId, 'SourceRecoveryFabricName, Present, 'TargetRecoveryFabricName> =
            state.assignments.Add(fun config -> config.TargetNetworkId <- value)
            ({ assignments = state.assignments } : SiteRecoveryNetworkMappingState<'Name, 'RecoveryVaultName, 'ResourceGroupName, 'SourceNetworkId, 'SourceRecoveryFabricName, Present, 'TargetRecoveryFabricName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_network_mapping#target_recovery_fabric_name-1">SiteRecoveryNetworkMapping#target_recovery_fabric_name</a>.
        /// </summary>
        [<CustomOperation "target_recovery_fabric_name">]
        member _.TargetRecoveryFabricName(state: SiteRecoveryNetworkMappingState<'Name, 'RecoveryVaultName, 'ResourceGroupName, 'SourceNetworkId, 'SourceRecoveryFabricName, 'TargetNetworkId, Missing>, value: string) : SiteRecoveryNetworkMappingState<'Name, 'RecoveryVaultName, 'ResourceGroupName, 'SourceNetworkId, 'SourceRecoveryFabricName, 'TargetNetworkId, Present> =
            state.assignments.Add(fun config -> config.TargetRecoveryFabricName <- value)
            ({ assignments = state.assignments } : SiteRecoveryNetworkMappingState<'Name, 'RecoveryVaultName, 'ResourceGroupName, 'SourceNetworkId, 'SourceRecoveryFabricName, 'TargetNetworkId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_network_mapping#id-1">SiteRecoveryNetworkMapping#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SiteRecoveryNetworkMappingState<'Name, 'RecoveryVaultName, 'ResourceGroupName, 'SourceNetworkId, 'SourceRecoveryFabricName, 'TargetNetworkId, 'TargetRecoveryFabricName>, value: string) : SiteRecoveryNetworkMappingState<'Name, 'RecoveryVaultName, 'ResourceGroupName, 'SourceNetworkId, 'SourceRecoveryFabricName, 'TargetNetworkId, 'TargetRecoveryFabricName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SiteRecoveryNetworkMappingState<'Name, 'RecoveryVaultName, 'ResourceGroupName, 'SourceNetworkId, 'SourceRecoveryFabricName, 'TargetNetworkId, 'TargetRecoveryFabricName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_network_mapping#timeouts-1">SiteRecoveryNetworkMapping#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SiteRecoveryNetworkMappingState<'Name, 'RecoveryVaultName, 'ResourceGroupName, 'SourceNetworkId, 'SourceRecoveryFabricName, 'TargetNetworkId, 'TargetRecoveryFabricName>, value: azurerm.SiteRecoveryNetworkMapping.SiteRecoveryNetworkMappingTimeouts) : SiteRecoveryNetworkMappingState<'Name, 'RecoveryVaultName, 'ResourceGroupName, 'SourceNetworkId, 'SourceRecoveryFabricName, 'TargetNetworkId, 'TargetRecoveryFabricName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SiteRecoveryNetworkMappingState<'Name, 'RecoveryVaultName, 'ResourceGroupName, 'SourceNetworkId, 'SourceRecoveryFabricName, 'TargetNetworkId, 'TargetRecoveryFabricName>

        member _.Run(state: SiteRecoveryNetworkMappingState<Present, Present, Present, Present, Present, Present, Present>) : azurerm.SiteRecoveryNetworkMapping.SiteRecoveryNetworkMapping =
            let config = azurerm.SiteRecoveryNetworkMapping.SiteRecoveryNetworkMappingConfig()
            for setter in state.assignments do
                setter config
            azurerm.SiteRecoveryNetworkMapping.SiteRecoveryNetworkMapping(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.siteRecoveryNetworkMapping: missing required arguments. Must call: name, recovery_vault_name, resource_group_name, source_network_id, source_recovery_fabric_name, target_network_id, target_recovery_fabric_name.", 9999, IsError = true)>]
        member _.Run(_: SiteRecoveryNetworkMappingState<_, _, _, _, _, _, _>) : azurerm.SiteRecoveryNetworkMapping.SiteRecoveryNetworkMapping =
            Unchecked.defaultof<azurerm.SiteRecoveryNetworkMapping.SiteRecoveryNetworkMapping>

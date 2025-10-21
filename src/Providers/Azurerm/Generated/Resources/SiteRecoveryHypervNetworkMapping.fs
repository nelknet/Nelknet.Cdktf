namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SiteRecoveryHypervNetworkMappingState<'Name, 'RecoveryVaultId, 'SourceNetworkName, 'SourceSystemCenterVirtualMachineManagerName, 'TargetNetworkId> = { assignments: ResizeArray<azurerm.SiteRecoveryHypervNetworkMapping.SiteRecoveryHypervNetworkMappingConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_hyperv_network_mapping">azurerm_site_recovery_hyperv_network_mapping</a>.
    /// </summary>
    type SiteRecoveryHypervNetworkMappingBuilder(logicalId: string) =
        member _.Yield(_: unit) : SiteRecoveryHypervNetworkMappingState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SiteRecoveryHypervNetworkMappingState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : SiteRecoveryHypervNetworkMappingState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SiteRecoveryHypervNetworkMappingState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_hyperv_network_mapping#name-1">SiteRecoveryHypervNetworkMapping#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SiteRecoveryHypervNetworkMappingState<Missing, 'RecoveryVaultId, 'SourceNetworkName, 'SourceSystemCenterVirtualMachineManagerName, 'TargetNetworkId>, value: string) : SiteRecoveryHypervNetworkMappingState<Present, 'RecoveryVaultId, 'SourceNetworkName, 'SourceSystemCenterVirtualMachineManagerName, 'TargetNetworkId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SiteRecoveryHypervNetworkMappingState<Present, 'RecoveryVaultId, 'SourceNetworkName, 'SourceSystemCenterVirtualMachineManagerName, 'TargetNetworkId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_hyperv_network_mapping#recovery_vault_id-1">SiteRecoveryHypervNetworkMapping#recovery_vault_id</a>.
        /// </summary>
        [<CustomOperation "recovery_vault_id">]
        member _.RecoveryVaultId(state: SiteRecoveryHypervNetworkMappingState<'Name, Missing, 'SourceNetworkName, 'SourceSystemCenterVirtualMachineManagerName, 'TargetNetworkId>, value: string) : SiteRecoveryHypervNetworkMappingState<'Name, Present, 'SourceNetworkName, 'SourceSystemCenterVirtualMachineManagerName, 'TargetNetworkId> =
            state.assignments.Add(fun config -> config.RecoveryVaultId <- value)
            ({ assignments = state.assignments } : SiteRecoveryHypervNetworkMappingState<'Name, Present, 'SourceNetworkName, 'SourceSystemCenterVirtualMachineManagerName, 'TargetNetworkId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_hyperv_network_mapping#source_network_name-1">SiteRecoveryHypervNetworkMapping#source_network_name</a>.
        /// </summary>
        [<CustomOperation "source_network_name">]
        member _.SourceNetworkName(state: SiteRecoveryHypervNetworkMappingState<'Name, 'RecoveryVaultId, Missing, 'SourceSystemCenterVirtualMachineManagerName, 'TargetNetworkId>, value: string) : SiteRecoveryHypervNetworkMappingState<'Name, 'RecoveryVaultId, Present, 'SourceSystemCenterVirtualMachineManagerName, 'TargetNetworkId> =
            state.assignments.Add(fun config -> config.SourceNetworkName <- value)
            ({ assignments = state.assignments } : SiteRecoveryHypervNetworkMappingState<'Name, 'RecoveryVaultId, Present, 'SourceSystemCenterVirtualMachineManagerName, 'TargetNetworkId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_hyperv_network_mapping#source_system_center_virtual_machine_manager_name-1">SiteRecoveryHypervNetworkMapping#source_system_center_virtual_machine_manager_name</a>.
        /// </summary>
        [<CustomOperation "source_system_center_virtual_machine_manager_name">]
        member _.SourceSystemCenterVirtualMachineManagerName(state: SiteRecoveryHypervNetworkMappingState<'Name, 'RecoveryVaultId, 'SourceNetworkName, Missing, 'TargetNetworkId>, value: string) : SiteRecoveryHypervNetworkMappingState<'Name, 'RecoveryVaultId, 'SourceNetworkName, Present, 'TargetNetworkId> =
            state.assignments.Add(fun config -> config.SourceSystemCenterVirtualMachineManagerName <- value)
            ({ assignments = state.assignments } : SiteRecoveryHypervNetworkMappingState<'Name, 'RecoveryVaultId, 'SourceNetworkName, Present, 'TargetNetworkId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_hyperv_network_mapping#target_network_id-1">SiteRecoveryHypervNetworkMapping#target_network_id</a>.
        /// </summary>
        [<CustomOperation "target_network_id">]
        member _.TargetNetworkId(state: SiteRecoveryHypervNetworkMappingState<'Name, 'RecoveryVaultId, 'SourceNetworkName, 'SourceSystemCenterVirtualMachineManagerName, Missing>, value: string) : SiteRecoveryHypervNetworkMappingState<'Name, 'RecoveryVaultId, 'SourceNetworkName, 'SourceSystemCenterVirtualMachineManagerName, Present> =
            state.assignments.Add(fun config -> config.TargetNetworkId <- value)
            ({ assignments = state.assignments } : SiteRecoveryHypervNetworkMappingState<'Name, 'RecoveryVaultId, 'SourceNetworkName, 'SourceSystemCenterVirtualMachineManagerName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_hyperv_network_mapping#id-1">SiteRecoveryHypervNetworkMapping#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SiteRecoveryHypervNetworkMappingState<'Name, 'RecoveryVaultId, 'SourceNetworkName, 'SourceSystemCenterVirtualMachineManagerName, 'TargetNetworkId>, value: string) : SiteRecoveryHypervNetworkMappingState<'Name, 'RecoveryVaultId, 'SourceNetworkName, 'SourceSystemCenterVirtualMachineManagerName, 'TargetNetworkId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SiteRecoveryHypervNetworkMappingState<'Name, 'RecoveryVaultId, 'SourceNetworkName, 'SourceSystemCenterVirtualMachineManagerName, 'TargetNetworkId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_hyperv_network_mapping#timeouts-1">SiteRecoveryHypervNetworkMapping#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SiteRecoveryHypervNetworkMappingState<'Name, 'RecoveryVaultId, 'SourceNetworkName, 'SourceSystemCenterVirtualMachineManagerName, 'TargetNetworkId>, value: azurerm.SiteRecoveryHypervNetworkMapping.SiteRecoveryHypervNetworkMappingTimeouts) : SiteRecoveryHypervNetworkMappingState<'Name, 'RecoveryVaultId, 'SourceNetworkName, 'SourceSystemCenterVirtualMachineManagerName, 'TargetNetworkId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SiteRecoveryHypervNetworkMappingState<'Name, 'RecoveryVaultId, 'SourceNetworkName, 'SourceSystemCenterVirtualMachineManagerName, 'TargetNetworkId>

        member _.Run(state: SiteRecoveryHypervNetworkMappingState<Present, Present, Present, Present, Present>) : azurerm.SiteRecoveryHypervNetworkMapping.SiteRecoveryHypervNetworkMapping =
            let config = azurerm.SiteRecoveryHypervNetworkMapping.SiteRecoveryHypervNetworkMappingConfig()
            for setter in state.assignments do
                setter config
            azurerm.SiteRecoveryHypervNetworkMapping.SiteRecoveryHypervNetworkMapping(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.siteRecoveryHypervNetworkMapping: missing required arguments. Must call: name, recovery_vault_id, source_network_name, source_system_center_virtual_machine_manager_name, target_network_id.", 9999, IsError = true)>]
        member _.Run(_: SiteRecoveryHypervNetworkMappingState<_, _, _, _, _>) : azurerm.SiteRecoveryHypervNetworkMapping.SiteRecoveryHypervNetworkMapping =
            Unchecked.defaultof<azurerm.SiteRecoveryHypervNetworkMapping.SiteRecoveryHypervNetworkMapping>

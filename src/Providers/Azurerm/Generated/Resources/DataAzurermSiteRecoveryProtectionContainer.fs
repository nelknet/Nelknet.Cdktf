namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermSiteRecoveryProtectionContainerState<'Name, 'RecoveryFabricName, 'RecoveryVaultName, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermSiteRecoveryProtectionContainer.DataAzurermSiteRecoveryProtectionContainerConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/site_recovery_protection_container">azurerm_site_recovery_protection_container</a>.
    /// </summary>
    type DataAzurermSiteRecoveryProtectionContainerBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermSiteRecoveryProtectionContainerState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermSiteRecoveryProtectionContainerState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : DataAzurermSiteRecoveryProtectionContainerState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermSiteRecoveryProtectionContainerState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/site_recovery_protection_container#name-1">DataAzurermSiteRecoveryProtectionContainer#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermSiteRecoveryProtectionContainerState<Missing, 'RecoveryFabricName, 'RecoveryVaultName, 'ResourceGroupName>, value: string) : DataAzurermSiteRecoveryProtectionContainerState<Present, 'RecoveryFabricName, 'RecoveryVaultName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermSiteRecoveryProtectionContainerState<Present, 'RecoveryFabricName, 'RecoveryVaultName, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/site_recovery_protection_container#recovery_fabric_name-1">DataAzurermSiteRecoveryProtectionContainer#recovery_fabric_name</a>.
        /// </summary>
        [<CustomOperation "recovery_fabric_name">]
        member _.RecoveryFabricName(state: DataAzurermSiteRecoveryProtectionContainerState<'Name, Missing, 'RecoveryVaultName, 'ResourceGroupName>, value: string) : DataAzurermSiteRecoveryProtectionContainerState<'Name, Present, 'RecoveryVaultName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.RecoveryFabricName <- value)
            ({ assignments = state.assignments } : DataAzurermSiteRecoveryProtectionContainerState<'Name, Present, 'RecoveryVaultName, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/site_recovery_protection_container#recovery_vault_name-1">DataAzurermSiteRecoveryProtectionContainer#recovery_vault_name</a>.
        /// </summary>
        [<CustomOperation "recovery_vault_name">]
        member _.RecoveryVaultName(state: DataAzurermSiteRecoveryProtectionContainerState<'Name, 'RecoveryFabricName, Missing, 'ResourceGroupName>, value: string) : DataAzurermSiteRecoveryProtectionContainerState<'Name, 'RecoveryFabricName, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.RecoveryVaultName <- value)
            ({ assignments = state.assignments } : DataAzurermSiteRecoveryProtectionContainerState<'Name, 'RecoveryFabricName, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/site_recovery_protection_container#resource_group_name-1">DataAzurermSiteRecoveryProtectionContainer#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermSiteRecoveryProtectionContainerState<'Name, 'RecoveryFabricName, 'RecoveryVaultName, Missing>, value: string) : DataAzurermSiteRecoveryProtectionContainerState<'Name, 'RecoveryFabricName, 'RecoveryVaultName, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermSiteRecoveryProtectionContainerState<'Name, 'RecoveryFabricName, 'RecoveryVaultName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/site_recovery_protection_container#id-1">DataAzurermSiteRecoveryProtectionContainer#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermSiteRecoveryProtectionContainerState<'Name, 'RecoveryFabricName, 'RecoveryVaultName, 'ResourceGroupName>, value: string) : DataAzurermSiteRecoveryProtectionContainerState<'Name, 'RecoveryFabricName, 'RecoveryVaultName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermSiteRecoveryProtectionContainerState<'Name, 'RecoveryFabricName, 'RecoveryVaultName, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/site_recovery_protection_container#timeouts-1">DataAzurermSiteRecoveryProtectionContainer#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermSiteRecoveryProtectionContainerState<'Name, 'RecoveryFabricName, 'RecoveryVaultName, 'ResourceGroupName>, value: azurerm.DataAzurermSiteRecoveryProtectionContainer.DataAzurermSiteRecoveryProtectionContainerTimeouts) : DataAzurermSiteRecoveryProtectionContainerState<'Name, 'RecoveryFabricName, 'RecoveryVaultName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermSiteRecoveryProtectionContainerState<'Name, 'RecoveryFabricName, 'RecoveryVaultName, 'ResourceGroupName>

        member _.Run(state: DataAzurermSiteRecoveryProtectionContainerState<Present, Present, Present, Present>) : azurerm.DataAzurermSiteRecoveryProtectionContainer.DataAzurermSiteRecoveryProtectionContainer =
            let config = azurerm.DataAzurermSiteRecoveryProtectionContainer.DataAzurermSiteRecoveryProtectionContainerConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermSiteRecoveryProtectionContainer.DataAzurermSiteRecoveryProtectionContainer(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermSiteRecoveryProtectionContainer: missing required arguments. Must call: name, recovery_fabric_name, recovery_vault_name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermSiteRecoveryProtectionContainerState<_, _, _, _>) : azurerm.DataAzurermSiteRecoveryProtectionContainer.DataAzurermSiteRecoveryProtectionContainer =
            Unchecked.defaultof<azurerm.DataAzurermSiteRecoveryProtectionContainer.DataAzurermSiteRecoveryProtectionContainer>

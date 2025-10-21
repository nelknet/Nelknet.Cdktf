namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SiteRecoveryProtectionContainerState<'Name, 'RecoveryFabricName, 'RecoveryVaultName, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.SiteRecoveryProtectionContainer.SiteRecoveryProtectionContainerConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_protection_container">azurerm_site_recovery_protection_container</a>.
    /// </summary>
    type SiteRecoveryProtectionContainerBuilder(logicalId: string) =
        member _.Yield(_: unit) : SiteRecoveryProtectionContainerState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SiteRecoveryProtectionContainerState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : SiteRecoveryProtectionContainerState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SiteRecoveryProtectionContainerState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_protection_container#name-1">SiteRecoveryProtectionContainer#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SiteRecoveryProtectionContainerState<Missing, 'RecoveryFabricName, 'RecoveryVaultName, 'ResourceGroupName>, value: string) : SiteRecoveryProtectionContainerState<Present, 'RecoveryFabricName, 'RecoveryVaultName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SiteRecoveryProtectionContainerState<Present, 'RecoveryFabricName, 'RecoveryVaultName, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_protection_container#recovery_fabric_name-1">SiteRecoveryProtectionContainer#recovery_fabric_name</a>.
        /// </summary>
        [<CustomOperation "recovery_fabric_name">]
        member _.RecoveryFabricName(state: SiteRecoveryProtectionContainerState<'Name, Missing, 'RecoveryVaultName, 'ResourceGroupName>, value: string) : SiteRecoveryProtectionContainerState<'Name, Present, 'RecoveryVaultName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.RecoveryFabricName <- value)
            ({ assignments = state.assignments } : SiteRecoveryProtectionContainerState<'Name, Present, 'RecoveryVaultName, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_protection_container#recovery_vault_name-1">SiteRecoveryProtectionContainer#recovery_vault_name</a>.
        /// </summary>
        [<CustomOperation "recovery_vault_name">]
        member _.RecoveryVaultName(state: SiteRecoveryProtectionContainerState<'Name, 'RecoveryFabricName, Missing, 'ResourceGroupName>, value: string) : SiteRecoveryProtectionContainerState<'Name, 'RecoveryFabricName, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.RecoveryVaultName <- value)
            ({ assignments = state.assignments } : SiteRecoveryProtectionContainerState<'Name, 'RecoveryFabricName, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_protection_container#resource_group_name-1">SiteRecoveryProtectionContainer#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: SiteRecoveryProtectionContainerState<'Name, 'RecoveryFabricName, 'RecoveryVaultName, Missing>, value: string) : SiteRecoveryProtectionContainerState<'Name, 'RecoveryFabricName, 'RecoveryVaultName, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : SiteRecoveryProtectionContainerState<'Name, 'RecoveryFabricName, 'RecoveryVaultName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_protection_container#id-1">SiteRecoveryProtectionContainer#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SiteRecoveryProtectionContainerState<'Name, 'RecoveryFabricName, 'RecoveryVaultName, 'ResourceGroupName>, value: string) : SiteRecoveryProtectionContainerState<'Name, 'RecoveryFabricName, 'RecoveryVaultName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SiteRecoveryProtectionContainerState<'Name, 'RecoveryFabricName, 'RecoveryVaultName, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_protection_container#timeouts-1">SiteRecoveryProtectionContainer#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SiteRecoveryProtectionContainerState<'Name, 'RecoveryFabricName, 'RecoveryVaultName, 'ResourceGroupName>, value: azurerm.SiteRecoveryProtectionContainer.SiteRecoveryProtectionContainerTimeouts) : SiteRecoveryProtectionContainerState<'Name, 'RecoveryFabricName, 'RecoveryVaultName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SiteRecoveryProtectionContainerState<'Name, 'RecoveryFabricName, 'RecoveryVaultName, 'ResourceGroupName>

        member _.Run(state: SiteRecoveryProtectionContainerState<Present, Present, Present, Present>) : azurerm.SiteRecoveryProtectionContainer.SiteRecoveryProtectionContainer =
            let config = azurerm.SiteRecoveryProtectionContainer.SiteRecoveryProtectionContainerConfig()
            for setter in state.assignments do
                setter config
            azurerm.SiteRecoveryProtectionContainer.SiteRecoveryProtectionContainer(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.siteRecoveryProtectionContainer: missing required arguments. Must call: name, recovery_fabric_name, recovery_vault_name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: SiteRecoveryProtectionContainerState<_, _, _, _>) : azurerm.SiteRecoveryProtectionContainer.SiteRecoveryProtectionContainer =
            Unchecked.defaultof<azurerm.SiteRecoveryProtectionContainer.SiteRecoveryProtectionContainer>

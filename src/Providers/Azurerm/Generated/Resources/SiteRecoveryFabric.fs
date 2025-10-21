namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SiteRecoveryFabricState<'Location, 'Name, 'RecoveryVaultName, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.SiteRecoveryFabric.SiteRecoveryFabricConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_fabric">azurerm_site_recovery_fabric</a>.
    /// </summary>
    type SiteRecoveryFabricBuilder(logicalId: string) =
        member _.Yield(_: unit) : SiteRecoveryFabricState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SiteRecoveryFabricState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : SiteRecoveryFabricState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SiteRecoveryFabricState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_fabric#location-1">SiteRecoveryFabric#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: SiteRecoveryFabricState<Missing, 'Name, 'RecoveryVaultName, 'ResourceGroupName>, value: string) : SiteRecoveryFabricState<Present, 'Name, 'RecoveryVaultName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : SiteRecoveryFabricState<Present, 'Name, 'RecoveryVaultName, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_fabric#name-1">SiteRecoveryFabric#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SiteRecoveryFabricState<'Location, Missing, 'RecoveryVaultName, 'ResourceGroupName>, value: string) : SiteRecoveryFabricState<'Location, Present, 'RecoveryVaultName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SiteRecoveryFabricState<'Location, Present, 'RecoveryVaultName, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_fabric#recovery_vault_name-1">SiteRecoveryFabric#recovery_vault_name</a>.
        /// </summary>
        [<CustomOperation "recovery_vault_name">]
        member _.RecoveryVaultName(state: SiteRecoveryFabricState<'Location, 'Name, Missing, 'ResourceGroupName>, value: string) : SiteRecoveryFabricState<'Location, 'Name, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.RecoveryVaultName <- value)
            ({ assignments = state.assignments } : SiteRecoveryFabricState<'Location, 'Name, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_fabric#resource_group_name-1">SiteRecoveryFabric#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: SiteRecoveryFabricState<'Location, 'Name, 'RecoveryVaultName, Missing>, value: string) : SiteRecoveryFabricState<'Location, 'Name, 'RecoveryVaultName, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : SiteRecoveryFabricState<'Location, 'Name, 'RecoveryVaultName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_fabric#id-1">SiteRecoveryFabric#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SiteRecoveryFabricState<'Location, 'Name, 'RecoveryVaultName, 'ResourceGroupName>, value: string) : SiteRecoveryFabricState<'Location, 'Name, 'RecoveryVaultName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SiteRecoveryFabricState<'Location, 'Name, 'RecoveryVaultName, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/site_recovery_fabric#timeouts-1">SiteRecoveryFabric#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SiteRecoveryFabricState<'Location, 'Name, 'RecoveryVaultName, 'ResourceGroupName>, value: azurerm.SiteRecoveryFabric.SiteRecoveryFabricTimeouts) : SiteRecoveryFabricState<'Location, 'Name, 'RecoveryVaultName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SiteRecoveryFabricState<'Location, 'Name, 'RecoveryVaultName, 'ResourceGroupName>

        member _.Run(state: SiteRecoveryFabricState<Present, Present, Present, Present>) : azurerm.SiteRecoveryFabric.SiteRecoveryFabric =
            let config = azurerm.SiteRecoveryFabric.SiteRecoveryFabricConfig()
            for setter in state.assignments do
                setter config
            azurerm.SiteRecoveryFabric.SiteRecoveryFabric(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.siteRecoveryFabric: missing required arguments. Must call: location, name, recovery_vault_name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: SiteRecoveryFabricState<_, _, _, _>) : azurerm.SiteRecoveryFabric.SiteRecoveryFabric =
            Unchecked.defaultof<azurerm.SiteRecoveryFabric.SiteRecoveryFabric>

namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermSiteRecoveryFabricState<'Name, 'RecoveryVaultName, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermSiteRecoveryFabric.DataAzurermSiteRecoveryFabricConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/site_recovery_fabric">azurerm_site_recovery_fabric</a>.
    /// </summary>
    type DataAzurermSiteRecoveryFabricBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermSiteRecoveryFabricState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermSiteRecoveryFabricState<Missing, Missing, Missing>)

        member _.Zero(()) : DataAzurermSiteRecoveryFabricState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermSiteRecoveryFabricState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/site_recovery_fabric#name-1">DataAzurermSiteRecoveryFabric#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermSiteRecoveryFabricState<Missing, 'RecoveryVaultName, 'ResourceGroupName>, value: string) : DataAzurermSiteRecoveryFabricState<Present, 'RecoveryVaultName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermSiteRecoveryFabricState<Present, 'RecoveryVaultName, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/site_recovery_fabric#recovery_vault_name-1">DataAzurermSiteRecoveryFabric#recovery_vault_name</a>.
        /// </summary>
        [<CustomOperation "recovery_vault_name">]
        member _.RecoveryVaultName(state: DataAzurermSiteRecoveryFabricState<'Name, Missing, 'ResourceGroupName>, value: string) : DataAzurermSiteRecoveryFabricState<'Name, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.RecoveryVaultName <- value)
            ({ assignments = state.assignments } : DataAzurermSiteRecoveryFabricState<'Name, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/site_recovery_fabric#resource_group_name-1">DataAzurermSiteRecoveryFabric#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermSiteRecoveryFabricState<'Name, 'RecoveryVaultName, Missing>, value: string) : DataAzurermSiteRecoveryFabricState<'Name, 'RecoveryVaultName, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermSiteRecoveryFabricState<'Name, 'RecoveryVaultName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/site_recovery_fabric#id-1">DataAzurermSiteRecoveryFabric#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermSiteRecoveryFabricState<'Name, 'RecoveryVaultName, 'ResourceGroupName>, value: string) : DataAzurermSiteRecoveryFabricState<'Name, 'RecoveryVaultName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermSiteRecoveryFabricState<'Name, 'RecoveryVaultName, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/site_recovery_fabric#timeouts-1">DataAzurermSiteRecoveryFabric#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermSiteRecoveryFabricState<'Name, 'RecoveryVaultName, 'ResourceGroupName>, value: azurerm.DataAzurermSiteRecoveryFabric.DataAzurermSiteRecoveryFabricTimeouts) : DataAzurermSiteRecoveryFabricState<'Name, 'RecoveryVaultName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermSiteRecoveryFabricState<'Name, 'RecoveryVaultName, 'ResourceGroupName>

        member _.Run(state: DataAzurermSiteRecoveryFabricState<Present, Present, Present>) : azurerm.DataAzurermSiteRecoveryFabric.DataAzurermSiteRecoveryFabric =
            let config = azurerm.DataAzurermSiteRecoveryFabric.DataAzurermSiteRecoveryFabricConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermSiteRecoveryFabric.DataAzurermSiteRecoveryFabric(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermSiteRecoveryFabric: missing required arguments. Must call: name, recovery_vault_name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermSiteRecoveryFabricState<_, _, _>) : azurerm.DataAzurermSiteRecoveryFabric.DataAzurermSiteRecoveryFabric =
            Unchecked.defaultof<azurerm.DataAzurermSiteRecoveryFabric.DataAzurermSiteRecoveryFabric>

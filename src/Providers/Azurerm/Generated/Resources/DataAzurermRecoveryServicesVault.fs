namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermRecoveryServicesVaultState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermRecoveryServicesVault.DataAzurermRecoveryServicesVaultConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/recovery_services_vault">azurerm_recovery_services_vault</a>.
    /// </summary>
    type DataAzurermRecoveryServicesVaultBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermRecoveryServicesVaultState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermRecoveryServicesVaultState<Missing, Missing>)

        member _.Zero(()) : DataAzurermRecoveryServicesVaultState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermRecoveryServicesVaultState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/recovery_services_vault#name-1">DataAzurermRecoveryServicesVault#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermRecoveryServicesVaultState<Missing, 'ResourceGroupName>, value: string) : DataAzurermRecoveryServicesVaultState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermRecoveryServicesVaultState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/recovery_services_vault#resource_group_name-1">DataAzurermRecoveryServicesVault#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermRecoveryServicesVaultState<'Name, Missing>, value: string) : DataAzurermRecoveryServicesVaultState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermRecoveryServicesVaultState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/recovery_services_vault#id-1">DataAzurermRecoveryServicesVault#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermRecoveryServicesVaultState<'Name, 'ResourceGroupName>, value: string) : DataAzurermRecoveryServicesVaultState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermRecoveryServicesVaultState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/recovery_services_vault#timeouts-1">DataAzurermRecoveryServicesVault#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermRecoveryServicesVaultState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermRecoveryServicesVault.DataAzurermRecoveryServicesVaultTimeouts) : DataAzurermRecoveryServicesVaultState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermRecoveryServicesVaultState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermRecoveryServicesVaultState<Present, Present>) : azurerm.DataAzurermRecoveryServicesVault.DataAzurermRecoveryServicesVault =
            let config = azurerm.DataAzurermRecoveryServicesVault.DataAzurermRecoveryServicesVaultConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermRecoveryServicesVault.DataAzurermRecoveryServicesVault(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermRecoveryServicesVault: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermRecoveryServicesVaultState<_, _>) : azurerm.DataAzurermRecoveryServicesVault.DataAzurermRecoveryServicesVault =
            Unchecked.defaultof<azurerm.DataAzurermRecoveryServicesVault.DataAzurermRecoveryServicesVault>

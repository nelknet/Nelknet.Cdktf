namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermDataProtectionBackupVaultState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermDataProtectionBackupVault.DataAzurermDataProtectionBackupVaultConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/data_protection_backup_vault">azurerm_data_protection_backup_vault</a>.
    /// </summary>
    type DataAzurermDataProtectionBackupVaultBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermDataProtectionBackupVaultState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermDataProtectionBackupVaultState<Missing, Missing>)

        member _.Zero(()) : DataAzurermDataProtectionBackupVaultState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermDataProtectionBackupVaultState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/data_protection_backup_vault#name-1">DataAzurermDataProtectionBackupVault#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermDataProtectionBackupVaultState<Missing, 'ResourceGroupName>, value: string) : DataAzurermDataProtectionBackupVaultState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermDataProtectionBackupVaultState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/data_protection_backup_vault#resource_group_name-1">DataAzurermDataProtectionBackupVault#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermDataProtectionBackupVaultState<'Name, Missing>, value: string) : DataAzurermDataProtectionBackupVaultState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermDataProtectionBackupVaultState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/data_protection_backup_vault#id-1">DataAzurermDataProtectionBackupVault#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermDataProtectionBackupVaultState<'Name, 'ResourceGroupName>, value: string) : DataAzurermDataProtectionBackupVaultState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermDataProtectionBackupVaultState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/data_protection_backup_vault#timeouts-1">DataAzurermDataProtectionBackupVault#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermDataProtectionBackupVaultState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermDataProtectionBackupVault.DataAzurermDataProtectionBackupVaultTimeouts) : DataAzurermDataProtectionBackupVaultState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermDataProtectionBackupVaultState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermDataProtectionBackupVaultState<Present, Present>) : azurerm.DataAzurermDataProtectionBackupVault.DataAzurermDataProtectionBackupVault =
            let config = azurerm.DataAzurermDataProtectionBackupVault.DataAzurermDataProtectionBackupVaultConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermDataProtectionBackupVault.DataAzurermDataProtectionBackupVault(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermDataProtectionBackupVault: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermDataProtectionBackupVaultState<_, _>) : azurerm.DataAzurermDataProtectionBackupVault.DataAzurermDataProtectionBackupVault =
            Unchecked.defaultof<azurerm.DataAzurermDataProtectionBackupVault.DataAzurermDataProtectionBackupVault>

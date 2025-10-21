namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataProtectionBackupVaultState<'DatastoreType, 'Location, 'Name, 'Redundancy, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataProtectionBackupVault.DataProtectionBackupVaultConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_vault">azurerm_data_protection_backup_vault</a>.
    /// </summary>
    type DataProtectionBackupVaultBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataProtectionBackupVaultState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataProtectionBackupVaultState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : DataProtectionBackupVaultState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataProtectionBackupVaultState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_vault#datastore_type-1">DataProtectionBackupVault#datastore_type</a>.
        /// </summary>
        [<CustomOperation "datastore_type">]
        member _.DatastoreType(state: DataProtectionBackupVaultState<Missing, 'Location, 'Name, 'Redundancy, 'ResourceGroupName>, value: string) : DataProtectionBackupVaultState<Present, 'Location, 'Name, 'Redundancy, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DatastoreType <- value)
            ({ assignments = state.assignments } : DataProtectionBackupVaultState<Present, 'Location, 'Name, 'Redundancy, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_vault#location-1">DataProtectionBackupVault#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: DataProtectionBackupVaultState<'DatastoreType, Missing, 'Name, 'Redundancy, 'ResourceGroupName>, value: string) : DataProtectionBackupVaultState<'DatastoreType, Present, 'Name, 'Redundancy, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : DataProtectionBackupVaultState<'DatastoreType, Present, 'Name, 'Redundancy, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_vault#name-1">DataProtectionBackupVault#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataProtectionBackupVaultState<'DatastoreType, 'Location, Missing, 'Redundancy, 'ResourceGroupName>, value: string) : DataProtectionBackupVaultState<'DatastoreType, 'Location, Present, 'Redundancy, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataProtectionBackupVaultState<'DatastoreType, 'Location, Present, 'Redundancy, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_vault#redundancy-1">DataProtectionBackupVault#redundancy</a>.
        /// </summary>
        [<CustomOperation "redundancy">]
        member _.Redundancy(state: DataProtectionBackupVaultState<'DatastoreType, 'Location, 'Name, Missing, 'ResourceGroupName>, value: string) : DataProtectionBackupVaultState<'DatastoreType, 'Location, 'Name, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Redundancy <- value)
            ({ assignments = state.assignments } : DataProtectionBackupVaultState<'DatastoreType, 'Location, 'Name, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_vault#resource_group_name-1">DataProtectionBackupVault#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataProtectionBackupVaultState<'DatastoreType, 'Location, 'Name, 'Redundancy, Missing>, value: string) : DataProtectionBackupVaultState<'DatastoreType, 'Location, 'Name, 'Redundancy, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataProtectionBackupVaultState<'DatastoreType, 'Location, 'Name, 'Redundancy, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_vault#id-1">DataProtectionBackupVault#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataProtectionBackupVaultState<'DatastoreType, 'Location, 'Name, 'Redundancy, 'ResourceGroupName>, value: string) : DataProtectionBackupVaultState<'DatastoreType, 'Location, 'Name, 'Redundancy, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataProtectionBackupVaultState<'DatastoreType, 'Location, 'Name, 'Redundancy, 'ResourceGroupName>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_vault#identity-1">DataProtectionBackupVault#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: DataProtectionBackupVaultState<'DatastoreType, 'Location, 'Name, 'Redundancy, 'ResourceGroupName>, value: azurerm.DataProtectionBackupVault.DataProtectionBackupVaultIdentity) : DataProtectionBackupVaultState<'DatastoreType, 'Location, 'Name, 'Redundancy, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : DataProtectionBackupVaultState<'DatastoreType, 'Location, 'Name, 'Redundancy, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_vault#retention_duration_in_days-1">DataProtectionBackupVault#retention_duration_in_days</a>.
        /// </summary>
        [<CustomOperation "retention_duration_in_days">]
        member _.RetentionDurationInDays(state: DataProtectionBackupVaultState<'DatastoreType, 'Location, 'Name, 'Redundancy, 'ResourceGroupName>, value: double) : DataProtectionBackupVaultState<'DatastoreType, 'Location, 'Name, 'Redundancy, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.RetentionDurationInDays <- value)
            state : DataProtectionBackupVaultState<'DatastoreType, 'Location, 'Name, 'Redundancy, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_vault#soft_delete-1">DataProtectionBackupVault#soft_delete</a>.
        /// </summary>
        [<CustomOperation "soft_delete">]
        member _.SoftDelete(state: DataProtectionBackupVaultState<'DatastoreType, 'Location, 'Name, 'Redundancy, 'ResourceGroupName>, value: string) : DataProtectionBackupVaultState<'DatastoreType, 'Location, 'Name, 'Redundancy, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.SoftDelete <- value)
            state : DataProtectionBackupVaultState<'DatastoreType, 'Location, 'Name, 'Redundancy, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_vault#tags-1">DataProtectionBackupVault#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataProtectionBackupVaultState<'DatastoreType, 'Location, 'Name, 'Redundancy, 'ResourceGroupName>, value: seq<string * string>) : DataProtectionBackupVaultState<'DatastoreType, 'Location, 'Name, 'Redundancy, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataProtectionBackupVaultState<'DatastoreType, 'Location, 'Name, 'Redundancy, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_vault#timeouts-1">DataProtectionBackupVault#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataProtectionBackupVaultState<'DatastoreType, 'Location, 'Name, 'Redundancy, 'ResourceGroupName>, value: azurerm.DataProtectionBackupVault.DataProtectionBackupVaultTimeouts) : DataProtectionBackupVaultState<'DatastoreType, 'Location, 'Name, 'Redundancy, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataProtectionBackupVaultState<'DatastoreType, 'Location, 'Name, 'Redundancy, 'ResourceGroupName>

        member _.Run(state: DataProtectionBackupVaultState<Present, Present, Present, Present, Present>) : azurerm.DataProtectionBackupVault.DataProtectionBackupVault =
            let config = azurerm.DataProtectionBackupVault.DataProtectionBackupVaultConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataProtectionBackupVault.DataProtectionBackupVault(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataProtectionBackupVault: missing required arguments. Must call: datastore_type, location, name, redundancy, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataProtectionBackupVaultState<_, _, _, _, _>) : azurerm.DataProtectionBackupVault.DataProtectionBackupVault =
            Unchecked.defaultof<azurerm.DataProtectionBackupVault.DataProtectionBackupVault>

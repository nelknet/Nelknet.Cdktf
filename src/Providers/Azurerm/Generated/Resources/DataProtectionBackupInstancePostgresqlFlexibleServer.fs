namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataProtectionBackupInstancePostgresqlFlexibleServerState<'BackupPolicyId, 'Location, 'Name, 'ServerId, 'VaultId> = { assignments: ResizeArray<azurerm.DataProtectionBackupInstancePostgresqlFlexibleServer.DataProtectionBackupInstancePostgresqlFlexibleServerConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_instance_postgresql_flexible_server">azurerm_data_protection_backup_instance_postgresql_flexible_server</a>.
    /// </summary>
    type DataProtectionBackupInstancePostgresqlFlexibleServerBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataProtectionBackupInstancePostgresqlFlexibleServerState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataProtectionBackupInstancePostgresqlFlexibleServerState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : DataProtectionBackupInstancePostgresqlFlexibleServerState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataProtectionBackupInstancePostgresqlFlexibleServerState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_instance_postgresql_flexible_server#backup_policy_id-1">DataProtectionBackupInstancePostgresqlFlexibleServer#backup_policy_id</a>.
        /// </summary>
        [<CustomOperation "backup_policy_id">]
        member _.BackupPolicyId(state: DataProtectionBackupInstancePostgresqlFlexibleServerState<Missing, 'Location, 'Name, 'ServerId, 'VaultId>, value: string) : DataProtectionBackupInstancePostgresqlFlexibleServerState<Present, 'Location, 'Name, 'ServerId, 'VaultId> =
            state.assignments.Add(fun config -> config.BackupPolicyId <- value)
            ({ assignments = state.assignments } : DataProtectionBackupInstancePostgresqlFlexibleServerState<Present, 'Location, 'Name, 'ServerId, 'VaultId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_instance_postgresql_flexible_server#location-1">DataProtectionBackupInstancePostgresqlFlexibleServer#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: DataProtectionBackupInstancePostgresqlFlexibleServerState<'BackupPolicyId, Missing, 'Name, 'ServerId, 'VaultId>, value: string) : DataProtectionBackupInstancePostgresqlFlexibleServerState<'BackupPolicyId, Present, 'Name, 'ServerId, 'VaultId> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : DataProtectionBackupInstancePostgresqlFlexibleServerState<'BackupPolicyId, Present, 'Name, 'ServerId, 'VaultId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_instance_postgresql_flexible_server#name-1">DataProtectionBackupInstancePostgresqlFlexibleServer#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataProtectionBackupInstancePostgresqlFlexibleServerState<'BackupPolicyId, 'Location, Missing, 'ServerId, 'VaultId>, value: string) : DataProtectionBackupInstancePostgresqlFlexibleServerState<'BackupPolicyId, 'Location, Present, 'ServerId, 'VaultId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataProtectionBackupInstancePostgresqlFlexibleServerState<'BackupPolicyId, 'Location, Present, 'ServerId, 'VaultId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_instance_postgresql_flexible_server#server_id-1">DataProtectionBackupInstancePostgresqlFlexibleServer#server_id</a>.
        /// </summary>
        [<CustomOperation "server_id">]
        member _.ServerId(state: DataProtectionBackupInstancePostgresqlFlexibleServerState<'BackupPolicyId, 'Location, 'Name, Missing, 'VaultId>, value: string) : DataProtectionBackupInstancePostgresqlFlexibleServerState<'BackupPolicyId, 'Location, 'Name, Present, 'VaultId> =
            state.assignments.Add(fun config -> config.ServerId <- value)
            ({ assignments = state.assignments } : DataProtectionBackupInstancePostgresqlFlexibleServerState<'BackupPolicyId, 'Location, 'Name, Present, 'VaultId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_instance_postgresql_flexible_server#vault_id-1">DataProtectionBackupInstancePostgresqlFlexibleServer#vault_id</a>.
        /// </summary>
        [<CustomOperation "vault_id">]
        member _.VaultId(state: DataProtectionBackupInstancePostgresqlFlexibleServerState<'BackupPolicyId, 'Location, 'Name, 'ServerId, Missing>, value: string) : DataProtectionBackupInstancePostgresqlFlexibleServerState<'BackupPolicyId, 'Location, 'Name, 'ServerId, Present> =
            state.assignments.Add(fun config -> config.VaultId <- value)
            ({ assignments = state.assignments } : DataProtectionBackupInstancePostgresqlFlexibleServerState<'BackupPolicyId, 'Location, 'Name, 'ServerId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_instance_postgresql_flexible_server#id-1">DataProtectionBackupInstancePostgresqlFlexibleServer#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataProtectionBackupInstancePostgresqlFlexibleServerState<'BackupPolicyId, 'Location, 'Name, 'ServerId, 'VaultId>, value: string) : DataProtectionBackupInstancePostgresqlFlexibleServerState<'BackupPolicyId, 'Location, 'Name, 'ServerId, 'VaultId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataProtectionBackupInstancePostgresqlFlexibleServerState<'BackupPolicyId, 'Location, 'Name, 'ServerId, 'VaultId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_backup_instance_postgresql_flexible_server#timeouts-1">DataProtectionBackupInstancePostgresqlFlexibleServer#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataProtectionBackupInstancePostgresqlFlexibleServerState<'BackupPolicyId, 'Location, 'Name, 'ServerId, 'VaultId>, value: azurerm.DataProtectionBackupInstancePostgresqlFlexibleServer.DataProtectionBackupInstancePostgresqlFlexibleServerTimeouts) : DataProtectionBackupInstancePostgresqlFlexibleServerState<'BackupPolicyId, 'Location, 'Name, 'ServerId, 'VaultId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataProtectionBackupInstancePostgresqlFlexibleServerState<'BackupPolicyId, 'Location, 'Name, 'ServerId, 'VaultId>

        member _.Run(state: DataProtectionBackupInstancePostgresqlFlexibleServerState<Present, Present, Present, Present, Present>) : azurerm.DataProtectionBackupInstancePostgresqlFlexibleServer.DataProtectionBackupInstancePostgresqlFlexibleServer =
            let config = azurerm.DataProtectionBackupInstancePostgresqlFlexibleServer.DataProtectionBackupInstancePostgresqlFlexibleServerConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataProtectionBackupInstancePostgresqlFlexibleServer.DataProtectionBackupInstancePostgresqlFlexibleServer(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataProtectionBackupInstancePostgresqlFlexibleServer: missing required arguments. Must call: backup_policy_id, location, name, server_id, vault_id.", 9999, IsError = true)>]
        member _.Run(_: DataProtectionBackupInstancePostgresqlFlexibleServerState<_, _, _, _, _>) : azurerm.DataProtectionBackupInstancePostgresqlFlexibleServer.DataProtectionBackupInstancePostgresqlFlexibleServer =
            Unchecked.defaultof<azurerm.DataProtectionBackupInstancePostgresqlFlexibleServer.DataProtectionBackupInstancePostgresqlFlexibleServer>

namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MssqlDatabaseState<'Name, 'ServerId> = { assignments: ResizeArray<azurerm.MssqlDatabase.MssqlDatabaseConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database">azurerm_mssql_database</a>.
    /// </summary>
    type MssqlDatabaseBuilder(logicalId: string) =
        member _.Yield(_: unit) : MssqlDatabaseState<Missing, Missing> =
            ({ assignments = ResizeArray() } : MssqlDatabaseState<Missing, Missing>)

        member _.Zero(()) : MssqlDatabaseState<Missing, Missing> =
            ({ assignments = ResizeArray() } : MssqlDatabaseState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#name-1">MssqlDatabase#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: MssqlDatabaseState<Missing, 'ServerId>, value: string) : MssqlDatabaseState<Present, 'ServerId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : MssqlDatabaseState<Present, 'ServerId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#server_id-1">MssqlDatabase#server_id</a>.
        /// </summary>
        [<CustomOperation "server_id">]
        member _.ServerId(state: MssqlDatabaseState<'Name, Missing>, value: string) : MssqlDatabaseState<'Name, Present> =
            state.assignments.Add(fun config -> config.ServerId <- value)
            ({ assignments = state.assignments } : MssqlDatabaseState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#auto_pause_delay_in_minutes-1">MssqlDatabase#auto_pause_delay_in_minutes</a>.
        /// </summary>
        [<CustomOperation "auto_pause_delay_in_minutes">]
        member _.AutoPauseDelayInMinutes(state: MssqlDatabaseState<'Name, 'ServerId>, value: double) : MssqlDatabaseState<'Name, 'ServerId> =
            state.assignments.Add(fun config -> config.AutoPauseDelayInMinutes <- value)
            state : MssqlDatabaseState<'Name, 'ServerId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#collation-1">MssqlDatabase#collation</a>.
        /// </summary>
        [<CustomOperation "collation">]
        member _.Collation(state: MssqlDatabaseState<'Name, 'ServerId>, value: string) : MssqlDatabaseState<'Name, 'ServerId> =
            state.assignments.Add(fun config -> config.Collation <- value)
            state : MssqlDatabaseState<'Name, 'ServerId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#create_mode-1">MssqlDatabase#create_mode</a>.
        /// </summary>
        [<CustomOperation "create_mode">]
        member _.CreateMode(state: MssqlDatabaseState<'Name, 'ServerId>, value: string) : MssqlDatabaseState<'Name, 'ServerId> =
            state.assignments.Add(fun config -> config.CreateMode <- value)
            state : MssqlDatabaseState<'Name, 'ServerId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#creation_source_database_id-1">MssqlDatabase#creation_source_database_id</a>.
        /// </summary>
        [<CustomOperation "creation_source_database_id">]
        member _.CreationSourceDatabaseId(state: MssqlDatabaseState<'Name, 'ServerId>, value: string) : MssqlDatabaseState<'Name, 'ServerId> =
            state.assignments.Add(fun config -> config.CreationSourceDatabaseId <- value)
            state : MssqlDatabaseState<'Name, 'ServerId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#elastic_pool_id-1">MssqlDatabase#elastic_pool_id</a>.
        /// </summary>
        [<CustomOperation "elastic_pool_id">]
        member _.ElasticPoolId(state: MssqlDatabaseState<'Name, 'ServerId>, value: string) : MssqlDatabaseState<'Name, 'ServerId> =
            state.assignments.Add(fun config -> config.ElasticPoolId <- value)
            state : MssqlDatabaseState<'Name, 'ServerId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#enclave_type-1">MssqlDatabase#enclave_type</a>.
        /// </summary>
        [<CustomOperation "enclave_type">]
        member _.EnclaveType(state: MssqlDatabaseState<'Name, 'ServerId>, value: string) : MssqlDatabaseState<'Name, 'ServerId> =
            state.assignments.Add(fun config -> config.EnclaveType <- value)
            state : MssqlDatabaseState<'Name, 'ServerId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#geo_backup_enabled-1">MssqlDatabase#geo_backup_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "geo_backup_enabled">]
        member _.GeoBackupEnabled(state: MssqlDatabaseState<'Name, 'ServerId>, value: bool) : MssqlDatabaseState<'Name, 'ServerId> =
            state.assignments.Add(fun config -> config.GeoBackupEnabled <- value)
            state : MssqlDatabaseState<'Name, 'ServerId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#geo_backup_enabled-1">MssqlDatabase#geo_backup_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "geo_backup_enabled">]
        member _.GeoBackupEnabled(state: MssqlDatabaseState<'Name, 'ServerId>, value: HashiCorp.Cdktf.IResolvable) : MssqlDatabaseState<'Name, 'ServerId> =
            state.assignments.Add(fun config -> config.GeoBackupEnabled <- value)
            state : MssqlDatabaseState<'Name, 'ServerId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#id-1">MssqlDatabase#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MssqlDatabaseState<'Name, 'ServerId>, value: string) : MssqlDatabaseState<'Name, 'ServerId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MssqlDatabaseState<'Name, 'ServerId>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#identity-1">MssqlDatabase#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: MssqlDatabaseState<'Name, 'ServerId>, value: azurerm.MssqlDatabase.MssqlDatabaseIdentity) : MssqlDatabaseState<'Name, 'ServerId> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : MssqlDatabaseState<'Name, 'ServerId>

        /// <summary>
        /// import block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#import-1">MssqlDatabase#import</a>
        /// </summary>
        [<CustomOperation "import">]
        member _.Import(state: MssqlDatabaseState<'Name, 'ServerId>, value: azurerm.MssqlDatabase.MssqlDatabaseImport) : MssqlDatabaseState<'Name, 'ServerId> =
            state.assignments.Add(fun config -> config.Import <- value)
            state : MssqlDatabaseState<'Name, 'ServerId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#ledger_enabled-1">MssqlDatabase#ledger_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "ledger_enabled">]
        member _.LedgerEnabled(state: MssqlDatabaseState<'Name, 'ServerId>, value: bool) : MssqlDatabaseState<'Name, 'ServerId> =
            state.assignments.Add(fun config -> config.LedgerEnabled <- value)
            state : MssqlDatabaseState<'Name, 'ServerId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#ledger_enabled-1">MssqlDatabase#ledger_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "ledger_enabled">]
        member _.LedgerEnabled(state: MssqlDatabaseState<'Name, 'ServerId>, value: HashiCorp.Cdktf.IResolvable) : MssqlDatabaseState<'Name, 'ServerId> =
            state.assignments.Add(fun config -> config.LedgerEnabled <- value)
            state : MssqlDatabaseState<'Name, 'ServerId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#license_type-1">MssqlDatabase#license_type</a>.
        /// </summary>
        [<CustomOperation "license_type">]
        member _.LicenseType(state: MssqlDatabaseState<'Name, 'ServerId>, value: string) : MssqlDatabaseState<'Name, 'ServerId> =
            state.assignments.Add(fun config -> config.LicenseType <- value)
            state : MssqlDatabaseState<'Name, 'ServerId>

        /// <summary>
        /// long_term_retention_policy block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#long_term_retention_policy-1">MssqlDatabase#long_term_retention_policy</a>
        /// </summary>
        [<CustomOperation "long_term_retention_policy">]
        member _.LongTermRetentionPolicy(state: MssqlDatabaseState<'Name, 'ServerId>, value: azurerm.MssqlDatabase.MssqlDatabaseLongTermRetentionPolicy) : MssqlDatabaseState<'Name, 'ServerId> =
            state.assignments.Add(fun config -> config.LongTermRetentionPolicy <- value)
            state : MssqlDatabaseState<'Name, 'ServerId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#maintenance_configuration_name-1">MssqlDatabase#maintenance_configuration_name</a>.
        /// </summary>
        [<CustomOperation "maintenance_configuration_name">]
        member _.MaintenanceConfigurationName(state: MssqlDatabaseState<'Name, 'ServerId>, value: string) : MssqlDatabaseState<'Name, 'ServerId> =
            state.assignments.Add(fun config -> config.MaintenanceConfigurationName <- value)
            state : MssqlDatabaseState<'Name, 'ServerId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#max_size_gb-1">MssqlDatabase#max_size_gb</a>.
        /// </summary>
        [<CustomOperation "max_size_gb">]
        member _.MaxSizeGb(state: MssqlDatabaseState<'Name, 'ServerId>, value: double) : MssqlDatabaseState<'Name, 'ServerId> =
            state.assignments.Add(fun config -> config.MaxSizeGb <- value)
            state : MssqlDatabaseState<'Name, 'ServerId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#min_capacity-1">MssqlDatabase#min_capacity</a>.
        /// </summary>
        [<CustomOperation "min_capacity">]
        member _.MinCapacity(state: MssqlDatabaseState<'Name, 'ServerId>, value: double) : MssqlDatabaseState<'Name, 'ServerId> =
            state.assignments.Add(fun config -> config.MinCapacity <- value)
            state : MssqlDatabaseState<'Name, 'ServerId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#read_replica_count-1">MssqlDatabase#read_replica_count</a>.
        /// </summary>
        [<CustomOperation "read_replica_count">]
        member _.ReadReplicaCount(state: MssqlDatabaseState<'Name, 'ServerId>, value: double) : MssqlDatabaseState<'Name, 'ServerId> =
            state.assignments.Add(fun config -> config.ReadReplicaCount <- value)
            state : MssqlDatabaseState<'Name, 'ServerId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#read_scale-1">MssqlDatabase#read_scale</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "read_scale">]
        member _.ReadScale(state: MssqlDatabaseState<'Name, 'ServerId>, value: bool) : MssqlDatabaseState<'Name, 'ServerId> =
            state.assignments.Add(fun config -> config.ReadScale <- value)
            state : MssqlDatabaseState<'Name, 'ServerId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#read_scale-1">MssqlDatabase#read_scale</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "read_scale">]
        member _.ReadScale(state: MssqlDatabaseState<'Name, 'ServerId>, value: HashiCorp.Cdktf.IResolvable) : MssqlDatabaseState<'Name, 'ServerId> =
            state.assignments.Add(fun config -> config.ReadScale <- value)
            state : MssqlDatabaseState<'Name, 'ServerId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#recover_database_id-1">MssqlDatabase#recover_database_id</a>.
        /// </summary>
        [<CustomOperation "recover_database_id">]
        member _.RecoverDatabaseId(state: MssqlDatabaseState<'Name, 'ServerId>, value: string) : MssqlDatabaseState<'Name, 'ServerId> =
            state.assignments.Add(fun config -> config.RecoverDatabaseId <- value)
            state : MssqlDatabaseState<'Name, 'ServerId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#recovery_point_id-1">MssqlDatabase#recovery_point_id</a>.
        /// </summary>
        [<CustomOperation "recovery_point_id">]
        member _.RecoveryPointId(state: MssqlDatabaseState<'Name, 'ServerId>, value: string) : MssqlDatabaseState<'Name, 'ServerId> =
            state.assignments.Add(fun config -> config.RecoveryPointId <- value)
            state : MssqlDatabaseState<'Name, 'ServerId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#restore_dropped_database_id-1">MssqlDatabase#restore_dropped_database_id</a>.
        /// </summary>
        [<CustomOperation "restore_dropped_database_id">]
        member _.RestoreDroppedDatabaseId(state: MssqlDatabaseState<'Name, 'ServerId>, value: string) : MssqlDatabaseState<'Name, 'ServerId> =
            state.assignments.Add(fun config -> config.RestoreDroppedDatabaseId <- value)
            state : MssqlDatabaseState<'Name, 'ServerId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#restore_long_term_retention_backup_id-1">MssqlDatabase#restore_long_term_retention_backup_id</a>.
        /// </summary>
        [<CustomOperation "restore_long_term_retention_backup_id">]
        member _.RestoreLongTermRetentionBackupId(state: MssqlDatabaseState<'Name, 'ServerId>, value: string) : MssqlDatabaseState<'Name, 'ServerId> =
            state.assignments.Add(fun config -> config.RestoreLongTermRetentionBackupId <- value)
            state : MssqlDatabaseState<'Name, 'ServerId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#restore_point_in_time-1">MssqlDatabase#restore_point_in_time</a>.
        /// </summary>
        [<CustomOperation "restore_point_in_time">]
        member _.RestorePointInTime(state: MssqlDatabaseState<'Name, 'ServerId>, value: string) : MssqlDatabaseState<'Name, 'ServerId> =
            state.assignments.Add(fun config -> config.RestorePointInTime <- value)
            state : MssqlDatabaseState<'Name, 'ServerId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#sample_name-1">MssqlDatabase#sample_name</a>.
        /// </summary>
        [<CustomOperation "sample_name">]
        member _.SampleName(state: MssqlDatabaseState<'Name, 'ServerId>, value: string) : MssqlDatabaseState<'Name, 'ServerId> =
            state.assignments.Add(fun config -> config.SampleName <- value)
            state : MssqlDatabaseState<'Name, 'ServerId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#secondary_type-1">MssqlDatabase#secondary_type</a>.
        /// </summary>
        [<CustomOperation "secondary_type">]
        member _.SecondaryType(state: MssqlDatabaseState<'Name, 'ServerId>, value: string) : MssqlDatabaseState<'Name, 'ServerId> =
            state.assignments.Add(fun config -> config.SecondaryType <- value)
            state : MssqlDatabaseState<'Name, 'ServerId>

        /// <summary>
        /// short_term_retention_policy block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#short_term_retention_policy-1">MssqlDatabase#short_term_retention_policy</a>
        /// </summary>
        [<CustomOperation "short_term_retention_policy">]
        member _.ShortTermRetentionPolicy(state: MssqlDatabaseState<'Name, 'ServerId>, value: azurerm.MssqlDatabase.MssqlDatabaseShortTermRetentionPolicy) : MssqlDatabaseState<'Name, 'ServerId> =
            state.assignments.Add(fun config -> config.ShortTermRetentionPolicy <- value)
            state : MssqlDatabaseState<'Name, 'ServerId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#sku_name-1">MssqlDatabase#sku_name</a>.
        /// </summary>
        [<CustomOperation "sku_name">]
        member _.SkuName(state: MssqlDatabaseState<'Name, 'ServerId>, value: string) : MssqlDatabaseState<'Name, 'ServerId> =
            state.assignments.Add(fun config -> config.SkuName <- value)
            state : MssqlDatabaseState<'Name, 'ServerId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#storage_account_type-1">MssqlDatabase#storage_account_type</a>.
        /// </summary>
        [<CustomOperation "storage_account_type">]
        member _.StorageAccountType(state: MssqlDatabaseState<'Name, 'ServerId>, value: string) : MssqlDatabaseState<'Name, 'ServerId> =
            state.assignments.Add(fun config -> config.StorageAccountType <- value)
            state : MssqlDatabaseState<'Name, 'ServerId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#tags-1">MssqlDatabase#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: MssqlDatabaseState<'Name, 'ServerId>, value: seq<string * string>) : MssqlDatabaseState<'Name, 'ServerId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : MssqlDatabaseState<'Name, 'ServerId>

        /// <summary>
        /// threat_detection_policy block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#threat_detection_policy-1">MssqlDatabase#threat_detection_policy</a>
        /// </summary>
        [<CustomOperation "threat_detection_policy">]
        member _.ThreatDetectionPolicy(state: MssqlDatabaseState<'Name, 'ServerId>, value: azurerm.MssqlDatabase.MssqlDatabaseThreatDetectionPolicy) : MssqlDatabaseState<'Name, 'ServerId> =
            state.assignments.Add(fun config -> config.ThreatDetectionPolicy <- value)
            state : MssqlDatabaseState<'Name, 'ServerId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#timeouts-1">MssqlDatabase#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: MssqlDatabaseState<'Name, 'ServerId>, value: azurerm.MssqlDatabase.MssqlDatabaseTimeouts) : MssqlDatabaseState<'Name, 'ServerId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : MssqlDatabaseState<'Name, 'ServerId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#transparent_data_encryption_enabled-1">MssqlDatabase#transparent_data_encryption_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "transparent_data_encryption_enabled">]
        member _.TransparentDataEncryptionEnabled(state: MssqlDatabaseState<'Name, 'ServerId>, value: bool) : MssqlDatabaseState<'Name, 'ServerId> =
            state.assignments.Add(fun config -> config.TransparentDataEncryptionEnabled <- value)
            state : MssqlDatabaseState<'Name, 'ServerId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#transparent_data_encryption_enabled-1">MssqlDatabase#transparent_data_encryption_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "transparent_data_encryption_enabled">]
        member _.TransparentDataEncryptionEnabled(state: MssqlDatabaseState<'Name, 'ServerId>, value: HashiCorp.Cdktf.IResolvable) : MssqlDatabaseState<'Name, 'ServerId> =
            state.assignments.Add(fun config -> config.TransparentDataEncryptionEnabled <- value)
            state : MssqlDatabaseState<'Name, 'ServerId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#transparent_data_encryption_key_automatic_rotation_enabled-1">MssqlDatabase#transparent_data_encryption_key_automatic_rotation_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "transparent_data_encryption_key_automatic_rotation_enabled">]
        member _.TransparentDataEncryptionKeyAutomaticRotationEnabled(state: MssqlDatabaseState<'Name, 'ServerId>, value: bool) : MssqlDatabaseState<'Name, 'ServerId> =
            state.assignments.Add(fun config -> config.TransparentDataEncryptionKeyAutomaticRotationEnabled <- value)
            state : MssqlDatabaseState<'Name, 'ServerId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#transparent_data_encryption_key_automatic_rotation_enabled-1">MssqlDatabase#transparent_data_encryption_key_automatic_rotation_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "transparent_data_encryption_key_automatic_rotation_enabled">]
        member _.TransparentDataEncryptionKeyAutomaticRotationEnabled(state: MssqlDatabaseState<'Name, 'ServerId>, value: HashiCorp.Cdktf.IResolvable) : MssqlDatabaseState<'Name, 'ServerId> =
            state.assignments.Add(fun config -> config.TransparentDataEncryptionKeyAutomaticRotationEnabled <- value)
            state : MssqlDatabaseState<'Name, 'ServerId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#transparent_data_encryption_key_vault_key_id-1">MssqlDatabase#transparent_data_encryption_key_vault_key_id</a>.
        /// </summary>
        [<CustomOperation "transparent_data_encryption_key_vault_key_id">]
        member _.TransparentDataEncryptionKeyVaultKeyId(state: MssqlDatabaseState<'Name, 'ServerId>, value: string) : MssqlDatabaseState<'Name, 'ServerId> =
            state.assignments.Add(fun config -> config.TransparentDataEncryptionKeyVaultKeyId <- value)
            state : MssqlDatabaseState<'Name, 'ServerId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#zone_redundant-1">MssqlDatabase#zone_redundant</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "zone_redundant">]
        member _.ZoneRedundant(state: MssqlDatabaseState<'Name, 'ServerId>, value: bool) : MssqlDatabaseState<'Name, 'ServerId> =
            state.assignments.Add(fun config -> config.ZoneRedundant <- value)
            state : MssqlDatabaseState<'Name, 'ServerId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#zone_redundant-1">MssqlDatabase#zone_redundant</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "zone_redundant">]
        member _.ZoneRedundant(state: MssqlDatabaseState<'Name, 'ServerId>, value: HashiCorp.Cdktf.IResolvable) : MssqlDatabaseState<'Name, 'ServerId> =
            state.assignments.Add(fun config -> config.ZoneRedundant <- value)
            state : MssqlDatabaseState<'Name, 'ServerId>

        member _.Run(state: MssqlDatabaseState<Present, Present>) : azurerm.MssqlDatabase.MssqlDatabase =
            let config = azurerm.MssqlDatabase.MssqlDatabaseConfig()
            for setter in state.assignments do
                setter config
            azurerm.MssqlDatabase.MssqlDatabase(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.mssqlDatabase: missing required arguments. Must call: name, server_id.", 9999, IsError = true)>]
        member _.Run(_: MssqlDatabaseState<_, _>) : azurerm.MssqlDatabase.MssqlDatabase =
            Unchecked.defaultof<azurerm.MssqlDatabase.MssqlDatabase>

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MssqlDatabase
{
    [JsiiInterface(nativeType: typeof(IMssqlDatabaseConfig), fullyQualifiedName: "azurerm.mssqlDatabase.MssqlDatabaseConfig")]
    public interface IMssqlDatabaseConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#name MssqlDatabase#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#server_id MssqlDatabase#server_id}.</summary>
        [JsiiProperty(name: "serverId", typeJson: "{\"primitive\":\"string\"}")]
        string ServerId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#auto_pause_delay_in_minutes MssqlDatabase#auto_pause_delay_in_minutes}.</summary>
        [JsiiProperty(name: "autoPauseDelayInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? AutoPauseDelayInMinutes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#collation MssqlDatabase#collation}.</summary>
        [JsiiProperty(name: "collation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Collation
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#create_mode MssqlDatabase#create_mode}.</summary>
        [JsiiProperty(name: "createMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CreateMode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#creation_source_database_id MssqlDatabase#creation_source_database_id}.</summary>
        [JsiiProperty(name: "creationSourceDatabaseId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CreationSourceDatabaseId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#elastic_pool_id MssqlDatabase#elastic_pool_id}.</summary>
        [JsiiProperty(name: "elasticPoolId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ElasticPoolId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#enclave_type MssqlDatabase#enclave_type}.</summary>
        [JsiiProperty(name: "enclaveType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EnclaveType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#geo_backup_enabled MssqlDatabase#geo_backup_enabled}.</summary>
        [JsiiProperty(name: "geoBackupEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? GeoBackupEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#id MssqlDatabase#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>identity block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#identity MssqlDatabase#identity}
        /// </remarks>
        [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.mssqlDatabase.MssqlDatabaseIdentity\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.MssqlDatabase.IMssqlDatabaseIdentity? Identity
        {
            get
            {
                return null;
            }
        }

        /// <summary>import block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#import MssqlDatabase#import}
        /// </remarks>
        [JsiiProperty(name: "import", typeJson: "{\"fqn\":\"azurerm.mssqlDatabase.MssqlDatabaseImport\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.MssqlDatabase.IMssqlDatabaseImport? Import
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#ledger_enabled MssqlDatabase#ledger_enabled}.</summary>
        [JsiiProperty(name: "ledgerEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? LedgerEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#license_type MssqlDatabase#license_type}.</summary>
        [JsiiProperty(name: "licenseType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LicenseType
        {
            get
            {
                return null;
            }
        }

        /// <summary>long_term_retention_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#long_term_retention_policy MssqlDatabase#long_term_retention_policy}
        /// </remarks>
        [JsiiProperty(name: "longTermRetentionPolicy", typeJson: "{\"fqn\":\"azurerm.mssqlDatabase.MssqlDatabaseLongTermRetentionPolicy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.MssqlDatabase.IMssqlDatabaseLongTermRetentionPolicy? LongTermRetentionPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#maintenance_configuration_name MssqlDatabase#maintenance_configuration_name}.</summary>
        [JsiiProperty(name: "maintenanceConfigurationName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MaintenanceConfigurationName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#max_size_gb MssqlDatabase#max_size_gb}.</summary>
        [JsiiProperty(name: "maxSizeGb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxSizeGb
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#min_capacity MssqlDatabase#min_capacity}.</summary>
        [JsiiProperty(name: "minCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MinCapacity
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#read_replica_count MssqlDatabase#read_replica_count}.</summary>
        [JsiiProperty(name: "readReplicaCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ReadReplicaCount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#read_scale MssqlDatabase#read_scale}.</summary>
        [JsiiProperty(name: "readScale", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ReadScale
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#recover_database_id MssqlDatabase#recover_database_id}.</summary>
        [JsiiProperty(name: "recoverDatabaseId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RecoverDatabaseId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#recovery_point_id MssqlDatabase#recovery_point_id}.</summary>
        [JsiiProperty(name: "recoveryPointId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RecoveryPointId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#restore_dropped_database_id MssqlDatabase#restore_dropped_database_id}.</summary>
        [JsiiProperty(name: "restoreDroppedDatabaseId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RestoreDroppedDatabaseId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#restore_long_term_retention_backup_id MssqlDatabase#restore_long_term_retention_backup_id}.</summary>
        [JsiiProperty(name: "restoreLongTermRetentionBackupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RestoreLongTermRetentionBackupId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#restore_point_in_time MssqlDatabase#restore_point_in_time}.</summary>
        [JsiiProperty(name: "restorePointInTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RestorePointInTime
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#sample_name MssqlDatabase#sample_name}.</summary>
        [JsiiProperty(name: "sampleName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SampleName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#secondary_type MssqlDatabase#secondary_type}.</summary>
        [JsiiProperty(name: "secondaryType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SecondaryType
        {
            get
            {
                return null;
            }
        }

        /// <summary>short_term_retention_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#short_term_retention_policy MssqlDatabase#short_term_retention_policy}
        /// </remarks>
        [JsiiProperty(name: "shortTermRetentionPolicy", typeJson: "{\"fqn\":\"azurerm.mssqlDatabase.MssqlDatabaseShortTermRetentionPolicy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.MssqlDatabase.IMssqlDatabaseShortTermRetentionPolicy? ShortTermRetentionPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#sku_name MssqlDatabase#sku_name}.</summary>
        [JsiiProperty(name: "skuName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SkuName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#storage_account_type MssqlDatabase#storage_account_type}.</summary>
        [JsiiProperty(name: "storageAccountType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StorageAccountType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#tags MssqlDatabase#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>threat_detection_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#threat_detection_policy MssqlDatabase#threat_detection_policy}
        /// </remarks>
        [JsiiProperty(name: "threatDetectionPolicy", typeJson: "{\"fqn\":\"azurerm.mssqlDatabase.MssqlDatabaseThreatDetectionPolicy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.MssqlDatabase.IMssqlDatabaseThreatDetectionPolicy? ThreatDetectionPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#timeouts MssqlDatabase#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.mssqlDatabase.MssqlDatabaseTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.MssqlDatabase.IMssqlDatabaseTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#transparent_data_encryption_enabled MssqlDatabase#transparent_data_encryption_enabled}.</summary>
        [JsiiProperty(name: "transparentDataEncryptionEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? TransparentDataEncryptionEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#transparent_data_encryption_key_automatic_rotation_enabled MssqlDatabase#transparent_data_encryption_key_automatic_rotation_enabled}.</summary>
        [JsiiProperty(name: "transparentDataEncryptionKeyAutomaticRotationEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? TransparentDataEncryptionKeyAutomaticRotationEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#transparent_data_encryption_key_vault_key_id MssqlDatabase#transparent_data_encryption_key_vault_key_id}.</summary>
        [JsiiProperty(name: "transparentDataEncryptionKeyVaultKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TransparentDataEncryptionKeyVaultKeyId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#zone_redundant MssqlDatabase#zone_redundant}.</summary>
        [JsiiProperty(name: "zoneRedundant", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ZoneRedundant
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMssqlDatabaseConfig), fullyQualifiedName: "azurerm.mssqlDatabase.MssqlDatabaseConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.MssqlDatabase.IMssqlDatabaseConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#name MssqlDatabase#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#server_id MssqlDatabase#server_id}.</summary>
            [JsiiProperty(name: "serverId", typeJson: "{\"primitive\":\"string\"}")]
            public string ServerId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#auto_pause_delay_in_minutes MssqlDatabase#auto_pause_delay_in_minutes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "autoPauseDelayInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? AutoPauseDelayInMinutes
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#collation MssqlDatabase#collation}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "collation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Collation
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#create_mode MssqlDatabase#create_mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "createMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CreateMode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#creation_source_database_id MssqlDatabase#creation_source_database_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "creationSourceDatabaseId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CreationSourceDatabaseId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#elastic_pool_id MssqlDatabase#elastic_pool_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "elasticPoolId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ElasticPoolId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#enclave_type MssqlDatabase#enclave_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "enclaveType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EnclaveType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#geo_backup_enabled MssqlDatabase#geo_backup_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "geoBackupEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? GeoBackupEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#id MssqlDatabase#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>identity block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#identity MssqlDatabase#identity}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.mssqlDatabase.MssqlDatabaseIdentity\"}", isOptional: true)]
            public azurerm.MssqlDatabase.IMssqlDatabaseIdentity? Identity
            {
                get => GetInstanceProperty<azurerm.MssqlDatabase.IMssqlDatabaseIdentity?>();
            }

            /// <summary>import block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#import MssqlDatabase#import}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "import", typeJson: "{\"fqn\":\"azurerm.mssqlDatabase.MssqlDatabaseImport\"}", isOptional: true)]
            public azurerm.MssqlDatabase.IMssqlDatabaseImport? Import
            {
                get => GetInstanceProperty<azurerm.MssqlDatabase.IMssqlDatabaseImport?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#ledger_enabled MssqlDatabase#ledger_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ledgerEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? LedgerEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#license_type MssqlDatabase#license_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "licenseType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LicenseType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>long_term_retention_policy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#long_term_retention_policy MssqlDatabase#long_term_retention_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "longTermRetentionPolicy", typeJson: "{\"fqn\":\"azurerm.mssqlDatabase.MssqlDatabaseLongTermRetentionPolicy\"}", isOptional: true)]
            public azurerm.MssqlDatabase.IMssqlDatabaseLongTermRetentionPolicy? LongTermRetentionPolicy
            {
                get => GetInstanceProperty<azurerm.MssqlDatabase.IMssqlDatabaseLongTermRetentionPolicy?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#maintenance_configuration_name MssqlDatabase#maintenance_configuration_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maintenanceConfigurationName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MaintenanceConfigurationName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#max_size_gb MssqlDatabase#max_size_gb}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxSizeGb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxSizeGb
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#min_capacity MssqlDatabase#min_capacity}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "minCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MinCapacity
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#read_replica_count MssqlDatabase#read_replica_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "readReplicaCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ReadReplicaCount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#read_scale MssqlDatabase#read_scale}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "readScale", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? ReadScale
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#recover_database_id MssqlDatabase#recover_database_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "recoverDatabaseId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RecoverDatabaseId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#recovery_point_id MssqlDatabase#recovery_point_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "recoveryPointId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RecoveryPointId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#restore_dropped_database_id MssqlDatabase#restore_dropped_database_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "restoreDroppedDatabaseId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RestoreDroppedDatabaseId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#restore_long_term_retention_backup_id MssqlDatabase#restore_long_term_retention_backup_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "restoreLongTermRetentionBackupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RestoreLongTermRetentionBackupId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#restore_point_in_time MssqlDatabase#restore_point_in_time}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "restorePointInTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RestorePointInTime
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#sample_name MssqlDatabase#sample_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sampleName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SampleName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#secondary_type MssqlDatabase#secondary_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "secondaryType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SecondaryType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>short_term_retention_policy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#short_term_retention_policy MssqlDatabase#short_term_retention_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "shortTermRetentionPolicy", typeJson: "{\"fqn\":\"azurerm.mssqlDatabase.MssqlDatabaseShortTermRetentionPolicy\"}", isOptional: true)]
            public azurerm.MssqlDatabase.IMssqlDatabaseShortTermRetentionPolicy? ShortTermRetentionPolicy
            {
                get => GetInstanceProperty<azurerm.MssqlDatabase.IMssqlDatabaseShortTermRetentionPolicy?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#sku_name MssqlDatabase#sku_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "skuName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SkuName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#storage_account_type MssqlDatabase#storage_account_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "storageAccountType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StorageAccountType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#tags MssqlDatabase#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>threat_detection_policy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#threat_detection_policy MssqlDatabase#threat_detection_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "threatDetectionPolicy", typeJson: "{\"fqn\":\"azurerm.mssqlDatabase.MssqlDatabaseThreatDetectionPolicy\"}", isOptional: true)]
            public azurerm.MssqlDatabase.IMssqlDatabaseThreatDetectionPolicy? ThreatDetectionPolicy
            {
                get => GetInstanceProperty<azurerm.MssqlDatabase.IMssqlDatabaseThreatDetectionPolicy?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#timeouts MssqlDatabase#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.mssqlDatabase.MssqlDatabaseTimeouts\"}", isOptional: true)]
            public azurerm.MssqlDatabase.IMssqlDatabaseTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.MssqlDatabase.IMssqlDatabaseTimeouts?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#transparent_data_encryption_enabled MssqlDatabase#transparent_data_encryption_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "transparentDataEncryptionEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? TransparentDataEncryptionEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#transparent_data_encryption_key_automatic_rotation_enabled MssqlDatabase#transparent_data_encryption_key_automatic_rotation_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "transparentDataEncryptionKeyAutomaticRotationEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? TransparentDataEncryptionKeyAutomaticRotationEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#transparent_data_encryption_key_vault_key_id MssqlDatabase#transparent_data_encryption_key_vault_key_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "transparentDataEncryptionKeyVaultKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TransparentDataEncryptionKeyVaultKeyId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_database#zone_redundant MssqlDatabase#zone_redundant}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "zoneRedundant", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? ZoneRedundant
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.SSHProvisionerConnection\"},{\"fqn\":\"cdktf.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktf.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktf.ITerraformIterator\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.FileProvisioner\"},{\"fqn\":\"cdktf.LocalExecProvisioner\"},{\"fqn\":\"cdktf.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}

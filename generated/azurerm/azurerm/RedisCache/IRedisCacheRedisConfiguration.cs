using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.RedisCache
{
    [JsiiInterface(nativeType: typeof(IRedisCacheRedisConfiguration), fullyQualifiedName: "azurerm.redisCache.RedisCacheRedisConfiguration")]
    public interface IRedisCacheRedisConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_cache#active_directory_authentication_enabled RedisCache#active_directory_authentication_enabled}.</summary>
        [JsiiProperty(name: "activeDirectoryAuthenticationEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ActiveDirectoryAuthenticationEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_cache#aof_backup_enabled RedisCache#aof_backup_enabled}.</summary>
        [JsiiProperty(name: "aofBackupEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AofBackupEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_cache#aof_storage_connection_string_0 RedisCache#aof_storage_connection_string_0}.</summary>
        [JsiiProperty(name: "aofStorageConnectionString0", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AofStorageConnectionString0
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_cache#aof_storage_connection_string_1 RedisCache#aof_storage_connection_string_1}.</summary>
        [JsiiProperty(name: "aofStorageConnectionString1", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AofStorageConnectionString1
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_cache#authentication_enabled RedisCache#authentication_enabled}.</summary>
        [JsiiProperty(name: "authenticationEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AuthenticationEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_cache#data_persistence_authentication_method RedisCache#data_persistence_authentication_method}.</summary>
        [JsiiProperty(name: "dataPersistenceAuthenticationMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DataPersistenceAuthenticationMethod
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_cache#maxfragmentationmemory_reserved RedisCache#maxfragmentationmemory_reserved}.</summary>
        [JsiiProperty(name: "maxfragmentationmemoryReserved", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxfragmentationmemoryReserved
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_cache#maxmemory_delta RedisCache#maxmemory_delta}.</summary>
        [JsiiProperty(name: "maxmemoryDelta", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxmemoryDelta
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_cache#maxmemory_policy RedisCache#maxmemory_policy}.</summary>
        [JsiiProperty(name: "maxmemoryPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MaxmemoryPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_cache#maxmemory_reserved RedisCache#maxmemory_reserved}.</summary>
        [JsiiProperty(name: "maxmemoryReserved", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxmemoryReserved
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_cache#notify_keyspace_events RedisCache#notify_keyspace_events}.</summary>
        [JsiiProperty(name: "notifyKeyspaceEvents", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NotifyKeyspaceEvents
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_cache#rdb_backup_enabled RedisCache#rdb_backup_enabled}.</summary>
        [JsiiProperty(name: "rdbBackupEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RdbBackupEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_cache#rdb_backup_frequency RedisCache#rdb_backup_frequency}.</summary>
        [JsiiProperty(name: "rdbBackupFrequency", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? RdbBackupFrequency
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_cache#rdb_backup_max_snapshot_count RedisCache#rdb_backup_max_snapshot_count}.</summary>
        [JsiiProperty(name: "rdbBackupMaxSnapshotCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? RdbBackupMaxSnapshotCount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_cache#rdb_storage_connection_string RedisCache#rdb_storage_connection_string}.</summary>
        [JsiiProperty(name: "rdbStorageConnectionString", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RdbStorageConnectionString
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_cache#storage_account_subscription_id RedisCache#storage_account_subscription_id}.</summary>
        [JsiiProperty(name: "storageAccountSubscriptionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StorageAccountSubscriptionId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRedisCacheRedisConfiguration), fullyQualifiedName: "azurerm.redisCache.RedisCacheRedisConfiguration")]
        internal sealed class _Proxy : DeputyBase, azurerm.RedisCache.IRedisCacheRedisConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_cache#active_directory_authentication_enabled RedisCache#active_directory_authentication_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "activeDirectoryAuthenticationEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? ActiveDirectoryAuthenticationEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_cache#aof_backup_enabled RedisCache#aof_backup_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "aofBackupEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? AofBackupEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_cache#aof_storage_connection_string_0 RedisCache#aof_storage_connection_string_0}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "aofStorageConnectionString0", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AofStorageConnectionString0
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_cache#aof_storage_connection_string_1 RedisCache#aof_storage_connection_string_1}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "aofStorageConnectionString1", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AofStorageConnectionString1
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_cache#authentication_enabled RedisCache#authentication_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "authenticationEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? AuthenticationEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_cache#data_persistence_authentication_method RedisCache#data_persistence_authentication_method}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dataPersistenceAuthenticationMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DataPersistenceAuthenticationMethod
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_cache#maxfragmentationmemory_reserved RedisCache#maxfragmentationmemory_reserved}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxfragmentationmemoryReserved", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxfragmentationmemoryReserved
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_cache#maxmemory_delta RedisCache#maxmemory_delta}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxmemoryDelta", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxmemoryDelta
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_cache#maxmemory_policy RedisCache#maxmemory_policy}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxmemoryPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MaxmemoryPolicy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_cache#maxmemory_reserved RedisCache#maxmemory_reserved}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxmemoryReserved", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxmemoryReserved
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_cache#notify_keyspace_events RedisCache#notify_keyspace_events}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "notifyKeyspaceEvents", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NotifyKeyspaceEvents
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_cache#rdb_backup_enabled RedisCache#rdb_backup_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "rdbBackupEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? RdbBackupEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_cache#rdb_backup_frequency RedisCache#rdb_backup_frequency}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "rdbBackupFrequency", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? RdbBackupFrequency
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_cache#rdb_backup_max_snapshot_count RedisCache#rdb_backup_max_snapshot_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "rdbBackupMaxSnapshotCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? RdbBackupMaxSnapshotCount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_cache#rdb_storage_connection_string RedisCache#rdb_storage_connection_string}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "rdbStorageConnectionString", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RdbStorageConnectionString
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_cache#storage_account_subscription_id RedisCache#storage_account_subscription_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "storageAccountSubscriptionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StorageAccountSubscriptionId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

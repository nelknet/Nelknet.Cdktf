using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.RedisCache
{
    [JsiiByValue(fqn: "azurerm.redisCache.RedisCacheRedisConfiguration")]
    public class RedisCacheRedisConfiguration : azurerm.RedisCache.IRedisCacheRedisConfiguration
    {
        private object? _activeDirectoryAuthenticationEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_cache#active_directory_authentication_enabled RedisCache#active_directory_authentication_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "activeDirectoryAuthenticationEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? ActiveDirectoryAuthenticationEnabled
        {
            get => _activeDirectoryAuthenticationEnabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _activeDirectoryAuthenticationEnabled = value;
            }
        }

        private object? _aofBackupEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_cache#aof_backup_enabled RedisCache#aof_backup_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "aofBackupEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? AofBackupEnabled
        {
            get => _aofBackupEnabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _aofBackupEnabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_cache#aof_storage_connection_string_0 RedisCache#aof_storage_connection_string_0}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "aofStorageConnectionString0", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AofStorageConnectionString0
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_cache#aof_storage_connection_string_1 RedisCache#aof_storage_connection_string_1}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "aofStorageConnectionString1", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AofStorageConnectionString1
        {
            get;
            set;
        }

        private object? _authenticationEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_cache#authentication_enabled RedisCache#authentication_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "authenticationEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? AuthenticationEnabled
        {
            get => _authenticationEnabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _authenticationEnabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_cache#data_persistence_authentication_method RedisCache#data_persistence_authentication_method}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dataPersistenceAuthenticationMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DataPersistenceAuthenticationMethod
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_cache#maxfragmentationmemory_reserved RedisCache#maxfragmentationmemory_reserved}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxfragmentationmemoryReserved", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxfragmentationmemoryReserved
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_cache#maxmemory_delta RedisCache#maxmemory_delta}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxmemoryDelta", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxmemoryDelta
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_cache#maxmemory_policy RedisCache#maxmemory_policy}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxmemoryPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MaxmemoryPolicy
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_cache#maxmemory_reserved RedisCache#maxmemory_reserved}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxmemoryReserved", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxmemoryReserved
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_cache#notify_keyspace_events RedisCache#notify_keyspace_events}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "notifyKeyspaceEvents", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NotifyKeyspaceEvents
        {
            get;
            set;
        }

        private object? _rdbBackupEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_cache#rdb_backup_enabled RedisCache#rdb_backup_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "rdbBackupEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? RdbBackupEnabled
        {
            get => _rdbBackupEnabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _rdbBackupEnabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_cache#rdb_backup_frequency RedisCache#rdb_backup_frequency}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "rdbBackupFrequency", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? RdbBackupFrequency
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_cache#rdb_backup_max_snapshot_count RedisCache#rdb_backup_max_snapshot_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "rdbBackupMaxSnapshotCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? RdbBackupMaxSnapshotCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_cache#rdb_storage_connection_string RedisCache#rdb_storage_connection_string}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "rdbStorageConnectionString", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RdbStorageConnectionString
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_cache#storage_account_subscription_id RedisCache#storage_account_subscription_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "storageAccountSubscriptionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StorageAccountSubscriptionId
        {
            get;
            set;
        }
    }
}

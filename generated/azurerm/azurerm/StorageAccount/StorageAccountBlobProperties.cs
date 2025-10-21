using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StorageAccount
{
    [JsiiByValue(fqn: "azurerm.storageAccount.StorageAccountBlobProperties")]
    public class StorageAccountBlobProperties : azurerm.StorageAccount.IStorageAccountBlobProperties
    {
        private object? _changeFeedEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#change_feed_enabled StorageAccount#change_feed_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "changeFeedEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? ChangeFeedEnabled
        {
            get => _changeFeedEnabled;
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
                _changeFeedEnabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#change_feed_retention_in_days StorageAccount#change_feed_retention_in_days}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "changeFeedRetentionInDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ChangeFeedRetentionInDays
        {
            get;
            set;
        }

        /// <summary>container_delete_retention_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#container_delete_retention_policy StorageAccount#container_delete_retention_policy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "containerDeleteRetentionPolicy", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountBlobPropertiesContainerDeleteRetentionPolicy\"}", isOptional: true)]
        public azurerm.StorageAccount.IStorageAccountBlobPropertiesContainerDeleteRetentionPolicy? ContainerDeleteRetentionPolicy
        {
            get;
            set;
        }

        private object? _corsRule;

        /// <summary>cors_rule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#cors_rule StorageAccount#cors_rule}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "corsRule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.storageAccount.StorageAccountBlobPropertiesCorsRule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CorsRule
        {
            get => _corsRule;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.StorageAccount.IStorageAccountBlobPropertiesCorsRule[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.StorageAccount.IStorageAccountBlobPropertiesCorsRule).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _corsRule = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#default_service_version StorageAccount#default_service_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "defaultServiceVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DefaultServiceVersion
        {
            get;
            set;
        }

        /// <summary>delete_retention_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#delete_retention_policy StorageAccount#delete_retention_policy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "deleteRetentionPolicy", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountBlobPropertiesDeleteRetentionPolicy\"}", isOptional: true)]
        public azurerm.StorageAccount.IStorageAccountBlobPropertiesDeleteRetentionPolicy? DeleteRetentionPolicy
        {
            get;
            set;
        }

        private object? _lastAccessTimeEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#last_access_time_enabled StorageAccount#last_access_time_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "lastAccessTimeEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? LastAccessTimeEnabled
        {
            get => _lastAccessTimeEnabled;
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
                _lastAccessTimeEnabled = value;
            }
        }

        /// <summary>restore_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#restore_policy StorageAccount#restore_policy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "restorePolicy", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountBlobPropertiesRestorePolicy\"}", isOptional: true)]
        public azurerm.StorageAccount.IStorageAccountBlobPropertiesRestorePolicy? RestorePolicy
        {
            get;
            set;
        }

        private object? _versioningEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#versioning_enabled StorageAccount#versioning_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "versioningEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? VersioningEnabled
        {
            get => _versioningEnabled;
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
                _versioningEnabled = value;
            }
        }
    }
}

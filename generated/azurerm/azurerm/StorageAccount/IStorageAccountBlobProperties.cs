using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StorageAccount
{
    [JsiiInterface(nativeType: typeof(IStorageAccountBlobProperties), fullyQualifiedName: "azurerm.storageAccount.StorageAccountBlobProperties")]
    public interface IStorageAccountBlobProperties
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#change_feed_enabled StorageAccount#change_feed_enabled}.</summary>
        [JsiiProperty(name: "changeFeedEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ChangeFeedEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#change_feed_retention_in_days StorageAccount#change_feed_retention_in_days}.</summary>
        [JsiiProperty(name: "changeFeedRetentionInDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ChangeFeedRetentionInDays
        {
            get
            {
                return null;
            }
        }

        /// <summary>container_delete_retention_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#container_delete_retention_policy StorageAccount#container_delete_retention_policy}
        /// </remarks>
        [JsiiProperty(name: "containerDeleteRetentionPolicy", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountBlobPropertiesContainerDeleteRetentionPolicy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.StorageAccount.IStorageAccountBlobPropertiesContainerDeleteRetentionPolicy? ContainerDeleteRetentionPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>cors_rule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#cors_rule StorageAccount#cors_rule}
        /// </remarks>
        [JsiiProperty(name: "corsRule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.storageAccount.StorageAccountBlobPropertiesCorsRule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CorsRule
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#default_service_version StorageAccount#default_service_version}.</summary>
        [JsiiProperty(name: "defaultServiceVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DefaultServiceVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>delete_retention_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#delete_retention_policy StorageAccount#delete_retention_policy}
        /// </remarks>
        [JsiiProperty(name: "deleteRetentionPolicy", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountBlobPropertiesDeleteRetentionPolicy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.StorageAccount.IStorageAccountBlobPropertiesDeleteRetentionPolicy? DeleteRetentionPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#last_access_time_enabled StorageAccount#last_access_time_enabled}.</summary>
        [JsiiProperty(name: "lastAccessTimeEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? LastAccessTimeEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>restore_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#restore_policy StorageAccount#restore_policy}
        /// </remarks>
        [JsiiProperty(name: "restorePolicy", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountBlobPropertiesRestorePolicy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.StorageAccount.IStorageAccountBlobPropertiesRestorePolicy? RestorePolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#versioning_enabled StorageAccount#versioning_enabled}.</summary>
        [JsiiProperty(name: "versioningEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? VersioningEnabled
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IStorageAccountBlobProperties), fullyQualifiedName: "azurerm.storageAccount.StorageAccountBlobProperties")]
        internal sealed class _Proxy : DeputyBase, azurerm.StorageAccount.IStorageAccountBlobProperties
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#change_feed_enabled StorageAccount#change_feed_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "changeFeedEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? ChangeFeedEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#change_feed_retention_in_days StorageAccount#change_feed_retention_in_days}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "changeFeedRetentionInDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ChangeFeedRetentionInDays
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>container_delete_retention_policy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#container_delete_retention_policy StorageAccount#container_delete_retention_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "containerDeleteRetentionPolicy", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountBlobPropertiesContainerDeleteRetentionPolicy\"}", isOptional: true)]
            public azurerm.StorageAccount.IStorageAccountBlobPropertiesContainerDeleteRetentionPolicy? ContainerDeleteRetentionPolicy
            {
                get => GetInstanceProperty<azurerm.StorageAccount.IStorageAccountBlobPropertiesContainerDeleteRetentionPolicy?>();
            }

            /// <summary>cors_rule block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#cors_rule StorageAccount#cors_rule}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "corsRule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.storageAccount.StorageAccountBlobPropertiesCorsRule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CorsRule
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#default_service_version StorageAccount#default_service_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "defaultServiceVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DefaultServiceVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>delete_retention_policy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#delete_retention_policy StorageAccount#delete_retention_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "deleteRetentionPolicy", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountBlobPropertiesDeleteRetentionPolicy\"}", isOptional: true)]
            public azurerm.StorageAccount.IStorageAccountBlobPropertiesDeleteRetentionPolicy? DeleteRetentionPolicy
            {
                get => GetInstanceProperty<azurerm.StorageAccount.IStorageAccountBlobPropertiesDeleteRetentionPolicy?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#last_access_time_enabled StorageAccount#last_access_time_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "lastAccessTimeEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? LastAccessTimeEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>restore_policy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#restore_policy StorageAccount#restore_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "restorePolicy", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountBlobPropertiesRestorePolicy\"}", isOptional: true)]
            public azurerm.StorageAccount.IStorageAccountBlobPropertiesRestorePolicy? RestorePolicy
            {
                get => GetInstanceProperty<azurerm.StorageAccount.IStorageAccountBlobPropertiesRestorePolicy?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#versioning_enabled StorageAccount#versioning_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "versioningEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? VersioningEnabled
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StorageAccount
{
    [JsiiInterface(nativeType: typeof(IStorageAccountQueueProperties), fullyQualifiedName: "azurerm.storageAccount.StorageAccountQueueProperties")]
    public interface IStorageAccountQueueProperties
    {
        /// <summary>cors_rule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#cors_rule StorageAccount#cors_rule}
        /// </remarks>
        [JsiiProperty(name: "corsRule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.storageAccount.StorageAccountQueuePropertiesCorsRule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CorsRule
        {
            get
            {
                return null;
            }
        }

        /// <summary>hour_metrics block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#hour_metrics StorageAccount#hour_metrics}
        /// </remarks>
        [JsiiProperty(name: "hourMetrics", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountQueuePropertiesHourMetrics\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.StorageAccount.IStorageAccountQueuePropertiesHourMetrics? HourMetrics
        {
            get
            {
                return null;
            }
        }

        /// <summary>logging block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#logging StorageAccount#logging}
        /// </remarks>
        [JsiiProperty(name: "logging", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountQueuePropertiesLogging\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.StorageAccount.IStorageAccountQueuePropertiesLogging? Logging
        {
            get
            {
                return null;
            }
        }

        /// <summary>minute_metrics block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#minute_metrics StorageAccount#minute_metrics}
        /// </remarks>
        [JsiiProperty(name: "minuteMetrics", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountQueuePropertiesMinuteMetrics\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.StorageAccount.IStorageAccountQueuePropertiesMinuteMetrics? MinuteMetrics
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IStorageAccountQueueProperties), fullyQualifiedName: "azurerm.storageAccount.StorageAccountQueueProperties")]
        internal sealed class _Proxy : DeputyBase, azurerm.StorageAccount.IStorageAccountQueueProperties
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>cors_rule block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#cors_rule StorageAccount#cors_rule}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "corsRule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.storageAccount.StorageAccountQueuePropertiesCorsRule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CorsRule
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>hour_metrics block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#hour_metrics StorageAccount#hour_metrics}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "hourMetrics", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountQueuePropertiesHourMetrics\"}", isOptional: true)]
            public azurerm.StorageAccount.IStorageAccountQueuePropertiesHourMetrics? HourMetrics
            {
                get => GetInstanceProperty<azurerm.StorageAccount.IStorageAccountQueuePropertiesHourMetrics?>();
            }

            /// <summary>logging block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#logging StorageAccount#logging}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "logging", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountQueuePropertiesLogging\"}", isOptional: true)]
            public azurerm.StorageAccount.IStorageAccountQueuePropertiesLogging? Logging
            {
                get => GetInstanceProperty<azurerm.StorageAccount.IStorageAccountQueuePropertiesLogging?>();
            }

            /// <summary>minute_metrics block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#minute_metrics StorageAccount#minute_metrics}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "minuteMetrics", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountQueuePropertiesMinuteMetrics\"}", isOptional: true)]
            public azurerm.StorageAccount.IStorageAccountQueuePropertiesMinuteMetrics? MinuteMetrics
            {
                get => GetInstanceProperty<azurerm.StorageAccount.IStorageAccountQueuePropertiesMinuteMetrics?>();
            }
        }
    }
}

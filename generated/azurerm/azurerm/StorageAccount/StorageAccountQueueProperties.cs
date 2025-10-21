using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StorageAccount
{
    [JsiiByValue(fqn: "azurerm.storageAccount.StorageAccountQueueProperties")]
    public class StorageAccountQueueProperties : azurerm.StorageAccount.IStorageAccountQueueProperties
    {
        private object? _corsRule;

        /// <summary>cors_rule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#cors_rule StorageAccount#cors_rule}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "corsRule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.storageAccount.StorageAccountQueuePropertiesCorsRule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case azurerm.StorageAccount.IStorageAccountQueuePropertiesCorsRule[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.StorageAccount.IStorageAccountQueuePropertiesCorsRule).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _corsRule = value;
            }
        }

        /// <summary>hour_metrics block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#hour_metrics StorageAccount#hour_metrics}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "hourMetrics", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountQueuePropertiesHourMetrics\"}", isOptional: true)]
        public azurerm.StorageAccount.IStorageAccountQueuePropertiesHourMetrics? HourMetrics
        {
            get;
            set;
        }

        /// <summary>logging block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#logging StorageAccount#logging}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "logging", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountQueuePropertiesLogging\"}", isOptional: true)]
        public azurerm.StorageAccount.IStorageAccountQueuePropertiesLogging? Logging
        {
            get;
            set;
        }

        /// <summary>minute_metrics block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#minute_metrics StorageAccount#minute_metrics}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "minuteMetrics", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountQueuePropertiesMinuteMetrics\"}", isOptional: true)]
        public azurerm.StorageAccount.IStorageAccountQueuePropertiesMinuteMetrics? MinuteMetrics
        {
            get;
            set;
        }
    }
}

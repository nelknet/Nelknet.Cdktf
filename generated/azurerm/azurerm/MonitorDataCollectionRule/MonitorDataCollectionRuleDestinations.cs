using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MonitorDataCollectionRule
{
    [JsiiByValue(fqn: "azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDestinations")]
    public class MonitorDataCollectionRuleDestinations : azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDestinations
    {
        /// <summary>azure_monitor_metrics block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#azure_monitor_metrics MonitorDataCollectionRule#azure_monitor_metrics}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "azureMonitorMetrics", typeJson: "{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDestinationsAzureMonitorMetrics\"}", isOptional: true)]
        public azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDestinationsAzureMonitorMetrics? AzureMonitorMetrics
        {
            get;
            set;
        }

        /// <summary>event_hub block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#event_hub MonitorDataCollectionRule#event_hub}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "eventHub", typeJson: "{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDestinationsEventHub\"}", isOptional: true)]
        public azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDestinationsEventHub? EventHub
        {
            get;
            set;
        }

        /// <summary>event_hub_direct block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#event_hub_direct MonitorDataCollectionRule#event_hub_direct}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "eventHubDirect", typeJson: "{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDestinationsEventHubDirect\"}", isOptional: true)]
        public azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDestinationsEventHubDirect? EventHubDirect
        {
            get;
            set;
        }

        private object? _logAnalytics;

        /// <summary>log_analytics block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#log_analytics MonitorDataCollectionRule#log_analytics}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "logAnalytics", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDestinationsLogAnalytics\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? LogAnalytics
        {
            get => _logAnalytics;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDestinationsLogAnalytics[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDestinationsLogAnalytics).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _logAnalytics = value;
            }
        }

        private object? _monitorAccount;

        /// <summary>monitor_account block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#monitor_account MonitorDataCollectionRule#monitor_account}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "monitorAccount", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDestinationsMonitorAccount\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? MonitorAccount
        {
            get => _monitorAccount;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDestinationsMonitorAccount[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDestinationsMonitorAccount).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _monitorAccount = value;
            }
        }

        private object? _storageBlob;

        /// <summary>storage_blob block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#storage_blob MonitorDataCollectionRule#storage_blob}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "storageBlob", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDestinationsStorageBlob\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? StorageBlob
        {
            get => _storageBlob;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDestinationsStorageBlob[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDestinationsStorageBlob).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _storageBlob = value;
            }
        }

        private object? _storageBlobDirect;

        /// <summary>storage_blob_direct block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#storage_blob_direct MonitorDataCollectionRule#storage_blob_direct}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "storageBlobDirect", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDestinationsStorageBlobDirect\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? StorageBlobDirect
        {
            get => _storageBlobDirect;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDestinationsStorageBlobDirect[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDestinationsStorageBlobDirect).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _storageBlobDirect = value;
            }
        }

        private object? _storageTableDirect;

        /// <summary>storage_table_direct block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#storage_table_direct MonitorDataCollectionRule#storage_table_direct}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "storageTableDirect", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDestinationsStorageTableDirect\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? StorageTableDirect
        {
            get => _storageTableDirect;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDestinationsStorageTableDirect[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDestinationsStorageTableDirect).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _storageTableDirect = value;
            }
        }
    }
}

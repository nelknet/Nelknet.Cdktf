using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MonitorDataCollectionRule
{
    [JsiiInterface(nativeType: typeof(IMonitorDataCollectionRuleDestinations), fullyQualifiedName: "azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDestinations")]
    public interface IMonitorDataCollectionRuleDestinations
    {
        /// <summary>azure_monitor_metrics block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#azure_monitor_metrics MonitorDataCollectionRule#azure_monitor_metrics}
        /// </remarks>
        [JsiiProperty(name: "azureMonitorMetrics", typeJson: "{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDestinationsAzureMonitorMetrics\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDestinationsAzureMonitorMetrics? AzureMonitorMetrics
        {
            get
            {
                return null;
            }
        }

        /// <summary>event_hub block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#event_hub MonitorDataCollectionRule#event_hub}
        /// </remarks>
        [JsiiProperty(name: "eventHub", typeJson: "{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDestinationsEventHub\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDestinationsEventHub? EventHub
        {
            get
            {
                return null;
            }
        }

        /// <summary>event_hub_direct block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#event_hub_direct MonitorDataCollectionRule#event_hub_direct}
        /// </remarks>
        [JsiiProperty(name: "eventHubDirect", typeJson: "{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDestinationsEventHubDirect\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDestinationsEventHubDirect? EventHubDirect
        {
            get
            {
                return null;
            }
        }

        /// <summary>log_analytics block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#log_analytics MonitorDataCollectionRule#log_analytics}
        /// </remarks>
        [JsiiProperty(name: "logAnalytics", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDestinationsLogAnalytics\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? LogAnalytics
        {
            get
            {
                return null;
            }
        }

        /// <summary>monitor_account block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#monitor_account MonitorDataCollectionRule#monitor_account}
        /// </remarks>
        [JsiiProperty(name: "monitorAccount", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDestinationsMonitorAccount\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? MonitorAccount
        {
            get
            {
                return null;
            }
        }

        /// <summary>storage_blob block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#storage_blob MonitorDataCollectionRule#storage_blob}
        /// </remarks>
        [JsiiProperty(name: "storageBlob", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDestinationsStorageBlob\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? StorageBlob
        {
            get
            {
                return null;
            }
        }

        /// <summary>storage_blob_direct block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#storage_blob_direct MonitorDataCollectionRule#storage_blob_direct}
        /// </remarks>
        [JsiiProperty(name: "storageBlobDirect", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDestinationsStorageBlobDirect\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? StorageBlobDirect
        {
            get
            {
                return null;
            }
        }

        /// <summary>storage_table_direct block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#storage_table_direct MonitorDataCollectionRule#storage_table_direct}
        /// </remarks>
        [JsiiProperty(name: "storageTableDirect", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDestinationsStorageTableDirect\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? StorageTableDirect
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMonitorDataCollectionRuleDestinations), fullyQualifiedName: "azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDestinations")]
        internal sealed class _Proxy : DeputyBase, azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDestinations
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>azure_monitor_metrics block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#azure_monitor_metrics MonitorDataCollectionRule#azure_monitor_metrics}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "azureMonitorMetrics", typeJson: "{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDestinationsAzureMonitorMetrics\"}", isOptional: true)]
            public azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDestinationsAzureMonitorMetrics? AzureMonitorMetrics
            {
                get => GetInstanceProperty<azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDestinationsAzureMonitorMetrics?>();
            }

            /// <summary>event_hub block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#event_hub MonitorDataCollectionRule#event_hub}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "eventHub", typeJson: "{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDestinationsEventHub\"}", isOptional: true)]
            public azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDestinationsEventHub? EventHub
            {
                get => GetInstanceProperty<azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDestinationsEventHub?>();
            }

            /// <summary>event_hub_direct block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#event_hub_direct MonitorDataCollectionRule#event_hub_direct}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "eventHubDirect", typeJson: "{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDestinationsEventHubDirect\"}", isOptional: true)]
            public azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDestinationsEventHubDirect? EventHubDirect
            {
                get => GetInstanceProperty<azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDestinationsEventHubDirect?>();
            }

            /// <summary>log_analytics block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#log_analytics MonitorDataCollectionRule#log_analytics}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "logAnalytics", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDestinationsLogAnalytics\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? LogAnalytics
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>monitor_account block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#monitor_account MonitorDataCollectionRule#monitor_account}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "monitorAccount", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDestinationsMonitorAccount\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? MonitorAccount
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>storage_blob block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#storage_blob MonitorDataCollectionRule#storage_blob}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "storageBlob", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDestinationsStorageBlob\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? StorageBlob
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>storage_blob_direct block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#storage_blob_direct MonitorDataCollectionRule#storage_blob_direct}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "storageBlobDirect", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDestinationsStorageBlobDirect\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? StorageBlobDirect
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>storage_table_direct block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#storage_table_direct MonitorDataCollectionRule#storage_table_direct}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "storageTableDirect", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDestinationsStorageTableDirect\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? StorageTableDirect
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}

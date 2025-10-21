using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MonitorDataCollectionRule
{
    [JsiiInterface(nativeType: typeof(IMonitorDataCollectionRuleDataSources), fullyQualifiedName: "azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDataSources")]
    public interface IMonitorDataCollectionRuleDataSources
    {
        /// <summary>data_import block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#data_import MonitorDataCollectionRule#data_import}
        /// </remarks>
        [JsiiProperty(name: "dataImport", typeJson: "{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesDataImport\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDataSourcesDataImport? DataImport
        {
            get
            {
                return null;
            }
        }

        /// <summary>extension block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#extension MonitorDataCollectionRule#extension}
        /// </remarks>
        [JsiiProperty(name: "extension", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesExtension\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Extension
        {
            get
            {
                return null;
            }
        }

        /// <summary>iis_log block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#iis_log MonitorDataCollectionRule#iis_log}
        /// </remarks>
        [JsiiProperty(name: "iisLog", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesIisLog\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IisLog
        {
            get
            {
                return null;
            }
        }

        /// <summary>log_file block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#log_file MonitorDataCollectionRule#log_file}
        /// </remarks>
        [JsiiProperty(name: "logFile", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesLogFile\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? LogFile
        {
            get
            {
                return null;
            }
        }

        /// <summary>performance_counter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#performance_counter MonitorDataCollectionRule#performance_counter}
        /// </remarks>
        [JsiiProperty(name: "performanceCounter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesPerformanceCounter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PerformanceCounter
        {
            get
            {
                return null;
            }
        }

        /// <summary>platform_telemetry block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#platform_telemetry MonitorDataCollectionRule#platform_telemetry}
        /// </remarks>
        [JsiiProperty(name: "platformTelemetry", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesPlatformTelemetry\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PlatformTelemetry
        {
            get
            {
                return null;
            }
        }

        /// <summary>prometheus_forwarder block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#prometheus_forwarder MonitorDataCollectionRule#prometheus_forwarder}
        /// </remarks>
        [JsiiProperty(name: "prometheusForwarder", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesPrometheusForwarder\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PrometheusForwarder
        {
            get
            {
                return null;
            }
        }

        /// <summary>syslog block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#syslog MonitorDataCollectionRule#syslog}
        /// </remarks>
        [JsiiProperty(name: "syslog", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesSyslog\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Syslog
        {
            get
            {
                return null;
            }
        }

        /// <summary>windows_event_log block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#windows_event_log MonitorDataCollectionRule#windows_event_log}
        /// </remarks>
        [JsiiProperty(name: "windowsEventLog", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesWindowsEventLog\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? WindowsEventLog
        {
            get
            {
                return null;
            }
        }

        /// <summary>windows_firewall_log block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#windows_firewall_log MonitorDataCollectionRule#windows_firewall_log}
        /// </remarks>
        [JsiiProperty(name: "windowsFirewallLog", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesWindowsFirewallLog\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? WindowsFirewallLog
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMonitorDataCollectionRuleDataSources), fullyQualifiedName: "azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDataSources")]
        internal sealed class _Proxy : DeputyBase, azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDataSources
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>data_import block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#data_import MonitorDataCollectionRule#data_import}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dataImport", typeJson: "{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesDataImport\"}", isOptional: true)]
            public azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDataSourcesDataImport? DataImport
            {
                get => GetInstanceProperty<azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDataSourcesDataImport?>();
            }

            /// <summary>extension block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#extension MonitorDataCollectionRule#extension}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "extension", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesExtension\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Extension
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>iis_log block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#iis_log MonitorDataCollectionRule#iis_log}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "iisLog", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesIisLog\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? IisLog
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>log_file block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#log_file MonitorDataCollectionRule#log_file}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "logFile", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesLogFile\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? LogFile
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>performance_counter block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#performance_counter MonitorDataCollectionRule#performance_counter}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "performanceCounter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesPerformanceCounter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? PerformanceCounter
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>platform_telemetry block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#platform_telemetry MonitorDataCollectionRule#platform_telemetry}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "platformTelemetry", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesPlatformTelemetry\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? PlatformTelemetry
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>prometheus_forwarder block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#prometheus_forwarder MonitorDataCollectionRule#prometheus_forwarder}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "prometheusForwarder", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesPrometheusForwarder\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? PrometheusForwarder
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>syslog block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#syslog MonitorDataCollectionRule#syslog}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "syslog", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesSyslog\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Syslog
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>windows_event_log block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#windows_event_log MonitorDataCollectionRule#windows_event_log}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "windowsEventLog", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesWindowsEventLog\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? WindowsEventLog
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>windows_firewall_log block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#windows_firewall_log MonitorDataCollectionRule#windows_firewall_log}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "windowsFirewallLog", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesWindowsFirewallLog\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? WindowsFirewallLog
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}

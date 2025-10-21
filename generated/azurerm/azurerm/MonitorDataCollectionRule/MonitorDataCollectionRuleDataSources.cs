using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MonitorDataCollectionRule
{
    [JsiiByValue(fqn: "azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDataSources")]
    public class MonitorDataCollectionRuleDataSources : azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDataSources
    {
        /// <summary>data_import block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#data_import MonitorDataCollectionRule#data_import}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dataImport", typeJson: "{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesDataImport\"}", isOptional: true)]
        public azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDataSourcesDataImport? DataImport
        {
            get;
            set;
        }

        private object? _extension;

        /// <summary>extension block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#extension MonitorDataCollectionRule#extension}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "extension", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesExtension\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Extension
        {
            get => _extension;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDataSourcesExtension[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDataSourcesExtension).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _extension = value;
            }
        }

        private object? _iisLog;

        /// <summary>iis_log block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#iis_log MonitorDataCollectionRule#iis_log}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "iisLog", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesIisLog\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? IisLog
        {
            get => _iisLog;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDataSourcesIisLog[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDataSourcesIisLog).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _iisLog = value;
            }
        }

        private object? _logFile;

        /// <summary>log_file block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#log_file MonitorDataCollectionRule#log_file}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "logFile", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesLogFile\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? LogFile
        {
            get => _logFile;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDataSourcesLogFile[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDataSourcesLogFile).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _logFile = value;
            }
        }

        private object? _performanceCounter;

        /// <summary>performance_counter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#performance_counter MonitorDataCollectionRule#performance_counter}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "performanceCounter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesPerformanceCounter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? PerformanceCounter
        {
            get => _performanceCounter;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDataSourcesPerformanceCounter[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDataSourcesPerformanceCounter).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _performanceCounter = value;
            }
        }

        private object? _platformTelemetry;

        /// <summary>platform_telemetry block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#platform_telemetry MonitorDataCollectionRule#platform_telemetry}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "platformTelemetry", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesPlatformTelemetry\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? PlatformTelemetry
        {
            get => _platformTelemetry;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDataSourcesPlatformTelemetry[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDataSourcesPlatformTelemetry).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _platformTelemetry = value;
            }
        }

        private object? _prometheusForwarder;

        /// <summary>prometheus_forwarder block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#prometheus_forwarder MonitorDataCollectionRule#prometheus_forwarder}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "prometheusForwarder", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesPrometheusForwarder\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? PrometheusForwarder
        {
            get => _prometheusForwarder;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDataSourcesPrometheusForwarder[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDataSourcesPrometheusForwarder).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _prometheusForwarder = value;
            }
        }

        private object? _syslog;

        /// <summary>syslog block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#syslog MonitorDataCollectionRule#syslog}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "syslog", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesSyslog\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Syslog
        {
            get => _syslog;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDataSourcesSyslog[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDataSourcesSyslog).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _syslog = value;
            }
        }

        private object? _windowsEventLog;

        /// <summary>windows_event_log block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#windows_event_log MonitorDataCollectionRule#windows_event_log}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "windowsEventLog", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesWindowsEventLog\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? WindowsEventLog
        {
            get => _windowsEventLog;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDataSourcesWindowsEventLog[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDataSourcesWindowsEventLog).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _windowsEventLog = value;
            }
        }

        private object? _windowsFirewallLog;

        /// <summary>windows_firewall_log block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule#windows_firewall_log MonitorDataCollectionRule#windows_firewall_log}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "windowsFirewallLog", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesWindowsFirewallLog\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? WindowsFirewallLog
        {
            get => _windowsFirewallLog;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDataSourcesWindowsFirewallLog[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDataSourcesWindowsFirewallLog).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _windowsFirewallLog = value;
            }
        }
    }
}

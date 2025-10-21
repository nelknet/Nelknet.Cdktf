using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MonitorDataCollectionRule
{
    [JsiiClass(nativeType: typeof(azurerm.MonitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesOutputReference), fullyQualifiedName: "azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MonitorDataCollectionRuleDataSourcesOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MonitorDataCollectionRuleDataSourcesOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MonitorDataCollectionRuleDataSourcesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MonitorDataCollectionRuleDataSourcesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDataImport", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesDataImport\"}}]")]
        public virtual void PutDataImport(azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDataSourcesDataImport @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDataSourcesDataImport)}, new object[]{@value});
        }

        [JsiiMethod(name: "putExtension", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesExtension\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutExtension(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDataSourcesExtension[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDataSourcesExtension).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDataSourcesExtension).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIisLog", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesIisLog\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutIisLog(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDataSourcesIisLog[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDataSourcesIisLog).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDataSourcesIisLog).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLogFile", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesLogFile\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutLogFile(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDataSourcesLogFile[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDataSourcesLogFile).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDataSourcesLogFile).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPerformanceCounter", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesPerformanceCounter\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutPerformanceCounter(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDataSourcesPerformanceCounter[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDataSourcesPerformanceCounter).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDataSourcesPerformanceCounter).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPlatformTelemetry", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesPlatformTelemetry\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutPlatformTelemetry(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDataSourcesPlatformTelemetry[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDataSourcesPlatformTelemetry).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDataSourcesPlatformTelemetry).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPrometheusForwarder", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesPrometheusForwarder\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutPrometheusForwarder(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDataSourcesPrometheusForwarder[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDataSourcesPrometheusForwarder).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDataSourcesPrometheusForwarder).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSyslog", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesSyslog\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutSyslog(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDataSourcesSyslog[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDataSourcesSyslog).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDataSourcesSyslog).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putWindowsEventLog", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesWindowsEventLog\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutWindowsEventLog(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDataSourcesWindowsEventLog[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDataSourcesWindowsEventLog).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDataSourcesWindowsEventLog).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putWindowsFirewallLog", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesWindowsFirewallLog\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutWindowsFirewallLog(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDataSourcesWindowsFirewallLog[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDataSourcesWindowsFirewallLog).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDataSourcesWindowsFirewallLog).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDataImport")]
        public virtual void ResetDataImport()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExtension")]
        public virtual void ResetExtension()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIisLog")]
        public virtual void ResetIisLog()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLogFile")]
        public virtual void ResetLogFile()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPerformanceCounter")]
        public virtual void ResetPerformanceCounter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPlatformTelemetry")]
        public virtual void ResetPlatformTelemetry()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPrometheusForwarder")]
        public virtual void ResetPrometheusForwarder()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSyslog")]
        public virtual void ResetSyslog()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWindowsEventLog")]
        public virtual void ResetWindowsEventLog()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWindowsFirewallLog")]
        public virtual void ResetWindowsFirewallLog()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "dataImport", typeJson: "{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesDataImportOutputReference\"}")]
        public virtual azurerm.MonitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesDataImportOutputReference DataImport
        {
            get => GetInstanceProperty<azurerm.MonitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesDataImportOutputReference>()!;
        }

        [JsiiProperty(name: "extension", typeJson: "{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesExtensionList\"}")]
        public virtual azurerm.MonitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesExtensionList Extension
        {
            get => GetInstanceProperty<azurerm.MonitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesExtensionList>()!;
        }

        [JsiiProperty(name: "iisLog", typeJson: "{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesIisLogList\"}")]
        public virtual azurerm.MonitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesIisLogList IisLog
        {
            get => GetInstanceProperty<azurerm.MonitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesIisLogList>()!;
        }

        [JsiiProperty(name: "logFile", typeJson: "{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesLogFileList\"}")]
        public virtual azurerm.MonitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesLogFileList LogFile
        {
            get => GetInstanceProperty<azurerm.MonitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesLogFileList>()!;
        }

        [JsiiProperty(name: "performanceCounter", typeJson: "{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesPerformanceCounterList\"}")]
        public virtual azurerm.MonitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesPerformanceCounterList PerformanceCounter
        {
            get => GetInstanceProperty<azurerm.MonitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesPerformanceCounterList>()!;
        }

        [JsiiProperty(name: "platformTelemetry", typeJson: "{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesPlatformTelemetryList\"}")]
        public virtual azurerm.MonitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesPlatformTelemetryList PlatformTelemetry
        {
            get => GetInstanceProperty<azurerm.MonitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesPlatformTelemetryList>()!;
        }

        [JsiiProperty(name: "prometheusForwarder", typeJson: "{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesPrometheusForwarderList\"}")]
        public virtual azurerm.MonitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesPrometheusForwarderList PrometheusForwarder
        {
            get => GetInstanceProperty<azurerm.MonitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesPrometheusForwarderList>()!;
        }

        [JsiiProperty(name: "syslog", typeJson: "{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesSyslogList\"}")]
        public virtual azurerm.MonitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesSyslogList Syslog
        {
            get => GetInstanceProperty<azurerm.MonitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesSyslogList>()!;
        }

        [JsiiProperty(name: "windowsEventLog", typeJson: "{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesWindowsEventLogList\"}")]
        public virtual azurerm.MonitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesWindowsEventLogList WindowsEventLog
        {
            get => GetInstanceProperty<azurerm.MonitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesWindowsEventLogList>()!;
        }

        [JsiiProperty(name: "windowsFirewallLog", typeJson: "{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesWindowsFirewallLogList\"}")]
        public virtual azurerm.MonitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesWindowsFirewallLogList WindowsFirewallLog
        {
            get => GetInstanceProperty<azurerm.MonitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesWindowsFirewallLogList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataImportInput", typeJson: "{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesDataImport\"}", isOptional: true)]
        public virtual azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDataSourcesDataImport? DataImportInput
        {
            get => GetInstanceProperty<azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDataSourcesDataImport?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "extensionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesExtension\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ExtensionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "iisLogInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesIisLog\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? IisLogInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "logFileInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesLogFile\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? LogFileInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "performanceCounterInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesPerformanceCounter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? PerformanceCounterInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "platformTelemetryInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesPlatformTelemetry\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? PlatformTelemetryInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "prometheusForwarderInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesPrometheusForwarder\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? PrometheusForwarderInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "syslogInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesSyslog\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? SyslogInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "windowsEventLogInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesWindowsEventLog\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? WindowsEventLogInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "windowsFirewallLogInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDataSourcesWindowsFirewallLog\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? WindowsFirewallLogInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDataSources\"}", isOptional: true)]
        public virtual azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDataSources? InternalValue
        {
            get => GetInstanceProperty<azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDataSources?>();
            set => SetInstanceProperty(value);
        }
    }
}

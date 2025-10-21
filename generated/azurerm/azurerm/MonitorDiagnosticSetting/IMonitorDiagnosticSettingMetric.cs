using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MonitorDiagnosticSetting
{
    [JsiiInterface(nativeType: typeof(IMonitorDiagnosticSettingMetric), fullyQualifiedName: "azurerm.monitorDiagnosticSetting.MonitorDiagnosticSettingMetric")]
    public interface IMonitorDiagnosticSettingMetric
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_diagnostic_setting#category MonitorDiagnosticSetting#category}.</summary>
        [JsiiProperty(name: "category", typeJson: "{\"primitive\":\"string\"}")]
        string Category
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_diagnostic_setting#enabled MonitorDiagnosticSetting#enabled}.</summary>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Enabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>retention_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_diagnostic_setting#retention_policy MonitorDiagnosticSetting#retention_policy}
        /// </remarks>
        [JsiiProperty(name: "retentionPolicy", typeJson: "{\"fqn\":\"azurerm.monitorDiagnosticSetting.MonitorDiagnosticSettingMetricRetentionPolicy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.MonitorDiagnosticSetting.IMonitorDiagnosticSettingMetricRetentionPolicy? RetentionPolicy
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMonitorDiagnosticSettingMetric), fullyQualifiedName: "azurerm.monitorDiagnosticSetting.MonitorDiagnosticSettingMetric")]
        internal sealed class _Proxy : DeputyBase, azurerm.MonitorDiagnosticSetting.IMonitorDiagnosticSettingMetric
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_diagnostic_setting#category MonitorDiagnosticSetting#category}.</summary>
            [JsiiProperty(name: "category", typeJson: "{\"primitive\":\"string\"}")]
            public string Category
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_diagnostic_setting#enabled MonitorDiagnosticSetting#enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Enabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>retention_policy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_diagnostic_setting#retention_policy MonitorDiagnosticSetting#retention_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "retentionPolicy", typeJson: "{\"fqn\":\"azurerm.monitorDiagnosticSetting.MonitorDiagnosticSettingMetricRetentionPolicy\"}", isOptional: true)]
            public azurerm.MonitorDiagnosticSetting.IMonitorDiagnosticSettingMetricRetentionPolicy? RetentionPolicy
            {
                get => GetInstanceProperty<azurerm.MonitorDiagnosticSetting.IMonitorDiagnosticSettingMetricRetentionPolicy?>();
            }
        }
    }
}

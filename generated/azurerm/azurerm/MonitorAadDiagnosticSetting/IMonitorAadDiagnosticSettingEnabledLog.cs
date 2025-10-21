using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MonitorAadDiagnosticSetting
{
    [JsiiInterface(nativeType: typeof(IMonitorAadDiagnosticSettingEnabledLog), fullyQualifiedName: "azurerm.monitorAadDiagnosticSetting.MonitorAadDiagnosticSettingEnabledLog")]
    public interface IMonitorAadDiagnosticSettingEnabledLog
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_aad_diagnostic_setting#category MonitorAadDiagnosticSetting#category}.</summary>
        [JsiiProperty(name: "category", typeJson: "{\"primitive\":\"string\"}")]
        string Category
        {
            get;
        }

        /// <summary>retention_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_aad_diagnostic_setting#retention_policy MonitorAadDiagnosticSetting#retention_policy}
        /// </remarks>
        [JsiiProperty(name: "retentionPolicy", typeJson: "{\"fqn\":\"azurerm.monitorAadDiagnosticSetting.MonitorAadDiagnosticSettingEnabledLogRetentionPolicy\"}")]
        azurerm.MonitorAadDiagnosticSetting.IMonitorAadDiagnosticSettingEnabledLogRetentionPolicy RetentionPolicy
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMonitorAadDiagnosticSettingEnabledLog), fullyQualifiedName: "azurerm.monitorAadDiagnosticSetting.MonitorAadDiagnosticSettingEnabledLog")]
        internal sealed class _Proxy : DeputyBase, azurerm.MonitorAadDiagnosticSetting.IMonitorAadDiagnosticSettingEnabledLog
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_aad_diagnostic_setting#category MonitorAadDiagnosticSetting#category}.</summary>
            [JsiiProperty(name: "category", typeJson: "{\"primitive\":\"string\"}")]
            public string Category
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>retention_policy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_aad_diagnostic_setting#retention_policy MonitorAadDiagnosticSetting#retention_policy}
            /// </remarks>
            [JsiiProperty(name: "retentionPolicy", typeJson: "{\"fqn\":\"azurerm.monitorAadDiagnosticSetting.MonitorAadDiagnosticSettingEnabledLogRetentionPolicy\"}")]
            public azurerm.MonitorAadDiagnosticSetting.IMonitorAadDiagnosticSettingEnabledLogRetentionPolicy RetentionPolicy
            {
                get => GetInstanceProperty<azurerm.MonitorAadDiagnosticSetting.IMonitorAadDiagnosticSettingEnabledLogRetentionPolicy>()!;
            }
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MonitorDiagnosticSetting
{
    [JsiiByValue(fqn: "azurerm.monitorDiagnosticSetting.MonitorDiagnosticSettingEnabledLog")]
    public class MonitorDiagnosticSettingEnabledLog : azurerm.MonitorDiagnosticSetting.IMonitorDiagnosticSettingEnabledLog
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_diagnostic_setting#category MonitorDiagnosticSetting#category}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "category", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Category
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_diagnostic_setting#category_group MonitorDiagnosticSetting#category_group}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "categoryGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CategoryGroup
        {
            get;
            set;
        }

        /// <summary>retention_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_diagnostic_setting#retention_policy MonitorDiagnosticSetting#retention_policy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "retentionPolicy", typeJson: "{\"fqn\":\"azurerm.monitorDiagnosticSetting.MonitorDiagnosticSettingEnabledLogRetentionPolicy\"}", isOptional: true)]
        public azurerm.MonitorDiagnosticSetting.IMonitorDiagnosticSettingEnabledLogRetentionPolicy? RetentionPolicy
        {
            get;
            set;
        }
    }
}

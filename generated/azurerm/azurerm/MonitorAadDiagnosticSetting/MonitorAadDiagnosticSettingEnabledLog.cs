using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MonitorAadDiagnosticSetting
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.monitorAadDiagnosticSetting.MonitorAadDiagnosticSettingEnabledLog")]
    public class MonitorAadDiagnosticSettingEnabledLog : azurerm.MonitorAadDiagnosticSetting.IMonitorAadDiagnosticSettingEnabledLog
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_aad_diagnostic_setting#category MonitorAadDiagnosticSetting#category}.</summary>
        [JsiiProperty(name: "category", typeJson: "{\"primitive\":\"string\"}")]
        public string Category
        {
            get;
            set;
        }

        /// <summary>retention_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_aad_diagnostic_setting#retention_policy MonitorAadDiagnosticSetting#retention_policy}
        /// </remarks>
        [JsiiProperty(name: "retentionPolicy", typeJson: "{\"fqn\":\"azurerm.monitorAadDiagnosticSetting.MonitorAadDiagnosticSettingEnabledLogRetentionPolicy\"}")]
        public azurerm.MonitorAadDiagnosticSetting.IMonitorAadDiagnosticSettingEnabledLogRetentionPolicy RetentionPolicy
        {
            get;
            set;
        }
    }
}

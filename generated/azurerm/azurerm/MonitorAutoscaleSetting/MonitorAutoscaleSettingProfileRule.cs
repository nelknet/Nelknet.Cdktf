using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MonitorAutoscaleSetting
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.monitorAutoscaleSetting.MonitorAutoscaleSettingProfileRule")]
    public class MonitorAutoscaleSettingProfileRule : azurerm.MonitorAutoscaleSetting.IMonitorAutoscaleSettingProfileRule
    {
        /// <summary>metric_trigger block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_autoscale_setting#metric_trigger MonitorAutoscaleSetting#metric_trigger}
        /// </remarks>
        [JsiiProperty(name: "metricTrigger", typeJson: "{\"fqn\":\"azurerm.monitorAutoscaleSetting.MonitorAutoscaleSettingProfileRuleMetricTrigger\"}")]
        public azurerm.MonitorAutoscaleSetting.IMonitorAutoscaleSettingProfileRuleMetricTrigger MetricTrigger
        {
            get;
            set;
        }

        /// <summary>scale_action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_autoscale_setting#scale_action MonitorAutoscaleSetting#scale_action}
        /// </remarks>
        [JsiiProperty(name: "scaleAction", typeJson: "{\"fqn\":\"azurerm.monitorAutoscaleSetting.MonitorAutoscaleSettingProfileRuleScaleAction\"}")]
        public azurerm.MonitorAutoscaleSetting.IMonitorAutoscaleSettingProfileRuleScaleAction ScaleAction
        {
            get;
            set;
        }
    }
}

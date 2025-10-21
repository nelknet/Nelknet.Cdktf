using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MonitorAutoscaleSetting
{
    [JsiiInterface(nativeType: typeof(IMonitorAutoscaleSettingProfileRule), fullyQualifiedName: "azurerm.monitorAutoscaleSetting.MonitorAutoscaleSettingProfileRule")]
    public interface IMonitorAutoscaleSettingProfileRule
    {
        /// <summary>metric_trigger block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_autoscale_setting#metric_trigger MonitorAutoscaleSetting#metric_trigger}
        /// </remarks>
        [JsiiProperty(name: "metricTrigger", typeJson: "{\"fqn\":\"azurerm.monitorAutoscaleSetting.MonitorAutoscaleSettingProfileRuleMetricTrigger\"}")]
        azurerm.MonitorAutoscaleSetting.IMonitorAutoscaleSettingProfileRuleMetricTrigger MetricTrigger
        {
            get;
        }

        /// <summary>scale_action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_autoscale_setting#scale_action MonitorAutoscaleSetting#scale_action}
        /// </remarks>
        [JsiiProperty(name: "scaleAction", typeJson: "{\"fqn\":\"azurerm.monitorAutoscaleSetting.MonitorAutoscaleSettingProfileRuleScaleAction\"}")]
        azurerm.MonitorAutoscaleSetting.IMonitorAutoscaleSettingProfileRuleScaleAction ScaleAction
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMonitorAutoscaleSettingProfileRule), fullyQualifiedName: "azurerm.monitorAutoscaleSetting.MonitorAutoscaleSettingProfileRule")]
        internal sealed class _Proxy : DeputyBase, azurerm.MonitorAutoscaleSetting.IMonitorAutoscaleSettingProfileRule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>metric_trigger block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_autoscale_setting#metric_trigger MonitorAutoscaleSetting#metric_trigger}
            /// </remarks>
            [JsiiProperty(name: "metricTrigger", typeJson: "{\"fqn\":\"azurerm.monitorAutoscaleSetting.MonitorAutoscaleSettingProfileRuleMetricTrigger\"}")]
            public azurerm.MonitorAutoscaleSetting.IMonitorAutoscaleSettingProfileRuleMetricTrigger MetricTrigger
            {
                get => GetInstanceProperty<azurerm.MonitorAutoscaleSetting.IMonitorAutoscaleSettingProfileRuleMetricTrigger>()!;
            }

            /// <summary>scale_action block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_autoscale_setting#scale_action MonitorAutoscaleSetting#scale_action}
            /// </remarks>
            [JsiiProperty(name: "scaleAction", typeJson: "{\"fqn\":\"azurerm.monitorAutoscaleSetting.MonitorAutoscaleSettingProfileRuleScaleAction\"}")]
            public azurerm.MonitorAutoscaleSetting.IMonitorAutoscaleSettingProfileRuleScaleAction ScaleAction
            {
                get => GetInstanceProperty<azurerm.MonitorAutoscaleSetting.IMonitorAutoscaleSettingProfileRuleScaleAction>()!;
            }
        }
    }
}

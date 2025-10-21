using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MonitorAutoscaleSetting
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.monitorAutoscaleSetting.MonitorAutoscaleSettingPredictive")]
    public class MonitorAutoscaleSettingPredictive : azurerm.MonitorAutoscaleSetting.IMonitorAutoscaleSettingPredictive
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_autoscale_setting#scale_mode MonitorAutoscaleSetting#scale_mode}.</summary>
        [JsiiProperty(name: "scaleMode", typeJson: "{\"primitive\":\"string\"}")]
        public string ScaleMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_autoscale_setting#look_ahead_time MonitorAutoscaleSetting#look_ahead_time}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "lookAheadTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LookAheadTime
        {
            get;
            set;
        }
    }
}

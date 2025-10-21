using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MonitorAutoscaleSetting
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.monitorAutoscaleSetting.MonitorAutoscaleSettingProfileCapacity")]
    public class MonitorAutoscaleSettingProfileCapacity : azurerm.MonitorAutoscaleSetting.IMonitorAutoscaleSettingProfileCapacity
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_autoscale_setting#default MonitorAutoscaleSetting#default}.</summary>
        [JsiiProperty(name: "default", typeJson: "{\"primitive\":\"number\"}")]
        public double Default
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_autoscale_setting#maximum MonitorAutoscaleSetting#maximum}.</summary>
        [JsiiProperty(name: "maximum", typeJson: "{\"primitive\":\"number\"}")]
        public double Maximum
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_autoscale_setting#minimum MonitorAutoscaleSetting#minimum}.</summary>
        [JsiiProperty(name: "minimum", typeJson: "{\"primitive\":\"number\"}")]
        public double Minimum
        {
            get;
            set;
        }
    }
}

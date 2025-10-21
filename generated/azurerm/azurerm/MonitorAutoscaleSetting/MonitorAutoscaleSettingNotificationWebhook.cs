using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MonitorAutoscaleSetting
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.monitorAutoscaleSetting.MonitorAutoscaleSettingNotificationWebhook")]
    public class MonitorAutoscaleSettingNotificationWebhook : azurerm.MonitorAutoscaleSetting.IMonitorAutoscaleSettingNotificationWebhook
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_autoscale_setting#service_uri MonitorAutoscaleSetting#service_uri}.</summary>
        [JsiiProperty(name: "serviceUri", typeJson: "{\"primitive\":\"string\"}")]
        public string ServiceUri
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_autoscale_setting#properties MonitorAutoscaleSetting#properties}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "properties", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Properties
        {
            get;
            set;
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MonitorActivityLogAlert
{
    [JsiiByValue(fqn: "azurerm.monitorActivityLogAlert.MonitorActivityLogAlertCriteriaServiceHealth")]
    public class MonitorActivityLogAlertCriteriaServiceHealth : azurerm.MonitorActivityLogAlert.IMonitorActivityLogAlertCriteriaServiceHealth
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_activity_log_alert#events MonitorActivityLogAlert#events}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "events", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Events
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_activity_log_alert#locations MonitorActivityLogAlert#locations}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "locations", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Locations
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_activity_log_alert#services MonitorActivityLogAlert#services}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "services", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Services
        {
            get;
            set;
        }
    }
}

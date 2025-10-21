using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MonitorActivityLogAlert
{
    [JsiiByValue(fqn: "azurerm.monitorActivityLogAlert.MonitorActivityLogAlertCriteriaResourceHealth")]
    public class MonitorActivityLogAlertCriteriaResourceHealth : azurerm.MonitorActivityLogAlert.IMonitorActivityLogAlertCriteriaResourceHealth
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_activity_log_alert#current MonitorActivityLogAlert#current}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "current", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Current
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_activity_log_alert#previous MonitorActivityLogAlert#previous}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "previous", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Previous
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_activity_log_alert#reason MonitorActivityLogAlert#reason}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "reason", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Reason
        {
            get;
            set;
        }
    }
}

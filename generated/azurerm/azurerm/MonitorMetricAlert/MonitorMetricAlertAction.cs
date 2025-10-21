using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MonitorMetricAlert
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.monitorMetricAlert.MonitorMetricAlertAction")]
    public class MonitorMetricAlertAction : azurerm.MonitorMetricAlert.IMonitorMetricAlertAction
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_metric_alert#action_group_id MonitorMetricAlert#action_group_id}.</summary>
        [JsiiProperty(name: "actionGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public string ActionGroupId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_metric_alert#webhook_properties MonitorMetricAlert#webhook_properties}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "webhookProperties", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? WebhookProperties
        {
            get;
            set;
        }
    }
}

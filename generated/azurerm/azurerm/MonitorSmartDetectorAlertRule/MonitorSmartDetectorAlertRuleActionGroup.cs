using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MonitorSmartDetectorAlertRule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.monitorSmartDetectorAlertRule.MonitorSmartDetectorAlertRuleActionGroup")]
    public class MonitorSmartDetectorAlertRuleActionGroup : azurerm.MonitorSmartDetectorAlertRule.IMonitorSmartDetectorAlertRuleActionGroup
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_smart_detector_alert_rule#ids MonitorSmartDetectorAlertRule#ids}.</summary>
        [JsiiProperty(name: "ids", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Ids
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_smart_detector_alert_rule#email_subject MonitorSmartDetectorAlertRule#email_subject}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "emailSubject", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EmailSubject
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_smart_detector_alert_rule#webhook_payload MonitorSmartDetectorAlertRule#webhook_payload}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "webhookPayload", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? WebhookPayload
        {
            get;
            set;
        }
    }
}

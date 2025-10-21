using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MonitorScheduledQueryRulesAlert
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.monitorScheduledQueryRulesAlert.MonitorScheduledQueryRulesAlertAction")]
    public class MonitorScheduledQueryRulesAlertAction : azurerm.MonitorScheduledQueryRulesAlert.IMonitorScheduledQueryRulesAlertAction
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_scheduled_query_rules_alert#action_group MonitorScheduledQueryRulesAlert#action_group}.</summary>
        [JsiiProperty(name: "actionGroup", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] ActionGroup
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_scheduled_query_rules_alert#custom_webhook_payload MonitorScheduledQueryRulesAlert#custom_webhook_payload}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "customWebhookPayload", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CustomWebhookPayload
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_scheduled_query_rules_alert#email_subject MonitorScheduledQueryRulesAlert#email_subject}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "emailSubject", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EmailSubject
        {
            get;
            set;
        }
    }
}

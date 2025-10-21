using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MonitorAlertPrometheusRuleGroup
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.monitorAlertPrometheusRuleGroup.MonitorAlertPrometheusRuleGroupRuleAction")]
    public class MonitorAlertPrometheusRuleGroupRuleAction : azurerm.MonitorAlertPrometheusRuleGroup.IMonitorAlertPrometheusRuleGroupRuleAction
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_prometheus_rule_group#action_group_id MonitorAlertPrometheusRuleGroup#action_group_id}.</summary>
        [JsiiProperty(name: "actionGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public string ActionGroupId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_prometheus_rule_group#action_properties MonitorAlertPrometheusRuleGroup#action_properties}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "actionProperties", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? ActionProperties
        {
            get;
            set;
        }
    }
}

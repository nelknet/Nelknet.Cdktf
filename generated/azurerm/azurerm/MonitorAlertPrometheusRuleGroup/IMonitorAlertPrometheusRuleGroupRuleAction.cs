using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MonitorAlertPrometheusRuleGroup
{
    [JsiiInterface(nativeType: typeof(IMonitorAlertPrometheusRuleGroupRuleAction), fullyQualifiedName: "azurerm.monitorAlertPrometheusRuleGroup.MonitorAlertPrometheusRuleGroupRuleAction")]
    public interface IMonitorAlertPrometheusRuleGroupRuleAction
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_prometheus_rule_group#action_group_id MonitorAlertPrometheusRuleGroup#action_group_id}.</summary>
        [JsiiProperty(name: "actionGroupId", typeJson: "{\"primitive\":\"string\"}")]
        string ActionGroupId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_prometheus_rule_group#action_properties MonitorAlertPrometheusRuleGroup#action_properties}.</summary>
        [JsiiProperty(name: "actionProperties", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? ActionProperties
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMonitorAlertPrometheusRuleGroupRuleAction), fullyQualifiedName: "azurerm.monitorAlertPrometheusRuleGroup.MonitorAlertPrometheusRuleGroupRuleAction")]
        internal sealed class _Proxy : DeputyBase, azurerm.MonitorAlertPrometheusRuleGroup.IMonitorAlertPrometheusRuleGroupRuleAction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_prometheus_rule_group#action_group_id MonitorAlertPrometheusRuleGroup#action_group_id}.</summary>
            [JsiiProperty(name: "actionGroupId", typeJson: "{\"primitive\":\"string\"}")]
            public string ActionGroupId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_alert_prometheus_rule_group#action_properties MonitorAlertPrometheusRuleGroup#action_properties}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "actionProperties", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? ActionProperties
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }
        }
    }
}

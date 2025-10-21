using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MonitorScheduledQueryRulesAlert
{
    [JsiiInterface(nativeType: typeof(IMonitorScheduledQueryRulesAlertTrigger), fullyQualifiedName: "azurerm.monitorScheduledQueryRulesAlert.MonitorScheduledQueryRulesAlertTrigger")]
    public interface IMonitorScheduledQueryRulesAlertTrigger
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_scheduled_query_rules_alert#operator MonitorScheduledQueryRulesAlert#operator}.</summary>
        [JsiiProperty(name: "operator", typeJson: "{\"primitive\":\"string\"}")]
        string Operator
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_scheduled_query_rules_alert#threshold MonitorScheduledQueryRulesAlert#threshold}.</summary>
        [JsiiProperty(name: "threshold", typeJson: "{\"primitive\":\"number\"}")]
        double Threshold
        {
            get;
        }

        /// <summary>metric_trigger block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_scheduled_query_rules_alert#metric_trigger MonitorScheduledQueryRulesAlert#metric_trigger}
        /// </remarks>
        [JsiiProperty(name: "metricTrigger", typeJson: "{\"fqn\":\"azurerm.monitorScheduledQueryRulesAlert.MonitorScheduledQueryRulesAlertTriggerMetricTrigger\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.MonitorScheduledQueryRulesAlert.IMonitorScheduledQueryRulesAlertTriggerMetricTrigger? MetricTrigger
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMonitorScheduledQueryRulesAlertTrigger), fullyQualifiedName: "azurerm.monitorScheduledQueryRulesAlert.MonitorScheduledQueryRulesAlertTrigger")]
        internal sealed class _Proxy : DeputyBase, azurerm.MonitorScheduledQueryRulesAlert.IMonitorScheduledQueryRulesAlertTrigger
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_scheduled_query_rules_alert#operator MonitorScheduledQueryRulesAlert#operator}.</summary>
            [JsiiProperty(name: "operator", typeJson: "{\"primitive\":\"string\"}")]
            public string Operator
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_scheduled_query_rules_alert#threshold MonitorScheduledQueryRulesAlert#threshold}.</summary>
            [JsiiProperty(name: "threshold", typeJson: "{\"primitive\":\"number\"}")]
            public double Threshold
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>metric_trigger block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_scheduled_query_rules_alert#metric_trigger MonitorScheduledQueryRulesAlert#metric_trigger}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metricTrigger", typeJson: "{\"fqn\":\"azurerm.monitorScheduledQueryRulesAlert.MonitorScheduledQueryRulesAlertTriggerMetricTrigger\"}", isOptional: true)]
            public azurerm.MonitorScheduledQueryRulesAlert.IMonitorScheduledQueryRulesAlertTriggerMetricTrigger? MetricTrigger
            {
                get => GetInstanceProperty<azurerm.MonitorScheduledQueryRulesAlert.IMonitorScheduledQueryRulesAlertTriggerMetricTrigger?>();
            }
        }
    }
}

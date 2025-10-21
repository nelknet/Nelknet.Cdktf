using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MonitorMetricAlert
{
    [JsiiInterface(nativeType: typeof(IMonitorMetricAlertAction), fullyQualifiedName: "azurerm.monitorMetricAlert.MonitorMetricAlertAction")]
    public interface IMonitorMetricAlertAction
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_metric_alert#action_group_id MonitorMetricAlert#action_group_id}.</summary>
        [JsiiProperty(name: "actionGroupId", typeJson: "{\"primitive\":\"string\"}")]
        string ActionGroupId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_metric_alert#webhook_properties MonitorMetricAlert#webhook_properties}.</summary>
        [JsiiProperty(name: "webhookProperties", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? WebhookProperties
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMonitorMetricAlertAction), fullyQualifiedName: "azurerm.monitorMetricAlert.MonitorMetricAlertAction")]
        internal sealed class _Proxy : DeputyBase, azurerm.MonitorMetricAlert.IMonitorMetricAlertAction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_metric_alert#action_group_id MonitorMetricAlert#action_group_id}.</summary>
            [JsiiProperty(name: "actionGroupId", typeJson: "{\"primitive\":\"string\"}")]
            public string ActionGroupId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_metric_alert#webhook_properties MonitorMetricAlert#webhook_properties}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "webhookProperties", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? WebhookProperties
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }
        }
    }
}

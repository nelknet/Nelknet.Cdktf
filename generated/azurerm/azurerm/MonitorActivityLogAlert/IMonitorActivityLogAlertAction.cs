using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MonitorActivityLogAlert
{
    [JsiiInterface(nativeType: typeof(IMonitorActivityLogAlertAction), fullyQualifiedName: "azurerm.monitorActivityLogAlert.MonitorActivityLogAlertAction")]
    public interface IMonitorActivityLogAlertAction
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_activity_log_alert#action_group_id MonitorActivityLogAlert#action_group_id}.</summary>
        [JsiiProperty(name: "actionGroupId", typeJson: "{\"primitive\":\"string\"}")]
        string ActionGroupId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_activity_log_alert#webhook_properties MonitorActivityLogAlert#webhook_properties}.</summary>
        [JsiiProperty(name: "webhookProperties", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? WebhookProperties
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMonitorActivityLogAlertAction), fullyQualifiedName: "azurerm.monitorActivityLogAlert.MonitorActivityLogAlertAction")]
        internal sealed class _Proxy : DeputyBase, azurerm.MonitorActivityLogAlert.IMonitorActivityLogAlertAction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_activity_log_alert#action_group_id MonitorActivityLogAlert#action_group_id}.</summary>
            [JsiiProperty(name: "actionGroupId", typeJson: "{\"primitive\":\"string\"}")]
            public string ActionGroupId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_activity_log_alert#webhook_properties MonitorActivityLogAlert#webhook_properties}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "webhookProperties", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? WebhookProperties
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MonitorAutoscaleSetting
{
    [JsiiInterface(nativeType: typeof(IMonitorAutoscaleSettingNotification), fullyQualifiedName: "azurerm.monitorAutoscaleSetting.MonitorAutoscaleSettingNotification")]
    public interface IMonitorAutoscaleSettingNotification
    {
        /// <summary>email block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_autoscale_setting#email MonitorAutoscaleSetting#email}
        /// </remarks>
        [JsiiProperty(name: "email", typeJson: "{\"fqn\":\"azurerm.monitorAutoscaleSetting.MonitorAutoscaleSettingNotificationEmail\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.MonitorAutoscaleSetting.IMonitorAutoscaleSettingNotificationEmail? Email
        {
            get
            {
                return null;
            }
        }

        /// <summary>webhook block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_autoscale_setting#webhook MonitorAutoscaleSetting#webhook}
        /// </remarks>
        [JsiiProperty(name: "webhook", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorAutoscaleSetting.MonitorAutoscaleSettingNotificationWebhook\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Webhook
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMonitorAutoscaleSettingNotification), fullyQualifiedName: "azurerm.monitorAutoscaleSetting.MonitorAutoscaleSettingNotification")]
        internal sealed class _Proxy : DeputyBase, azurerm.MonitorAutoscaleSetting.IMonitorAutoscaleSettingNotification
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>email block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_autoscale_setting#email MonitorAutoscaleSetting#email}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "email", typeJson: "{\"fqn\":\"azurerm.monitorAutoscaleSetting.MonitorAutoscaleSettingNotificationEmail\"}", isOptional: true)]
            public azurerm.MonitorAutoscaleSetting.IMonitorAutoscaleSettingNotificationEmail? Email
            {
                get => GetInstanceProperty<azurerm.MonitorAutoscaleSetting.IMonitorAutoscaleSettingNotificationEmail?>();
            }

            /// <summary>webhook block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_autoscale_setting#webhook MonitorAutoscaleSetting#webhook}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "webhook", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorAutoscaleSetting.MonitorAutoscaleSettingNotificationWebhook\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Webhook
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}

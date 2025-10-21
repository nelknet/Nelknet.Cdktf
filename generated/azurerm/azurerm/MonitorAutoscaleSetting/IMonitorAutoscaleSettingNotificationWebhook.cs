using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MonitorAutoscaleSetting
{
    [JsiiInterface(nativeType: typeof(IMonitorAutoscaleSettingNotificationWebhook), fullyQualifiedName: "azurerm.monitorAutoscaleSetting.MonitorAutoscaleSettingNotificationWebhook")]
    public interface IMonitorAutoscaleSettingNotificationWebhook
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_autoscale_setting#service_uri MonitorAutoscaleSetting#service_uri}.</summary>
        [JsiiProperty(name: "serviceUri", typeJson: "{\"primitive\":\"string\"}")]
        string ServiceUri
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_autoscale_setting#properties MonitorAutoscaleSetting#properties}.</summary>
        [JsiiProperty(name: "properties", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Properties
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMonitorAutoscaleSettingNotificationWebhook), fullyQualifiedName: "azurerm.monitorAutoscaleSetting.MonitorAutoscaleSettingNotificationWebhook")]
        internal sealed class _Proxy : DeputyBase, azurerm.MonitorAutoscaleSetting.IMonitorAutoscaleSettingNotificationWebhook
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_autoscale_setting#service_uri MonitorAutoscaleSetting#service_uri}.</summary>
            [JsiiProperty(name: "serviceUri", typeJson: "{\"primitive\":\"string\"}")]
            public string ServiceUri
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_autoscale_setting#properties MonitorAutoscaleSetting#properties}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "properties", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Properties
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }
        }
    }
}

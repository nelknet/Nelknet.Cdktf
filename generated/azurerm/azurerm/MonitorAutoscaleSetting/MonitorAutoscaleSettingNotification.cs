using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MonitorAutoscaleSetting
{
    [JsiiByValue(fqn: "azurerm.monitorAutoscaleSetting.MonitorAutoscaleSettingNotification")]
    public class MonitorAutoscaleSettingNotification : azurerm.MonitorAutoscaleSetting.IMonitorAutoscaleSettingNotification
    {
        /// <summary>email block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_autoscale_setting#email MonitorAutoscaleSetting#email}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "email", typeJson: "{\"fqn\":\"azurerm.monitorAutoscaleSetting.MonitorAutoscaleSettingNotificationEmail\"}", isOptional: true)]
        public azurerm.MonitorAutoscaleSetting.IMonitorAutoscaleSettingNotificationEmail? Email
        {
            get;
            set;
        }

        private object? _webhook;

        /// <summary>webhook block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_autoscale_setting#webhook MonitorAutoscaleSetting#webhook}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "webhook", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorAutoscaleSetting.MonitorAutoscaleSettingNotificationWebhook\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Webhook
        {
            get => _webhook;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.MonitorAutoscaleSetting.IMonitorAutoscaleSettingNotificationWebhook[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.MonitorAutoscaleSetting.IMonitorAutoscaleSettingNotificationWebhook).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _webhook = value;
            }
        }
    }
}

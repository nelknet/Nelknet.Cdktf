using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MonitorAutoscaleSetting
{
    [JsiiInterface(nativeType: typeof(IMonitorAutoscaleSettingPredictive), fullyQualifiedName: "azurerm.monitorAutoscaleSetting.MonitorAutoscaleSettingPredictive")]
    public interface IMonitorAutoscaleSettingPredictive
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_autoscale_setting#scale_mode MonitorAutoscaleSetting#scale_mode}.</summary>
        [JsiiProperty(name: "scaleMode", typeJson: "{\"primitive\":\"string\"}")]
        string ScaleMode
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_autoscale_setting#look_ahead_time MonitorAutoscaleSetting#look_ahead_time}.</summary>
        [JsiiProperty(name: "lookAheadTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LookAheadTime
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMonitorAutoscaleSettingPredictive), fullyQualifiedName: "azurerm.monitorAutoscaleSetting.MonitorAutoscaleSettingPredictive")]
        internal sealed class _Proxy : DeputyBase, azurerm.MonitorAutoscaleSetting.IMonitorAutoscaleSettingPredictive
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_autoscale_setting#scale_mode MonitorAutoscaleSetting#scale_mode}.</summary>
            [JsiiProperty(name: "scaleMode", typeJson: "{\"primitive\":\"string\"}")]
            public string ScaleMode
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_autoscale_setting#look_ahead_time MonitorAutoscaleSetting#look_ahead_time}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "lookAheadTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LookAheadTime
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

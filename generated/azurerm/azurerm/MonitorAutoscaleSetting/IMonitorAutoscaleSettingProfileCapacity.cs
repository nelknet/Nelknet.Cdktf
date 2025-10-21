using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MonitorAutoscaleSetting
{
    [JsiiInterface(nativeType: typeof(IMonitorAutoscaleSettingProfileCapacity), fullyQualifiedName: "azurerm.monitorAutoscaleSetting.MonitorAutoscaleSettingProfileCapacity")]
    public interface IMonitorAutoscaleSettingProfileCapacity
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_autoscale_setting#default MonitorAutoscaleSetting#default}.</summary>
        [JsiiProperty(name: "default", typeJson: "{\"primitive\":\"number\"}")]
        double Default
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_autoscale_setting#maximum MonitorAutoscaleSetting#maximum}.</summary>
        [JsiiProperty(name: "maximum", typeJson: "{\"primitive\":\"number\"}")]
        double Maximum
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_autoscale_setting#minimum MonitorAutoscaleSetting#minimum}.</summary>
        [JsiiProperty(name: "minimum", typeJson: "{\"primitive\":\"number\"}")]
        double Minimum
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMonitorAutoscaleSettingProfileCapacity), fullyQualifiedName: "azurerm.monitorAutoscaleSetting.MonitorAutoscaleSettingProfileCapacity")]
        internal sealed class _Proxy : DeputyBase, azurerm.MonitorAutoscaleSetting.IMonitorAutoscaleSettingProfileCapacity
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_autoscale_setting#default MonitorAutoscaleSetting#default}.</summary>
            [JsiiProperty(name: "default", typeJson: "{\"primitive\":\"number\"}")]
            public double Default
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_autoscale_setting#maximum MonitorAutoscaleSetting#maximum}.</summary>
            [JsiiProperty(name: "maximum", typeJson: "{\"primitive\":\"number\"}")]
            public double Maximum
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_autoscale_setting#minimum MonitorAutoscaleSetting#minimum}.</summary>
            [JsiiProperty(name: "minimum", typeJson: "{\"primitive\":\"number\"}")]
            public double Minimum
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MonitorAutoscaleSetting
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.monitorAutoscaleSetting.MonitorAutoscaleSettingProfile")]
    public class MonitorAutoscaleSettingProfile : azurerm.MonitorAutoscaleSetting.IMonitorAutoscaleSettingProfile
    {
        /// <summary>capacity block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_autoscale_setting#capacity MonitorAutoscaleSetting#capacity}
        /// </remarks>
        [JsiiProperty(name: "capacity", typeJson: "{\"fqn\":\"azurerm.monitorAutoscaleSetting.MonitorAutoscaleSettingProfileCapacity\"}")]
        public azurerm.MonitorAutoscaleSetting.IMonitorAutoscaleSettingProfileCapacity Capacity
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_autoscale_setting#name MonitorAutoscaleSetting#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>fixed_date block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_autoscale_setting#fixed_date MonitorAutoscaleSetting#fixed_date}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fixedDate", typeJson: "{\"fqn\":\"azurerm.monitorAutoscaleSetting.MonitorAutoscaleSettingProfileFixedDate\"}", isOptional: true)]
        public azurerm.MonitorAutoscaleSetting.IMonitorAutoscaleSettingProfileFixedDate? FixedDate
        {
            get;
            set;
        }

        /// <summary>recurrence block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_autoscale_setting#recurrence MonitorAutoscaleSetting#recurrence}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "recurrence", typeJson: "{\"fqn\":\"azurerm.monitorAutoscaleSetting.MonitorAutoscaleSettingProfileRecurrence\"}", isOptional: true)]
        public azurerm.MonitorAutoscaleSetting.IMonitorAutoscaleSettingProfileRecurrence? Recurrence
        {
            get;
            set;
        }

        private object? _rule;

        /// <summary>rule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_autoscale_setting#rule MonitorAutoscaleSetting#rule}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "rule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorAutoscaleSetting.MonitorAutoscaleSettingProfileRule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Rule
        {
            get => _rule;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.MonitorAutoscaleSetting.IMonitorAutoscaleSettingProfileRule[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.MonitorAutoscaleSetting.IMonitorAutoscaleSettingProfileRule).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _rule = value;
            }
        }
    }
}

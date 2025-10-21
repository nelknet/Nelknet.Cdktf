using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VirtualDesktopScalingPlan
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.virtualDesktopScalingPlan.VirtualDesktopScalingPlanSchedule")]
    public class VirtualDesktopScalingPlanSchedule : azurerm.VirtualDesktopScalingPlan.IVirtualDesktopScalingPlanSchedule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_scaling_plan#days_of_week VirtualDesktopScalingPlan#days_of_week}.</summary>
        [JsiiProperty(name: "daysOfWeek", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] DaysOfWeek
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_scaling_plan#name VirtualDesktopScalingPlan#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_scaling_plan#off_peak_load_balancing_algorithm VirtualDesktopScalingPlan#off_peak_load_balancing_algorithm}.</summary>
        [JsiiProperty(name: "offPeakLoadBalancingAlgorithm", typeJson: "{\"primitive\":\"string\"}")]
        public string OffPeakLoadBalancingAlgorithm
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_scaling_plan#off_peak_start_time VirtualDesktopScalingPlan#off_peak_start_time}.</summary>
        [JsiiProperty(name: "offPeakStartTime", typeJson: "{\"primitive\":\"string\"}")]
        public string OffPeakStartTime
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_scaling_plan#peak_load_balancing_algorithm VirtualDesktopScalingPlan#peak_load_balancing_algorithm}.</summary>
        [JsiiProperty(name: "peakLoadBalancingAlgorithm", typeJson: "{\"primitive\":\"string\"}")]
        public string PeakLoadBalancingAlgorithm
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_scaling_plan#peak_start_time VirtualDesktopScalingPlan#peak_start_time}.</summary>
        [JsiiProperty(name: "peakStartTime", typeJson: "{\"primitive\":\"string\"}")]
        public string PeakStartTime
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_scaling_plan#ramp_down_capacity_threshold_percent VirtualDesktopScalingPlan#ramp_down_capacity_threshold_percent}.</summary>
        [JsiiProperty(name: "rampDownCapacityThresholdPercent", typeJson: "{\"primitive\":\"number\"}")]
        public double RampDownCapacityThresholdPercent
        {
            get;
            set;
        }

        private object _rampDownForceLogoffUsers;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_scaling_plan#ramp_down_force_logoff_users VirtualDesktopScalingPlan#ramp_down_force_logoff_users}.</summary>
        [JsiiProperty(name: "rampDownForceLogoffUsers", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public object RampDownForceLogoffUsers
        {
            get => _rampDownForceLogoffUsers;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _rampDownForceLogoffUsers = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_scaling_plan#ramp_down_load_balancing_algorithm VirtualDesktopScalingPlan#ramp_down_load_balancing_algorithm}.</summary>
        [JsiiProperty(name: "rampDownLoadBalancingAlgorithm", typeJson: "{\"primitive\":\"string\"}")]
        public string RampDownLoadBalancingAlgorithm
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_scaling_plan#ramp_down_minimum_hosts_percent VirtualDesktopScalingPlan#ramp_down_minimum_hosts_percent}.</summary>
        [JsiiProperty(name: "rampDownMinimumHostsPercent", typeJson: "{\"primitive\":\"number\"}")]
        public double RampDownMinimumHostsPercent
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_scaling_plan#ramp_down_notification_message VirtualDesktopScalingPlan#ramp_down_notification_message}.</summary>
        [JsiiProperty(name: "rampDownNotificationMessage", typeJson: "{\"primitive\":\"string\"}")]
        public string RampDownNotificationMessage
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_scaling_plan#ramp_down_start_time VirtualDesktopScalingPlan#ramp_down_start_time}.</summary>
        [JsiiProperty(name: "rampDownStartTime", typeJson: "{\"primitive\":\"string\"}")]
        public string RampDownStartTime
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_scaling_plan#ramp_down_stop_hosts_when VirtualDesktopScalingPlan#ramp_down_stop_hosts_when}.</summary>
        [JsiiProperty(name: "rampDownStopHostsWhen", typeJson: "{\"primitive\":\"string\"}")]
        public string RampDownStopHostsWhen
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_scaling_plan#ramp_down_wait_time_minutes VirtualDesktopScalingPlan#ramp_down_wait_time_minutes}.</summary>
        [JsiiProperty(name: "rampDownWaitTimeMinutes", typeJson: "{\"primitive\":\"number\"}")]
        public double RampDownWaitTimeMinutes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_scaling_plan#ramp_up_load_balancing_algorithm VirtualDesktopScalingPlan#ramp_up_load_balancing_algorithm}.</summary>
        [JsiiProperty(name: "rampUpLoadBalancingAlgorithm", typeJson: "{\"primitive\":\"string\"}")]
        public string RampUpLoadBalancingAlgorithm
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_scaling_plan#ramp_up_start_time VirtualDesktopScalingPlan#ramp_up_start_time}.</summary>
        [JsiiProperty(name: "rampUpStartTime", typeJson: "{\"primitive\":\"string\"}")]
        public string RampUpStartTime
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_scaling_plan#ramp_up_capacity_threshold_percent VirtualDesktopScalingPlan#ramp_up_capacity_threshold_percent}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "rampUpCapacityThresholdPercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? RampUpCapacityThresholdPercent
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_scaling_plan#ramp_up_minimum_hosts_percent VirtualDesktopScalingPlan#ramp_up_minimum_hosts_percent}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "rampUpMinimumHostsPercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? RampUpMinimumHostsPercent
        {
            get;
            set;
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VirtualDesktopScalingPlan
{
    [JsiiInterface(nativeType: typeof(IVirtualDesktopScalingPlanSchedule), fullyQualifiedName: "azurerm.virtualDesktopScalingPlan.VirtualDesktopScalingPlanSchedule")]
    public interface IVirtualDesktopScalingPlanSchedule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_scaling_plan#days_of_week VirtualDesktopScalingPlan#days_of_week}.</summary>
        [JsiiProperty(name: "daysOfWeek", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] DaysOfWeek
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_scaling_plan#name VirtualDesktopScalingPlan#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_scaling_plan#off_peak_load_balancing_algorithm VirtualDesktopScalingPlan#off_peak_load_balancing_algorithm}.</summary>
        [JsiiProperty(name: "offPeakLoadBalancingAlgorithm", typeJson: "{\"primitive\":\"string\"}")]
        string OffPeakLoadBalancingAlgorithm
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_scaling_plan#off_peak_start_time VirtualDesktopScalingPlan#off_peak_start_time}.</summary>
        [JsiiProperty(name: "offPeakStartTime", typeJson: "{\"primitive\":\"string\"}")]
        string OffPeakStartTime
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_scaling_plan#peak_load_balancing_algorithm VirtualDesktopScalingPlan#peak_load_balancing_algorithm}.</summary>
        [JsiiProperty(name: "peakLoadBalancingAlgorithm", typeJson: "{\"primitive\":\"string\"}")]
        string PeakLoadBalancingAlgorithm
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_scaling_plan#peak_start_time VirtualDesktopScalingPlan#peak_start_time}.</summary>
        [JsiiProperty(name: "peakStartTime", typeJson: "{\"primitive\":\"string\"}")]
        string PeakStartTime
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_scaling_plan#ramp_down_capacity_threshold_percent VirtualDesktopScalingPlan#ramp_down_capacity_threshold_percent}.</summary>
        [JsiiProperty(name: "rampDownCapacityThresholdPercent", typeJson: "{\"primitive\":\"number\"}")]
        double RampDownCapacityThresholdPercent
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_scaling_plan#ramp_down_force_logoff_users VirtualDesktopScalingPlan#ramp_down_force_logoff_users}.</summary>
        [JsiiProperty(name: "rampDownForceLogoffUsers", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        object RampDownForceLogoffUsers
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_scaling_plan#ramp_down_load_balancing_algorithm VirtualDesktopScalingPlan#ramp_down_load_balancing_algorithm}.</summary>
        [JsiiProperty(name: "rampDownLoadBalancingAlgorithm", typeJson: "{\"primitive\":\"string\"}")]
        string RampDownLoadBalancingAlgorithm
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_scaling_plan#ramp_down_minimum_hosts_percent VirtualDesktopScalingPlan#ramp_down_minimum_hosts_percent}.</summary>
        [JsiiProperty(name: "rampDownMinimumHostsPercent", typeJson: "{\"primitive\":\"number\"}")]
        double RampDownMinimumHostsPercent
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_scaling_plan#ramp_down_notification_message VirtualDesktopScalingPlan#ramp_down_notification_message}.</summary>
        [JsiiProperty(name: "rampDownNotificationMessage", typeJson: "{\"primitive\":\"string\"}")]
        string RampDownNotificationMessage
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_scaling_plan#ramp_down_start_time VirtualDesktopScalingPlan#ramp_down_start_time}.</summary>
        [JsiiProperty(name: "rampDownStartTime", typeJson: "{\"primitive\":\"string\"}")]
        string RampDownStartTime
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_scaling_plan#ramp_down_stop_hosts_when VirtualDesktopScalingPlan#ramp_down_stop_hosts_when}.</summary>
        [JsiiProperty(name: "rampDownStopHostsWhen", typeJson: "{\"primitive\":\"string\"}")]
        string RampDownStopHostsWhen
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_scaling_plan#ramp_down_wait_time_minutes VirtualDesktopScalingPlan#ramp_down_wait_time_minutes}.</summary>
        [JsiiProperty(name: "rampDownWaitTimeMinutes", typeJson: "{\"primitive\":\"number\"}")]
        double RampDownWaitTimeMinutes
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_scaling_plan#ramp_up_load_balancing_algorithm VirtualDesktopScalingPlan#ramp_up_load_balancing_algorithm}.</summary>
        [JsiiProperty(name: "rampUpLoadBalancingAlgorithm", typeJson: "{\"primitive\":\"string\"}")]
        string RampUpLoadBalancingAlgorithm
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_scaling_plan#ramp_up_start_time VirtualDesktopScalingPlan#ramp_up_start_time}.</summary>
        [JsiiProperty(name: "rampUpStartTime", typeJson: "{\"primitive\":\"string\"}")]
        string RampUpStartTime
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_scaling_plan#ramp_up_capacity_threshold_percent VirtualDesktopScalingPlan#ramp_up_capacity_threshold_percent}.</summary>
        [JsiiProperty(name: "rampUpCapacityThresholdPercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? RampUpCapacityThresholdPercent
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_scaling_plan#ramp_up_minimum_hosts_percent VirtualDesktopScalingPlan#ramp_up_minimum_hosts_percent}.</summary>
        [JsiiProperty(name: "rampUpMinimumHostsPercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? RampUpMinimumHostsPercent
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IVirtualDesktopScalingPlanSchedule), fullyQualifiedName: "azurerm.virtualDesktopScalingPlan.VirtualDesktopScalingPlanSchedule")]
        internal sealed class _Proxy : DeputyBase, azurerm.VirtualDesktopScalingPlan.IVirtualDesktopScalingPlanSchedule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_scaling_plan#days_of_week VirtualDesktopScalingPlan#days_of_week}.</summary>
            [JsiiProperty(name: "daysOfWeek", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] DaysOfWeek
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_scaling_plan#name VirtualDesktopScalingPlan#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_scaling_plan#off_peak_load_balancing_algorithm VirtualDesktopScalingPlan#off_peak_load_balancing_algorithm}.</summary>
            [JsiiProperty(name: "offPeakLoadBalancingAlgorithm", typeJson: "{\"primitive\":\"string\"}")]
            public string OffPeakLoadBalancingAlgorithm
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_scaling_plan#off_peak_start_time VirtualDesktopScalingPlan#off_peak_start_time}.</summary>
            [JsiiProperty(name: "offPeakStartTime", typeJson: "{\"primitive\":\"string\"}")]
            public string OffPeakStartTime
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_scaling_plan#peak_load_balancing_algorithm VirtualDesktopScalingPlan#peak_load_balancing_algorithm}.</summary>
            [JsiiProperty(name: "peakLoadBalancingAlgorithm", typeJson: "{\"primitive\":\"string\"}")]
            public string PeakLoadBalancingAlgorithm
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_scaling_plan#peak_start_time VirtualDesktopScalingPlan#peak_start_time}.</summary>
            [JsiiProperty(name: "peakStartTime", typeJson: "{\"primitive\":\"string\"}")]
            public string PeakStartTime
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_scaling_plan#ramp_down_capacity_threshold_percent VirtualDesktopScalingPlan#ramp_down_capacity_threshold_percent}.</summary>
            [JsiiProperty(name: "rampDownCapacityThresholdPercent", typeJson: "{\"primitive\":\"number\"}")]
            public double RampDownCapacityThresholdPercent
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_scaling_plan#ramp_down_force_logoff_users VirtualDesktopScalingPlan#ramp_down_force_logoff_users}.</summary>
            [JsiiProperty(name: "rampDownForceLogoffUsers", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
            public object RampDownForceLogoffUsers
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_scaling_plan#ramp_down_load_balancing_algorithm VirtualDesktopScalingPlan#ramp_down_load_balancing_algorithm}.</summary>
            [JsiiProperty(name: "rampDownLoadBalancingAlgorithm", typeJson: "{\"primitive\":\"string\"}")]
            public string RampDownLoadBalancingAlgorithm
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_scaling_plan#ramp_down_minimum_hosts_percent VirtualDesktopScalingPlan#ramp_down_minimum_hosts_percent}.</summary>
            [JsiiProperty(name: "rampDownMinimumHostsPercent", typeJson: "{\"primitive\":\"number\"}")]
            public double RampDownMinimumHostsPercent
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_scaling_plan#ramp_down_notification_message VirtualDesktopScalingPlan#ramp_down_notification_message}.</summary>
            [JsiiProperty(name: "rampDownNotificationMessage", typeJson: "{\"primitive\":\"string\"}")]
            public string RampDownNotificationMessage
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_scaling_plan#ramp_down_start_time VirtualDesktopScalingPlan#ramp_down_start_time}.</summary>
            [JsiiProperty(name: "rampDownStartTime", typeJson: "{\"primitive\":\"string\"}")]
            public string RampDownStartTime
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_scaling_plan#ramp_down_stop_hosts_when VirtualDesktopScalingPlan#ramp_down_stop_hosts_when}.</summary>
            [JsiiProperty(name: "rampDownStopHostsWhen", typeJson: "{\"primitive\":\"string\"}")]
            public string RampDownStopHostsWhen
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_scaling_plan#ramp_down_wait_time_minutes VirtualDesktopScalingPlan#ramp_down_wait_time_minutes}.</summary>
            [JsiiProperty(name: "rampDownWaitTimeMinutes", typeJson: "{\"primitive\":\"number\"}")]
            public double RampDownWaitTimeMinutes
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_scaling_plan#ramp_up_load_balancing_algorithm VirtualDesktopScalingPlan#ramp_up_load_balancing_algorithm}.</summary>
            [JsiiProperty(name: "rampUpLoadBalancingAlgorithm", typeJson: "{\"primitive\":\"string\"}")]
            public string RampUpLoadBalancingAlgorithm
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_scaling_plan#ramp_up_start_time VirtualDesktopScalingPlan#ramp_up_start_time}.</summary>
            [JsiiProperty(name: "rampUpStartTime", typeJson: "{\"primitive\":\"string\"}")]
            public string RampUpStartTime
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_scaling_plan#ramp_up_capacity_threshold_percent VirtualDesktopScalingPlan#ramp_up_capacity_threshold_percent}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "rampUpCapacityThresholdPercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? RampUpCapacityThresholdPercent
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_scaling_plan#ramp_up_minimum_hosts_percent VirtualDesktopScalingPlan#ramp_up_minimum_hosts_percent}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "rampUpMinimumHostsPercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? RampUpMinimumHostsPercent
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}

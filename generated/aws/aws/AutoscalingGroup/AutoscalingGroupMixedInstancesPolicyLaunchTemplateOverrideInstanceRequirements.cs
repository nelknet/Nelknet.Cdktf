using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AutoscalingGroup
{
    [JsiiByValue(fqn: "aws.autoscalingGroup.AutoscalingGroupMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirements")]
    public class AutoscalingGroupMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirements : aws.AutoscalingGroup.IAutoscalingGroupMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirements
    {
        /// <summary>accelerator_count block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#accelerator_count AutoscalingGroup#accelerator_count}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "acceleratorCount", typeJson: "{\"fqn\":\"aws.autoscalingGroup.AutoscalingGroupMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsAcceleratorCount\"}", isOptional: true)]
        public aws.AutoscalingGroup.IAutoscalingGroupMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsAcceleratorCount? AcceleratorCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#accelerator_manufacturers AutoscalingGroup#accelerator_manufacturers}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "acceleratorManufacturers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AcceleratorManufacturers
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#accelerator_names AutoscalingGroup#accelerator_names}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "acceleratorNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AcceleratorNames
        {
            get;
            set;
        }

        /// <summary>accelerator_total_memory_mib block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#accelerator_total_memory_mib AutoscalingGroup#accelerator_total_memory_mib}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "acceleratorTotalMemoryMib", typeJson: "{\"fqn\":\"aws.autoscalingGroup.AutoscalingGroupMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsAcceleratorTotalMemoryMib\"}", isOptional: true)]
        public aws.AutoscalingGroup.IAutoscalingGroupMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsAcceleratorTotalMemoryMib? AcceleratorTotalMemoryMib
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#accelerator_types AutoscalingGroup#accelerator_types}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "acceleratorTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AcceleratorTypes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#allowed_instance_types AutoscalingGroup#allowed_instance_types}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "allowedInstanceTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AllowedInstanceTypes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#bare_metal AutoscalingGroup#bare_metal}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bareMetal", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BareMetal
        {
            get;
            set;
        }

        /// <summary>baseline_ebs_bandwidth_mbps block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#baseline_ebs_bandwidth_mbps AutoscalingGroup#baseline_ebs_bandwidth_mbps}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "baselineEbsBandwidthMbps", typeJson: "{\"fqn\":\"aws.autoscalingGroup.AutoscalingGroupMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsBaselineEbsBandwidthMbps\"}", isOptional: true)]
        public aws.AutoscalingGroup.IAutoscalingGroupMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsBaselineEbsBandwidthMbps? BaselineEbsBandwidthMbps
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#burstable_performance AutoscalingGroup#burstable_performance}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "burstablePerformance", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BurstablePerformance
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#cpu_manufacturers AutoscalingGroup#cpu_manufacturers}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cpuManufacturers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? CpuManufacturers
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#excluded_instance_types AutoscalingGroup#excluded_instance_types}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "excludedInstanceTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ExcludedInstanceTypes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#instance_generations AutoscalingGroup#instance_generations}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "instanceGenerations", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? InstanceGenerations
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#local_storage AutoscalingGroup#local_storage}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "localStorage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LocalStorage
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#local_storage_types AutoscalingGroup#local_storage_types}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "localStorageTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? LocalStorageTypes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#max_spot_price_as_percentage_of_optimal_on_demand_price AutoscalingGroup#max_spot_price_as_percentage_of_optimal_on_demand_price}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxSpotPriceAsPercentageOfOptimalOnDemandPrice", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxSpotPriceAsPercentageOfOptimalOnDemandPrice
        {
            get;
            set;
        }

        /// <summary>memory_gib_per_vcpu block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#memory_gib_per_vcpu AutoscalingGroup#memory_gib_per_vcpu}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "memoryGibPerVcpu", typeJson: "{\"fqn\":\"aws.autoscalingGroup.AutoscalingGroupMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsMemoryGibPerVcpu\"}", isOptional: true)]
        public aws.AutoscalingGroup.IAutoscalingGroupMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsMemoryGibPerVcpu? MemoryGibPerVcpu
        {
            get;
            set;
        }

        /// <summary>memory_mib block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#memory_mib AutoscalingGroup#memory_mib}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "memoryMib", typeJson: "{\"fqn\":\"aws.autoscalingGroup.AutoscalingGroupMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsMemoryMib\"}", isOptional: true)]
        public aws.AutoscalingGroup.IAutoscalingGroupMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsMemoryMib? MemoryMib
        {
            get;
            set;
        }

        /// <summary>network_bandwidth_gbps block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#network_bandwidth_gbps AutoscalingGroup#network_bandwidth_gbps}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "networkBandwidthGbps", typeJson: "{\"fqn\":\"aws.autoscalingGroup.AutoscalingGroupMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsNetworkBandwidthGbps\"}", isOptional: true)]
        public aws.AutoscalingGroup.IAutoscalingGroupMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsNetworkBandwidthGbps? NetworkBandwidthGbps
        {
            get;
            set;
        }

        /// <summary>network_interface_count block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#network_interface_count AutoscalingGroup#network_interface_count}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "networkInterfaceCount", typeJson: "{\"fqn\":\"aws.autoscalingGroup.AutoscalingGroupMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsNetworkInterfaceCount\"}", isOptional: true)]
        public aws.AutoscalingGroup.IAutoscalingGroupMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsNetworkInterfaceCount? NetworkInterfaceCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#on_demand_max_price_percentage_over_lowest_price AutoscalingGroup#on_demand_max_price_percentage_over_lowest_price}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "onDemandMaxPricePercentageOverLowestPrice", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? OnDemandMaxPricePercentageOverLowestPrice
        {
            get;
            set;
        }

        private object? _requireHibernateSupport;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#require_hibernate_support AutoscalingGroup#require_hibernate_support}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "requireHibernateSupport", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? RequireHibernateSupport
        {
            get => _requireHibernateSupport;
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
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _requireHibernateSupport = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#spot_max_price_percentage_over_lowest_price AutoscalingGroup#spot_max_price_percentage_over_lowest_price}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "spotMaxPricePercentageOverLowestPrice", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? SpotMaxPricePercentageOverLowestPrice
        {
            get;
            set;
        }

        /// <summary>total_local_storage_gb block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#total_local_storage_gb AutoscalingGroup#total_local_storage_gb}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "totalLocalStorageGb", typeJson: "{\"fqn\":\"aws.autoscalingGroup.AutoscalingGroupMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsTotalLocalStorageGb\"}", isOptional: true)]
        public aws.AutoscalingGroup.IAutoscalingGroupMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsTotalLocalStorageGb? TotalLocalStorageGb
        {
            get;
            set;
        }

        /// <summary>vcpu_count block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#vcpu_count AutoscalingGroup#vcpu_count}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vcpuCount", typeJson: "{\"fqn\":\"aws.autoscalingGroup.AutoscalingGroupMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsVcpuCount\"}", isOptional: true)]
        public aws.AutoscalingGroup.IAutoscalingGroupMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsVcpuCount? VcpuCount
        {
            get;
            set;
        }
    }
}

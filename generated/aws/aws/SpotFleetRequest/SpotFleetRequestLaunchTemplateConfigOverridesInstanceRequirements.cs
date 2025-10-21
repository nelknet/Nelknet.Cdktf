using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SpotFleetRequest
{
    [JsiiByValue(fqn: "aws.spotFleetRequest.SpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirements")]
    public class SpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirements : aws.SpotFleetRequest.ISpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirements
    {
        /// <summary>accelerator_count block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#accelerator_count SpotFleetRequest#accelerator_count}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "acceleratorCount", typeJson: "{\"fqn\":\"aws.spotFleetRequest.SpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsAcceleratorCount\"}", isOptional: true)]
        public aws.SpotFleetRequest.ISpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsAcceleratorCount? AcceleratorCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#accelerator_manufacturers SpotFleetRequest#accelerator_manufacturers}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "acceleratorManufacturers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AcceleratorManufacturers
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#accelerator_names SpotFleetRequest#accelerator_names}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "acceleratorNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AcceleratorNames
        {
            get;
            set;
        }

        /// <summary>accelerator_total_memory_mib block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#accelerator_total_memory_mib SpotFleetRequest#accelerator_total_memory_mib}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "acceleratorTotalMemoryMib", typeJson: "{\"fqn\":\"aws.spotFleetRequest.SpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsAcceleratorTotalMemoryMib\"}", isOptional: true)]
        public aws.SpotFleetRequest.ISpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsAcceleratorTotalMemoryMib? AcceleratorTotalMemoryMib
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#accelerator_types SpotFleetRequest#accelerator_types}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "acceleratorTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AcceleratorTypes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#allowed_instance_types SpotFleetRequest#allowed_instance_types}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "allowedInstanceTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AllowedInstanceTypes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#bare_metal SpotFleetRequest#bare_metal}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bareMetal", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BareMetal
        {
            get;
            set;
        }

        /// <summary>baseline_ebs_bandwidth_mbps block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#baseline_ebs_bandwidth_mbps SpotFleetRequest#baseline_ebs_bandwidth_mbps}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "baselineEbsBandwidthMbps", typeJson: "{\"fqn\":\"aws.spotFleetRequest.SpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsBaselineEbsBandwidthMbps\"}", isOptional: true)]
        public aws.SpotFleetRequest.ISpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsBaselineEbsBandwidthMbps? BaselineEbsBandwidthMbps
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#burstable_performance SpotFleetRequest#burstable_performance}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "burstablePerformance", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BurstablePerformance
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#cpu_manufacturers SpotFleetRequest#cpu_manufacturers}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cpuManufacturers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? CpuManufacturers
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#excluded_instance_types SpotFleetRequest#excluded_instance_types}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "excludedInstanceTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ExcludedInstanceTypes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#instance_generations SpotFleetRequest#instance_generations}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "instanceGenerations", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? InstanceGenerations
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#local_storage SpotFleetRequest#local_storage}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "localStorage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LocalStorage
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#local_storage_types SpotFleetRequest#local_storage_types}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "localStorageTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? LocalStorageTypes
        {
            get;
            set;
        }

        /// <summary>memory_gib_per_vcpu block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#memory_gib_per_vcpu SpotFleetRequest#memory_gib_per_vcpu}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "memoryGibPerVcpu", typeJson: "{\"fqn\":\"aws.spotFleetRequest.SpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsMemoryGibPerVcpu\"}", isOptional: true)]
        public aws.SpotFleetRequest.ISpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsMemoryGibPerVcpu? MemoryGibPerVcpu
        {
            get;
            set;
        }

        /// <summary>memory_mib block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#memory_mib SpotFleetRequest#memory_mib}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "memoryMib", typeJson: "{\"fqn\":\"aws.spotFleetRequest.SpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsMemoryMib\"}", isOptional: true)]
        public aws.SpotFleetRequest.ISpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsMemoryMib? MemoryMib
        {
            get;
            set;
        }

        /// <summary>network_bandwidth_gbps block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#network_bandwidth_gbps SpotFleetRequest#network_bandwidth_gbps}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "networkBandwidthGbps", typeJson: "{\"fqn\":\"aws.spotFleetRequest.SpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsNetworkBandwidthGbps\"}", isOptional: true)]
        public aws.SpotFleetRequest.ISpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsNetworkBandwidthGbps? NetworkBandwidthGbps
        {
            get;
            set;
        }

        /// <summary>network_interface_count block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#network_interface_count SpotFleetRequest#network_interface_count}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "networkInterfaceCount", typeJson: "{\"fqn\":\"aws.spotFleetRequest.SpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsNetworkInterfaceCount\"}", isOptional: true)]
        public aws.SpotFleetRequest.ISpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsNetworkInterfaceCount? NetworkInterfaceCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#on_demand_max_price_percentage_over_lowest_price SpotFleetRequest#on_demand_max_price_percentage_over_lowest_price}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "onDemandMaxPricePercentageOverLowestPrice", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? OnDemandMaxPricePercentageOverLowestPrice
        {
            get;
            set;
        }

        private object? _requireHibernateSupport;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#require_hibernate_support SpotFleetRequest#require_hibernate_support}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#spot_max_price_percentage_over_lowest_price SpotFleetRequest#spot_max_price_percentage_over_lowest_price}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "spotMaxPricePercentageOverLowestPrice", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? SpotMaxPricePercentageOverLowestPrice
        {
            get;
            set;
        }

        /// <summary>total_local_storage_gb block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#total_local_storage_gb SpotFleetRequest#total_local_storage_gb}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "totalLocalStorageGb", typeJson: "{\"fqn\":\"aws.spotFleetRequest.SpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsTotalLocalStorageGb\"}", isOptional: true)]
        public aws.SpotFleetRequest.ISpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsTotalLocalStorageGb? TotalLocalStorageGb
        {
            get;
            set;
        }

        /// <summary>vcpu_count block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#vcpu_count SpotFleetRequest#vcpu_count}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vcpuCount", typeJson: "{\"fqn\":\"aws.spotFleetRequest.SpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsVcpuCount\"}", isOptional: true)]
        public aws.SpotFleetRequest.ISpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsVcpuCount? VcpuCount
        {
            get;
            set;
        }
    }
}

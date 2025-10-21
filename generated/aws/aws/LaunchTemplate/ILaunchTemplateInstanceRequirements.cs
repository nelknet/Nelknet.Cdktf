using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LaunchTemplate
{
    [JsiiInterface(nativeType: typeof(ILaunchTemplateInstanceRequirements), fullyQualifiedName: "aws.launchTemplate.LaunchTemplateInstanceRequirements")]
    public interface ILaunchTemplateInstanceRequirements
    {
        /// <summary>memory_mib block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#memory_mib LaunchTemplate#memory_mib}
        /// </remarks>
        [JsiiProperty(name: "memoryMib", typeJson: "{\"fqn\":\"aws.launchTemplate.LaunchTemplateInstanceRequirementsMemoryMib\"}")]
        aws.LaunchTemplate.ILaunchTemplateInstanceRequirementsMemoryMib MemoryMib
        {
            get;
        }

        /// <summary>vcpu_count block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#vcpu_count LaunchTemplate#vcpu_count}
        /// </remarks>
        [JsiiProperty(name: "vcpuCount", typeJson: "{\"fqn\":\"aws.launchTemplate.LaunchTemplateInstanceRequirementsVcpuCount\"}")]
        aws.LaunchTemplate.ILaunchTemplateInstanceRequirementsVcpuCount VcpuCount
        {
            get;
        }

        /// <summary>accelerator_count block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#accelerator_count LaunchTemplate#accelerator_count}
        /// </remarks>
        [JsiiProperty(name: "acceleratorCount", typeJson: "{\"fqn\":\"aws.launchTemplate.LaunchTemplateInstanceRequirementsAcceleratorCount\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.LaunchTemplate.ILaunchTemplateInstanceRequirementsAcceleratorCount? AcceleratorCount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#accelerator_manufacturers LaunchTemplate#accelerator_manufacturers}.</summary>
        [JsiiProperty(name: "acceleratorManufacturers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AcceleratorManufacturers
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#accelerator_names LaunchTemplate#accelerator_names}.</summary>
        [JsiiProperty(name: "acceleratorNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AcceleratorNames
        {
            get
            {
                return null;
            }
        }

        /// <summary>accelerator_total_memory_mib block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#accelerator_total_memory_mib LaunchTemplate#accelerator_total_memory_mib}
        /// </remarks>
        [JsiiProperty(name: "acceleratorTotalMemoryMib", typeJson: "{\"fqn\":\"aws.launchTemplate.LaunchTemplateInstanceRequirementsAcceleratorTotalMemoryMib\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.LaunchTemplate.ILaunchTemplateInstanceRequirementsAcceleratorTotalMemoryMib? AcceleratorTotalMemoryMib
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#accelerator_types LaunchTemplate#accelerator_types}.</summary>
        [JsiiProperty(name: "acceleratorTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AcceleratorTypes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#allowed_instance_types LaunchTemplate#allowed_instance_types}.</summary>
        [JsiiProperty(name: "allowedInstanceTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AllowedInstanceTypes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#bare_metal LaunchTemplate#bare_metal}.</summary>
        [JsiiProperty(name: "bareMetal", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BareMetal
        {
            get
            {
                return null;
            }
        }

        /// <summary>baseline_ebs_bandwidth_mbps block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#baseline_ebs_bandwidth_mbps LaunchTemplate#baseline_ebs_bandwidth_mbps}
        /// </remarks>
        [JsiiProperty(name: "baselineEbsBandwidthMbps", typeJson: "{\"fqn\":\"aws.launchTemplate.LaunchTemplateInstanceRequirementsBaselineEbsBandwidthMbps\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.LaunchTemplate.ILaunchTemplateInstanceRequirementsBaselineEbsBandwidthMbps? BaselineEbsBandwidthMbps
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#burstable_performance LaunchTemplate#burstable_performance}.</summary>
        [JsiiProperty(name: "burstablePerformance", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BurstablePerformance
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#cpu_manufacturers LaunchTemplate#cpu_manufacturers}.</summary>
        [JsiiProperty(name: "cpuManufacturers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? CpuManufacturers
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#excluded_instance_types LaunchTemplate#excluded_instance_types}.</summary>
        [JsiiProperty(name: "excludedInstanceTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ExcludedInstanceTypes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#instance_generations LaunchTemplate#instance_generations}.</summary>
        [JsiiProperty(name: "instanceGenerations", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? InstanceGenerations
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#local_storage LaunchTemplate#local_storage}.</summary>
        [JsiiProperty(name: "localStorage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LocalStorage
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#local_storage_types LaunchTemplate#local_storage_types}.</summary>
        [JsiiProperty(name: "localStorageTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? LocalStorageTypes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#max_spot_price_as_percentage_of_optimal_on_demand_price LaunchTemplate#max_spot_price_as_percentage_of_optimal_on_demand_price}.</summary>
        [JsiiProperty(name: "maxSpotPriceAsPercentageOfOptimalOnDemandPrice", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxSpotPriceAsPercentageOfOptimalOnDemandPrice
        {
            get
            {
                return null;
            }
        }

        /// <summary>memory_gib_per_vcpu block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#memory_gib_per_vcpu LaunchTemplate#memory_gib_per_vcpu}
        /// </remarks>
        [JsiiProperty(name: "memoryGibPerVcpu", typeJson: "{\"fqn\":\"aws.launchTemplate.LaunchTemplateInstanceRequirementsMemoryGibPerVcpu\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.LaunchTemplate.ILaunchTemplateInstanceRequirementsMemoryGibPerVcpu? MemoryGibPerVcpu
        {
            get
            {
                return null;
            }
        }

        /// <summary>network_bandwidth_gbps block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#network_bandwidth_gbps LaunchTemplate#network_bandwidth_gbps}
        /// </remarks>
        [JsiiProperty(name: "networkBandwidthGbps", typeJson: "{\"fqn\":\"aws.launchTemplate.LaunchTemplateInstanceRequirementsNetworkBandwidthGbps\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.LaunchTemplate.ILaunchTemplateInstanceRequirementsNetworkBandwidthGbps? NetworkBandwidthGbps
        {
            get
            {
                return null;
            }
        }

        /// <summary>network_interface_count block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#network_interface_count LaunchTemplate#network_interface_count}
        /// </remarks>
        [JsiiProperty(name: "networkInterfaceCount", typeJson: "{\"fqn\":\"aws.launchTemplate.LaunchTemplateInstanceRequirementsNetworkInterfaceCount\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.LaunchTemplate.ILaunchTemplateInstanceRequirementsNetworkInterfaceCount? NetworkInterfaceCount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#on_demand_max_price_percentage_over_lowest_price LaunchTemplate#on_demand_max_price_percentage_over_lowest_price}.</summary>
        [JsiiProperty(name: "onDemandMaxPricePercentageOverLowestPrice", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? OnDemandMaxPricePercentageOverLowestPrice
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#require_hibernate_support LaunchTemplate#require_hibernate_support}.</summary>
        [JsiiProperty(name: "requireHibernateSupport", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RequireHibernateSupport
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#spot_max_price_percentage_over_lowest_price LaunchTemplate#spot_max_price_percentage_over_lowest_price}.</summary>
        [JsiiProperty(name: "spotMaxPricePercentageOverLowestPrice", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? SpotMaxPricePercentageOverLowestPrice
        {
            get
            {
                return null;
            }
        }

        /// <summary>total_local_storage_gb block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#total_local_storage_gb LaunchTemplate#total_local_storage_gb}
        /// </remarks>
        [JsiiProperty(name: "totalLocalStorageGb", typeJson: "{\"fqn\":\"aws.launchTemplate.LaunchTemplateInstanceRequirementsTotalLocalStorageGb\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.LaunchTemplate.ILaunchTemplateInstanceRequirementsTotalLocalStorageGb? TotalLocalStorageGb
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILaunchTemplateInstanceRequirements), fullyQualifiedName: "aws.launchTemplate.LaunchTemplateInstanceRequirements")]
        internal sealed class _Proxy : DeputyBase, aws.LaunchTemplate.ILaunchTemplateInstanceRequirements
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>memory_mib block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#memory_mib LaunchTemplate#memory_mib}
            /// </remarks>
            [JsiiProperty(name: "memoryMib", typeJson: "{\"fqn\":\"aws.launchTemplate.LaunchTemplateInstanceRequirementsMemoryMib\"}")]
            public aws.LaunchTemplate.ILaunchTemplateInstanceRequirementsMemoryMib MemoryMib
            {
                get => GetInstanceProperty<aws.LaunchTemplate.ILaunchTemplateInstanceRequirementsMemoryMib>()!;
            }

            /// <summary>vcpu_count block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#vcpu_count LaunchTemplate#vcpu_count}
            /// </remarks>
            [JsiiProperty(name: "vcpuCount", typeJson: "{\"fqn\":\"aws.launchTemplate.LaunchTemplateInstanceRequirementsVcpuCount\"}")]
            public aws.LaunchTemplate.ILaunchTemplateInstanceRequirementsVcpuCount VcpuCount
            {
                get => GetInstanceProperty<aws.LaunchTemplate.ILaunchTemplateInstanceRequirementsVcpuCount>()!;
            }

            /// <summary>accelerator_count block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#accelerator_count LaunchTemplate#accelerator_count}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "acceleratorCount", typeJson: "{\"fqn\":\"aws.launchTemplate.LaunchTemplateInstanceRequirementsAcceleratorCount\"}", isOptional: true)]
            public aws.LaunchTemplate.ILaunchTemplateInstanceRequirementsAcceleratorCount? AcceleratorCount
            {
                get => GetInstanceProperty<aws.LaunchTemplate.ILaunchTemplateInstanceRequirementsAcceleratorCount?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#accelerator_manufacturers LaunchTemplate#accelerator_manufacturers}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "acceleratorManufacturers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AcceleratorManufacturers
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#accelerator_names LaunchTemplate#accelerator_names}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "acceleratorNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AcceleratorNames
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>accelerator_total_memory_mib block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#accelerator_total_memory_mib LaunchTemplate#accelerator_total_memory_mib}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "acceleratorTotalMemoryMib", typeJson: "{\"fqn\":\"aws.launchTemplate.LaunchTemplateInstanceRequirementsAcceleratorTotalMemoryMib\"}", isOptional: true)]
            public aws.LaunchTemplate.ILaunchTemplateInstanceRequirementsAcceleratorTotalMemoryMib? AcceleratorTotalMemoryMib
            {
                get => GetInstanceProperty<aws.LaunchTemplate.ILaunchTemplateInstanceRequirementsAcceleratorTotalMemoryMib?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#accelerator_types LaunchTemplate#accelerator_types}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "acceleratorTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AcceleratorTypes
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#allowed_instance_types LaunchTemplate#allowed_instance_types}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "allowedInstanceTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AllowedInstanceTypes
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#bare_metal LaunchTemplate#bare_metal}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "bareMetal", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BareMetal
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>baseline_ebs_bandwidth_mbps block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#baseline_ebs_bandwidth_mbps LaunchTemplate#baseline_ebs_bandwidth_mbps}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "baselineEbsBandwidthMbps", typeJson: "{\"fqn\":\"aws.launchTemplate.LaunchTemplateInstanceRequirementsBaselineEbsBandwidthMbps\"}", isOptional: true)]
            public aws.LaunchTemplate.ILaunchTemplateInstanceRequirementsBaselineEbsBandwidthMbps? BaselineEbsBandwidthMbps
            {
                get => GetInstanceProperty<aws.LaunchTemplate.ILaunchTemplateInstanceRequirementsBaselineEbsBandwidthMbps?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#burstable_performance LaunchTemplate#burstable_performance}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "burstablePerformance", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BurstablePerformance
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#cpu_manufacturers LaunchTemplate#cpu_manufacturers}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cpuManufacturers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? CpuManufacturers
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#excluded_instance_types LaunchTemplate#excluded_instance_types}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "excludedInstanceTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ExcludedInstanceTypes
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#instance_generations LaunchTemplate#instance_generations}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "instanceGenerations", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? InstanceGenerations
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#local_storage LaunchTemplate#local_storage}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "localStorage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LocalStorage
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#local_storage_types LaunchTemplate#local_storage_types}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "localStorageTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? LocalStorageTypes
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#max_spot_price_as_percentage_of_optimal_on_demand_price LaunchTemplate#max_spot_price_as_percentage_of_optimal_on_demand_price}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxSpotPriceAsPercentageOfOptimalOnDemandPrice", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxSpotPriceAsPercentageOfOptimalOnDemandPrice
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>memory_gib_per_vcpu block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#memory_gib_per_vcpu LaunchTemplate#memory_gib_per_vcpu}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "memoryGibPerVcpu", typeJson: "{\"fqn\":\"aws.launchTemplate.LaunchTemplateInstanceRequirementsMemoryGibPerVcpu\"}", isOptional: true)]
            public aws.LaunchTemplate.ILaunchTemplateInstanceRequirementsMemoryGibPerVcpu? MemoryGibPerVcpu
            {
                get => GetInstanceProperty<aws.LaunchTemplate.ILaunchTemplateInstanceRequirementsMemoryGibPerVcpu?>();
            }

            /// <summary>network_bandwidth_gbps block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#network_bandwidth_gbps LaunchTemplate#network_bandwidth_gbps}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "networkBandwidthGbps", typeJson: "{\"fqn\":\"aws.launchTemplate.LaunchTemplateInstanceRequirementsNetworkBandwidthGbps\"}", isOptional: true)]
            public aws.LaunchTemplate.ILaunchTemplateInstanceRequirementsNetworkBandwidthGbps? NetworkBandwidthGbps
            {
                get => GetInstanceProperty<aws.LaunchTemplate.ILaunchTemplateInstanceRequirementsNetworkBandwidthGbps?>();
            }

            /// <summary>network_interface_count block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#network_interface_count LaunchTemplate#network_interface_count}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "networkInterfaceCount", typeJson: "{\"fqn\":\"aws.launchTemplate.LaunchTemplateInstanceRequirementsNetworkInterfaceCount\"}", isOptional: true)]
            public aws.LaunchTemplate.ILaunchTemplateInstanceRequirementsNetworkInterfaceCount? NetworkInterfaceCount
            {
                get => GetInstanceProperty<aws.LaunchTemplate.ILaunchTemplateInstanceRequirementsNetworkInterfaceCount?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#on_demand_max_price_percentage_over_lowest_price LaunchTemplate#on_demand_max_price_percentage_over_lowest_price}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "onDemandMaxPricePercentageOverLowestPrice", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? OnDemandMaxPricePercentageOverLowestPrice
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#require_hibernate_support LaunchTemplate#require_hibernate_support}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "requireHibernateSupport", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? RequireHibernateSupport
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#spot_max_price_percentage_over_lowest_price LaunchTemplate#spot_max_price_percentage_over_lowest_price}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "spotMaxPricePercentageOverLowestPrice", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? SpotMaxPricePercentageOverLowestPrice
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>total_local_storage_gb block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#total_local_storage_gb LaunchTemplate#total_local_storage_gb}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "totalLocalStorageGb", typeJson: "{\"fqn\":\"aws.launchTemplate.LaunchTemplateInstanceRequirementsTotalLocalStorageGb\"}", isOptional: true)]
            public aws.LaunchTemplate.ILaunchTemplateInstanceRequirementsTotalLocalStorageGb? TotalLocalStorageGb
            {
                get => GetInstanceProperty<aws.LaunchTemplate.ILaunchTemplateInstanceRequirementsTotalLocalStorageGb?>();
            }
        }
    }
}

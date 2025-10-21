using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SpotFleetRequest
{
    [JsiiInterface(nativeType: typeof(ISpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirements), fullyQualifiedName: "aws.spotFleetRequest.SpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirements")]
    public interface ISpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirements
    {
        /// <summary>accelerator_count block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#accelerator_count SpotFleetRequest#accelerator_count}
        /// </remarks>
        [JsiiProperty(name: "acceleratorCount", typeJson: "{\"fqn\":\"aws.spotFleetRequest.SpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsAcceleratorCount\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SpotFleetRequest.ISpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsAcceleratorCount? AcceleratorCount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#accelerator_manufacturers SpotFleetRequest#accelerator_manufacturers}.</summary>
        [JsiiProperty(name: "acceleratorManufacturers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AcceleratorManufacturers
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#accelerator_names SpotFleetRequest#accelerator_names}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#accelerator_total_memory_mib SpotFleetRequest#accelerator_total_memory_mib}
        /// </remarks>
        [JsiiProperty(name: "acceleratorTotalMemoryMib", typeJson: "{\"fqn\":\"aws.spotFleetRequest.SpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsAcceleratorTotalMemoryMib\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SpotFleetRequest.ISpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsAcceleratorTotalMemoryMib? AcceleratorTotalMemoryMib
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#accelerator_types SpotFleetRequest#accelerator_types}.</summary>
        [JsiiProperty(name: "acceleratorTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AcceleratorTypes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#allowed_instance_types SpotFleetRequest#allowed_instance_types}.</summary>
        [JsiiProperty(name: "allowedInstanceTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AllowedInstanceTypes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#bare_metal SpotFleetRequest#bare_metal}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#baseline_ebs_bandwidth_mbps SpotFleetRequest#baseline_ebs_bandwidth_mbps}
        /// </remarks>
        [JsiiProperty(name: "baselineEbsBandwidthMbps", typeJson: "{\"fqn\":\"aws.spotFleetRequest.SpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsBaselineEbsBandwidthMbps\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SpotFleetRequest.ISpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsBaselineEbsBandwidthMbps? BaselineEbsBandwidthMbps
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#burstable_performance SpotFleetRequest#burstable_performance}.</summary>
        [JsiiProperty(name: "burstablePerformance", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BurstablePerformance
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#cpu_manufacturers SpotFleetRequest#cpu_manufacturers}.</summary>
        [JsiiProperty(name: "cpuManufacturers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? CpuManufacturers
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#excluded_instance_types SpotFleetRequest#excluded_instance_types}.</summary>
        [JsiiProperty(name: "excludedInstanceTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ExcludedInstanceTypes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#instance_generations SpotFleetRequest#instance_generations}.</summary>
        [JsiiProperty(name: "instanceGenerations", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? InstanceGenerations
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#local_storage SpotFleetRequest#local_storage}.</summary>
        [JsiiProperty(name: "localStorage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LocalStorage
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#local_storage_types SpotFleetRequest#local_storage_types}.</summary>
        [JsiiProperty(name: "localStorageTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? LocalStorageTypes
        {
            get
            {
                return null;
            }
        }

        /// <summary>memory_gib_per_vcpu block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#memory_gib_per_vcpu SpotFleetRequest#memory_gib_per_vcpu}
        /// </remarks>
        [JsiiProperty(name: "memoryGibPerVcpu", typeJson: "{\"fqn\":\"aws.spotFleetRequest.SpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsMemoryGibPerVcpu\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SpotFleetRequest.ISpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsMemoryGibPerVcpu? MemoryGibPerVcpu
        {
            get
            {
                return null;
            }
        }

        /// <summary>memory_mib block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#memory_mib SpotFleetRequest#memory_mib}
        /// </remarks>
        [JsiiProperty(name: "memoryMib", typeJson: "{\"fqn\":\"aws.spotFleetRequest.SpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsMemoryMib\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SpotFleetRequest.ISpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsMemoryMib? MemoryMib
        {
            get
            {
                return null;
            }
        }

        /// <summary>network_bandwidth_gbps block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#network_bandwidth_gbps SpotFleetRequest#network_bandwidth_gbps}
        /// </remarks>
        [JsiiProperty(name: "networkBandwidthGbps", typeJson: "{\"fqn\":\"aws.spotFleetRequest.SpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsNetworkBandwidthGbps\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SpotFleetRequest.ISpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsNetworkBandwidthGbps? NetworkBandwidthGbps
        {
            get
            {
                return null;
            }
        }

        /// <summary>network_interface_count block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#network_interface_count SpotFleetRequest#network_interface_count}
        /// </remarks>
        [JsiiProperty(name: "networkInterfaceCount", typeJson: "{\"fqn\":\"aws.spotFleetRequest.SpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsNetworkInterfaceCount\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SpotFleetRequest.ISpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsNetworkInterfaceCount? NetworkInterfaceCount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#on_demand_max_price_percentage_over_lowest_price SpotFleetRequest#on_demand_max_price_percentage_over_lowest_price}.</summary>
        [JsiiProperty(name: "onDemandMaxPricePercentageOverLowestPrice", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? OnDemandMaxPricePercentageOverLowestPrice
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#require_hibernate_support SpotFleetRequest#require_hibernate_support}.</summary>
        [JsiiProperty(name: "requireHibernateSupport", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RequireHibernateSupport
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#spot_max_price_percentage_over_lowest_price SpotFleetRequest#spot_max_price_percentage_over_lowest_price}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#total_local_storage_gb SpotFleetRequest#total_local_storage_gb}
        /// </remarks>
        [JsiiProperty(name: "totalLocalStorageGb", typeJson: "{\"fqn\":\"aws.spotFleetRequest.SpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsTotalLocalStorageGb\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SpotFleetRequest.ISpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsTotalLocalStorageGb? TotalLocalStorageGb
        {
            get
            {
                return null;
            }
        }

        /// <summary>vcpu_count block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#vcpu_count SpotFleetRequest#vcpu_count}
        /// </remarks>
        [JsiiProperty(name: "vcpuCount", typeJson: "{\"fqn\":\"aws.spotFleetRequest.SpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsVcpuCount\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SpotFleetRequest.ISpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsVcpuCount? VcpuCount
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirements), fullyQualifiedName: "aws.spotFleetRequest.SpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirements")]
        internal sealed class _Proxy : DeputyBase, aws.SpotFleetRequest.ISpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirements
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>accelerator_count block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#accelerator_count SpotFleetRequest#accelerator_count}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "acceleratorCount", typeJson: "{\"fqn\":\"aws.spotFleetRequest.SpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsAcceleratorCount\"}", isOptional: true)]
            public aws.SpotFleetRequest.ISpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsAcceleratorCount? AcceleratorCount
            {
                get => GetInstanceProperty<aws.SpotFleetRequest.ISpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsAcceleratorCount?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#accelerator_manufacturers SpotFleetRequest#accelerator_manufacturers}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "acceleratorManufacturers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AcceleratorManufacturers
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#accelerator_names SpotFleetRequest#accelerator_names}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "acceleratorNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AcceleratorNames
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>accelerator_total_memory_mib block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#accelerator_total_memory_mib SpotFleetRequest#accelerator_total_memory_mib}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "acceleratorTotalMemoryMib", typeJson: "{\"fqn\":\"aws.spotFleetRequest.SpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsAcceleratorTotalMemoryMib\"}", isOptional: true)]
            public aws.SpotFleetRequest.ISpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsAcceleratorTotalMemoryMib? AcceleratorTotalMemoryMib
            {
                get => GetInstanceProperty<aws.SpotFleetRequest.ISpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsAcceleratorTotalMemoryMib?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#accelerator_types SpotFleetRequest#accelerator_types}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "acceleratorTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AcceleratorTypes
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#allowed_instance_types SpotFleetRequest#allowed_instance_types}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "allowedInstanceTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AllowedInstanceTypes
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#bare_metal SpotFleetRequest#bare_metal}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "bareMetal", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BareMetal
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>baseline_ebs_bandwidth_mbps block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#baseline_ebs_bandwidth_mbps SpotFleetRequest#baseline_ebs_bandwidth_mbps}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "baselineEbsBandwidthMbps", typeJson: "{\"fqn\":\"aws.spotFleetRequest.SpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsBaselineEbsBandwidthMbps\"}", isOptional: true)]
            public aws.SpotFleetRequest.ISpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsBaselineEbsBandwidthMbps? BaselineEbsBandwidthMbps
            {
                get => GetInstanceProperty<aws.SpotFleetRequest.ISpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsBaselineEbsBandwidthMbps?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#burstable_performance SpotFleetRequest#burstable_performance}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "burstablePerformance", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BurstablePerformance
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#cpu_manufacturers SpotFleetRequest#cpu_manufacturers}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cpuManufacturers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? CpuManufacturers
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#excluded_instance_types SpotFleetRequest#excluded_instance_types}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "excludedInstanceTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ExcludedInstanceTypes
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#instance_generations SpotFleetRequest#instance_generations}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "instanceGenerations", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? InstanceGenerations
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#local_storage SpotFleetRequest#local_storage}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "localStorage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LocalStorage
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#local_storage_types SpotFleetRequest#local_storage_types}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "localStorageTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? LocalStorageTypes
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>memory_gib_per_vcpu block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#memory_gib_per_vcpu SpotFleetRequest#memory_gib_per_vcpu}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "memoryGibPerVcpu", typeJson: "{\"fqn\":\"aws.spotFleetRequest.SpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsMemoryGibPerVcpu\"}", isOptional: true)]
            public aws.SpotFleetRequest.ISpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsMemoryGibPerVcpu? MemoryGibPerVcpu
            {
                get => GetInstanceProperty<aws.SpotFleetRequest.ISpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsMemoryGibPerVcpu?>();
            }

            /// <summary>memory_mib block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#memory_mib SpotFleetRequest#memory_mib}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "memoryMib", typeJson: "{\"fqn\":\"aws.spotFleetRequest.SpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsMemoryMib\"}", isOptional: true)]
            public aws.SpotFleetRequest.ISpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsMemoryMib? MemoryMib
            {
                get => GetInstanceProperty<aws.SpotFleetRequest.ISpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsMemoryMib?>();
            }

            /// <summary>network_bandwidth_gbps block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#network_bandwidth_gbps SpotFleetRequest#network_bandwidth_gbps}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "networkBandwidthGbps", typeJson: "{\"fqn\":\"aws.spotFleetRequest.SpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsNetworkBandwidthGbps\"}", isOptional: true)]
            public aws.SpotFleetRequest.ISpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsNetworkBandwidthGbps? NetworkBandwidthGbps
            {
                get => GetInstanceProperty<aws.SpotFleetRequest.ISpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsNetworkBandwidthGbps?>();
            }

            /// <summary>network_interface_count block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#network_interface_count SpotFleetRequest#network_interface_count}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "networkInterfaceCount", typeJson: "{\"fqn\":\"aws.spotFleetRequest.SpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsNetworkInterfaceCount\"}", isOptional: true)]
            public aws.SpotFleetRequest.ISpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsNetworkInterfaceCount? NetworkInterfaceCount
            {
                get => GetInstanceProperty<aws.SpotFleetRequest.ISpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsNetworkInterfaceCount?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#on_demand_max_price_percentage_over_lowest_price SpotFleetRequest#on_demand_max_price_percentage_over_lowest_price}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "onDemandMaxPricePercentageOverLowestPrice", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? OnDemandMaxPricePercentageOverLowestPrice
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#require_hibernate_support SpotFleetRequest#require_hibernate_support}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "requireHibernateSupport", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? RequireHibernateSupport
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#spot_max_price_percentage_over_lowest_price SpotFleetRequest#spot_max_price_percentage_over_lowest_price}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "spotMaxPricePercentageOverLowestPrice", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? SpotMaxPricePercentageOverLowestPrice
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>total_local_storage_gb block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#total_local_storage_gb SpotFleetRequest#total_local_storage_gb}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "totalLocalStorageGb", typeJson: "{\"fqn\":\"aws.spotFleetRequest.SpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsTotalLocalStorageGb\"}", isOptional: true)]
            public aws.SpotFleetRequest.ISpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsTotalLocalStorageGb? TotalLocalStorageGb
            {
                get => GetInstanceProperty<aws.SpotFleetRequest.ISpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsTotalLocalStorageGb?>();
            }

            /// <summary>vcpu_count block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#vcpu_count SpotFleetRequest#vcpu_count}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "vcpuCount", typeJson: "{\"fqn\":\"aws.spotFleetRequest.SpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsVcpuCount\"}", isOptional: true)]
            public aws.SpotFleetRequest.ISpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsVcpuCount? VcpuCount
            {
                get => GetInstanceProperty<aws.SpotFleetRequest.ISpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsVcpuCount?>();
            }
        }
    }
}

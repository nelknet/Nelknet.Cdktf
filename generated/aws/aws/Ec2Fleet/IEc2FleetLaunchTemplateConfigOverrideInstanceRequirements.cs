using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2Fleet
{
    [JsiiInterface(nativeType: typeof(IEc2FleetLaunchTemplateConfigOverrideInstanceRequirements), fullyQualifiedName: "aws.ec2Fleet.Ec2FleetLaunchTemplateConfigOverrideInstanceRequirements")]
    public interface IEc2FleetLaunchTemplateConfigOverrideInstanceRequirements
    {
        /// <summary>memory_mib block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#memory_mib Ec2Fleet#memory_mib}
        /// </remarks>
        [JsiiProperty(name: "memoryMib", typeJson: "{\"fqn\":\"aws.ec2Fleet.Ec2FleetLaunchTemplateConfigOverrideInstanceRequirementsMemoryMib\"}")]
        aws.Ec2Fleet.IEc2FleetLaunchTemplateConfigOverrideInstanceRequirementsMemoryMib MemoryMib
        {
            get;
        }

        /// <summary>vcpu_count block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#vcpu_count Ec2Fleet#vcpu_count}
        /// </remarks>
        [JsiiProperty(name: "vcpuCount", typeJson: "{\"fqn\":\"aws.ec2Fleet.Ec2FleetLaunchTemplateConfigOverrideInstanceRequirementsVcpuCount\"}")]
        aws.Ec2Fleet.IEc2FleetLaunchTemplateConfigOverrideInstanceRequirementsVcpuCount VcpuCount
        {
            get;
        }

        /// <summary>accelerator_count block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#accelerator_count Ec2Fleet#accelerator_count}
        /// </remarks>
        [JsiiProperty(name: "acceleratorCount", typeJson: "{\"fqn\":\"aws.ec2Fleet.Ec2FleetLaunchTemplateConfigOverrideInstanceRequirementsAcceleratorCount\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Ec2Fleet.IEc2FleetLaunchTemplateConfigOverrideInstanceRequirementsAcceleratorCount? AcceleratorCount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#accelerator_manufacturers Ec2Fleet#accelerator_manufacturers}.</summary>
        [JsiiProperty(name: "acceleratorManufacturers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AcceleratorManufacturers
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#accelerator_names Ec2Fleet#accelerator_names}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#accelerator_total_memory_mib Ec2Fleet#accelerator_total_memory_mib}
        /// </remarks>
        [JsiiProperty(name: "acceleratorTotalMemoryMib", typeJson: "{\"fqn\":\"aws.ec2Fleet.Ec2FleetLaunchTemplateConfigOverrideInstanceRequirementsAcceleratorTotalMemoryMib\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Ec2Fleet.IEc2FleetLaunchTemplateConfigOverrideInstanceRequirementsAcceleratorTotalMemoryMib? AcceleratorTotalMemoryMib
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#accelerator_types Ec2Fleet#accelerator_types}.</summary>
        [JsiiProperty(name: "acceleratorTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AcceleratorTypes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#allowed_instance_types Ec2Fleet#allowed_instance_types}.</summary>
        [JsiiProperty(name: "allowedInstanceTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AllowedInstanceTypes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#bare_metal Ec2Fleet#bare_metal}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#baseline_ebs_bandwidth_mbps Ec2Fleet#baseline_ebs_bandwidth_mbps}
        /// </remarks>
        [JsiiProperty(name: "baselineEbsBandwidthMbps", typeJson: "{\"fqn\":\"aws.ec2Fleet.Ec2FleetLaunchTemplateConfigOverrideInstanceRequirementsBaselineEbsBandwidthMbps\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Ec2Fleet.IEc2FleetLaunchTemplateConfigOverrideInstanceRequirementsBaselineEbsBandwidthMbps? BaselineEbsBandwidthMbps
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#burstable_performance Ec2Fleet#burstable_performance}.</summary>
        [JsiiProperty(name: "burstablePerformance", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BurstablePerformance
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#cpu_manufacturers Ec2Fleet#cpu_manufacturers}.</summary>
        [JsiiProperty(name: "cpuManufacturers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? CpuManufacturers
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#excluded_instance_types Ec2Fleet#excluded_instance_types}.</summary>
        [JsiiProperty(name: "excludedInstanceTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ExcludedInstanceTypes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#instance_generations Ec2Fleet#instance_generations}.</summary>
        [JsiiProperty(name: "instanceGenerations", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? InstanceGenerations
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#local_storage Ec2Fleet#local_storage}.</summary>
        [JsiiProperty(name: "localStorage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LocalStorage
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#local_storage_types Ec2Fleet#local_storage_types}.</summary>
        [JsiiProperty(name: "localStorageTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? LocalStorageTypes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#max_spot_price_as_percentage_of_optimal_on_demand_price Ec2Fleet#max_spot_price_as_percentage_of_optimal_on_demand_price}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#memory_gib_per_vcpu Ec2Fleet#memory_gib_per_vcpu}
        /// </remarks>
        [JsiiProperty(name: "memoryGibPerVcpu", typeJson: "{\"fqn\":\"aws.ec2Fleet.Ec2FleetLaunchTemplateConfigOverrideInstanceRequirementsMemoryGibPerVcpu\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Ec2Fleet.IEc2FleetLaunchTemplateConfigOverrideInstanceRequirementsMemoryGibPerVcpu? MemoryGibPerVcpu
        {
            get
            {
                return null;
            }
        }

        /// <summary>network_bandwidth_gbps block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#network_bandwidth_gbps Ec2Fleet#network_bandwidth_gbps}
        /// </remarks>
        [JsiiProperty(name: "networkBandwidthGbps", typeJson: "{\"fqn\":\"aws.ec2Fleet.Ec2FleetLaunchTemplateConfigOverrideInstanceRequirementsNetworkBandwidthGbps\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Ec2Fleet.IEc2FleetLaunchTemplateConfigOverrideInstanceRequirementsNetworkBandwidthGbps? NetworkBandwidthGbps
        {
            get
            {
                return null;
            }
        }

        /// <summary>network_interface_count block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#network_interface_count Ec2Fleet#network_interface_count}
        /// </remarks>
        [JsiiProperty(name: "networkInterfaceCount", typeJson: "{\"fqn\":\"aws.ec2Fleet.Ec2FleetLaunchTemplateConfigOverrideInstanceRequirementsNetworkInterfaceCount\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Ec2Fleet.IEc2FleetLaunchTemplateConfigOverrideInstanceRequirementsNetworkInterfaceCount? NetworkInterfaceCount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#on_demand_max_price_percentage_over_lowest_price Ec2Fleet#on_demand_max_price_percentage_over_lowest_price}.</summary>
        [JsiiProperty(name: "onDemandMaxPricePercentageOverLowestPrice", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? OnDemandMaxPricePercentageOverLowestPrice
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#require_hibernate_support Ec2Fleet#require_hibernate_support}.</summary>
        [JsiiProperty(name: "requireHibernateSupport", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RequireHibernateSupport
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#spot_max_price_percentage_over_lowest_price Ec2Fleet#spot_max_price_percentage_over_lowest_price}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#total_local_storage_gb Ec2Fleet#total_local_storage_gb}
        /// </remarks>
        [JsiiProperty(name: "totalLocalStorageGb", typeJson: "{\"fqn\":\"aws.ec2Fleet.Ec2FleetLaunchTemplateConfigOverrideInstanceRequirementsTotalLocalStorageGb\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Ec2Fleet.IEc2FleetLaunchTemplateConfigOverrideInstanceRequirementsTotalLocalStorageGb? TotalLocalStorageGb
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEc2FleetLaunchTemplateConfigOverrideInstanceRequirements), fullyQualifiedName: "aws.ec2Fleet.Ec2FleetLaunchTemplateConfigOverrideInstanceRequirements")]
        internal sealed class _Proxy : DeputyBase, aws.Ec2Fleet.IEc2FleetLaunchTemplateConfigOverrideInstanceRequirements
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>memory_mib block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#memory_mib Ec2Fleet#memory_mib}
            /// </remarks>
            [JsiiProperty(name: "memoryMib", typeJson: "{\"fqn\":\"aws.ec2Fleet.Ec2FleetLaunchTemplateConfigOverrideInstanceRequirementsMemoryMib\"}")]
            public aws.Ec2Fleet.IEc2FleetLaunchTemplateConfigOverrideInstanceRequirementsMemoryMib MemoryMib
            {
                get => GetInstanceProperty<aws.Ec2Fleet.IEc2FleetLaunchTemplateConfigOverrideInstanceRequirementsMemoryMib>()!;
            }

            /// <summary>vcpu_count block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#vcpu_count Ec2Fleet#vcpu_count}
            /// </remarks>
            [JsiiProperty(name: "vcpuCount", typeJson: "{\"fqn\":\"aws.ec2Fleet.Ec2FleetLaunchTemplateConfigOverrideInstanceRequirementsVcpuCount\"}")]
            public aws.Ec2Fleet.IEc2FleetLaunchTemplateConfigOverrideInstanceRequirementsVcpuCount VcpuCount
            {
                get => GetInstanceProperty<aws.Ec2Fleet.IEc2FleetLaunchTemplateConfigOverrideInstanceRequirementsVcpuCount>()!;
            }

            /// <summary>accelerator_count block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#accelerator_count Ec2Fleet#accelerator_count}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "acceleratorCount", typeJson: "{\"fqn\":\"aws.ec2Fleet.Ec2FleetLaunchTemplateConfigOverrideInstanceRequirementsAcceleratorCount\"}", isOptional: true)]
            public aws.Ec2Fleet.IEc2FleetLaunchTemplateConfigOverrideInstanceRequirementsAcceleratorCount? AcceleratorCount
            {
                get => GetInstanceProperty<aws.Ec2Fleet.IEc2FleetLaunchTemplateConfigOverrideInstanceRequirementsAcceleratorCount?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#accelerator_manufacturers Ec2Fleet#accelerator_manufacturers}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "acceleratorManufacturers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AcceleratorManufacturers
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#accelerator_names Ec2Fleet#accelerator_names}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "acceleratorNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AcceleratorNames
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>accelerator_total_memory_mib block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#accelerator_total_memory_mib Ec2Fleet#accelerator_total_memory_mib}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "acceleratorTotalMemoryMib", typeJson: "{\"fqn\":\"aws.ec2Fleet.Ec2FleetLaunchTemplateConfigOverrideInstanceRequirementsAcceleratorTotalMemoryMib\"}", isOptional: true)]
            public aws.Ec2Fleet.IEc2FleetLaunchTemplateConfigOverrideInstanceRequirementsAcceleratorTotalMemoryMib? AcceleratorTotalMemoryMib
            {
                get => GetInstanceProperty<aws.Ec2Fleet.IEc2FleetLaunchTemplateConfigOverrideInstanceRequirementsAcceleratorTotalMemoryMib?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#accelerator_types Ec2Fleet#accelerator_types}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "acceleratorTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AcceleratorTypes
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#allowed_instance_types Ec2Fleet#allowed_instance_types}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "allowedInstanceTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AllowedInstanceTypes
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#bare_metal Ec2Fleet#bare_metal}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "bareMetal", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BareMetal
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>baseline_ebs_bandwidth_mbps block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#baseline_ebs_bandwidth_mbps Ec2Fleet#baseline_ebs_bandwidth_mbps}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "baselineEbsBandwidthMbps", typeJson: "{\"fqn\":\"aws.ec2Fleet.Ec2FleetLaunchTemplateConfigOverrideInstanceRequirementsBaselineEbsBandwidthMbps\"}", isOptional: true)]
            public aws.Ec2Fleet.IEc2FleetLaunchTemplateConfigOverrideInstanceRequirementsBaselineEbsBandwidthMbps? BaselineEbsBandwidthMbps
            {
                get => GetInstanceProperty<aws.Ec2Fleet.IEc2FleetLaunchTemplateConfigOverrideInstanceRequirementsBaselineEbsBandwidthMbps?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#burstable_performance Ec2Fleet#burstable_performance}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "burstablePerformance", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BurstablePerformance
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#cpu_manufacturers Ec2Fleet#cpu_manufacturers}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cpuManufacturers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? CpuManufacturers
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#excluded_instance_types Ec2Fleet#excluded_instance_types}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "excludedInstanceTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ExcludedInstanceTypes
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#instance_generations Ec2Fleet#instance_generations}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "instanceGenerations", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? InstanceGenerations
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#local_storage Ec2Fleet#local_storage}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "localStorage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LocalStorage
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#local_storage_types Ec2Fleet#local_storage_types}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "localStorageTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? LocalStorageTypes
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#max_spot_price_as_percentage_of_optimal_on_demand_price Ec2Fleet#max_spot_price_as_percentage_of_optimal_on_demand_price}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxSpotPriceAsPercentageOfOptimalOnDemandPrice", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxSpotPriceAsPercentageOfOptimalOnDemandPrice
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>memory_gib_per_vcpu block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#memory_gib_per_vcpu Ec2Fleet#memory_gib_per_vcpu}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "memoryGibPerVcpu", typeJson: "{\"fqn\":\"aws.ec2Fleet.Ec2FleetLaunchTemplateConfigOverrideInstanceRequirementsMemoryGibPerVcpu\"}", isOptional: true)]
            public aws.Ec2Fleet.IEc2FleetLaunchTemplateConfigOverrideInstanceRequirementsMemoryGibPerVcpu? MemoryGibPerVcpu
            {
                get => GetInstanceProperty<aws.Ec2Fleet.IEc2FleetLaunchTemplateConfigOverrideInstanceRequirementsMemoryGibPerVcpu?>();
            }

            /// <summary>network_bandwidth_gbps block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#network_bandwidth_gbps Ec2Fleet#network_bandwidth_gbps}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "networkBandwidthGbps", typeJson: "{\"fqn\":\"aws.ec2Fleet.Ec2FleetLaunchTemplateConfigOverrideInstanceRequirementsNetworkBandwidthGbps\"}", isOptional: true)]
            public aws.Ec2Fleet.IEc2FleetLaunchTemplateConfigOverrideInstanceRequirementsNetworkBandwidthGbps? NetworkBandwidthGbps
            {
                get => GetInstanceProperty<aws.Ec2Fleet.IEc2FleetLaunchTemplateConfigOverrideInstanceRequirementsNetworkBandwidthGbps?>();
            }

            /// <summary>network_interface_count block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#network_interface_count Ec2Fleet#network_interface_count}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "networkInterfaceCount", typeJson: "{\"fqn\":\"aws.ec2Fleet.Ec2FleetLaunchTemplateConfigOverrideInstanceRequirementsNetworkInterfaceCount\"}", isOptional: true)]
            public aws.Ec2Fleet.IEc2FleetLaunchTemplateConfigOverrideInstanceRequirementsNetworkInterfaceCount? NetworkInterfaceCount
            {
                get => GetInstanceProperty<aws.Ec2Fleet.IEc2FleetLaunchTemplateConfigOverrideInstanceRequirementsNetworkInterfaceCount?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#on_demand_max_price_percentage_over_lowest_price Ec2Fleet#on_demand_max_price_percentage_over_lowest_price}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "onDemandMaxPricePercentageOverLowestPrice", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? OnDemandMaxPricePercentageOverLowestPrice
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#require_hibernate_support Ec2Fleet#require_hibernate_support}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "requireHibernateSupport", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? RequireHibernateSupport
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#spot_max_price_percentage_over_lowest_price Ec2Fleet#spot_max_price_percentage_over_lowest_price}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "spotMaxPricePercentageOverLowestPrice", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? SpotMaxPricePercentageOverLowestPrice
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>total_local_storage_gb block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#total_local_storage_gb Ec2Fleet#total_local_storage_gb}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "totalLocalStorageGb", typeJson: "{\"fqn\":\"aws.ec2Fleet.Ec2FleetLaunchTemplateConfigOverrideInstanceRequirementsTotalLocalStorageGb\"}", isOptional: true)]
            public aws.Ec2Fleet.IEc2FleetLaunchTemplateConfigOverrideInstanceRequirementsTotalLocalStorageGb? TotalLocalStorageGb
            {
                get => GetInstanceProperty<aws.Ec2Fleet.IEc2FleetLaunchTemplateConfigOverrideInstanceRequirementsTotalLocalStorageGb?>();
            }
        }
    }
}

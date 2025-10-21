using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2Fleet
{
    [JsiiClass(nativeType: typeof(aws.Ec2Fleet.Ec2FleetLaunchTemplateConfigOverrideInstanceRequirementsOutputReference), fullyQualifiedName: "aws.ec2Fleet.Ec2FleetLaunchTemplateConfigOverrideInstanceRequirementsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class Ec2FleetLaunchTemplateConfigOverrideInstanceRequirementsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public Ec2FleetLaunchTemplateConfigOverrideInstanceRequirementsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Ec2FleetLaunchTemplateConfigOverrideInstanceRequirementsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Ec2FleetLaunchTemplateConfigOverrideInstanceRequirementsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAcceleratorCount", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ec2Fleet.Ec2FleetLaunchTemplateConfigOverrideInstanceRequirementsAcceleratorCount\"}}]")]
        public virtual void PutAcceleratorCount(aws.Ec2Fleet.IEc2FleetLaunchTemplateConfigOverrideInstanceRequirementsAcceleratorCount @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Ec2Fleet.IEc2FleetLaunchTemplateConfigOverrideInstanceRequirementsAcceleratorCount)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAcceleratorTotalMemoryMib", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ec2Fleet.Ec2FleetLaunchTemplateConfigOverrideInstanceRequirementsAcceleratorTotalMemoryMib\"}}]")]
        public virtual void PutAcceleratorTotalMemoryMib(aws.Ec2Fleet.IEc2FleetLaunchTemplateConfigOverrideInstanceRequirementsAcceleratorTotalMemoryMib @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Ec2Fleet.IEc2FleetLaunchTemplateConfigOverrideInstanceRequirementsAcceleratorTotalMemoryMib)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBaselineEbsBandwidthMbps", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ec2Fleet.Ec2FleetLaunchTemplateConfigOverrideInstanceRequirementsBaselineEbsBandwidthMbps\"}}]")]
        public virtual void PutBaselineEbsBandwidthMbps(aws.Ec2Fleet.IEc2FleetLaunchTemplateConfigOverrideInstanceRequirementsBaselineEbsBandwidthMbps @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Ec2Fleet.IEc2FleetLaunchTemplateConfigOverrideInstanceRequirementsBaselineEbsBandwidthMbps)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMemoryGibPerVcpu", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ec2Fleet.Ec2FleetLaunchTemplateConfigOverrideInstanceRequirementsMemoryGibPerVcpu\"}}]")]
        public virtual void PutMemoryGibPerVcpu(aws.Ec2Fleet.IEc2FleetLaunchTemplateConfigOverrideInstanceRequirementsMemoryGibPerVcpu @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Ec2Fleet.IEc2FleetLaunchTemplateConfigOverrideInstanceRequirementsMemoryGibPerVcpu)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMemoryMib", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ec2Fleet.Ec2FleetLaunchTemplateConfigOverrideInstanceRequirementsMemoryMib\"}}]")]
        public virtual void PutMemoryMib(aws.Ec2Fleet.IEc2FleetLaunchTemplateConfigOverrideInstanceRequirementsMemoryMib @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Ec2Fleet.IEc2FleetLaunchTemplateConfigOverrideInstanceRequirementsMemoryMib)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNetworkBandwidthGbps", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ec2Fleet.Ec2FleetLaunchTemplateConfigOverrideInstanceRequirementsNetworkBandwidthGbps\"}}]")]
        public virtual void PutNetworkBandwidthGbps(aws.Ec2Fleet.IEc2FleetLaunchTemplateConfigOverrideInstanceRequirementsNetworkBandwidthGbps @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Ec2Fleet.IEc2FleetLaunchTemplateConfigOverrideInstanceRequirementsNetworkBandwidthGbps)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNetworkInterfaceCount", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ec2Fleet.Ec2FleetLaunchTemplateConfigOverrideInstanceRequirementsNetworkInterfaceCount\"}}]")]
        public virtual void PutNetworkInterfaceCount(aws.Ec2Fleet.IEc2FleetLaunchTemplateConfigOverrideInstanceRequirementsNetworkInterfaceCount @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Ec2Fleet.IEc2FleetLaunchTemplateConfigOverrideInstanceRequirementsNetworkInterfaceCount)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTotalLocalStorageGb", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ec2Fleet.Ec2FleetLaunchTemplateConfigOverrideInstanceRequirementsTotalLocalStorageGb\"}}]")]
        public virtual void PutTotalLocalStorageGb(aws.Ec2Fleet.IEc2FleetLaunchTemplateConfigOverrideInstanceRequirementsTotalLocalStorageGb @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Ec2Fleet.IEc2FleetLaunchTemplateConfigOverrideInstanceRequirementsTotalLocalStorageGb)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVcpuCount", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ec2Fleet.Ec2FleetLaunchTemplateConfigOverrideInstanceRequirementsVcpuCount\"}}]")]
        public virtual void PutVcpuCount(aws.Ec2Fleet.IEc2FleetLaunchTemplateConfigOverrideInstanceRequirementsVcpuCount @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Ec2Fleet.IEc2FleetLaunchTemplateConfigOverrideInstanceRequirementsVcpuCount)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAcceleratorCount")]
        public virtual void ResetAcceleratorCount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAcceleratorManufacturers")]
        public virtual void ResetAcceleratorManufacturers()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAcceleratorNames")]
        public virtual void ResetAcceleratorNames()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAcceleratorTotalMemoryMib")]
        public virtual void ResetAcceleratorTotalMemoryMib()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAcceleratorTypes")]
        public virtual void ResetAcceleratorTypes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAllowedInstanceTypes")]
        public virtual void ResetAllowedInstanceTypes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBareMetal")]
        public virtual void ResetBareMetal()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBaselineEbsBandwidthMbps")]
        public virtual void ResetBaselineEbsBandwidthMbps()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBurstablePerformance")]
        public virtual void ResetBurstablePerformance()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCpuManufacturers")]
        public virtual void ResetCpuManufacturers()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExcludedInstanceTypes")]
        public virtual void ResetExcludedInstanceTypes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInstanceGenerations")]
        public virtual void ResetInstanceGenerations()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLocalStorage")]
        public virtual void ResetLocalStorage()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLocalStorageTypes")]
        public virtual void ResetLocalStorageTypes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxSpotPriceAsPercentageOfOptimalOnDemandPrice")]
        public virtual void ResetMaxSpotPriceAsPercentageOfOptimalOnDemandPrice()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMemoryGibPerVcpu")]
        public virtual void ResetMemoryGibPerVcpu()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetworkBandwidthGbps")]
        public virtual void ResetNetworkBandwidthGbps()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetworkInterfaceCount")]
        public virtual void ResetNetworkInterfaceCount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOnDemandMaxPricePercentageOverLowestPrice")]
        public virtual void ResetOnDemandMaxPricePercentageOverLowestPrice()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRequireHibernateSupport")]
        public virtual void ResetRequireHibernateSupport()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSpotMaxPricePercentageOverLowestPrice")]
        public virtual void ResetSpotMaxPricePercentageOverLowestPrice()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTotalLocalStorageGb")]
        public virtual void ResetTotalLocalStorageGb()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "acceleratorCount", typeJson: "{\"fqn\":\"aws.ec2Fleet.Ec2FleetLaunchTemplateConfigOverrideInstanceRequirementsAcceleratorCountOutputReference\"}")]
        public virtual aws.Ec2Fleet.Ec2FleetLaunchTemplateConfigOverrideInstanceRequirementsAcceleratorCountOutputReference AcceleratorCount
        {
            get => GetInstanceProperty<aws.Ec2Fleet.Ec2FleetLaunchTemplateConfigOverrideInstanceRequirementsAcceleratorCountOutputReference>()!;
        }

        [JsiiProperty(name: "acceleratorTotalMemoryMib", typeJson: "{\"fqn\":\"aws.ec2Fleet.Ec2FleetLaunchTemplateConfigOverrideInstanceRequirementsAcceleratorTotalMemoryMibOutputReference\"}")]
        public virtual aws.Ec2Fleet.Ec2FleetLaunchTemplateConfigOverrideInstanceRequirementsAcceleratorTotalMemoryMibOutputReference AcceleratorTotalMemoryMib
        {
            get => GetInstanceProperty<aws.Ec2Fleet.Ec2FleetLaunchTemplateConfigOverrideInstanceRequirementsAcceleratorTotalMemoryMibOutputReference>()!;
        }

        [JsiiProperty(name: "baselineEbsBandwidthMbps", typeJson: "{\"fqn\":\"aws.ec2Fleet.Ec2FleetLaunchTemplateConfigOverrideInstanceRequirementsBaselineEbsBandwidthMbpsOutputReference\"}")]
        public virtual aws.Ec2Fleet.Ec2FleetLaunchTemplateConfigOverrideInstanceRequirementsBaselineEbsBandwidthMbpsOutputReference BaselineEbsBandwidthMbps
        {
            get => GetInstanceProperty<aws.Ec2Fleet.Ec2FleetLaunchTemplateConfigOverrideInstanceRequirementsBaselineEbsBandwidthMbpsOutputReference>()!;
        }

        [JsiiProperty(name: "memoryGibPerVcpu", typeJson: "{\"fqn\":\"aws.ec2Fleet.Ec2FleetLaunchTemplateConfigOverrideInstanceRequirementsMemoryGibPerVcpuOutputReference\"}")]
        public virtual aws.Ec2Fleet.Ec2FleetLaunchTemplateConfigOverrideInstanceRequirementsMemoryGibPerVcpuOutputReference MemoryGibPerVcpu
        {
            get => GetInstanceProperty<aws.Ec2Fleet.Ec2FleetLaunchTemplateConfigOverrideInstanceRequirementsMemoryGibPerVcpuOutputReference>()!;
        }

        [JsiiProperty(name: "memoryMib", typeJson: "{\"fqn\":\"aws.ec2Fleet.Ec2FleetLaunchTemplateConfigOverrideInstanceRequirementsMemoryMibOutputReference\"}")]
        public virtual aws.Ec2Fleet.Ec2FleetLaunchTemplateConfigOverrideInstanceRequirementsMemoryMibOutputReference MemoryMib
        {
            get => GetInstanceProperty<aws.Ec2Fleet.Ec2FleetLaunchTemplateConfigOverrideInstanceRequirementsMemoryMibOutputReference>()!;
        }

        [JsiiProperty(name: "networkBandwidthGbps", typeJson: "{\"fqn\":\"aws.ec2Fleet.Ec2FleetLaunchTemplateConfigOverrideInstanceRequirementsNetworkBandwidthGbpsOutputReference\"}")]
        public virtual aws.Ec2Fleet.Ec2FleetLaunchTemplateConfigOverrideInstanceRequirementsNetworkBandwidthGbpsOutputReference NetworkBandwidthGbps
        {
            get => GetInstanceProperty<aws.Ec2Fleet.Ec2FleetLaunchTemplateConfigOverrideInstanceRequirementsNetworkBandwidthGbpsOutputReference>()!;
        }

        [JsiiProperty(name: "networkInterfaceCount", typeJson: "{\"fqn\":\"aws.ec2Fleet.Ec2FleetLaunchTemplateConfigOverrideInstanceRequirementsNetworkInterfaceCountOutputReference\"}")]
        public virtual aws.Ec2Fleet.Ec2FleetLaunchTemplateConfigOverrideInstanceRequirementsNetworkInterfaceCountOutputReference NetworkInterfaceCount
        {
            get => GetInstanceProperty<aws.Ec2Fleet.Ec2FleetLaunchTemplateConfigOverrideInstanceRequirementsNetworkInterfaceCountOutputReference>()!;
        }

        [JsiiProperty(name: "totalLocalStorageGb", typeJson: "{\"fqn\":\"aws.ec2Fleet.Ec2FleetLaunchTemplateConfigOverrideInstanceRequirementsTotalLocalStorageGbOutputReference\"}")]
        public virtual aws.Ec2Fleet.Ec2FleetLaunchTemplateConfigOverrideInstanceRequirementsTotalLocalStorageGbOutputReference TotalLocalStorageGb
        {
            get => GetInstanceProperty<aws.Ec2Fleet.Ec2FleetLaunchTemplateConfigOverrideInstanceRequirementsTotalLocalStorageGbOutputReference>()!;
        }

        [JsiiProperty(name: "vcpuCount", typeJson: "{\"fqn\":\"aws.ec2Fleet.Ec2FleetLaunchTemplateConfigOverrideInstanceRequirementsVcpuCountOutputReference\"}")]
        public virtual aws.Ec2Fleet.Ec2FleetLaunchTemplateConfigOverrideInstanceRequirementsVcpuCountOutputReference VcpuCount
        {
            get => GetInstanceProperty<aws.Ec2Fleet.Ec2FleetLaunchTemplateConfigOverrideInstanceRequirementsVcpuCountOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "acceleratorCountInput", typeJson: "{\"fqn\":\"aws.ec2Fleet.Ec2FleetLaunchTemplateConfigOverrideInstanceRequirementsAcceleratorCount\"}", isOptional: true)]
        public virtual aws.Ec2Fleet.IEc2FleetLaunchTemplateConfigOverrideInstanceRequirementsAcceleratorCount? AcceleratorCountInput
        {
            get => GetInstanceProperty<aws.Ec2Fleet.IEc2FleetLaunchTemplateConfigOverrideInstanceRequirementsAcceleratorCount?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "acceleratorManufacturersInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? AcceleratorManufacturersInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "acceleratorNamesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? AcceleratorNamesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "acceleratorTotalMemoryMibInput", typeJson: "{\"fqn\":\"aws.ec2Fleet.Ec2FleetLaunchTemplateConfigOverrideInstanceRequirementsAcceleratorTotalMemoryMib\"}", isOptional: true)]
        public virtual aws.Ec2Fleet.IEc2FleetLaunchTemplateConfigOverrideInstanceRequirementsAcceleratorTotalMemoryMib? AcceleratorTotalMemoryMibInput
        {
            get => GetInstanceProperty<aws.Ec2Fleet.IEc2FleetLaunchTemplateConfigOverrideInstanceRequirementsAcceleratorTotalMemoryMib?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "acceleratorTypesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? AcceleratorTypesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "allowedInstanceTypesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? AllowedInstanceTypesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "bareMetalInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BareMetalInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "baselineEbsBandwidthMbpsInput", typeJson: "{\"fqn\":\"aws.ec2Fleet.Ec2FleetLaunchTemplateConfigOverrideInstanceRequirementsBaselineEbsBandwidthMbps\"}", isOptional: true)]
        public virtual aws.Ec2Fleet.IEc2FleetLaunchTemplateConfigOverrideInstanceRequirementsBaselineEbsBandwidthMbps? BaselineEbsBandwidthMbpsInput
        {
            get => GetInstanceProperty<aws.Ec2Fleet.IEc2FleetLaunchTemplateConfigOverrideInstanceRequirementsBaselineEbsBandwidthMbps?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "burstablePerformanceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BurstablePerformanceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cpuManufacturersInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? CpuManufacturersInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "excludedInstanceTypesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? ExcludedInstanceTypesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceGenerationsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? InstanceGenerationsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "localStorageInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LocalStorageInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "localStorageTypesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? LocalStorageTypesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxSpotPriceAsPercentageOfOptimalOnDemandPriceInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxSpotPriceAsPercentageOfOptimalOnDemandPriceInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "memoryGibPerVcpuInput", typeJson: "{\"fqn\":\"aws.ec2Fleet.Ec2FleetLaunchTemplateConfigOverrideInstanceRequirementsMemoryGibPerVcpu\"}", isOptional: true)]
        public virtual aws.Ec2Fleet.IEc2FleetLaunchTemplateConfigOverrideInstanceRequirementsMemoryGibPerVcpu? MemoryGibPerVcpuInput
        {
            get => GetInstanceProperty<aws.Ec2Fleet.IEc2FleetLaunchTemplateConfigOverrideInstanceRequirementsMemoryGibPerVcpu?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "memoryMibInput", typeJson: "{\"fqn\":\"aws.ec2Fleet.Ec2FleetLaunchTemplateConfigOverrideInstanceRequirementsMemoryMib\"}", isOptional: true)]
        public virtual aws.Ec2Fleet.IEc2FleetLaunchTemplateConfigOverrideInstanceRequirementsMemoryMib? MemoryMibInput
        {
            get => GetInstanceProperty<aws.Ec2Fleet.IEc2FleetLaunchTemplateConfigOverrideInstanceRequirementsMemoryMib?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkBandwidthGbpsInput", typeJson: "{\"fqn\":\"aws.ec2Fleet.Ec2FleetLaunchTemplateConfigOverrideInstanceRequirementsNetworkBandwidthGbps\"}", isOptional: true)]
        public virtual aws.Ec2Fleet.IEc2FleetLaunchTemplateConfigOverrideInstanceRequirementsNetworkBandwidthGbps? NetworkBandwidthGbpsInput
        {
            get => GetInstanceProperty<aws.Ec2Fleet.IEc2FleetLaunchTemplateConfigOverrideInstanceRequirementsNetworkBandwidthGbps?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkInterfaceCountInput", typeJson: "{\"fqn\":\"aws.ec2Fleet.Ec2FleetLaunchTemplateConfigOverrideInstanceRequirementsNetworkInterfaceCount\"}", isOptional: true)]
        public virtual aws.Ec2Fleet.IEc2FleetLaunchTemplateConfigOverrideInstanceRequirementsNetworkInterfaceCount? NetworkInterfaceCountInput
        {
            get => GetInstanceProperty<aws.Ec2Fleet.IEc2FleetLaunchTemplateConfigOverrideInstanceRequirementsNetworkInterfaceCount?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "onDemandMaxPricePercentageOverLowestPriceInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? OnDemandMaxPricePercentageOverLowestPriceInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "requireHibernateSupportInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? RequireHibernateSupportInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "spotMaxPricePercentageOverLowestPriceInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? SpotMaxPricePercentageOverLowestPriceInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "totalLocalStorageGbInput", typeJson: "{\"fqn\":\"aws.ec2Fleet.Ec2FleetLaunchTemplateConfigOverrideInstanceRequirementsTotalLocalStorageGb\"}", isOptional: true)]
        public virtual aws.Ec2Fleet.IEc2FleetLaunchTemplateConfigOverrideInstanceRequirementsTotalLocalStorageGb? TotalLocalStorageGbInput
        {
            get => GetInstanceProperty<aws.Ec2Fleet.IEc2FleetLaunchTemplateConfigOverrideInstanceRequirementsTotalLocalStorageGb?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vcpuCountInput", typeJson: "{\"fqn\":\"aws.ec2Fleet.Ec2FleetLaunchTemplateConfigOverrideInstanceRequirementsVcpuCount\"}", isOptional: true)]
        public virtual aws.Ec2Fleet.IEc2FleetLaunchTemplateConfigOverrideInstanceRequirementsVcpuCount? VcpuCountInput
        {
            get => GetInstanceProperty<aws.Ec2Fleet.IEc2FleetLaunchTemplateConfigOverrideInstanceRequirementsVcpuCount?>();
        }

        [JsiiProperty(name: "acceleratorManufacturers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AcceleratorManufacturers
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "acceleratorNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AcceleratorNames
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "acceleratorTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AcceleratorTypes
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "allowedInstanceTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AllowedInstanceTypes
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "bareMetal", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BareMetal
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "burstablePerformance", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BurstablePerformance
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "cpuManufacturers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] CpuManufacturers
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "excludedInstanceTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ExcludedInstanceTypes
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "instanceGenerations", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] InstanceGenerations
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "localStorage", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LocalStorage
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "localStorageTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] LocalStorageTypes
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxSpotPriceAsPercentageOfOptimalOnDemandPrice", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxSpotPriceAsPercentageOfOptimalOnDemandPrice
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "onDemandMaxPricePercentageOverLowestPrice", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double OnDemandMaxPricePercentageOverLowestPrice
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "requireHibernateSupport", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object RequireHibernateSupport
        {
            get => GetInstanceProperty<object>()!;
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
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "spotMaxPricePercentageOverLowestPrice", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SpotMaxPricePercentageOverLowestPrice
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.ec2Fleet.Ec2FleetLaunchTemplateConfigOverrideInstanceRequirements\"}", isOptional: true)]
        public virtual aws.Ec2Fleet.IEc2FleetLaunchTemplateConfigOverrideInstanceRequirements? InternalValue
        {
            get => GetInstanceProperty<aws.Ec2Fleet.IEc2FleetLaunchTemplateConfigOverrideInstanceRequirements?>();
            set => SetInstanceProperty(value);
        }
    }
}

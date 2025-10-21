using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LaunchTemplate
{
    [JsiiClass(nativeType: typeof(aws.LaunchTemplate.LaunchTemplateInstanceRequirementsOutputReference), fullyQualifiedName: "aws.launchTemplate.LaunchTemplateInstanceRequirementsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class LaunchTemplateInstanceRequirementsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public LaunchTemplateInstanceRequirementsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected LaunchTemplateInstanceRequirementsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LaunchTemplateInstanceRequirementsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAcceleratorCount", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.launchTemplate.LaunchTemplateInstanceRequirementsAcceleratorCount\"}}]")]
        public virtual void PutAcceleratorCount(aws.LaunchTemplate.ILaunchTemplateInstanceRequirementsAcceleratorCount @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LaunchTemplate.ILaunchTemplateInstanceRequirementsAcceleratorCount)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAcceleratorTotalMemoryMib", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.launchTemplate.LaunchTemplateInstanceRequirementsAcceleratorTotalMemoryMib\"}}]")]
        public virtual void PutAcceleratorTotalMemoryMib(aws.LaunchTemplate.ILaunchTemplateInstanceRequirementsAcceleratorTotalMemoryMib @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LaunchTemplate.ILaunchTemplateInstanceRequirementsAcceleratorTotalMemoryMib)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBaselineEbsBandwidthMbps", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.launchTemplate.LaunchTemplateInstanceRequirementsBaselineEbsBandwidthMbps\"}}]")]
        public virtual void PutBaselineEbsBandwidthMbps(aws.LaunchTemplate.ILaunchTemplateInstanceRequirementsBaselineEbsBandwidthMbps @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LaunchTemplate.ILaunchTemplateInstanceRequirementsBaselineEbsBandwidthMbps)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMemoryGibPerVcpu", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.launchTemplate.LaunchTemplateInstanceRequirementsMemoryGibPerVcpu\"}}]")]
        public virtual void PutMemoryGibPerVcpu(aws.LaunchTemplate.ILaunchTemplateInstanceRequirementsMemoryGibPerVcpu @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LaunchTemplate.ILaunchTemplateInstanceRequirementsMemoryGibPerVcpu)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMemoryMib", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.launchTemplate.LaunchTemplateInstanceRequirementsMemoryMib\"}}]")]
        public virtual void PutMemoryMib(aws.LaunchTemplate.ILaunchTemplateInstanceRequirementsMemoryMib @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LaunchTemplate.ILaunchTemplateInstanceRequirementsMemoryMib)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNetworkBandwidthGbps", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.launchTemplate.LaunchTemplateInstanceRequirementsNetworkBandwidthGbps\"}}]")]
        public virtual void PutNetworkBandwidthGbps(aws.LaunchTemplate.ILaunchTemplateInstanceRequirementsNetworkBandwidthGbps @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LaunchTemplate.ILaunchTemplateInstanceRequirementsNetworkBandwidthGbps)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNetworkInterfaceCount", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.launchTemplate.LaunchTemplateInstanceRequirementsNetworkInterfaceCount\"}}]")]
        public virtual void PutNetworkInterfaceCount(aws.LaunchTemplate.ILaunchTemplateInstanceRequirementsNetworkInterfaceCount @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LaunchTemplate.ILaunchTemplateInstanceRequirementsNetworkInterfaceCount)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTotalLocalStorageGb", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.launchTemplate.LaunchTemplateInstanceRequirementsTotalLocalStorageGb\"}}]")]
        public virtual void PutTotalLocalStorageGb(aws.LaunchTemplate.ILaunchTemplateInstanceRequirementsTotalLocalStorageGb @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LaunchTemplate.ILaunchTemplateInstanceRequirementsTotalLocalStorageGb)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVcpuCount", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.launchTemplate.LaunchTemplateInstanceRequirementsVcpuCount\"}}]")]
        public virtual void PutVcpuCount(aws.LaunchTemplate.ILaunchTemplateInstanceRequirementsVcpuCount @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LaunchTemplate.ILaunchTemplateInstanceRequirementsVcpuCount)}, new object[]{@value});
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

        [JsiiProperty(name: "acceleratorCount", typeJson: "{\"fqn\":\"aws.launchTemplate.LaunchTemplateInstanceRequirementsAcceleratorCountOutputReference\"}")]
        public virtual aws.LaunchTemplate.LaunchTemplateInstanceRequirementsAcceleratorCountOutputReference AcceleratorCount
        {
            get => GetInstanceProperty<aws.LaunchTemplate.LaunchTemplateInstanceRequirementsAcceleratorCountOutputReference>()!;
        }

        [JsiiProperty(name: "acceleratorTotalMemoryMib", typeJson: "{\"fqn\":\"aws.launchTemplate.LaunchTemplateInstanceRequirementsAcceleratorTotalMemoryMibOutputReference\"}")]
        public virtual aws.LaunchTemplate.LaunchTemplateInstanceRequirementsAcceleratorTotalMemoryMibOutputReference AcceleratorTotalMemoryMib
        {
            get => GetInstanceProperty<aws.LaunchTemplate.LaunchTemplateInstanceRequirementsAcceleratorTotalMemoryMibOutputReference>()!;
        }

        [JsiiProperty(name: "baselineEbsBandwidthMbps", typeJson: "{\"fqn\":\"aws.launchTemplate.LaunchTemplateInstanceRequirementsBaselineEbsBandwidthMbpsOutputReference\"}")]
        public virtual aws.LaunchTemplate.LaunchTemplateInstanceRequirementsBaselineEbsBandwidthMbpsOutputReference BaselineEbsBandwidthMbps
        {
            get => GetInstanceProperty<aws.LaunchTemplate.LaunchTemplateInstanceRequirementsBaselineEbsBandwidthMbpsOutputReference>()!;
        }

        [JsiiProperty(name: "memoryGibPerVcpu", typeJson: "{\"fqn\":\"aws.launchTemplate.LaunchTemplateInstanceRequirementsMemoryGibPerVcpuOutputReference\"}")]
        public virtual aws.LaunchTemplate.LaunchTemplateInstanceRequirementsMemoryGibPerVcpuOutputReference MemoryGibPerVcpu
        {
            get => GetInstanceProperty<aws.LaunchTemplate.LaunchTemplateInstanceRequirementsMemoryGibPerVcpuOutputReference>()!;
        }

        [JsiiProperty(name: "memoryMib", typeJson: "{\"fqn\":\"aws.launchTemplate.LaunchTemplateInstanceRequirementsMemoryMibOutputReference\"}")]
        public virtual aws.LaunchTemplate.LaunchTemplateInstanceRequirementsMemoryMibOutputReference MemoryMib
        {
            get => GetInstanceProperty<aws.LaunchTemplate.LaunchTemplateInstanceRequirementsMemoryMibOutputReference>()!;
        }

        [JsiiProperty(name: "networkBandwidthGbps", typeJson: "{\"fqn\":\"aws.launchTemplate.LaunchTemplateInstanceRequirementsNetworkBandwidthGbpsOutputReference\"}")]
        public virtual aws.LaunchTemplate.LaunchTemplateInstanceRequirementsNetworkBandwidthGbpsOutputReference NetworkBandwidthGbps
        {
            get => GetInstanceProperty<aws.LaunchTemplate.LaunchTemplateInstanceRequirementsNetworkBandwidthGbpsOutputReference>()!;
        }

        [JsiiProperty(name: "networkInterfaceCount", typeJson: "{\"fqn\":\"aws.launchTemplate.LaunchTemplateInstanceRequirementsNetworkInterfaceCountOutputReference\"}")]
        public virtual aws.LaunchTemplate.LaunchTemplateInstanceRequirementsNetworkInterfaceCountOutputReference NetworkInterfaceCount
        {
            get => GetInstanceProperty<aws.LaunchTemplate.LaunchTemplateInstanceRequirementsNetworkInterfaceCountOutputReference>()!;
        }

        [JsiiProperty(name: "totalLocalStorageGb", typeJson: "{\"fqn\":\"aws.launchTemplate.LaunchTemplateInstanceRequirementsTotalLocalStorageGbOutputReference\"}")]
        public virtual aws.LaunchTemplate.LaunchTemplateInstanceRequirementsTotalLocalStorageGbOutputReference TotalLocalStorageGb
        {
            get => GetInstanceProperty<aws.LaunchTemplate.LaunchTemplateInstanceRequirementsTotalLocalStorageGbOutputReference>()!;
        }

        [JsiiProperty(name: "vcpuCount", typeJson: "{\"fqn\":\"aws.launchTemplate.LaunchTemplateInstanceRequirementsVcpuCountOutputReference\"}")]
        public virtual aws.LaunchTemplate.LaunchTemplateInstanceRequirementsVcpuCountOutputReference VcpuCount
        {
            get => GetInstanceProperty<aws.LaunchTemplate.LaunchTemplateInstanceRequirementsVcpuCountOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "acceleratorCountInput", typeJson: "{\"fqn\":\"aws.launchTemplate.LaunchTemplateInstanceRequirementsAcceleratorCount\"}", isOptional: true)]
        public virtual aws.LaunchTemplate.ILaunchTemplateInstanceRequirementsAcceleratorCount? AcceleratorCountInput
        {
            get => GetInstanceProperty<aws.LaunchTemplate.ILaunchTemplateInstanceRequirementsAcceleratorCount?>();
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
        [JsiiProperty(name: "acceleratorTotalMemoryMibInput", typeJson: "{\"fqn\":\"aws.launchTemplate.LaunchTemplateInstanceRequirementsAcceleratorTotalMemoryMib\"}", isOptional: true)]
        public virtual aws.LaunchTemplate.ILaunchTemplateInstanceRequirementsAcceleratorTotalMemoryMib? AcceleratorTotalMemoryMibInput
        {
            get => GetInstanceProperty<aws.LaunchTemplate.ILaunchTemplateInstanceRequirementsAcceleratorTotalMemoryMib?>();
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
        [JsiiProperty(name: "baselineEbsBandwidthMbpsInput", typeJson: "{\"fqn\":\"aws.launchTemplate.LaunchTemplateInstanceRequirementsBaselineEbsBandwidthMbps\"}", isOptional: true)]
        public virtual aws.LaunchTemplate.ILaunchTemplateInstanceRequirementsBaselineEbsBandwidthMbps? BaselineEbsBandwidthMbpsInput
        {
            get => GetInstanceProperty<aws.LaunchTemplate.ILaunchTemplateInstanceRequirementsBaselineEbsBandwidthMbps?>();
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
        [JsiiProperty(name: "memoryGibPerVcpuInput", typeJson: "{\"fqn\":\"aws.launchTemplate.LaunchTemplateInstanceRequirementsMemoryGibPerVcpu\"}", isOptional: true)]
        public virtual aws.LaunchTemplate.ILaunchTemplateInstanceRequirementsMemoryGibPerVcpu? MemoryGibPerVcpuInput
        {
            get => GetInstanceProperty<aws.LaunchTemplate.ILaunchTemplateInstanceRequirementsMemoryGibPerVcpu?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "memoryMibInput", typeJson: "{\"fqn\":\"aws.launchTemplate.LaunchTemplateInstanceRequirementsMemoryMib\"}", isOptional: true)]
        public virtual aws.LaunchTemplate.ILaunchTemplateInstanceRequirementsMemoryMib? MemoryMibInput
        {
            get => GetInstanceProperty<aws.LaunchTemplate.ILaunchTemplateInstanceRequirementsMemoryMib?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkBandwidthGbpsInput", typeJson: "{\"fqn\":\"aws.launchTemplate.LaunchTemplateInstanceRequirementsNetworkBandwidthGbps\"}", isOptional: true)]
        public virtual aws.LaunchTemplate.ILaunchTemplateInstanceRequirementsNetworkBandwidthGbps? NetworkBandwidthGbpsInput
        {
            get => GetInstanceProperty<aws.LaunchTemplate.ILaunchTemplateInstanceRequirementsNetworkBandwidthGbps?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkInterfaceCountInput", typeJson: "{\"fqn\":\"aws.launchTemplate.LaunchTemplateInstanceRequirementsNetworkInterfaceCount\"}", isOptional: true)]
        public virtual aws.LaunchTemplate.ILaunchTemplateInstanceRequirementsNetworkInterfaceCount? NetworkInterfaceCountInput
        {
            get => GetInstanceProperty<aws.LaunchTemplate.ILaunchTemplateInstanceRequirementsNetworkInterfaceCount?>();
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
        [JsiiProperty(name: "totalLocalStorageGbInput", typeJson: "{\"fqn\":\"aws.launchTemplate.LaunchTemplateInstanceRequirementsTotalLocalStorageGb\"}", isOptional: true)]
        public virtual aws.LaunchTemplate.ILaunchTemplateInstanceRequirementsTotalLocalStorageGb? TotalLocalStorageGbInput
        {
            get => GetInstanceProperty<aws.LaunchTemplate.ILaunchTemplateInstanceRequirementsTotalLocalStorageGb?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vcpuCountInput", typeJson: "{\"fqn\":\"aws.launchTemplate.LaunchTemplateInstanceRequirementsVcpuCount\"}", isOptional: true)]
        public virtual aws.LaunchTemplate.ILaunchTemplateInstanceRequirementsVcpuCount? VcpuCountInput
        {
            get => GetInstanceProperty<aws.LaunchTemplate.ILaunchTemplateInstanceRequirementsVcpuCount?>();
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.launchTemplate.LaunchTemplateInstanceRequirements\"}", isOptional: true)]
        public virtual aws.LaunchTemplate.ILaunchTemplateInstanceRequirements? InternalValue
        {
            get => GetInstanceProperty<aws.LaunchTemplate.ILaunchTemplateInstanceRequirements?>();
            set => SetInstanceProperty(value);
        }
    }
}

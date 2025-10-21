using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SpotFleetRequest
{
    [JsiiClass(nativeType: typeof(aws.SpotFleetRequest.SpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsOutputReference), fullyQualifiedName: "aws.spotFleetRequest.SpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected SpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAcceleratorCount", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.spotFleetRequest.SpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsAcceleratorCount\"}}]")]
        public virtual void PutAcceleratorCount(aws.SpotFleetRequest.ISpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsAcceleratorCount @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SpotFleetRequest.ISpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsAcceleratorCount)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAcceleratorTotalMemoryMib", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.spotFleetRequest.SpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsAcceleratorTotalMemoryMib\"}}]")]
        public virtual void PutAcceleratorTotalMemoryMib(aws.SpotFleetRequest.ISpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsAcceleratorTotalMemoryMib @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SpotFleetRequest.ISpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsAcceleratorTotalMemoryMib)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBaselineEbsBandwidthMbps", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.spotFleetRequest.SpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsBaselineEbsBandwidthMbps\"}}]")]
        public virtual void PutBaselineEbsBandwidthMbps(aws.SpotFleetRequest.ISpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsBaselineEbsBandwidthMbps @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SpotFleetRequest.ISpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsBaselineEbsBandwidthMbps)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMemoryGibPerVcpu", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.spotFleetRequest.SpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsMemoryGibPerVcpu\"}}]")]
        public virtual void PutMemoryGibPerVcpu(aws.SpotFleetRequest.ISpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsMemoryGibPerVcpu @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SpotFleetRequest.ISpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsMemoryGibPerVcpu)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMemoryMib", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.spotFleetRequest.SpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsMemoryMib\"}}]")]
        public virtual void PutMemoryMib(aws.SpotFleetRequest.ISpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsMemoryMib @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SpotFleetRequest.ISpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsMemoryMib)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNetworkBandwidthGbps", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.spotFleetRequest.SpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsNetworkBandwidthGbps\"}}]")]
        public virtual void PutNetworkBandwidthGbps(aws.SpotFleetRequest.ISpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsNetworkBandwidthGbps @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SpotFleetRequest.ISpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsNetworkBandwidthGbps)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNetworkInterfaceCount", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.spotFleetRequest.SpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsNetworkInterfaceCount\"}}]")]
        public virtual void PutNetworkInterfaceCount(aws.SpotFleetRequest.ISpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsNetworkInterfaceCount @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SpotFleetRequest.ISpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsNetworkInterfaceCount)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTotalLocalStorageGb", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.spotFleetRequest.SpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsTotalLocalStorageGb\"}}]")]
        public virtual void PutTotalLocalStorageGb(aws.SpotFleetRequest.ISpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsTotalLocalStorageGb @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SpotFleetRequest.ISpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsTotalLocalStorageGb)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVcpuCount", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.spotFleetRequest.SpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsVcpuCount\"}}]")]
        public virtual void PutVcpuCount(aws.SpotFleetRequest.ISpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsVcpuCount @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SpotFleetRequest.ISpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsVcpuCount)}, new object[]{@value});
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

        [JsiiMethod(name: "resetMemoryGibPerVcpu")]
        public virtual void ResetMemoryGibPerVcpu()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMemoryMib")]
        public virtual void ResetMemoryMib()
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

        [JsiiMethod(name: "resetVcpuCount")]
        public virtual void ResetVcpuCount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "acceleratorCount", typeJson: "{\"fqn\":\"aws.spotFleetRequest.SpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsAcceleratorCountOutputReference\"}")]
        public virtual aws.SpotFleetRequest.SpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsAcceleratorCountOutputReference AcceleratorCount
        {
            get => GetInstanceProperty<aws.SpotFleetRequest.SpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsAcceleratorCountOutputReference>()!;
        }

        [JsiiProperty(name: "acceleratorTotalMemoryMib", typeJson: "{\"fqn\":\"aws.spotFleetRequest.SpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsAcceleratorTotalMemoryMibOutputReference\"}")]
        public virtual aws.SpotFleetRequest.SpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsAcceleratorTotalMemoryMibOutputReference AcceleratorTotalMemoryMib
        {
            get => GetInstanceProperty<aws.SpotFleetRequest.SpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsAcceleratorTotalMemoryMibOutputReference>()!;
        }

        [JsiiProperty(name: "baselineEbsBandwidthMbps", typeJson: "{\"fqn\":\"aws.spotFleetRequest.SpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsBaselineEbsBandwidthMbpsOutputReference\"}")]
        public virtual aws.SpotFleetRequest.SpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsBaselineEbsBandwidthMbpsOutputReference BaselineEbsBandwidthMbps
        {
            get => GetInstanceProperty<aws.SpotFleetRequest.SpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsBaselineEbsBandwidthMbpsOutputReference>()!;
        }

        [JsiiProperty(name: "memoryGibPerVcpu", typeJson: "{\"fqn\":\"aws.spotFleetRequest.SpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsMemoryGibPerVcpuOutputReference\"}")]
        public virtual aws.SpotFleetRequest.SpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsMemoryGibPerVcpuOutputReference MemoryGibPerVcpu
        {
            get => GetInstanceProperty<aws.SpotFleetRequest.SpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsMemoryGibPerVcpuOutputReference>()!;
        }

        [JsiiProperty(name: "memoryMib", typeJson: "{\"fqn\":\"aws.spotFleetRequest.SpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsMemoryMibOutputReference\"}")]
        public virtual aws.SpotFleetRequest.SpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsMemoryMibOutputReference MemoryMib
        {
            get => GetInstanceProperty<aws.SpotFleetRequest.SpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsMemoryMibOutputReference>()!;
        }

        [JsiiProperty(name: "networkBandwidthGbps", typeJson: "{\"fqn\":\"aws.spotFleetRequest.SpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsNetworkBandwidthGbpsOutputReference\"}")]
        public virtual aws.SpotFleetRequest.SpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsNetworkBandwidthGbpsOutputReference NetworkBandwidthGbps
        {
            get => GetInstanceProperty<aws.SpotFleetRequest.SpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsNetworkBandwidthGbpsOutputReference>()!;
        }

        [JsiiProperty(name: "networkInterfaceCount", typeJson: "{\"fqn\":\"aws.spotFleetRequest.SpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsNetworkInterfaceCountOutputReference\"}")]
        public virtual aws.SpotFleetRequest.SpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsNetworkInterfaceCountOutputReference NetworkInterfaceCount
        {
            get => GetInstanceProperty<aws.SpotFleetRequest.SpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsNetworkInterfaceCountOutputReference>()!;
        }

        [JsiiProperty(name: "totalLocalStorageGb", typeJson: "{\"fqn\":\"aws.spotFleetRequest.SpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsTotalLocalStorageGbOutputReference\"}")]
        public virtual aws.SpotFleetRequest.SpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsTotalLocalStorageGbOutputReference TotalLocalStorageGb
        {
            get => GetInstanceProperty<aws.SpotFleetRequest.SpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsTotalLocalStorageGbOutputReference>()!;
        }

        [JsiiProperty(name: "vcpuCount", typeJson: "{\"fqn\":\"aws.spotFleetRequest.SpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsVcpuCountOutputReference\"}")]
        public virtual aws.SpotFleetRequest.SpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsVcpuCountOutputReference VcpuCount
        {
            get => GetInstanceProperty<aws.SpotFleetRequest.SpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsVcpuCountOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "acceleratorCountInput", typeJson: "{\"fqn\":\"aws.spotFleetRequest.SpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsAcceleratorCount\"}", isOptional: true)]
        public virtual aws.SpotFleetRequest.ISpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsAcceleratorCount? AcceleratorCountInput
        {
            get => GetInstanceProperty<aws.SpotFleetRequest.ISpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsAcceleratorCount?>();
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
        [JsiiProperty(name: "acceleratorTotalMemoryMibInput", typeJson: "{\"fqn\":\"aws.spotFleetRequest.SpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsAcceleratorTotalMemoryMib\"}", isOptional: true)]
        public virtual aws.SpotFleetRequest.ISpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsAcceleratorTotalMemoryMib? AcceleratorTotalMemoryMibInput
        {
            get => GetInstanceProperty<aws.SpotFleetRequest.ISpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsAcceleratorTotalMemoryMib?>();
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
        [JsiiProperty(name: "baselineEbsBandwidthMbpsInput", typeJson: "{\"fqn\":\"aws.spotFleetRequest.SpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsBaselineEbsBandwidthMbps\"}", isOptional: true)]
        public virtual aws.SpotFleetRequest.ISpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsBaselineEbsBandwidthMbps? BaselineEbsBandwidthMbpsInput
        {
            get => GetInstanceProperty<aws.SpotFleetRequest.ISpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsBaselineEbsBandwidthMbps?>();
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
        [JsiiProperty(name: "memoryGibPerVcpuInput", typeJson: "{\"fqn\":\"aws.spotFleetRequest.SpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsMemoryGibPerVcpu\"}", isOptional: true)]
        public virtual aws.SpotFleetRequest.ISpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsMemoryGibPerVcpu? MemoryGibPerVcpuInput
        {
            get => GetInstanceProperty<aws.SpotFleetRequest.ISpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsMemoryGibPerVcpu?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "memoryMibInput", typeJson: "{\"fqn\":\"aws.spotFleetRequest.SpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsMemoryMib\"}", isOptional: true)]
        public virtual aws.SpotFleetRequest.ISpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsMemoryMib? MemoryMibInput
        {
            get => GetInstanceProperty<aws.SpotFleetRequest.ISpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsMemoryMib?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkBandwidthGbpsInput", typeJson: "{\"fqn\":\"aws.spotFleetRequest.SpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsNetworkBandwidthGbps\"}", isOptional: true)]
        public virtual aws.SpotFleetRequest.ISpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsNetworkBandwidthGbps? NetworkBandwidthGbpsInput
        {
            get => GetInstanceProperty<aws.SpotFleetRequest.ISpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsNetworkBandwidthGbps?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkInterfaceCountInput", typeJson: "{\"fqn\":\"aws.spotFleetRequest.SpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsNetworkInterfaceCount\"}", isOptional: true)]
        public virtual aws.SpotFleetRequest.ISpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsNetworkInterfaceCount? NetworkInterfaceCountInput
        {
            get => GetInstanceProperty<aws.SpotFleetRequest.ISpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsNetworkInterfaceCount?>();
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
        [JsiiProperty(name: "totalLocalStorageGbInput", typeJson: "{\"fqn\":\"aws.spotFleetRequest.SpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsTotalLocalStorageGb\"}", isOptional: true)]
        public virtual aws.SpotFleetRequest.ISpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsTotalLocalStorageGb? TotalLocalStorageGbInput
        {
            get => GetInstanceProperty<aws.SpotFleetRequest.ISpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsTotalLocalStorageGb?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vcpuCountInput", typeJson: "{\"fqn\":\"aws.spotFleetRequest.SpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsVcpuCount\"}", isOptional: true)]
        public virtual aws.SpotFleetRequest.ISpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsVcpuCount? VcpuCountInput
        {
            get => GetInstanceProperty<aws.SpotFleetRequest.ISpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirementsVcpuCount?>();
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.spotFleetRequest.SpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirements\"}", isOptional: true)]
        public virtual aws.SpotFleetRequest.ISpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirements? InternalValue
        {
            get => GetInstanceProperty<aws.SpotFleetRequest.ISpotFleetRequestLaunchTemplateConfigOverridesInstanceRequirements?>();
            set => SetInstanceProperty(value);
        }
    }
}

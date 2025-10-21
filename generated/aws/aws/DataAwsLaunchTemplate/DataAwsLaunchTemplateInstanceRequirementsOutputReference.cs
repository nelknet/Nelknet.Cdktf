using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsLaunchTemplate
{
    [JsiiClass(nativeType: typeof(aws.DataAwsLaunchTemplate.DataAwsLaunchTemplateInstanceRequirementsOutputReference), fullyQualifiedName: "aws.dataAwsLaunchTemplate.DataAwsLaunchTemplateInstanceRequirementsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAwsLaunchTemplateInstanceRequirementsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAwsLaunchTemplateInstanceRequirementsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsLaunchTemplateInstanceRequirementsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsLaunchTemplateInstanceRequirementsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "acceleratorCount", typeJson: "{\"fqn\":\"aws.dataAwsLaunchTemplate.DataAwsLaunchTemplateInstanceRequirementsAcceleratorCountList\"}")]
        public virtual aws.DataAwsLaunchTemplate.DataAwsLaunchTemplateInstanceRequirementsAcceleratorCountList AcceleratorCount
        {
            get => GetInstanceProperty<aws.DataAwsLaunchTemplate.DataAwsLaunchTemplateInstanceRequirementsAcceleratorCountList>()!;
        }

        [JsiiProperty(name: "acceleratorManufacturers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AcceleratorManufacturers
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "acceleratorNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AcceleratorNames
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "acceleratorTotalMemoryMib", typeJson: "{\"fqn\":\"aws.dataAwsLaunchTemplate.DataAwsLaunchTemplateInstanceRequirementsAcceleratorTotalMemoryMibList\"}")]
        public virtual aws.DataAwsLaunchTemplate.DataAwsLaunchTemplateInstanceRequirementsAcceleratorTotalMemoryMibList AcceleratorTotalMemoryMib
        {
            get => GetInstanceProperty<aws.DataAwsLaunchTemplate.DataAwsLaunchTemplateInstanceRequirementsAcceleratorTotalMemoryMibList>()!;
        }

        [JsiiProperty(name: "acceleratorTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AcceleratorTypes
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "allowedInstanceTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AllowedInstanceTypes
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "bareMetal", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BareMetal
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "baselineEbsBandwidthMbps", typeJson: "{\"fqn\":\"aws.dataAwsLaunchTemplate.DataAwsLaunchTemplateInstanceRequirementsBaselineEbsBandwidthMbpsList\"}")]
        public virtual aws.DataAwsLaunchTemplate.DataAwsLaunchTemplateInstanceRequirementsBaselineEbsBandwidthMbpsList BaselineEbsBandwidthMbps
        {
            get => GetInstanceProperty<aws.DataAwsLaunchTemplate.DataAwsLaunchTemplateInstanceRequirementsBaselineEbsBandwidthMbpsList>()!;
        }

        [JsiiProperty(name: "burstablePerformance", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BurstablePerformance
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "cpuManufacturers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] CpuManufacturers
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "excludedInstanceTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ExcludedInstanceTypes
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "instanceGenerations", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] InstanceGenerations
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "localStorage", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LocalStorage
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "localStorageTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] LocalStorageTypes
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "maxSpotPriceAsPercentageOfOptimalOnDemandPrice", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxSpotPriceAsPercentageOfOptimalOnDemandPrice
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "memoryGibPerVcpu", typeJson: "{\"fqn\":\"aws.dataAwsLaunchTemplate.DataAwsLaunchTemplateInstanceRequirementsMemoryGibPerVcpuList\"}")]
        public virtual aws.DataAwsLaunchTemplate.DataAwsLaunchTemplateInstanceRequirementsMemoryGibPerVcpuList MemoryGibPerVcpu
        {
            get => GetInstanceProperty<aws.DataAwsLaunchTemplate.DataAwsLaunchTemplateInstanceRequirementsMemoryGibPerVcpuList>()!;
        }

        [JsiiProperty(name: "memoryMib", typeJson: "{\"fqn\":\"aws.dataAwsLaunchTemplate.DataAwsLaunchTemplateInstanceRequirementsMemoryMibList\"}")]
        public virtual aws.DataAwsLaunchTemplate.DataAwsLaunchTemplateInstanceRequirementsMemoryMibList MemoryMib
        {
            get => GetInstanceProperty<aws.DataAwsLaunchTemplate.DataAwsLaunchTemplateInstanceRequirementsMemoryMibList>()!;
        }

        [JsiiProperty(name: "networkBandwidthGbps", typeJson: "{\"fqn\":\"aws.dataAwsLaunchTemplate.DataAwsLaunchTemplateInstanceRequirementsNetworkBandwidthGbpsList\"}")]
        public virtual aws.DataAwsLaunchTemplate.DataAwsLaunchTemplateInstanceRequirementsNetworkBandwidthGbpsList NetworkBandwidthGbps
        {
            get => GetInstanceProperty<aws.DataAwsLaunchTemplate.DataAwsLaunchTemplateInstanceRequirementsNetworkBandwidthGbpsList>()!;
        }

        [JsiiProperty(name: "networkInterfaceCount", typeJson: "{\"fqn\":\"aws.dataAwsLaunchTemplate.DataAwsLaunchTemplateInstanceRequirementsNetworkInterfaceCountList\"}")]
        public virtual aws.DataAwsLaunchTemplate.DataAwsLaunchTemplateInstanceRequirementsNetworkInterfaceCountList NetworkInterfaceCount
        {
            get => GetInstanceProperty<aws.DataAwsLaunchTemplate.DataAwsLaunchTemplateInstanceRequirementsNetworkInterfaceCountList>()!;
        }

        [JsiiProperty(name: "onDemandMaxPricePercentageOverLowestPrice", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double OnDemandMaxPricePercentageOverLowestPrice
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "requireHibernateSupport", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable RequireHibernateSupport
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "spotMaxPricePercentageOverLowestPrice", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SpotMaxPricePercentageOverLowestPrice
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "totalLocalStorageGb", typeJson: "{\"fqn\":\"aws.dataAwsLaunchTemplate.DataAwsLaunchTemplateInstanceRequirementsTotalLocalStorageGbList\"}")]
        public virtual aws.DataAwsLaunchTemplate.DataAwsLaunchTemplateInstanceRequirementsTotalLocalStorageGbList TotalLocalStorageGb
        {
            get => GetInstanceProperty<aws.DataAwsLaunchTemplate.DataAwsLaunchTemplateInstanceRequirementsTotalLocalStorageGbList>()!;
        }

        [JsiiProperty(name: "vcpuCount", typeJson: "{\"fqn\":\"aws.dataAwsLaunchTemplate.DataAwsLaunchTemplateInstanceRequirementsVcpuCountList\"}")]
        public virtual aws.DataAwsLaunchTemplate.DataAwsLaunchTemplateInstanceRequirementsVcpuCountList VcpuCount
        {
            get => GetInstanceProperty<aws.DataAwsLaunchTemplate.DataAwsLaunchTemplateInstanceRequirementsVcpuCountList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.dataAwsLaunchTemplate.DataAwsLaunchTemplateInstanceRequirements\"}", isOptional: true)]
        public virtual aws.DataAwsLaunchTemplate.IDataAwsLaunchTemplateInstanceRequirements? InternalValue
        {
            get => GetInstanceProperty<aws.DataAwsLaunchTemplate.IDataAwsLaunchTemplateInstanceRequirements?>();
            set => SetInstanceProperty(value);
        }
    }
}

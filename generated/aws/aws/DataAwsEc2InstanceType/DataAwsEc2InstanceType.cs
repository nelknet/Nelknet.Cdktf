using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsEc2InstanceType
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_instance_type aws_ec2_instance_type}.</summary>
    [JsiiClass(nativeType: typeof(aws.DataAwsEc2InstanceType.DataAwsEc2InstanceType), fullyQualifiedName: "aws.dataAwsEc2InstanceType.DataAwsEc2InstanceType", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.dataAwsEc2InstanceType.DataAwsEc2InstanceTypeConfig\"}}]")]
    public class DataAwsEc2InstanceType : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_instance_type aws_ec2_instance_type} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAwsEc2InstanceType(Constructs.Construct scope, string id, aws.DataAwsEc2InstanceType.IDataAwsEc2InstanceTypeConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.DataAwsEc2InstanceType.IDataAwsEc2InstanceTypeConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsEc2InstanceType(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsEc2InstanceType(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a DataAwsEc2InstanceType resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAwsEc2InstanceType to import.</param>
        /// <param name="importFromId">The id of the existing DataAwsEc2InstanceType that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAwsEc2InstanceType to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAwsEc2InstanceType to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_instance_type#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAwsEc2InstanceType that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAwsEc2InstanceType to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.DataAwsEc2InstanceType.DataAwsEc2InstanceType), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.dataAwsEc2InstanceType.DataAwsEc2InstanceTypeTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.DataAwsEc2InstanceType.IDataAwsEc2InstanceTypeTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.DataAwsEc2InstanceType.IDataAwsEc2InstanceTypeTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "synthesizeHclAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeHclAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(aws.DataAwsEc2InstanceType.DataAwsEc2InstanceType))!;

        [JsiiProperty(name: "autoRecoverySupported", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable AutoRecoverySupported
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "bandwidthWeightings", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] BandwidthWeightings
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "bareMetal", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable BareMetal
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "bootModes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] BootModes
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "burstablePerformanceSupported", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable BurstablePerformanceSupported
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "currentGeneration", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable CurrentGeneration
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "dedicatedHostsSupported", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable DedicatedHostsSupported
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "defaultCores", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DefaultCores
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "defaultNetworkCardIndex", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DefaultNetworkCardIndex
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "defaultThreadsPerCore", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DefaultThreadsPerCore
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "defaultVcpus", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DefaultVcpus
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "ebsEncryptionSupport", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EbsEncryptionSupport
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ebsNvmeSupport", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EbsNvmeSupport
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ebsOptimizedSupport", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EbsOptimizedSupport
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ebsPerformanceBaselineBandwidth", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double EbsPerformanceBaselineBandwidth
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "ebsPerformanceBaselineIops", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double EbsPerformanceBaselineIops
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "ebsPerformanceBaselineThroughput", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double EbsPerformanceBaselineThroughput
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "ebsPerformanceMaximumBandwidth", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double EbsPerformanceMaximumBandwidth
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "ebsPerformanceMaximumIops", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double EbsPerformanceMaximumIops
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "ebsPerformanceMaximumThroughput", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double EbsPerformanceMaximumThroughput
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "efaMaximumInterfaces", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double EfaMaximumInterfaces
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "efaSupported", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable EfaSupported
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "enaSrdSupported", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable EnaSrdSupported
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "enaSupport", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EnaSupport
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "encryptionInTransitSupported", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable EncryptionInTransitSupported
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "fpgas", typeJson: "{\"fqn\":\"aws.dataAwsEc2InstanceType.DataAwsEc2InstanceTypeFpgasList\"}")]
        public virtual aws.DataAwsEc2InstanceType.DataAwsEc2InstanceTypeFpgasList Fpgas
        {
            get => GetInstanceProperty<aws.DataAwsEc2InstanceType.DataAwsEc2InstanceTypeFpgasList>()!;
        }

        [JsiiProperty(name: "freeTierEligible", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable FreeTierEligible
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "gpus", typeJson: "{\"fqn\":\"aws.dataAwsEc2InstanceType.DataAwsEc2InstanceTypeGpusList\"}")]
        public virtual aws.DataAwsEc2InstanceType.DataAwsEc2InstanceTypeGpusList Gpus
        {
            get => GetInstanceProperty<aws.DataAwsEc2InstanceType.DataAwsEc2InstanceTypeGpusList>()!;
        }

        [JsiiProperty(name: "hibernationSupported", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable HibernationSupported
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "hypervisor", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Hypervisor
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "inferenceAccelerators", typeJson: "{\"fqn\":\"aws.dataAwsEc2InstanceType.DataAwsEc2InstanceTypeInferenceAcceleratorsList\"}")]
        public virtual aws.DataAwsEc2InstanceType.DataAwsEc2InstanceTypeInferenceAcceleratorsList InferenceAccelerators
        {
            get => GetInstanceProperty<aws.DataAwsEc2InstanceType.DataAwsEc2InstanceTypeInferenceAcceleratorsList>()!;
        }

        [JsiiProperty(name: "instanceDisks", typeJson: "{\"fqn\":\"aws.dataAwsEc2InstanceType.DataAwsEc2InstanceTypeInstanceDisksList\"}")]
        public virtual aws.DataAwsEc2InstanceType.DataAwsEc2InstanceTypeInstanceDisksList InstanceDisks
        {
            get => GetInstanceProperty<aws.DataAwsEc2InstanceType.DataAwsEc2InstanceTypeInstanceDisksList>()!;
        }

        [JsiiProperty(name: "instanceStorageSupported", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable InstanceStorageSupported
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "ipv6Supported", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable Ipv6Supported
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "maximumIpv4AddressesPerInterface", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaximumIpv4AddressesPerInterface
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "maximumIpv6AddressesPerInterface", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaximumIpv6AddressesPerInterface
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "maximumNetworkCards", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaximumNetworkCards
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "maximumNetworkInterfaces", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaximumNetworkInterfaces
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "mediaAccelerators", typeJson: "{\"fqn\":\"aws.dataAwsEc2InstanceType.DataAwsEc2InstanceTypeMediaAcceleratorsList\"}")]
        public virtual aws.DataAwsEc2InstanceType.DataAwsEc2InstanceTypeMediaAcceleratorsList MediaAccelerators
        {
            get => GetInstanceProperty<aws.DataAwsEc2InstanceType.DataAwsEc2InstanceTypeMediaAcceleratorsList>()!;
        }

        [JsiiProperty(name: "memorySize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MemorySize
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "networkCards", typeJson: "{\"fqn\":\"aws.dataAwsEc2InstanceType.DataAwsEc2InstanceTypeNetworkCardsList\"}")]
        public virtual aws.DataAwsEc2InstanceType.DataAwsEc2InstanceTypeNetworkCardsList NetworkCards
        {
            get => GetInstanceProperty<aws.DataAwsEc2InstanceType.DataAwsEc2InstanceTypeNetworkCardsList>()!;
        }

        [JsiiProperty(name: "networkPerformance", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NetworkPerformance
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "neuronDevices", typeJson: "{\"fqn\":\"aws.dataAwsEc2InstanceType.DataAwsEc2InstanceTypeNeuronDevicesList\"}")]
        public virtual aws.DataAwsEc2InstanceType.DataAwsEc2InstanceTypeNeuronDevicesList NeuronDevices
        {
            get => GetInstanceProperty<aws.DataAwsEc2InstanceType.DataAwsEc2InstanceTypeNeuronDevicesList>()!;
        }

        [JsiiProperty(name: "nitroEnclavesSupport", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NitroEnclavesSupport
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nitroTpmSupport", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NitroTpmSupport
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nitroTpmSupportedVersions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] NitroTpmSupportedVersions
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "phcSupport", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PhcSupport
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "supportedArchitectures", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SupportedArchitectures
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "supportedCpuFeatures", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SupportedCpuFeatures
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "supportedPlacementStrategies", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SupportedPlacementStrategies
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "supportedRootDeviceTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SupportedRootDeviceTypes
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "supportedUsagesClasses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SupportedUsagesClasses
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "supportedVirtualizationTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SupportedVirtualizationTypes
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "sustainedClockSpeed", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SustainedClockSpeed
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.dataAwsEc2InstanceType.DataAwsEc2InstanceTypeTimeoutsOutputReference\"}")]
        public virtual aws.DataAwsEc2InstanceType.DataAwsEc2InstanceTypeTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.DataAwsEc2InstanceType.DataAwsEc2InstanceTypeTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "totalFpgaMemory", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TotalFpgaMemory
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "totalGpuMemory", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TotalGpuMemory
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "totalInferenceMemory", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TotalInferenceMemory
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "totalInstanceStorage", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TotalInstanceStorage
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "totalMediaMemory", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TotalMediaMemory
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "totalNeuronDeviceMemory", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TotalNeuronDeviceMemory
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "validCores", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}")]
        public virtual double[] ValidCores
        {
            get => GetInstanceProperty<double[]>()!;
        }

        [JsiiProperty(name: "validThreadsPerCore", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}")]
        public virtual double[] ValidThreadsPerCore
        {
            get => GetInstanceProperty<double[]>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InstanceTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.dataAwsEc2InstanceType.DataAwsEc2InstanceTypeTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}

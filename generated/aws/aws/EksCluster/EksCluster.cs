using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EksCluster
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_cluster aws_eks_cluster}.</summary>
    [JsiiClass(nativeType: typeof(aws.EksCluster.EksCluster), fullyQualifiedName: "aws.eksCluster.EksCluster", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.eksCluster.EksClusterConfig\"}}]")]
    public class EksCluster : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_cluster aws_eks_cluster} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public EksCluster(Constructs.Construct scope, string id, aws.EksCluster.IEksClusterConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.EksCluster.IEksClusterConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EksCluster(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EksCluster(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a EksCluster resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the EksCluster to import.</param>
        /// <param name="importFromId">The id of the existing EksCluster that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the EksCluster to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the EksCluster to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_cluster#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing EksCluster that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the EksCluster to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.EksCluster.EksCluster), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAccessConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.eksCluster.EksClusterAccessConfig\"}}]")]
        public virtual void PutAccessConfig(aws.EksCluster.IEksClusterAccessConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.EksCluster.IEksClusterAccessConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putComputeConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.eksCluster.EksClusterComputeConfig\"}}]")]
        public virtual void PutComputeConfig(aws.EksCluster.IEksClusterComputeConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.EksCluster.IEksClusterComputeConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEncryptionConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.eksCluster.EksClusterEncryptionConfig\"}}]")]
        public virtual void PutEncryptionConfig(aws.EksCluster.IEksClusterEncryptionConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.EksCluster.IEksClusterEncryptionConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putKubernetesNetworkConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.eksCluster.EksClusterKubernetesNetworkConfig\"}}]")]
        public virtual void PutKubernetesNetworkConfig(aws.EksCluster.IEksClusterKubernetesNetworkConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.EksCluster.IEksClusterKubernetesNetworkConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOutpostConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.eksCluster.EksClusterOutpostConfig\"}}]")]
        public virtual void PutOutpostConfig(aws.EksCluster.IEksClusterOutpostConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.EksCluster.IEksClusterOutpostConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRemoteNetworkConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.eksCluster.EksClusterRemoteNetworkConfig\"}}]")]
        public virtual void PutRemoteNetworkConfig(aws.EksCluster.IEksClusterRemoteNetworkConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.EksCluster.IEksClusterRemoteNetworkConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStorageConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.eksCluster.EksClusterStorageConfig\"}}]")]
        public virtual void PutStorageConfig(aws.EksCluster.IEksClusterStorageConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.EksCluster.IEksClusterStorageConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.eksCluster.EksClusterTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.EksCluster.IEksClusterTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.EksCluster.IEksClusterTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUpgradePolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.eksCluster.EksClusterUpgradePolicy\"}}]")]
        public virtual void PutUpgradePolicy(aws.EksCluster.IEksClusterUpgradePolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.EksCluster.IEksClusterUpgradePolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVpcConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.eksCluster.EksClusterVpcConfig\"}}]")]
        public virtual void PutVpcConfig(aws.EksCluster.IEksClusterVpcConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.EksCluster.IEksClusterVpcConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putZonalShiftConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.eksCluster.EksClusterZonalShiftConfig\"}}]")]
        public virtual void PutZonalShiftConfig(aws.EksCluster.IEksClusterZonalShiftConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.EksCluster.IEksClusterZonalShiftConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAccessConfig")]
        public virtual void ResetAccessConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBootstrapSelfManagedAddons")]
        public virtual void ResetBootstrapSelfManagedAddons()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetComputeConfig")]
        public virtual void ResetComputeConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnabledClusterLogTypes")]
        public virtual void ResetEnabledClusterLogTypes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEncryptionConfig")]
        public virtual void ResetEncryptionConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetForceUpdateVersion")]
        public virtual void ResetForceUpdateVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKubernetesNetworkConfig")]
        public virtual void ResetKubernetesNetworkConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOutpostConfig")]
        public virtual void ResetOutpostConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRemoteNetworkConfig")]
        public virtual void ResetRemoteNetworkConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStorageConfig")]
        public virtual void ResetStorageConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTagsAll")]
        public virtual void ResetTagsAll()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUpgradePolicy")]
        public virtual void ResetUpgradePolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVersion")]
        public virtual void ResetVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetZonalShiftConfig")]
        public virtual void ResetZonalShiftConfig()
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
        = GetStaticProperty<string>(typeof(aws.EksCluster.EksCluster))!;

        [JsiiProperty(name: "accessConfig", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterAccessConfigOutputReference\"}")]
        public virtual aws.EksCluster.EksClusterAccessConfigOutputReference AccessConfig
        {
            get => GetInstanceProperty<aws.EksCluster.EksClusterAccessConfigOutputReference>()!;
        }

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "certificateAuthority", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterCertificateAuthorityList\"}")]
        public virtual aws.EksCluster.EksClusterCertificateAuthorityList CertificateAuthority
        {
            get => GetInstanceProperty<aws.EksCluster.EksClusterCertificateAuthorityList>()!;
        }

        [JsiiProperty(name: "clusterId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "computeConfig", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterComputeConfigOutputReference\"}")]
        public virtual aws.EksCluster.EksClusterComputeConfigOutputReference ComputeConfig
        {
            get => GetInstanceProperty<aws.EksCluster.EksClusterComputeConfigOutputReference>()!;
        }

        [JsiiProperty(name: "createdAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "encryptionConfig", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterEncryptionConfigOutputReference\"}")]
        public virtual aws.EksCluster.EksClusterEncryptionConfigOutputReference EncryptionConfig
        {
            get => GetInstanceProperty<aws.EksCluster.EksClusterEncryptionConfigOutputReference>()!;
        }

        [JsiiProperty(name: "endpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Endpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterIdentityList\"}")]
        public virtual aws.EksCluster.EksClusterIdentityList Identity
        {
            get => GetInstanceProperty<aws.EksCluster.EksClusterIdentityList>()!;
        }

        [JsiiProperty(name: "kubernetesNetworkConfig", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterKubernetesNetworkConfigOutputReference\"}")]
        public virtual aws.EksCluster.EksClusterKubernetesNetworkConfigOutputReference KubernetesNetworkConfig
        {
            get => GetInstanceProperty<aws.EksCluster.EksClusterKubernetesNetworkConfigOutputReference>()!;
        }

        [JsiiProperty(name: "outpostConfig", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterOutpostConfigOutputReference\"}")]
        public virtual aws.EksCluster.EksClusterOutpostConfigOutputReference OutpostConfig
        {
            get => GetInstanceProperty<aws.EksCluster.EksClusterOutpostConfigOutputReference>()!;
        }

        [JsiiProperty(name: "platformVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PlatformVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "remoteNetworkConfig", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterRemoteNetworkConfigOutputReference\"}")]
        public virtual aws.EksCluster.EksClusterRemoteNetworkConfigOutputReference RemoteNetworkConfig
        {
            get => GetInstanceProperty<aws.EksCluster.EksClusterRemoteNetworkConfigOutputReference>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "storageConfig", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterStorageConfigOutputReference\"}")]
        public virtual aws.EksCluster.EksClusterStorageConfigOutputReference StorageConfig
        {
            get => GetInstanceProperty<aws.EksCluster.EksClusterStorageConfigOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterTimeoutsOutputReference\"}")]
        public virtual aws.EksCluster.EksClusterTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.EksCluster.EksClusterTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "upgradePolicy", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterUpgradePolicyOutputReference\"}")]
        public virtual aws.EksCluster.EksClusterUpgradePolicyOutputReference UpgradePolicy
        {
            get => GetInstanceProperty<aws.EksCluster.EksClusterUpgradePolicyOutputReference>()!;
        }

        [JsiiProperty(name: "vpcConfig", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterVpcConfigOutputReference\"}")]
        public virtual aws.EksCluster.EksClusterVpcConfigOutputReference VpcConfig
        {
            get => GetInstanceProperty<aws.EksCluster.EksClusterVpcConfigOutputReference>()!;
        }

        [JsiiProperty(name: "zonalShiftConfig", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterZonalShiftConfigOutputReference\"}")]
        public virtual aws.EksCluster.EksClusterZonalShiftConfigOutputReference ZonalShiftConfig
        {
            get => GetInstanceProperty<aws.EksCluster.EksClusterZonalShiftConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accessConfigInput", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterAccessConfig\"}", isOptional: true)]
        public virtual aws.EksCluster.IEksClusterAccessConfig? AccessConfigInput
        {
            get => GetInstanceProperty<aws.EksCluster.IEksClusterAccessConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "bootstrapSelfManagedAddonsInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? BootstrapSelfManagedAddonsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "computeConfigInput", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterComputeConfig\"}", isOptional: true)]
        public virtual aws.EksCluster.IEksClusterComputeConfig? ComputeConfigInput
        {
            get => GetInstanceProperty<aws.EksCluster.IEksClusterComputeConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "enabledClusterLogTypesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? EnabledClusterLogTypesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "encryptionConfigInput", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterEncryptionConfig\"}", isOptional: true)]
        public virtual aws.EksCluster.IEksClusterEncryptionConfig? EncryptionConfigInput
        {
            get => GetInstanceProperty<aws.EksCluster.IEksClusterEncryptionConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "forceUpdateVersionInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ForceUpdateVersionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kubernetesNetworkConfigInput", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterKubernetesNetworkConfig\"}", isOptional: true)]
        public virtual aws.EksCluster.IEksClusterKubernetesNetworkConfig? KubernetesNetworkConfigInput
        {
            get => GetInstanceProperty<aws.EksCluster.IEksClusterKubernetesNetworkConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "outpostConfigInput", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterOutpostConfig\"}", isOptional: true)]
        public virtual aws.EksCluster.IEksClusterOutpostConfig? OutpostConfigInput
        {
            get => GetInstanceProperty<aws.EksCluster.IEksClusterOutpostConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "remoteNetworkConfigInput", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterRemoteNetworkConfig\"}", isOptional: true)]
        public virtual aws.EksCluster.IEksClusterRemoteNetworkConfig? RemoteNetworkConfigInput
        {
            get => GetInstanceProperty<aws.EksCluster.IEksClusterRemoteNetworkConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "roleArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RoleArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "storageConfigInput", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterStorageConfig\"}", isOptional: true)]
        public virtual aws.EksCluster.IEksClusterStorageConfig? StorageConfigInput
        {
            get => GetInstanceProperty<aws.EksCluster.IEksClusterStorageConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsAllInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsAllInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.eksCluster.EksClusterTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "upgradePolicyInput", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterUpgradePolicy\"}", isOptional: true)]
        public virtual aws.EksCluster.IEksClusterUpgradePolicy? UpgradePolicyInput
        {
            get => GetInstanceProperty<aws.EksCluster.IEksClusterUpgradePolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "versionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vpcConfigInput", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterVpcConfig\"}", isOptional: true)]
        public virtual aws.EksCluster.IEksClusterVpcConfig? VpcConfigInput
        {
            get => GetInstanceProperty<aws.EksCluster.IEksClusterVpcConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "zonalShiftConfigInput", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterZonalShiftConfig\"}", isOptional: true)]
        public virtual aws.EksCluster.IEksClusterZonalShiftConfig? ZonalShiftConfigInput
        {
            get => GetInstanceProperty<aws.EksCluster.IEksClusterZonalShiftConfig?>();
        }

        [JsiiProperty(name: "bootstrapSelfManagedAddons", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object BootstrapSelfManagedAddons
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

        [JsiiProperty(name: "enabledClusterLogTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] EnabledClusterLogTypes
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "forceUpdateVersion", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object ForceUpdateVersion
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

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RoleArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tagsAll", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> TagsAll
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Version
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}

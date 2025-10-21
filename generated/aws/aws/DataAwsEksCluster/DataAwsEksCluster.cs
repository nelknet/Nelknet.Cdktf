using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsEksCluster
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/eks_cluster aws_eks_cluster}.</summary>
    [JsiiClass(nativeType: typeof(aws.DataAwsEksCluster.DataAwsEksCluster), fullyQualifiedName: "aws.dataAwsEksCluster.DataAwsEksCluster", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.dataAwsEksCluster.DataAwsEksClusterConfig\"}}]")]
    public class DataAwsEksCluster : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/eks_cluster aws_eks_cluster} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAwsEksCluster(Constructs.Construct scope, string id, aws.DataAwsEksCluster.IDataAwsEksClusterConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.DataAwsEksCluster.IDataAwsEksClusterConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsEksCluster(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsEksCluster(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a DataAwsEksCluster resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAwsEksCluster to import.</param>
        /// <param name="importFromId">The id of the existing DataAwsEksCluster that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAwsEksCluster to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAwsEksCluster to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/eks_cluster#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAwsEksCluster that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAwsEksCluster to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.DataAwsEksCluster.DataAwsEksCluster), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
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
        = GetStaticProperty<string>(typeof(aws.DataAwsEksCluster.DataAwsEksCluster))!;

        [JsiiProperty(name: "accessConfig", typeJson: "{\"fqn\":\"aws.dataAwsEksCluster.DataAwsEksClusterAccessConfigList\"}")]
        public virtual aws.DataAwsEksCluster.DataAwsEksClusterAccessConfigList AccessConfig
        {
            get => GetInstanceProperty<aws.DataAwsEksCluster.DataAwsEksClusterAccessConfigList>()!;
        }

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "certificateAuthority", typeJson: "{\"fqn\":\"aws.dataAwsEksCluster.DataAwsEksClusterCertificateAuthorityList\"}")]
        public virtual aws.DataAwsEksCluster.DataAwsEksClusterCertificateAuthorityList CertificateAuthority
        {
            get => GetInstanceProperty<aws.DataAwsEksCluster.DataAwsEksClusterCertificateAuthorityList>()!;
        }

        [JsiiProperty(name: "clusterId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "computeConfig", typeJson: "{\"fqn\":\"aws.dataAwsEksCluster.DataAwsEksClusterComputeConfigList\"}")]
        public virtual aws.DataAwsEksCluster.DataAwsEksClusterComputeConfigList ComputeConfig
        {
            get => GetInstanceProperty<aws.DataAwsEksCluster.DataAwsEksClusterComputeConfigList>()!;
        }

        [JsiiProperty(name: "createdAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "enabledClusterLogTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] EnabledClusterLogTypes
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "endpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Endpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"aws.dataAwsEksCluster.DataAwsEksClusterIdentityList\"}")]
        public virtual aws.DataAwsEksCluster.DataAwsEksClusterIdentityList Identity
        {
            get => GetInstanceProperty<aws.DataAwsEksCluster.DataAwsEksClusterIdentityList>()!;
        }

        [JsiiProperty(name: "kubernetesNetworkConfig", typeJson: "{\"fqn\":\"aws.dataAwsEksCluster.DataAwsEksClusterKubernetesNetworkConfigList\"}")]
        public virtual aws.DataAwsEksCluster.DataAwsEksClusterKubernetesNetworkConfigList KubernetesNetworkConfig
        {
            get => GetInstanceProperty<aws.DataAwsEksCluster.DataAwsEksClusterKubernetesNetworkConfigList>()!;
        }

        [JsiiProperty(name: "outpostConfig", typeJson: "{\"fqn\":\"aws.dataAwsEksCluster.DataAwsEksClusterOutpostConfigList\"}")]
        public virtual aws.DataAwsEksCluster.DataAwsEksClusterOutpostConfigList OutpostConfig
        {
            get => GetInstanceProperty<aws.DataAwsEksCluster.DataAwsEksClusterOutpostConfigList>()!;
        }

        [JsiiProperty(name: "platformVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PlatformVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "remoteNetworkConfig", typeJson: "{\"fqn\":\"aws.dataAwsEksCluster.DataAwsEksClusterRemoteNetworkConfigList\"}")]
        public virtual aws.DataAwsEksCluster.DataAwsEksClusterRemoteNetworkConfigList RemoteNetworkConfig
        {
            get => GetInstanceProperty<aws.DataAwsEksCluster.DataAwsEksClusterRemoteNetworkConfigList>()!;
        }

        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RoleArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "storageConfig", typeJson: "{\"fqn\":\"aws.dataAwsEksCluster.DataAwsEksClusterStorageConfigList\"}")]
        public virtual aws.DataAwsEksCluster.DataAwsEksClusterStorageConfigList StorageConfig
        {
            get => GetInstanceProperty<aws.DataAwsEksCluster.DataAwsEksClusterStorageConfigList>()!;
        }

        [JsiiProperty(name: "upgradePolicy", typeJson: "{\"fqn\":\"aws.dataAwsEksCluster.DataAwsEksClusterUpgradePolicyList\"}")]
        public virtual aws.DataAwsEksCluster.DataAwsEksClusterUpgradePolicyList UpgradePolicy
        {
            get => GetInstanceProperty<aws.DataAwsEksCluster.DataAwsEksClusterUpgradePolicyList>()!;
        }

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Version
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vpcConfig", typeJson: "{\"fqn\":\"aws.dataAwsEksCluster.DataAwsEksClusterVpcConfigList\"}")]
        public virtual aws.DataAwsEksCluster.DataAwsEksClusterVpcConfigList VpcConfig
        {
            get => GetInstanceProperty<aws.DataAwsEksCluster.DataAwsEksClusterVpcConfigList>()!;
        }

        [JsiiProperty(name: "zonalShiftConfig", typeJson: "{\"fqn\":\"aws.dataAwsEksCluster.DataAwsEksClusterZonalShiftConfigList\"}")]
        public virtual aws.DataAwsEksCluster.DataAwsEksClusterZonalShiftConfigList ZonalShiftConfig
        {
            get => GetInstanceProperty<aws.DataAwsEksCluster.DataAwsEksClusterZonalShiftConfigList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
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

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }
    }
}

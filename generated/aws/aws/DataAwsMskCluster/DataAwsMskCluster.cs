using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsMskCluster
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/msk_cluster aws_msk_cluster}.</summary>
    [JsiiClass(nativeType: typeof(aws.DataAwsMskCluster.DataAwsMskCluster), fullyQualifiedName: "aws.dataAwsMskCluster.DataAwsMskCluster", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.dataAwsMskCluster.DataAwsMskClusterConfig\"}}]")]
    public class DataAwsMskCluster : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/msk_cluster aws_msk_cluster} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAwsMskCluster(Constructs.Construct scope, string id, aws.DataAwsMskCluster.IDataAwsMskClusterConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.DataAwsMskCluster.IDataAwsMskClusterConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsMskCluster(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsMskCluster(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a DataAwsMskCluster resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAwsMskCluster to import.</param>
        /// <param name="importFromId">The id of the existing DataAwsMskCluster that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAwsMskCluster to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAwsMskCluster to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/msk_cluster#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAwsMskCluster that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAwsMskCluster to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.DataAwsMskCluster.DataAwsMskCluster), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(aws.DataAwsMskCluster.DataAwsMskCluster))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "bootstrapBrokers", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BootstrapBrokers
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "bootstrapBrokersPublicSaslIam", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BootstrapBrokersPublicSaslIam
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "bootstrapBrokersPublicSaslScram", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BootstrapBrokersPublicSaslScram
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "bootstrapBrokersPublicTls", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BootstrapBrokersPublicTls
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "bootstrapBrokersSaslIam", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BootstrapBrokersSaslIam
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "bootstrapBrokersSaslScram", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BootstrapBrokersSaslScram
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "bootstrapBrokersTls", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BootstrapBrokersTls
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "brokerNodeGroupInfo", typeJson: "{\"fqn\":\"aws.dataAwsMskCluster.DataAwsMskClusterBrokerNodeGroupInfoList\"}")]
        public virtual aws.DataAwsMskCluster.DataAwsMskClusterBrokerNodeGroupInfoList BrokerNodeGroupInfo
        {
            get => GetInstanceProperty<aws.DataAwsMskCluster.DataAwsMskClusterBrokerNodeGroupInfoList>()!;
        }

        [JsiiProperty(name: "clusterUuid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterUuid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "kafkaVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KafkaVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "numberOfBrokerNodes", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NumberOfBrokerNodes
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "zookeeperConnectString", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ZookeeperConnectString
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "zookeeperConnectStringTls", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ZookeeperConnectStringTls
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "clusterNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClusterNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiProperty(name: "clusterName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
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

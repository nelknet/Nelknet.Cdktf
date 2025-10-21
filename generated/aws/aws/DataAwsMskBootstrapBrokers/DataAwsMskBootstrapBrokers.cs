using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsMskBootstrapBrokers
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/msk_bootstrap_brokers aws_msk_bootstrap_brokers}.</summary>
    [JsiiClass(nativeType: typeof(aws.DataAwsMskBootstrapBrokers.DataAwsMskBootstrapBrokers), fullyQualifiedName: "aws.dataAwsMskBootstrapBrokers.DataAwsMskBootstrapBrokers", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.dataAwsMskBootstrapBrokers.DataAwsMskBootstrapBrokersConfig\"}}]")]
    public class DataAwsMskBootstrapBrokers : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/msk_bootstrap_brokers aws_msk_bootstrap_brokers} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAwsMskBootstrapBrokers(Constructs.Construct scope, string id, aws.DataAwsMskBootstrapBrokers.IDataAwsMskBootstrapBrokersConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.DataAwsMskBootstrapBrokers.IDataAwsMskBootstrapBrokersConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsMskBootstrapBrokers(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsMskBootstrapBrokers(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a DataAwsMskBootstrapBrokers resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAwsMskBootstrapBrokers to import.</param>
        /// <param name="importFromId">The id of the existing DataAwsMskBootstrapBrokers that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAwsMskBootstrapBrokers to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAwsMskBootstrapBrokers to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/msk_bootstrap_brokers#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAwsMskBootstrapBrokers that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAwsMskBootstrapBrokers to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.DataAwsMskBootstrapBrokers.DataAwsMskBootstrapBrokers), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
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
        = GetStaticProperty<string>(typeof(aws.DataAwsMskBootstrapBrokers.DataAwsMskBootstrapBrokers))!;

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

        [JsiiProperty(name: "bootstrapBrokersVpcConnectivitySaslIam", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BootstrapBrokersVpcConnectivitySaslIam
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "bootstrapBrokersVpcConnectivitySaslScram", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BootstrapBrokersVpcConnectivitySaslScram
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "bootstrapBrokersVpcConnectivityTls", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BootstrapBrokersVpcConnectivityTls
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "clusterArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClusterArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "clusterArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterArn
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
    }
}

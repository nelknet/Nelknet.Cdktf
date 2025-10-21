using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsElasticsearchDomain
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/elasticsearch_domain aws_elasticsearch_domain}.</summary>
    [JsiiClass(nativeType: typeof(aws.DataAwsElasticsearchDomain.DataAwsElasticsearchDomain), fullyQualifiedName: "aws.dataAwsElasticsearchDomain.DataAwsElasticsearchDomain", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.dataAwsElasticsearchDomain.DataAwsElasticsearchDomainConfig\"}}]")]
    public class DataAwsElasticsearchDomain : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/elasticsearch_domain aws_elasticsearch_domain} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAwsElasticsearchDomain(Constructs.Construct scope, string id, aws.DataAwsElasticsearchDomain.IDataAwsElasticsearchDomainConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.DataAwsElasticsearchDomain.IDataAwsElasticsearchDomainConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsElasticsearchDomain(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsElasticsearchDomain(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a DataAwsElasticsearchDomain resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAwsElasticsearchDomain to import.</param>
        /// <param name="importFromId">The id of the existing DataAwsElasticsearchDomain that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAwsElasticsearchDomain to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAwsElasticsearchDomain to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/elasticsearch_domain#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAwsElasticsearchDomain that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAwsElasticsearchDomain to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.DataAwsElasticsearchDomain.DataAwsElasticsearchDomain), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(aws.DataAwsElasticsearchDomain.DataAwsElasticsearchDomain))!;

        [JsiiProperty(name: "accessPolicies", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccessPolicies
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "advancedOptions", typeJson: "{\"fqn\":\"cdktf.StringMap\"}")]
        public virtual HashiCorp.Cdktf.StringMap AdvancedOptions
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.StringMap>()!;
        }

        [JsiiProperty(name: "advancedSecurityOptions", typeJson: "{\"fqn\":\"aws.dataAwsElasticsearchDomain.DataAwsElasticsearchDomainAdvancedSecurityOptionsList\"}")]
        public virtual aws.DataAwsElasticsearchDomain.DataAwsElasticsearchDomainAdvancedSecurityOptionsList AdvancedSecurityOptions
        {
            get => GetInstanceProperty<aws.DataAwsElasticsearchDomain.DataAwsElasticsearchDomainAdvancedSecurityOptionsList>()!;
        }

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "autoTuneOptions", typeJson: "{\"fqn\":\"aws.dataAwsElasticsearchDomain.DataAwsElasticsearchDomainAutoTuneOptionsList\"}")]
        public virtual aws.DataAwsElasticsearchDomain.DataAwsElasticsearchDomainAutoTuneOptionsList AutoTuneOptions
        {
            get => GetInstanceProperty<aws.DataAwsElasticsearchDomain.DataAwsElasticsearchDomainAutoTuneOptionsList>()!;
        }

        [JsiiProperty(name: "clusterConfig", typeJson: "{\"fqn\":\"aws.dataAwsElasticsearchDomain.DataAwsElasticsearchDomainClusterConfigList\"}")]
        public virtual aws.DataAwsElasticsearchDomain.DataAwsElasticsearchDomainClusterConfigList ClusterConfig
        {
            get => GetInstanceProperty<aws.DataAwsElasticsearchDomain.DataAwsElasticsearchDomainClusterConfigList>()!;
        }

        [JsiiProperty(name: "cognitoOptions", typeJson: "{\"fqn\":\"aws.dataAwsElasticsearchDomain.DataAwsElasticsearchDomainCognitoOptionsList\"}")]
        public virtual aws.DataAwsElasticsearchDomain.DataAwsElasticsearchDomainCognitoOptionsList CognitoOptions
        {
            get => GetInstanceProperty<aws.DataAwsElasticsearchDomain.DataAwsElasticsearchDomainCognitoOptionsList>()!;
        }

        [JsiiProperty(name: "created", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable Created
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "deleted", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable Deleted
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "domainId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DomainId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ebsOptions", typeJson: "{\"fqn\":\"aws.dataAwsElasticsearchDomain.DataAwsElasticsearchDomainEbsOptionsList\"}")]
        public virtual aws.DataAwsElasticsearchDomain.DataAwsElasticsearchDomainEbsOptionsList EbsOptions
        {
            get => GetInstanceProperty<aws.DataAwsElasticsearchDomain.DataAwsElasticsearchDomainEbsOptionsList>()!;
        }

        [JsiiProperty(name: "elasticsearchVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ElasticsearchVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "encryptionAtRest", typeJson: "{\"fqn\":\"aws.dataAwsElasticsearchDomain.DataAwsElasticsearchDomainEncryptionAtRestList\"}")]
        public virtual aws.DataAwsElasticsearchDomain.DataAwsElasticsearchDomainEncryptionAtRestList EncryptionAtRest
        {
            get => GetInstanceProperty<aws.DataAwsElasticsearchDomain.DataAwsElasticsearchDomainEncryptionAtRestList>()!;
        }

        [JsiiProperty(name: "endpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Endpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "kibanaEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KibanaEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "logPublishingOptions", typeJson: "{\"fqn\":\"aws.dataAwsElasticsearchDomain.DataAwsElasticsearchDomainLogPublishingOptionsList\"}")]
        public virtual aws.DataAwsElasticsearchDomain.DataAwsElasticsearchDomainLogPublishingOptionsList LogPublishingOptions
        {
            get => GetInstanceProperty<aws.DataAwsElasticsearchDomain.DataAwsElasticsearchDomainLogPublishingOptionsList>()!;
        }

        [JsiiProperty(name: "nodeToNodeEncryption", typeJson: "{\"fqn\":\"aws.dataAwsElasticsearchDomain.DataAwsElasticsearchDomainNodeToNodeEncryptionList\"}")]
        public virtual aws.DataAwsElasticsearchDomain.DataAwsElasticsearchDomainNodeToNodeEncryptionList NodeToNodeEncryption
        {
            get => GetInstanceProperty<aws.DataAwsElasticsearchDomain.DataAwsElasticsearchDomainNodeToNodeEncryptionList>()!;
        }

        [JsiiProperty(name: "processing", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable Processing
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "snapshotOptions", typeJson: "{\"fqn\":\"aws.dataAwsElasticsearchDomain.DataAwsElasticsearchDomainSnapshotOptionsList\"}")]
        public virtual aws.DataAwsElasticsearchDomain.DataAwsElasticsearchDomainSnapshotOptionsList SnapshotOptions
        {
            get => GetInstanceProperty<aws.DataAwsElasticsearchDomain.DataAwsElasticsearchDomainSnapshotOptionsList>()!;
        }

        [JsiiProperty(name: "vpcOptions", typeJson: "{\"fqn\":\"aws.dataAwsElasticsearchDomain.DataAwsElasticsearchDomainVpcOptionsList\"}")]
        public virtual aws.DataAwsElasticsearchDomain.DataAwsElasticsearchDomainVpcOptionsList VpcOptions
        {
            get => GetInstanceProperty<aws.DataAwsElasticsearchDomain.DataAwsElasticsearchDomainVpcOptionsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "domainNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DomainNameInput
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

        [JsiiProperty(name: "domainName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DomainName
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

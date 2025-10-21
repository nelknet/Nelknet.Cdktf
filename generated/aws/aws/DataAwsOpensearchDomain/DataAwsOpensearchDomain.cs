using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsOpensearchDomain
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/opensearch_domain aws_opensearch_domain}.</summary>
    [JsiiClass(nativeType: typeof(aws.DataAwsOpensearchDomain.DataAwsOpensearchDomain), fullyQualifiedName: "aws.dataAwsOpensearchDomain.DataAwsOpensearchDomain", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.dataAwsOpensearchDomain.DataAwsOpensearchDomainConfig\"}}]")]
    public class DataAwsOpensearchDomain : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/opensearch_domain aws_opensearch_domain} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAwsOpensearchDomain(Constructs.Construct scope, string id, aws.DataAwsOpensearchDomain.IDataAwsOpensearchDomainConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.DataAwsOpensearchDomain.IDataAwsOpensearchDomainConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsOpensearchDomain(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsOpensearchDomain(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a DataAwsOpensearchDomain resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAwsOpensearchDomain to import.</param>
        /// <param name="importFromId">The id of the existing DataAwsOpensearchDomain that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAwsOpensearchDomain to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAwsOpensearchDomain to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/opensearch_domain#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAwsOpensearchDomain that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAwsOpensearchDomain to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.DataAwsOpensearchDomain.DataAwsOpensearchDomain), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putOffPeakWindowOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.dataAwsOpensearchDomain.DataAwsOpensearchDomainOffPeakWindowOptions\"}}]")]
        public virtual void PutOffPeakWindowOptions(aws.DataAwsOpensearchDomain.IDataAwsOpensearchDomainOffPeakWindowOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.DataAwsOpensearchDomain.IDataAwsOpensearchDomainOffPeakWindowOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOffPeakWindowOptions")]
        public virtual void ResetOffPeakWindowOptions()
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
        = GetStaticProperty<string>(typeof(aws.DataAwsOpensearchDomain.DataAwsOpensearchDomain))!;

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

        [JsiiProperty(name: "advancedSecurityOptions", typeJson: "{\"fqn\":\"aws.dataAwsOpensearchDomain.DataAwsOpensearchDomainAdvancedSecurityOptionsList\"}")]
        public virtual aws.DataAwsOpensearchDomain.DataAwsOpensearchDomainAdvancedSecurityOptionsList AdvancedSecurityOptions
        {
            get => GetInstanceProperty<aws.DataAwsOpensearchDomain.DataAwsOpensearchDomainAdvancedSecurityOptionsList>()!;
        }

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "autoTuneOptions", typeJson: "{\"fqn\":\"aws.dataAwsOpensearchDomain.DataAwsOpensearchDomainAutoTuneOptionsList\"}")]
        public virtual aws.DataAwsOpensearchDomain.DataAwsOpensearchDomainAutoTuneOptionsList AutoTuneOptions
        {
            get => GetInstanceProperty<aws.DataAwsOpensearchDomain.DataAwsOpensearchDomainAutoTuneOptionsList>()!;
        }

        [JsiiProperty(name: "clusterConfig", typeJson: "{\"fqn\":\"aws.dataAwsOpensearchDomain.DataAwsOpensearchDomainClusterConfigList\"}")]
        public virtual aws.DataAwsOpensearchDomain.DataAwsOpensearchDomainClusterConfigList ClusterConfig
        {
            get => GetInstanceProperty<aws.DataAwsOpensearchDomain.DataAwsOpensearchDomainClusterConfigList>()!;
        }

        [JsiiProperty(name: "cognitoOptions", typeJson: "{\"fqn\":\"aws.dataAwsOpensearchDomain.DataAwsOpensearchDomainCognitoOptionsList\"}")]
        public virtual aws.DataAwsOpensearchDomain.DataAwsOpensearchDomainCognitoOptionsList CognitoOptions
        {
            get => GetInstanceProperty<aws.DataAwsOpensearchDomain.DataAwsOpensearchDomainCognitoOptionsList>()!;
        }

        [JsiiProperty(name: "created", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable Created
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "dashboardEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DashboardEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dashboardEndpointV2", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DashboardEndpointV2
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "deleted", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable Deleted
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "domainEndpointV2HostedZoneId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DomainEndpointV2HostedZoneId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "domainId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DomainId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ebsOptions", typeJson: "{\"fqn\":\"aws.dataAwsOpensearchDomain.DataAwsOpensearchDomainEbsOptionsList\"}")]
        public virtual aws.DataAwsOpensearchDomain.DataAwsOpensearchDomainEbsOptionsList EbsOptions
        {
            get => GetInstanceProperty<aws.DataAwsOpensearchDomain.DataAwsOpensearchDomainEbsOptionsList>()!;
        }

        [JsiiProperty(name: "encryptionAtRest", typeJson: "{\"fqn\":\"aws.dataAwsOpensearchDomain.DataAwsOpensearchDomainEncryptionAtRestList\"}")]
        public virtual aws.DataAwsOpensearchDomain.DataAwsOpensearchDomainEncryptionAtRestList EncryptionAtRest
        {
            get => GetInstanceProperty<aws.DataAwsOpensearchDomain.DataAwsOpensearchDomainEncryptionAtRestList>()!;
        }

        [JsiiProperty(name: "endpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Endpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "endpointV2", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EndpointV2
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "engineVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EngineVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ipAddressType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IpAddressType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "kibanaEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KibanaEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "logPublishingOptions", typeJson: "{\"fqn\":\"aws.dataAwsOpensearchDomain.DataAwsOpensearchDomainLogPublishingOptionsList\"}")]
        public virtual aws.DataAwsOpensearchDomain.DataAwsOpensearchDomainLogPublishingOptionsList LogPublishingOptions
        {
            get => GetInstanceProperty<aws.DataAwsOpensearchDomain.DataAwsOpensearchDomainLogPublishingOptionsList>()!;
        }

        [JsiiProperty(name: "nodeToNodeEncryption", typeJson: "{\"fqn\":\"aws.dataAwsOpensearchDomain.DataAwsOpensearchDomainNodeToNodeEncryptionList\"}")]
        public virtual aws.DataAwsOpensearchDomain.DataAwsOpensearchDomainNodeToNodeEncryptionList NodeToNodeEncryption
        {
            get => GetInstanceProperty<aws.DataAwsOpensearchDomain.DataAwsOpensearchDomainNodeToNodeEncryptionList>()!;
        }

        [JsiiProperty(name: "offPeakWindowOptions", typeJson: "{\"fqn\":\"aws.dataAwsOpensearchDomain.DataAwsOpensearchDomainOffPeakWindowOptionsOutputReference\"}")]
        public virtual aws.DataAwsOpensearchDomain.DataAwsOpensearchDomainOffPeakWindowOptionsOutputReference OffPeakWindowOptions
        {
            get => GetInstanceProperty<aws.DataAwsOpensearchDomain.DataAwsOpensearchDomainOffPeakWindowOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "processing", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable Processing
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "snapshotOptions", typeJson: "{\"fqn\":\"aws.dataAwsOpensearchDomain.DataAwsOpensearchDomainSnapshotOptionsList\"}")]
        public virtual aws.DataAwsOpensearchDomain.DataAwsOpensearchDomainSnapshotOptionsList SnapshotOptions
        {
            get => GetInstanceProperty<aws.DataAwsOpensearchDomain.DataAwsOpensearchDomainSnapshotOptionsList>()!;
        }

        [JsiiProperty(name: "softwareUpdateOptions", typeJson: "{\"fqn\":\"aws.dataAwsOpensearchDomain.DataAwsOpensearchDomainSoftwareUpdateOptionsList\"}")]
        public virtual aws.DataAwsOpensearchDomain.DataAwsOpensearchDomainSoftwareUpdateOptionsList SoftwareUpdateOptions
        {
            get => GetInstanceProperty<aws.DataAwsOpensearchDomain.DataAwsOpensearchDomainSoftwareUpdateOptionsList>()!;
        }

        [JsiiProperty(name: "vpcOptions", typeJson: "{\"fqn\":\"aws.dataAwsOpensearchDomain.DataAwsOpensearchDomainVpcOptionsList\"}")]
        public virtual aws.DataAwsOpensearchDomain.DataAwsOpensearchDomainVpcOptionsList VpcOptions
        {
            get => GetInstanceProperty<aws.DataAwsOpensearchDomain.DataAwsOpensearchDomainVpcOptionsList>()!;
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
        [JsiiProperty(name: "offPeakWindowOptionsInput", typeJson: "{\"fqn\":\"aws.dataAwsOpensearchDomain.DataAwsOpensearchDomainOffPeakWindowOptions\"}", isOptional: true)]
        public virtual aws.DataAwsOpensearchDomain.IDataAwsOpensearchDomainOffPeakWindowOptions? OffPeakWindowOptionsInput
        {
            get => GetInstanceProperty<aws.DataAwsOpensearchDomain.IDataAwsOpensearchDomainOffPeakWindowOptions?>();
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

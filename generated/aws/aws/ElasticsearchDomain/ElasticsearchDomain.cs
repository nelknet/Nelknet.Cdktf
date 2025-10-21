using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ElasticsearchDomain
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticsearch_domain aws_elasticsearch_domain}.</summary>
    [JsiiClass(nativeType: typeof(aws.ElasticsearchDomain.ElasticsearchDomain), fullyQualifiedName: "aws.elasticsearchDomain.ElasticsearchDomain", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.elasticsearchDomain.ElasticsearchDomainConfig\"}}]")]
    public class ElasticsearchDomain : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticsearch_domain aws_elasticsearch_domain} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ElasticsearchDomain(Constructs.Construct scope, string id, aws.ElasticsearchDomain.IElasticsearchDomainConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.ElasticsearchDomain.IElasticsearchDomainConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ElasticsearchDomain(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ElasticsearchDomain(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a ElasticsearchDomain resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the ElasticsearchDomain to import.</param>
        /// <param name="importFromId">The id of the existing ElasticsearchDomain that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the ElasticsearchDomain to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the ElasticsearchDomain to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticsearch_domain#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing ElasticsearchDomain that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the ElasticsearchDomain to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.ElasticsearchDomain.ElasticsearchDomain), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAdvancedSecurityOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.elasticsearchDomain.ElasticsearchDomainAdvancedSecurityOptions\"}}]")]
        public virtual void PutAdvancedSecurityOptions(aws.ElasticsearchDomain.IElasticsearchDomainAdvancedSecurityOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.ElasticsearchDomain.IElasticsearchDomainAdvancedSecurityOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAutoTuneOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.elasticsearchDomain.ElasticsearchDomainAutoTuneOptions\"}}]")]
        public virtual void PutAutoTuneOptions(aws.ElasticsearchDomain.IElasticsearchDomainAutoTuneOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.ElasticsearchDomain.IElasticsearchDomainAutoTuneOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putClusterConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.elasticsearchDomain.ElasticsearchDomainClusterConfig\"}}]")]
        public virtual void PutClusterConfig(aws.ElasticsearchDomain.IElasticsearchDomainClusterConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.ElasticsearchDomain.IElasticsearchDomainClusterConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCognitoOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.elasticsearchDomain.ElasticsearchDomainCognitoOptions\"}}]")]
        public virtual void PutCognitoOptions(aws.ElasticsearchDomain.IElasticsearchDomainCognitoOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.ElasticsearchDomain.IElasticsearchDomainCognitoOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDomainEndpointOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.elasticsearchDomain.ElasticsearchDomainDomainEndpointOptions\"}}]")]
        public virtual void PutDomainEndpointOptions(aws.ElasticsearchDomain.IElasticsearchDomainDomainEndpointOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.ElasticsearchDomain.IElasticsearchDomainDomainEndpointOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEbsOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.elasticsearchDomain.ElasticsearchDomainEbsOptions\"}}]")]
        public virtual void PutEbsOptions(aws.ElasticsearchDomain.IElasticsearchDomainEbsOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.ElasticsearchDomain.IElasticsearchDomainEbsOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEncryptAtRest", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.elasticsearchDomain.ElasticsearchDomainEncryptAtRest\"}}]")]
        public virtual void PutEncryptAtRest(aws.ElasticsearchDomain.IElasticsearchDomainEncryptAtRest @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.ElasticsearchDomain.IElasticsearchDomainEncryptAtRest)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLogPublishingOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.elasticsearchDomain.ElasticsearchDomainLogPublishingOptions\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutLogPublishingOptions(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.ElasticsearchDomain.IElasticsearchDomainLogPublishingOptions[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.ElasticsearchDomain.IElasticsearchDomainLogPublishingOptions).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.ElasticsearchDomain.IElasticsearchDomainLogPublishingOptions).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNodeToNodeEncryption", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.elasticsearchDomain.ElasticsearchDomainNodeToNodeEncryption\"}}]")]
        public virtual void PutNodeToNodeEncryption(aws.ElasticsearchDomain.IElasticsearchDomainNodeToNodeEncryption @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.ElasticsearchDomain.IElasticsearchDomainNodeToNodeEncryption)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSnapshotOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.elasticsearchDomain.ElasticsearchDomainSnapshotOptions\"}}]")]
        public virtual void PutSnapshotOptions(aws.ElasticsearchDomain.IElasticsearchDomainSnapshotOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.ElasticsearchDomain.IElasticsearchDomainSnapshotOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.elasticsearchDomain.ElasticsearchDomainTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.ElasticsearchDomain.IElasticsearchDomainTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.ElasticsearchDomain.IElasticsearchDomainTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVpcOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.elasticsearchDomain.ElasticsearchDomainVpcOptions\"}}]")]
        public virtual void PutVpcOptions(aws.ElasticsearchDomain.IElasticsearchDomainVpcOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.ElasticsearchDomain.IElasticsearchDomainVpcOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAccessPolicies")]
        public virtual void ResetAccessPolicies()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAdvancedOptions")]
        public virtual void ResetAdvancedOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAdvancedSecurityOptions")]
        public virtual void ResetAdvancedSecurityOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAutoTuneOptions")]
        public virtual void ResetAutoTuneOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetClusterConfig")]
        public virtual void ResetClusterConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCognitoOptions")]
        public virtual void ResetCognitoOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDomainEndpointOptions")]
        public virtual void ResetDomainEndpointOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEbsOptions")]
        public virtual void ResetEbsOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetElasticsearchVersion")]
        public virtual void ResetElasticsearchVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEncryptAtRest")]
        public virtual void ResetEncryptAtRest()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLogPublishingOptions")]
        public virtual void ResetLogPublishingOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNodeToNodeEncryption")]
        public virtual void ResetNodeToNodeEncryption()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSnapshotOptions")]
        public virtual void ResetSnapshotOptions()
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

        [JsiiMethod(name: "resetVpcOptions")]
        public virtual void ResetVpcOptions()
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
        = GetStaticProperty<string>(typeof(aws.ElasticsearchDomain.ElasticsearchDomain))!;

        [JsiiProperty(name: "advancedSecurityOptions", typeJson: "{\"fqn\":\"aws.elasticsearchDomain.ElasticsearchDomainAdvancedSecurityOptionsOutputReference\"}")]
        public virtual aws.ElasticsearchDomain.ElasticsearchDomainAdvancedSecurityOptionsOutputReference AdvancedSecurityOptions
        {
            get => GetInstanceProperty<aws.ElasticsearchDomain.ElasticsearchDomainAdvancedSecurityOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "autoTuneOptions", typeJson: "{\"fqn\":\"aws.elasticsearchDomain.ElasticsearchDomainAutoTuneOptionsOutputReference\"}")]
        public virtual aws.ElasticsearchDomain.ElasticsearchDomainAutoTuneOptionsOutputReference AutoTuneOptions
        {
            get => GetInstanceProperty<aws.ElasticsearchDomain.ElasticsearchDomainAutoTuneOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "clusterConfig", typeJson: "{\"fqn\":\"aws.elasticsearchDomain.ElasticsearchDomainClusterConfigOutputReference\"}")]
        public virtual aws.ElasticsearchDomain.ElasticsearchDomainClusterConfigOutputReference ClusterConfig
        {
            get => GetInstanceProperty<aws.ElasticsearchDomain.ElasticsearchDomainClusterConfigOutputReference>()!;
        }

        [JsiiProperty(name: "cognitoOptions", typeJson: "{\"fqn\":\"aws.elasticsearchDomain.ElasticsearchDomainCognitoOptionsOutputReference\"}")]
        public virtual aws.ElasticsearchDomain.ElasticsearchDomainCognitoOptionsOutputReference CognitoOptions
        {
            get => GetInstanceProperty<aws.ElasticsearchDomain.ElasticsearchDomainCognitoOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "domainEndpointOptions", typeJson: "{\"fqn\":\"aws.elasticsearchDomain.ElasticsearchDomainDomainEndpointOptionsOutputReference\"}")]
        public virtual aws.ElasticsearchDomain.ElasticsearchDomainDomainEndpointOptionsOutputReference DomainEndpointOptions
        {
            get => GetInstanceProperty<aws.ElasticsearchDomain.ElasticsearchDomainDomainEndpointOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "domainId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DomainId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ebsOptions", typeJson: "{\"fqn\":\"aws.elasticsearchDomain.ElasticsearchDomainEbsOptionsOutputReference\"}")]
        public virtual aws.ElasticsearchDomain.ElasticsearchDomainEbsOptionsOutputReference EbsOptions
        {
            get => GetInstanceProperty<aws.ElasticsearchDomain.ElasticsearchDomainEbsOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "encryptAtRest", typeJson: "{\"fqn\":\"aws.elasticsearchDomain.ElasticsearchDomainEncryptAtRestOutputReference\"}")]
        public virtual aws.ElasticsearchDomain.ElasticsearchDomainEncryptAtRestOutputReference EncryptAtRest
        {
            get => GetInstanceProperty<aws.ElasticsearchDomain.ElasticsearchDomainEncryptAtRestOutputReference>()!;
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

        [JsiiProperty(name: "logPublishingOptions", typeJson: "{\"fqn\":\"aws.elasticsearchDomain.ElasticsearchDomainLogPublishingOptionsList\"}")]
        public virtual aws.ElasticsearchDomain.ElasticsearchDomainLogPublishingOptionsList LogPublishingOptions
        {
            get => GetInstanceProperty<aws.ElasticsearchDomain.ElasticsearchDomainLogPublishingOptionsList>()!;
        }

        [JsiiProperty(name: "nodeToNodeEncryption", typeJson: "{\"fqn\":\"aws.elasticsearchDomain.ElasticsearchDomainNodeToNodeEncryptionOutputReference\"}")]
        public virtual aws.ElasticsearchDomain.ElasticsearchDomainNodeToNodeEncryptionOutputReference NodeToNodeEncryption
        {
            get => GetInstanceProperty<aws.ElasticsearchDomain.ElasticsearchDomainNodeToNodeEncryptionOutputReference>()!;
        }

        [JsiiProperty(name: "snapshotOptions", typeJson: "{\"fqn\":\"aws.elasticsearchDomain.ElasticsearchDomainSnapshotOptionsOutputReference\"}")]
        public virtual aws.ElasticsearchDomain.ElasticsearchDomainSnapshotOptionsOutputReference SnapshotOptions
        {
            get => GetInstanceProperty<aws.ElasticsearchDomain.ElasticsearchDomainSnapshotOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.elasticsearchDomain.ElasticsearchDomainTimeoutsOutputReference\"}")]
        public virtual aws.ElasticsearchDomain.ElasticsearchDomainTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.ElasticsearchDomain.ElasticsearchDomainTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "vpcOptions", typeJson: "{\"fqn\":\"aws.elasticsearchDomain.ElasticsearchDomainVpcOptionsOutputReference\"}")]
        public virtual aws.ElasticsearchDomain.ElasticsearchDomainVpcOptionsOutputReference VpcOptions
        {
            get => GetInstanceProperty<aws.ElasticsearchDomain.ElasticsearchDomainVpcOptionsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accessPoliciesInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AccessPoliciesInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "advancedOptionsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? AdvancedOptionsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "advancedSecurityOptionsInput", typeJson: "{\"fqn\":\"aws.elasticsearchDomain.ElasticsearchDomainAdvancedSecurityOptions\"}", isOptional: true)]
        public virtual aws.ElasticsearchDomain.IElasticsearchDomainAdvancedSecurityOptions? AdvancedSecurityOptionsInput
        {
            get => GetInstanceProperty<aws.ElasticsearchDomain.IElasticsearchDomainAdvancedSecurityOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "autoTuneOptionsInput", typeJson: "{\"fqn\":\"aws.elasticsearchDomain.ElasticsearchDomainAutoTuneOptions\"}", isOptional: true)]
        public virtual aws.ElasticsearchDomain.IElasticsearchDomainAutoTuneOptions? AutoTuneOptionsInput
        {
            get => GetInstanceProperty<aws.ElasticsearchDomain.IElasticsearchDomainAutoTuneOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clusterConfigInput", typeJson: "{\"fqn\":\"aws.elasticsearchDomain.ElasticsearchDomainClusterConfig\"}", isOptional: true)]
        public virtual aws.ElasticsearchDomain.IElasticsearchDomainClusterConfig? ClusterConfigInput
        {
            get => GetInstanceProperty<aws.ElasticsearchDomain.IElasticsearchDomainClusterConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cognitoOptionsInput", typeJson: "{\"fqn\":\"aws.elasticsearchDomain.ElasticsearchDomainCognitoOptions\"}", isOptional: true)]
        public virtual aws.ElasticsearchDomain.IElasticsearchDomainCognitoOptions? CognitoOptionsInput
        {
            get => GetInstanceProperty<aws.ElasticsearchDomain.IElasticsearchDomainCognitoOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "domainEndpointOptionsInput", typeJson: "{\"fqn\":\"aws.elasticsearchDomain.ElasticsearchDomainDomainEndpointOptions\"}", isOptional: true)]
        public virtual aws.ElasticsearchDomain.IElasticsearchDomainDomainEndpointOptions? DomainEndpointOptionsInput
        {
            get => GetInstanceProperty<aws.ElasticsearchDomain.IElasticsearchDomainDomainEndpointOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "domainNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DomainNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ebsOptionsInput", typeJson: "{\"fqn\":\"aws.elasticsearchDomain.ElasticsearchDomainEbsOptions\"}", isOptional: true)]
        public virtual aws.ElasticsearchDomain.IElasticsearchDomainEbsOptions? EbsOptionsInput
        {
            get => GetInstanceProperty<aws.ElasticsearchDomain.IElasticsearchDomainEbsOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "elasticsearchVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ElasticsearchVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "encryptAtRestInput", typeJson: "{\"fqn\":\"aws.elasticsearchDomain.ElasticsearchDomainEncryptAtRest\"}", isOptional: true)]
        public virtual aws.ElasticsearchDomain.IElasticsearchDomainEncryptAtRest? EncryptAtRestInput
        {
            get => GetInstanceProperty<aws.ElasticsearchDomain.IElasticsearchDomainEncryptAtRest?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "logPublishingOptionsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.elasticsearchDomain.ElasticsearchDomainLogPublishingOptions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? LogPublishingOptionsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nodeToNodeEncryptionInput", typeJson: "{\"fqn\":\"aws.elasticsearchDomain.ElasticsearchDomainNodeToNodeEncryption\"}", isOptional: true)]
        public virtual aws.ElasticsearchDomain.IElasticsearchDomainNodeToNodeEncryption? NodeToNodeEncryptionInput
        {
            get => GetInstanceProperty<aws.ElasticsearchDomain.IElasticsearchDomainNodeToNodeEncryption?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "snapshotOptionsInput", typeJson: "{\"fqn\":\"aws.elasticsearchDomain.ElasticsearchDomainSnapshotOptions\"}", isOptional: true)]
        public virtual aws.ElasticsearchDomain.IElasticsearchDomainSnapshotOptions? SnapshotOptionsInput
        {
            get => GetInstanceProperty<aws.ElasticsearchDomain.IElasticsearchDomainSnapshotOptions?>();
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
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.elasticsearchDomain.ElasticsearchDomainTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vpcOptionsInput", typeJson: "{\"fqn\":\"aws.elasticsearchDomain.ElasticsearchDomainVpcOptions\"}", isOptional: true)]
        public virtual aws.ElasticsearchDomain.IElasticsearchDomainVpcOptions? VpcOptionsInput
        {
            get => GetInstanceProperty<aws.ElasticsearchDomain.IElasticsearchDomainVpcOptions?>();
        }

        [JsiiProperty(name: "accessPolicies", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccessPolicies
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "advancedOptions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> AdvancedOptions
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "domainName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DomainName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "elasticsearchVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ElasticsearchVersion
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

        [JsiiProperty(name: "tagsAll", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> TagsAll
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OpensearchDomain
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain aws_opensearch_domain}.</summary>
    [JsiiClass(nativeType: typeof(aws.OpensearchDomain.OpensearchDomain), fullyQualifiedName: "aws.opensearchDomain.OpensearchDomain", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.opensearchDomain.OpensearchDomainConfig\"}}]")]
    public class OpensearchDomain : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain aws_opensearch_domain} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public OpensearchDomain(Constructs.Construct scope, string id, aws.OpensearchDomain.IOpensearchDomainConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.OpensearchDomain.IOpensearchDomainConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OpensearchDomain(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OpensearchDomain(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a OpensearchDomain resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the OpensearchDomain to import.</param>
        /// <param name="importFromId">The id of the existing OpensearchDomain that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the OpensearchDomain to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the OpensearchDomain to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing OpensearchDomain that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the OpensearchDomain to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.OpensearchDomain.OpensearchDomain), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAdvancedSecurityOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.opensearchDomain.OpensearchDomainAdvancedSecurityOptions\"}}]")]
        public virtual void PutAdvancedSecurityOptions(aws.OpensearchDomain.IOpensearchDomainAdvancedSecurityOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.OpensearchDomain.IOpensearchDomainAdvancedSecurityOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAutoTuneOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.opensearchDomain.OpensearchDomainAutoTuneOptions\"}}]")]
        public virtual void PutAutoTuneOptions(aws.OpensearchDomain.IOpensearchDomainAutoTuneOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.OpensearchDomain.IOpensearchDomainAutoTuneOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putClusterConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.opensearchDomain.OpensearchDomainClusterConfig\"}}]")]
        public virtual void PutClusterConfig(aws.OpensearchDomain.IOpensearchDomainClusterConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.OpensearchDomain.IOpensearchDomainClusterConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCognitoOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.opensearchDomain.OpensearchDomainCognitoOptions\"}}]")]
        public virtual void PutCognitoOptions(aws.OpensearchDomain.IOpensearchDomainCognitoOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.OpensearchDomain.IOpensearchDomainCognitoOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDomainEndpointOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.opensearchDomain.OpensearchDomainDomainEndpointOptions\"}}]")]
        public virtual void PutDomainEndpointOptions(aws.OpensearchDomain.IOpensearchDomainDomainEndpointOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.OpensearchDomain.IOpensearchDomainDomainEndpointOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEbsOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.opensearchDomain.OpensearchDomainEbsOptions\"}}]")]
        public virtual void PutEbsOptions(aws.OpensearchDomain.IOpensearchDomainEbsOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.OpensearchDomain.IOpensearchDomainEbsOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEncryptAtRest", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.opensearchDomain.OpensearchDomainEncryptAtRest\"}}]")]
        public virtual void PutEncryptAtRest(aws.OpensearchDomain.IOpensearchDomainEncryptAtRest @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.OpensearchDomain.IOpensearchDomainEncryptAtRest)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLogPublishingOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.opensearchDomain.OpensearchDomainLogPublishingOptions\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutLogPublishingOptions(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.OpensearchDomain.IOpensearchDomainLogPublishingOptions[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.OpensearchDomain.IOpensearchDomainLogPublishingOptions).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.OpensearchDomain.IOpensearchDomainLogPublishingOptions).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNodeToNodeEncryption", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.opensearchDomain.OpensearchDomainNodeToNodeEncryption\"}}]")]
        public virtual void PutNodeToNodeEncryption(aws.OpensearchDomain.IOpensearchDomainNodeToNodeEncryption @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.OpensearchDomain.IOpensearchDomainNodeToNodeEncryption)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOffPeakWindowOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.opensearchDomain.OpensearchDomainOffPeakWindowOptions\"}}]")]
        public virtual void PutOffPeakWindowOptions(aws.OpensearchDomain.IOpensearchDomainOffPeakWindowOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.OpensearchDomain.IOpensearchDomainOffPeakWindowOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSnapshotOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.opensearchDomain.OpensearchDomainSnapshotOptions\"}}]")]
        public virtual void PutSnapshotOptions(aws.OpensearchDomain.IOpensearchDomainSnapshotOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.OpensearchDomain.IOpensearchDomainSnapshotOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSoftwareUpdateOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.opensearchDomain.OpensearchDomainSoftwareUpdateOptions\"}}]")]
        public virtual void PutSoftwareUpdateOptions(aws.OpensearchDomain.IOpensearchDomainSoftwareUpdateOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.OpensearchDomain.IOpensearchDomainSoftwareUpdateOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.opensearchDomain.OpensearchDomainTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.OpensearchDomain.IOpensearchDomainTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.OpensearchDomain.IOpensearchDomainTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVpcOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.opensearchDomain.OpensearchDomainVpcOptions\"}}]")]
        public virtual void PutVpcOptions(aws.OpensearchDomain.IOpensearchDomainVpcOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.OpensearchDomain.IOpensearchDomainVpcOptions)}, new object[]{@value});
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

        [JsiiMethod(name: "resetEncryptAtRest")]
        public virtual void ResetEncryptAtRest()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEngineVersion")]
        public virtual void ResetEngineVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIpAddressType")]
        public virtual void ResetIpAddressType()
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

        [JsiiMethod(name: "resetOffPeakWindowOptions")]
        public virtual void ResetOffPeakWindowOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSnapshotOptions")]
        public virtual void ResetSnapshotOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSoftwareUpdateOptions")]
        public virtual void ResetSoftwareUpdateOptions()
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
        = GetStaticProperty<string>(typeof(aws.OpensearchDomain.OpensearchDomain))!;

        [JsiiProperty(name: "advancedSecurityOptions", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainAdvancedSecurityOptionsOutputReference\"}")]
        public virtual aws.OpensearchDomain.OpensearchDomainAdvancedSecurityOptionsOutputReference AdvancedSecurityOptions
        {
            get => GetInstanceProperty<aws.OpensearchDomain.OpensearchDomainAdvancedSecurityOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "autoTuneOptions", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainAutoTuneOptionsOutputReference\"}")]
        public virtual aws.OpensearchDomain.OpensearchDomainAutoTuneOptionsOutputReference AutoTuneOptions
        {
            get => GetInstanceProperty<aws.OpensearchDomain.OpensearchDomainAutoTuneOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "clusterConfig", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainClusterConfigOutputReference\"}")]
        public virtual aws.OpensearchDomain.OpensearchDomainClusterConfigOutputReference ClusterConfig
        {
            get => GetInstanceProperty<aws.OpensearchDomain.OpensearchDomainClusterConfigOutputReference>()!;
        }

        [JsiiProperty(name: "cognitoOptions", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainCognitoOptionsOutputReference\"}")]
        public virtual aws.OpensearchDomain.OpensearchDomainCognitoOptionsOutputReference CognitoOptions
        {
            get => GetInstanceProperty<aws.OpensearchDomain.OpensearchDomainCognitoOptionsOutputReference>()!;
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

        [JsiiProperty(name: "domainEndpointOptions", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainDomainEndpointOptionsOutputReference\"}")]
        public virtual aws.OpensearchDomain.OpensearchDomainDomainEndpointOptionsOutputReference DomainEndpointOptions
        {
            get => GetInstanceProperty<aws.OpensearchDomain.OpensearchDomainDomainEndpointOptionsOutputReference>()!;
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

        [JsiiProperty(name: "ebsOptions", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainEbsOptionsOutputReference\"}")]
        public virtual aws.OpensearchDomain.OpensearchDomainEbsOptionsOutputReference EbsOptions
        {
            get => GetInstanceProperty<aws.OpensearchDomain.OpensearchDomainEbsOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "encryptAtRest", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainEncryptAtRestOutputReference\"}")]
        public virtual aws.OpensearchDomain.OpensearchDomainEncryptAtRestOutputReference EncryptAtRest
        {
            get => GetInstanceProperty<aws.OpensearchDomain.OpensearchDomainEncryptAtRestOutputReference>()!;
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

        [JsiiProperty(name: "kibanaEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KibanaEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "logPublishingOptions", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainLogPublishingOptionsList\"}")]
        public virtual aws.OpensearchDomain.OpensearchDomainLogPublishingOptionsList LogPublishingOptions
        {
            get => GetInstanceProperty<aws.OpensearchDomain.OpensearchDomainLogPublishingOptionsList>()!;
        }

        [JsiiProperty(name: "nodeToNodeEncryption", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainNodeToNodeEncryptionOutputReference\"}")]
        public virtual aws.OpensearchDomain.OpensearchDomainNodeToNodeEncryptionOutputReference NodeToNodeEncryption
        {
            get => GetInstanceProperty<aws.OpensearchDomain.OpensearchDomainNodeToNodeEncryptionOutputReference>()!;
        }

        [JsiiProperty(name: "offPeakWindowOptions", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainOffPeakWindowOptionsOutputReference\"}")]
        public virtual aws.OpensearchDomain.OpensearchDomainOffPeakWindowOptionsOutputReference OffPeakWindowOptions
        {
            get => GetInstanceProperty<aws.OpensearchDomain.OpensearchDomainOffPeakWindowOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "snapshotOptions", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainSnapshotOptionsOutputReference\"}")]
        public virtual aws.OpensearchDomain.OpensearchDomainSnapshotOptionsOutputReference SnapshotOptions
        {
            get => GetInstanceProperty<aws.OpensearchDomain.OpensearchDomainSnapshotOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "softwareUpdateOptions", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainSoftwareUpdateOptionsOutputReference\"}")]
        public virtual aws.OpensearchDomain.OpensearchDomainSoftwareUpdateOptionsOutputReference SoftwareUpdateOptions
        {
            get => GetInstanceProperty<aws.OpensearchDomain.OpensearchDomainSoftwareUpdateOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainTimeoutsOutputReference\"}")]
        public virtual aws.OpensearchDomain.OpensearchDomainTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.OpensearchDomain.OpensearchDomainTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "vpcOptions", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainVpcOptionsOutputReference\"}")]
        public virtual aws.OpensearchDomain.OpensearchDomainVpcOptionsOutputReference VpcOptions
        {
            get => GetInstanceProperty<aws.OpensearchDomain.OpensearchDomainVpcOptionsOutputReference>()!;
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
        [JsiiProperty(name: "advancedSecurityOptionsInput", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainAdvancedSecurityOptions\"}", isOptional: true)]
        public virtual aws.OpensearchDomain.IOpensearchDomainAdvancedSecurityOptions? AdvancedSecurityOptionsInput
        {
            get => GetInstanceProperty<aws.OpensearchDomain.IOpensearchDomainAdvancedSecurityOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "autoTuneOptionsInput", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainAutoTuneOptions\"}", isOptional: true)]
        public virtual aws.OpensearchDomain.IOpensearchDomainAutoTuneOptions? AutoTuneOptionsInput
        {
            get => GetInstanceProperty<aws.OpensearchDomain.IOpensearchDomainAutoTuneOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clusterConfigInput", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainClusterConfig\"}", isOptional: true)]
        public virtual aws.OpensearchDomain.IOpensearchDomainClusterConfig? ClusterConfigInput
        {
            get => GetInstanceProperty<aws.OpensearchDomain.IOpensearchDomainClusterConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cognitoOptionsInput", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainCognitoOptions\"}", isOptional: true)]
        public virtual aws.OpensearchDomain.IOpensearchDomainCognitoOptions? CognitoOptionsInput
        {
            get => GetInstanceProperty<aws.OpensearchDomain.IOpensearchDomainCognitoOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "domainEndpointOptionsInput", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainDomainEndpointOptions\"}", isOptional: true)]
        public virtual aws.OpensearchDomain.IOpensearchDomainDomainEndpointOptions? DomainEndpointOptionsInput
        {
            get => GetInstanceProperty<aws.OpensearchDomain.IOpensearchDomainDomainEndpointOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "domainNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DomainNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ebsOptionsInput", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainEbsOptions\"}", isOptional: true)]
        public virtual aws.OpensearchDomain.IOpensearchDomainEbsOptions? EbsOptionsInput
        {
            get => GetInstanceProperty<aws.OpensearchDomain.IOpensearchDomainEbsOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "encryptAtRestInput", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainEncryptAtRest\"}", isOptional: true)]
        public virtual aws.OpensearchDomain.IOpensearchDomainEncryptAtRest? EncryptAtRestInput
        {
            get => GetInstanceProperty<aws.OpensearchDomain.IOpensearchDomainEncryptAtRest?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "engineVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EngineVersionInput
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
        [JsiiProperty(name: "ipAddressTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IpAddressTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "logPublishingOptionsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.opensearchDomain.OpensearchDomainLogPublishingOptions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? LogPublishingOptionsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nodeToNodeEncryptionInput", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainNodeToNodeEncryption\"}", isOptional: true)]
        public virtual aws.OpensearchDomain.IOpensearchDomainNodeToNodeEncryption? NodeToNodeEncryptionInput
        {
            get => GetInstanceProperty<aws.OpensearchDomain.IOpensearchDomainNodeToNodeEncryption?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "offPeakWindowOptionsInput", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainOffPeakWindowOptions\"}", isOptional: true)]
        public virtual aws.OpensearchDomain.IOpensearchDomainOffPeakWindowOptions? OffPeakWindowOptionsInput
        {
            get => GetInstanceProperty<aws.OpensearchDomain.IOpensearchDomainOffPeakWindowOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "snapshotOptionsInput", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainSnapshotOptions\"}", isOptional: true)]
        public virtual aws.OpensearchDomain.IOpensearchDomainSnapshotOptions? SnapshotOptionsInput
        {
            get => GetInstanceProperty<aws.OpensearchDomain.IOpensearchDomainSnapshotOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "softwareUpdateOptionsInput", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainSoftwareUpdateOptions\"}", isOptional: true)]
        public virtual aws.OpensearchDomain.IOpensearchDomainSoftwareUpdateOptions? SoftwareUpdateOptionsInput
        {
            get => GetInstanceProperty<aws.OpensearchDomain.IOpensearchDomainSoftwareUpdateOptions?>();
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
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.opensearchDomain.OpensearchDomainTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vpcOptionsInput", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainVpcOptions\"}", isOptional: true)]
        public virtual aws.OpensearchDomain.IOpensearchDomainVpcOptions? VpcOptionsInput
        {
            get => GetInstanceProperty<aws.OpensearchDomain.IOpensearchDomainVpcOptions?>();
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

        [JsiiProperty(name: "engineVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EngineVersion
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

        [JsiiProperty(name: "ipAddressType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IpAddressType
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

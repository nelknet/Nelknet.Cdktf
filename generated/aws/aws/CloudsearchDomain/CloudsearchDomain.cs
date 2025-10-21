using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudsearchDomain
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudsearch_domain aws_cloudsearch_domain}.</summary>
    [JsiiClass(nativeType: typeof(aws.CloudsearchDomain.CloudsearchDomain), fullyQualifiedName: "aws.cloudsearchDomain.CloudsearchDomain", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.cloudsearchDomain.CloudsearchDomainConfig\"}}]")]
    public class CloudsearchDomain : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudsearch_domain aws_cloudsearch_domain} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public CloudsearchDomain(Constructs.Construct scope, string id, aws.CloudsearchDomain.ICloudsearchDomainConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.CloudsearchDomain.ICloudsearchDomainConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudsearchDomain(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudsearchDomain(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a CloudsearchDomain resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the CloudsearchDomain to import.</param>
        /// <param name="importFromId">The id of the existing CloudsearchDomain that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the CloudsearchDomain to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the CloudsearchDomain to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudsearch_domain#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing CloudsearchDomain that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the CloudsearchDomain to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.CloudsearchDomain.CloudsearchDomain), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putEndpointOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudsearchDomain.CloudsearchDomainEndpointOptions\"}}]")]
        public virtual void PutEndpointOptions(aws.CloudsearchDomain.ICloudsearchDomainEndpointOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CloudsearchDomain.ICloudsearchDomainEndpointOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIndexField", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudsearchDomain.CloudsearchDomainIndexField\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutIndexField(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.CloudsearchDomain.ICloudsearchDomainIndexField[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.CloudsearchDomain.ICloudsearchDomainIndexField).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.CloudsearchDomain.ICloudsearchDomainIndexField).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putScalingParameters", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudsearchDomain.CloudsearchDomainScalingParameters\"}}]")]
        public virtual void PutScalingParameters(aws.CloudsearchDomain.ICloudsearchDomainScalingParameters @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CloudsearchDomain.ICloudsearchDomainScalingParameters)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudsearchDomain.CloudsearchDomainTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.CloudsearchDomain.ICloudsearchDomainTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CloudsearchDomain.ICloudsearchDomainTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetEndpointOptions")]
        public virtual void ResetEndpointOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIndexField")]
        public virtual void ResetIndexField()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMultiAz")]
        public virtual void ResetMultiAz()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetScalingParameters")]
        public virtual void ResetScalingParameters()
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
        = GetStaticProperty<string>(typeof(aws.CloudsearchDomain.CloudsearchDomain))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "documentServiceEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DocumentServiceEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "domainId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DomainId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "endpointOptions", typeJson: "{\"fqn\":\"aws.cloudsearchDomain.CloudsearchDomainEndpointOptionsOutputReference\"}")]
        public virtual aws.CloudsearchDomain.CloudsearchDomainEndpointOptionsOutputReference EndpointOptions
        {
            get => GetInstanceProperty<aws.CloudsearchDomain.CloudsearchDomainEndpointOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "indexField", typeJson: "{\"fqn\":\"aws.cloudsearchDomain.CloudsearchDomainIndexFieldList\"}")]
        public virtual aws.CloudsearchDomain.CloudsearchDomainIndexFieldList IndexField
        {
            get => GetInstanceProperty<aws.CloudsearchDomain.CloudsearchDomainIndexFieldList>()!;
        }

        [JsiiProperty(name: "scalingParameters", typeJson: "{\"fqn\":\"aws.cloudsearchDomain.CloudsearchDomainScalingParametersOutputReference\"}")]
        public virtual aws.CloudsearchDomain.CloudsearchDomainScalingParametersOutputReference ScalingParameters
        {
            get => GetInstanceProperty<aws.CloudsearchDomain.CloudsearchDomainScalingParametersOutputReference>()!;
        }

        [JsiiProperty(name: "searchServiceEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SearchServiceEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.cloudsearchDomain.CloudsearchDomainTimeoutsOutputReference\"}")]
        public virtual aws.CloudsearchDomain.CloudsearchDomainTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.CloudsearchDomain.CloudsearchDomainTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "endpointOptionsInput", typeJson: "{\"fqn\":\"aws.cloudsearchDomain.CloudsearchDomainEndpointOptions\"}", isOptional: true)]
        public virtual aws.CloudsearchDomain.ICloudsearchDomainEndpointOptions? EndpointOptionsInput
        {
            get => GetInstanceProperty<aws.CloudsearchDomain.ICloudsearchDomainEndpointOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "indexFieldInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudsearchDomain.CloudsearchDomainIndexField\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? IndexFieldInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "multiAzInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? MultiAzInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scalingParametersInput", typeJson: "{\"fqn\":\"aws.cloudsearchDomain.CloudsearchDomainScalingParameters\"}", isOptional: true)]
        public virtual aws.CloudsearchDomain.ICloudsearchDomainScalingParameters? ScalingParametersInput
        {
            get => GetInstanceProperty<aws.CloudsearchDomain.ICloudsearchDomainScalingParameters?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.cloudsearchDomain.CloudsearchDomainTimeouts\"}]}}", isOptional: true)]
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

        [JsiiProperty(name: "multiAz", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object MultiAz
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

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}

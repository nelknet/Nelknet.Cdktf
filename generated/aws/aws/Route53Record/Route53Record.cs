using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Route53Record
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_record aws_route53_record}.</summary>
    [JsiiClass(nativeType: typeof(aws.Route53Record.Route53Record), fullyQualifiedName: "aws.route53Record.Route53Record", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.route53Record.Route53RecordConfig\"}}]")]
    public class Route53Record : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_record aws_route53_record} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public Route53Record(Constructs.Construct scope, string id, aws.Route53Record.IRoute53RecordConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.Route53Record.IRoute53RecordConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Route53Record(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Route53Record(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a Route53Record resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the Route53Record to import.</param>
        /// <param name="importFromId">The id of the existing Route53Record that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the Route53Record to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the Route53Record to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_record#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing Route53Record that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the Route53Record to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.Route53Record.Route53Record), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAlias", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.route53Record.Route53RecordAlias\"}}]")]
        public virtual void PutAlias(aws.Route53Record.IRoute53RecordAlias @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Route53Record.IRoute53RecordAlias)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCidrRoutingPolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.route53Record.Route53RecordCidrRoutingPolicy\"}}]")]
        public virtual void PutCidrRoutingPolicy(aws.Route53Record.IRoute53RecordCidrRoutingPolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Route53Record.IRoute53RecordCidrRoutingPolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFailoverRoutingPolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.route53Record.Route53RecordFailoverRoutingPolicy\"}}]")]
        public virtual void PutFailoverRoutingPolicy(aws.Route53Record.IRoute53RecordFailoverRoutingPolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Route53Record.IRoute53RecordFailoverRoutingPolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGeolocationRoutingPolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.route53Record.Route53RecordGeolocationRoutingPolicy\"}}]")]
        public virtual void PutGeolocationRoutingPolicy(aws.Route53Record.IRoute53RecordGeolocationRoutingPolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Route53Record.IRoute53RecordGeolocationRoutingPolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGeoproximityRoutingPolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.route53Record.Route53RecordGeoproximityRoutingPolicy\"}}]")]
        public virtual void PutGeoproximityRoutingPolicy(aws.Route53Record.IRoute53RecordGeoproximityRoutingPolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Route53Record.IRoute53RecordGeoproximityRoutingPolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLatencyRoutingPolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.route53Record.Route53RecordLatencyRoutingPolicy\"}}]")]
        public virtual void PutLatencyRoutingPolicy(aws.Route53Record.IRoute53RecordLatencyRoutingPolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Route53Record.IRoute53RecordLatencyRoutingPolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.route53Record.Route53RecordTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.Route53Record.IRoute53RecordTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Route53Record.IRoute53RecordTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "putWeightedRoutingPolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.route53Record.Route53RecordWeightedRoutingPolicy\"}}]")]
        public virtual void PutWeightedRoutingPolicy(aws.Route53Record.IRoute53RecordWeightedRoutingPolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Route53Record.IRoute53RecordWeightedRoutingPolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAlias")]
        public virtual void ResetAlias()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAllowOverwrite")]
        public virtual void ResetAllowOverwrite()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCidrRoutingPolicy")]
        public virtual void ResetCidrRoutingPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFailoverRoutingPolicy")]
        public virtual void ResetFailoverRoutingPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGeolocationRoutingPolicy")]
        public virtual void ResetGeolocationRoutingPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGeoproximityRoutingPolicy")]
        public virtual void ResetGeoproximityRoutingPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHealthCheckId")]
        public virtual void ResetHealthCheckId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLatencyRoutingPolicy")]
        public virtual void ResetLatencyRoutingPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMultivalueAnswerRoutingPolicy")]
        public virtual void ResetMultivalueAnswerRoutingPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRecords")]
        public virtual void ResetRecords()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSetIdentifier")]
        public virtual void ResetSetIdentifier()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTtl")]
        public virtual void ResetTtl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWeightedRoutingPolicy")]
        public virtual void ResetWeightedRoutingPolicy()
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
        = GetStaticProperty<string>(typeof(aws.Route53Record.Route53Record))!;

        [JsiiProperty(name: "alias", typeJson: "{\"fqn\":\"aws.route53Record.Route53RecordAliasOutputReference\"}")]
        public virtual aws.Route53Record.Route53RecordAliasOutputReference Alias
        {
            get => GetInstanceProperty<aws.Route53Record.Route53RecordAliasOutputReference>()!;
        }

        [JsiiProperty(name: "cidrRoutingPolicy", typeJson: "{\"fqn\":\"aws.route53Record.Route53RecordCidrRoutingPolicyOutputReference\"}")]
        public virtual aws.Route53Record.Route53RecordCidrRoutingPolicyOutputReference CidrRoutingPolicy
        {
            get => GetInstanceProperty<aws.Route53Record.Route53RecordCidrRoutingPolicyOutputReference>()!;
        }

        [JsiiProperty(name: "failoverRoutingPolicy", typeJson: "{\"fqn\":\"aws.route53Record.Route53RecordFailoverRoutingPolicyOutputReference\"}")]
        public virtual aws.Route53Record.Route53RecordFailoverRoutingPolicyOutputReference FailoverRoutingPolicy
        {
            get => GetInstanceProperty<aws.Route53Record.Route53RecordFailoverRoutingPolicyOutputReference>()!;
        }

        [JsiiProperty(name: "fqdn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Fqdn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "geolocationRoutingPolicy", typeJson: "{\"fqn\":\"aws.route53Record.Route53RecordGeolocationRoutingPolicyOutputReference\"}")]
        public virtual aws.Route53Record.Route53RecordGeolocationRoutingPolicyOutputReference GeolocationRoutingPolicy
        {
            get => GetInstanceProperty<aws.Route53Record.Route53RecordGeolocationRoutingPolicyOutputReference>()!;
        }

        [JsiiProperty(name: "geoproximityRoutingPolicy", typeJson: "{\"fqn\":\"aws.route53Record.Route53RecordGeoproximityRoutingPolicyOutputReference\"}")]
        public virtual aws.Route53Record.Route53RecordGeoproximityRoutingPolicyOutputReference GeoproximityRoutingPolicy
        {
            get => GetInstanceProperty<aws.Route53Record.Route53RecordGeoproximityRoutingPolicyOutputReference>()!;
        }

        [JsiiProperty(name: "latencyRoutingPolicy", typeJson: "{\"fqn\":\"aws.route53Record.Route53RecordLatencyRoutingPolicyOutputReference\"}")]
        public virtual aws.Route53Record.Route53RecordLatencyRoutingPolicyOutputReference LatencyRoutingPolicy
        {
            get => GetInstanceProperty<aws.Route53Record.Route53RecordLatencyRoutingPolicyOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.route53Record.Route53RecordTimeoutsOutputReference\"}")]
        public virtual aws.Route53Record.Route53RecordTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.Route53Record.Route53RecordTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "weightedRoutingPolicy", typeJson: "{\"fqn\":\"aws.route53Record.Route53RecordWeightedRoutingPolicyOutputReference\"}")]
        public virtual aws.Route53Record.Route53RecordWeightedRoutingPolicyOutputReference WeightedRoutingPolicy
        {
            get => GetInstanceProperty<aws.Route53Record.Route53RecordWeightedRoutingPolicyOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "aliasInput", typeJson: "{\"fqn\":\"aws.route53Record.Route53RecordAlias\"}", isOptional: true)]
        public virtual aws.Route53Record.IRoute53RecordAlias? AliasInput
        {
            get => GetInstanceProperty<aws.Route53Record.IRoute53RecordAlias?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "allowOverwriteInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? AllowOverwriteInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cidrRoutingPolicyInput", typeJson: "{\"fqn\":\"aws.route53Record.Route53RecordCidrRoutingPolicy\"}", isOptional: true)]
        public virtual aws.Route53Record.IRoute53RecordCidrRoutingPolicy? CidrRoutingPolicyInput
        {
            get => GetInstanceProperty<aws.Route53Record.IRoute53RecordCidrRoutingPolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "failoverRoutingPolicyInput", typeJson: "{\"fqn\":\"aws.route53Record.Route53RecordFailoverRoutingPolicy\"}", isOptional: true)]
        public virtual aws.Route53Record.IRoute53RecordFailoverRoutingPolicy? FailoverRoutingPolicyInput
        {
            get => GetInstanceProperty<aws.Route53Record.IRoute53RecordFailoverRoutingPolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "geolocationRoutingPolicyInput", typeJson: "{\"fqn\":\"aws.route53Record.Route53RecordGeolocationRoutingPolicy\"}", isOptional: true)]
        public virtual aws.Route53Record.IRoute53RecordGeolocationRoutingPolicy? GeolocationRoutingPolicyInput
        {
            get => GetInstanceProperty<aws.Route53Record.IRoute53RecordGeolocationRoutingPolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "geoproximityRoutingPolicyInput", typeJson: "{\"fqn\":\"aws.route53Record.Route53RecordGeoproximityRoutingPolicy\"}", isOptional: true)]
        public virtual aws.Route53Record.IRoute53RecordGeoproximityRoutingPolicy? GeoproximityRoutingPolicyInput
        {
            get => GetInstanceProperty<aws.Route53Record.IRoute53RecordGeoproximityRoutingPolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "healthCheckIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HealthCheckIdInput
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
        [JsiiProperty(name: "latencyRoutingPolicyInput", typeJson: "{\"fqn\":\"aws.route53Record.Route53RecordLatencyRoutingPolicy\"}", isOptional: true)]
        public virtual aws.Route53Record.IRoute53RecordLatencyRoutingPolicy? LatencyRoutingPolicyInput
        {
            get => GetInstanceProperty<aws.Route53Record.IRoute53RecordLatencyRoutingPolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "multivalueAnswerRoutingPolicyInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? MultivalueAnswerRoutingPolicyInput
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
        [JsiiProperty(name: "recordsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? RecordsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "setIdentifierInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SetIdentifierInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.route53Record.Route53RecordTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ttlInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TtlInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "weightedRoutingPolicyInput", typeJson: "{\"fqn\":\"aws.route53Record.Route53RecordWeightedRoutingPolicy\"}", isOptional: true)]
        public virtual aws.Route53Record.IRoute53RecordWeightedRoutingPolicy? WeightedRoutingPolicyInput
        {
            get => GetInstanceProperty<aws.Route53Record.IRoute53RecordWeightedRoutingPolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "zoneIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ZoneIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "allowOverwrite", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object AllowOverwrite
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

        [JsiiProperty(name: "healthCheckId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HealthCheckId
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

        [JsiiProperty(name: "multivalueAnswerRoutingPolicy", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object MultivalueAnswerRoutingPolicy
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

        [JsiiProperty(name: "records", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Records
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "setIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SetIdentifier
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ttl", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Ttl
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "zoneId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ZoneId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}

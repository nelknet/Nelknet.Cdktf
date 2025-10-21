using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Route53DomainsDelegationSignerRecord
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53domains_delegation_signer_record aws_route53domains_delegation_signer_record}.</summary>
    [JsiiClass(nativeType: typeof(aws.Route53DomainsDelegationSignerRecord.Route53DomainsDelegationSignerRecord), fullyQualifiedName: "aws.route53DomainsDelegationSignerRecord.Route53DomainsDelegationSignerRecord", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.route53DomainsDelegationSignerRecord.Route53DomainsDelegationSignerRecordConfig\"}}]")]
    public class Route53DomainsDelegationSignerRecord : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53domains_delegation_signer_record aws_route53domains_delegation_signer_record} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public Route53DomainsDelegationSignerRecord(Constructs.Construct scope, string id, aws.Route53DomainsDelegationSignerRecord.IRoute53DomainsDelegationSignerRecordConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.Route53DomainsDelegationSignerRecord.IRoute53DomainsDelegationSignerRecordConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Route53DomainsDelegationSignerRecord(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Route53DomainsDelegationSignerRecord(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a Route53DomainsDelegationSignerRecord resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the Route53DomainsDelegationSignerRecord to import.</param>
        /// <param name="importFromId">The id of the existing Route53DomainsDelegationSignerRecord that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the Route53DomainsDelegationSignerRecord to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the Route53DomainsDelegationSignerRecord to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53domains_delegation_signer_record#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing Route53DomainsDelegationSignerRecord that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the Route53DomainsDelegationSignerRecord to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.Route53DomainsDelegationSignerRecord.Route53DomainsDelegationSignerRecord), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putSigningAttributes", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.route53DomainsDelegationSignerRecord.Route53DomainsDelegationSignerRecordSigningAttributes\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutSigningAttributes(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.Route53DomainsDelegationSignerRecord.IRoute53DomainsDelegationSignerRecordSigningAttributes[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Route53DomainsDelegationSignerRecord.IRoute53DomainsDelegationSignerRecordSigningAttributes).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Route53DomainsDelegationSignerRecord.IRoute53DomainsDelegationSignerRecordSigningAttributes).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.route53DomainsDelegationSignerRecord.Route53DomainsDelegationSignerRecordTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.Route53DomainsDelegationSignerRecord.IRoute53DomainsDelegationSignerRecordTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Route53DomainsDelegationSignerRecord.IRoute53DomainsDelegationSignerRecordTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetSigningAttributes")]
        public virtual void ResetSigningAttributes()
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
        = GetStaticProperty<string>(typeof(aws.Route53DomainsDelegationSignerRecord.Route53DomainsDelegationSignerRecord))!;

        [JsiiProperty(name: "dnssecKeyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DnssecKeyId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "signingAttributes", typeJson: "{\"fqn\":\"aws.route53DomainsDelegationSignerRecord.Route53DomainsDelegationSignerRecordSigningAttributesList\"}")]
        public virtual aws.Route53DomainsDelegationSignerRecord.Route53DomainsDelegationSignerRecordSigningAttributesList SigningAttributes
        {
            get => GetInstanceProperty<aws.Route53DomainsDelegationSignerRecord.Route53DomainsDelegationSignerRecordSigningAttributesList>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.route53DomainsDelegationSignerRecord.Route53DomainsDelegationSignerRecordTimeoutsOutputReference\"}")]
        public virtual aws.Route53DomainsDelegationSignerRecord.Route53DomainsDelegationSignerRecordTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.Route53DomainsDelegationSignerRecord.Route53DomainsDelegationSignerRecordTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "domainNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DomainNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "signingAttributesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.route53DomainsDelegationSignerRecord.Route53DomainsDelegationSignerRecordSigningAttributes\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? SigningAttributesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.route53DomainsDelegationSignerRecord.Route53DomainsDelegationSignerRecordTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "domainName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DomainName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}

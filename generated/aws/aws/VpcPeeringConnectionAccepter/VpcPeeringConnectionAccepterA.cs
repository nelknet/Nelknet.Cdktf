using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.VpcPeeringConnectionAccepter
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_peering_connection_accepter aws_vpc_peering_connection_accepter}.</summary>
    [JsiiClass(nativeType: typeof(aws.VpcPeeringConnectionAccepter.VpcPeeringConnectionAccepterA), fullyQualifiedName: "aws.vpcPeeringConnectionAccepter.VpcPeeringConnectionAccepterA", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.vpcPeeringConnectionAccepter.VpcPeeringConnectionAccepterAConfig\"}}]")]
    public class VpcPeeringConnectionAccepterA : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_peering_connection_accepter aws_vpc_peering_connection_accepter} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public VpcPeeringConnectionAccepterA(Constructs.Construct scope, string id, aws.VpcPeeringConnectionAccepter.IVpcPeeringConnectionAccepterAConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.VpcPeeringConnectionAccepter.IVpcPeeringConnectionAccepterAConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VpcPeeringConnectionAccepterA(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VpcPeeringConnectionAccepterA(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a VpcPeeringConnectionAccepterA resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the VpcPeeringConnectionAccepterA to import.</param>
        /// <param name="importFromId">The id of the existing VpcPeeringConnectionAccepterA that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the VpcPeeringConnectionAccepterA to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the VpcPeeringConnectionAccepterA to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_peering_connection_accepter#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing VpcPeeringConnectionAccepterA that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the VpcPeeringConnectionAccepterA to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.VpcPeeringConnectionAccepter.VpcPeeringConnectionAccepterA), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAccepter", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.vpcPeeringConnectionAccepter.VpcPeeringConnectionAccepterAccepter\"}}]")]
        public virtual void PutAccepter(aws.VpcPeeringConnectionAccepter.IVpcPeeringConnectionAccepterAccepter @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.VpcPeeringConnectionAccepter.IVpcPeeringConnectionAccepterAccepter)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRequester", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.vpcPeeringConnectionAccepter.VpcPeeringConnectionAccepterRequester\"}}]")]
        public virtual void PutRequester(aws.VpcPeeringConnectionAccepter.IVpcPeeringConnectionAccepterRequester @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.VpcPeeringConnectionAccepter.IVpcPeeringConnectionAccepterRequester)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.vpcPeeringConnectionAccepter.VpcPeeringConnectionAccepterTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.VpcPeeringConnectionAccepter.IVpcPeeringConnectionAccepterTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.VpcPeeringConnectionAccepter.IVpcPeeringConnectionAccepterTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAccepter")]
        public virtual void ResetAccepter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAutoAccept")]
        public virtual void ResetAutoAccept()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRequester")]
        public virtual void ResetRequester()
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
        = GetStaticProperty<string>(typeof(aws.VpcPeeringConnectionAccepter.VpcPeeringConnectionAccepterA))!;

        [JsiiProperty(name: "accepter", typeJson: "{\"fqn\":\"aws.vpcPeeringConnectionAccepter.VpcPeeringConnectionAccepterAccepterOutputReference\"}")]
        public virtual aws.VpcPeeringConnectionAccepter.VpcPeeringConnectionAccepterAccepterOutputReference Accepter
        {
            get => GetInstanceProperty<aws.VpcPeeringConnectionAccepter.VpcPeeringConnectionAccepterAccepterOutputReference>()!;
        }

        [JsiiProperty(name: "acceptStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AcceptStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "peerOwnerId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PeerOwnerId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "peerRegion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PeerRegion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "peerVpcId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PeerVpcId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "requester", typeJson: "{\"fqn\":\"aws.vpcPeeringConnectionAccepter.VpcPeeringConnectionAccepterRequesterOutputReference\"}")]
        public virtual aws.VpcPeeringConnectionAccepter.VpcPeeringConnectionAccepterRequesterOutputReference Requester
        {
            get => GetInstanceProperty<aws.VpcPeeringConnectionAccepter.VpcPeeringConnectionAccepterRequesterOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.vpcPeeringConnectionAccepter.VpcPeeringConnectionAccepterTimeoutsOutputReference\"}")]
        public virtual aws.VpcPeeringConnectionAccepter.VpcPeeringConnectionAccepterTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.VpcPeeringConnectionAccepter.VpcPeeringConnectionAccepterTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "vpcId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VpcId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accepterInput", typeJson: "{\"fqn\":\"aws.vpcPeeringConnectionAccepter.VpcPeeringConnectionAccepterAccepter\"}", isOptional: true)]
        public virtual aws.VpcPeeringConnectionAccepter.IVpcPeeringConnectionAccepterAccepter? AccepterInput
        {
            get => GetInstanceProperty<aws.VpcPeeringConnectionAccepter.IVpcPeeringConnectionAccepterAccepter?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "autoAcceptInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? AutoAcceptInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "requesterInput", typeJson: "{\"fqn\":\"aws.vpcPeeringConnectionAccepter.VpcPeeringConnectionAccepterRequester\"}", isOptional: true)]
        public virtual aws.VpcPeeringConnectionAccepter.IVpcPeeringConnectionAccepterRequester? RequesterInput
        {
            get => GetInstanceProperty<aws.VpcPeeringConnectionAccepter.IVpcPeeringConnectionAccepterRequester?>();
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
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.vpcPeeringConnectionAccepter.VpcPeeringConnectionAccepterTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vpcPeeringConnectionIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VpcPeeringConnectionIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "autoAccept", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object AutoAccept
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

        [JsiiProperty(name: "vpcPeeringConnectionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VpcPeeringConnectionId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}

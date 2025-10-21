using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.VpcPeeringConnectionOptions
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_peering_connection_options aws_vpc_peering_connection_options}.</summary>
    [JsiiClass(nativeType: typeof(aws.VpcPeeringConnectionOptions.VpcPeeringConnectionOptions), fullyQualifiedName: "aws.vpcPeeringConnectionOptions.VpcPeeringConnectionOptions", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.vpcPeeringConnectionOptions.VpcPeeringConnectionOptionsConfig\"}}]")]
    public class VpcPeeringConnectionOptions : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_peering_connection_options aws_vpc_peering_connection_options} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public VpcPeeringConnectionOptions(Constructs.Construct scope, string id, aws.VpcPeeringConnectionOptions.IVpcPeeringConnectionOptionsConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.VpcPeeringConnectionOptions.IVpcPeeringConnectionOptionsConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VpcPeeringConnectionOptions(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VpcPeeringConnectionOptions(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a VpcPeeringConnectionOptions resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the VpcPeeringConnectionOptions to import.</param>
        /// <param name="importFromId">The id of the existing VpcPeeringConnectionOptions that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the VpcPeeringConnectionOptions to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the VpcPeeringConnectionOptions to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_peering_connection_options#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing VpcPeeringConnectionOptions that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the VpcPeeringConnectionOptions to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.VpcPeeringConnectionOptions.VpcPeeringConnectionOptions), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAccepter", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.vpcPeeringConnectionOptions.VpcPeeringConnectionOptionsAccepter\"}}]")]
        public virtual void PutAccepter(aws.VpcPeeringConnectionOptions.IVpcPeeringConnectionOptionsAccepter @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.VpcPeeringConnectionOptions.IVpcPeeringConnectionOptionsAccepter)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRequester", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.vpcPeeringConnectionOptions.VpcPeeringConnectionOptionsRequester\"}}]")]
        public virtual void PutRequester(aws.VpcPeeringConnectionOptions.IVpcPeeringConnectionOptionsRequester @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.VpcPeeringConnectionOptions.IVpcPeeringConnectionOptionsRequester)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAccepter")]
        public virtual void ResetAccepter()
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
        = GetStaticProperty<string>(typeof(aws.VpcPeeringConnectionOptions.VpcPeeringConnectionOptions))!;

        [JsiiProperty(name: "accepter", typeJson: "{\"fqn\":\"aws.vpcPeeringConnectionOptions.VpcPeeringConnectionOptionsAccepterOutputReference\"}")]
        public virtual aws.VpcPeeringConnectionOptions.VpcPeeringConnectionOptionsAccepterOutputReference Accepter
        {
            get => GetInstanceProperty<aws.VpcPeeringConnectionOptions.VpcPeeringConnectionOptionsAccepterOutputReference>()!;
        }

        [JsiiProperty(name: "requester", typeJson: "{\"fqn\":\"aws.vpcPeeringConnectionOptions.VpcPeeringConnectionOptionsRequesterOutputReference\"}")]
        public virtual aws.VpcPeeringConnectionOptions.VpcPeeringConnectionOptionsRequesterOutputReference Requester
        {
            get => GetInstanceProperty<aws.VpcPeeringConnectionOptions.VpcPeeringConnectionOptionsRequesterOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accepterInput", typeJson: "{\"fqn\":\"aws.vpcPeeringConnectionOptions.VpcPeeringConnectionOptionsAccepter\"}", isOptional: true)]
        public virtual aws.VpcPeeringConnectionOptions.IVpcPeeringConnectionOptionsAccepter? AccepterInput
        {
            get => GetInstanceProperty<aws.VpcPeeringConnectionOptions.IVpcPeeringConnectionOptionsAccepter?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "requesterInput", typeJson: "{\"fqn\":\"aws.vpcPeeringConnectionOptions.VpcPeeringConnectionOptionsRequester\"}", isOptional: true)]
        public virtual aws.VpcPeeringConnectionOptions.IVpcPeeringConnectionOptionsRequester? RequesterInput
        {
            get => GetInstanceProperty<aws.VpcPeeringConnectionOptions.IVpcPeeringConnectionOptionsRequester?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vpcPeeringConnectionIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VpcPeeringConnectionIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
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

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.VpcIpamPoolCidr
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipam_pool_cidr aws_vpc_ipam_pool_cidr}.</summary>
    [JsiiClass(nativeType: typeof(aws.VpcIpamPoolCidr.VpcIpamPoolCidr), fullyQualifiedName: "aws.vpcIpamPoolCidr.VpcIpamPoolCidr", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.vpcIpamPoolCidr.VpcIpamPoolCidrConfig\"}}]")]
    public class VpcIpamPoolCidr : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipam_pool_cidr aws_vpc_ipam_pool_cidr} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public VpcIpamPoolCidr(Constructs.Construct scope, string id, aws.VpcIpamPoolCidr.IVpcIpamPoolCidrConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.VpcIpamPoolCidr.IVpcIpamPoolCidrConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VpcIpamPoolCidr(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VpcIpamPoolCidr(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a VpcIpamPoolCidr resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the VpcIpamPoolCidr to import.</param>
        /// <param name="importFromId">The id of the existing VpcIpamPoolCidr that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the VpcIpamPoolCidr to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the VpcIpamPoolCidr to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipam_pool_cidr#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing VpcIpamPoolCidr that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the VpcIpamPoolCidr to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.VpcIpamPoolCidr.VpcIpamPoolCidr), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putCidrAuthorizationContext", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.vpcIpamPoolCidr.VpcIpamPoolCidrCidrAuthorizationContext\"}}]")]
        public virtual void PutCidrAuthorizationContext(aws.VpcIpamPoolCidr.IVpcIpamPoolCidrCidrAuthorizationContext @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.VpcIpamPoolCidr.IVpcIpamPoolCidrCidrAuthorizationContext)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.vpcIpamPoolCidr.VpcIpamPoolCidrTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.VpcIpamPoolCidr.IVpcIpamPoolCidrTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.VpcIpamPoolCidr.IVpcIpamPoolCidrTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCidr")]
        public virtual void ResetCidr()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCidrAuthorizationContext")]
        public virtual void ResetCidrAuthorizationContext()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetmaskLength")]
        public virtual void ResetNetmaskLength()
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
        = GetStaticProperty<string>(typeof(aws.VpcIpamPoolCidr.VpcIpamPoolCidr))!;

        [JsiiProperty(name: "cidrAuthorizationContext", typeJson: "{\"fqn\":\"aws.vpcIpamPoolCidr.VpcIpamPoolCidrCidrAuthorizationContextOutputReference\"}")]
        public virtual aws.VpcIpamPoolCidr.VpcIpamPoolCidrCidrAuthorizationContextOutputReference CidrAuthorizationContext
        {
            get => GetInstanceProperty<aws.VpcIpamPoolCidr.VpcIpamPoolCidrCidrAuthorizationContextOutputReference>()!;
        }

        [JsiiProperty(name: "ipamPoolCidrId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IpamPoolCidrId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.vpcIpamPoolCidr.VpcIpamPoolCidrTimeoutsOutputReference\"}")]
        public virtual aws.VpcIpamPoolCidr.VpcIpamPoolCidrTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.VpcIpamPoolCidr.VpcIpamPoolCidrTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cidrAuthorizationContextInput", typeJson: "{\"fqn\":\"aws.vpcIpamPoolCidr.VpcIpamPoolCidrCidrAuthorizationContext\"}", isOptional: true)]
        public virtual aws.VpcIpamPoolCidr.IVpcIpamPoolCidrCidrAuthorizationContext? CidrAuthorizationContextInput
        {
            get => GetInstanceProperty<aws.VpcIpamPoolCidr.IVpcIpamPoolCidrCidrAuthorizationContext?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cidrInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CidrInput
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
        [JsiiProperty(name: "ipamPoolIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IpamPoolIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "netmaskLengthInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? NetmaskLengthInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.vpcIpamPoolCidr.VpcIpamPoolCidrTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "cidr", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Cidr
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

        [JsiiProperty(name: "ipamPoolId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IpamPoolId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "netmaskLength", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NetmaskLength
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OpensearchVpcEndpoint
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_vpc_endpoint aws_opensearch_vpc_endpoint}.</summary>
    [JsiiClass(nativeType: typeof(aws.OpensearchVpcEndpoint.OpensearchVpcEndpoint), fullyQualifiedName: "aws.opensearchVpcEndpoint.OpensearchVpcEndpoint", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.opensearchVpcEndpoint.OpensearchVpcEndpointConfig\"}}]")]
    public class OpensearchVpcEndpoint : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_vpc_endpoint aws_opensearch_vpc_endpoint} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public OpensearchVpcEndpoint(Constructs.Construct scope, string id, aws.OpensearchVpcEndpoint.IOpensearchVpcEndpointConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.OpensearchVpcEndpoint.IOpensearchVpcEndpointConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OpensearchVpcEndpoint(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OpensearchVpcEndpoint(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a OpensearchVpcEndpoint resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the OpensearchVpcEndpoint to import.</param>
        /// <param name="importFromId">The id of the existing OpensearchVpcEndpoint that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the OpensearchVpcEndpoint to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the OpensearchVpcEndpoint to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_vpc_endpoint#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing OpensearchVpcEndpoint that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the OpensearchVpcEndpoint to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.OpensearchVpcEndpoint.OpensearchVpcEndpoint), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.opensearchVpcEndpoint.OpensearchVpcEndpointTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.OpensearchVpcEndpoint.IOpensearchVpcEndpointTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.OpensearchVpcEndpoint.IOpensearchVpcEndpointTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVpcOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.opensearchVpcEndpoint.OpensearchVpcEndpointVpcOptions\"}}]")]
        public virtual void PutVpcOptions(aws.OpensearchVpcEndpoint.IOpensearchVpcEndpointVpcOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.OpensearchVpcEndpoint.IOpensearchVpcEndpointVpcOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
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
        = GetStaticProperty<string>(typeof(aws.OpensearchVpcEndpoint.OpensearchVpcEndpoint))!;

        [JsiiProperty(name: "endpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Endpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.opensearchVpcEndpoint.OpensearchVpcEndpointTimeoutsOutputReference\"}")]
        public virtual aws.OpensearchVpcEndpoint.OpensearchVpcEndpointTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.OpensearchVpcEndpoint.OpensearchVpcEndpointTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "vpcOptions", typeJson: "{\"fqn\":\"aws.opensearchVpcEndpoint.OpensearchVpcEndpointVpcOptionsOutputReference\"}")]
        public virtual aws.OpensearchVpcEndpoint.OpensearchVpcEndpointVpcOptionsOutputReference VpcOptions
        {
            get => GetInstanceProperty<aws.OpensearchVpcEndpoint.OpensearchVpcEndpointVpcOptionsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "domainArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DomainArnInput
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
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.opensearchVpcEndpoint.OpensearchVpcEndpointTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vpcOptionsInput", typeJson: "{\"fqn\":\"aws.opensearchVpcEndpoint.OpensearchVpcEndpointVpcOptions\"}", isOptional: true)]
        public virtual aws.OpensearchVpcEndpoint.IOpensearchVpcEndpointVpcOptions? VpcOptionsInput
        {
            get => GetInstanceProperty<aws.OpensearchVpcEndpoint.IOpensearchVpcEndpointVpcOptions?>();
        }

        [JsiiProperty(name: "domainArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DomainArn
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
    }
}

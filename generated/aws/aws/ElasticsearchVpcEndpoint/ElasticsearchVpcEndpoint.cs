using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ElasticsearchVpcEndpoint
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticsearch_vpc_endpoint aws_elasticsearch_vpc_endpoint}.</summary>
    [JsiiClass(nativeType: typeof(aws.ElasticsearchVpcEndpoint.ElasticsearchVpcEndpoint), fullyQualifiedName: "aws.elasticsearchVpcEndpoint.ElasticsearchVpcEndpoint", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.elasticsearchVpcEndpoint.ElasticsearchVpcEndpointConfig\"}}]")]
    public class ElasticsearchVpcEndpoint : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticsearch_vpc_endpoint aws_elasticsearch_vpc_endpoint} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ElasticsearchVpcEndpoint(Constructs.Construct scope, string id, aws.ElasticsearchVpcEndpoint.IElasticsearchVpcEndpointConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.ElasticsearchVpcEndpoint.IElasticsearchVpcEndpointConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ElasticsearchVpcEndpoint(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ElasticsearchVpcEndpoint(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a ElasticsearchVpcEndpoint resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the ElasticsearchVpcEndpoint to import.</param>
        /// <param name="importFromId">The id of the existing ElasticsearchVpcEndpoint that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the ElasticsearchVpcEndpoint to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the ElasticsearchVpcEndpoint to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticsearch_vpc_endpoint#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing ElasticsearchVpcEndpoint that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the ElasticsearchVpcEndpoint to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.ElasticsearchVpcEndpoint.ElasticsearchVpcEndpoint), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.elasticsearchVpcEndpoint.ElasticsearchVpcEndpointTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.ElasticsearchVpcEndpoint.IElasticsearchVpcEndpointTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.ElasticsearchVpcEndpoint.IElasticsearchVpcEndpointTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVpcOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.elasticsearchVpcEndpoint.ElasticsearchVpcEndpointVpcOptions\"}}]")]
        public virtual void PutVpcOptions(aws.ElasticsearchVpcEndpoint.IElasticsearchVpcEndpointVpcOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.ElasticsearchVpcEndpoint.IElasticsearchVpcEndpointVpcOptions)}, new object[]{@value});
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
        = GetStaticProperty<string>(typeof(aws.ElasticsearchVpcEndpoint.ElasticsearchVpcEndpoint))!;

        [JsiiProperty(name: "endpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Endpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.elasticsearchVpcEndpoint.ElasticsearchVpcEndpointTimeoutsOutputReference\"}")]
        public virtual aws.ElasticsearchVpcEndpoint.ElasticsearchVpcEndpointTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.ElasticsearchVpcEndpoint.ElasticsearchVpcEndpointTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "vpcOptions", typeJson: "{\"fqn\":\"aws.elasticsearchVpcEndpoint.ElasticsearchVpcEndpointVpcOptionsOutputReference\"}")]
        public virtual aws.ElasticsearchVpcEndpoint.ElasticsearchVpcEndpointVpcOptionsOutputReference VpcOptions
        {
            get => GetInstanceProperty<aws.ElasticsearchVpcEndpoint.ElasticsearchVpcEndpointVpcOptionsOutputReference>()!;
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
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.elasticsearchVpcEndpoint.ElasticsearchVpcEndpointTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vpcOptionsInput", typeJson: "{\"fqn\":\"aws.elasticsearchVpcEndpoint.ElasticsearchVpcEndpointVpcOptions\"}", isOptional: true)]
        public virtual aws.ElasticsearchVpcEndpoint.IElasticsearchVpcEndpointVpcOptions? VpcOptionsInput
        {
            get => GetInstanceProperty<aws.ElasticsearchVpcEndpoint.IElasticsearchVpcEndpointVpcOptions?>();
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

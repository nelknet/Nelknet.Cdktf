using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ElasticsearchDomainSamlOptions
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticsearch_domain_saml_options aws_elasticsearch_domain_saml_options}.</summary>
    [JsiiClass(nativeType: typeof(aws.ElasticsearchDomainSamlOptions.ElasticsearchDomainSamlOptions), fullyQualifiedName: "aws.elasticsearchDomainSamlOptions.ElasticsearchDomainSamlOptions", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.elasticsearchDomainSamlOptions.ElasticsearchDomainSamlOptionsConfig\"}}]")]
    public class ElasticsearchDomainSamlOptions : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticsearch_domain_saml_options aws_elasticsearch_domain_saml_options} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ElasticsearchDomainSamlOptions(Constructs.Construct scope, string id, aws.ElasticsearchDomainSamlOptions.IElasticsearchDomainSamlOptionsConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.ElasticsearchDomainSamlOptions.IElasticsearchDomainSamlOptionsConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ElasticsearchDomainSamlOptions(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ElasticsearchDomainSamlOptions(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a ElasticsearchDomainSamlOptions resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the ElasticsearchDomainSamlOptions to import.</param>
        /// <param name="importFromId">The id of the existing ElasticsearchDomainSamlOptions that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the ElasticsearchDomainSamlOptions to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the ElasticsearchDomainSamlOptions to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticsearch_domain_saml_options#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing ElasticsearchDomainSamlOptions that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the ElasticsearchDomainSamlOptions to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.ElasticsearchDomainSamlOptions.ElasticsearchDomainSamlOptions), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putSamlOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.elasticsearchDomainSamlOptions.ElasticsearchDomainSamlOptionsSamlOptions\"}}]")]
        public virtual void PutSamlOptions(aws.ElasticsearchDomainSamlOptions.IElasticsearchDomainSamlOptionsSamlOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.ElasticsearchDomainSamlOptions.IElasticsearchDomainSamlOptionsSamlOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.elasticsearchDomainSamlOptions.ElasticsearchDomainSamlOptionsTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.ElasticsearchDomainSamlOptions.IElasticsearchDomainSamlOptionsTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.ElasticsearchDomainSamlOptions.IElasticsearchDomainSamlOptionsTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSamlOptions")]
        public virtual void ResetSamlOptions()
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
        = GetStaticProperty<string>(typeof(aws.ElasticsearchDomainSamlOptions.ElasticsearchDomainSamlOptions))!;

        [JsiiProperty(name: "samlOptions", typeJson: "{\"fqn\":\"aws.elasticsearchDomainSamlOptions.ElasticsearchDomainSamlOptionsSamlOptionsOutputReference\"}")]
        public virtual aws.ElasticsearchDomainSamlOptions.ElasticsearchDomainSamlOptionsSamlOptionsOutputReference SamlOptions
        {
            get => GetInstanceProperty<aws.ElasticsearchDomainSamlOptions.ElasticsearchDomainSamlOptionsSamlOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.elasticsearchDomainSamlOptions.ElasticsearchDomainSamlOptionsTimeoutsOutputReference\"}")]
        public virtual aws.ElasticsearchDomainSamlOptions.ElasticsearchDomainSamlOptionsTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.ElasticsearchDomainSamlOptions.ElasticsearchDomainSamlOptionsTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "domainNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DomainNameInput
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
        [JsiiProperty(name: "samlOptionsInput", typeJson: "{\"fqn\":\"aws.elasticsearchDomainSamlOptions.ElasticsearchDomainSamlOptionsSamlOptions\"}", isOptional: true)]
        public virtual aws.ElasticsearchDomainSamlOptions.IElasticsearchDomainSamlOptionsSamlOptions? SamlOptionsInput
        {
            get => GetInstanceProperty<aws.ElasticsearchDomainSamlOptions.IElasticsearchDomainSamlOptionsSamlOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.elasticsearchDomainSamlOptions.ElasticsearchDomainSamlOptionsTimeouts\"}]}}", isOptional: true)]
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

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}

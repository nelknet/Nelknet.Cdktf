using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apigatewayv2DomainName
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_domain_name aws_apigatewayv2_domain_name}.</summary>
    [JsiiClass(nativeType: typeof(aws.Apigatewayv2DomainName.Apigatewayv2DomainName), fullyQualifiedName: "aws.apigatewayv2DomainName.Apigatewayv2DomainName", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.apigatewayv2DomainName.Apigatewayv2DomainNameConfig\"}}]")]
    public class Apigatewayv2DomainName : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_domain_name aws_apigatewayv2_domain_name} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public Apigatewayv2DomainName(Constructs.Construct scope, string id, aws.Apigatewayv2DomainName.IApigatewayv2DomainNameConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.Apigatewayv2DomainName.IApigatewayv2DomainNameConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Apigatewayv2DomainName(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Apigatewayv2DomainName(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a Apigatewayv2DomainName resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the Apigatewayv2DomainName to import.</param>
        /// <param name="importFromId">The id of the existing Apigatewayv2DomainName that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the Apigatewayv2DomainName to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the Apigatewayv2DomainName to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_domain_name#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing Apigatewayv2DomainName that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the Apigatewayv2DomainName to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.Apigatewayv2DomainName.Apigatewayv2DomainName), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putDomainNameConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.apigatewayv2DomainName.Apigatewayv2DomainNameDomainNameConfiguration\"}}]")]
        public virtual void PutDomainNameConfiguration(aws.Apigatewayv2DomainName.IApigatewayv2DomainNameDomainNameConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Apigatewayv2DomainName.IApigatewayv2DomainNameDomainNameConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMutualTlsAuthentication", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.apigatewayv2DomainName.Apigatewayv2DomainNameMutualTlsAuthentication\"}}]")]
        public virtual void PutMutualTlsAuthentication(aws.Apigatewayv2DomainName.IApigatewayv2DomainNameMutualTlsAuthentication @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Apigatewayv2DomainName.IApigatewayv2DomainNameMutualTlsAuthentication)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.apigatewayv2DomainName.Apigatewayv2DomainNameTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.Apigatewayv2DomainName.IApigatewayv2DomainNameTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Apigatewayv2DomainName.IApigatewayv2DomainNameTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMutualTlsAuthentication")]
        public virtual void ResetMutualTlsAuthentication()
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
        = GetStaticProperty<string>(typeof(aws.Apigatewayv2DomainName.Apigatewayv2DomainName))!;

        [JsiiProperty(name: "apiMappingSelectionExpression", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApiMappingSelectionExpression
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "domainNameConfiguration", typeJson: "{\"fqn\":\"aws.apigatewayv2DomainName.Apigatewayv2DomainNameDomainNameConfigurationOutputReference\"}")]
        public virtual aws.Apigatewayv2DomainName.Apigatewayv2DomainNameDomainNameConfigurationOutputReference DomainNameConfiguration
        {
            get => GetInstanceProperty<aws.Apigatewayv2DomainName.Apigatewayv2DomainNameDomainNameConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "mutualTlsAuthentication", typeJson: "{\"fqn\":\"aws.apigatewayv2DomainName.Apigatewayv2DomainNameMutualTlsAuthenticationOutputReference\"}")]
        public virtual aws.Apigatewayv2DomainName.Apigatewayv2DomainNameMutualTlsAuthenticationOutputReference MutualTlsAuthentication
        {
            get => GetInstanceProperty<aws.Apigatewayv2DomainName.Apigatewayv2DomainNameMutualTlsAuthenticationOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.apigatewayv2DomainName.Apigatewayv2DomainNameTimeoutsOutputReference\"}")]
        public virtual aws.Apigatewayv2DomainName.Apigatewayv2DomainNameTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.Apigatewayv2DomainName.Apigatewayv2DomainNameTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "domainNameConfigurationInput", typeJson: "{\"fqn\":\"aws.apigatewayv2DomainName.Apigatewayv2DomainNameDomainNameConfiguration\"}", isOptional: true)]
        public virtual aws.Apigatewayv2DomainName.IApigatewayv2DomainNameDomainNameConfiguration? DomainNameConfigurationInput
        {
            get => GetInstanceProperty<aws.Apigatewayv2DomainName.IApigatewayv2DomainNameDomainNameConfiguration?>();
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
        [JsiiProperty(name: "mutualTlsAuthenticationInput", typeJson: "{\"fqn\":\"aws.apigatewayv2DomainName.Apigatewayv2DomainNameMutualTlsAuthentication\"}", isOptional: true)]
        public virtual aws.Apigatewayv2DomainName.IApigatewayv2DomainNameMutualTlsAuthentication? MutualTlsAuthenticationInput
        {
            get => GetInstanceProperty<aws.Apigatewayv2DomainName.IApigatewayv2DomainNameMutualTlsAuthentication?>();
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
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.apigatewayv2DomainName.Apigatewayv2DomainNameTimeouts\"}]}}", isOptional: true)]
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

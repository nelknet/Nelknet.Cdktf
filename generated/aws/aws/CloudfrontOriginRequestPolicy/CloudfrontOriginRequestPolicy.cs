using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontOriginRequestPolicy
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_origin_request_policy aws_cloudfront_origin_request_policy}.</summary>
    [JsiiClass(nativeType: typeof(aws.CloudfrontOriginRequestPolicy.CloudfrontOriginRequestPolicy), fullyQualifiedName: "aws.cloudfrontOriginRequestPolicy.CloudfrontOriginRequestPolicy", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.cloudfrontOriginRequestPolicy.CloudfrontOriginRequestPolicyConfig\"}}]")]
    public class CloudfrontOriginRequestPolicy : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_origin_request_policy aws_cloudfront_origin_request_policy} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public CloudfrontOriginRequestPolicy(Constructs.Construct scope, string id, aws.CloudfrontOriginRequestPolicy.ICloudfrontOriginRequestPolicyConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.CloudfrontOriginRequestPolicy.ICloudfrontOriginRequestPolicyConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudfrontOriginRequestPolicy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudfrontOriginRequestPolicy(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a CloudfrontOriginRequestPolicy resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the CloudfrontOriginRequestPolicy to import.</param>
        /// <param name="importFromId">The id of the existing CloudfrontOriginRequestPolicy that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the CloudfrontOriginRequestPolicy to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the CloudfrontOriginRequestPolicy to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_origin_request_policy#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing CloudfrontOriginRequestPolicy that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the CloudfrontOriginRequestPolicy to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.CloudfrontOriginRequestPolicy.CloudfrontOriginRequestPolicy), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putCookiesConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudfrontOriginRequestPolicy.CloudfrontOriginRequestPolicyCookiesConfig\"}}]")]
        public virtual void PutCookiesConfig(aws.CloudfrontOriginRequestPolicy.ICloudfrontOriginRequestPolicyCookiesConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CloudfrontOriginRequestPolicy.ICloudfrontOriginRequestPolicyCookiesConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHeadersConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudfrontOriginRequestPolicy.CloudfrontOriginRequestPolicyHeadersConfig\"}}]")]
        public virtual void PutHeadersConfig(aws.CloudfrontOriginRequestPolicy.ICloudfrontOriginRequestPolicyHeadersConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CloudfrontOriginRequestPolicy.ICloudfrontOriginRequestPolicyHeadersConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putQueryStringsConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudfrontOriginRequestPolicy.CloudfrontOriginRequestPolicyQueryStringsConfig\"}}]")]
        public virtual void PutQueryStringsConfig(aws.CloudfrontOriginRequestPolicy.ICloudfrontOriginRequestPolicyQueryStringsConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CloudfrontOriginRequestPolicy.ICloudfrontOriginRequestPolicyQueryStringsConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetComment")]
        public virtual void ResetComment()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
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
        = GetStaticProperty<string>(typeof(aws.CloudfrontOriginRequestPolicy.CloudfrontOriginRequestPolicy))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "cookiesConfig", typeJson: "{\"fqn\":\"aws.cloudfrontOriginRequestPolicy.CloudfrontOriginRequestPolicyCookiesConfigOutputReference\"}")]
        public virtual aws.CloudfrontOriginRequestPolicy.CloudfrontOriginRequestPolicyCookiesConfigOutputReference CookiesConfig
        {
            get => GetInstanceProperty<aws.CloudfrontOriginRequestPolicy.CloudfrontOriginRequestPolicyCookiesConfigOutputReference>()!;
        }

        [JsiiProperty(name: "etag", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Etag
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "headersConfig", typeJson: "{\"fqn\":\"aws.cloudfrontOriginRequestPolicy.CloudfrontOriginRequestPolicyHeadersConfigOutputReference\"}")]
        public virtual aws.CloudfrontOriginRequestPolicy.CloudfrontOriginRequestPolicyHeadersConfigOutputReference HeadersConfig
        {
            get => GetInstanceProperty<aws.CloudfrontOriginRequestPolicy.CloudfrontOriginRequestPolicyHeadersConfigOutputReference>()!;
        }

        [JsiiProperty(name: "queryStringsConfig", typeJson: "{\"fqn\":\"aws.cloudfrontOriginRequestPolicy.CloudfrontOriginRequestPolicyQueryStringsConfigOutputReference\"}")]
        public virtual aws.CloudfrontOriginRequestPolicy.CloudfrontOriginRequestPolicyQueryStringsConfigOutputReference QueryStringsConfig
        {
            get => GetInstanceProperty<aws.CloudfrontOriginRequestPolicy.CloudfrontOriginRequestPolicyQueryStringsConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "commentInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CommentInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cookiesConfigInput", typeJson: "{\"fqn\":\"aws.cloudfrontOriginRequestPolicy.CloudfrontOriginRequestPolicyCookiesConfig\"}", isOptional: true)]
        public virtual aws.CloudfrontOriginRequestPolicy.ICloudfrontOriginRequestPolicyCookiesConfig? CookiesConfigInput
        {
            get => GetInstanceProperty<aws.CloudfrontOriginRequestPolicy.ICloudfrontOriginRequestPolicyCookiesConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "headersConfigInput", typeJson: "{\"fqn\":\"aws.cloudfrontOriginRequestPolicy.CloudfrontOriginRequestPolicyHeadersConfig\"}", isOptional: true)]
        public virtual aws.CloudfrontOriginRequestPolicy.ICloudfrontOriginRequestPolicyHeadersConfig? HeadersConfigInput
        {
            get => GetInstanceProperty<aws.CloudfrontOriginRequestPolicy.ICloudfrontOriginRequestPolicyHeadersConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "queryStringsConfigInput", typeJson: "{\"fqn\":\"aws.cloudfrontOriginRequestPolicy.CloudfrontOriginRequestPolicyQueryStringsConfig\"}", isOptional: true)]
        public virtual aws.CloudfrontOriginRequestPolicy.ICloudfrontOriginRequestPolicyQueryStringsConfig? QueryStringsConfigInput
        {
            get => GetInstanceProperty<aws.CloudfrontOriginRequestPolicy.ICloudfrontOriginRequestPolicyQueryStringsConfig?>();
        }

        [JsiiProperty(name: "comment", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Comment
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

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}

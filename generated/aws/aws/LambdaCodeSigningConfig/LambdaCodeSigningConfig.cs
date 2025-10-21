using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LambdaCodeSigningConfig
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_code_signing_config aws_lambda_code_signing_config}.</summary>
    [JsiiClass(nativeType: typeof(aws.LambdaCodeSigningConfig.LambdaCodeSigningConfig), fullyQualifiedName: "aws.lambdaCodeSigningConfig.LambdaCodeSigningConfig", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.lambdaCodeSigningConfig.LambdaCodeSigningConfigConfig\"}}]")]
    public class LambdaCodeSigningConfig : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_code_signing_config aws_lambda_code_signing_config} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public LambdaCodeSigningConfig(Constructs.Construct scope, string id, aws.LambdaCodeSigningConfig.ILambdaCodeSigningConfigConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.LambdaCodeSigningConfig.ILambdaCodeSigningConfigConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LambdaCodeSigningConfig(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LambdaCodeSigningConfig(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a LambdaCodeSigningConfig resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the LambdaCodeSigningConfig to import.</param>
        /// <param name="importFromId">The id of the existing LambdaCodeSigningConfig that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the LambdaCodeSigningConfig to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the LambdaCodeSigningConfig to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_code_signing_config#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing LambdaCodeSigningConfig that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the LambdaCodeSigningConfig to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.LambdaCodeSigningConfig.LambdaCodeSigningConfig), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAllowedPublishers", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lambdaCodeSigningConfig.LambdaCodeSigningConfigAllowedPublishers\"}}]")]
        public virtual void PutAllowedPublishers(aws.LambdaCodeSigningConfig.ILambdaCodeSigningConfigAllowedPublishers @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LambdaCodeSigningConfig.ILambdaCodeSigningConfigAllowedPublishers)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPolicies", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lambdaCodeSigningConfig.LambdaCodeSigningConfigPolicies\"}}]")]
        public virtual void PutPolicies(aws.LambdaCodeSigningConfig.ILambdaCodeSigningConfigPolicies @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LambdaCodeSigningConfig.ILambdaCodeSigningConfigPolicies)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPolicies")]
        public virtual void ResetPolicies()
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
        = GetStaticProperty<string>(typeof(aws.LambdaCodeSigningConfig.LambdaCodeSigningConfig))!;

        [JsiiProperty(name: "allowedPublishers", typeJson: "{\"fqn\":\"aws.lambdaCodeSigningConfig.LambdaCodeSigningConfigAllowedPublishersOutputReference\"}")]
        public virtual aws.LambdaCodeSigningConfig.LambdaCodeSigningConfigAllowedPublishersOutputReference AllowedPublishers
        {
            get => GetInstanceProperty<aws.LambdaCodeSigningConfig.LambdaCodeSigningConfigAllowedPublishersOutputReference>()!;
        }

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "configId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConfigId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lastModified", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastModified
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "policies", typeJson: "{\"fqn\":\"aws.lambdaCodeSigningConfig.LambdaCodeSigningConfigPoliciesOutputReference\"}")]
        public virtual aws.LambdaCodeSigningConfig.LambdaCodeSigningConfigPoliciesOutputReference Policies
        {
            get => GetInstanceProperty<aws.LambdaCodeSigningConfig.LambdaCodeSigningConfigPoliciesOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "allowedPublishersInput", typeJson: "{\"fqn\":\"aws.lambdaCodeSigningConfig.LambdaCodeSigningConfigAllowedPublishers\"}", isOptional: true)]
        public virtual aws.LambdaCodeSigningConfig.ILambdaCodeSigningConfigAllowedPublishers? AllowedPublishersInput
        {
            get => GetInstanceProperty<aws.LambdaCodeSigningConfig.ILambdaCodeSigningConfigAllowedPublishers?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
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
        [JsiiProperty(name: "policiesInput", typeJson: "{\"fqn\":\"aws.lambdaCodeSigningConfig.LambdaCodeSigningConfigPolicies\"}", isOptional: true)]
        public virtual aws.LambdaCodeSigningConfig.ILambdaCodeSigningConfigPolicies? PoliciesInput
        {
            get => GetInstanceProperty<aws.LambdaCodeSigningConfig.ILambdaCodeSigningConfigPolicies?>();
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

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
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

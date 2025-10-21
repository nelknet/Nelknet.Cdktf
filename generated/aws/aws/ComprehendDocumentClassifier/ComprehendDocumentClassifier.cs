using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ComprehendDocumentClassifier
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/comprehend_document_classifier aws_comprehend_document_classifier}.</summary>
    [JsiiClass(nativeType: typeof(aws.ComprehendDocumentClassifier.ComprehendDocumentClassifier), fullyQualifiedName: "aws.comprehendDocumentClassifier.ComprehendDocumentClassifier", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.comprehendDocumentClassifier.ComprehendDocumentClassifierConfig\"}}]")]
    public class ComprehendDocumentClassifier : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/comprehend_document_classifier aws_comprehend_document_classifier} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ComprehendDocumentClassifier(Constructs.Construct scope, string id, aws.ComprehendDocumentClassifier.IComprehendDocumentClassifierConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.ComprehendDocumentClassifier.IComprehendDocumentClassifierConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ComprehendDocumentClassifier(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ComprehendDocumentClassifier(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a ComprehendDocumentClassifier resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the ComprehendDocumentClassifier to import.</param>
        /// <param name="importFromId">The id of the existing ComprehendDocumentClassifier that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the ComprehendDocumentClassifier to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the ComprehendDocumentClassifier to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/comprehend_document_classifier#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing ComprehendDocumentClassifier that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the ComprehendDocumentClassifier to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.ComprehendDocumentClassifier.ComprehendDocumentClassifier), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putInputDataConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.comprehendDocumentClassifier.ComprehendDocumentClassifierInputDataConfig\"}}]")]
        public virtual void PutInputDataConfig(aws.ComprehendDocumentClassifier.IComprehendDocumentClassifierInputDataConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.ComprehendDocumentClassifier.IComprehendDocumentClassifierInputDataConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOutputDataConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.comprehendDocumentClassifier.ComprehendDocumentClassifierOutputDataConfig\"}}]")]
        public virtual void PutOutputDataConfig(aws.ComprehendDocumentClassifier.IComprehendDocumentClassifierOutputDataConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.ComprehendDocumentClassifier.IComprehendDocumentClassifierOutputDataConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.comprehendDocumentClassifier.ComprehendDocumentClassifierTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.ComprehendDocumentClassifier.IComprehendDocumentClassifierTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.ComprehendDocumentClassifier.IComprehendDocumentClassifierTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVpcConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.comprehendDocumentClassifier.ComprehendDocumentClassifierVpcConfig\"}}]")]
        public virtual void PutVpcConfig(aws.ComprehendDocumentClassifier.IComprehendDocumentClassifierVpcConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.ComprehendDocumentClassifier.IComprehendDocumentClassifierVpcConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMode")]
        public virtual void ResetMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetModelKmsKeyId")]
        public virtual void ResetModelKmsKeyId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOutputDataConfig")]
        public virtual void ResetOutputDataConfig()
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

        [JsiiMethod(name: "resetVersionName")]
        public virtual void ResetVersionName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVersionNamePrefix")]
        public virtual void ResetVersionNamePrefix()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVolumeKmsKeyId")]
        public virtual void ResetVolumeKmsKeyId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVpcConfig")]
        public virtual void ResetVpcConfig()
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
        = GetStaticProperty<string>(typeof(aws.ComprehendDocumentClassifier.ComprehendDocumentClassifier))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "inputDataConfig", typeJson: "{\"fqn\":\"aws.comprehendDocumentClassifier.ComprehendDocumentClassifierInputDataConfigOutputReference\"}")]
        public virtual aws.ComprehendDocumentClassifier.ComprehendDocumentClassifierInputDataConfigOutputReference InputDataConfig
        {
            get => GetInstanceProperty<aws.ComprehendDocumentClassifier.ComprehendDocumentClassifierInputDataConfigOutputReference>()!;
        }

        [JsiiProperty(name: "outputDataConfig", typeJson: "{\"fqn\":\"aws.comprehendDocumentClassifier.ComprehendDocumentClassifierOutputDataConfigOutputReference\"}")]
        public virtual aws.ComprehendDocumentClassifier.ComprehendDocumentClassifierOutputDataConfigOutputReference OutputDataConfig
        {
            get => GetInstanceProperty<aws.ComprehendDocumentClassifier.ComprehendDocumentClassifierOutputDataConfigOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.comprehendDocumentClassifier.ComprehendDocumentClassifierTimeoutsOutputReference\"}")]
        public virtual aws.ComprehendDocumentClassifier.ComprehendDocumentClassifierTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.ComprehendDocumentClassifier.ComprehendDocumentClassifierTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "vpcConfig", typeJson: "{\"fqn\":\"aws.comprehendDocumentClassifier.ComprehendDocumentClassifierVpcConfigOutputReference\"}")]
        public virtual aws.ComprehendDocumentClassifier.ComprehendDocumentClassifierVpcConfigOutputReference VpcConfig
        {
            get => GetInstanceProperty<aws.ComprehendDocumentClassifier.ComprehendDocumentClassifierVpcConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataAccessRoleArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DataAccessRoleArnInput
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
        [JsiiProperty(name: "inputDataConfigInput", typeJson: "{\"fqn\":\"aws.comprehendDocumentClassifier.ComprehendDocumentClassifierInputDataConfig\"}", isOptional: true)]
        public virtual aws.ComprehendDocumentClassifier.IComprehendDocumentClassifierInputDataConfig? InputDataConfigInput
        {
            get => GetInstanceProperty<aws.ComprehendDocumentClassifier.IComprehendDocumentClassifierInputDataConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "languageCodeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LanguageCodeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "modeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "modelKmsKeyIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ModelKmsKeyIdInput
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
        [JsiiProperty(name: "outputDataConfigInput", typeJson: "{\"fqn\":\"aws.comprehendDocumentClassifier.ComprehendDocumentClassifierOutputDataConfig\"}", isOptional: true)]
        public virtual aws.ComprehendDocumentClassifier.IComprehendDocumentClassifierOutputDataConfig? OutputDataConfigInput
        {
            get => GetInstanceProperty<aws.ComprehendDocumentClassifier.IComprehendDocumentClassifierOutputDataConfig?>();
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
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.comprehendDocumentClassifier.ComprehendDocumentClassifierTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "versionNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VersionNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "versionNamePrefixInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VersionNamePrefixInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "volumeKmsKeyIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VolumeKmsKeyIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vpcConfigInput", typeJson: "{\"fqn\":\"aws.comprehendDocumentClassifier.ComprehendDocumentClassifierVpcConfig\"}", isOptional: true)]
        public virtual aws.ComprehendDocumentClassifier.IComprehendDocumentClassifierVpcConfig? VpcConfigInput
        {
            get => GetInstanceProperty<aws.ComprehendDocumentClassifier.IComprehendDocumentClassifierVpcConfig?>();
        }

        [JsiiProperty(name: "dataAccessRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DataAccessRoleArn
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

        [JsiiProperty(name: "languageCode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LanguageCode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Mode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "modelKmsKeyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ModelKmsKeyId
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

        [JsiiProperty(name: "versionName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VersionName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "versionNamePrefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VersionNamePrefix
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "volumeKmsKeyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VolumeKmsKeyId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}

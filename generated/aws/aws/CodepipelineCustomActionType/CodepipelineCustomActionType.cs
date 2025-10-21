using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CodepipelineCustomActionType
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline_custom_action_type aws_codepipeline_custom_action_type}.</summary>
    [JsiiClass(nativeType: typeof(aws.CodepipelineCustomActionType.CodepipelineCustomActionType), fullyQualifiedName: "aws.codepipelineCustomActionType.CodepipelineCustomActionType", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.codepipelineCustomActionType.CodepipelineCustomActionTypeConfig\"}}]")]
    public class CodepipelineCustomActionType : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline_custom_action_type aws_codepipeline_custom_action_type} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public CodepipelineCustomActionType(Constructs.Construct scope, string id, aws.CodepipelineCustomActionType.ICodepipelineCustomActionTypeConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.CodepipelineCustomActionType.ICodepipelineCustomActionTypeConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CodepipelineCustomActionType(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CodepipelineCustomActionType(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a CodepipelineCustomActionType resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the CodepipelineCustomActionType to import.</param>
        /// <param name="importFromId">The id of the existing CodepipelineCustomActionType that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the CodepipelineCustomActionType to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the CodepipelineCustomActionType to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline_custom_action_type#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing CodepipelineCustomActionType that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the CodepipelineCustomActionType to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.CodepipelineCustomActionType.CodepipelineCustomActionType), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putConfigurationProperty", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codepipelineCustomActionType.CodepipelineCustomActionTypeConfigurationProperty\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutConfigurationProperty(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.CodepipelineCustomActionType.ICodepipelineCustomActionTypeConfigurationProperty[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.CodepipelineCustomActionType.ICodepipelineCustomActionTypeConfigurationProperty).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.CodepipelineCustomActionType.ICodepipelineCustomActionTypeConfigurationProperty).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putInputArtifactDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.codepipelineCustomActionType.CodepipelineCustomActionTypeInputArtifactDetails\"}}]")]
        public virtual void PutInputArtifactDetails(aws.CodepipelineCustomActionType.ICodepipelineCustomActionTypeInputArtifactDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CodepipelineCustomActionType.ICodepipelineCustomActionTypeInputArtifactDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOutputArtifactDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.codepipelineCustomActionType.CodepipelineCustomActionTypeOutputArtifactDetails\"}}]")]
        public virtual void PutOutputArtifactDetails(aws.CodepipelineCustomActionType.ICodepipelineCustomActionTypeOutputArtifactDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CodepipelineCustomActionType.ICodepipelineCustomActionTypeOutputArtifactDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.codepipelineCustomActionType.CodepipelineCustomActionTypeSettings\"}}]")]
        public virtual void PutSettings(aws.CodepipelineCustomActionType.ICodepipelineCustomActionTypeSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CodepipelineCustomActionType.ICodepipelineCustomActionTypeSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetConfigurationProperty")]
        public virtual void ResetConfigurationProperty()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSettings")]
        public virtual void ResetSettings()
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
        = GetStaticProperty<string>(typeof(aws.CodepipelineCustomActionType.CodepipelineCustomActionType))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "configurationProperty", typeJson: "{\"fqn\":\"aws.codepipelineCustomActionType.CodepipelineCustomActionTypeConfigurationPropertyList\"}")]
        public virtual aws.CodepipelineCustomActionType.CodepipelineCustomActionTypeConfigurationPropertyList ConfigurationProperty
        {
            get => GetInstanceProperty<aws.CodepipelineCustomActionType.CodepipelineCustomActionTypeConfigurationPropertyList>()!;
        }

        [JsiiProperty(name: "inputArtifactDetails", typeJson: "{\"fqn\":\"aws.codepipelineCustomActionType.CodepipelineCustomActionTypeInputArtifactDetailsOutputReference\"}")]
        public virtual aws.CodepipelineCustomActionType.CodepipelineCustomActionTypeInputArtifactDetailsOutputReference InputArtifactDetails
        {
            get => GetInstanceProperty<aws.CodepipelineCustomActionType.CodepipelineCustomActionTypeInputArtifactDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "outputArtifactDetails", typeJson: "{\"fqn\":\"aws.codepipelineCustomActionType.CodepipelineCustomActionTypeOutputArtifactDetailsOutputReference\"}")]
        public virtual aws.CodepipelineCustomActionType.CodepipelineCustomActionTypeOutputArtifactDetailsOutputReference OutputArtifactDetails
        {
            get => GetInstanceProperty<aws.CodepipelineCustomActionType.CodepipelineCustomActionTypeOutputArtifactDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "owner", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Owner
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "settings", typeJson: "{\"fqn\":\"aws.codepipelineCustomActionType.CodepipelineCustomActionTypeSettingsOutputReference\"}")]
        public virtual aws.CodepipelineCustomActionType.CodepipelineCustomActionTypeSettingsOutputReference Settings
        {
            get => GetInstanceProperty<aws.CodepipelineCustomActionType.CodepipelineCustomActionTypeSettingsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "categoryInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CategoryInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "configurationPropertyInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codepipelineCustomActionType.CodepipelineCustomActionTypeConfigurationProperty\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ConfigurationPropertyInput
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
        [JsiiProperty(name: "inputArtifactDetailsInput", typeJson: "{\"fqn\":\"aws.codepipelineCustomActionType.CodepipelineCustomActionTypeInputArtifactDetails\"}", isOptional: true)]
        public virtual aws.CodepipelineCustomActionType.ICodepipelineCustomActionTypeInputArtifactDetails? InputArtifactDetailsInput
        {
            get => GetInstanceProperty<aws.CodepipelineCustomActionType.ICodepipelineCustomActionTypeInputArtifactDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "outputArtifactDetailsInput", typeJson: "{\"fqn\":\"aws.codepipelineCustomActionType.CodepipelineCustomActionTypeOutputArtifactDetails\"}", isOptional: true)]
        public virtual aws.CodepipelineCustomActionType.ICodepipelineCustomActionTypeOutputArtifactDetails? OutputArtifactDetailsInput
        {
            get => GetInstanceProperty<aws.CodepipelineCustomActionType.ICodepipelineCustomActionTypeOutputArtifactDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "providerNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ProviderNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "settingsInput", typeJson: "{\"fqn\":\"aws.codepipelineCustomActionType.CodepipelineCustomActionTypeSettings\"}", isOptional: true)]
        public virtual aws.CodepipelineCustomActionType.ICodepipelineCustomActionTypeSettings? SettingsInput
        {
            get => GetInstanceProperty<aws.CodepipelineCustomActionType.ICodepipelineCustomActionTypeSettings?>();
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
        [JsiiProperty(name: "versionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "category", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Category
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

        [JsiiProperty(name: "providerName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProviderName
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

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Version
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}

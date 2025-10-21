using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ElastictranscoderPreset
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastictranscoder_preset aws_elastictranscoder_preset}.</summary>
    [JsiiClass(nativeType: typeof(aws.ElastictranscoderPreset.ElastictranscoderPreset), fullyQualifiedName: "aws.elastictranscoderPreset.ElastictranscoderPreset", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.elastictranscoderPreset.ElastictranscoderPresetConfig\"}}]")]
    public class ElastictranscoderPreset : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastictranscoder_preset aws_elastictranscoder_preset} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ElastictranscoderPreset(Constructs.Construct scope, string id, aws.ElastictranscoderPreset.IElastictranscoderPresetConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.ElastictranscoderPreset.IElastictranscoderPresetConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ElastictranscoderPreset(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ElastictranscoderPreset(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a ElastictranscoderPreset resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the ElastictranscoderPreset to import.</param>
        /// <param name="importFromId">The id of the existing ElastictranscoderPreset that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the ElastictranscoderPreset to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the ElastictranscoderPreset to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastictranscoder_preset#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing ElastictranscoderPreset that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the ElastictranscoderPreset to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.ElastictranscoderPreset.ElastictranscoderPreset), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAudio", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.elastictranscoderPreset.ElastictranscoderPresetAudio\"}}]")]
        public virtual void PutAudio(aws.ElastictranscoderPreset.IElastictranscoderPresetAudio @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.ElastictranscoderPreset.IElastictranscoderPresetAudio)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAudioCodecOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.elastictranscoderPreset.ElastictranscoderPresetAudioCodecOptions\"}}]")]
        public virtual void PutAudioCodecOptions(aws.ElastictranscoderPreset.IElastictranscoderPresetAudioCodecOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.ElastictranscoderPreset.IElastictranscoderPresetAudioCodecOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putThumbnails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.elastictranscoderPreset.ElastictranscoderPresetThumbnails\"}}]")]
        public virtual void PutThumbnails(aws.ElastictranscoderPreset.IElastictranscoderPresetThumbnails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.ElastictranscoderPreset.IElastictranscoderPresetThumbnails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVideo", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.elastictranscoderPreset.ElastictranscoderPresetVideo\"}}]")]
        public virtual void PutVideo(aws.ElastictranscoderPreset.IElastictranscoderPresetVideo @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.ElastictranscoderPreset.IElastictranscoderPresetVideo)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVideoWatermarks", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.elastictranscoderPreset.ElastictranscoderPresetVideoWatermarks\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutVideoWatermarks(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.ElastictranscoderPreset.IElastictranscoderPresetVideoWatermarks[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.ElastictranscoderPreset.IElastictranscoderPresetVideoWatermarks).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.ElastictranscoderPreset.IElastictranscoderPresetVideoWatermarks).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAudio")]
        public virtual void ResetAudio()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAudioCodecOptions")]
        public virtual void ResetAudioCodecOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
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

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetThumbnails")]
        public virtual void ResetThumbnails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetType")]
        public virtual void ResetType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVideo")]
        public virtual void ResetVideo()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVideoCodecOptions")]
        public virtual void ResetVideoCodecOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVideoWatermarks")]
        public virtual void ResetVideoWatermarks()
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
        = GetStaticProperty<string>(typeof(aws.ElastictranscoderPreset.ElastictranscoderPreset))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "audio", typeJson: "{\"fqn\":\"aws.elastictranscoderPreset.ElastictranscoderPresetAudioOutputReference\"}")]
        public virtual aws.ElastictranscoderPreset.ElastictranscoderPresetAudioOutputReference Audio
        {
            get => GetInstanceProperty<aws.ElastictranscoderPreset.ElastictranscoderPresetAudioOutputReference>()!;
        }

        [JsiiProperty(name: "audioCodecOptions", typeJson: "{\"fqn\":\"aws.elastictranscoderPreset.ElastictranscoderPresetAudioCodecOptionsOutputReference\"}")]
        public virtual aws.ElastictranscoderPreset.ElastictranscoderPresetAudioCodecOptionsOutputReference AudioCodecOptions
        {
            get => GetInstanceProperty<aws.ElastictranscoderPreset.ElastictranscoderPresetAudioCodecOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "thumbnails", typeJson: "{\"fqn\":\"aws.elastictranscoderPreset.ElastictranscoderPresetThumbnailsOutputReference\"}")]
        public virtual aws.ElastictranscoderPreset.ElastictranscoderPresetThumbnailsOutputReference Thumbnails
        {
            get => GetInstanceProperty<aws.ElastictranscoderPreset.ElastictranscoderPresetThumbnailsOutputReference>()!;
        }

        [JsiiProperty(name: "video", typeJson: "{\"fqn\":\"aws.elastictranscoderPreset.ElastictranscoderPresetVideoOutputReference\"}")]
        public virtual aws.ElastictranscoderPreset.ElastictranscoderPresetVideoOutputReference Video
        {
            get => GetInstanceProperty<aws.ElastictranscoderPreset.ElastictranscoderPresetVideoOutputReference>()!;
        }

        [JsiiProperty(name: "videoWatermarks", typeJson: "{\"fqn\":\"aws.elastictranscoderPreset.ElastictranscoderPresetVideoWatermarksList\"}")]
        public virtual aws.ElastictranscoderPreset.ElastictranscoderPresetVideoWatermarksList VideoWatermarks
        {
            get => GetInstanceProperty<aws.ElastictranscoderPreset.ElastictranscoderPresetVideoWatermarksList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "audioCodecOptionsInput", typeJson: "{\"fqn\":\"aws.elastictranscoderPreset.ElastictranscoderPresetAudioCodecOptions\"}", isOptional: true)]
        public virtual aws.ElastictranscoderPreset.IElastictranscoderPresetAudioCodecOptions? AudioCodecOptionsInput
        {
            get => GetInstanceProperty<aws.ElastictranscoderPreset.IElastictranscoderPresetAudioCodecOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "audioInput", typeJson: "{\"fqn\":\"aws.elastictranscoderPreset.ElastictranscoderPresetAudio\"}", isOptional: true)]
        public virtual aws.ElastictranscoderPreset.IElastictranscoderPresetAudio? AudioInput
        {
            get => GetInstanceProperty<aws.ElastictranscoderPreset.IElastictranscoderPresetAudio?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "containerInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ContainerInput
        {
            get => GetInstanceProperty<string?>();
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
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "thumbnailsInput", typeJson: "{\"fqn\":\"aws.elastictranscoderPreset.ElastictranscoderPresetThumbnails\"}", isOptional: true)]
        public virtual aws.ElastictranscoderPreset.IElastictranscoderPresetThumbnails? ThumbnailsInput
        {
            get => GetInstanceProperty<aws.ElastictranscoderPreset.IElastictranscoderPresetThumbnails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "videoCodecOptionsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? VideoCodecOptionsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "videoInput", typeJson: "{\"fqn\":\"aws.elastictranscoderPreset.ElastictranscoderPresetVideo\"}", isOptional: true)]
        public virtual aws.ElastictranscoderPreset.IElastictranscoderPresetVideo? VideoInput
        {
            get => GetInstanceProperty<aws.ElastictranscoderPreset.IElastictranscoderPresetVideo?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "videoWatermarksInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.elastictranscoderPreset.ElastictranscoderPresetVideoWatermarks\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? VideoWatermarksInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "container", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Container
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
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

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "videoCodecOptions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> VideoCodecOptions
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }
    }
}

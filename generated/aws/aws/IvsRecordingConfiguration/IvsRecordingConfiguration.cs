using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.IvsRecordingConfiguration
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ivs_recording_configuration aws_ivs_recording_configuration}.</summary>
    [JsiiClass(nativeType: typeof(aws.IvsRecordingConfiguration.IvsRecordingConfiguration), fullyQualifiedName: "aws.ivsRecordingConfiguration.IvsRecordingConfiguration", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.ivsRecordingConfiguration.IvsRecordingConfigurationConfig\"}}]")]
    public class IvsRecordingConfiguration : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ivs_recording_configuration aws_ivs_recording_configuration} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public IvsRecordingConfiguration(Constructs.Construct scope, string id, aws.IvsRecordingConfiguration.IIvsRecordingConfigurationConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.IvsRecordingConfiguration.IIvsRecordingConfigurationConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IvsRecordingConfiguration(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IvsRecordingConfiguration(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a IvsRecordingConfiguration resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the IvsRecordingConfiguration to import.</param>
        /// <param name="importFromId">The id of the existing IvsRecordingConfiguration that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the IvsRecordingConfiguration to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the IvsRecordingConfiguration to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ivs_recording_configuration#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing IvsRecordingConfiguration that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the IvsRecordingConfiguration to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.IvsRecordingConfiguration.IvsRecordingConfiguration), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putDestinationConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ivsRecordingConfiguration.IvsRecordingConfigurationDestinationConfiguration\"}}]")]
        public virtual void PutDestinationConfiguration(aws.IvsRecordingConfiguration.IIvsRecordingConfigurationDestinationConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.IvsRecordingConfiguration.IIvsRecordingConfigurationDestinationConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putThumbnailConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ivsRecordingConfiguration.IvsRecordingConfigurationThumbnailConfiguration\"}}]")]
        public virtual void PutThumbnailConfiguration(aws.IvsRecordingConfiguration.IIvsRecordingConfigurationThumbnailConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.IvsRecordingConfiguration.IIvsRecordingConfigurationThumbnailConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ivsRecordingConfiguration.IvsRecordingConfigurationTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.IvsRecordingConfiguration.IIvsRecordingConfigurationTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.IvsRecordingConfiguration.IIvsRecordingConfigurationTimeouts)}, new object[]{@value});
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

        [JsiiMethod(name: "resetRecordingReconnectWindowSeconds")]
        public virtual void ResetRecordingReconnectWindowSeconds()
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

        [JsiiMethod(name: "resetThumbnailConfiguration")]
        public virtual void ResetThumbnailConfiguration()
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
        = GetStaticProperty<string>(typeof(aws.IvsRecordingConfiguration.IvsRecordingConfiguration))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "destinationConfiguration", typeJson: "{\"fqn\":\"aws.ivsRecordingConfiguration.IvsRecordingConfigurationDestinationConfigurationOutputReference\"}")]
        public virtual aws.IvsRecordingConfiguration.IvsRecordingConfigurationDestinationConfigurationOutputReference DestinationConfiguration
        {
            get => GetInstanceProperty<aws.IvsRecordingConfiguration.IvsRecordingConfigurationDestinationConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "thumbnailConfiguration", typeJson: "{\"fqn\":\"aws.ivsRecordingConfiguration.IvsRecordingConfigurationThumbnailConfigurationOutputReference\"}")]
        public virtual aws.IvsRecordingConfiguration.IvsRecordingConfigurationThumbnailConfigurationOutputReference ThumbnailConfiguration
        {
            get => GetInstanceProperty<aws.IvsRecordingConfiguration.IvsRecordingConfigurationThumbnailConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.ivsRecordingConfiguration.IvsRecordingConfigurationTimeoutsOutputReference\"}")]
        public virtual aws.IvsRecordingConfiguration.IvsRecordingConfigurationTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.IvsRecordingConfiguration.IvsRecordingConfigurationTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "destinationConfigurationInput", typeJson: "{\"fqn\":\"aws.ivsRecordingConfiguration.IvsRecordingConfigurationDestinationConfiguration\"}", isOptional: true)]
        public virtual aws.IvsRecordingConfiguration.IIvsRecordingConfigurationDestinationConfiguration? DestinationConfigurationInput
        {
            get => GetInstanceProperty<aws.IvsRecordingConfiguration.IIvsRecordingConfigurationDestinationConfiguration?>();
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
        [JsiiProperty(name: "recordingReconnectWindowSecondsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? RecordingReconnectWindowSecondsInput
        {
            get => GetInstanceProperty<double?>();
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
        [JsiiProperty(name: "thumbnailConfigurationInput", typeJson: "{\"fqn\":\"aws.ivsRecordingConfiguration.IvsRecordingConfigurationThumbnailConfiguration\"}", isOptional: true)]
        public virtual aws.IvsRecordingConfiguration.IIvsRecordingConfigurationThumbnailConfiguration? ThumbnailConfigurationInput
        {
            get => GetInstanceProperty<aws.IvsRecordingConfiguration.IIvsRecordingConfigurationThumbnailConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.ivsRecordingConfiguration.IvsRecordingConfigurationTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
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

        [JsiiProperty(name: "recordingReconnectWindowSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RecordingReconnectWindowSeconds
        {
            get => GetInstanceProperty<double>()!;
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

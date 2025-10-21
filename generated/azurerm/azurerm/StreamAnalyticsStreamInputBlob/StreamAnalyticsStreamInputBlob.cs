using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StreamAnalyticsStreamInputBlob
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_stream_input_blob azurerm_stream_analytics_stream_input_blob}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.StreamAnalyticsStreamInputBlob.StreamAnalyticsStreamInputBlob), fullyQualifiedName: "azurerm.streamAnalyticsStreamInputBlob.StreamAnalyticsStreamInputBlob", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.streamAnalyticsStreamInputBlob.StreamAnalyticsStreamInputBlobConfig\"}}]")]
    public class StreamAnalyticsStreamInputBlob : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_stream_input_blob azurerm_stream_analytics_stream_input_blob} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public StreamAnalyticsStreamInputBlob(Constructs.Construct scope, string id, azurerm.StreamAnalyticsStreamInputBlob.IStreamAnalyticsStreamInputBlobConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.StreamAnalyticsStreamInputBlob.IStreamAnalyticsStreamInputBlobConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected StreamAnalyticsStreamInputBlob(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected StreamAnalyticsStreamInputBlob(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a StreamAnalyticsStreamInputBlob resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the StreamAnalyticsStreamInputBlob to import.</param>
        /// <param name="importFromId">The id of the existing StreamAnalyticsStreamInputBlob that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the StreamAnalyticsStreamInputBlob to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the StreamAnalyticsStreamInputBlob to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stream_analytics_stream_input_blob#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing StreamAnalyticsStreamInputBlob that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the StreamAnalyticsStreamInputBlob to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.StreamAnalyticsStreamInputBlob.StreamAnalyticsStreamInputBlob), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putSerialization", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.streamAnalyticsStreamInputBlob.StreamAnalyticsStreamInputBlobSerialization\"}}]")]
        public virtual void PutSerialization(azurerm.StreamAnalyticsStreamInputBlob.IStreamAnalyticsStreamInputBlobSerialization @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.StreamAnalyticsStreamInputBlob.IStreamAnalyticsStreamInputBlobSerialization)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.streamAnalyticsStreamInputBlob.StreamAnalyticsStreamInputBlobTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.StreamAnalyticsStreamInputBlob.IStreamAnalyticsStreamInputBlobTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.StreamAnalyticsStreamInputBlob.IStreamAnalyticsStreamInputBlobTimeouts)}, new object[]{@value});
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
        = GetStaticProperty<string>(typeof(azurerm.StreamAnalyticsStreamInputBlob.StreamAnalyticsStreamInputBlob))!;

        [JsiiProperty(name: "serialization", typeJson: "{\"fqn\":\"azurerm.streamAnalyticsStreamInputBlob.StreamAnalyticsStreamInputBlobSerializationOutputReference\"}")]
        public virtual azurerm.StreamAnalyticsStreamInputBlob.StreamAnalyticsStreamInputBlobSerializationOutputReference Serialization
        {
            get => GetInstanceProperty<azurerm.StreamAnalyticsStreamInputBlob.StreamAnalyticsStreamInputBlobSerializationOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.streamAnalyticsStreamInputBlob.StreamAnalyticsStreamInputBlobTimeoutsOutputReference\"}")]
        public virtual azurerm.StreamAnalyticsStreamInputBlob.StreamAnalyticsStreamInputBlobTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.StreamAnalyticsStreamInputBlob.StreamAnalyticsStreamInputBlobTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "dateFormatInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DateFormatInput
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
        [JsiiProperty(name: "pathPatternInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PathPatternInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceGroupNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResourceGroupNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serializationInput", typeJson: "{\"fqn\":\"azurerm.streamAnalyticsStreamInputBlob.StreamAnalyticsStreamInputBlobSerialization\"}", isOptional: true)]
        public virtual azurerm.StreamAnalyticsStreamInputBlob.IStreamAnalyticsStreamInputBlobSerialization? SerializationInput
        {
            get => GetInstanceProperty<azurerm.StreamAnalyticsStreamInputBlob.IStreamAnalyticsStreamInputBlobSerialization?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "storageAccountKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StorageAccountKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "storageAccountNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StorageAccountNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "storageContainerNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StorageContainerNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "streamAnalyticsJobNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StreamAnalyticsJobNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeFormatInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TimeFormatInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.streamAnalyticsStreamInputBlob.StreamAnalyticsStreamInputBlobTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "dateFormat", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DateFormat
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

        [JsiiProperty(name: "pathPattern", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PathPattern
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceGroupName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "storageAccountKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StorageAccountKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "storageAccountName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StorageAccountName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "storageContainerName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StorageContainerName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "streamAnalyticsJobName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StreamAnalyticsJobName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timeFormat", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeFormat
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
